Public Class form1


    Dim WithEvents FpSpread1 As New FarPoint.Win.Spread.FpSpread()
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FpSpread1 = New FarPoint.Win.Spread.FpSpread
        Dim hoja1 As New FarPoint.Win.Spread.SheetView
        hoja1.RowCount = 20

        Dim hoja2 As New FarPoint.Win.Spread.SheetView
        hoja2.RowCount = 20
        FpSpread1.Sheets.Add(hoja1)
        FpSpread1.Sheets.Add(hoja2)

        FpSpread1.Dock = DockStyle.Fill
        Me.Controls.Add(FpSpread1)

    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sheet1
        GenerateCells(0)
        EnableDefaultFilters()
        EnableCustomFilter()

        'Sheet 2
        GenerateCells(1)
        Sheet2Test()

    End Sub

    Private Sub GenerateCells(index)
        For i = 0 To Me.FpSpread1.Sheets(index).Rows.Count - 1
            Dim prctcell As New FarPoint.Win.Spread.CellType.ButtonCellType()
            If i < 10 Then
                prctcell.Text = "Text Button"

            Else

                prctcell.Text = "Test"

            End If

            FpSpread1.Sheets(index).Cells(i, 4).CellType = prctcell
            'FpSpread1.Sheets(0).Cells(i, 5).CellType = prctcell
            FpSpread1.Sheets(index).SetValue(i, 1, 69 + i)
        Next
    End Sub
#Region "Sheet1"


    Private Sub EnableDefaultFilters()
        FpSpread1.ActiveSheet.ColumnHeaderVisible = True
        Dim hideRowFilter As New FarPoint.Win.Spread.HideRowFilter(FpSpread1.ActiveSheet)
        FpSpread1.ActiveSheet.Columns(0, 2).AllowAutoFilter = True
        FpSpread1.ActiveSheet.AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.FilterGadget
    End Sub

    Private Sub EnableCustomFilter()
        ''Display only custom filters created in Column1.
        Dim fcdBoton As New FarPoint.Win.Spread.FilterColumnDefinition(4, FarPoint.Win.Spread.FilterListBehavior.Custom)


        Dim fcd As New FarPoint.Win.Spread.FilterColumnDefinition(1, FarPoint.Win.Spread.FilterListBehavior.SortByMostOccurrences Or FarPoint.Win.Spread.FilterListBehavior.Default)
        Dim fcd1 As New FarPoint.Win.Spread.FilterColumnDefinition(2)
        Dim fcd2 As New FarPoint.Win.Spread.FilterColumnDefinition
        Dim hf As New FarPoint.Win.Spread.HideRowFilter(FpSpread1.Sheets(0))
        hf.AddColumn(fcd)
        hf.AddColumn(fcd)
        hf.AddColumn(fcd1)
        hf.AddColumn(fcdBoton)

        FpSpread1.Sheets(0).RowFilter = hf
        FpSpread1.ActiveSheet.AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.FilterGadget

        ''Add the custom filter created for Column1.

        Dim ccd As FarPoint.Win.Spread.FilterColumnDefinition = FpSpread1.Sheets(0).RowFilter.GetFilterColumnDefinition(4)
        Dim cfi As New CustomFilterButton(FpSpread1.Sheets(0), "Text Button")
        Dim cfi2 As New CustomFilterButton(FpSpread1.Sheets(0), "Test")

        ccd.Filters.Add(cfi)
        ccd.Filters.Add(cfi2)




    End Sub



#End Region

#Region "Sheet2"
    Private Sub Sheet2Test()

        Dim indexSheet As Integer = 1
        ''Display only custom filters created in Column1.
        Dim fcdBoton As New FarPoint.Win.Spread.FilterColumnDefinition(4, FarPoint.Win.Spread.FilterListBehavior.Custom)


        Dim fcd As New FarPoint.Win.Spread.FilterColumnDefinition(1, FarPoint.Win.Spread.FilterListBehavior.SortByMostOccurrences Or FarPoint.Win.Spread.FilterListBehavior.Default)
        Dim fcd1 As New FarPoint.Win.Spread.FilterColumnDefinition(2)
        Dim fcd2 As New FarPoint.Win.Spread.FilterColumnDefinition
        Dim hf As New FarPoint.Win.Spread.HideRowFilter(FpSpread1.Sheets(indexSheet))
        hf.AddColumn(fcd)
        hf.AddColumn(fcd)
        hf.AddColumn(fcd1)
        hf.AddColumn(fcdBoton)

        FpSpread1.Sheets(indexSheet).RowFilter = hf
        FpSpread1.ActiveSheet.AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.FilterGadget

        ''Add the custom filter created for Column1.

        Dim ccd As FarPoint.Win.Spread.FilterColumnDefinition = FpSpread1.Sheets(indexSheet).RowFilter.GetFilterColumnDefinition(4)
        Dim cfi As New CustomFilterButton(FpSpread1.Sheets(indexSheet), "Text Button")
        Dim cfi2 As New CustomFilterButton(FpSpread1.Sheets(indexSheet), "Test")

        ccd.Filters.Add(cfi)
        ccd.Filters.Add(cfi2)

        FpSpread1.Sheets(indexSheet).AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.EnhancedContextMenu
    End Sub
#End Region

End Class

Class algo
    Inherits FarPoint.Win.Spread.FilterItemValue


    Sub New()
        MyBase.New("Test")

    End Sub
End Class