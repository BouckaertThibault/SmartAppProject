using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NewProject.Core.ViewModels
{
    public class DetailViewModel: MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        
        public DetailViewModel( IMvxNavigationService navigationService)
        {

            
            this._navigationService = navigationService;
            Debug.WriteLine("Constructor gedaan van detailviewmodel");
            


        }
    }
}
