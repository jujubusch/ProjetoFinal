using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinal.Models
{
    [Table("TipoSaida")]
    public class TipoSaida
    {
        [Column("Id")]
        [Display(Name = "Código do Tipo de Saída")]
        public int Id { get; set; }

        [Column("TipoSaidaDescricao")]
        [Display(Name = "Descrição do Tipo de Saída")]
        public string TipoSaidaDescricao { get; set; } = string.Empty;
    }
}
