using System.ComponentModel.DataAnnotations;

namespace SharksApp.API.Models
{
    public class Shark
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public double LengthInMeters { get; set; }
        public string Habitat { get; set; }
    }
}
