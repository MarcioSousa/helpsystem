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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BtnPergunta = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            DgvPrincipal = new DataGridView();
            Column1 = new DataGridViewImageColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewImageColumn();
            groupBox1 = new GroupBox();
            PbxExtrelas = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvPrincipal).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbxExtrelas).BeginInit();
            SuspendLayout();
            // 
            // BtnPergunta
            // 
            BtnPergunta.AutoSize = true;
            BtnPergunta.Location = new Point(36, 15);
            BtnPergunta.Name = "BtnPergunta";
            BtnPergunta.Size = new Size(110, 25);
            BtnPergunta.TabIndex = 0;
            BtnPergunta.Text = "OPERAÇÕES";
            BtnPergunta.UseVisualStyleBackColor = true;
            BtnPergunta.Click += BtnPergunta_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(152, 15);
            button1.Name = "button1";
            button1.Size = new Size(110, 25);
            button1.TabIndex = 1;
            button1.Text = "ADMINISTRATIVO";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(268, 15);
            button2.Name = "button2";
            button2.Size = new Size(110, 25);
            button2.TabIndex = 2;
            button2.Text = "COMERCIAL";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(384, 15);
            button3.Name = "button3";
            button3.Size = new Size(110, 25);
            button3.TabIndex = 3;
            button3.Text = "TECNOLOGIA";
            button3.UseVisualStyleBackColor = true;
            // 
            // DgvPrincipal
            // 
            DgvPrincipal.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPrincipal.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPrincipal.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPrincipal.Location = new Point(12, 51);
            DgvPrincipal.Name = "DgvPrincipal";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvPrincipal.RowHeadersVisible = false;
            DgvPrincipal.RowTemplate.Height = 25;
            DgvPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPrincipal.Size = new Size(552, 382);
            DgvPrincipal.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 300;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PbxExtrelas);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(570, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 421);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // PbxExtrelas
            // 
            PbxExtrelas.Image = Properties.Resources.duasestrelas;
            PbxExtrelas.Location = new Point(306, 19);
            PbxExtrelas.Name = "PbxExtrelas";
            PbxExtrelas.Size = new Size(122, 26);
            PbxExtrelas.SizeMode = PictureBoxSizeMode.Zoom;
            PbxExtrelas.TabIndex = 2;
            PbxExtrelas.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "ASSUNTO/TÍTULO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 102);
            textBox1.TabIndex = 0;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 445);
            Controls.Add(groupBox1);
            Controls.Add(DgvPrincipal);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnPergunta);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário Principal";
            Load += Frm_Principal_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPrincipal).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbxExtrelas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnPergunta;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView DgvPrincipal;
        private GroupBox groupBox1;
        private PictureBox PbxExtrelas;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Column4;
    }
}