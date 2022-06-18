
using System.Linq;
using tests22297.Models;

namespace tests22297.Services
{
    public class DbService : IDbService
    {
        private readonly ContextMy context;

        public DbService(ContextMy _context)
        {
            context = _context;
        }

        public List<DTO.FireFighter> GetFireFighters(int IdAction)
        {
            var firefighterActions = context.FireFightersActions.Where(x => x.IdAction == IdAction);

            var firefighters = context.FireFighters.Select(s => new { s.IdFireFighter, s.FirstName, s.LastName }).Join(firefighterActions, x => x.IdFireFighter, y => y.IdFireFighter,
                 (FireFighters, FireFighterAction) => new DTO.FireFighter
                 (
                     FireFighters.IdFireFighter,
                     FireFighters.FirstName,
                     FireFighters.LastName
                 )).ToList();
            return firefighters;
      
        }

        public DTO.ActionWithFireFighters getAction(int IdAction) { 
            var action = context.Actions.Where(x => x.IdAction == IdAction).SingleOrDefault();
            if (action == null)
            {
                return null;
            }
            else
            {
                return new DTO.ActionWithFireFighters
                {
                    IdAction = action.IdAction,
                    StartDate = action.StartDate,
                    EndTime = action.EndTime,
                    NeedSpecialEquipment = action.NeedSpecialEquipment,
                    Fighters = GetFireFighters(IdAction),
                };
            }
        }

        public int deleteAction(int IdAction) {
            
            if (context.Actions.Where(x => x.IdAction == IdAction).SingleOrDefault() == null) {
                return -1;
            }
            else { 
            var action = context.Actions.Where(x => x.IdAction == IdAction).SingleOrDefault();
            if (action.EndTime > DateTime.Now && action.StartDate < DateTime.Now)
            {
                int id = action.IdAction;
                var actiontruck = context.FireTruckActions.Where(x => x.IdAction == IdAction).ToList();
                var actionfighter = context.FireFightersActions.Where(x => x.IdAction == IdAction).ToList();
                context.FireFightersActions.RemoveRange(actionfighter);
                context.FireTruckActions.RemoveRange(actiontruck);
                context.SaveChanges();
                context.Actions.Remove(action);
                context.SaveChanges();
                return id;
            }
                return -2;
            }
        }
    }
}
