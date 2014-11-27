namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage
{
    using ArtOfTest.Common.UnitTesting;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.AcceptPolicy;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.AdditionalQuestions;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.Documents;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.PersonalInfo;
    using TestingFramework.Core.Base;

    public class ApplySofAcademyPageValidator
    {
        private readonly string errorMessageQ9 = "Моля попълнете допълнителните полета на въпроса 'Откъде научихте за програмата Telerik Software Academy?'";
        private readonly string errorMessageQ10 = "Моля отговорете на въпроса 'Кандидатствали ли сте преди в Софтуерната академия на Телерик?'";

        public void AssertIsNotInCandidatePeriod()
        {
            Assert.IsTrue(
                Pages<ApplySofAcademyPage>.Instance.Map.MainContent.InnerText
                .Contains("За съжаление периодът на кандидатстване за академията изтече."));
        }

        public void AssertIsInCandidatePeriod()
        {
            Assert.IsTrue(
                Pages<ApplySofAcademyPage>.Instance.Map.MainContent.InnerText
                .Contains("Кандидатстване за \"Софтуерната академия на Телерик\""));
        }

        //q09:Откъде научихте за програмата Telerik Software Academy?
        public void AssertCantApplyAsQ09_InvalidCarierCenter_InvalidInputData(string invalidData)
        {
            ApplyCantApplyAsQ09_InvalidCarierCenter(invalidData);
            Pages<AcceptTermsPart>.Instance.Map.AcceptTerms.Click();
            Pages<ApplySofAcademyPage>.Instance.Map.ApplyButton.Click();

            Assert.IsTrue(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(errorMessageQ9), string.Format("{0} is invalid input", invalidData));

        }

        public void AssertCantApplyAsQ09_InvalidCarierCenter_ValidInputData(string validData)
        {

            ApplyCantApplyAsQ09_InvalidCarierCenter(validData);
            Pages<ApplySofAcademyPage>.Instance.Map.ApplyButton.Click();

            Assert.IsFalse(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(errorMessageQ9), string.Format("{0} is invalid input", validData));

        }

        #region[Question10]
        //q10:Кандидатствали ли сте преди в Софтуерната академия на Телерик?
        public void AssertCantApplyAsQ10_NoSelection()
        {
            string validInput = "асдфг";

            this.FullfilPersolalDataAndDocument();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q1Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q2Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q3Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q4Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q5Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q6Checkbox1.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q7Checkbox9.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q8Checkbox16.Click();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q9Checkbox31.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q9Checkbox31Text.Text = validInput;

            Pages<AdditionalQuestionsPart>.Instance.Map.Q11RadioButton42.Click();

            Pages<AcceptTermsPart>.Instance.Map.AcceptTerms.Click();
            Pages<ApplySofAcademyPage>.Instance.Map.ApplyButton.Click();

            Assert.IsTrue(Pages<ApplySofAcademyPage>.Instance.Map.MainMessage.InnerText.Contains(errorMessageQ10));
        }
        #endregion

        private void ApplyCantApplyAsQ09_InvalidCarierCenter(string insetDataTestInput)
        {
            string validInput = "асдфг";
            this.FullfilPersolalDataAndDocument();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q1Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q2Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q3Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q4Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q5Text.Text = validInput;
            Pages<AdditionalQuestionsPart>.Instance.Map.Q6Checkbox1.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q7Checkbox9.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q8Checkbox16.Click();

            Pages<AdditionalQuestionsPart>.Instance.Map.Q9Checkbox31.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q9Checkbox31Text.Text = insetDataTestInput;

            Pages<AdditionalQuestionsPart>.Instance.Map.Q10RadioButton39.Click();
            Pages<AdditionalQuestionsPart>.Instance.Map.Q11RadioButton42.Click();
        }

        private void FullfilPersolalDataAndDocument()
        {
            Pages<PersonalInfoPart>.Instance.SetValidInputPersonalInfo();
            Pages<DocumentsPart>.Instance.SetValidDocuments();
        }

    }
}
