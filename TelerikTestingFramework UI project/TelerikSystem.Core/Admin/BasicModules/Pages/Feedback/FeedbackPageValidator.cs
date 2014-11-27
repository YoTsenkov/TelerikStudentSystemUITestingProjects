namespace TelerikSystem.Core.Admin.BasicModules.Pages.Feedback
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class FeedbackPageValidator
    {
        public void AssertMessagePresent(string message)
        {
            Assert.IsTrue(Pages<FeedbackPage>.Instance.IsMessagePresent(message));
        }
    }
}
