using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net.Models.Clans;

public class PubgClan : PubgEntity
{
    [JsonProperty("clanName")]
    public string ClanName { get; set; }
    
    [JsonProperty("clanTag")]
    public string ClanTag { get; set; }
    
    [JsonProperty("clanLevel")]
    public string ClanLevel { get; set; }
    
    [JsonProperty("clanMemberCount")]
    public string ClanMemberCount { get; set; }
}