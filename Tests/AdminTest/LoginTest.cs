using AdminPage;
using Base;
using NUnit.Framework;

namespace Tests
{
    [TestFixture, Order(0)]
    internal class LoginTest : BaseSetup
    {
        [Test]
        public void LoginWithValidCredential()
        {
            //initialize the object
            LoginPage login = new();
            login.Login()
                .VerifyLogin();
        }

    }
}
