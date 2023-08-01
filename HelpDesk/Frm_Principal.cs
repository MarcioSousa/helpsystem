using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal(Form login)
        {
            InitializeComponent();
            login.Visible = false;
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            DgvPrincipal.Rows.Add();

            DataGridViewImageColumn fotoum = new DataGridViewImageColumn();
            Image fotopessoaum = Image.FromFile("C:\\Users\\Marcio\\source\\repos\\HelpDesk\\HelpDesk\\Resources\\tresestrelas.png");
            fotoum.Image = fotopessoaum;

            DgvPrincipal.Rows[0].Cells[0].Value = fotoum.Image;
            DgvPrincipal.Rows[0].Cells[1].Value = "asdljfalçskd jflaksjdfçlaksjd flç kja sdçflkjaslçdf kjlçaskjdflçkjasdlkjfla ajsfdlk jaslçdk jflçkajs lk jalkja lkjaslk jflkasj lkj lkjlaç kjlçka jlkj lk";

            DataGridViewImageColumn imgum = new DataGridViewImageColumn();
            Image imageum = Image.FromFile("C:\\Users\\Marcio\\source\\repos\\HelpDesk\\HelpDesk\\Resources\\umaestrela.png");
            imgum.Image = imageum;
            DgvPrincipal.Rows[0].Cells[2].Value = imgum.Image;

        }

        private void BtnPergunta_Click(object sender, EventArgs e)
        {
            Frm_Pergunta pergunta = new Frm_Pergunta();
            pergunta.ShowDialog();
        }
    }
}
