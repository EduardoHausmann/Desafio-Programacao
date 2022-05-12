using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("espaco_cafes")]
    public class EspacoCafe
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("lotacao_maxima")]
        public int LotacaoMaxima { get; set; }

        [Column("registro_ativo")]
        public Boolean RegistroAtivo { get; set; }
    }
}
