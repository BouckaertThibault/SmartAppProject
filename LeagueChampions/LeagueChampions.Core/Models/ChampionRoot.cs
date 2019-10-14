using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class ChampionRoot
    {
        [JsonProperty("data")]
        public Dictionary<string, Champion> Data { get; set; }


    }
}
