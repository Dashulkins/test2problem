namespace tests22297.Services
{
    public interface IDbService
    {
        public List<DTO.FireFighter> GetFireFighters(int IdAction);
        public DTO.ActionWithFireFighters getAction(int IdAction);
        public int deleteAction(int IdAction);
    }
}
