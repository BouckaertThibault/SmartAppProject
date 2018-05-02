using MvvmCross;
using MvvmCross.Base;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.IoC;
using MvvmCross.Platforms.Tvos.Core;
using MvvmCross.Platforms.Tvos.Presenters;
using MvvmCross.ViewModels;
using NewProject.Core;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace NewProject.tvOS
{
    public class Setup : MvxTvosSetup<App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

           
        }

        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();

           
        }

        protected override IMvxIocOptions CreateIocOptions()
        {
            return new MvxIocOptions
            {
                PropertyInjectorOptions = MvxPropertyInjectorOptions.MvxInject
            };
        }
    }
}
