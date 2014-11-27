namespace TelerikSystem.Core.Admin.BasicModules.Pages.Feedback
{
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;

    using System.Collections.Generic;

    public class FeedbackPage : BasePage<FeedbackPageMap, FeedbackPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/";
            }
        }

        public void CreateFeedbackReport(string message)
        {
            if (this.Browser.Url != this.Url)
            {
                this.Navigate();
            }

            this.Map.HelpButton.FireClick();
            this.Map.FeedbackUserLink.Click();
            this.Map.Message.Click();
            this.Map.Message.Text = message;
            //this.Map.SubmitButton.Click(); // In order not to have too many similar messages, no delete
        }

        public void GoToAdminFeedbackReport()
        {
            if (this.Browser.Url != this.Url)
            {
                this.Navigate();
            }

            this.Map.AdminButton.Click();
            this.Map.FeedbackAdminLink.Click();
        }

        public bool IsMessagePresent(string message)
        {
            var messagesCount = Pages<FeedbackPage>.Instance.Map.FeedbackGrid.DataItems.Count;
            List<string> allMessages = new List<string>();
            for (int i = 0; i < messagesCount; i++)
            {
                allMessages.Add(Pages<FeedbackPage>.Instance.Map.FeedbackGrid.DataItems[i][4].TextContent);
            }

            return allMessages.Contains(message);
        }

        //public void ResolveFeedbackReport()
        //{
        //    
        //}
    }
}
