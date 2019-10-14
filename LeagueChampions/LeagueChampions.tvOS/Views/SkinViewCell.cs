using CoreGraphics;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Tvos.Binding.Views;
using NewProject.tvOS.Converters;
using Project.Core.Models;
using System;
using UIKit;

namespace NewProject.tvOS
{
    public partial class SkinViewCell : MvxCollectionViewCell
    {
        internal static readonly NSString Identifier = new NSString("SkinCell");





        private UIImageView imageView;
        public UIImageView ImageView
        {
            get
            {
                if (imageView == null)
                {
                    imageView = new UIImageView();
                    imageView.ContentMode = UIViewContentMode.ScaleAspectFill;
                    imageView.AdjustsImageWhenAncestorFocused = true;

                    //imageView.Layer.CornerRadius = 16;
                    //imageView.Layer.MasksToBounds = true;
                }

                return imageView;
            }
        }

        private UILabel nameLabel;
        public UILabel NameLabel
        {
            get
            {
                if (nameLabel == null)
                {
                    nameLabel = new UILabel
                    {
                        TextColor = UIColor.White,
                        TextAlignment = UITextAlignment.Center,
                        Font = UIFont.SystemFontOfSize(25)

                    };
                }

                return nameLabel;
            }
        }






        public SkinViewCell(IntPtr handle) : base(handle)
        {
            SetupViews();

        }



        private void SetupViews()
        {
            AddSubview(ImageView);
            AddSubview(NameLabel);


            ImageView.Frame = new CGRect(0, 0, Frame.Width, Frame.Height);
            NameLabel.Frame = new CGRect(0, 150, Frame.Width, 35);


        }


        public override bool CanBecomeFocused
        {
            get { return true; }
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            MvxFluentBindingDescriptionSet<SkinViewCell, ChampionDetailSkins> set = new MvxFluentBindingDescriptionSet<SkinViewCell, ChampionDetailSkins>(this);

            set.Bind(NameLabel).To(a => a.Name);
            set.Bind(ImageView).For(iv => iv.Image).To(a => a.backgroundImage).WithConversion<StringToImageConverter>();
            set.Apply();
        }

        public override void DidUpdateFocus(UIFocusUpdateContext context, UIFocusAnimationCoordinator coordinator)
        {
            var previousItem = context.PreviouslyFocusedView as SkinViewCell;
            if (previousItem != null)
            {
                Animate(0.5, () =>
                {
                    previousItem.NameLabel.Font = UIFont.SystemFontOfSize(25);
                    previousItem.NameLabel.Frame = new CGRect(0, 150, Frame.Width, 35);
                });
            }

            var nextItem = context.NextFocusedView as SkinViewCell;
            if (nextItem != null)
            {
                Animate(0.5, () =>
                {
                    nextItem.NameLabel.Font = UIFont.SystemFontOfSize(30);
                    nextItem.NameLabel.Frame = new CGRect(0, 170, Frame.Width, 40);
                });
            }
        }

    }
}