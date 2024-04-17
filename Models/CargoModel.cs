using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investify.Models
{
    [Table("Cargo")]
    public class CargoModel
    {
        [Key]
        public int Car_id { get; set; }

        public string Car_nome { get; set; }
    }
}
