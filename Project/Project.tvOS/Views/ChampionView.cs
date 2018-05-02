﻿using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.tvOS.Views;
using Project.Core.Models;
using Project.Core.ViewModels;
using Project.tvOS.CollectionViewSources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            set.Bind(_championViewSource)
                    .For(src => src.SelectionChangedCommand)
                    .To(vm => vm.NavigateToDetailCommand);
            //_championViewSource.SelectedItemChanged += _championViewSource_SelectedItemChanged;

            set.Apply();
            
        }

        //private void _championViewSource_SelectedItemChanged(object sender, EventArgs e)
        //{

        //    this.PresentViewController(new Detail())
        //}
    }
}