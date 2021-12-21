using System.ComponentModel.DataAnnotations;

namespace ViagemPE.Models
{
    public class Destino
    {
        [Key]
        public int Id_Destino { get; set; }
        public string Cidade { get; set; }
        public string Hotel { get; set; }
    }
}
