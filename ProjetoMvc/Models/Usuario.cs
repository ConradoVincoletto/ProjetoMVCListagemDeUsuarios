using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMvc.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name ="Codigo")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }
        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }
        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public string Telefone { get; set; }


    }
}
