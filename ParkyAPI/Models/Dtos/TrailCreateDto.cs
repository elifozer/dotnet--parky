using System.ComponentModel.DataAnnotations;

namespace ParkyAPI.Models.Dtos
{
    public class TrailCreateDto
    {
        [Required] public string Name { get; set; }

        [Required] public double Distance { get; set; }

        [Required] public double Elevation { get; set; }

        public Trail.DifficultyType Difficulty { get; set; }

        [Required] public int NationalParkId { get; set; }
    }
}