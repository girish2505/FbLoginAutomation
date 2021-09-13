using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace facebook
{
    public class Tests : Base.BaseClass
    {
        [Test]
        public void EnterEmailAndPasswordToLogin()
        {
            DoAction.DoAction.AssertTitle(driver);
            DoAction.DoAction.Login(driver);
        }
        [Test]
        public void CreatingNewAcc()
        {
            SignUp.CreateNewAccount.Registration(driver);
        }
    }
}