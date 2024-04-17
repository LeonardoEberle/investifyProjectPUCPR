using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investify.Models
{
    [Table("Usuario")]
    public class UsuarioModel
    {
        [Key]
        public int Usu_id { get; set; }
        public string Usu_nome { get; set; }

        public string Usu_cpf { get; set; }

        public string Usu_senha { get; set; }

        public string Usu_telefone { get; set; }

        public string Usu_email { get; set; }

        public DateTime Usu_dataInicio { get; set; }

        public DateTime Usu_dataNasc { get; set; }

        public int Usu_status { get; set; }
    }
}
