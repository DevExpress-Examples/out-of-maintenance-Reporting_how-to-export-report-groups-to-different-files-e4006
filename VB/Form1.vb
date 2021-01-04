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
			Using report As New XtraReport1()
				report.CreateDocument()

				For i As Integer = 0 To report.groups.Count - 1
					Using newReport As New XtraReport()
						Dim j As Integer = DirectCast(report.groups(i), Groups).StartPageIndex
						Do While j <= DirectCast(report.groups(i), Groups).EndPageIndex
							newReport.Pages.Add(report.Pages(j))
							j += 1
						Loop
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not handle local variables named the same as class members well:
						Dim name_Conflict As String = Guid.NewGuid().ToString()
						newReport.ExportToPdf(name_Conflict & ".pdf")
					End Using
				Next i
			End Using
		End Sub
	End Class
End Namespace