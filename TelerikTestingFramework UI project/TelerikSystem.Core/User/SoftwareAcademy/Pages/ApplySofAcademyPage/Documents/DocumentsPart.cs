namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.Documents
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestingFramework.Core.Base;

    [TestClass]
    public class DocumentsPart : BasePage<DocumentsPartMap, ApplySofAcademyPageValidator> // Нямам валидатор
    {

        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/SoftwareAcademy/Candidate"; // това не ми трябва !!!!
            }
        }

        public void SetValidDocuments()
        {
            this.Map.Cv.Upload(@"C:\Data\CV.docx",1000);
            this.Map.Cl.Upload(@"C:\Data\CL.docx", 1000);
           // this.Map.AddDoc.Upload(@"C:\Data\CL.docx", 1000);
        }
    }
}
