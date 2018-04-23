Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace ExportGroups
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            Dim report As New XtraReport1()
            report.CreateDocument()

            For i As Integer = 0 To report.groups.Count - 1
                Dim newReport As New XtraReport()
                For j As Integer = DirectCast(report.groups(i), Groups).StartPageIndex To DirectCast(report.groups(i), Groups).EndPageIndex
                    newReport.Pages.Add(report.Pages(j))
                Next j

                Dim name_Renamed As String = Guid.NewGuid().ToString()
                newReport.ExportToPdf(name_Renamed & ".pdf")
            Next i
        End Sub
    End Class
End Namespace