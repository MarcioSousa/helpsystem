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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HelpDesk
{
    public partial class Frm_Principal : Form
    {
        readonly AcessoSqlServer acessoSqlServer = new AcessoSqlServer();
        readonly Pessoa pessoa = new Pessoa();
        readonly Setor setor = new Setor();

        public Frm_Principal(Form login, Pessoa pessoa)
        {
            InitializeComponent();
            DgvPerguntas.AutoGenerateColumns = false;
            login.Visible = false;
            this.pessoa = pessoa;
            pessoa = ProcurarPessoa(pessoa.Id_pessoa);
            setor = CarregaSetor(pessoa);
            LblFuncionario.Text = pessoa.Nome;
            LblSetor.Text = setor.Nome;
            LblCodigoFuncionario.Text = pessoa.Id_pessoa.ToString();
        }

        private Pessoa ProcurarPessoa(int? id_pessoa)
        {
            Pessoa pessoa = new Pessoa();
            DataTable dataTablePessoas = new DataTable();

            acessoSqlServer.LimparParametros();

            dataTablePessoas = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT id_pessoa, nome, senha, setor FROM PESSOA WHERE id_pessoa = " + id_pessoa);

            foreach (DataRow item in dataTablePessoas.Rows)
            {
                pessoa.Id_pessoa = Convert.ToInt32(item[0]);
                pessoa.Nome = item[1].ToString();
                pessoa.Senha = item[2].ToString();
                pessoa.Setor = Convert.ToInt32(item[3]);
            }

            return pessoa;
        }
        private Setor CarregaSetor(Pessoa pessoa)
        {
            Setor setor = new Setor();

            DataTable dataTableSetor = new DataTable();

            acessoSqlServer.LimparParametros();

            dataTableSetor = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT id_setor, nome FROM SETOR WHERE id_setor = " + pessoa.Setor);

            foreach (DataRow item in dataTableSetor.Rows)
            {
                setor.Id_setor = Convert.ToInt32(item[0]);
                setor.Nome = item[1].ToString();
            }

            return setor;
        }
        private void CarregaDataGrid()
        {
            List<Pergunta> perguntas = new List<Pergunta> { };

            acessoSqlServer.LimparParametros();
            DataTable dataTablePerguntas = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT id_pergunta, questao, dificuldade, pessoa FROM PERGUNTA");

            foreach (DataRow linha in dataTablePerguntas.Rows)
            {
                Pergunta pergunta = new Pergunta(Convert.ToInt32(linha["id_pergunta"]), linha["questao"].ToString(), Convert.ToInt32(linha["dificuldade"]));
                perguntas.Add(pergunta);
            }

            DgvPerguntas.DataSource = perguntas;

            DgvPerguntas.Update();
            DgvPerguntas.Refresh();
        }
        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }
        //private void BtnPergunta_Click(object sender, EventArgs e)
        //{
        //    //Frm_Pergunta pergunta = new Frm_Pergunta();
        //    //pergunta.ShowDialog();
        //    Filtrargem("");
        //}

        private void FiltrargemBotao(string? setor)
        {
            List<Pergunta> perguntas = new List<Pergunta> { };

            acessoSqlServer.LimparParametros();
            DataTable dataTablePerguntas = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT id_pergunta, questao, dificuldade, pessoa FROM PERGUNTA WHERE setor = 2");

            foreach (DataRow linha in dataTablePerguntas.Rows)
            {
                Pergunta pergunta = new Pergunta(Convert.ToInt32(linha["id_pergunta"]), linha["questao"].ToString(), Convert.ToInt32(linha["dificuldade"]));
                perguntas.Add(pergunta);
            }

            DgvPerguntas.DataSource = perguntas;

            DgvPerguntas.Update();
            DgvPerguntas.Refresh();
        }

        private void BtnOperacoes_Click(object sender, EventArgs e)
        {
            FiltrargemBotao("OPERAÇÕES");
        }

        private void BtnTecnologia_Click(object sender, EventArgs e)
        {
            FiltrargemBotao("TECNOLOGIA");
        }

        private void BtnAdministrativo_Click(object sender, EventArgs e)
        {
            FiltrargemBotao("ADMINISTRATIVO");
        }

        private void BtnComercial_Click(object sender, EventArgs e)
        {
            FiltrargemBotao("COMERCIAL");
        }

        private void BtnNovaPergunta_Click(object sender, EventArgs e)
        {
            Frm_Pergunta frm_Pergunta = new Frm_Pergunta(Convert.ToInt32(LblCodigoFuncionario.Text));
            frm_Pergunta.ShowDialog();
            CarregaDataGrid();
        }
    }
}
