namespace ProjetoFelipe.View
{
    partial class CalculoIMC
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
            txtMacro = new TextBox();
            btnMacro = new Button();
            txtResult = new TextBox();
            btnResult = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtAge = new TextBox();
            label3 = new Label();
            txtPeso = new TextBox();
            label4 = new Label();
            txtSize = new TextBox();
            cbxPao = new CheckBox();
            cbxTapioca = new CheckBox();
            cbxSucri = new CheckBox();
            SuspendLayout();
            // 
            // txtMacro
            // 
            txtMacro.Location = new Point(354, 181);
            txtMacro.Margin = new Padding(6);
            txtMacro.Name = "txtMacro";
            txtMacro.Size = new Size(100, 23);
            txtMacro.TabIndex = 15;
            // 
            // btnMacro
            // 
            btnMacro.Location = new Point(175, 164);
            btnMacro.Name = "btnMacro";
            btnMacro.Size = new Size(144, 55);
            btnMacro.TabIndex = 14;
            btnMacro.Text = "Calculo Macro";
            btnMacro.UseVisualStyleBackColor = true;
            btnMacro.Click += btnMacro_Click_1;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(354, 71);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 13;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(175, 54);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(144, 55);
            btnResult.TabIndex = 12;
            btnResult.Text = "Calculo IMC";
            btnResult.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 16;
            label1.Text = "Nome";
            // 
            // txtName
            // 
            txtName.Location = new Point(40, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 80);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 18;
            label2.Text = "Idade";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(40, 98);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 132);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 20;
            label3.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(40, 150);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 186);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 22;
            label4.Text = "Altura";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(40, 214);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(100, 23);
            txtSize.TabIndex = 23;
            // 
            // cbxPao
            // 
            cbxPao.AutoSize = true;
            cbxPao.Location = new Point(54, 259);
            cbxPao.Name = "cbxPao";
            cbxPao.Size = new Size(46, 19);
            cbxPao.TabIndex = 24;
            cbxPao.Text = "Pão";
            cbxPao.UseVisualStyleBackColor = true;
            cbxPao.CheckedChanged += cbxPao_CheckedChanged;
            // 
            // cbxTapioca
            // 
            cbxTapioca.AutoSize = true;
            cbxTapioca.Location = new Point(166, 259);
            cbxTapioca.Name = "cbxTapioca";
            cbxTapioca.Size = new Size(66, 19);
            cbxTapioca.TabIndex = 25;
            cbxTapioca.Text = "Tapioca";
            cbxTapioca.UseVisualStyleBackColor = true;
            // 
            // cbxSucri
            // 
            cbxSucri.AutoSize = true;
            cbxSucri.Location = new Point(272, 259);
            cbxSucri.Name = "cbxSucri";
            cbxSucri.Size = new Size(73, 19);
            cbxSucri.TabIndex = 26;
            cbxSucri.Text = "Secrilhos";
            cbxSucri.UseVisualStyleBackColor = true;
            // 
            // CalculoIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 337);
            Controls.Add(cbxSucri);
            Controls.Add(cbxTapioca);
            Controls.Add(cbxPao);
            Controls.Add(txtSize);
            Controls.Add(label4);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtMacro);
            Controls.Add(btnMacro);
            Controls.Add(txtResult);
            Controls.Add(btnResult);
            Name = "CalculoIMC";
            Text = "CalculoIMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMacro;
        private Button btnMacro;
        private TextBox txtResult;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtAge;
        private Label label3;
        private TextBox txtPeso;
        private Label label4;
        private TextBox txtSize;
        private CheckBox cbxPao;
        private CheckBox cbxTapioca;
        private CheckBox cbxSucri;
        public Button btnResult;
    }
}