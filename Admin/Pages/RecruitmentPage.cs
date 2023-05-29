using OpenQA.Selenium;

namespace AdminPage
{
    public class RecruitmentPage : RecruitmentObject
    {

        public RecruitmentPage OpenVacancies()
        {
            Vacancies.Click();
            return new RecruitmentPage();
        }
        public RecruitmentPage OpenCandidates()
        {
            Candidates.Click();
            return new RecruitmentPage();
        }
        public RecruitmentVerify AddCandidate(string fname,string lname, string email)
        {
            AddBtn.Click();
            
            List<IWebElement> inputElements = new() { FirstName, LastName, Email };
            List<string> inputValues = new() { fname,lname,email };

            Vacancy.Click();
            SelectVacancy.Click();
            Add(inputElements, inputValues);
            SaveBtn.Click();
            return new();
        }
        public RecruitmentVerify SearchCandidate()
        {
            VacancyDropdown.Click();
            SelectVacancy.Click();
            CandidateName.SendKeys("Suman");
            Thread.Sleep(1000);
            CandidateName.SendKeys(Keys.ArrowDown + Keys.Enter);
            Search.Click();
            return new();

        }
        public RecruitmentVerify AddVacancies(string vname)
        {
            AddBtn.Click();
            VacancyName.SendKeys(vname);
            JobTitle.Click();
            JobTitle.SendKeys(Keys.ArrowDown+Keys.Enter);
            HiringManager.SendKeys("test");
            Thread.Sleep(1000);
            HiringManager.SendKeys(Keys.ArrowDown + Keys.Enter);
            SaveBtn.Submit();
            return new();

        }
        public RecruitmentVerify SearchVacancies()
        {
            VacancyDropdown.Click();
            SelectVacancy.Click();
            Search.Click();
            return new();

        }
    }
}
