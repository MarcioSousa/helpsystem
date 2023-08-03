using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pergunta
    {
        public int? Id_pergunta { get; set; }
        public string? Titulo { get; set; }
        public string? Questao { get; set; }
        public int? Dificuldade { get; set; }
        public int? Pessoa { get; set; }
        public int? Setor { get; set; }

        public Pergunta()
        {

        }

        public Pergunta(int id_pergunta, string titulo, string questao, int dificuldade, int pessoa, int setor)
        {
            this.Id_pergunta = id_pergunta;
            this.Titulo = titulo;
            this.Questao = questao;
            this.Dificuldade = dificuldade;
            this.Pessoa = pessoa;
            this.Setor = setor;
        }

    }
}
