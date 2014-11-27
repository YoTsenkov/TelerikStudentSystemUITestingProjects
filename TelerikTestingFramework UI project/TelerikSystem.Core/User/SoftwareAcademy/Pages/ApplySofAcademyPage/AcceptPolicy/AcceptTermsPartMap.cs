namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.AcceptPolicy
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    [TestClass]
    public class AcceptTermsPartMap : BaseElementMap
    {
        public HtmlInputCheckBox AcceptTerms
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("AcceptTerms");
            }
        }
    }
}
