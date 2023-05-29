namespace AdminPage
{
    public class MenuPage : MenuObject
    {
        public RecruitmentPage OpenRecruitment()
        {
            Recruitment.Click();
            return new RecruitmentPage();
        }
    }
}
