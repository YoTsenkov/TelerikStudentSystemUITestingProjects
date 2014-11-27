namespace TelerikSystem.Tests.Admin.BasicModules.Feedback
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikSystem.Core.Admin.BasicModules.Pages.Feedback;
    using TelerikSystem.Core.Pages.LoginPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class FeedbackTests : BaseTest
    {
        private User currentUser;

        public override void TestInit()
        {
            currentUser = GetUser.Admin();
        }

        [TestMethod]
        public void ConfirmFeedbackReportExist()
        {
            const string Message = "Message should be at least 20 symbols";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FeedbackPage>.Instance.CreateFeedbackReport(Message);
            Pages<FeedbackPage>.Instance.GoToAdminFeedbackReport();
            Pages<FeedbackPage>.Instance.Validator.AssertMessagePresent(Message);
        }
    }
}
