namespace HelpDesk
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            BtnAcessar = new Button();
            TxtSenha = new TextBox();
            TxtLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnFechar = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnAcessar
            // 
            BtnAcessar.Location = new Point(187, 80);
            BtnAcessar.Name = "BtnAcessar";
            BtnAcessar.Size = new Size(75, 23);
            BtnAcessar.TabIndex = 0;
            BtnAcessar.Text = "Acessar";
            BtnAcessar.UseVisualStyleBackColor = true;
            BtnAcessar.Click += BtnAcessar_Click;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(58, 51);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(285, 23);
            TxtSenha.TabIndex = 1;
            // 
            // TxtLogin
            // 
            TxtLogin.Location = new Point(58, 22);
            TxtLogin.Name = "TxtLogin";
            TxtLogin.Size = new Size(285, 23);
            TxtLogin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(15, 59);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(268, 80);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(75, 23);
            BtnFechar.TabIndex = 5;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtLogin);
            groupBox1.Controls.Add(BtnFechar);
            groupBox1.Controls.Add(BtnAcessar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtSenha);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 119);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(55, 115);
            label3.Name = "label3";
            label3.Size = new Size(318, 21);
            label3.TabIndex = 7;
            label3.Text = "BEM VINDO AO HELPDESK, COLABORADOR";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(88, 153);
            label4.Name = "label4";
            label4.Size = new Size(237, 21);
            label4.TabIndex = 8;
            label4.Text = "SUA PLATAFORMA DE DÚVIDAS.";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 84, 123);
            ClientSize = new Size(417, 321);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAcessar;
        private TextBox TxtSenha;
        private TextBox TxtLogin;
        private Label label1;
        private Label label2;
        private Button BtnFechar;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}