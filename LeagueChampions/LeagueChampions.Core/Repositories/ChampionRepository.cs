using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Repositories;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using LeagueChampions.Core.Models;

namespace Project.Core.Repositories
{
    public class ChampionRepository : IChampionRepository
    {
        //private const string _BASEURL = "https://euw1.api.riotgames.com/lol/static-data/v3/champions";
        private const string _ALLCHAMPS = "https://ddragon.leagueoflegends.com/cdn/9.20.1/data/en_US/champion.json";
        private const string _INDIVIDUAL_CHAMP = "https://ddragon.leagueoflegends.com/cdn/9.20.1/data/en_US/champion/";
        private const string _API_KEY = "RGAPI-852ad88b-f462-474e-8bb9-fbeff81c4525";
        public string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


        private HttpClient CreateHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("X-Riot-Token", _API_KEY);
            return client;
        }


        public List<Champion> GetChampions()
        {
            
           
            try
            {
                Debug.WriteLine("Kijken dat champions.json al bestaat...");
                
                var filename = Path.Combine(documents, "champions.json");
                var text = File.ReadAllText(filename);

                
                
                Debug.WriteLine("champions.json gevonden, deze uitlezen...");
                var finaalresultaat = JsonConvert.DeserializeObject<ChampionRoot>(text);
                return finaalresultaat.Data.Values.ToList<Champion>();
                

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                var filename = Path.Combine(documents, "champions.json");
                Debug.WriteLine("FILENAME: " + filename);
                Debug.WriteLine("champions.json was leeg of bestaat niet, data ophalen en storen in file...");
                using (HttpClient client = CreateHttpClient())
                {

                    var json = client.GetStringAsync(_ALLCHAMPS + "?locale=en_US&champListData=image&tags=image&dataById=false");
                    var r = json.Result;



                    File.WriteAllText(filename, r);
                    var finaalresultaat = JsonConvert.DeserializeObject<ChampionRoot>(r);
                    return finaalresultaat.Data.Values.ToList<Champion>();
                }
            }
        }


        public ChampionDetail GetChampionById(string name)
        {

            try
            {
                Debug.WriteLine("Lezen championDetail" + name +".json...");
                
                var filename = Path.Combine(documents, "championDetail" + name + ".json");
                var text = File.ReadAllText(filename);
                
                Debug.WriteLine("championDetail" + name + ".json gevonden, deze uitlezen...");

                var finaalresultaat = JsonConvert.DeserializeObject<ChampionDetailRoot>(text);
                
                var championdata = finaalresultaat.ChampionDetail.Values.ToList<ChampionDetail>();
                return championdata[0];

            }


            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                var filename = Path.Combine(documents, "championDetail" + name + ".json");
                

                Debug.WriteLine("championDetail" + name + ".json was leeg of bestaat niet, data ophalen en storen in file...");
                using (HttpClient client = CreateHttpClient())
                {

                    var json = client.GetStringAsync(_INDIVIDUAL_CHAMP + name + ".json");
                    var r = json.Result;

                    File.WriteAllText(filename, r);

                    var finaalresultaat = JsonConvert.DeserializeObject<ChampionDetailRoot>(r);

                    var championdata = finaalresultaat.ChampionDetail.Values.ToList<ChampionDetail>();
                    return championdata[0];
                }

                
            }

        }






    }
}
