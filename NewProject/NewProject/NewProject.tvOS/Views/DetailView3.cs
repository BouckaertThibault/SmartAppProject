using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Tvos.Presenters.Attributes;
using MvvmCross.Platforms.Tvos.Views;
using NewProject.Core.ViewModels;
using NewProject.tvOS.CollectionViewSources;
using NewProject.tvOS.Converters;
using System;
using UIKit;

namespace NewProject.tvOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    [MvxTabPresentation(WrapInNavigationController = true, TabIconName = "home", TabName = "Skins")]
    public partial class DetailView3 : MvxViewController<DetailView3Model>
    {

        public DetailView3(IntPtr handle) : base(handle)
        {
        }


        private SkinViewSource _skinViewSource;

        public override void ViewDidLoad()
        {
            try
            {
                base.ViewDidLoad();
                _skinViewSource = new SkinViewSource(SkinCollection);
                

                SkinCollection.Source = _skinViewSource;
                SkinCollection.ReloadData();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            MvxFluentBindingDescriptionSet<DetailView3, DetailView3Model> set = this.CreateBindingSet<DetailView3, DetailView3Model>();
            set.Bind(imgBackground).For(iv => iv.Image).To(a => a.SkinImage).WithConversion<StringToImageConverter>();

            set.Bind(_skinViewSource).To(vm => vm.ChampionDetailSkins);
            set.Bind(_skinViewSource)
                     .For(src => src.SelectionChangedCommand)
                     .To(vm => vm.SkinSelectedCommand);

            set.Apply();

        }



    }
}