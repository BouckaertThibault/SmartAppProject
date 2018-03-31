﻿using Newtonsoft.Json;

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
                return "https://ddragon.leagueoflegends.com/cdn/8.6.1/img/pasive/" + url;
            }
        }
    }
}