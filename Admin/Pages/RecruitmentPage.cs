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
        public void AddCandidate(string fname,string lname, string email)
        {
            AddBtn.Click();
            
            List<IWebElement> inputElements = new() { FirstName, LastName, Email };
            List<string> inputValues = new() { fname,lname,email };

            Vacancy.Click();
            SelectVacancy.Click();
            Add(inputElements, inputValues);
            SaveBtn.Click();
        }
        public void SearchCandidate()
        {
            VacancyDropdown.Click();
            SelectVacancy.Click();
            CandidateName.SendKeys("Test Test");
            Search.Click();

        }
        public void AddVacancies(string vname, string hmanager)
        {
            AddBtn.Click();
            VacancyName.SendKeys(vname);
            JobTitle.Click();
            SelectJob.Click();
            HiringManager.SendKeys(hmanager+Keys.ArrowDown+Keys.Enter);

            SaveBtn.Submit();
        }
        public void SearchVacancies()
        {
            VacancyDropdown.Click();
            SelectVacancy.Click();
            Search.Click();

        }
    }
}
