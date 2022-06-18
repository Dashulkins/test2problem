using System.ComponentModel.DataAnnotations;

namespace tests22297.Models
{
    public class Action
    {
        [Key]
        public int IdAction { get; set; }
        public DateTime StartDate { get; set; }    
        [Required]
        public DateTime EndTime { get; set; }
        public bool NeedSpecialEquipment { get; set; }  
        public virtual ICollection<FireFighterAction> FireFighterActions { get; set; }    
        public virtual ICollection<FireTruckAction> FireTruckActions { get; set; }
    }
}
