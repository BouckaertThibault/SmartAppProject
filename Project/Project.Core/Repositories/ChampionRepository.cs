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

namespace Project.Core.Repositories
{
    public class ChampionRepository : IChampionRepository
    {
        private const string _BASEURL = "https://euw1.api.riotgames.com/lol/static-data/v3/champions";
        private const string _API_KEY = "RGAPI-03bbb3ce-f67e-a1dd-9aa8-3579da119cfa";
      

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
                Debug.WriteLine("Lezen champions.json file...");
                var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var filename = Path.Combine(documents, "champions.json");
                var text = File.ReadAllText(filename);

                if(text == null)
                {
                    Debug.WriteLine("champions.json was leeg of bestaat niet, data ophalen en storen in file...");
                    using (HttpClient client = CreateHttpClient())
                    {

                        var json = client.GetStringAsync(_BASEURL + "?locale=en_US&champListData=image&tags=image&dataById=false");
                        var r = json.Result;



                        File.WriteAllText(filename, r);
                        var finaalresultaat = JsonConvert.DeserializeObject<ChampionRoot>(r);
                        return finaalresultaat.Data.Values.ToList<Champion>();
                    }
                }

                else
                {
                    Debug.WriteLine("champions.json gevonden, deze uitlezen...");
                    var finaalresultaat = JsonConvert.DeserializeObject<ChampionRoot>(text);
                    return finaalresultaat.Data.Values.ToList<Champion>();
                }


               
                

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }

        }



        public ChampionDetail GetChampionById(int ID)
        {

            try
            {
                Debug.WriteLine("Lezen championDetail" + ID +".json...");
                var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var filename = Path.Combine(documents, "championDetail" + ID +".json");
                var text = File.ReadAllText(filename);


                if (text == null)
                {
                    using (HttpClient client = CreateHttpClient())
                    {
                        Debug.WriteLine("championDetail" + ID + ".json was leeg of bestaat niet, data ophalen en storen in file...");
                        var json = client.GetStringAsync(_BASEURL + "/" + ID + "?locale=en_US&champData=image&champData=info&champData=lore&champData=passive&champData=skins&champData=spells");
                        var r = json.Result;

                        File.WriteAllText(filename, r);
                        var finaalresultaat = JsonConvert.DeserializeObject<ChampionDetail>(r);
                        return finaalresultaat;
                    }
                }

                else
                {
                    Debug.WriteLine("championDetail" + ID + ".json gevonden, deze uitlezen...");
                    var finaalresultaat = JsonConvert.DeserializeObject<ChampionDetail>(text);
                    return finaalresultaat;
                }


            }


            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }

        }






    }
}
