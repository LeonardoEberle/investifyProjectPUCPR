using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investify.Models
{
    [Table("Genero")]
    public class GeneroModel
    {
        [Key]
        public int Gen_id { get; set; }

        public string Gen_nome { get; set; }
    }
}
