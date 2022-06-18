using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tests22297.Models
{
    public class FireTruckAction
    {
        [Key]
        public int IdFireTruckAction { get; set; }
        public int IdFireTruck { get; set; }
        public int IdAction { get; set; }
        public DateTime AssignmentDate { get; set; }
        [ForeignKey("IdFireTruck")]
        public virtual FireTruck IdFireTruckNavigation { get; set; }
        [ForeignKey("IdAction")]
        public virtual Action IdActionNavigation { get; set; }
    }
}
