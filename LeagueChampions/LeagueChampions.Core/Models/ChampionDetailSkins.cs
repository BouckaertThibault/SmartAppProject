using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class ChampionDetailSkins
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("num")]
        public int SkinNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public string backgroundImage
        {
            get
            {
                string newImage = ImageName.Substring(0, ImageName.Length - 4);
                return "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/" + newImage + "_" + SkinNumber + ".jpg";
            }
        }

        public string ImageName { get; set; }
    }
}
