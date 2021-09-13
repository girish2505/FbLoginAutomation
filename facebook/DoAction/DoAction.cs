using System;
using facebook.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;


namespace facebook.DoAction
{
    class DoAction
    {
        public static void AssertTitle(IWebDriver driver)
        {
            string title1 = "Facebook - లాగిన్ లేదా సైన్ అప్";

            string title = driver.Title;

            Assert.AreEqual(title1, title);
        }
        public static void Login(IWebDriver driver)
        {
            LoginPage login = new LoginPage(driver);

            login.email.SendKeys("girishvayugundla@gmail.com");
            System.Threading.Thread.Sleep(2000);

            login.password.SendKeys("Girish@2505");
            System.Threading.Thread.Sleep(2000);

            login.loginBtn.Click();
            System.Threading.Thread.Sleep(2000);

        }
    }
}
