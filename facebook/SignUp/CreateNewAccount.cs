using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Chrome;

namespace facebook.SignUp
{
    public class CreateNewAccount
    {
        public static void Registration(IWebDriver driver)
        {
            IWebElement CreateButton = driver.FindElement(By.XPath("//*[@class='_6ltg'][2]"));
            CreateButton.Click();
            System.Threading.Thread.Sleep(500);


            driver.FindElement(By.Name("firstname")).SendKeys("girish");
            System.Threading.Thread.Sleep(500);


            driver.FindElement(By.Name("lastname")).SendKeys("guptha");
            System.Threading.Thread.Sleep(500);


            driver.FindElement(By.Name("reg_email__")).SendKeys("vgirishg@gmail.com");
            System.Threading.Thread.Sleep(500);

            driver.FindElement(By.Name("reg_email_confirmation__")).SendKeys("vgirishg@gmail.com");
            System.Threading.Thread.Sleep(500);

            driver.FindElement(By.Name("reg_passwd__")).SendKeys("girish2505");
            System.Threading.Thread.Sleep(500);


            SelectElement element = new SelectElement(driver.FindElement(By.Name("birthday_day")));
            element.SelectByText("25");
            System.Threading.Thread.Sleep(500);


            SelectElement element1 = new SelectElement(driver.FindElement(By.Id("month")));
            element1.SelectByValue("5");
            System.Threading.Thread.Sleep(500);


            SelectElement element2 = new SelectElement(driver.FindElement(By.Id("year")));
            element2.SelectByValue("2000");
            System.Threading.Thread.Sleep(500);


            driver.FindElement(By.Name("sex")).Click();
            System.Threading.Thread.Sleep(500);


            driver.FindElement(By.Name("websubmit")).Click();
            System.Threading.Thread.Sleep(500);
        }
    }
}
