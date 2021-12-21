using System.ComponentModel.DataAnnotations;

namespace ViagemPE.Models
{
    public class Promo
    {
        [Key]
        public int Id_Promo { get; set; }
        public string Primeira_Cidade { get; set; }
        public string Segunda_Cidade { get; set; }
        public int Diarias { get; set; }
        public int Taxa_Desconto { get; set; }
    }
}
