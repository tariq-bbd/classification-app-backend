using System.ComponentModel.DataAnnotations;

namespace ClassificationAppBackend.Models
{
    public class UserModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }

    }
}