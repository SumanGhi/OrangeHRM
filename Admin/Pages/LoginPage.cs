namespace AdminPage
{
    public class LoginPage : LoginObject
    {
        public LoginVerify Login()
        {
            UserName.SendKeys("Admin");
            Password.SendKeys("admin123");
            LoginBtn.Click();
            return new LoginVerify();
        }
    }
}
