namespace Parky.Models.DTOs
{
    public class TrailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
        public double Elevation{ get; set; }
        public DifficultyType Difficulty { get; set; }
        public int NationalParkId { get; set; }
        public NationalParkDTO NationalPark { get; set; }
    }
}
