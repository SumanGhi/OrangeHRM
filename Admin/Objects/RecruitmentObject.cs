using Base;
using OpenQA.Selenium;

namespace AdminPage
{
    public class RecruitmentObject : BasePage
    {
        //To add the candidate and vacancies
        protected IWebElement AddBtn => WaitUntilElementIsVisible("//button[text()=' Add ']");
        protected IWebElement Vacancies => WaitUntilElementIsVisible("//a[text()='Vacancies']");
        protected IWebElement Candidates => WaitUntilElementIsVisible("//a[text()='Candidates']");
        protected IWebElement Success => WaitUntilElementIsVisible("//a[text()='Success']");
        #region candidate
        //Candidate form details
        protected IWebElement FirstName => WaitUntilElementIsVisible("//input[@name='firstName']");
        protected IWebElement LastName => WaitUntilElementIsVisible("//input[@name='lastName']");
        protected IWebElement Vacancy => WaitUntilElementIsVisible("//div[@class='oxd-select-text-input']");
        protected IWebElement SelectVacancy => WaitUntilElementIsVisible("//*[text()='Senior QA Lead']");
        protected IWebElement Email => WaitUntilElementIsVisible("//*[text()='Email']//parent::div//following-sibling::div/input");
        protected IWebElement SaveBtn => WaitUntilElementIsVisible("//button[text()=' Save ']");
        #endregion
        #region Search candidate
        protected IWebElement CandidateName => WaitUntilElementIsVisible("//*[text()='Candidate Name']//parent::div//following-sibling::div//input");
        protected IWebElement Search => WaitUntilElementIsVisible("//button[text()=' Search ']");

        #endregion
        #region Add vacancy
        //Add vacancy
        protected IWebElement VacancyName => WaitUntilElementIsVisible("//*[text()='Vacancy Name']//parent::div//following-sibling::div/input");
        protected IWebElement JobTitle => WaitUntilElementIsVisible("//div[@class='oxd-select-text-input']");
        protected IWebElement HiringManager => WaitUntilElementIsVisible("//*[text()='Hiring Manager']//parent::div//following-sibling::div//input");
        protected IWebElement SelectJob => WaitUntilElementIsVisible("//*[text()='Analyst']");

        #endregion
        #region Search vacancy
        protected IWebElement VacancyDropdown => WaitUntilElementIsVisible("//*[text()='Vacancy']//parent::div//following-sibling::div/div/div/div[1]");

        #endregion
    }
}
