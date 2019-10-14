using Foundation;
using MvvmCross.Platforms.Tvos.Binding.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UIKit;

namespace NewProject.tvOS.CollectionViewSources
{
    public class SkinViewSource : MvxCollectionViewSource
    {
        public SkinViewSource(UICollectionView collectionView) : base(collectionView)
        {
        }

        protected override UICollectionViewCell GetOrCreateCellFor(UICollectionView collectionView, NSIndexPath indexPath, object item)
        {
            try
            {
                var skinCell = (SkinViewCell)collectionView.DequeueReusableCell(SkinViewCell.Identifier, indexPath);

                return skinCell;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }

        }
    }
}
