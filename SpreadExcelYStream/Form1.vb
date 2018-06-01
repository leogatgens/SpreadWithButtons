Public Class Form1


    Private Sub BtnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Dim ruta As String = TextBox1.Text
        If String.IsNullOrEmpty(ruta) Then
            Return

        End If
        'Me.FpSpread1.OpenExcel("D:\Documentos Usuarios\MELENDEZGL\Desktop\Libro1.xlsx")
        Me.FpSpread1.OpenExcel(ruta)


    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Dim generaExcel As GeneradorExcel = New GeneradorExcel

        generaExcel.GenerarArchivoExcelDesdeSpread()
        MsgBox("Listo")


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FpSpread1.AllowUserFormulas = True
    End Sub
End Class