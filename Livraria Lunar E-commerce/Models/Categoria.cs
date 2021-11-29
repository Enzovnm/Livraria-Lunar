using System.ComponentModel.DataAnnotations;

namespace Livraria_Lunar_E_commerce.Models
{
    public class Categoria
    {
        [Display(Name = "C�digo")]
        public int cd_categoria { get; set; }

        [Required(ErrorMessage = "O Campo Categoria � obrigat�rio")]
        [Display(Name= "Categoria")]
        [MaxLength(70,ErrorMessage = "O Nome da Categoria deve conter no m�ximo 70 caracteres")]
        [MinLength(3,ErrorMessage = "O Nome da Categoria deve conter no m�nimo 3 caracteres")]
        public string nm_categoria { get; set; }
    }
}