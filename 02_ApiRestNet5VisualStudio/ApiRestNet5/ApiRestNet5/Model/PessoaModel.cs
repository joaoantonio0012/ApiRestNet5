using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestNet5.Model
{
    public class PessoaModel
    {

        public long Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Endereco { get; set; }
        public string Genero { get; set; }

    }
}
