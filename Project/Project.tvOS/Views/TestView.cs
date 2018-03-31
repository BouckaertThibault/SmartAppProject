using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.tvOS.Views;
using Project.Core.ViewModels;
using System;
using UIKit;

namespace Project.tvOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class TestView : MvxViewController<TestViewModel>
    {
        public TestView(IntPtr handle) : base(handle)
        {
        }


        public override void ViewDidLoad()
        {
            try
            {
                base.ViewDidLoad();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            MvxFluentBindingDescriptionSet<TestView, TestViewModel> set = this.CreateBindingSet<TestView, TestViewModel>();
            set.Bind(btnToCollection).To(vm => vm.GoToCollectionCommand);


            set.Apply();
        }
    }
}