using MvvmCross.ViewModels;
using Project.Core.Models;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewProject.Core.ViewModels
{
    public class DetailView3Model: MvxViewModel<ChampionDetail>
    {
        private ChampionDetail _championDetail;

        public ChampionDetail ChampionDetail
        {
            get
            {
                return _championDetail;
            }

            set
            {
                _championDetail = value;
                RaisePropertyChanged(() => ChampionDetail);
            }
        }


        protected readonly IChampionDataService _championDataService;
        public DetailView3Model(IChampionDataService championDataService)
        {

            this._championDataService = championDataService;

        }


        
        public override void Prepare(ChampionDetail parameter)
        {
            ChampionDetail = parameter;
        }

    }
}
