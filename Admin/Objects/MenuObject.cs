using Base;
using OpenQA.Selenium;

namespace AdminPage
{
    public class MenuObject : BasePage
    {
        protected IWebElement Recruitment => WaitUntilElementIsVisible("//a[@href='/web/index.php/recruitment/viewRecruitmentModule']");
       
    }
}
