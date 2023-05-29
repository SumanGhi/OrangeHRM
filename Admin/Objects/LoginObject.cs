using Base;
using OpenQA.Selenium;

namespace AdminPage
{
    public class LoginObject : BasePage
    {
        protected IWebElement UserName => WaitUntilElementIsVisible("//input[@name='username']");
        protected IWebElement Password => WaitUntilElementIsVisible("//input[@name='password']");
        protected IWebElement LoginBtn => WaitUntilElementIsVisible("//button[text()=' Login ']");
        protected IWebElement Recruitment => WaitUntilElementIsVisible("//a[@href='/web/index.php/recruitment/viewRecruitmentModule']");


    }
}
