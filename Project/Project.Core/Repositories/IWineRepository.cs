using System.Collections.Generic;
using System.Threading.Tasks;
using WineApp.Core.Models;

namespace WineApp.Core.Repositories
{
    public interface IWineRepository
    {
        Task<List<Wine>> GetWines();
        Task<Wine> PostWine(Wine wine);
        Task DeleteWine(string id);
    }
}