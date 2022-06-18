using Newtonsoft.Json;


namespace tests22297.DTO
{
    public class ActionWithFireFighters
    {
        [JsonProperty("IdAction")] public int IdAction { set; get; }
        [JsonProperty("StartTime")] public DateTime StartDate { get; set; }
    
        [JsonProperty("EndTime")]public DateTime EndTime { get; set; }
        [JsonProperty("NeedSpecialEquipment")]public bool NeedSpecialEquipment { get; set; }
        [JsonProperty("ListOfFireFighters")] public List<DTO.FireFighter> Fighters { get; set; }
    }
}
