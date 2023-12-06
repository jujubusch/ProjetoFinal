using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo do Produto")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Descrição do Tipo de Produto")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
