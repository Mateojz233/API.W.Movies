using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class Category : AuditBase
    {
        [Required] 
        [Display(Name = "Nombre de la categoria")] 
        public string Name { get; set; }
    }
}
