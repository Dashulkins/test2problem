using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tests22297.Models
{
    public class FireFighterAction
    {
        [Key]
        public int IdFireFighterAction { get; set; }
        public int IdFireFighter { get; set; }
        public int IdAction { get; set; }

        [ForeignKey("IdFireFighter")]
        public virtual FireFighter IdFireFighterNavigation { get; set; }
        [ForeignKey("IdAction")]
        public virtual Action IdActionNavigation { get; set; }
    }
}
