#nullable disable

namespace FunctionApp1.Models
{
    public partial class Stage
    {
        public Stage()
        {
            ScheduleItems = new HashSet<ScheduleItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ScheduleItem> ScheduleItems { get; set; }
    }
}
