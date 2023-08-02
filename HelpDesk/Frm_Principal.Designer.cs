namespace HelpDesk
{
    partial class Frm_Principal
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
            BtnOperacoes = new Button();
            BtnAdministrativo = new Button();
            BtnComercial = new Button();
            BtnTecnologia = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            LblFuncionario = new Label();
            DgvPerguntas = new DataGridView();
            ID_PERGUNTA = new DataGridViewTextBoxColumn();
            QUESTAO = new DataGridViewTextBoxColumn();
            DIFICULDADE = new DataGridViewTextBoxColumn();
            LblSetor = new Label();
            label4 = new Label();
            BtnNovaPergunta = new Button();
            LblCodigoFuncionario = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPerguntas).BeginInit();
            SuspendLayout();
            // 
            // BtnOperacoes
            // 
            BtnOperacoes.AutoSize = true;
            BtnOperacoes.Location = new Point(36, 24);
            BtnOperacoes.Name = "BtnOperacoes";
            BtnOperacoes.Size = new Size(110, 25);
            BtnOperacoes.TabIndex = 0;
            BtnOperacoes.Text = "OPERAÇÕES";
            BtnOperacoes.UseVisualStyleBackColor = true;
            BtnOperacoes.Click += BtnOperacoes_Click;
            // 
            // BtnAdministrativo
            // 
            BtnAdministrativo.AutoSize = true;
            BtnAdministrativo.Location = new Point(152, 24);
            BtnAdministrativo.Name = "BtnAdministrativo";
            BtnAdministrativo.Size = new Size(110, 25);
            BtnAdministrativo.TabIndex = 1;
            BtnAdministrativo.Text = "ADMINISTRATIVO";
            BtnAdministrativo.UseVisualStyleBackColor = true;
            BtnAdministrativo.Click += BtnAdministrativo_Click;
            // 
            // BtnComercial
            // 
            BtnComercial.AutoSize = true;
            BtnComercial.Location = new Point(268, 24);
            BtnComercial.Name = "BtnComercial";
            BtnComercial.Size = new Size(110, 25);
            BtnComercial.TabIndex = 2;
            BtnComercial.Text = "COMERCIAL";
            BtnComercial.UseVisualStyleBackColor = true;
            BtnComercial.Click += BtnComercial_Click;
            // 
            // BtnTecnologia
            // 
            BtnTecnologia.AutoSize = true;
            BtnTecnologia.Location = new Point(384, 24);
            BtnTecnologia.Name = "BtnTecnologia";
            BtnTecnologia.Size = new Size(110, 25);
            BtnTecnologia.TabIndex = 3;
            BtnTecnologia.Text = "TECNOLOGIA";
            BtnTecnologia.UseVisualStyleBackColor = true;
            BtnTecnologia.Click += BtnTecnologia_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(570, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 377);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "ASSUNTO/TÍTULO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 102);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 56);
            label2.Name = "label2";
            label2.Size = new Size(164, 21);
            label2.TabIndex = 6;
            label2.Text = "Nome do Funcionario:";
            // 
            // LblFuncionario
            // 
            LblFuncionario.AutoSize = true;
            LblFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblFuncionario.Location = new Point(192, 56);
            LblFuncionario.Name = "LblFuncionario";
            LblFuncionario.Size = new Size(161, 21);
            LblFuncionario.TabIndex = 7;
            LblFuncionario.Text = "Nome do Funcionario";
            // 
            // DgvPerguntas
            // 
            DgvPerguntas.AllowUserToAddRows = false;
            DgvPerguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPerguntas.Columns.AddRange(new DataGridViewColumn[] { ID_PERGUNTA, QUESTAO, DIFICULDADE });
            DgvPerguntas.Location = new Point(22, 119);
            DgvPerguntas.Name = "DgvPerguntas";
            DgvPerguntas.RowHeadersVisible = false;
            DgvPerguntas.RowTemplate.Height = 25;
            DgvPerguntas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPerguntas.Size = new Size(499, 282);
            DgvPerguntas.TabIndex = 8;
            // 
            // ID_PERGUNTA
            // 
            ID_PERGUNTA.DataPropertyName = "Id_pergunta";
            ID_PERGUNTA.HeaderText = "CÓDIGO";
            ID_PERGUNTA.Name = "ID_PERGUNTA";
            ID_PERGUNTA.ReadOnly = true;
            ID_PERGUNTA.Width = 70;
            // 
            // QUESTAO
            // 
            QUESTAO.DataPropertyName = "Questao";
            QUESTAO.HeaderText = "QUESTÃO";
            QUESTAO.Name = "QUESTAO";
            QUESTAO.ReadOnly = true;
            QUESTAO.Width = 310;
            // 
            // DIFICULDADE
            // 
            DIFICULDADE.DataPropertyName = "Dificuldade";
            DIFICULDADE.HeaderText = "DIFICULDADE";
            DIFICULDADE.Name = "DIFICULDADE";
            DIFICULDADE.ReadOnly = true;
            DIFICULDADE.Width = 90;
            // 
            // LblSetor
            // 
            LblSetor.AutoSize = true;
            LblSetor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblSetor.Location = new Point(331, 86);
            LblSetor.Name = "LblSetor";
            LblSetor.Size = new Size(116, 21);
            LblSetor.TabIndex = 10;
            LblSetor.Text = "Nome do Setor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(275, 86);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 9;
            label4.Text = "Setor:";
            // 
            // BtnNovaPergunta
            // 
            BtnNovaPergunta.AutoSize = true;
            BtnNovaPergunta.Location = new Point(411, 408);
            BtnNovaPergunta.Name = "BtnNovaPergunta";
            BtnNovaPergunta.Size = new Size(110, 25);
            BtnNovaPergunta.TabIndex = 11;
            BtnNovaPergunta.Text = "NOVA PERGUNTA";
            BtnNovaPergunta.UseVisualStyleBackColor = true;
            BtnNovaPergunta.Click += BtnNovaPergunta_Click;
            // 
            // LblCodigoFuncionario
            // 
            LblCodigoFuncionario.AutoSize = true;
            LblCodigoFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblCodigoFuncionario.Location = new Point(91, 86);
            LblCodigoFuncionario.Name = "LblCodigoFuncionario";
            LblCodigoFuncionario.Size = new Size(168, 21);
            LblCodigoFuncionario.TabIndex = 13;
            LblCodigoFuncionario.Text = "Código do Funcionário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 86);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 12;
            label5.Text = "Código:";
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 445);
            Controls.Add(LblCodigoFuncionario);
            Controls.Add(label5);
            Controls.Add(BtnNovaPergunta);
            Controls.Add(LblSetor);
            Controls.Add(label4);
            Controls.Add(DgvPerguntas);
            Controls.Add(LblFuncionario);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(BtnTecnologia);
            Controls.Add(BtnComercial);
            Controls.Add(BtnAdministrativo);
            Controls.Add(BtnOperacoes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário Principal";
            Load += Frm_Principal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPerguntas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnOperacoes;
        private Button BtnAdministrativo;
        private Button BtnComercial;
        private Button BtnTecnologia;
        private GroupBox groupBox1;
        private PictureBox PbxExtrelas;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label LblFuncionario;
        private DataGridView DgvPerguntas;
        private Label LblSetor;
        private Label label4;
        private DataGridViewTextBoxColumn ID_PERGUNTA;
        private DataGridViewTextBoxColumn QUESTAO;
        private DataGridViewTextBoxColumn DIFICULDADE;
        private Button BtnNovaPergunta;
        private Label LblCodigoFuncionario;
        private Label label5;
    }
}