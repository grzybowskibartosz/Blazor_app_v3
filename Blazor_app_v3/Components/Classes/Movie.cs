using System.ComponentModel.DataAnnotations;

namespace Blazor_app_v3.Components.Classes
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RelaseDate { get; set; }
        public float? Rate { get; set; }
        public int? Rate_num { get; set; }
        public float? AverageRating => Rate != null && Rate_num != null ? Rate / Rate_num : null;
        public string? imgUrl { get; set; }
        public List<Class> ratings { get; set; } = new List<Class>();
    }
}
