﻿using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Services
{
    public interface IChampionDataService
    {
        List<Champion> GetChampions();
        ChampionDetail GetChampionById(int ID);
    }
}
