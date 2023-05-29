using NUnit.Framework;

namespace AdminPage
{
    public class LoginVerify : LoginObject
    {
        public MenuPage VerifyLogin()
        {
            Assert.That(Recruitment.Displayed, Is.True, "Cannot login");
            Console.WriteLine("Successfully logged in");
            return new MenuPage();

        }
    }
}
