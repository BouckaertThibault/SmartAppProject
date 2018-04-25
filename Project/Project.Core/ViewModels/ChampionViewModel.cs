using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using Project.Core.Models;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.ViewModels
{
    public class ChampionViewModel : MvxViewModel
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


        
        private readonly IMvxNavigationService _navigationService;
        protected readonly IChampionDataService _championDataService;
        public ChampionViewModel(IChampionDataService championDataService, IMvxNavigationService navigationService)
        {

            this._championDataService = championDataService;
            this._navigationService = navigationService;
           

            GetChampions();


        }



        public void GetChampions()
        {
            try
            {
                Champions = _championDataService.GetChampions();
                
                //foreach (Champion champ in Champions)
                //{
                //    Debug.WriteLine(champ.Name + " - " + champ.Title + " - " + champ.Image.LoadingScreenImage);
                //}
                //GetChampionById(45);
                RaisePropertyChanged(() => Champions);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            


        }

        public void GetChampionById(int ID)
        {
            ChampionDetail = _championDataService.GetChampionById(ID);



            Debug.WriteLine(ChampionDetail.Name);
            Debug.WriteLine(ChampionDetail.Title);
            Debug.WriteLine(ChampionDetail.Lore);


            RaisePropertyChanged(() => ChampionDetail);


        }

        public void ReadFile(string text) { }


    }
}
