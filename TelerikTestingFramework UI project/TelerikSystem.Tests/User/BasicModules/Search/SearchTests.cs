namespace TelerikSystem.Tests.User.BasicModules.Search
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikSystem.Core.User.BasicModules.Pages.SearchPage;
    using TestingFramework.Core.Base;

    [TestClass]
    public class SearchTests : BaseTest
    {
        [TestMethod]
        public void Search_AssertsTextWhenNoResultFound()
        {
            const string SearchedValue = "abcdef";
            const string ReturnedText = "Вашето търсене не върна резултат";

            Pages<SearchPage>.Instance.SearchText(SearchedValue);
            Pages<SearchPage>.Instance.Validator.AssertText(ReturnedText);
        }

        [TestMethod]
        public void Search_AssertsUsersCount()
        {
            const string SearchedValue = "testuser";
            const int UsersCount = 1;

            Pages<SearchPage>.Instance.SearchText(SearchedValue);
            Pages<SearchPage>.Instance.Validator.AssertUsersCount(UsersCount);
        }

        [TestMethod]
        public void Search_AssertsCoursesCount()
        {
            const string SearchedValue = "testing";
            const int CoursesCount = 2;

            Pages<SearchPage>.Instance.SearchText(SearchedValue);
            Pages<SearchPage>.Instance.Validator.AssertCoursesCount(CoursesCount);
        }

        [TestMethod]
        public void Search_AssertsTracksCount()
        {
            const string SearchedValue = "super";
            const int TracksCount = 1;

            Pages<SearchPage>.Instance.SearchText(SearchedValue);
            Pages<SearchPage>.Instance.Validator.AssertTracksCount(TracksCount);
        }

        [TestMethod]
        public void Search_AssertsUsersAndCoursesCount()
        {
            const string SearchedValue = "user";
            const int UsersCount = 34;
            const int CoursesCount = 1;

            Pages<SearchPage>.Instance.SearchText(SearchedValue);
            Pages<SearchPage>.Instance.Validator.AssertUsersCount(UsersCount);
            Pages<SearchPage>.Instance.Validator.AssertCoursesCount(CoursesCount);
        }
    }
}
