using NUnit.Framework;

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
    }
}