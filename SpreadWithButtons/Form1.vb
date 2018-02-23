Imports FarPoint.Win.Spread
Imports FarPoint.Win.Spread.CellType

Public Class form1


    Dim WithEvents FpSpread1 As New FarPoint.Win.Spread.FpSpread()

    Dim handler As EditorNotifyEventHandler

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FpSpread1 = New FarPoint.Win.Spread.FpSpread
        Dim hoja1 As New FarPoint.Win.Spread.SheetView
        hoja1.RowCount = 500
        hoja1.ColumnCount = 70

        Dim hoja2 As New FarPoint.Win.Spread.SheetView
        hoja2.RowCount = 500
        hoja2.ColumnCount = 70
        FpSpread1.Sheets.Add(hoja1)
        FpSpread1.Sheets.Add(hoja2)

        FpSpread1.Dock = DockStyle.Fill
        Me.Controls.Add(FpSpread1)


        AddHandler FpSpread1.ButtonClicked, handler
        AddHandler FpSpread1.KeyDown, AddressOf manejoEnter

        'AddHandler FpSpread1.Enter, handler





        Dim im As FarPoint.Win.Spread.InputMap = New FarPoint.Win.Spread.InputMap()

        im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)



        im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.Space), FarPoint.Win.Spread.SpreadActions.None)








    End Sub


    Private Sub manejoEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (e.KeyCode = Keys.[Return]) AndAlso (TypeOf FpSpread1.ActiveSheet.ActiveCell.CellType Is ButtonCellType) Then
            FpSpread1_ButtonClicked(sender, New FarPoint.Win.Spread.EditorNotifyEventArgs(FpSpread1.GetRootWorkbook(), Nothing, FpSpread1.ActiveSheet.ActiveRowIndex, FpSpread1.ActiveSheet.ActiveColumnIndex))
            FpSpread1.StopCellEditing()
        End If
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
            For j = 4 To Me.FpSpread1.Sheets(index).columns.Count - 1
                Dim bttncell As New FarPoint.Win.Spread.CellType.ButtonCellType()
                bttncell.BackgroundStyle = FarPoint.Win.BackStyle.Gradient
                bttncell.ButtonColor = Color.Yellow
                bttncell.ButtonColor2 = Color.Orange
                bttncell.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
                bttncell.ShadowSize = 20



                If i < 10 Then
                    bttncell.Text = "Text Button"
                    FpSpread1.Sheets(index).Cells(i, j).Value = bttncell.Text

                Else

                    bttncell.Text = "Test"
                    FpSpread1.Sheets(index).Cells(i, j).Value = bttncell.Text

                End If

                FpSpread1.Sheets(index).Cells(i, j).CellType = bttncell
                'FpSpread1.Sheets(0).Cells(i, 5).CellType = prctcell
                'FpSpread1.Sheets(index).SetValue(i, 1, 69 + i)

            Next

        Next
    End Sub

    Private Sub FpSpread1_ButtonClicked(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EditorNotifyEventArgs) Handles FpSpread1.ButtonClicked
        'Dim algo = e.EditingControl
        'algo.Text = "adfsssssssssssss"

        Dim hoja = DirectCast(sender, FpSpread)

        Dim prctcell As New FarPoint.Win.Spread.CellType.ButtonCellType()

        Dim texto As String = "OJO"



        FpSpread1.ActiveSheet.Cells(e.Row, e.Column).CellType = prctcell
        prctcell.Text = texto
        hoja.ActiveSheet.SetValue(e.Row, e.Column, texto)
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
        Dim fcdBoton As New FarPoint.Win.Spread.FilterColumnDefinition(4, FarPoint.Win.Spread.FilterListBehavior.Default)
        'Dim fcdBoton As New FarPoint.Win.Spread.FilterColumnDefinition(4, FarPoint.Win.Spread.FilterListBehavior.Custom)


        'Dim fcd As New FarPoint.Win.Spread.FilterColumnDefinition(1, FarPoint.Win.Spread.FilterListBehavior.SortByMostOccurrences Or FarPoint.Win.Spread.FilterListBehavior.Default)
        'Dim fcd1 As New FarPoint.Win.Spread.FilterColumnDefinition(2)
        'Dim fcd2 As New FarPoint.Win.Spread.FilterColumnDefinition
        Dim hf As New FarPoint.Win.Spread.HideRowFilter(FpSpread1.Sheets(indexSheet))
        'hf.AddColumn(fcd)
        'hf.AddColumn(fcd)
        'hf.AddColumn(fcd1)
        hf.AddColumn(fcdBoton)

        FpSpread1.Sheets(indexSheet).RowFilter = hf



#Disable Warning BC42303 ' XML comment cannot appear within a method or a property. XML comment will be ignored.
        '''Add the custom filter created for Column1.

        'Dim ccd As FarPoint.Win.Spread.FilterColumnDefinition = FpSpread1.Sheets(indexSheet).RowFilter.GetFilterColumnDefinition(4)
        'Dim cfi As New CustomFilterButton(FpSpread1.Sheets(indexSheet), "Text Button")
        'Dim cfi2 As New CustomFilterButton(FpSpread1.Sheets(indexSheet), "Test")

        'ccd.Filters.Add(cfi)
        'ccd.Filters.Add(cfi2)

        FpSpread1.Sheets(indexSheet).AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.EnhancedContextMenu
#Enable Warning BC42303 ' XML comment cannot appear within a method or a property. XML comment will be ignored.
    End Sub
#End Region

End Class

Class algo
    Inherits FarPoint.Win.Spread.FilterItemValue


    Sub New()
        MyBase.New("Test")

    End Sub
End Class