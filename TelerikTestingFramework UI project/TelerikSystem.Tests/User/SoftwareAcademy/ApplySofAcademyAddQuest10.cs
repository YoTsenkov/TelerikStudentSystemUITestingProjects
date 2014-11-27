using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Core.Base;
using TestingFramework.Core.Models;
using TelerikSystem.Core.Pages.LoginPage;
using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage;

namespace TelerikSystem.Tests.User.SoftwareAcademy
{
    [TestClass]
    public class ApplySofAcademyAddQuest10 :BaseTest
    {
        private TestingFramework.Core.Models.User currentUser;

        public override void TestInit()
        {
            this.currentUser = GetUser.NotFillApplicationForm();
            this.currentUser.Username = "ccccc";
            this.currentUser.Password = "123456";
        }


      
        [TestMethod]
        public void ApplySofAcademy_AssertMainErrorMessageQ10()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertCantApplyAsQ10_NoSelection();
        }
    }
}
