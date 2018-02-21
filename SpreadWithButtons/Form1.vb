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

        GenerarFiltrosCustoms()
    End Sub

    Private Sub GenerarFiltrosCustoms()
        'Display only custom filters created in Column1.
        Dim fcd As New FarPoint.Win.Spread.FilterColumnDefinition(2, FarPoint.Win.Spread.FilterListBehavior.Custom)
        Dim hf As New FarPoint.Win.Spread.HideRowFilter(FpSpread1.ActiveSheet)
        hf.AddColumn(fcd)
        FpSpread1.ActiveSheet.RowFilter = hf


        Dim ccd As FarPoint.Win.Spread.FilterColumnDefinition = FpSpread1.ActiveSheet.RowFilter.GetFilterColumnDefinition(2)
        'Add the custom filter created for Column1.
        For i = 0 To Me.FpSpread1.ActiveSheet.Rows.Count - 1
            Dim cfi As New CustomFilterButton(FpSpread1.ActiveSheet)
            ccd.Filters.Add(cfi)

        Next



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

            If i < 20 Then
                Dim prctcell As New FarPoint.Win.Spread.CellType.ButtonCellType()
                FpSpread1.ActiveSheet.Cells(i, 2).CellType = prctcell

                prctcell.Text = "Text Button"

                'Else

                '    FpSpread1.ActiveSheet.Cells(i, 2).Text = "Hola"

            End If



        Next
    End Sub


End Class