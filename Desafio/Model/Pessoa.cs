using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("pessoas")]
    public class Pessoa
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("sobrenome")]
        public string Sobrenome { get; set; }

        [Column("cpf")]
        public string CPF { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("email")]
        public string Email { get; set; }
        
        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }
        
        [Column("nome_mae")]
        public string NomeMae { get; set; }
        
        [Column("sexo")]
        public string Sexo { get; set; }

        [Column("registro_ativo")]
        public Boolean RegistroAtivo { get; set; }
    }
}
