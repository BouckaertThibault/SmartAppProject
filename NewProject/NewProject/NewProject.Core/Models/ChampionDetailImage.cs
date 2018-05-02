using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class ChampionDetailImage
    {
        [JsonProperty("full")]
        public string url { get; set; }

        public string backgroundImage
        {
            get
            {
                string newImage = url.Substring(0, url.Length - 4);
                return "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/" + newImage + "_0.jpg";
            }
        }

        public string SquareImage
        {
            get
            {
                string newImage = url.Substring(0, url.Length - 4);
                return "https://http://ddragon.leagueoflegends.com/cdn/8.6.1/img/champion/" + newImage + ".png";
            }
        }

        public string LoadingScreenImage
        {
            get
            {
                string newImage = url.Substring(0, url.Length - 4);
                return "https://ddragon.leagueoflegends.com/cdn/img/champion/loading/" + newImage + "_0.jpg";
            }
        }
    }
}
