using System;
using System.ComponentModel.DataAnnotations;

namespace TicketsBasket.Models.Domain
{
    public class UserProfile : Record
    {
        public UserProfile()
        {
            CreatedOn = DateTime.UtcNow;
        }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25)]
        public string LastName { get; set; }
        
        [Required]
        [StringLength(25)]
        public string Email { get; set; }

        [Required]
        [StringLength(25)]
        public string Country { get; set; }

        [Required]
        [StringLength(25)]
        public string City { get; set; }
        public bool IsOrganizer { get; set; }
        public DateTime CreatedOn { get; set; }
        
        
    }
}