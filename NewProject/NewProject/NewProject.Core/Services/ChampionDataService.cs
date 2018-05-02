using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Models;
using Project.Core.Repositories;

namespace Project.Core.Services
{
    class ChampionDataService : IChampionDataService
    {
        private readonly IChampionRepository _championRepository;

        public ChampionDataService(IChampionRepository ChampionRepository)
        {
            this._championRepository = ChampionRepository;
           
        }

        public List<Champion> GetChampions()
        {
            return _championRepository.GetChampions();
        }

        public ChampionDetail GetChampionById(int ID)
        {
            return _championRepository.GetChampionById(ID);
        }
    }
}
