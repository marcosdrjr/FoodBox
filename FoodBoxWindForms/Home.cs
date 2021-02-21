using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodBoxWindForms
{
    public partial class Home : Form
    {
        public List<SnacksDTO> Snacks { get; set; }
        public Home()
        {
            Snacks = GetSnacks();
            InitializeComponent();
        }

        private List<SnacksDTO> GetSnacks()
        {
            var list = new List<SnacksDTO>();
            list.Add(new SnacksDTO()
            {
                name = "Lanche 1",
                description = "teste"
            });
            list.Add(new SnacksDTO()
            {
                name = "Lanche 2",
                description = "teste"
            });
            list.Add(new SnacksDTO()
            {
                name = "Lanche 3",
                description = "teste"
            });
            return list;
        }

        private void Home_Load(object sender, EventArgs e)
        {   
            var snacks = this.Snacks;
            dataGridView1.DataSource = snacks;
            if (string.IsNullOrEmpty(txtCodes.Text))
                txtCodes.Text = "00000";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selctedSnacksDTO = dataGridView1.SelectedRows[0].DataBoundItem as SnacksDTO;
                var comand = selctedSnacksDTO.name.ToString();
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
                var selctedSnacksDTO = dataGridViewSnacks.SelectedRows[0].DataBoundItem as SnacksDTO;
                var comand = selctedSnacksDTO.name.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Some error occured: " + ex.Message + " - " + ex.Source);
            }
        }
    }

    public class SnacksDTO
    {
        public string name { get; set; }
        public string description { get; set; }
    }
}
