using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models.Dtos
{
    public class CategoryCreateUpdateDto
    {
        [Required(ErrorMessage = "El nombre de la categoria obligatoria")]
        [MaxLength(200, ErrorMessage = "El número máximo es de 200 caracteres")]
        public string Name { get; set; }

    }
}
