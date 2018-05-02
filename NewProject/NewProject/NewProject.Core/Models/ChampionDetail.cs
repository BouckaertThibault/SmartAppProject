using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class ChampionDetail
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("skins")]
        public List<ChampionDetailSkins> Skins { get; set; }

        [JsonProperty("image")]
        public ChampionDetailImage Image { get; set; }

        [JsonProperty("lore")]
        public string Lore { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("spells")]
        public List<ChampionDetailSpells> Spells { get; set; }

        [JsonProperty("passive")]
        public ChampionDetailPassive Passive { get; set; }


    }
}
