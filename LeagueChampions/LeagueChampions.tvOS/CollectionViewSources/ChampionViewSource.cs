﻿using Foundation;
using MvvmCross.Platforms.Tvos.Binding.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UIKit;

namespace NewProject.tvOS.CollectionViewSources
{
    public class ChampionViewSource : MvxCollectionViewSource
    {
        public ChampionViewSource(UICollectionView collectionView) : base(collectionView)
        {
        }

        protected override UICollectionViewCell GetOrCreateCellFor(UICollectionView collectionView, NSIndexPath indexPath, object item)
        {
            try
            {
                var championCell = (ChampionViewCell)collectionView.DequeueReusableCell(ChampionViewCell.Identifier, indexPath);

                return championCell;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }

        }









    }
}
