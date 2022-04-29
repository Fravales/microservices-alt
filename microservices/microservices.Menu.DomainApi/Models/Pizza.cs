using System.ComponentModel.DataAnnotations;

namespace microservices.Menu.DomainApi.Models
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
      
        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(20, ErrorMessage = "Max length 20 chars")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Max length 100 chars")]
        public string? Description { get; set; }
        
        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public bool Avaible { get; set; }

    }
}