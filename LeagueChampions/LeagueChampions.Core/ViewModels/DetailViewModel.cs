using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Project.Core.Models;
using Project.Core.Services;
using Project.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace NewProject.Core.ViewModels
{
    public class DetailViewModel: MvxViewModel<ChampionDetail>
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
        public DetailViewModel(IChampionDataService championDataService)
        {

            this._championDataService = championDataService;
            
        }



        
        public override void Prepare(ChampionDetail parameter)
        {
            ChampionDetail = parameter;
        }


        

    }
}
