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
    public class DetailViewModel: MvxViewModel<Champion>
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





        private readonly IMvxNavigationService _navigationService;
        protected readonly IChampionDataService _championDataService;
        public DetailViewModel(IChampionDataService championDataService, IMvxNavigationService navigationService)
        {

            this._championDataService = championDataService;
            this._navigationService = navigationService;
            Debug.WriteLine("Constructor gedaan van detailviewmodel");
            
        }


      

        public override void Prepare(Champion parameter)
        {
            GetChampionById(parameter.ID);
        }


        public void GetChampionById(int championID)
        {
            ChampionDetail = _championDataService.GetChampionById(championID);

            RaisePropertyChanged(() => ChampionDetail);

        }

    }
}
