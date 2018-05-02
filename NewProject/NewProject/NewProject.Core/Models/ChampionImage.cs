using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class ChampionImage
    {
        [JsonProperty("full")]
        public string url { get; set; }

        public string LoadingScreenImage
        {
            get {
                string newImage = url.Substring(0, url.Length - 4);
                return "https://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + newImage + "_0.jpg";
            }
        }

    }
}
