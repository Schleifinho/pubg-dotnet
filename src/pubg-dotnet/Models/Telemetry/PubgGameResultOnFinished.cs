using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry
{
    public class PubgGameResultOnFinished
    {
        [JsonProperty]
        public IEnumerable<PubgGameResult> Results { get; set; }
    }
}
