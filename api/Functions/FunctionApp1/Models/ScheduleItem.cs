#nullable disable

namespace FunctionApp1.Models
{
    public partial class ScheduleItem
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int? ArtistId { get; set; }
        public int? StageId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Stage Stage { get; set; }
    }
}
