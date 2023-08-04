namespace HelpDesk
{
    partial class Frm_Pergunta
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
            groupBox1 = new GroupBox();
            BtnTecnologia = new Button();
            BtnComercial = new Button();
            BtnAdministrativo = new Button();
            BtnOperacoes = new Button();
            groupBox2 = new GroupBox();
            TxtPergunta = new TextBox();
            NupUrgencia = new NumericUpDown();
            TxtTituloAssunto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnEnviar = new Button();
            BtnCancelar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NupUrgencia).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnTecnologia);
            groupBox1.Controls.Add(BtnComercial);
            groupBox1.Controls.Add(BtnAdministrativo);
            groupBox1.Controls.Add(BtnOperacoes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 62);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Escolha qual departamento quer fazer a pergunta";
            // 
            // BtnTecnologia
            // 
            BtnTecnologia.AutoSize = true;
            BtnTecnologia.Location = new Point(363, 22);
            BtnTecnologia.Name = "BtnTecnologia";
            BtnTecnologia.Size = new Size(110, 25);
            BtnTecnologia.TabIndex = 7;
            BtnTecnologia.Text = "TECNOLOGIA";
            BtnTecnologia.UseVisualStyleBackColor = true;
            BtnTecnologia.Click += BtnTecnologia_Click;
            // 
            // BtnComercial
            // 
            BtnComercial.AutoSize = true;
            BtnComercial.Location = new Point(247, 22);
            BtnComercial.Name = "BtnComercial";
            BtnComercial.Size = new Size(110, 25);
            BtnComercial.TabIndex = 6;
            BtnComercial.Text = "COMERCIAL";
            BtnComercial.UseVisualStyleBackColor = true;
            BtnComercial.Click += BtnComercial_Click;
            // 
            // BtnAdministrativo
            // 
            BtnAdministrativo.AutoSize = true;
            BtnAdministrativo.Location = new Point(131, 22);
            BtnAdministrativo.Name = "BtnAdministrativo";
            BtnAdministrativo.Size = new Size(110, 25);
            BtnAdministrativo.TabIndex = 5;
            BtnAdministrativo.Text = "ADMINISTRATIVO";
            BtnAdministrativo.UseVisualStyleBackColor = true;
            BtnAdministrativo.Click += BtnAdministrativo_Click;
            // 
            // BtnOperacoes
            // 
            BtnOperacoes.AutoSize = true;
            BtnOperacoes.Location = new Point(15, 22);
            BtnOperacoes.Name = "BtnOperacoes";
            BtnOperacoes.Size = new Size(110, 25);
            BtnOperacoes.TabIndex = 4;
            BtnOperacoes.Text = "OPERAÇÕES";
            BtnOperacoes.UseVisualStyleBackColor = true;
            BtnOperacoes.Click += BtnOperacoes_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtPergunta);
            groupBox2.Controls.Add(NupUrgencia);
            groupBox2.Controls.Add(TxtTituloAssunto);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 327);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // TxtPergunta
            // 
            TxtPergunta.Location = new Point(6, 92);
            TxtPergunta.Multiline = true;
            TxtPergunta.Name = "TxtPergunta";
            TxtPergunta.Size = new Size(473, 229);
            TxtPergunta.TabIndex = 5;
            // 
            // NupUrgencia
            // 
            NupUrgencia.Location = new Point(415, 37);
            NupUrgencia.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            NupUrgencia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NupUrgencia.Name = "NupUrgencia";
            NupUrgencia.Size = new Size(64, 23);
            NupUrgencia.TabIndex = 4;
            NupUrgencia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TxtTituloAssunto
            // 
            TxtTituloAssunto.Location = new Point(6, 37);
            TxtTituloAssunto.Name = "TxtTituloAssunto";
            TxtTituloAssunto.Size = new Size(403, 23);
            TxtTituloAssunto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "PERGUNTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 19);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "URGENCIA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "TÍTULO/ASSUNTO";
            // 
            // BtnEnviar
            // 
            BtnEnviar.AutoSize = true;
            BtnEnviar.Location = new Point(387, 413);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(110, 25);
            BtnEnviar.TabIndex = 8;
            BtnEnviar.Text = "ENVIAR";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.AutoSize = true;
            BtnCancelar.Location = new Point(12, 413);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(132, 25);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "CANCELAR / FECHAR";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // Frm_Pergunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnEnviar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Pergunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cadastro de Pergunta";
            Load += Frm_Pergunta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NupUrgencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button BtnTecnologia;
        private Button BtnComercial;
        private Button BtnAdministrativo;
        private Button BtnOperacoes;
        private GroupBox groupBox2;
        private Button BtnEnviar;
        private TextBox TxtPergunta;
        private NumericUpDown NupUrgencia;
        private TextBox TxtTituloAssunto;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnCancelar;
    }
}