using Control;
using Model;
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
    public partial class Frm_Pergunta : Form
    {
        readonly AcessoSqlServer acessoSqlServer = new AcessoSqlServer();
        readonly Pessoa pessoa = new Pessoa();
        int botaoSelecionado = 0;
        public Frm_Pergunta(int codPessoa)
        {
            InitializeComponent();
            pessoa.Id_pessoa = codPessoa;
        }

        private void Frm_Pergunta_Load(object sender, EventArgs e)
        {

        }

        private void BtnOperacoes_Click(object sender, EventArgs e)
        {
            botaoSelecionado = 1;
            BtnAdministrativo.Enabled = false;
            BtnComercial.Enabled = false;
            BtnTecnologia.Enabled = false;
        }

        private void BtnAdministrativo_Click(object sender, EventArgs e)
        {
            botaoSelecionado = 2;
            BtnOperacoes.Enabled = false;
            BtnComercial.Enabled = false;
            BtnTecnologia.Enabled = false;
        }

        private void BtnComercial_Click(object sender, EventArgs e)
        {
            botaoSelecionado = 3;
            BtnOperacoes.Enabled = false;
            BtnAdministrativo.Enabled = false;
            BtnTecnologia.Enabled = false;
        }

        private void BtnTecnologia_Click(object sender, EventArgs e)
        {
            botaoSelecionado = 4;
            BtnOperacoes.Enabled = false;
            BtnAdministrativo.Enabled = false;
            BtnComercial.Enabled = false;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (botaoSelecionado != 0)
            {
                if (TxtPergunta.Text != "" && NupUrgencia.Value != 0 && TxtTituloAssunto.Text != "")
                {
                    acessoSqlServer.LimparParametros();
                    acessoSqlServer.ExecutarManipulacao(CommandType.Text, "INSERT INTO PERGUNTA (questao, dificuldade, pessoa, setor) VALUES ('" + TxtPergunta.Text + "', " + NupUrgencia.Value + ", " + pessoa.Id_pessoa + ", " + botaoSelecionado + ")");
                    MessageBox.Show("Pergunta inserida com sucesso!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione um botão.");
            }
        }
    }
}
