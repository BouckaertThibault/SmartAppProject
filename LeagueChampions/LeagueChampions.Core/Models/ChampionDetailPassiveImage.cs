using Newtonsoft.Json;

namespace Project.Core.Models
{
    public class ChampionDetailPassiveImage
    {
        [JsonProperty("full")]
        public string url { get; set; }

        public string SpellImage
        {
            get
            {
                return "https://ddragon.leagueoflegends.com/cdn/9.20.1/img/passive/" + url;
            }
        }
    }
}