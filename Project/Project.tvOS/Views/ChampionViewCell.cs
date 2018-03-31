using CoreGraphics;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.tvOS.Views;
using Project.Core.Models;
using Project.tvOS.Converters;
using System;
using UIKit;

namespace Project.tvOS
{
    public partial class ChampionViewCell : MvxCollectionViewCell
    {
        internal static readonly NSString Identifier = new NSString("ChampionCell");





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
                        TextColor = UIColor.Black,
                        TextAlignment = UITextAlignment.Center,
                        Font = UIFont.SystemFontOfSize(20)

                    };
                }

                return nameLabel;
            }
        }






        public ChampionViewCell(IntPtr handle) : base(handle)
        {
            SetupViews();
            
        }



        private void SetupViews()
        {
            AddSubview(ImageView);
            AddSubview(NameLabel);
           

            ImageView.Frame = new CGRect(0, 0, Frame.Width, Frame.Height);
            NameLabel.Frame = new CGRect(0, 530, Frame.Width, 30);


        }


        public override bool CanBecomeFocused
        {
            get { return true; }
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            MvxFluentBindingDescriptionSet<ChampionViewCell, Champion> set = new MvxFluentBindingDescriptionSet<ChampionViewCell, Champion>(this);

            set.Bind(NameLabel).To(a => a.Name);
            set.Bind(ImageView).For(iv => iv.Image).To(a => a.Image.LoadingScreenImage).WithConversion<StringToImageConverter>();
            set.Apply();
        }

    }
}