using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.tvOS.Views;
using Project.Core.ViewModels;
using Project.tvOS.CollectionViewSources;
using System;
using UIKit;

namespace Project.tvOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class ChampionView : MvxCollectionViewController<ChampionViewModel>
    {

        public ChampionView(IntPtr handle) : base(handle)
        {
        }


        private ChampionViewSource _championViewSource;

        public override void ViewDidLoad()
        {
            try
            {
                base.ViewDidLoad();
                _championViewSource = new ChampionViewSource(this.CollectionView);
                NavigationItem.Title = "Champions";
                CollectionView.BackgroundColor = UIColor.White;
                this.CollectionView.Source = _championViewSource;
                this.CollectionView.ReloadData();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            MvxFluentBindingDescriptionSet<ChampionView, ChampionViewModel> set = this.CreateBindingSet<ChampionView, ChampionViewModel>();

            set.Bind(_championViewSource).To(vm => vm.Champions);

            set.Apply();
            
        }



    }
}