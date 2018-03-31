using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Core.Models;

namespace Project.Core.Repositories
{
    public interface IChampionRepository
    {
        List<Champion> GetChampions();
        ChampionDetail GetChampionById(int ID);
    }
}
