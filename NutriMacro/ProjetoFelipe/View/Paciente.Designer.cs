namespace ProjetoFelipe.View
{
    partial class Paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            txtPeso = new TextBox();
            label4 = new Label();
            txtSize = new TextBox();
            dgvPaciente = new DataGridView();
            groupBox1 = new GroupBox();
            btnFiltro = new Button();
            txtFiltro = new TextBox();
            cboFiltro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 16;
            label1.Text = "Nome";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 18;
            label2.Text = "Idade";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(12, 94);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 9);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 20;
            label3.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(118, 39);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 64);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 22;
            label4.Text = "Altura";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(118, 94);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(100, 23);
            txtSize.TabIndex = 23;
            // 
            // dgvPaciente
            // 
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaciente.Location = new Point(12, 123);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.RowTemplate.Height = 25;
            dgvPaciente.Size = new Size(560, 144);
            dgvPaciente.TabIndex = 24;
            dgvPaciente.CellMouseDoubleClick += dgvPaciente_CellMouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFiltro);
            groupBox1.Controls.Add(txtFiltro);
            groupBox1.Controls.Add(cboFiltro);
            groupBox1.Location = new Point(372, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnFiltro
            // 
            btnFiltro.Location = new Point(119, 70);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(75, 23);
            btnFiltro.TabIndex = 2;
            btnFiltro.Text = "Filtrar";
            btnFiltro.UseVisualStyleBackColor = true;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(6, 71);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(100, 23);
            txtFiltro.TabIndex = 1;
            // 
            // cboFiltro
            // 
            cboFiltro.FormattingEnabled = true;
            cboFiltro.Items.AddRange(new object[] { "Id", "Nome", "Idade" });
            cboFiltro.Location = new Point(6, 27);
            cboFiltro.Name = "cboFiltro";
            cboFiltro.Size = new Size(100, 23);
            cboFiltro.TabIndex = 0;
            // 
            // Paciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 337);
            Controls.Add(groupBox1);
            Controls.Add(dgvPaciente);
            Controls.Add(txtSize);
            Controls.Add(label4);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Paciente";
            Text = "CalculoIMC";
            Load += Paciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtPeso;
        private Label label4;
        private TextBox txtSize;
        private DataGridView dgvPaciente;
        private GroupBox groupBox1;
        private Button btnFiltro;
        private TextBox txtFiltro;
        private ComboBox cboFiltro;
    }
}