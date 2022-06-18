using System.ComponentModel.DataAnnotations;

namespace tests22297.Models
{
    public class FireTruck
    {
        [Key]
        public int IdFireTruck { get; set; }
        [MaxLength(10)]
        public string OperationalNumber { get; set; }
        public bool SpecialEquipment { get; set; }
        public virtual ICollection<FireTruckAction> TruckActions { get; set; }  
    }
}
