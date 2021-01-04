Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace ExportGroups
	Public Class Groups
		Public Sub New(ByVal startPageIndex As Integer, ByVal endPageIndex As Integer)
			Me.startPageIndex_Conflict = startPageIndex
			Me.endPageIndex_Conflict = endPageIndex
		End Sub

'INSTANT VB NOTE: The field startPageIndex was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private startPageIndex_Conflict As Integer
'INSTANT VB NOTE: The field endPageIndex was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private endPageIndex_Conflict As Integer

		Public Property StartPageIndex() As Integer
			Get
				Return startPageIndex_Conflict
			End Get
			Set(ByVal value As Integer)
				startPageIndex_Conflict = value
			End Set
		End Property

		Public Property EndPageIndex() As Integer
			Get
				Return endPageIndex_Conflict
			End Get
			Set(ByVal value As Integer)
				endPageIndex_Conflict = value
			End Set
		End Property
	End Class
End Namespace
