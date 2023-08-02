using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Setor
    {       
        public int? Id_setor { get; set; }
        public string? Nome { get; set; }

        public Setor()
        {

        }
        public Setor(int  id_setor, string nome)
        {
            this.Id_setor = id_setor;
            this.Nome = nome;   
        }

    }
}
