using Foundation;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Project.Core.Models;
using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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


        private string _spellName;

        public string SpellName
        {
            get
            {
                if (_spellName == null)
                {
                    _spellName = "Choose an ability";
                }
                return _spellName;
            }
            set
            {
                
                _spellName = value;
               
                RaisePropertyChanged(() => SpellName);
            }
        }

        private string _spellText;

        public string SpellText
        {
            get
            {
                return _spellText;
            }
            set
            {
                _spellText = value;
                RaisePropertyChanged(() => SpellText);
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



        
        public IMvxCommand ChangeTextCommand
        {
            get { return new MvxCommand<string>(ChangeText); }
        }

        void ChangeText(string parameter)
        {
            if(parameter == "Passive")
            {
               SpellName = ChampionDetail.Passive.Name;
               SpellText = ChampionDetail.Passive.Description; 
            }
            if (parameter == "Spell 1")
            {
               SpellName = ChampionDetail.Spells[0].Name;
               SpellText = ChampionDetail.Spells[0].Description;
            }
            if (parameter == "Spell 2")
            {
                SpellName = ChampionDetail.Spells[1].Name;
                SpellText = ChampionDetail.Spells[1].Description;
            }
            if (parameter == "Spell 3")
            {
                SpellName = ChampionDetail.Spells[2].Name;
                SpellText = ChampionDetail.Spells[2].Description;
            }
            if (parameter == "Spell 4")
            {
                SpellName = ChampionDetail.Spells[3].Name;
                SpellText = ChampionDetail.Spells[3].Description;
            }
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
