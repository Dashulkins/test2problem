using System.ComponentModel.DataAnnotations;

namespace tests22297.Models
{
    public class FireFighter
    {
        [Key]
        public int IdFireFighter { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
         public virtual ICollection<FireFighterAction> FireFighterActions { get; set; }
    }
}
