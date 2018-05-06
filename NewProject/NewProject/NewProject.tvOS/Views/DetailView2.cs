using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Tvos.Presenters.Attributes;
using MvvmCross.Platforms.Tvos.Views;
using NewProject.Core.ViewModels;
using NewProject.tvOS.Converters;
using Project.Core.Models;
using System;
using UIKit;

namespace NewProject.tvOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    //[MvxChildPresentation]
    [MvxTabPresentation(WrapInNavigationController = true, TabIconName = "home", TabName = "Abilities")]
    public partial class DetailView2 : MvxViewController<DetailView2Model>
    {
        public DetailView2 (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            try
            {
                base.ViewDidLoad();
                
                MvxFluentBindingDescriptionSet<DetailView2, DetailView2Model> set = this.CreateBindingSet<DetailView2, DetailView2Model>();
                set.Bind(imgBackground).To(vm => vm.ChampionDetail.Image.backgroundImage).WithConversion<StringToImageConverter>();

                btnPassive.SetBackgroundImage(ViewModel.GetOnlineImage(ViewModel.ChampionDetail.Passive.Image.SpellImage), UIControlState.Normal);
                btnAbility1.SetBackgroundImage(ViewModel.GetOnlineImage(ViewModel.ChampionDetail.Spells[0].Image.SpellImage), UIControlState.Normal);
                btnAbility2.SetBackgroundImage(ViewModel.GetOnlineImage(ViewModel.ChampionDetail.Spells[1].Image.SpellImage), UIControlState.Normal);
                btnAbility3.SetBackgroundImage(ViewModel.GetOnlineImage(ViewModel.ChampionDetail.Spells[2].Image.SpellImage), UIControlState.Normal);
                btnAbility4.SetBackgroundImage(ViewModel.GetOnlineImage(ViewModel.ChampionDetail.Spells[3].Image.SpellImage), UIControlState.Normal);


                set.Apply();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }



        }

    }
}