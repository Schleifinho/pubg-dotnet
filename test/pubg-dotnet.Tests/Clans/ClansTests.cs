using Pubg.Net;
using Pubg.Net.Services.Clans;
using Pubg.Net.Tests.Util;
using Xunit;

namespace pubg.net.Tests.Clans;

public class ClansTests : TestBase
{
    [Fact(Skip = "ClanIds are always null in the samples")]
    public void Can_Get_Clans_ById()
    {
        var clansService = new PubgClansService(Storage.ApiKey);

        var clanId = Storage.GetPlayer(PubgPlatform.Steam).ClanId;
        
        var clan = clansService.GetClan(PubgPlatform.Steam, clanId);
        
        Assert.NotNull(clan);
        Assert.Equal(clanId, clan.Id);
    }
}