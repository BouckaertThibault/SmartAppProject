using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using NewProject.Core.ViewModels;
using Project.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewProject.Core
{
    public class AppStart : MvxAppStart
    {
        private readonly IMvxNavigationService _mvxNavigationService;

        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
            : base(app)
        {
            _mvxNavigationService = mvxNavigationService;
        }

        protected override void Startup(object hint = null)
        {
            _mvxNavigationService.Navigate<ChampionViewModel>();
        }
    }
}
