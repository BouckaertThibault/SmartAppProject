using MvvmCross.Converters;
using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NewProject.tvOS.Converters
{
    public class ChampionToBool : MvxValueConverter<Champion, bool>
    {
        protected override bool Convert(Champion value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return true;
            }
            return false;
        }
    }
}
