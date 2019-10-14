using Newtonsoft.Json;
using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueChampions.Core.Models
{
    public class ChampionDetailRoot
    {

        [JsonProperty("data")]
        public Dictionary<string, ChampionDetail> ChampionDetail { get; set; }
}
}

