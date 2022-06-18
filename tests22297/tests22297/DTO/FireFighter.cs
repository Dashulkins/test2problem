using Newtonsoft.Json;

namespace tests22297.DTO
{
    public class FireFighter
    {
        public FireFighter(int idFireFighter, string firstName, string lastName)
        {
            IdFireFighter = idFireFighter;
            FirstName = firstName;
            LastName = lastName;
        }

        [JsonProperty("IdFireFighter")]public int IdFireFighter { get; set; }
        
        [JsonProperty("Firstname")]public string FirstName { get; set; }
        
        [JsonProperty("LastName")]public string LastName { get; set; }

    }
}
