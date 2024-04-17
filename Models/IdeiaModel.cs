using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investify.Models
{
    [Table("Ideia")]
public class IdeiaModel
    {
        [Key]
        public int Ide_id { get; set; }
        
        public string Ide_nome { get; set; }
        
        public string? ide_descricao { get; set; }

        public int Ide_empresario { get; set; }
        
        public int Ide_nivelRisco { get; set; }
        
        public int Ide_tipo { get; set; }
        
        public string Ide_cnpj { get; set; }
        
        public int Ide_fase { get; set; }
        
        public DateTime Ide_date { get; set; }
        
        public int Ide_status { get; set; }
        
        public double Ide_valorInicial { get; set; }
        
        public double Ide_valorAtual { get; set; }
        
        public int Ide_participacaoDisponivel { get; set; }
    }
}
