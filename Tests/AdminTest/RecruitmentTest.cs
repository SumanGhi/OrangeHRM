using AdminPage;
using Base;
using NUnit.Framework;

namespace Tests
{
    [TestFixture, Order(1)]
    internal class RecruitmentTest : BaseSetup
    {
        [Test,Order(0)]
        public void AddNewCandidate()
        {
            MenuPage menu = new();
            menu.OpenRecruitment()
                .AddCandidate("Suman", "Ghimire", "ghimiresuman409@gmail.com");
            menu.OpenRecruitment()
                .AddCandidate("Test1", "test1", "test1@gmail.com");
        }
        [Test,Order(1)]
        public void SearchCandidate()
        {
            MenuPage menu = new();
            menu.OpenRecruitment()
                .OpenCandidates()
                .SearchCandidate();
        }
        [Test,Order(2)]
        public void AddNewVacancies()
        {
            MenuPage menu = new();
            menu.OpenRecruitment()
                .OpenVacancies()
                .AddVacancies("QA manager", "PKtesting06 PKtesting06 p");
            menu.OpenRecruitment()
                .OpenVacancies()
                .AddVacancies("Automation Engineer", "PKtesting06 PKtesting06 p");
        }
        [Test,Order(3)]
        public void SearchVacancies()
        {
            MenuPage menu = new();
            menu.OpenRecruitment()
                .OpenVacancies()
                .SearchVacancies();
        }

    }
}
