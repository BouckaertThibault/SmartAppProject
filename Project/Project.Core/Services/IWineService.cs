using System.Collections.Generic;
using System.Threading.Tasks;
using WineApp.Core.Models;

namespace WineApp.Core.Services
{
    public interface IWineService
    {
        Task<List<Wine>> GetWines();
        Task AddWine(Wine newWine);
        Task DeleteWine(string id);
    }
}