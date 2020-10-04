using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketsBasket.Models.Domain
{
    public class Event : Record
    {
        public Event()
        {
            CreatedOn = DateTime.UtcNow;
        }

        [Required] [StringLength(80)] public string Title { get; set; }

        [StringLength(1000)] public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

        [Required] [StringLength(256)] public string CoverImageUrl { get; set; }
        public int TicketsCount { get; set; }

        [Required] [StringLength(256)] public string Location { get; set; }
        public int Views { get; set; }
        public string UserProfileId { get; set; }

        [Column(TypeName = "decimal(18, 2)")] public decimal Price { get; set; }
    }

    public class EventTag : Record
    {
        [Required] [StringLength(40)] public string Name { get; set; }
    }

    public class EventImage : Record
    {
        [Required]
        [StringLength(256)]
        public string ImageUrl { get; set; }
        
        [StringLength(256)] public string ThumpUrl { get; set; }
        
    }
}