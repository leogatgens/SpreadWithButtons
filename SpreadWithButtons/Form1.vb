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

        Dim columnobj As FarPoint.Win.Spread.Column
        columnobj = hoja1.Columns(0, 10)
        'columnobj.Locked = True
        '        hoja1.OperationMode = OperationMode.ReadOnly

        Dim hoja2 As New FarPoint.Win.Spread.SheetView
        hoja2.RowCount = 500
        hoja2.ColumnCount = 70
        Dim columnasHoja2 As FarPoint.Win.Spread.Column
        columnasHoja2 = hoja2.Columns(0, 20)
        'columnasHoja2.Locked = True
        FpSpread1.Sheets.Add(hoja1)
        FpSpread1.Sheets.Add(hoja2)

        FpSpread1.Dock = DockStyle.Fill
        Me.Controls.Add(FpSpread1)


        AddHandler FpSpread1.ButtonClicked, handler
        AddHandler FpSpread1.KeyDown, AddressOf manejoEnter



        'AddHandler FpSpread1.Enter, handler
        Dim eh As FarPoint.Win.Spread.EditModeStartingEventHandler = AddressOf FpSpread1EditModeStarting
        AddHandler FpSpread1.EditModeStarting, eh

        AddHandler FpSpread1.EditModeOff, AddressOf ManejoEditModeOff
        AddHandler FpSpread1.EditModeOn, AddressOf ManejoEditModeOn
        AddHandler FpSpread1.EditChange, AddressOf ManejoEditChange
        AddHandler FpSpread1.MouseDown, AddressOf ManejoMouseDown
        AddHandler FpSpread1.SelectionChanged, AddressOf ManejoSelectionChanged
        AddHandler FpSpread1.ActiveSheetChanging, AddressOf ManejoActiveSheetChanging
        AddHandler FpSpread1.ActiveSheetChanged, AddressOf ManejoActiveSheetChanged
        AddHandler FpSpread1.ActiveSheetChanging, AddressOf ManejoSelectionChanging
        AddHandler FpSpread1.LeaveCell, AddressOf ManejoLeaveCell
        AddHandler FpSpread1.Change, AddressOf ManejoChange
        AddHandler FpSpread1.DragFillBlock, AddressOf ManejoDragFillBlock
        AddHandler FpSpread1.DragFillBlockCompleted, AddressOf ManejoDragFillBlockCompleted




















        Dim im As FarPoint.Win.Spread.InputMap = New FarPoint.Win.Spread.InputMap()

        im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)



        im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.Space), FarPoint.Win.Spread.SpreadActions.None)



        'Dim im2 As FarPoint.Win.Spread.InputMap = New FarPoint.Win.Spread.InputMap()
        'im2 = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)
        'im2.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.None)


        FpSpread1.ActiveSheet.FrozenColumnCount = 10

    End Sub

    Private Sub ManejoDragFillBlockCompleted(sender As Object, e As DragFillBlockCompletedEventArgs)
        Debug.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod.Name.ToString + ": " + FpSpread1.ActiveSheet.ActiveCell.Text)

    End Sub

    Private Sub ManejoDragFillBlock(sender As Object, e As DragFillBlockEventArgs)
        Debug.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod.Name.ToString + ": " + FpSpread1.ActiveSheet.ActiveCell.Text)
    End Sub

    Private Sub ManejoChange(sender As Object, e As ChangeEventArgs)
        Debug.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod.Name.ToString + ": " + FpSpread1.ActiveSheet.ActiveCell.Text)
    End Sub

    Private Sub ManejoLeaveCell(sender As Object, e As LeaveCellEventArgs)
        Debug.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod.Name.ToString + ": " + FpSpread1.ActiveSheet.ActiveCell.Text)
    End Sub

    Private Sub ManejoSelectionChanging(sender As Object, e As ActiveSheetChangingEventArgs)
        Debug.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod.Name.ToString + ": " + FpSpread1.ActiveSheet.ActiveCell.Text)
    End Sub

    Private Sub ManejoActiveSheetChanged(sender As Object, e As ActiveSheetChangingEventArgs)
        Debug.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod.Name.ToString + ": " + FpSpread1.ActiveSheet.ActiveCell.Text)
    End Sub

    Private Sub ManejoActiveSheetChanging(sender As Object, e As ActiveSheetChangingEventArgs)
        Debug.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod.Name.ToString + ": " + FpSpread1.ActiveSheet.ActiveCell.Text)
    End Sub

    Private Sub ManejoSelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        Debug.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod.Name.ToString + ": " + FpSpread1.ActiveSheet.ActiveCell.Text)
    End Sub

    Private Sub ManejoMouseDown(sender As Object, e As MouseEventArgs)
        Debug.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod.Name.ToString + ": " + FpSpread1.ActiveSheet.ActiveCell.Value)

        FpSpread1.StopCellEditing()
    End Sub

    Private Sub ManejoEditChange(sender As Object, e As EditorNotifyEventArgs)
        Debug.WriteLine(System.Reflection.MethodInfo.GetCurrentMethod.Name.ToString + ": " + FpSpread1.ActiveSheet.ActiveCell.Text)
    End Sub



    Private Sub ManejoEditModeOn(sender As Object, e As EventArgs)
        Debug.WriteLine("ManejoEditModeOn: " + FpSpread1.ActiveSheet.ActiveCell.Text)


        'Dim prctcell As New FarPoint.Win.Spread.CellType.ButtonCellType()
        'FpSpread1.ActiveSheet.ActiveCell.CellType = prctcell
        'prctcell.Text = "GAto"
        'FpSpread1.ActiveSheet.ActiveCell.Value = "GAto"

    End Sub

    Private Sub ManejoEditModeOff(sender As Object, e As EventArgs)
        Debug.WriteLine("ManejoEditModeOff: " + FpSpread1.ActiveSheet.ActiveCell.Text)
    End Sub

    Private Sub FpSpread1EditModeStarting(sender As Object, e As EditModeStartingEventArgs)
        Debug.WriteLine("FpSpread1EditModeStarting: " + FpSpread1.ActiveSheet.ActiveCell.Text)

        'e.Cancel = True
    End Sub

    Private Sub manejoEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (e.KeyCode = Keys.[Return]) AndAlso (TypeOf FpSpread1.ActiveSheet.ActiveCell.CellType Is ButtonCellType) Then
            FpSpread1_ButtonClicked(sender, New FarPoint.Win.Spread.EditorNotifyEventArgs(FpSpread1.GetRootWorkbook(), Nothing, FpSpread1.ActiveSheet.ActiveRowIndex, FpSpread1.ActiveSheet.ActiveColumnIndex))
            FpSpread1.StopCellEditing()
            e.Handled = True
        End If

        FpSpread1.ActiveSheet.FrozenColumnCount = 0
    End Sub




    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sheet1
        GenerateCells(0)
        GenerateText(0)
        EnableDefaultFilters()
        EnableCustomFilter()

        'Sheet 2
        GenerateCells(1)
        Sheet2Test()

    End Sub

    Private Sub GenerateText(index)
        For i = 0 To Me.FpSpread1.Sheets(index).Rows.Count - 1
            For j = 0 To 3
                Me.FpSpread1.ActiveSheet.Cells(i, j).Text = "Hola"


            Next

        Next
    End Sub


    Private Sub GenerateCells(index)
        For i = 0 To Me.FpSpread1.Sheets(index).Rows.Count - 1
            For j = 4 To Me.FpSpread1.Sheets(index).columns.Count - 1
                Dim bttncell As New FarPoint.Win.Spread.CellType.ButtonCellType()
                AddHandler bttncell.EditingCanceled, AddressOf PruebaParar

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
                FpSpread1.Sheets(index).Cells(i, j).Locked = False
                FpSpread1.Sheets(1).Cells(i, j).CellPadding = New CellPadding(5)
                'FpSpread1.Sheets(0).Cells(i, 5).CellType = prctcell
                'FpSpread1.Sheets(index).SetValue(i, 1, 69 + i)

            Next

        Next
    End Sub

    Private Function PruebaParar(ByVal sender As Object, ByVal e As EventArgs) As EventHandler
        Debug.WriteLine("Cancelo Edicion:" + FpSpread1.ActiveSheet.ActiveCell.Text)

    End Function

    Private Sub FpSpread1_ButtonClicked(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EditorNotifyEventArgs) Handles FpSpread1.ButtonClicked
        'Dim algo = e.EditingControl
        'algo.Text = "adfsssssssssssss"

        Dim hoja = DirectCast(sender, FpSpread)

        'Dim prctcell As New FarPoint.Win.Spread.CellType.ButtonCellType()

        'Dim texto As String = "OJO"

        Debug.WriteLine("Enter en boton")

        'FpSpread1.ActiveSheet.Cells(e.Row, e.Column).CellType = prctcell
        'prctcell.Text = texto
        'hoja.ActiveSheet.SetValue(e.Row, e.Column, "pato")

        'MsgBox("Eso lo lograste")
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









