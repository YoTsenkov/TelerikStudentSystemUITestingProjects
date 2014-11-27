using ArtOfTest.WebAii.Controls.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core.Base;

namespace TelerikSystem.Core.Pages.MainPage
{
    public class MainPage : BasePage<MainPageMap, MainPageValidator>
    {
        public override string Url 
        {
            get
            {
                return @"http://test.telerikacademy.com/";
            } 
        }

        public void LogOut()
        {
            this.Map.LogoutButton.Click();
        }

        public bool IsCourseButtonPresent(string courseName, int courseId)
        {
            var buttonElements = Pages<MainPage>.Instance.Map.HomePageButtonsContainer
               .Find.AllByTagName<HtmlAnchor>("a");
            var buttons = new Dictionary<string, string>();
            foreach (var element in buttonElements)
            {
                string lastHrefPart = element.HRef.Split('/')[element.HRef.Split('/').Length - 1];
                string elementName = element.TextContent;
                buttons.Add(elementName, lastHrefPart);
            }

            string courseIdAsString = courseId.ToString();
            
            if (buttons.ContainsKey(courseName) && buttons[courseName] == courseIdAsString)
            {
                return true;
            }

            return false;
        }
    }
}
