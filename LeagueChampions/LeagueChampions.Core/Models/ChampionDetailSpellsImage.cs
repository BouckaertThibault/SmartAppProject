﻿using Newtonsoft.Json;

namespace Project.Core.Models
{
    public class ChampionDetailSpellsImage
    {
        [JsonProperty("full")]
        public string url { get; set; }

        public string SpellImage
        {
            get
            {
                return "https://ddragon.leagueoflegends.com/cdn/9.20.1/img/spell/" + url;
            }
        }
    }
}