using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Name must be 30 characters at most")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Dsiplay Order")]
        [Range(1, 100, ErrorMessage = "Display order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
