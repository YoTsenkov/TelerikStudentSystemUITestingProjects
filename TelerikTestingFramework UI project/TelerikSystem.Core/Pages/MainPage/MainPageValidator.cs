namespace TelerikSystem.Core.Pages.MainPage
{
    using TestingFramework.Core.Base;
    using ArtOfTest.Common.UnitTesting;

    public class MainPageValidator
    {
        public void AssertCourseButtonPresent(string courseName, int courseId)
        {
            Pages<MainPage>.Instance.Navigate();
            Assert.IsTrue(Pages<MainPage>.Instance.IsCourseButtonPresent(courseName, courseId));            
        }

        public void AssertCourseButtonNotPresent(string courseName, int courseId)
        {
            Pages<MainPage>.Instance.Navigate();
            Assert.IsFalse(Pages<MainPage>.Instance.IsCourseButtonPresent(courseName, courseId));
        }

        public void AssertAdminIsVisible()
        {
            Pages<MainPage>.Instance.Navigate();
            Assert.IsTrue(Pages<MainPage>.Instance.Map.Admin.IsVisible());
        }
    }
}
