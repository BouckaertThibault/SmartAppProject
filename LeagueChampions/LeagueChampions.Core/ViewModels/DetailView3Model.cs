using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Project.Core.Models;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NewProject.Core.ViewModels
{
    public class DetailView3Model: MvxViewModel<ChampionDetail>
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



        private List<ChampionDetailSkins> _championDetailSkins;

        public List<ChampionDetailSkins> ChampionDetailSkins
        {
            get
            {
                return _championDetailSkins;
            }

            set
            {
                _championDetailSkins = value;
                RaisePropertyChanged(() => ChampionDetailSkins);
            }
        }

        private string _skinImage;

        public string SkinImage
        {
            get
            {
                if (_skinImage == null)
                {
                    _skinImage = ChampionDetail.Image.backgroundImage;
                }
                return _skinImage;
            }
            set
            {
                _skinImage = value;
                RaisePropertyChanged(() => SkinImage);
            }
        }


        public MvxCommand<ChampionDetailSkins> SkinSelectedCommand
        {
            get
            {
                return new MvxCommand<ChampionDetailSkins>(
                    selectedSkin =>
                    {
                        try
                        {

                            SkinImage = selectedSkin.backgroundImage;

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                        }


                    }
                 );

            }
        }


        protected readonly IChampionDataService _championDataService;
        public DetailView3Model(IChampionDataService championDataService)
        {

            this._championDataService = championDataService;
            
        }


        
        public override void Prepare(ChampionDetail parameter)
        {
           
            ChampionDetail = parameter;
            ChampionDetailSkins = parameter.Skins;
            
        }

        
    }
}
