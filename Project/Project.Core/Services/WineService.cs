using System.Collections.Generic;
using System.Threading.Tasks;
using WineApp.Core.Models;
using WineApp.Core.Repositories;

namespace WineApp.Core.Services
{
    public class WineService : IWineService
    {
        private static List<Wine> _wines = new List<Wine>();
        private readonly IWineRepository _wineRepository;

        public WineService(IWineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }

        public async Task AddWine(Wine newWine)
        {
            await _wineRepository.PostWine(newWine);
        }

        public async Task<List<Wine>> GetWines()
        {
            return await _wineRepository.GetWines();
        }

        public async Task DeleteWine(string id)
        {
            await _wineRepository.DeleteWine(id);
        }
    }
}
