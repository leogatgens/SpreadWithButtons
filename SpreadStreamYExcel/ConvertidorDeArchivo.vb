Imports System.IO
Imports FarPoint.Excel
Imports FarPoint.Win.Spread

Friend Class ConvertidorDeArchivo


    Public Function ConviertaElArchivoPorCargar(ByVal archivo As Stream) As FpSpread
        Dim archivoConvertido As New FpSpread

        archivoConvertido.OpenExcel(archivo, ExcelOpenFlags.TruncateEmptyRowsAndColumns)
        'archivoConvertido.OpenExcel("D:\Documentos Usuarios\MELENDEZGL\Desktop\Libro1.xlsx")

        Return archivoConvertido
    End Function
End Class
