using System;
using System.Linq;

namespace TelerikSystem.Tests.Admin.SoftwareAcademy.EntranceExam
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.CreateNewExamPage;
    using TelerikSystem.Core.Pages.LoginPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class EntranceExamTests : BaseTest
    {
        [TestMethod]
        public void CreateNewExam()
        {
            var user = GetUser.Admin();
            var page = Pages<NewExamPage>.Instance;
            Pages<LoginPage>.Instance.LoginUser(user);
            page.Navigate();
            page.EntranceExam_CreateNewExam();
        }
    }
}
