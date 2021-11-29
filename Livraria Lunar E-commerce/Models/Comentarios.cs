using System;
using System.ComponentModel.DataAnnotations;

namespace Livraria_Lunar_E_commerce.Models
{
    public class Comentarios
    {
        [Display(Name = "C�digo")]
        public int cd_comentario { get; set; }

        [Required]
        [MaxLength(1000, ErrorMessage = "O Coment�rio deve conter no m�ximo 1000 caracteres")]
        [Display(Name = "Coment�rio")]
        public string ds_comentario { get; set; }

        [Display(Name = "C�digo do Usu�rio")]
        public int cd_usuario { get; set; }

        [Display(Name = "Nome do Usu�rio")]
        public string nm_usuario { get; set; }

        [Display(Name = "Data do Coment�rio")]
        public DateTime dt_comentario { get; set; }
    }
}