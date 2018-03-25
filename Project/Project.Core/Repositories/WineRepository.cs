using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WineApp.Core.Models;

namespace WineApp.Core.Repositories
{
    public class WineRepository : BaseRepository, IWineRepository
    {
        private const string _BASEURL = "https://wineserviceapp.azurewebsites.net/api/";

        public Task<List<Wine>> GetWines()
        {
            string url = String.Format("{0}{1}", _BASEURL, "wines");
            return GetAsync<List<Wine>>(url);
        }

        public Task<Wine> PostWine(Wine wine)
        {
            string url = String.Format("{0}{1}", _BASEURL, "wines");
            return PostAsync<Wine>(url, wine);
        }

        public Task  DeleteWine(string id)
        {
            string url = String.Format("{0}{1}/{2}", _BASEURL, "wines",id);
            return DeleteAsync<Wine>(url);
        }
    }
}
