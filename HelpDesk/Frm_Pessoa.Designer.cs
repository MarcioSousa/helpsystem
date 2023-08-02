namespace HelpDesk
{
    partial class Frm_Pessoa
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
            BtnCadastrar = new Button();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnConfirmar = new Button();
            BtnCancelar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            TxtNome = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            DgvPessoas = new DataGridView();
            TxtSenha = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPessoas).BeginInit();
            SuspendLayout();
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(6, 22);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(75, 23);
            BtnCadastrar.TabIndex = 0;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(87, 22);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(75, 23);
            BtnEditar.TabIndex = 1;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(168, 22);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(75, 23);
            BtnExcluir.TabIndex = 2;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(247, 81);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(75, 28);
            BtnConfirmar.TabIndex = 3;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(328, 81);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 28);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSenha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(BtnCancelar);
            groupBox1.Controls.Add(BtnConfirmar);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 120);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(6, 34);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(397, 23);
            TxtNome.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnCadastrar);
            groupBox2.Controls.Add(BtnEditar);
            groupBox2.Controls.Add(BtnExcluir);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(409, 59);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DgvPessoas);
            groupBox3.Location = new Point(12, 203);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(409, 235);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // DgvPessoas
            // 
            DgvPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPessoas.Location = new Point(6, 22);
            DgvPessoas.Name = "DgvPessoas";
            DgvPessoas.RowTemplate.Height = 25;
            DgvPessoas.Size = new Size(397, 207);
            DgvPessoas.TabIndex = 0;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(6, 86);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(235, 23);
            TxtSenha.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Senha";
            // 
            // Frm_Pessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Frm_Pessoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cadastro de Pessoas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvPessoas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCadastrar;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnConfirmar;
        private Button BtnCancelar;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox TxtNome;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView DgvPessoas;
        private TextBox TxtSenha;
        private Label label2;
    }
}