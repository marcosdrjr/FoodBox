using FoodBoxLibrary.Models.DTOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodBoxWindForms.Business;

namespace FoodBoxWindForms
{
    public partial class Home : Form
    {
        public List<SnacksDTO> Snacks { get; set; }
        public List<ProductDTO> Product { get; set; }
        public List<ProductSnacksDTO> IngredientsSnacks { get; set; }
        public List<RequestsSolicitationCodeDTO> RequestsSolicitation { get; set; }

        public Home()
        {
            Snacks = Integra.GetLisSnacks();
            Product = Integra.GetLisProducts();
            RequestsSolicitation = Integra.GetLisRequestsSolicitation();
            IngredientsSnacks = null;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var snacks = this.Snacks;
            var product = this.Product;
            var requestsSolicitation = this.RequestsSolicitation;

            dataGridViewSnacks.DataSource = snacks;
            dataGridViewSnacks.AutoResizeColumns();
            dataGridViewSnacks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridViewRequests.DataSource = requestsSolicitation;
            dataGridViewRequests.AutoResizeColumns();
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            var listProd = new List<string>();
            product.ForEach(s => listProd.Add(s.name));
            cbxIngredients.DataSource = listProd;

            if (string.IsNullOrEmpty(txtCodes.Text))
                txtCodes.Text = "00000";
        }

        #region GridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedItems = dataGridView1.SelectedRows[0].DataBoundItem as ProductSnacksDTO;
                var comand = selectedItems.name.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Some error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        private void dataGridViewSnacks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedItems = dataGridViewSnacks.SelectedRows[0].DataBoundItem as SnacksDTO;
                var comand = selectedItems.name.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Some error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedItems = dataGridViewRequests.SelectedRows[0].DataBoundItem as RequestsSolicitationCodeDTO;
                if (this.dataGridViewRequests.SelectedRows.Count == 0) return;
                var comand = selectedItems.codes.ToString();
                comand = comand.PadLeft(6, '0');
                txtCodes.Text = comand = comand.PadLeft(6, '0');
                ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxqtdIngredients?.SelectedIndex == null) { MessageBox.Show("Value Qtd. ingredients is not null!"); return; }
            if (cbxqtdIngredients?.SelectedIndex < 0) { MessageBox.Show("Value Qtd. ingredients is not null!"); return; }
            if (cbxIngredients.SelectedItem == null) { MessageBox.Show("Value is not null!"); return; }

            int qtd;

            var ValidateQtd = int.TryParse(cbxqtdIngredients.SelectedItem.ToString(), out qtd);
            var ingredients = cbxIngredients.SelectedItem.ToString();

            var prod = Product.Where(p => p.name == ingredients).FirstOrDefault();

            var poductSnacksDTO = new ProductSnacksDTO(qtd, prod);
            var ingredientsSnacksTMP = new List<ProductSnacksDTO>();


            ingredientsSnacksTMP.Add(poductSnacksDTO);

            if (IngredientsSnacks == null)
                IngredientsSnacks = ingredientsSnacksTMP;
            else
            {
                //var validaritemDuplicado = ingredientsSnacks.Where(p => p.id_product == poductSnacksDTO.id_product).Count();
                //if (validaritemDuplicado > 0)
                //{
                //}
                IngredientsSnacks.Add(poductSnacksDTO);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = IngredientsSnacks;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0) { MessageBox.Show("Ingredients is not null!"); return; }
            double ValueProducts = 0, ValueFinale = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                var cust = row.DataBoundItem as ProductSnacksDTO;
                ValueProducts = cust.qtdProduct * cust.value;
                ValueFinale += ValueProducts;
            }
            if (ValueFinale > 0)
                txtCalculation.Text = ValueFinale.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalculation.Text = null;
            txtDescription.Text = null;
            txtName.Text = null;
            IngredientsSnacks = null;
            dataGridView1.DataSource = null;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0) { MessageBox.Show("Ingredients is not null!"); return; }
            if (string.IsNullOrEmpty(txtCalculation.Text)) { MessageBox.Show("Is not Calculation!"); return; }
            if (string.IsNullOrEmpty(txtName.Text)) { MessageBox.Show("Name is not null!"); return; }
            if (string.IsNullOrEmpty(txtDescription.Text)) { MessageBox.Show("Description is not null!"); return; }

            var listProductSnacks = new List<ProductSnacksDTO>();
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                listProductSnacks.Add(row.DataBoundItem as ProductSnacksDTO);
            }

            double calculation;
            double.TryParse(txtCalculation.Text, out calculation);

            var solicitationProductSnacks = new SolicitationProductSnacksDTO(txtName.Text, txtDescription.Text, calculation, listProductSnacks);
            var postSnacks = Integra.PostSnacks(solicitationProductSnacks);
            if (postSnacks == null) { MessageBox.Show("Error you solicitation!"); return; }
            if (postSnacks.code <= 0) { MessageBox.Show("Error you solicitation!"); return; }

            var requestsSolicitation = new RequestsSolicitationDTO(postSnacks.code.ToString().PadLeft(6, '0'), postSnacks.name, postSnacks.description);
            txtCodes.Text = requestsSolicitation.codes;

            RequestsSolicitation = Integra.GetLisRequestsSolicitation();
            var requestsSolicitation2 = this.RequestsSolicitation;
            dataGridViewRequests.DataSource = requestsSolicitation2;
            dataGridViewRequests.AutoResizeColumns();
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRequests.Update();
            dataGridViewRequests.Refresh();


            txtCalculation.Text = null;
            txtDescription.Text = null;
            txtName.Text = null;
            IngredientsSnacks = null;
            dataGridView1.DataSource = null;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
