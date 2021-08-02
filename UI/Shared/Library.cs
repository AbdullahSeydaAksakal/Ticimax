using OpenQA.Selenium;
using System.Threading;

namespace UI.Shared
{

 internal  class Library
    {

        #region Tanimlamalar

        #region Settings

        public IWebDriver driver;

        public Library(IWebDriver d)
        {
            driver = d;
        }

        #endregion

        #region Elementler

        #region Pages
        #region Abiye
        public readonly By AbiyeSayfaElement = By.XPath("/html/body/form/div[3]/div[2]/div/div/ul/li[3]/ul/li[2]/a");
        #endregion
        #region Alisveris
        public readonly By AlisverisSayfaElement = By.XPath("/html/body/form/div[3]/div[2]/div/div/ul/li[3]/ul/li[2]/a");

        #endregion
        #region AnaSayfa
        public readonly By AnaSayfaElement = By.XPath("/html/body/form/div[3]/div[2]/div/div/ul/li[1]/a");
        #endregion
        #region BizeUlasin
        public readonly By BizeUlasinSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region Bluz
        public readonly By BluzSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region Elbise
        public readonly By ElbiseSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region Favorilerim
        public readonly By FavorilerimSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region Gomlek
        public readonly By GomlekSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region Hakkimizda
        public readonly By HakkimizdaSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region KargoTakibi
        public readonly By KargoTakibiSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region KargoVeTeslimat
        public readonly By KargoVeTeslimatSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region KVKK
        public readonly By KVKKSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region Magaza
        public readonly By MagazaSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region Magazalarimiz
        public readonly By MagazalarimizSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region MusteriHizmetleri
        public readonly By MusteriHizmetleriSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region OdemeSecenekleri
        public readonly By OdemeSecenekleriSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region Sepetim
        public readonly By SepetimSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region SikcaSorulanSorular
        public readonly By SikcaSorulanSorularSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region SiparisiTamamla
        public readonly By SiparisiTamamlaSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region SiparisTamamlandi
        public readonly By SiparisTamamlandiSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region UstGiyim
        public readonly By UstGiyimSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region Uyelik
        public readonly By UyelikSayfaElement = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #endregion



        #endregion


        #endregion

        #region Metodlar

        #region SiteyeGit
        public void TicimaxSayfasiniAcVeEkraniFullScreenYapMetod()

        {
           
                driver.Navigate().GoToUrl("https://test3.ticimax.dev/");
                driver.Manage().Window.FullScreen();
           
        }

        #endregion
        #region AbiyeSayfasinaGit
        public void AbiyeSayfasinaGitMetod()
        {
            driver.Navigate().GoToUrl("https://test3.ticimax.dev/abiye-4");
            driver.Manage().Window.FullScreen();
        }
        #endregion
        #region AlisverisSayfasinaGit
        public void AlisverisSayfasinaGitMetod()

        {
            Thread.Sleep(1500);
            driver.FindElement(AlisverisSayfaElement).Click();
        }

        #endregion
        #region AnaSayfayaGit
        public void AnaSayfayaGitMetod()

        {
            Thread.Sleep(1500);
            driver.FindElement(AnaSayfaElement).Click();
        }

        #endregion
        #region BizeUlasinSayfasinaGit
        public void BizeUlasinSayfasinaGitMetod()

        {
            Thread.Sleep(1500);
            driver.FindElement(BizeUlasinSayfaElement).Click();
        }
        #endregion
        #region BluzSayfasinaGit
        public void BluzSayfasinaGitMetod()

        {
            Thread.Sleep(1500);
            driver.FindElement(BluzSayfaElement).Click();
        }
        public readonly By Bluz = By.XPath("/html/body/form/div[10]/div[2]/div/div[2]/div/div/div[1]/div/ul/li[4]/a");
        #endregion
        #region ElbiseSayfasinaGit
        public void ElbiseSayfasinaGitMetod()

        {
            Thread.Sleep(1500);
            driver.FindElement(ElbiseSayfaElement).Click();
        }
        #endregion
        #region FavorilerimSayfasinaGit
        public void FavorilerimSayfasinaGitMetod()

        {
            Thread.Sleep(1500);
            driver.FindElement(FavorilerimSayfaElement).Click();
        }
        #endregion
        #region GomlekSayfasinaGit
        public void GomlekSayfasinaGitMetod()

        {
            Thread.Sleep(1500);
            driver.FindElement(GomlekSayfaElement).Click();
        }
        #endregion
        #region HakkimizdaSayfasinaGit
        public void HakkimizdaSayfasinaGitMetod()

        {
            Thread.Sleep(1500);
            driver.FindElement(HakkimizdaSayfaElement).Click();
        }
        #endregion
        #region KargoTakibiSayfasinaGit
        public void KargoTakibiSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(KargoTakibiSayfaElement).Click();
        }
        #endregion
        #region KargoVeTeslimatSayfasinaGit
        public void KargoVeTeslimatSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(KargoVeTeslimatSayfaElement).Click();
        }
        #endregion
        #region KVKKSayfasinaGit
        public void KVKKSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(KVKKSayfaElement).Click();
        }
        #endregion
        #region MagazaSayfasinaGit
        public void MagazaSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(MagazaSayfaElement).Click();
        }
        #endregion
        #region MagazalarimizSayfasinaGit
        public void MagazalarimizSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(MagazalarimizSayfaElement).Click();
        }
        #endregion
        #region MüsteriHizmetleriSayfasinaGit
        public void MüsteriHizmetleriSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(MusteriHizmetleriSayfaElement).Click();
        }
        #endregion
        #region OdemeSecenekleriSayfasinaGit
        public void OdemeSecenekleriSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(OdemeSecenekleriSayfaElement).Click();
        }
        #endregion
        #region SepetimSayfasinaGit
        public void SepetimSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(SepetimSayfaElement).Click();
        }
        #endregion
        #region SikcaSorulanSorularSayfasinaGit
        public void SikcaSorulanSorularSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(SikcaSorulanSorularSayfaElement).Click();
        }
        #endregion
        #region SiparisiTamamlaSayfasinaGit
        public void SiparisiTamamlaSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(SiparisiTamamlaSayfaElement).Click();
        }
        #endregion
        #region SiparisTamamlandiSayfasinaGit
        public void SiparisTamamlandiSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(SiparisTamamlandiSayfaElement).Click();
        }
        #endregion
        #region UstGiyimSayfasinaGit
        public void UstGiyimSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(UstGiyimSayfaElement).Click();
        }
        #endregion
        #region UyelikSayfasinaGit
        public void UyelikSayfasinaGitMetod()
        {
            Thread.Sleep(1500);
            driver.FindElement(UyelikSayfaElement).Click();
        }
        #endregion






        #endregion




    }

}