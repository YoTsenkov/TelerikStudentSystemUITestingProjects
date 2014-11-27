namespace TelerikSystem.Tests.Admin.BasicModules.Auditoriums
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikSystem.Core.Admin.BasicModules.Pages.Auditoriums;
    using TelerikSystem.Core.Pages.LoginPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;
    using System.Linq;

    [TestClass]
    public class AuditoriumTests : BaseTest
    {
        private User testUser;
        public override void TestInit()
        {
            this.testUser = new User
            {
                Username = "kalimar",
                Password = "space password"
            };
        }
        [TestMethod]
        public void Auditorium_CanCreateNewAuditorium()
        {
            var sut = Pages<AuditoriumPage>.Instance;

            Pages<LoginPage>.Instance.LoginUser(testUser);
            sut.Navigate();
            sut.AddAuditorium("test", "test", "30", "testing stuff");
            var allAuditoriums = sut.GetAllAuditoriums();

            Assert.IsTrue(allAuditoriums.Any(x => x.Name == "test"));
        }

        [TestMethod]
        public void Auditorium_CanDeleteAuditorium()
        {
            var sut = Pages<AuditoriumPage>.Instance;

            Pages<LoginPage>.Instance.LoginUser(testUser);

            sut.Navigate();
            sut.DeleteAuditorium(9);
            var allAuditoriums = sut.GetAllAuditoriums();

            Assert.IsTrue(!allAuditoriums.Any(x => x.Name == "test"));
        }
    }
}
