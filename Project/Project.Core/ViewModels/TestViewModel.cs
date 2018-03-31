using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using Newtonsoft.Json;
using Project.Core.Models;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.ViewModels
{
    public class TestViewModel : MvxViewModel
    {


        private List<Champion> _champions;

        public List<Champion> Champions
        {
            get
            {
                return _champions;
            }

            set
            {
                _champions = value;
                RaisePropertyChanged(() => Champions);
            }
        }


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



        public IMvxCommand GoToCollectionCommand
        {
            get
            {
                return new MvxCommand(GoToCollection);
            }
        }

        private readonly IMvxNavigationService _navigationService;
        protected readonly IChampionDataService _championDataService;
        public TestViewModel(IChampionDataService championDataService, IMvxNavigationService navigationService)
        {

            this._championDataService = championDataService;
            this._navigationService = navigationService;

            GetChampions();


        }





        public void GetChampions()
        {
            List<Champion> Champions = _championDataService.GetChampions();


            //foreach (KeyValuePair<string, Champion> kvp in Champions.Data)
            //{
            //    Champion champ = kvp.Value;
            //    Debug.WriteLine(champ.Name + " - " + champ.Title + " - " + champ.Image.LoadingScreenImage);
            //}

            foreach (Champion champ in Champions)
            {
                
                Debug.WriteLine(champ.Name + " - " + champ.Title + " - " + champ.Image.LoadingScreenImage);
            }
            GetChampionById(40);
            RaisePropertyChanged(() => Champions);


        }

        public void GetChampionById(int ID)
        {
            ChampionDetail = _championDataService.GetChampionById(ID);



            Debug.WriteLine(ChampionDetail.Name);
            Debug.WriteLine(ChampionDetail.Title);
            Debug.WriteLine(ChampionDetail.Lore);


            RaisePropertyChanged(() => ChampionDetail);


        }


        public void GoToCollection()
        {
            _navigationService.Navigate<ChampionViewModel>();
        }




    }
}
