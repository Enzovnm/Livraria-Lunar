using System.ComponentModel.DataAnnotations;

namespace Livraria_Lunar_E_commerce.Models
{
    public class Autor
    {

        [Display(Name = "C�digo")]
        public int cd_autor { get; set; }

        [Required(ErrorMessage = "O Campo Nome do Autor � obrigat�rio")]
        [Display(Name= "Nome do Autor")]
        [MaxLength(70,ErrorMessage = "O Nome do Autor deve conter no m�ximo 70 caracteres")]
        public string nm_autor { get; set; }

        [Required]
        [Display(Name = "Status")]
        [Range(0,1)]
        public int ds_status { get; set; }
    }

}