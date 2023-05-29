using NUnit.Framework;

namespace AdminPage
{
    public class RecruitmentVerify : RecruitmentObject
    {
        public MenuPage VerifyAddedCandidate()
        {
            Assert.That(Success.Displayed, Is.True, "Cannot login");
            return new MenuPage();

        }
        public MenuPage VerifyAddedVacancy()
        {
            Assert.That(Success.Displayed, Is.True, "Cannot login");
            return new MenuPage();

        }

    }
}
