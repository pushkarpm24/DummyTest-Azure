using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AzureTestProject1
{
    [TestFixture]
    public class TestClass
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Initilize()
        {

            //using chrome options to disable unwanted notifications
            ChromeOptions opt = new ChromeOptions();
            opt.AddArguments("--disable-notifications");

            //Launch the chrome browser
            driver = new ChromeDriver(opt);

            //Using implicitly wait 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //Maximizing the window
            driver.Manage().Window.Maximize();

            //Enter the url            
            driver.Url = "https://www.facebook.com";
        }

        [Test]
        public void Login()
        {
            Class1 page = new Class1(driver);
            page.GoToHomePage();
        }


        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
