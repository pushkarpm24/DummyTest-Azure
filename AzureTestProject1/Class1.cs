using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureTestProject1
{
    public class Class1
    {
        IWebDriver driver;
        public Class1(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailTextbox;
        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement PassTextbox;
        [FindsBy(How = How.XPath, Using = "//*[@id='u_0_b']")]
        public IWebElement LoginButton;

        public void GoToHomePage()
        {
            EmailTextbox.SendKeys("pushkarmorey555@gmail.com");
            PassTextbox.SendKeys("pushkarpm2430");
            LoginButton.Click();
        }
    }
}
