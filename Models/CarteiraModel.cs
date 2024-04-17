using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investify.Models
{
    [Table("Carteira")]
    public class CarteiraModel
    {
        [Key]
        public int Crt_id { get; set; }
        public int Crt_ideia { get; set; }
        public int Crt_investidor { get; set; }
        public double Crt_valorInvestido { get; set; }
        public DateTime Crt_dataInicio { get; set; }
        public int Crt_participacao { get; set; }
        public double Crt_receita { get; set; }
    }
}
