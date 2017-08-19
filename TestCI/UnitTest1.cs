using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestCI
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver _browser;

        const string TUTBY = "https://tut.by";
        const string ONLINER = "https://onliner.by";
        const string LURKMORE = "https://lurkmo.re";


        [OneTimeSetUp]
        public void ClassInit()
        {
            _browser = new ChromeDriver();
            _browser.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void ClassTearDown()
        {
            _browser?.Quit();
        }

        [Test]
        public void TestTutBy()
        {
            _browser.Navigate().GoToUrl(TUTBY);
        }

        [Test]
        public void TestOnliner()
        {
            _browser.Navigate().GoToUrl(ONLINER);
        }

        [Test]
        public void TestLurkmore()
        {
            _browser.Navigate().GoToUrl(LURKMORE);
        }
    }
}
