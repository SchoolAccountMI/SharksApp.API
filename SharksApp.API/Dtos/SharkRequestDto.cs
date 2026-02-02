namespace SharksApp.API.Dtos
{
    public class SharkRequestDto
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double LengthInMeters { get; set; }
        public string Habitat { get; set; }
    }
}
