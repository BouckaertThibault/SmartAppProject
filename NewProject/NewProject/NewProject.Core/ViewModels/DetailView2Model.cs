using Foundation;
using MvvmCross.ViewModels;
using Project.Core.Models;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace NewProject.Core.ViewModels
{
    public class DetailView2Model: MvxViewModel<ChampionDetail>
    {

        private ChampionDetail _championDetail;

        public ChampionDetail ChampionDetail
        {
            get
            {
                return _championDetail;
            }

            set
            {
                _championDetail = value;
                RaisePropertyChanged(() => ChampionDetail);
            }
        }


        protected readonly IChampionDataService _championDataService;
        public DetailView2Model(IChampionDataService championDataService)
        {

            this._championDataService = championDataService;
           
        }

        
        public override void Prepare(ChampionDetail parameter)
        {
            
            ChampionDetail = parameter;
        }


        public UIImage GetOnlineImage(string uri)
        {
            if (string.IsNullOrWhiteSpace(uri)) return null;
            using (var url = new NSUrl(uri))
            using (var data = NSData.FromUrl(url))
                return UIImage.LoadFromData(data);
        }
    }
}
