#nullable disable

namespace FunctionApp1.Models
{
    public partial class Artist
    {
        public Artist()
        {
            ScheduleItems = new HashSet<ScheduleItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string WebSite { get; set; }

        public virtual ICollection<ScheduleItem> ScheduleItems { get; set; }
    }
}
