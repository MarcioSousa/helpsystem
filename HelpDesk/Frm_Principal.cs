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
        readonly Pergunta pergunta = new Pergunta();

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
            DataTable dataTablePerguntas = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT id_pergunta, titulo, questao, dificuldade, pessoa, setor FROM PERGUNTA");

            foreach (DataRow linha in dataTablePerguntas.Rows)
            {
                Pergunta pergunta = new Pergunta(Convert.ToInt32(linha["id_pergunta"]), linha["titulo"].ToString(), linha["questao"].ToString(), Convert.ToInt32(linha["dificuldade"]), Convert.ToInt32(linha["pessoa"]), Convert.ToInt32(linha["setor"]));
                perguntas.Add(pergunta);
            }

            DgvPerguntas.DataSource = perguntas;

            DgvPerguntas.Update();
            DgvPerguntas.Refresh();
        }
        private string CarregaNomeSetor(int codSetor)
        {
            string nomeSetor = "";
            int a = 0;
            acessoSqlServer.LimparParametros();
            DataTable dataTableSetor = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT nome FROM SETOR WHERE id_setor = " + codSetor);

            foreach (DataRow linha in dataTableSetor.Rows)
            {
                nomeSetor = dataTableSetor.Rows[a][0].ToString();
            }

            return nomeSetor;
        }
        private void CarregaRespostas(int codigoPergunta)
        {
            List<Resposta> respostas = new List<Resposta>();
            TxtResposta.Text = "";
            int t = 0;
            acessoSqlServer.LimparParametros();
            DataTable dataTablePerguntas = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT R.id_resposta, R.resposta, R.resolvido, R.pergunta, R.setor, R.pessoa, P.nome FROM RESPOSTA R INNER JOIN PESSOA P ON P.id_pessoa = R.pessoa WHERE R.pergunta = " + codigoPergunta);

            foreach (DataRow linha in dataTablePerguntas.Rows)
            {
                TxtResposta.Text += string.Format(dataTablePerguntas.Rows[t][6].ToString() + " - " + CarregaNomeSetor(Convert.ToInt32(dataTablePerguntas.Rows[t][4])) + "{0}", Environment.NewLine);
                TxtResposta.Text += string.Format(dataTablePerguntas.Rows[t][1].ToString() + "{0}{0}", Environment.NewLine);

                Resposta resposta = new Resposta(Convert.ToInt32(dataTablePerguntas.Rows[t][0]), dataTablePerguntas.Rows[t][1].ToString(), dataTablePerguntas.Rows[t][2].ToString());

                respostas.Add(resposta);

                t++;
            }

        }
        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
            CarregaRespostas(Convert.ToInt32(DgvPerguntas.Rows[DgvPerguntas.CurrentRow.Index].Cells[0].Value));
        }
        private void FiltrargemBotao(string? setor)
        {
            try
            {
                List<Pergunta> perguntas = new List<Pergunta> { };
                DataTable dataTablePerguntas;
                acessoSqlServer.LimparParametros();
                int setorNumero = 0;

                if (setor == "OPERAÇÕES")
                {
                    setorNumero = 1;
                }
                else if (setor == "ADMINISTRATIVO")
                {
                    setorNumero = 2;
                }
                else if (setor == "COMERCIAL")
                {
                    setorNumero = 3;
                }
                else if (setor == "TECNOLOGIA")
                {
                    setorNumero = 4;
                }

                if (setor != null)
                {
                    dataTablePerguntas = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT id_pergunta, titulo, questao, dificuldade, pessoa, setor FROM PERGUNTA WHERE setor = " + setorNumero);
                }
                else
                {
                    dataTablePerguntas = acessoSqlServer.ExecutarConsulta(CommandType.Text, "SELECT id_pergunta, titulo, questao, dificuldade, pessoa, setor FROM PERGUNTA");
                }

                foreach (DataRow linha in dataTablePerguntas.Rows)
                {
                    Pergunta pergunta = new Pergunta(Convert.ToInt32(linha["id_pergunta"]), linha["titulo"].ToString(), linha["questao"].ToString(), Convert.ToInt32(linha["dificuldade"]), Convert.ToInt32(linha["pessoa"]), Convert.ToInt32(linha["setor"]));
                    perguntas.Add(pergunta);
                }

                DgvPerguntas.DataSource = perguntas;

                DgvPerguntas.Update();
                DgvPerguntas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                throw;
            }

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
        private void DgvPerguntas_SelectionChanged(object sender, EventArgs e)
        {
            TxtPergunta.Text = "";

            if (DgvPerguntas.Rows.Count != 0 && DgvPerguntas.Columns.Count != 0)
            {
                CarregaRespostas(Convert.ToInt32(DgvPerguntas.Rows[DgvPerguntas.CurrentRow.Index].Cells[0].Value));
                pergunta.Id_pergunta = Convert.ToInt32(DgvPerguntas.Rows[DgvPerguntas.CurrentRow.Index].Cells[0].Value);
                pergunta.Titulo = DgvPerguntas.Rows[DgvPerguntas.CurrentRow.Index].Cells[1].Value.ToString();
                pergunta.Dificuldade = Convert.ToInt32(DgvPerguntas.Rows[DgvPerguntas.CurrentRow.Index].Cells[2].Value);
                pergunta.Questao = DgvPerguntas.Rows[DgvPerguntas.CurrentRow.Index].Cells[3].Value.ToString();
                pergunta.Pessoa = Convert.ToInt32(DgvPerguntas.Rows[DgvPerguntas.CurrentRow.Index].Cells[4].Value);
                pergunta.Setor = Convert.ToInt32(DgvPerguntas.Rows[DgvPerguntas.CurrentRow.Index].Cells[5].Value);
                TxtPergunta.Text += string.Format(CarregaNomeSetor(Convert.ToInt32(pergunta.Setor)) + "{0}", Environment.NewLine); ;
                TxtPergunta.Text += DgvPerguntas.Rows[DgvPerguntas.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }
        private void BtnCarregaTudo_Click(object sender, EventArgs e)
        {
            FiltrargemBotao(null);
        }
        private void BtnResposta_Click(object sender, EventArgs e)
        {
            Frm_Resposta frm_Resposta = new Frm_Resposta(pergunta, Convert.ToInt32(LblCodigoFuncionario.Text), LblFuncionario.Text);
            frm_Resposta.ShowDialog();
            CarregaDataGrid();
        }

    }
}
