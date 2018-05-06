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
    [Register ("DetailView2")]
    partial class DetailView2
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAbility1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAbility2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAbility3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAbility4 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPassive { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgBackground { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIVisualEffectView imgBlur { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnAbility1 != null) {
                btnAbility1.Dispose ();
                btnAbility1 = null;
            }

            if (btnAbility2 != null) {
                btnAbility2.Dispose ();
                btnAbility2 = null;
            }

            if (btnAbility3 != null) {
                btnAbility3.Dispose ();
                btnAbility3 = null;
            }

            if (btnAbility4 != null) {
                btnAbility4.Dispose ();
                btnAbility4 = null;
            }

            if (btnPassive != null) {
                btnPassive.Dispose ();
                btnPassive = null;
            }

            if (imgBackground != null) {
                imgBackground.Dispose ();
                imgBackground = null;
            }

            if (imgBlur != null) {
                imgBlur.Dispose ();
                imgBlur = null;
            }
        }
    }
}