namespace TelerikSystem.Core.Admin.BasicModules.Pages.Auditoriums
{
    using System.Collections.Generic;
    using System.Linq;

    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    public class AuditoriumPage : BasePage<AuditoriumPageMap, AuditoriumsPageValidator>
    {
        public override string Url
        {
            get { return @"http://test.telerikacademy.com/Administration_Courses/TrainingRooms"; }
        }


        public void AddAuditorium(string name, string address, string capacity, string equipment)
        {
            var keyBoard = Manager.Current.Desktop.KeyBoard;

            Map.AddAuditoriumButton.Click();

            Map.NameInput.MouseClick();
            keyBoard.TypeText(name);

            Map.AddressInput.MouseClick();
            keyBoard.TypeText(address);

            Map.CapacityInput.MouseClick();
            keyBoard.TypeText(capacity);

            Map.EquipmentInput.MouseClick();
            keyBoard.TypeText(equipment);

            Map.UpdateButton.Click();
        }

        public IEnumerable<Auditorium> GetAllAuditoriums()
        {
            return Map.ContentTable.Rows.Select(Auditorium.Parse);
        }

        public void DeleteAuditorium(int id)
        {
            var dialog = new AlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(dialog);
            Manager.Current.DialogMonitor.Start();
            Map.GetDeleteButtonOf(id).Click();
            dialog.WaitUntilHandled();
        }
    }
}
