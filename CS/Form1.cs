using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace ExportGroups {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            using (XtraReport1 report = new XtraReport1()) {
                report.CreateDocument();

                for (int i = 0; i < report.groups.Count; i++) {
                    using (XtraReport newReport = new XtraReport()) {
                        for (int j = ((Groups)report.groups[i]).StartPageIndex; j <= ((Groups)report.groups[i]).EndPageIndex; j++) {
                            newReport.Pages.Add(report.Pages[j]);
                        }
                        string name = Guid.NewGuid().ToString();
                        newReport.ExportToPdf(name + ".pdf");
                    }
                }
            }
        }
    }
}