Imports System.IO
Imports FarPoint.Excel
Imports FarPoint.Win.Spread

Public Class GeneradorExcel


    Private libroEnStream As MemoryStream
    Private libroSpread As FpSpread

    Public Function GenerarArchivoExcelDesdeSpread() As FpSpread
        InicializarSpread()

        GenerarStreamDesdeHoja(libroSpread)

        GuardarRutaFisica(libroSpread)

        Dim algo = New ConvertidorDeArchivo
        Dim retorno = algo.ConviertaElArchivoPorCargar(libroEnStream)

        Return retorno
    End Function

    Private Sub InicializarSpread()
        libroSpread = New FpSpread With {
                    .Name = "Pruebas"
                }
        Dim hoja1 As New SheetView With {
            .SheetName = "Hoja1", .RowCount = 100, .ColumnCount = 100
        }

        libroSpread.Sheets.Add(hoja1)

        Dim hoja2 As New SheetView With {
            .SheetName = "Hoja2", .RowCount = 100, .ColumnCount = 100
        }

        libroSpread.Sheets.Add(hoja2)
    End Sub

    Private Sub GenerarStreamDesdeHoja(LibroSpread As FpSpread)
        libroEnStream = New System.IO.MemoryStream()

        LibroSpread.SaveExcel(libroEnStream, ExcelSaveFlags.UseOOXMLFormat)
    End Sub

    Private Sub GuardarRutaFisica(LibroSpread As FpSpread)
        Dim nuevoNombreArchivo As String = String.Concat(DateTime.Now.Second.ToString, "PruebaLeo", ".xlsx")
        LibroSpread.SaveExcel(String.Concat("D:/ArchivosPrueba/", nuevoNombreArchivo), ExcelSaveFlags.UseOOXMLFormat)
    End Sub
End Class
