namespace TelerikSystem.Core.Pages.LoginPage
{
    using TestingFramework.Core.Models;
    using TestingFramework.Core.Base;

    public class LoginPage : BasePage<LoginPageMap, LoginPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/Users/Auth/Login";
            }
        }

        public void LoginUser(User user)
        {
            this.Navigate();
            this.Map.Username.Text = user.Username;
            this.Map.Password.Text = user.Password;
            this.Map.Submit.Click();
        }       
    }
}
