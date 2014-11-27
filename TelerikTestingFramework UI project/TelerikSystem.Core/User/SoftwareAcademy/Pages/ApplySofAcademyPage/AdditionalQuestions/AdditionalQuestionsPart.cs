using System;
using System.Linq;
using TestingFramework.Core.Base;

namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.AdditionalQuestions
{
    public class AdditionalQuestionsPart : BasePage<AdditionalQuestionsPartMap, ApplySofAcademyPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/SoftwareAcademy/Candidate";
            }
        }
    }
}
