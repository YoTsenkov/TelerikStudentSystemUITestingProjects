namespace TelerikSystem.Core.Pages.MainPage
{
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    public class MainPageMap : BaseElementMap
    {
        public HtmlAnchor LogoutButton
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("ExitMI");
            }
        }

        public HtmlDiv HomePageButtonsContainer
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=homePageButtons");
            }
        }

        public HtmlAnchor Admin
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Contains("Админ"))
                    .FirstOrDefault();
            }
        }
    }
}
