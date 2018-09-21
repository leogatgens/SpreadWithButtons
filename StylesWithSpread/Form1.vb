﻿Imports System.IO
Imports FarPoint.Excel
Imports FarPoint.Win.Spread
Imports FarPoint.Win.Spread.Model
Imports Microsoft.Office.Interop

Public Class Form1

    Dim tiempo As New TimeSpan
    Dim HoraFin As New TimeSpan
    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim fileName As String = Nothing

        Using openFileDialog1 As OpenFileDialog = New OpenFileDialog()
            openFileDialog1.InitialDirectory = "c:\"
            openFileDialog1.Filter = "Excel Files(.xls)|*.xls|Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm"
            openFileDialog1.FilterIndex = 2
            openFileDialog1.RestoreDirectory = True

            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                fileName = openFileDialog1.FileName
            End If
        End Using

        If fileName IsNot Nothing Then

            RegistroInicioProceso()
            FpSpread1.OpenExcel(fileName, FarPoint.Excel.ExcelOpenFlags.TruncateEmptyRowsAndColumns Or FarPoint.Excel.ExcelOpenFlags.DoNotRecalculateAfterLoad)
            'FpSpread1.OpenExcel(fileName)

            RegistrarFinProceso()
        End If
    End Sub

    Private Sub RegistrarFinProceso()
        HoraFin = DateTime.Now.TimeOfDay

        Dim duracion = HoraFin - tiempo
        Debug.WriteLine("tiempo: " & duracion.ToString)
    End Sub

    Private Sub RegistroInicioProceso()
        tiempo = DateTime.Now.TimeOfDay
    End Sub

    Private Sub QuitarFormulasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitarFormulasToolStripMenuItem.Click

        EliminaLasFormulasDeLaHojaModelo()


        ''Copiar modelo
        ''Copiar estilos
    End Sub

    Public Sub EliminaLasFormulasDeLaHojaModelo()
        Dim archivo As FpSpread = FpSpread1
        If archivo IsNot Nothing Then


            RegistroInicioProceso()

            archivo.Sheets(1).SelectionPolicy = SelectionPolicy.MultiRange
            archivo.Sheets(1).AddSelection(0, 0, archivo.Sheets(1).NonEmptyRowCount,
                                           archivo.Sheets(1).NonEmptyColumnCount)
            archivo.Sheets(1).ClipboardCut(ClipboardCopyOptions.Formulas)
            Clipboard.Clear()

            'Dim archivoTemporal As New FpSpread
            'archivoTemporal.Sheets.Add(New SheetView With {.SheetName = "HojaCopia"})
            'archivoTemporal.Sheets(0).ClipboardPaste(ClipboardPasteOptions.Formulas)
            'archivoTemporal.Sheets.Clear()

            RegistrarFinProceso()
        End If


    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click


        Using cadenaDeMemoria As New MemoryStream()
            FpSpread1.SaveExcel(cadenaDeMemoria, ExcelSaveFlags.UseOOXMLFormat)





            Dim rutaTemporal = IO.Path.GetTempPath()
            Dim nombreArchivo = "Leo"
            Dim ruta = IO.Path.Combine(rutaTemporal, nombreArchivo & ".xlsx")

            Using ArchivoEnFlujo = New FileStream(ruta, FileMode.Create, FileAccess.Write)
                cadenaDeMemoria.WriteTo(ArchivoEnFlujo)
            End Using

            Dim excel As Excel.Application = New Excel.Application()
            excel.Workbooks.Open(ruta)
            excel.Visible = True
        End Using

    End Sub
End Class
