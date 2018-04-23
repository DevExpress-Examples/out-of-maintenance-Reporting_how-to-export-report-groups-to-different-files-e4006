Namespace ExportGroups
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.nwindDataSet1 = New ExportGroups.nwindDataSet()
            Me.customersTableAdapter = New ExportGroups.nwindDataSetTableAdapters.CustomersTableAdapter()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
            Me.Detail.HeightF = 23F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.Country")})
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(303.125F, 0F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(246.875F, 23F)
            Me.xrLabel3.Text = "xrLabel3"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.ContactName")})
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(103.125F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(200F, 23F)
            Me.xrLabel2.Text = "xrLabel2"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomerID")})
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(103.125F, 23F)
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' customersTableAdapter
            ' 
            Me.customersTableAdapter.ClearBeforeFill = True
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel7, Me.xrLabel6, Me.xrLabel5, Me.xrLabel4})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Country", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 23F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.ForeColor = System.Drawing.Color.Transparent
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(550F, 0F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(100F, 4.25F)
            Me.xrLabel7.StylePriority.UseForeColor = False
            Me.xrLabel7.Text = "start"
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.BackColor = System.Drawing.Color.Silver
            Me.xrLabel6.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(303.125F, 0F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(246.875F, 23F)
            Me.xrLabel6.StylePriority.UseBackColor = False
            Me.xrLabel6.StylePriority.UseBorders = False
            Me.xrLabel6.Text = "COUNTRY"
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.BackColor = System.Drawing.Color.Silver
            Me.xrLabel5.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(103.125F, 0F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(200F, 23F)
            Me.xrLabel5.StylePriority.UseBackColor = False
            Me.xrLabel5.StylePriority.UseBorders = False
            Me.xrLabel5.Text = "NAME"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.BackColor = System.Drawing.Color.Silver
            Me.xrLabel4.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(103.125F, 23F)
            Me.xrLabel4.StylePriority.UseBackColor = False
            Me.xrLabel4.StylePriority.UseBorders = False
            Me.xrLabel4.Text = "ID"
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel8})
            Me.GroupFooter1.HeightF = 4.249986F
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.ForeColor = System.Drawing.Color.Transparent
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(550F, 0F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(100F, 3.62498F)
            Me.xrLabel8.StylePriority.UseForeColor = False
            Me.xrLabel8.Text = "end"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1})
            Me.DataAdapter = Me.customersTableAdapter
            Me.DataMember = "Customers"
            Me.DataSource = Me.nwindDataSet1
            Me.Version = "11.1"
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private nwindDataSet1 As nwindDataSet
        Private customersTableAdapter As ExportGroups.nwindDataSetTableAdapters.CustomersTableAdapter
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
        Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
        Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
