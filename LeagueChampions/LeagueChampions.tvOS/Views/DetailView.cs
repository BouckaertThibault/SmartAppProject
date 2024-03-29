﻿using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Tvos.Presenters.Attributes;
using MvvmCross.Platforms.Tvos.Views;
using NewProject.Core.ViewModels;
using NewProject.tvOS.Converters;
using System;
using System.Diagnostics;
using UIKit;

namespace NewProject.tvOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    [MvxTabPresentation(WrapInNavigationController = true, TabIconName = "home", TabName = "Champion")]
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

                
                set.Bind(imgBackground).To(vm => vm.ChampionDetail.Image.backgroundImage).WithConversion<StringToImageConverter>();
                
                set.Bind(lblName).To(vm => vm.ChampionDetail.Name);
                set.Bind(lblTitle).To(vm => vm.ChampionDetail.Title);
                
                set.Apply();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }



        }
    }
}