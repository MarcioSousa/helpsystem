namespace HelpDesk
{
    partial class Frm_Resposta
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
            BtnCancelar = new Button();
            BtnEnviar = new Button();
            groupBox2 = new GroupBox();
            LblFuncionario = new Label();
            TxtResposta = new TextBox();
            label3 = new Label();
            NupUrgencia = new NumericUpDown();
            TxtTituloAssunto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            BtnTecnologia = new Button();
            TxtFuncionarioPergunta = new TextBox();
            BtnComercial = new Button();
            BtnAdministrativo = new Button();
            BtnOperacoes = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NupUrgencia).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.AutoSize = true;
            BtnCancelar.Location = new Point(12, 480);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(132, 25);
            BtnCancelar.TabIndex = 13;
            BtnCancelar.Text = "CANCELAR / FECHAR";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnEnviar
            // 
            BtnEnviar.AutoSize = true;
            BtnEnviar.Location = new Point(387, 480);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(110, 25);
            BtnEnviar.TabIndex = 12;
            BtnEnviar.Text = "ENVIAR";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LblFuncionario);
            groupBox2.Controls.Add(TxtResposta);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 321);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // LblFuncionario
            // 
            LblFuncionario.AutoSize = true;
            LblFuncionario.Location = new Point(232, 19);
            LblFuncionario.Name = "LblFuncionario";
            LblFuncionario.Size = new Size(38, 15);
            LblFuncionario.TabIndex = 15;
            LblFuncionario.Text = "label5";
            // 
            // TxtResposta
            // 
            TxtResposta.Location = new Point(6, 37);
            TxtResposta.Multiline = true;
            TxtResposta.Name = "TxtResposta";
            TxtResposta.Size = new Size(473, 278);
            TxtResposta.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(220, 15);
            label3.TabIndex = 2;
            label3.Text = "RESPOSTA VINDA DO FUNCIONÁRIO(A):";
            // 
            // NupUrgencia
            // 
            NupUrgencia.Enabled = false;
            NupUrgencia.Location = new Point(415, 97);
            NupUrgencia.Name = "NupUrgencia";
            NupUrgencia.Size = new Size(64, 23);
            NupUrgencia.TabIndex = 4;
            // 
            // TxtTituloAssunto
            // 
            TxtTituloAssunto.Enabled = false;
            TxtTituloAssunto.Location = new Point(6, 97);
            TxtTituloAssunto.Name = "TxtTituloAssunto";
            TxtTituloAssunto.Size = new Size(403, 23);
            TxtTituloAssunto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 79);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "URGENCIA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 79);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "TÍTULO/ASSUNTO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnTecnologia);
            groupBox1.Controls.Add(NupUrgencia);
            groupBox1.Controls.Add(TxtFuncionarioPergunta);
            groupBox1.Controls.Add(TxtTituloAssunto);
            groupBox1.Controls.Add(BtnComercial);
            groupBox1.Controls.Add(BtnAdministrativo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(BtnOperacoes);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 135);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do Funcionário que está com dúvidas";
            // 
            // BtnTecnologia
            // 
            BtnTecnologia.AutoSize = true;
            BtnTecnologia.Location = new Point(360, 51);
            BtnTecnologia.Name = "BtnTecnologia";
            BtnTecnologia.Size = new Size(110, 25);
            BtnTecnologia.TabIndex = 7;
            BtnTecnologia.Text = "TECNOLOGIA";
            BtnTecnologia.UseVisualStyleBackColor = true;
            // 
            // TxtFuncionarioPergunta
            // 
            TxtFuncionarioPergunta.Enabled = false;
            TxtFuncionarioPergunta.Location = new Point(6, 22);
            TxtFuncionarioPergunta.Name = "TxtFuncionarioPergunta";
            TxtFuncionarioPergunta.Size = new Size(473, 23);
            TxtFuncionarioPergunta.TabIndex = 17;
            // 
            // BtnComercial
            // 
            BtnComercial.AutoSize = true;
            BtnComercial.Location = new Point(244, 51);
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
            BtnAdministrativo.Location = new Point(128, 51);
            BtnAdministrativo.Name = "BtnAdministrativo";
            BtnAdministrativo.Size = new Size(110, 25);
            BtnAdministrativo.TabIndex = 5;
            BtnAdministrativo.Text = "ADMINISTRATIVO";
            BtnAdministrativo.UseVisualStyleBackColor = true;
            // 
            // BtnOperacoes
            // 
            BtnOperacoes.AutoSize = true;
            BtnOperacoes.Location = new Point(12, 51);
            BtnOperacoes.Name = "BtnOperacoes";
            BtnOperacoes.Size = new Size(110, 25);
            BtnOperacoes.TabIndex = 4;
            BtnOperacoes.Text = "OPERAÇÕES";
            BtnOperacoes.UseVisualStyleBackColor = true;
            // 
            // Frm_Resposta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 509);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnEnviar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Resposta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Respostas";
            Load += Frm_Resposta_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NupUrgencia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnEnviar;
        private GroupBox groupBox2;
        private TextBox TxtResposta;
        private NumericUpDown NupUrgencia;
        private TextBox TxtTituloAssunto;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Button BtnTecnologia;
        private Button BtnComercial;
        private Button BtnAdministrativo;
        private Button BtnOperacoes;
        private TextBox TxtFuncionarioPergunta;
        private Label LblFuncionario;
    }
}