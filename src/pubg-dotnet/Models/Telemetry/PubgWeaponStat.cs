using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry;

public class PubgWeaponStat
{
    [JsonProperty]
    public string Weapon { get; set; }
    [JsonProperty]
    public int Damage { get; set; }
    [JsonProperty]
    public int DBNODamage { get; set; }
    [JsonProperty]
    public int Shots { get; set; }
    [JsonProperty]
    public int Hits { get; set; }
    [JsonProperty]
    public int DBNOHits { get; set; }
    [JsonProperty]
    public int HoldingTime { get; set; }
    [JsonProperty]
    public IEnumerable<PubgHitDetail> HitDetails { get; set; }
}