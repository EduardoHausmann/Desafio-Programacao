using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("historico_evento_pessoas")]
    public class Historico
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("id_sala_evento")]
        public int IdSalaEvento { get; set; }

        [ForeignKey("IdSalaEvento")]
        public SalaEvento SalaEvento { get; set; }

        [Column("id_pessoa")]
        public int IdPessoa { get; set; }

        [ForeignKey("IdPessoa")]
        public Pessoa Pessoa { get; set; }

        [Column("lotacao_atual")]
        public int LotacaoAtual { get; set; }

        [Column("registro_ativo")]
        public Boolean RegistroAtivo { get; set; }
    }
}
