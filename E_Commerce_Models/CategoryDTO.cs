using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Models
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter category name")]
        public string Name { get; set; }
    }
}
