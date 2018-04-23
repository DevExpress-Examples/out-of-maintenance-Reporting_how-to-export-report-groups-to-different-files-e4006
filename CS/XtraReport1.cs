using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ExportGroups {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        public ArrayList groups = new ArrayList();
        int startPageIndex = 0;
        private void xrLabel7_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            startPageIndex = e.PageIndex;
        }

        private void xrLabel8_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            groups.Add(new Groups(startPageIndex, e.PageIndex));
        }
    }
}
