using Control;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class Frm_Resposta : Form
    {
        AcessoSqlServer acessoSqlServer = new AcessoSqlServer();
        Pergunta pergunta = new Pergunta();

        public Frm_Resposta(Pergunta pergunta)
        {
            InitializeComponent();
            this.pergunta = pergunta;
        }

        private void CarregaNomeFuncionario()
        {
            acessoSqlServer.LimparParametros();
            DataTable dataTablePerguntas = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT nome FROM PESSOA WHERE id_pessoa = " + pergunta.Pessoa);

            foreach (DataRow linha in dataTablePerguntas.Rows)
            {
                TxtFuncionarioPergunta.Text = linha["nome"].ToString();
            }
        }
        private void AjustaBotoes()
        {
            acessoSqlServer.LimparParametros();
            DataTable dataTablePerguntas = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT nome FROM SETOR WHERE id_setor = " + pergunta.Setor);

            foreach (DataRow linha in dataTablePerguntas.Rows)
            {
                if (linha["nome"].ToString() == "OPERAÇÕES")
                {
                    BtnAdministrativo.Enabled = false;
                    BtnComercial.Enabled = false;
                    BtnTecnologia.Enabled = false;
                }
                else if (linha["nome"].ToString() == "ADMINISTRATIVO")
                {
                    BtnComercial.Enabled = false;
                    BtnOperacoes.Enabled = false;
                    BtnTecnologia.Enabled = false;
                }
                else if (linha["nome"].ToString() == "COMERCIAL")
                {
                    BtnAdministrativo.Enabled = false;
                    BtnOperacoes.Enabled = false;
                    BtnTecnologia.Enabled = false;
                }
                else if (linha["nome"].ToString() == "TECNOLOGIA")
                {
                    BtnAdministrativo.Enabled = false;
                    BtnComercial.Enabled = false;
                    BtnOperacoes.Enabled = false;
                }
                break;
            }
        }
        private void Frm_Resposta_Load(object sender, EventArgs e)
        {
            TxtTituloAssunto.Text = pergunta.Titulo;
            NupUrgencia.Value = Convert.ToInt32(pergunta.Dificuldade);
            CarregaNomeFuncionario();
            AjustaBotoes();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
