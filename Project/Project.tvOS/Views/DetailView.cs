using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.tvOS.Views;
using Project.Core.ViewModels;
using System;
using UIKit;

namespace Project.tvOS
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

                MvxFluentBindingDescriptionSet<DetailView, DetailViewModel> set = this.CreateBindingSet<DetailView, DetailViewModel>();

                set.Bind(txtName).To(vm => vm.ChampionDetail.Name);
                set.Bind(txtID).To(vm => vm.ChampionDetail.ID);
                set.Bind(txtDescription).To(vm => vm.ChampionDetail.Lore);
                set.Apply();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            

            
        }
    }
}