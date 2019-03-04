
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UserDesigner;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Common.Message;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.UI.Win.Forms.RaporForms;
using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Win.Show;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.GeneralForms
{
    public partial class RaporTasarim : RibbonForm, ICommandHandler
    {
        #region Variables
        private readonly Rapor _rapor;

        #endregion

        public RaporTasarim(params object[] prm)
        {
            InitializeComponent();

            _rapor = (Rapor)prm[0];
            Yukle();
        }

        protected internal void Yukle()
        {
            var stream = new MemoryStream(_rapor.Dosya);
            var rapor = stream.StreamToReport();
            reportDesigner.AddCommandHandler(this);
            reportDesigner.OpenReport(rapor);
            reportDesigner.XtraTabbedMdiManager.View.DocumentProperties.AllowClose = false;
            reportDesigner.XtraTabbedMdiManager.View.DocumentProperties.AllowDock = false;
            reportDesigner.XtraTabbedMdiManager.View.DocumentProperties.AllowFloat = false;
            reportDesigner.ActiveDesignPanel.Report.DisplayName = _rapor.RaporAdi;
        }

        private void Kaydet()
        {
            _rapor.Dosya = reportDesigner.ActiveDesignPanel.Report.ReportToStream().GetBuffer();
            var result = ShowEditForms<RaporEditForm>.ShowDialogEditForms(KartTuru.Rapor, _rapor.Id, _rapor.RaporTuru, _rapor.RaporBolumTuru, _rapor.Dosya);
            if (result <= 0) return;

            reportDesigner.ActiveDesignPanel.ReportState = ReportState.Saved;
            DialogResult = DialogResult.OK;
            Tag = result;
            Close();
        }

        private void FarkliKaydet()
        {

        }

        public bool CanHandleCommand(ReportCommand command, ref bool useNextHandler)
        {
            useNextHandler = !(command == ReportCommand.SaveFile || command == ReportCommand.SaveFileAs || command == ReportCommand.Closing);
            return !useNextHandler;
        }

        public void HandleCommand(ReportCommand command, object[] args)
        {
            if (command == ReportCommand.SaveFile)
                Kaydet();
            else if (command == ReportCommand.SaveFileAs)
                FarkliKaydet();

            else if (command == ReportCommand.Closing)
                if (reportDesigner.ActiveDesignPanel.ReportState == ReportState.Changed)
                {
                    var result = Messages.KapanisMesaj();

                    switch (result)
                    {
                        case DialogResult.Yes:
                            Kaydet();
                            break;
                        case DialogResult.No:
                            reportDesigner.ActiveDesignPanel.ReportState = ReportState.Closing;
                            Close();
                            break;
                        case DialogResult.Cancel:
                            var eventArgs = args.Cast<CancelEventArgs>().FirstOrDefault();
                            if (eventArgs != null)
                                eventArgs.Cancel = true;
                            break;
                    }
                }


        }
    }
}