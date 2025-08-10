using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry;

public class PubgCharacterInfo
{
    [JsonProperty]
    public PubgCharacter Character { get; set; }
    [JsonProperty]
    public string PrimaryWeaponFirst { get; set; }
    [JsonProperty]
    public string PrimaryWeaponSecond { get; set; }
    [JsonProperty]
    public string SecondaryWeapon { get; set; }
    [JsonProperty]
    public int SpawnKitIndex { get; set; }
}