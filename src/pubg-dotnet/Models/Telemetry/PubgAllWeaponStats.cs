using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry;

public class PubgAllWeaponStats
{
    [JsonProperty]
    public string AccountId { get; set; }
    
    [JsonProperty]
    public IEnumerable<PubgWeaponStat> Stats { get; set; }
}