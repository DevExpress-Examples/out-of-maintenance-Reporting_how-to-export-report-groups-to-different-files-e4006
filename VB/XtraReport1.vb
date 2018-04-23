Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace ExportGroups
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Public groups As New ArrayList()
        Private startPageIndex As Integer = 0
        Private Sub xrLabel7_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles xrLabel7.PrintOnPage
            startPageIndex = e.PageIndex
        End Sub

        Private Sub xrLabel8_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles xrLabel8.PrintOnPage
            groups.Add(New Groups(startPageIndex, e.PageIndex))
        End Sub
    End Class
End Namespace
