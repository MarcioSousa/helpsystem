using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {      
        public int? Id_pessoa { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public int? Setor { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int id_pessoa, string nome, string senha)
        {
            this.Id_pessoa = id_pessoa;
            this.Nome = nome;
            this.Senha = senha;
        }



    }
}
