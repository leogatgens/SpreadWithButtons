Public Class form1


    Dim WithEvents FpSpread1 As New FarPoint.Win.Spread.FpSpread()
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FpSpread1 = New FarPoint.Win.Spread.FpSpread
        Dim hoja1 As New FarPoint.Win.Spread.SheetView
        hoja1.RowCount = 20
        FpSpread1.Sheets.Add(hoja1)
        FpSpread1.Dock = DockStyle.Fill
        Me.Controls.Add(FpSpread1)

    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


        GenerarCeldas()

        EnableDefaultFilters()
        EnableCustomFilter()
    End Sub

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
        Dim hf As New FarPoint.Win.Spread.HideRowFilter(FpSpread1.ActiveSheet)
        hf.AddColumn(fcd)
        hf.AddColumn(fcd)
        hf.AddColumn(fcd1)
        hf.AddColumn(fcdBoton)

        FpSpread1.ActiveSheet.RowFilter = hf
        FpSpread1.ActiveSheet.AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.EnhancedContextMenu

        ''Add the custom filter created for Column1.

        Dim ccd As FarPoint.Win.Spread.FilterColumnDefinition = FpSpread1.ActiveSheet.RowFilter.GetFilterColumnDefinition(4)
        Dim cfi As New CustomFilterButton(FpSpread1.ActiveSheet, "Text Button")
        Dim cfi2 As New CustomFilterButton(FpSpread1.ActiveSheet, "Test")

        ccd.Filters.Add(cfi)
        ccd.Filters.Add(cfi2)



    End Sub

    Private Sub GenerarCeldas()
        FpSpread1.ActiveSheet.DefaultStyle.CellType = New FarPoint.Win.Spread.CellType.NumberCellType
        FpSpread1.ActiveSheet.SetValue(0, 0, 10)
        FpSpread1.ActiveSheet.SetValue(1, 0, 100)
        FpSpread1.ActiveSheet.SetValue(2, 0, 50)
        FpSpread1.ActiveSheet.SetValue(3, 0, 40)
        FpSpread1.ActiveSheet.SetValue(4, 0, 80)
        FpSpread1.ActiveSheet.SetValue(5, 0, 1)
        FpSpread1.ActiveSheet.SetValue(6, 0, 65)
        FpSpread1.ActiveSheet.SetValue(7, 0, 20)
        FpSpread1.ActiveSheet.SetValue(8, 0, 30)
        FpSpread1.ActiveSheet.SetValue(9, 0, 35)





        For i = 0 To Me.FpSpread1.ActiveSheet.Rows.Count - 1
            Dim prctcell As New FarPoint.Win.Spread.CellType.ButtonCellType()
            If i < 10 Then
                prctcell.Text = "Text Button"

            Else

                prctcell.Text = "Test"

            End If

            FpSpread1.ActiveSheet.Cells(i, 4).CellType = prctcell
            FpSpread1.ActiveSheet.SetValue(i, 1, 69)
        Next
    End Sub


End Class