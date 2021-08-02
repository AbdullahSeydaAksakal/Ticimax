using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using UI.Shared;

namespace UI.Pages
{
  internal  class Abiye
    {

        #region Tanimlamalar
        #region Settings
        private IWebDriver driver;
        public Library library = null;
       public Abiye AbiyeSayfasi = null;

        #endregion
        #region TestBaslangic

        [OneTimeSetUp]
        public void Initialize()
        {

            driver = new ChromeDriver();
            library = new Library(driver);


    }
    #endregion
    #region TestBitis
    [OneTimeTearDown]
        public void BrowserQuit()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }

        #endregion

      
        #region Elementler
        public readonly By AbiyeSayfasindakiMidiBoyAtlasElbise_BeyazUrunElement = By.XPath("/html/body/form/div[6]/div[3]/div/div[2]/div[4]/div[1]/div[1]/div/div[3]/div[2]/a");
        public readonly By MidiBoyAtlasElbise_BeyazUrunuSayfasindakiSepeteEkleButtonElement = By.XPath("/html/body/form/div[6]/div[2]/div/div[2]/div/div/div[1]/div[3]/div/div[2]/div[11]/div/div[2]/input");
        public readonly By BeyazRenkButtonElement = By.XPath("/html/body/form/div[6]/div[2]/div/div[2]/div/div/div[1]/div[3]/div/div[2]/div[8]/div/span[3]/span");
        public readonly By BedeniSecButtonElement = By.XPath("/html/body/form/div[6]/div[2]/div/div[2]/div/div/div[1]/div[3]/div/div[2]/div[8]/div[2]/span[3]/span[1]");
        public readonly By SepeteEkleButtonElement = By.XPath("/html/body/form/div[6]/div[2]/div/div[2]/div/div/div[1]/div[3]/div/div[2]/div[11]/div/div[2]/input");
        public readonly By SiparisiTamamlaButtonElement = By.ClassName("modalSepetimBtn");
        public readonly By SepetimSayfasindakiSiparisiTamamlaButtonElement = By.XPath("/html/body/form/div[4]/div/div[1]/div[4]/div[1]/div[4]/a");
        public readonly By UyeliksizDevamEtButtonElement = By.XPath("/html/body/form/div[6]/div[2]/div[1]/div/div/div[1]/div/div/a[2]/span");
        public readonly By EpostaTextBoxElement = By.XPath("/html/body/form/div[6]/div[2]/div[1]/div/div/div[1]/div/div/div[1]/input");
        public readonly By SifreTextBoxElement = By.XPath("/html/body/form/div[6]/div[2]/div[1]/div/div/div[1]/div/div/div[2]/input");
        public readonly By GirisYapButtonElement = By.XPath("/html/body/form/div[6]/div[2]/div[1]/div/div/div[1]/div/div/button");
        public readonly By SiparisTamamlaSayfasindakiSiparisTamamlaButtonElement = By.Id("lnkBtnSiparisKaydet2");
        public readonly By OdemeSayfasiKapidaOdemeButtonElement = By.XPath("/html/body/form/div[4]/div[1]/div[4]/div/div[2]/div[1]/div/ul/li[3]/a");
        public readonly By OdemeSayfasiSiparisiTamamlaButtonElement = By.XPath("/html/body/form/div[4]/div[1]/div[4]/div/div[2]/div[2]/div/div[2]/a");
        public readonly By BilgilendirmeFormuOnayliyorumButtonElement = By.XPath("/html/body/form/div[7]/div/div/div/div/div/div[4]/a");

        #endregion

        #endregion
        #region Metodlar


        //[Test, Order(1)]
        //public void AnaSayfaAc()
        //{
        //    library.TicimaxSayfasiniAcVeEkraniFullScreenYapMetod();
        //}

        [Test, Order(1)]
        public void AbiyeSayfasinaGit()
        {
            library.AbiyeSayfasinaGitMetod();
        }

        [Test, Order(2)]
        public void AbiyeSayfasindakiMidiBoyAtlasElbiseBeyazUrununeBas()
        {
            driver.Manage().Window.FullScreen();
            var AbiyeSayfasindakiMidiBoyAtlasElbiseBeyazUrununeBas = driver.FindElement(AbiyeSayfasindakiMidiBoyAtlasElbise_BeyazUrunElement);
            AbiyeSayfasindakiMidiBoyAtlasElbiseBeyazUrununeBas.Click();
        }

