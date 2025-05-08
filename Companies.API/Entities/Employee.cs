using System.ComponentModel.DataAnnotations;

namespace Companies.API.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length is 30 characters.")]
        public string? Name { get; set; }
        public int  Age { get; set; }
        [Required(ErrorMessage = "Position is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length is 20 characters.")]
        public string? Position { get; set; }
        
        public int CompanyId { get; set;}
        //Navigation property
        public Company? Company { get; set; }
    }
}
