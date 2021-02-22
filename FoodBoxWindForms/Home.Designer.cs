
namespace FoodBoxWindForms
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDeliverSnack = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCodes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dataGridViewSnacks = new System.Windows.Forms.DataGridView();
            this.foodBoxDBDataSet = new FoodBoxWindForms.FoodBoxDBDataSet();
            this.foodBoxDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodBoxDBDataSet1 = new FoodBoxWindForms.FoodBoxDBDataSet1();
            this.snacksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.snacksTableAdapter = new FoodBoxWindForms.FoodBoxDBDataSet1TableAdapters.snacksTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.txtCalculation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQtdIngredients = new System.Windows.Forms.Label();
            this.cbxqtdIngredients = new System.Windows.Forms.ComboBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxIngredients = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSnacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBoxDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBoxDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBoxDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snacksBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 495);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 417);
            this.panel5.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnDeliverSnack);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 339);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(173, 78);
            this.panel8.TabIndex = 1;
            // 
            // btnDeliverSnack
            // 
            this.btnDeliverSnack.Location = new System.Drawing.Point(-6, 3);
            this.btnDeliverSnack.Name = "btnDeliverSnack";
            this.btnDeliverSnack.Size = new System.Drawing.Size(179, 44);
            this.btnDeliverSnack.TabIndex = 10;
            this.btnDeliverSnack.Text = "Deliver Snack";
            this.btnDeliverSnack.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(173, 339);
            this.panel7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Requests";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dataGridViewRequests);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 42);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(173, 297);
            this.panel11.TabIndex = 1;
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.AllowUserToAddRows = false;
            this.dataGridViewRequests.AllowUserToDeleteRows = false;
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRequests.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.ReadOnly = true;
            this.dataGridViewRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRequests.Size = new System.Drawing.Size(173, 297);
            this.dataGridViewRequests.TabIndex = 0;
            this.dataGridViewRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.txtCodes);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 78);
            this.panel3.TabIndex = 0;
            // 
            // txtCodes
            // 
            this.txtCodes.Location = new System.Drawing.Point(27, 33);
            this.txtCodes.Name = "txtCodes";
            this.txtCodes.Size = new System.Drawing.Size(100, 27);
            this.txtCodes.TabIndex = 1;
            this.txtCodes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(39, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "FoodBox";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(173, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 187);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingreditents Selected";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridView1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 27);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1100, 160);
            this.panel9.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 160);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(173, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1100, 180);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Snacks Default";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dataGridViewSnacks);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 33);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1100, 147);
            this.panel10.TabIndex = 1;
            // 
            // dataGridViewSnacks
            // 
            this.dataGridViewSnacks.AllowUserToAddRows = false;
            this.dataGridViewSnacks.AllowUserToDeleteRows = false;
            this.dataGridViewSnacks.AllowUserToOrderColumns = true;
            this.dataGridViewSnacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSnacks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSnacks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSnacks.Name = "dataGridViewSnacks";
            this.dataGridViewSnacks.ReadOnly = true;
            this.dataGridViewSnacks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSnacks.Size = new System.Drawing.Size(1100, 147);
            this.dataGridViewSnacks.TabIndex = 0;
            this.dataGridViewSnacks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSnacks_CellContentClick);
            // 
            // foodBoxDBDataSet
            // 
            this.foodBoxDBDataSet.DataSetName = "FoodBoxDBDataSet";
            this.foodBoxDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodBoxDBDataSetBindingSource
            // 
            this.foodBoxDBDataSetBindingSource.DataSource = this.foodBoxDBDataSet;
            this.foodBoxDBDataSetBindingSource.Position = 0;
            // 
            // foodBoxDBDataSet1
            // 
            this.foodBoxDBDataSet1.DataSetName = "FoodBoxDBDataSet1";
            this.foodBoxDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // snacksBindingSource
            // 
            this.snacksBindingSource.DataMember = "snacks";
            this.snacksBindingSource.DataSource = this.foodBoxDBDataSet1;
            // 
            // snacksTableAdapter
            // 
            this.snacksTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(359, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 27);
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(767, 50);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(321, 27);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(767, 86);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClear);
            this.panel6.Controls.Add(this.btnCalculation);
            this.panel6.Controls.Add(this.txtCalculation);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.lblQtdIngredients);
            this.panel6.Controls.Add(this.cbxqtdIngredients);
            this.panel6.Controls.Add(this.lblIngredients);
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Controls.Add(this.cbxIngredients);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Controls.Add(this.txtName);
            this.panel6.Controls.Add(this.txtDescription);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(173, 180);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1100, 128);
            this.panel6.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(359, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(245, 36);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(111, 86);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(173, 36);
            this.btnCalculation.TabIndex = 15;
            this.btnCalculation.Text = "Calculation";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // txtCalculation
            // 
            this.txtCalculation.Enabled = false;
            this.txtCalculation.Location = new System.Drawing.Point(111, 50);
            this.txtCalculation.Name = "txtCalculation";
            this.txtCalculation.Size = new System.Drawing.Size(174, 27);
            this.txtCalculation.TabIndex = 14;
            this.txtCalculation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Value $:";
            // 
            // lblQtdIngredients
            // 
            this.lblQtdIngredients.AutoSize = true;
            this.lblQtdIngredients.Location = new System.Drawing.Point(619, 11);
            this.lblQtdIngredients.Name = "lblQtdIngredients";
            this.lblQtdIngredients.Size = new System.Drawing.Size(142, 21);
            this.lblQtdIngredients.TabIndex = 12;
            this.lblQtdIngredients.Text = "Qtd. Ingredients:";
            // 
            // cbxqtdIngredients
            // 
            this.cbxqtdIngredients.FormattingEnabled = true;
            this.cbxqtdIngredients.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxqtdIngredients.Location = new System.Drawing.Point(767, 11);
            this.cbxqtdIngredients.Name = "cbxqtdIngredients";
            this.cbxqtdIngredients.Size = new System.Drawing.Size(164, 29);
            this.cbxqtdIngredients.TabIndex = 11;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(3, 11);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(102, 21);
            this.lblIngredients.TabIndex = 10;
            this.lblIngredients.Text = "Ingredients:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(938, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxIngredients
            // 
            this.cbxIngredients.FormattingEnabled = true;
            this.cbxIngredients.Location = new System.Drawing.Point(111, 8);
            this.cbxIngredients.Name = "cbxIngredients";
            this.cbxIngredients.Size = new System.Drawing.Size(493, 29);
            this.cbxIngredients.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1273, 495);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSnacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBoxDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBoxDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBoxDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snacksBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource foodBoxDBDataSetBindingSource;
        private FoodBoxDBDataSet foodBoxDBDataSet;
        private FoodBoxDBDataSet1 foodBoxDBDataSet1;
        private System.Windows.Forms.BindingSource snacksBindingSource;
        private FoodBoxDBDataSet1TableAdapters.snacksTableAdapter snacksTableAdapter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewSnacks;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCodes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDeliverSnack;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblQtdIngredients;
        private System.Windows.Forms.ComboBox cbxqtdIngredients;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxIngredients;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.TextBox txtCalculation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
    }
}

