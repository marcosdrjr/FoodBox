
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewSnacks = new System.Windows.Forms.DataGridView();
            this.foodBoxDBDataSet = new FoodBoxWindForms.FoodBoxDBDataSet();
            this.foodBoxDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodBoxDBDataSet1 = new FoodBoxWindForms.FoodBoxDBDataSet1();
            this.snacksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.snacksTableAdapter = new FoodBoxWindForms.FoodBoxDBDataSet1TableAdapters.snacksTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCodes = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(173, 354);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkedListBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 276);
            this.panel5.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(163, 268);
            this.checkedListBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.txtCodes);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 78);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(39, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "FoodBox";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(173, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 139);
            this.panel2.TabIndex = 1;
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
            this.dataGridView1.Size = new System.Drawing.Size(486, 139);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewSnacks);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(173, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 107);
            this.panel4.TabIndex = 2;
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
            this.dataGridViewSnacks.Size = new System.Drawing.Size(486, 107);
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
            this.label1.Location = new System.Drawing.Point(85, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 3);
            this.textBox2.MaxLength = 500;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 27);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(309, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(173, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(486, 108);
            this.panel6.TabIndex = 9;
            // 
            // txtCodes
            // 
            this.txtCodes.Location = new System.Drawing.Point(27, 33);
            this.txtCodes.Name = "txtCodes";
            this.txtCodes.Size = new System.Drawing.Size(100, 27);
            this.txtCodes.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(659, 354);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewSnacks;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCodes;
    }
}

