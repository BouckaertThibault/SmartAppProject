using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueChampions.Core.Models;
using Project.Core.Models;

namespace Project.Core.Repositories
{
    public interface IChampionRepository
    {
        List<Champion> GetChampions();
        ChampionDetail GetChampionById(string name);
    }
}
