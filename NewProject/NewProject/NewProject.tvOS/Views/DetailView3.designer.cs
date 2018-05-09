// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NewProject.tvOS
{
    [Register ("DetailView3")]
    partial class DetailView3
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgBackground { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UICollectionView SkinCollection { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgBackground != null) {
                imgBackground.Dispose ();
                imgBackground = null;
            }

            if (SkinCollection != null) {
                SkinCollection.Dispose ();
                SkinCollection = null;
            }
        }
    }
}