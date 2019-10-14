using Foundation;
using MvvmCross.Platforms.Tvos.Presenters.Attributes;
using MvvmCross.Platforms.Tvos.Views;
using NewProject.Core.ViewModels;
using System;
using UIKit;

namespace NewProject.tvOS
{
    [MvxFromStoryboard("Main")]
    [MvxChildPresentation]
    public partial class TabsRootView : MvxTabBarViewController<TabsRootViewModel>
    {
        private bool _isPresentedFirstTime = true;

        public TabsRootView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (ViewModel != null && _isPresentedFirstTime)
            {
                _isPresentedFirstTime = false;
                ViewModel.ShowInitialViewModelsCommand.ExecuteAsync(null);
            }
        }





    }
}