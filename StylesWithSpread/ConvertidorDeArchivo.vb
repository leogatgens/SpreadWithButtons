  Imports System.IO
  Imports FarPoint.Excel
  Imports FarPoint.Win.Spread

Public Class ConvertidorDeArchivo

    Public Function ConvierteElArchivoEnBytes(ByVal archivo As FpSpread) As Byte()

        Using cadenaDeMemoria As New MemoryStream()
            archivo.SaveExcel(cadenaDeMemoria, ExcelSaveFlags.UseOOXMLFormat)
            Return cadenaDeMemoria.ToArray()
        End Using

    End Function

    Public Function ConvierteBytesEnSpreadSheet(ByVal archivoEnBytes As Byte()) As FpSpread

        Dim archivoExcel As New FpSpread
        Using cadenaDememoria As New MemoryStream(archivoEnBytes)
            Try

         
            archivoExcel.OpenExcel(cadenaDememoria, ExcelOpenFlags.DoNotRecalculateAfterLoad Or
                                                    ExcelOpenFlags.TruncateEmptyRowsAndColumns)
            Catch ex As Exception
                Throw 
            End Try
        End Using
        Return archivoExcel
    End Function

  End Class
