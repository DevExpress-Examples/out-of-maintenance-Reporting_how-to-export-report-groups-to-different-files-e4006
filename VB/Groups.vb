Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace ExportGroups
    Public Class Groups
        Public Sub New(ByVal startPageIndex As Integer, ByVal endPageIndex As Integer)
            Me.startPageIndex_Renamed = startPageIndex
            Me.endPageIndex_Renamed = endPageIndex
        End Sub


        Private startPageIndex_Renamed As Integer

        Private endPageIndex_Renamed As Integer

        Public Property StartPageIndex() As Integer
            Get
                Return startPageIndex_Renamed
            End Get
            Set(ByVal value As Integer)
                startPageIndex_Renamed = value
            End Set
        End Property

        Public Property EndPageIndex() As Integer
            Get
                Return endPageIndex_Renamed
            End Get
            Set(ByVal value As Integer)
                endPageIndex_Renamed = value
            End Set
        End Property
    End Class
End Namespace
