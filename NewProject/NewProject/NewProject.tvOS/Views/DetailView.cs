using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Tvos.Presenters.Attributes;
using MvvmCross.Platforms.Tvos.Views;
using NewProject.Core.ViewModels;
using System;
using System.Diagnostics;
using UIKit;

namespace NewProject.tvOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    
    public partial class DetailView : MvxViewController<DetailViewModel>
    {
        public DetailView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            try
            {
                base.ViewDidLoad();
                Debug.WriteLine("View geladen");
                MvxFluentBindingDescriptionSet<DetailView, DetailViewModel> set = this.CreateBindingSet<DetailView, DetailViewModel>();

                
                set.Apply();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }



        }
    }
}