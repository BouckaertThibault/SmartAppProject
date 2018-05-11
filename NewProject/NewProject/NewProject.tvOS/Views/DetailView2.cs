using CoreGraphics;
using Foundation;
using MvvmCross.Base;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Tvos.Presenters.Attributes;
using MvvmCross.Platforms.Tvos.Views;
using MvvmCross.ViewModels;
using NewProject.Core;
using NewProject.Core.ViewModels;
using NewProject.tvOS.Converters;
using Project.Core.Models;
using System;
using System.Diagnostics;
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

                set.Bind(lblSpellName).To(vm => vm.SpellName);
                set.Bind(lblSpellText).To(vm => vm.SpellText);


                

                btnPassive.SetBackgroundImage(ViewModel.GetOnlineImage(ViewModel.ChampionDetail.Passive.Image.SpellImage), UIControlState.Normal);
                set.Bind(btnPassive).To(vm => vm.ChangeTextCommand).CommandParameter("Passive"); 
                btnAbility1.SetBackgroundImage(ViewModel.GetOnlineImage(ViewModel.ChampionDetail.Spells[0].Image.SpellImage), UIControlState.Normal);
                set.Bind(btnAbility1).To(vm => vm.ChangeTextCommand).CommandParameter("Spell 1");
                btnAbility2.SetBackgroundImage(ViewModel.GetOnlineImage(ViewModel.ChampionDetail.Spells[1].Image.SpellImage), UIControlState.Normal);
                set.Bind(btnAbility2).To(vm => vm.ChangeTextCommand).CommandParameter("Spell 2");
                btnAbility3.SetBackgroundImage(ViewModel.GetOnlineImage(ViewModel.ChampionDetail.Spells[2].Image.SpellImage), UIControlState.Normal);
                set.Bind(btnAbility3).To(vm => vm.ChangeTextCommand).CommandParameter("Spell 3");
                btnAbility4.SetBackgroundImage(ViewModel.GetOnlineImage(ViewModel.ChampionDetail.Spells[3].Image.SpellImage), UIControlState.Normal);
                set.Bind(btnAbility4).To(vm => vm.ChangeTextCommand).CommandParameter("Spell 4");

                
               
                
                set.Apply();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

        }
       

       

    }
}