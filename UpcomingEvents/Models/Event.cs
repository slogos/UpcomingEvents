using System;
using System.ComponentModel.DataAnnotations;

namespace UpcomingEvents.Models
{
    public class Event
    {
        public int Id { get; set; }

        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}