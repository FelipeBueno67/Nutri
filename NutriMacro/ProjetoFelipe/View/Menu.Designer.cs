namespace ProjetoFelipe.View
{
    partial class Menu
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
            Button button3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            Button button4;
            Button button5;
            label5 = new Label();
            panel1 = new Panel();
            btnIMCMenu = new Button();
            btnPaciente = new Button();
            label6 = new Label();
            PainelCabecalho = new Panel();
            panelConteudo = new Panel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            PainelCabecalho.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(555, 3);
            button3.Name = "button3";
            button3.Size = new Size(36, 28);
            button3.TabIndex = 15;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.MouseOverBackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(597, 3);
            button4.Name = "button4";
            button4.Size = new Size(36, 28);
            button4.TabIndex = 14;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button5.FlatAppearance.MouseOverBackColor = Color.Red;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(639, 3);
            button5.Name = "button5";
            button5.Size = new Size(36, 28);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.PeachPuff;
            label5.Location = new Point(248, 9);
            label5.Name = "label5";
            label5.Padding = new Padding(6);
            label5.Size = new Size(279, 49);
            label5.TabIndex = 16;
            label5.Text = "Nutricionista Vitual";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.SeaShell;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnIMCMenu);
            panel1.Controls.Add(btnPaciente);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(1, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 376);
            panel1.TabIndex = 17;
            // 
            // btnIMCMenu
            // 
            btnIMCMenu.BackColor = Color.SeaShell;
            btnIMCMenu.FlatAppearance.BorderColor = Color.White;
            btnIMCMenu.FlatAppearance.BorderSize = 0;
            btnIMCMenu.FlatAppearance.MouseDownBackColor = Color.White;
            btnIMCMenu.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            btnIMCMenu.FlatStyle = FlatStyle.Flat;
            btnIMCMenu.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIMCMenu.ForeColor = Color.Chocolate;
            btnIMCMenu.Image = (Image)resources.GetObject("btnIMCMenu.Image");
            btnIMCMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnIMCMenu.Location = new Point(3, 121);
            btnIMCMenu.Name = "btnIMCMenu";
            btnIMCMenu.Size = new Size(167, 53);
            btnIMCMenu.TabIndex = 16;
            btnIMCMenu.Text = "Calculo";
            btnIMCMenu.TextAlign = ContentAlignment.MiddleRight;
            btnIMCMenu.UseVisualStyleBackColor = false;
            btnIMCMenu.Click += btnIMCMenu_Click;
            // 
            // btnPaciente
            // 
            btnPaciente.BackColor = Color.SeaShell;
            btnPaciente.FlatAppearance.BorderColor = Color.White;
            btnPaciente.FlatAppearance.BorderSize = 0;
            btnPaciente.FlatAppearance.MouseDownBackColor = Color.White;
            btnPaciente.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            btnPaciente.FlatStyle = FlatStyle.Flat;
            btnPaciente.Font = new Font("Cascadia Code", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnPaciente.ForeColor = Color.Chocolate;
            btnPaciente.Image = (Image)resources.GetObject("btnPaciente.Image");
            btnPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaciente.Location = new Point(3, 46);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(167, 53);
            btnPaciente.TabIndex = 14;
            btnPaciente.Text = "Paciente";
            btnPaciente.TextAlign = ContentAlignment.MiddleRight;
            btnPaciente.UseVisualStyleBackColor = false;
            btnPaciente.Click += btnPaciente_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(297, 4);
            label6.Name = "label6";
            label6.Padding = new Padding(6);
            label6.Size = new Size(120, 27);
            label6.TabIndex = 13;
            label6.Text = "Nutricionista Vitual";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // PainelCabecalho
            // 
            PainelCabecalho.BackColor = Color.Chocolate;
            PainelCabecalho.Controls.Add(label5);
            PainelCabecalho.Dock = DockStyle.Top;
            PainelCabecalho.Location = new Point(0, 0);
            PainelCabecalho.Name = "PainelCabecalho";
            PainelCabecalho.Size = new Size(778, 72);
            PainelCabecalho.TabIndex = 18;
            // 
            // panelConteudo
            // 
            panelConteudo.Location = new Point(178, 75);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(600, 376);
            panelConteudo.TabIndex = 19;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 452);
            Controls.Add(panelConteudo);
            Controls.Add(panel1);
            Controls.Add(PainelCabecalho);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PainelCabecalho.ResumeLayout(false);
            PainelCabecalho.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Panel panel1;
        private Button btnIMCMenu;
        private Button btnPaciente;
        private Label label6;
        private Panel PainelCabecalho;
        public Panel panelConteudo;
    }
}