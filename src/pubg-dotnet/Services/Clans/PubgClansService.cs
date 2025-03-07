using System.Threading;
using System.Threading.Tasks;
using JsonApiSerializer;
using Newtonsoft.Json;
using Pubg.Net.Infrastructure;
using Pubg.Net.Models.Clans;
using Pubg.Net.Values;

namespace Pubg.Net.Services.Clans;

public class PubgClansService : PubgService
{
    public PubgClansService(string apiKey) : base(apiKey) { }
    
    public virtual PubgClan GetClan(PubgPlatform platform, string clanId, string apiKey = null)
    {
        var url = Api.Clans.ClansEndpoint(platform, clanId);
        apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;
        
        var clanJson = HttpRequestor.GetString(url, apiKey);
        
        return JsonConvert.DeserializeObject<PubgClan>(clanJson, new JsonApiSerializerSettings());
    }
    
    public virtual async Task<PubgClan> GetClanAsync(PubgPlatform platform, string clanId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
    {
        var url = Api.Clans.ClansEndpoint(platform, clanId);
        apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

        var clanJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey);

        return JsonConvert.DeserializeObject<PubgClan>(clanJson, new JsonApiSerializerSettings());
    }
}