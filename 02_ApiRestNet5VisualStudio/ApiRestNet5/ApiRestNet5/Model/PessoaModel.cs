using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestNet5.Model
{
    [Table("pessoa")]
    public class PessoaModel
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("sobrenome")]
        public string SobreNome { get; set; }
        [Column("endereco")]
        public string Endereco { get; set; }
        [Column("genero")]
        public string Genero { get; set; }

    }
}
