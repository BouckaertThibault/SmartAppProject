using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Tvos.Presenters.Attributes;
using MvvmCross.Platforms.Tvos.Views;
using NewProject.Core.ViewModels;
using System;
using UIKit;

namespace NewProject.tvOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    //[MvxChildPresentation]
    [MvxTabPresentation(WrapInNavigationController = true, TabIconName = "home", TabName = "Skins")]
    public partial class DetailView3 : MvxViewController<DetailView3Model>
    {
        public DetailView3 (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            try
            {
                base.ViewDidLoad();

                MvxFluentBindingDescriptionSet<DetailView3, DetailView3Model> set = this.CreateBindingSet<DetailView3, DetailView3Model>();




                set.Apply();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }



        }
    }
}