using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry;

public class PubgHitDetail
{
    [JsonProperty]
    public string BodyPart { get; set; }
    [JsonProperty]
    public int Kills { get; set; }
    [JsonProperty]
    public int DBNOs { get; set; }
    [JsonProperty]
    public int Hits { get; set; }
    [JsonProperty]
    public int DBNOHits { get; set; }
    [JsonProperty]
    public int Damage { get; set; }
    [JsonProperty]
    public int DBNODamage { get; set; }
}