        [Test, Order(3)]
        public void BeyazRengiSecButonunaBas()
        {
            driver.Manage().Window.FullScreen();
            var BeyazRengiSecButonunaBas = driver.FindElement(BeyazRenkButtonElement);
            BeyazRengiSecButonunaBas.Click();
        }

        [Test, Order(4)]
        public void BedeniSecButonunaBas()
        {
            driver.Manage().Window.FullScreen();
            var BedeniSecButonunaBas = driver.FindElement(BedeniSecButtonElement);
            BedeniSecButonunaBas.Click();
        }

        [Test, Order(5)]
        public void SepeteEkleButonunaBas()
        {
            Thread.Sleep(5000);
            driver.Manage().Window.FullScreen();
            var SepeteEkleButonunaBas = driver.FindElement(SepeteEkleButtonElement);
            SepeteEkleButonunaBas.Click();
            Thread.Sleep(5000);
        }

        [Test, Order(6)]
        public void SiparisiTamamlaButonunaBas()
        {
            Thread.Sleep(5000);
            var SiparisiTamamlaButonunaBas = driver.FindElement(SiparisiTamamlaButtonElement);
            SiparisiTamamlaButonunaBas.Click();
            Thread.Sleep(5000);

        }

        [Test, Order(7)]
        public void SepetimSayfasindakiSiparisiTamamlaButonunaBas()
        {
            Thread.Sleep(5000);
            var SepetimSayfasindakiSiparisiTamamlaButonunaBas = driver.FindElement(SepetimSayfasindakiSiparisiTamamlaButtonElement);
            SepetimSayfasindakiSiparisiTamamlaButonunaBas.Click();
            Thread.Sleep(5000);

        }

        [Test, Order(8)]
        public void LoginOl()
        {
            Thread.Sleep(5000);
            var Eposta = driver.FindElement(EpostaTextBoxElement);
            Eposta.SendKeys("a@mailinator.com");
            var Sifre = driver.FindElement(SifreTextBoxElement);
            Sifre.SendKeys("pYdTg9Dc");
            var GirisYap = driver.FindElement(GirisYapButtonElement);
            GirisYap.Click();
            Thread.Sleep(10000);


        }

        [Test, Order(9)]
        public void SiparisTamamlaSayfasindakiSiparisTamamlaButonunaBas()
        {
            Thread.Sleep(5000);
            var SiparisTamamlaSayfasindakiSiparisTamamlaButonunaBas = driver.FindElement(SiparisTamamlaSayfasindakiSiparisTamamlaButtonElement);
            SiparisTamamlaSayfasindakiSiparisTamamlaButonunaBas.Click();
            Thread.Sleep(5000);

        }

        [Test, Order(10)]
        public void OdemeSayfasiKapidaOdemButonunaBas()
        {
            Thread.Sleep(5000);
            var OdemeSayfasiKapidaOdemeyeBas = driver.FindElement(OdemeSayfasiKapidaOdemeButtonElement);
            OdemeSayfasiKapidaOdemeyeBas.Click();
            Thread.Sleep(5000);

        }

        [Test, Order(11)]
        public void OdemeSayfasiSiparisiTamamlaButonunaBasBas()
        {
            Thread.Sleep(5000);
            var OdemeSayfasiSiparisiTamamlaButonunaBasBas = driver.FindElement(OdemeSayfasiSiparisiTamamlaButtonElement);
            OdemeSayfasiSiparisiTamamlaButonunaBasBas.Click();
            Thread.Sleep(5000);

        }

        [Test, Order(12)]
        public void BilgilendirmeFormuOnayliyorumButonunaBas()
        {
            Thread.Sleep(5000);
            var BilgilendirmeFormuOnayliyorumButonunaBas = driver.FindElement(BilgilendirmeFormuOnayliyorumButtonElement);
            BilgilendirmeFormuOnayliyorumButonunaBas.Click();
            Thread.Sleep(5000);

        }


        #endregion

    }
}
