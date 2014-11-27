namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.CreateNewExamPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Telerik.TestingFramework.Controls.KendoUI;
    using TestingFramework.Core.Base;

    public class NewExamPageMap : BaseElementMap
    {
        public HtmlUnorderedList IqConfigurationId
        {
            get { return this.Find.ById<HtmlUnorderedList>("IQTestConfigurationId_listbox"); }
        }

        public HtmlUnorderedList ItConfigurationId
        {
            get { return this.Find.ById<HtmlUnorderedList>("ITTestConfigurationId_listbox"); }
        }

        public HtmlUnorderedList EnglishTestConfigurationId
        {
            get { return this.Find.ById<HtmlUnorderedList>("EnglishTestConfigurationId_listbox"); }
        }

        public KendoCalendar StartTime
        {
            get { return this.Find.ByXPath<KendoCalendar>("/html/body/div[12]/div[2]/div/div[8]/span[1]"); }
        }

        public HtmlInputText EndTime
        {
            get { return this.Find.ById<HtmlInputText>("EndTime"); }
        }

        public HtmlUnorderedList TrainingRoomOption
        {
            get { return this.Find.ById<HtmlUnorderedList>("TrainingRoomId_listbox"); }
        }

        public HtmlInputText AllowedIps
        {
            get { return this.Find.ById<HtmlInputText>("AllowedIp"); }
        }

        public HtmlInputNumber StudentsLimit
        {
            get { return this.Find.ById<HtmlInputNumber>("CandidatesCountLimit"); }
        }

        public HtmlAnchor UpdateButton
        {
            get { return this.Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault(a => a.InnerText == "Update"); }
        }

        public HtmlAnchor CancelButton
        {
            get { return this.Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault(a => a.InnerText == "Cancel"); }
        }

        public HtmlAnchor CloseWindowButton
        {
            get { return this.Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault(a => a.InnerText == "Close"); }
        }


        // TODO REMOVE THIS BS FROM HERE, IT IS SUPPOSED TO BE IN "EntranceExamMainPage"!!!!!!!S
        public HtmlAnchor GetToExams
        {
            get { return this.Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault(a => a.InnerText == "Добавяне на нов входен изпит"); }
        }
    }
}