using Newtonsoft.Json;
using System.Collections.Generic;
using Pubg.Net.Models.Telemetry;

namespace Pubg.Net
{
    public class LogMatchEnd : PubgTelemetryEvent
    {
        [JsonProperty]
        public IEnumerable<PubgCharacterInfo> Characters { get; set; }
        
        [JsonProperty]
        public PubgGameResultOnFinished GameResultOnFinished { get; set; }
        
        [JsonProperty]
        public IEnumerable<PubgAllWeaponStats> AllWeaponStats { get; set; }
    }
}
