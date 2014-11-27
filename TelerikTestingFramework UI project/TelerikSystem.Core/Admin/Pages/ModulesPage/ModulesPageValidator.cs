using ArtOfTest.Common.UnitTesting;
using TestingFramework.Core.Base;
namespace TelerikSystem.Core.Admin.Pages.ModulesPage
{
    public class ModulesPageValidator
    {
        public void AssertSettingsModuleExists()
        {
           Assert.IsTrue(Pages<ModulesPage>.Instance.Map.SettingsModule.IsVisible());
        }
    }
}
