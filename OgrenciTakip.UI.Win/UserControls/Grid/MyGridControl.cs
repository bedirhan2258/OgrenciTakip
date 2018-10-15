using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using OgrenciTakip.UI.Win.Interfaces;
using System.Drawing;
using DevExpress.XtraGrid.Registrator;
using System.ComponentModel;

namespace OgrenciTakip.UI.Win.UserControls.Grid
{
    [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (GridView)CreateView("MyGridView");

            view.Appearance.ViewCaption.ForeColor = Color.Maroon;

            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;

            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            //Menulerin üzerine sağ tıkladıgında default menu açılır.Bunun açılmasını istemiyoruz kendimiz acıcaz bu yuzden bunu false hale getirioruz.
            view.OptionsMenu.EnableColumnMenu = false; //Başlıkları gizledik
            view.OptionsMenu.EnableFooterMenu = false; //Footerı gizledik
            view.OptionsMenu.EnableGroupPanelMenu = false; //Grupların üzerinde verileri gizledik.

            //Enter bastığında diğer alana gitmesini sağlayan özellik.
            view.OptionsNavigation.EnterMoveNextColumn = true;

            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false; //Kolonlar bizim belirlediğimiz genişliklerde kalır.
            view.OptionsView.RowAutoHeight = true;  //Kolon yüksekliklerinin otomatik ayarlanması için.
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            var idColumn = new MyGridColumn();
            idColumn.Caption = "Id";
            idColumn.FieldName = "Id";
            idColumn.OptionsColumn.AllowEdit = false;
            idColumn.OptionsColumn.ShowInCustomizationForm = false; // ctrl + t yaptıgımızda dahil ilgili alanın gözükmemesi sağlar.
            view.Columns.Add(idColumn);

            var kodColumn = new MyGridColumn();
            kodColumn.Caption = "Kod";
            kodColumn.FieldName = "Kod";
            kodColumn.OptionsColumn.AllowEdit = false;
            kodColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            kodColumn.AppearanceCell.Options.UseTextOptions = true; //HAligment üzerinde yaptığımız değişikliklerin geçerli olması için.
            kodColumn.Visible = true;
            view.Columns.Add(kodColumn);


            return view;

        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);

            //Sürükle bırak yaptığımızda oluşucak gridin varsayılan yerine bizim oluşturduğumuz grid den meydana gelmesi için yazıldı.
            collection.Add(new MyGridInfoRegistrator());

        }

        private class MyGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName => "MyGridView";
            public override BaseView CreateView(GridControl grid) => new MyGridView(grid);


        }
    }

    public class MyGridView : GridView, IStatusBarKisayol
    {
        #region Properties
        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; }

        public string StatusBarKisayolAciklama { get; set; }
        #endregion
        public MyGridView() { }
        public MyGridView(GridControl ownerGrid) : base(ownerGrid) { }
        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);


        }

        private class MyGridColumnCollection : GridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }
            protected override GridColumn CreateColumn()
            {
                var column = new MyGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }

    public class MyGridColumn : GridColumn, IStatusBarKisayol
    {
        #region Properties
        public string StatusBarAciklama { get; set; }

        public string StatusBarKisayol { get; set; }

        public string StatusBarKisayolAciklama { get; set; }
        #endregion
    }
}
