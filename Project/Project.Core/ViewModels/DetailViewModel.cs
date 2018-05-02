using MvvmCross.Core.ViewModels;
using Project.Core.Models;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.ViewModels
{
    public class DetailViewModel : MvxViewModel
    {

        //private int _filter;

        //public int Filter
        //{
        //    get { return _filter; }
        //    set { _filter = value; RaisePropertyChanged(() => Filter); }
        //}

        //public override void Prepare(int parameter)
        //{
        //    this.Filter = parameter;
        //}

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
        protected DetailViewModel(IChampionDataService championDataService)
        {
            this._championDataService = championDataService;
            
        }

        public void Init(int championID)
        {
          
            GetChampionById(championID); 
        }


        public void GetChampionById(int championID)
        {
            ChampionDetail = _championDataService.GetChampionById(championID);



            Debug.WriteLine(ChampionDetail.Name);
            Debug.WriteLine(ChampionDetail.Title);
            Debug.WriteLine(ChampionDetail.Lore);


            RaisePropertyChanged(() => ChampionDetail);


        }
    }
}
