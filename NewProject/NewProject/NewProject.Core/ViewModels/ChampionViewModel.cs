using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using NewProject.Core.ViewModels;
using Project.Core.Models;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;

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


       


        
        private readonly IMvxNavigationService _navigationService;
        protected readonly IChampionDataService _championDataService;
        public ChampionViewModel(IChampionDataService championDataService, IMvxNavigationService navigationService)
        {

            this._championDataService = championDataService;
            this._navigationService = navigationService;
           

            GetChampions();


        }

        public MvxCommand<Champion> NavigateToDetailCommand
        {
            get
            {
                //return new MvxCommand<Champion>(
                //    selectedChampion =>
                //    {
                //        try
                //        {
                //            Debug.WriteLine("navigating to detailview");
                //            _navigationService.Navigate<DetailViewModel>();
                //            Debug.WriteLine("navigation to detailview completed");
                //        }
                //        catch (Exception ex)
                //        {
                //            Debug.WriteLine(ex.Message);
                //        }

                //        //ShowViewModel<DetailViewModel>(new { championID = selectedChampion.ID });
                //    }
                // );
                return new MvxCommand<Champion>(NavigateDetail);
            }
            

        }
         public void NavigateDetail(Champion C)
        {
            try
            {
                Debug.WriteLine("navigating to detailview");
                _navigationService.Navigate<DetailViewModel>();
                Debug.WriteLine("navigation to detailview completed");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        public void GetChampions()
        {
            try
            {
                Champions = _championDataService.GetChampions();


                
                RaisePropertyChanged(() => Champions);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            


        }

        

        


    }
}
