using MvvmCross.Core.ViewModels;
using MvvmCross.tvOS.Platform;
using MvvmCross.tvOS.Views.Presenters;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Project.tvOS
{
    public class Setup : MvxTvosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window) : base(applicationDelegate, window)
        {

        }

        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxTvosViewPresenter presenter) : base(applicationDelegate, presenter)
        {

        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}
