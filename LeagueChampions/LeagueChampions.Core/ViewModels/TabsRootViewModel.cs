using LeagueChampions.Core.Models;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using Project.Core.Models;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Core.ViewModels
{
    public class TabsRootViewModel: MvxViewModel<Champion>
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

        public TabsRootViewModel(IChampionDataService championDataService, IMvxNavigationService navigationService)
        {
            this._championDataService = championDataService;
            this._navigationService = navigationService;

            ShowInitialViewModelsCommand = new MvxAsyncCommand(ShowInitialViewModels);
           
        }

       
        public override void Prepare(Champion parameter)
        {
            GetChampionById(parameter.ID);
        }

        public void GetChampionById(string championID)
        {
            ChampionDetail = _championDataService.GetChampionById(championID);

            RaisePropertyChanged(() => ChampionDetail);

        }

        public IMvxAsyncCommand ShowInitialViewModelsCommand { get; private set; }

        private async Task ShowInitialViewModels()
        {
            var tasks = new List<Task>();
            tasks.Add(_navigationService.Navigate<DetailViewModel, ChampionDetail>(ChampionDetail));
            tasks.Add(_navigationService.Navigate<DetailView2Model, ChampionDetail>(ChampionDetail));
            tasks.Add(_navigationService.Navigate<DetailView3Model, ChampionDetail>(ChampionDetail));
            await Task.WhenAll(tasks);
        }

    }
}
