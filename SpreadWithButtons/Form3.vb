Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.FpSpread1.OpenExcel("E:\Plantilla CSI.xlsx", FarPoint.Excel.ExcelOpenFlags.TruncateEmptyRowsAndColumns And FarPoint.Excel.ExcelOpenFlags.DoNotRecalculateAfterLoad)
        Me.FpSpread1.OpenExcel("E:\Formulas.xlsx", FarPoint.Excel.ExcelOpenFlags.TruncateEmptyRowsAndColumns Or FarPoint.Excel.ExcelOpenFlags.DoNotRecalculateAfterLoad)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gato = String.Empty

    End Sub
End Class