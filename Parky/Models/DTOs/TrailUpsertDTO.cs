namespace Parky.Models.DTOs
{
    public class TrailUpsertDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
        public DifficultyType Difficulty { get; set; }
        public int NationalParkId { get; set; }
        public double Elevation { get; set; }

    }
}
