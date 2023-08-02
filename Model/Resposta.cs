using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Resposta
    {
        public int? Id_Resposta { get; set; }
        public string? RespostaQuestao { get; set; }
        public string? Resolvido { get; set; }

        public Resposta()
        {

        }

        public Resposta(int id_resposta, string respostaQuestao, string resolvido)
        {
            this.Id_Resposta = id_resposta;
            this.RespostaQuestao = respostaQuestao;
            this.Resolvido = resolvido;
        }

    }
}
