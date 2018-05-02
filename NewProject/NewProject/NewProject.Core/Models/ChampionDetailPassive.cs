using Newtonsoft.Json;

namespace Project.Core.Models
{
    public class ChampionDetailPassive
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public ChampionDetailPassiveImage Image { get; set; }
    }
}