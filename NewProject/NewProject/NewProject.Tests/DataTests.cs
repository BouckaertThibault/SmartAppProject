using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Foundation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvvmCross.Base;
using MvvmCross.Core;
using MvvmCross.Navigation;
using MvvmCross.Presenters.Hints;
using MvvmCross.Tests;
using MvvmCross.Views;
using NewProject.Core.ViewModels;
using Project.Core.Models;
using Project.Core.Services;
using Project.Core.ViewModels;
using UIKit;

namespace NewProject.Tests
{
    [TestClass]
    public class DataTests : MvxIoCSupportingTest
    {
        protected MockDispatcher MockDispatcher;

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();
            MockDispatcher = new MockDispatcher();
            Ioc.RegisterSingleton<IMvxViewDispatcher>(MockDispatcher);
            Ioc.RegisterSingleton<IMvxMainThreadDispatcher>(MockDispatcher);
            ///required inly when passing parameters
            Ioc.RegisterSingleton<IMvxStringToTypeParser>(new MvxStringToTypeParser());
        }


        [TestMethod]
        public void Champion_Property_Test()
        {
            var champions = new List<Champion>();
            champions.Add(new Champion() { ID = 1, Title = "Champion title 1", Name = "Champion name 1" });
            champions.Add(new Champion() { ID = 2, Title = "Champion title 2", Name = "Champion name 2" });

            var mockChampionService = new Mock<IChampionDataService>();
            mockChampionService.Setup(ws => ws.GetChampions()).Returns(champions);

            var vm = new ChampionViewModel(mockChampionService.Object, null);

            var allChampions = vm.Champions;

            Assert.IsNotNull(allChampions);
            Assert.IsTrue(allChampions.Count == 2);
        }



        [TestMethod]
        public void SpellImage_url_checker()
        {
            

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://ddragon.leagueoflegends.com/cdn/8.9.1/img/spell/FlashFrost.png");
            request.Method = "HEAD";

            bool exists;
            try
            {
                request.GetResponse();
                exists = true;
            }
            catch
            {
                exists = false;
            }


            Assert.IsTrue(exists);
            
        }


        [TestMethod]
        public void BackgroundImage_url_checker()
        {


            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Aatrox_2.jpg");
            request.Method = "HEAD";

            bool exists;
            try
            {
                request.GetResponse();
                exists = true;
            }
            catch
            {
                exists = false;
            }


            Assert.IsTrue(exists);

        }

        [TestMethod]
        public void PassiveImage_url_checker()
        {


            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://ddragon.leagueoflegends.com/cdn/8.9.1/img/passive/LeBlancP.png");
            request.Method = "HEAD";

            bool exists;
            try
            {
                request.GetResponse();
                exists = true;
            }
            catch
            {
                exists = false;
            }


            Assert.IsTrue(exists);

        }
        

    }
}
