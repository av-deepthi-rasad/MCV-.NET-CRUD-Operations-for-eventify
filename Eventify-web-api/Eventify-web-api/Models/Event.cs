using System.ComponentModel.DataAnnotations;

namespace Eventify_web_api.Models
{
    public class Event
    {

        public int EventId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
    }
}
