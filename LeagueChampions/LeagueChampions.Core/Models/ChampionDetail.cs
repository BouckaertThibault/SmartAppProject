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
        public string ID { get; set; }

        
        private List<ChampionDetailSkins> _skins;
        [JsonProperty("skins")]
        public List<ChampionDetailSkins> Skins {
            get {
                return _skins;
            }
            set {
                _skins = value;
                if(_skins != null && Image != null)
                {
                    foreach(ChampionDetailSkins skin in _skins)
                    {
                        skin.ImageName = Image.url;
                    }
                }
            }
        }

        
        private ChampionDetailImage _image;
        [JsonProperty("image")]
        public ChampionDetailImage Image {
            get {
                return _image;
            }
            set {
                _image = value;
                if(_image != null && Skins != null)
                {
                    foreach(ChampionDetailSkins skin in _skins)
                    {
                        skin.ImageName = Image.url;
                    }
                }
            }
        }

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
