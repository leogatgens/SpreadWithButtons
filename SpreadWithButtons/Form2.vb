Imports FarPoint.Win.Spread

Public Class Form2


    Dim handler As EditorNotifyEventHandler
    Private Sub FpSpread1_MouseDown(sender As Object, e As MouseEventArgs) Handles FpSpread1.MouseDown
        'MsgBox("FpSpread1_MouseDown")

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler FpSpread1.ButtonClicked, handler
        Dim eh As FarPoint.Win.Spread.EditModeStartingEventHandler = AddressOf FpSpread1EditModeStarting
        AddHandler FpSpread1.EditModeStarting, eh




        GenerateCells()
    End Sub

    Private Sub FpSpread1EditModeStarting(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EditModeStartingEventArgs) Handles FpSpread1.EditModeStarting

        Debug.WriteLine(FpSpread1.ActiveSheet.ActiveCell.Text)

        e.Cancel = True
    End Sub
    Private Sub GenerateCells()
        For i = 0 To Me.FpSpread1.ActiveSheet.Rows.Count - 1
            For j = 4 To Me.FpSpread1.ActiveSheet.Columns.Count - 1
                Dim bttncell As New FarPoint.Win.Spread.CellType.ButtonCellType()


                bttncell.BackgroundStyle = FarPoint.Win.BackStyle.Gradient
                bttncell.ButtonColor = Color.Yellow
                bttncell.ButtonColor2 = Color.Orange
                bttncell.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
                bttncell.ShadowSize = 20




                If i < 10 Then
                    bttncell.Text = "Text Button"
                    FpSpread1.ActiveSheet.Cells(i, j).Value = bttncell.Text


                Else

                    bttncell.Text = "Test"
                    FpSpread1.ActiveSheet.Cells(i, j).Value = bttncell.Text

                End If


                FpSpread1.ActiveSheet.Cells(i, j).CellType = bttncell
                FpSpread1.ActiveSheet.Cells(i, j).Locked = False
                FpSpread1.ActiveSheet.Cells(i, j).CellPadding = New CellPadding(5)
                'FpSpread1.Sheets(0).Cells(i, 5).CellType = prctcell
                'FpSpread1.ActiveSheet.SetValue(i, 1, 69 + i)

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

        'MsgBox("Eso lo lograste")
    End Sub
End Class