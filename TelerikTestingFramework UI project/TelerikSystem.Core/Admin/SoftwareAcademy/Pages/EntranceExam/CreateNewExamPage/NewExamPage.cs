namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.CreateNewExamPage
{
    using System;
    using System.Linq;
    using System.Threading;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;

    public class NewExamPage : BasePage<NewExamPageMap, NewExamPageValidator>
    {
        public override string Url
        {
            get { return @"http://test.telerikacademy.com/Administration_SoftwareAcademy/CandidateExams"; }
        }

        public void EntranceExam_CreateNewExam()
        {
            this.Map.GetToExams.FireClick();
            this.Map.IqConfigurationId.Find.AllByTagName<HtmlListItem>("li")[1].Click();
            this.Map.ItConfigurationId.Find.AllByTagName<HtmlListItem>("li")[2].Click();
            this.Map.EnglishTestConfigurationId.Find.AllByTagName<HtmlListItem>("li")[3].Click();
            // TODO MAKE IT DateTime.Now.ToString("19/10/2014 19:51:52").addMinutes/days or something similar;
      //      this.Map.StartTime.FireChange();
          //  this.Map.StartTime.SelectDay(DateTime.Now.AddDays(2.0).ToString());// = "25/11/2014 19:51:52";
            //this.Map.StartTime.NavigateToFuture();
    //        this.Map.EndTime.FireChange();
            //this.Map.EndTime.Value = "25/11/2014 22:51:52";
            //this.Map.EndTime.NavigateToFuture() ;
            //this.Map.EndTime.SetValue("aria-label", "Current focused date is 25/11/2014 20:51:52");
            this.Map.TrainingRoomOption.Find.AllByTagName<HtmlListItem>("li")[1].Click();
            this.Map.AllowedIps.FireChange();
            this.Map.AllowedIps.Text = "*1";
            this.Map.StudentsLimit.FireChange();
            this.Map.StudentsLimit.Text = "35";
          //  this.Map.CancelButton.FireClick();
            Thread.Sleep(10000);
            this.Map.UpdateButton.FireClick();
            Thread.Sleep(10000);
        }
    }
}