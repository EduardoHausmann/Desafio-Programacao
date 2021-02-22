using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("sala_eventos")]
    public class SalaEvento
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("numero_sala")]
        public int NumeroSala { get; set; }

        [Column("lotacao_maxima")]
        public int LotacaoMaxima { get; set; }

        [Column("registro_ativo")]
        public Boolean RegistroAtivo { get; set; }
    }
}
