using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Model;

namespace HelpDesk
{
    public partial class Frm_Login : Form
    {
        AcessoSqlServer acessoSqlServer = new AcessoSqlServer();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                int t = 0;
                Pessoa pessoa = new Pessoa();
                DataTable dataTablePessoas = new DataTable();

                acessoSqlServer.LimparParametros();

                dataTablePessoas = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM PESSOA");

                foreach (DataRow item in dataTablePessoas.Rows)
                {
                    if (item[1].ToString() == TxtLogin.Text)
                    {
                        if (item[2].ToString() == TxtSenha.Text)
                        {
                            pessoa.Id_pessoa = Convert.ToInt32(item[0]);
                            Frm_Principal principal = new Frm_Principal(this, pessoa);
                            principal.ShowDialog();
                            this.Close();
                        }
                    }
                    t++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível acessar sua conta!", ex.Message);
            }

        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
