using System.ComponentModel.DataAnnotations;

namespace AutoDealerApplication.Models
{
    public class Measurement
    {
        public Guid Id { get; set; }
        [Required]
        public string Code { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
    }
}