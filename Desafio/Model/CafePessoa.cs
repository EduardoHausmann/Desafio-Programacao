using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("cafe_pessoas")]
    public class CafePessoa
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("id_espaco_cafe")]
        public int IdEspacoCafe { get; set; }

        [ForeignKey("IdEspacoCafe")]
        public EspacoCafe EspacoCafe { get; set; }

        [Column("id_pessoa")]
        public int IdPessoa { get; set; }

        [ForeignKey("IdPessoa")]
        public Pessoa Pessoa { get; set; }

        [Column("registro_ativo")]
        public Boolean RegistroAtivo { get; set; }
    }
}
