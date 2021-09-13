using NUnit.Framework;
using OpenQA.Selenium;

namespace facebook.NewAccount
{
    public class CreateNewAccount
    {
        public static void AssertTitle(IWebDriver driver)
        {
            string title1 = "Facebook - లాగిన్ లేదా సైన్ అప్";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void CreatingNewAcc_On_Facebook(IWebDriver driver)
        {
            IWebElement signup = driver.FindElement(By.XPath("//*[text()='Create New Account']"));
            signup.Click();

            IWebElement firstname = driver.FindElement(By.Name("firstname"));
            firstname.SendKeys("girish");

            IWebElement lastname = driver.FindElement(By.Name("lastname"));
            lastname.SendKeys("guptha");

            IWebElement email = driver.FindElement(By.Name("reg_email__"));
            email.SendKeys("vgirish25@gmail.com");


        }
    }
}
