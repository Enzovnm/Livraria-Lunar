using System.ComponentModel.DataAnnotations;

namespace Livraria_Lunar_E_commerce.Models
{
    public class Editora
    {

        [Display(Name = "C�digo")]
        public int cd_editora { get; set; }

        [Required(ErrorMessage = "O Campo Nome da Editora � obrigat�rio")]
        [Display(Name= "Nome da Editora")]
        [MaxLength(70,ErrorMessage = "O Nome da Editora deve conter no m�ximo 70 caracteres")]
        public string nm_editora { get; set; }
    }
}