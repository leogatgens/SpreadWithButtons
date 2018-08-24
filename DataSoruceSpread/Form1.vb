Imports FarPoint.Win.Spread

Public Class Form1
    Private WithEvents fpSpread1 As New FpSpread
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bind the component to the data set.
        Dim fpSpread1 As FarPoint.Win.Spread.FpSpread = ConfigurarSpread()
        DataSource()
        Me.SplitContainer1.Panel2.Controls.Add(fpSpread1)
        Dim editor As New FarPoint.Win.Spread.FormulaTextBox
        editor.Dock = DockStyle.Fill
        SplitContainer2.Panel2.Controls.Add(editor)
        editor.Attach(fpSpread1)
    End Sub

    Private Sub DataSource()


        Dim div As New DataTable("Division")

        div.Columns.Add("Section", GetType(String))
        div.Columns.Add("Specialty", GetType(Decimal))
        div.Rows.Add(New Object() {"Finance", 77})
        div.Rows.Add(New Object() {"Mergers", 55})
        div.Rows.Add(New Object() {100, 500})
        div.Rows.Add(New Object() {100, 500})
        div.Rows.Add(New Object() {100, 500})
        div.Rows.Add(New Object() {100, 500})


        fpSpread1.DataSource = div
        fpSpread1.DataMember = "Division"


    End Sub

    Private Function ConfigurarSpread() As FarPoint.Win.Spread.FpSpread

        fpSpread1.AllowUserFormulas = True
        fpSpread1.EnableCrossSheetReference = True

        fpSpread1.Dock = DockStyle.Fill
        CreaHojaParaDataBind()
        CreaHojaFormulas()

        Return fpSpread1
    End Function

    Private Sub CreaHojaParaDataBind()
        Dim shv As New FarPoint.Win.Spread.SheetView()
        shv.SheetName = "Datos"
        shv.AutoCalculation = False
        fpSpread1.Sheets.Add(shv)
    End Sub

    Private Sub CreaHojaFormulas()
        Dim Formulas As New FarPoint.Win.Spread.SheetView()
        Formulas.AutoCalculation = False


        Formulas.Cells(10, 0).Formula = "SUM(Datos!A4:A6;Datos!B1:B6)"
        Formulas.Cells(11, 0).Formula = "SUM(Datos!B1:B8)"

        fpSpread1.Sheets.Add(Formulas)
    End Sub

    Private Sub SplitContainer2_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub SplitContainer2_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer2.Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim col As FarPoint.Win.Spread.Column
        Dim cell As New FarPoint.Win.Spread.CellType.NumberCellType()
        'col = fpSpread1.ActiveSheet.Columns(0)
        'col.CellType = cell
        fpSpread1.Sheets(0).Cells(2, 0, 5, 0).CellType = cell




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fpSpread1.Sheets(1).RecalculateAll()
    End Sub
End Class
