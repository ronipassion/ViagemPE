using System.ComponentModel.DataAnnotations;

namespace ViagemPE.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
    }
}
