namespace TelerikSystem.Core.Admin.BasicModules.Pages.Auditoriums
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;
    using System.Linq;

    public class AuditoriumPageMap : BaseElementMap
    {
        public HtmlDiv DataGrid
        {
            get
            {
                return Find.ById<HtmlDiv>("DataGrid");
            }
        }

        public HtmlAnchor AddAuditoriumButton
        {
            get
            {
                return DataGrid.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-add");
            }
        }

        public HtmlTable ContentTable
        {
            get
            {
                return DataGrid.Find.ByTagIndex<HtmlTable>("table", 0);
            }
        }


        public HtmlInputText NameInput
        {
            get
            {
                return Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlInputText CapacityInput
        {
            get
            {
                return Find.ById<HtmlInputText>("Capacity");
            }
        }

        public HtmlInputText AddressInput
        {
            get
            {
                return Find.ById<HtmlInputText>("Address");
            }
        }

        public HtmlInputText EquipmentInput
        {
            get
            {
                return Find.ById<HtmlInputText>("Equipment");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-update");
            }
        }

        public HtmlAnchor GetDeleteButtonOf(int id)
        {
            var targetRow = ContentTable.Rows.Single(x => x.Cells[0].TextContent == id.ToString());
            return targetRow.Cells[6].Find.ByTagIndex<HtmlAnchor>("a", 0);
        }
    }
}
