using System.Collections.Generic;
using System.Linq;
using Pubg.Net.Extensions;

namespace Pubg.Net.Values
{
    internal static class Api
    {
        internal const string DefaultBaseUrl = "https://api.pubg.com";
        internal static string ShardedBaseUrl = PubgApiConfiguration.GetApiBase() + "/shards/{0}";

        internal static class Leaderboard
        {
            internal static string LeaderboardEndpoint(PubgRegion region, string seasonId, PubgGameMode gameMode)
                => string.Format(ShardedBaseUrl + "/leaderboards/{1}/{2}", region.Serialize(), seasonId,
                    gameMode.Serialize());
        }

        internal static class Matches
        {
            internal static string MatchesEndpoint(PubgPlatform platform) =>
                string.Format(ShardedBaseUrl + "/matches", platform.Serialize());

            internal static string MatchesEndpoint(PubgPlatform platform, string matchId) =>
                MatchesEndpoint(platform) + $"/{matchId}";
        }

        internal static class Status
        {
            internal static string StatusEndpoint() => PubgApiConfiguration.GetApiBase() + "/status";
        }

        internal static class Players
        {
            internal static string PlayersEndpoint(PubgPlatform platform) =>
                string.Format(ShardedBaseUrl + "/players", platform.Serialize());

            internal static string PlayersEndpoint(PubgPlatform platform, string playerId) =>
                PlayersEndpoint(platform) + $"/{playerId}";

            internal static string PlayerSeasonsEndpoint(PubgPlatform platform, string playerId, string seasonId) =>
                string.Format(ShardedBaseUrl + "/players/{1}/seasons/{2}", platform.Serialize(), playerId, seasonId);
        }

        internal static class Samples
        {
            internal static string SamplesEndpoint(PubgPlatform platform) =>
                string.Format(ShardedBaseUrl + "/samples", platform.Serialize());
        }

        internal static class Seasons
        {
            internal static string SeasonsPCEndpoint(PubgPlatform platform) =>
                string.Format(ShardedBaseUrl + "/seasons", platform.Serialize());

            internal static string SeasonsXboxEndpoint(PubgRegion region) =>
                string.Format(ShardedBaseUrl + "/seasons", region.Serialize());
        }

        internal static class Tournaments
        {
            internal static string TournamentsEndpoint() => PubgApiConfiguration.GetApiBase() + "/tournaments";

            internal static string TournamentsEndpoint(string tournamentId) =>
                TournamentsEndpoint() + $"/{tournamentId}";
        }

        internal static class LifetimeStats
        {
            internal static string LifetimeStatsEndpoint(PubgPlatform platform, string accountId) =>
                string.Format($"{ShardedBaseUrl}/players/{accountId}/seasons/lifetime", platform.Serialize());

            internal static string LifetimeStatsEndpoint(PubgPlatform platform, PubgGameMode gameMode, IEnumerable<string> playerIds) =>
                string.Format($"{ShardedBaseUrl}/seasons/lifetime/gameMode/{gameMode.Serialize()}/players?filter[playerIds]={string.Join(",", playerIds)}", platform.Serialize());
        }

        internal static class Masteries
        {
            internal static string WeaponMasteryEndpoint(PubgPlatform platform, string accountId) =>
                string.Format($"{ShardedBaseUrl}/players/{accountId}/weapon_mastery", platform.Serialize());

            internal static string SurvivalMasteryEndpoint(PubgPlatform platform, string accountId) =>
                string.Format($"{ShardedBaseUrl}/players/{accountId}/survival_mastery", platform.Serialize());
        }

        internal static class Clans
        {
            internal static string ClansEndpoint(PubgPlatform platform, string clanId) =>
                string.Format($"{ShardedBaseUrl}/clans/{clanId}", platform.Serialize());
        }
    }
}