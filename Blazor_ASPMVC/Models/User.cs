using System.ComponentModel.DataAnnotations;

namespace Blazor_ASPMVC.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]

        public string Address { get; set; }

        public string Description { get; set; }
        [Required]
        public string Password { get; set; }

        public DateTime AccountCreationDate { get; set; }

        public DateTime? AccountDeletedDate { get; set; }

    }
}
