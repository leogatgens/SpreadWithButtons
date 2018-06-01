Imports System.IO
Imports FarPoint.CalcEngine
Imports FarPoint.Excel
Imports FarPoint.Win.Spread
Imports FarPoint.Win.Spread.Model

Public Class GeneradorExcel



    Private libroSpread As FpSpread
    Public Property retorno As FpSpread

    Public Function GenerarArchivoExcelDesdeSpread() As FpSpread
        InicializarSpread()

        DataModelManipulacion()











        'GenerarStreamDesdeHoja(libroSpread)

        'GuardarRutaFisica(libroSpread)









        Return retorno
    End Function

    Private Sub DataModelManipulacion()

        Dim dataModel As FarPoint.Win.Spread.Model.DefaultSheetDataModel

        dataModel = libroSpread.ActiveSheet.Models.Data
        dataModel.ColumnCount = 5
        dataModel.RowCount = 5
        'dataModel.SetValue(0, 0, "Not Empty")
        'dataModel.SetValue(3, 0, "Not Empty")
        'dataModel.SetFormula(0, 1, "SUM(A1:A3)")

        libroSpread.ActiveSheet.SetFormula(1, 1, "10/0")


        dataModel.SetFormula(4, 4, "SUM(A3:A20)")

        Dim c, r As Integer
        c = dataModel.NonEmptyColumnCount
        r = dataModel.NonEmptyRowCount
        Dim algo = dataModel.NextNonEmptyColumnFormula(0)


        'RecorrerFormulasDeHoja(libroSpread.ActiveSheet)
        RecorrerErroresDeHoja(libroSpread.ActiveSheet)
        'RecorrerTextosDeHoja(libroSpread.ActiveSheet)
    End Sub


    Private Sub RecorrerFormulasDeHoja(ByVal sheet As SheetView)

        Dim enumerator As DefaultSheetDataModel.DefaultSheetDataModelEnumerator = (CType(sheet.Models.Data, DefaultSheetDataModel)).EnumFormulas
        Dim indiceInicial As Integer = enumerator.NextNonEmptyRow(-1)

        While indiceInicial <> -1
            Dim proximoIndiceColumna As Integer = enumerator.NextNonEmptyColumnInRow(indiceInicial, -1)

            While proximoIndiceColumna <> -1
                Dim expr As String = sheet.GetFormula(indiceInicial, proximoIndiceColumna)
                sheet.Cells(indiceInicial, proximoIndiceColumna).Formula = ""
                proximoIndiceColumna = enumerator.NextNonEmptyColumnInRow(indiceInicial, proximoIndiceColumna)
            End While

            indiceInicial = enumerator.NextNonEmptyRow(indiceInicial)
        End While
    End Sub

    Private Sub RecorrerTextosDeHoja(ByVal sheet As SheetView)

        Dim enumerator As DefaultSheetDataModel.DefaultSheetDataModelEnumerator = (CType(sheet.Models.Data, DefaultSheetDataModel)).EnumValues
        Dim indiceInicial As Integer = enumerator.NextNonEmptyRow(-1)

        While indiceInicial <> -1
            Dim proximoIndiceColumna As Integer = enumerator.NextNonEmptyColumnInRow(indiceInicial, -1)

            While proximoIndiceColumna <> -1
                Dim expr As String = sheet.GetText(indiceInicial, proximoIndiceColumna)

                proximoIndiceColumna = enumerator.NextNonEmptyColumnInRow(indiceInicial, proximoIndiceColumna)
            End While

            indiceInicial = enumerator.NextNonEmptyRow(indiceInicial)
        End While
    End Sub

    Private Sub RecorrerErroresDeHoja(ByVal sheet As SheetView)

        Dim instance As DefaultSheetDataModel = CType(sheet.Models.Data, DefaultSheetDataModel)
        Dim value As Integer

        value = instance.GetNonEmptyErrorTextsColumnCount()

        Dim enumerator As DefaultSheetDataModel.DefaultSheetDataModelEnumerator = (CType(sheet.Models.Data, DefaultSheetDataModel)).EnumFormulas

        Dim indiceInicial As Integer = enumerator.NextNonEmptyRow(-1)

        While indiceInicial <> -1
            Dim proximoIndiceColumna As Integer = enumerator.NextNonEmptyColumnInRow(indiceInicial, -1)

            While proximoIndiceColumna <> -1
                Dim expr = sheet.GetValue(indiceInicial, proximoIndiceColumna)
                If TypeOf expr Is CalcError Then
                    Dim algo = expr.ToString


                End If



                proximoIndiceColumna = enumerator.NextNonEmptyColumnInRow(indiceInicial, proximoIndiceColumna)
            End While

            indiceInicial = enumerator.NextNonEmptyRow(indiceInicial)
        End While
    End Sub
    Private Shared Sub ObtenerProximoColumnaNoVacia(dataModel As Model.DefaultSheetDataModel)
        Dim proximaColumnaNovacia = dataModel.NextNonEmptyColumnInRow(0, 0)
    End Sub

    Private Sub InicializarSpread()
        libroSpread = New FpSpread With {
                    .Name = "Pruebas", .AllowUserFormulas = True
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



        'Dim hoja As New FpSpread
        Using libroEnStream As MemoryStream = New MemoryStream()
            LibroSpread.SaveExcel(libroEnStream)
            libroEnStream.Position = 0
            Dim algo = New ConvertidorDeArchivo
            retorno = algo.ConviertaElArchivoPorCargar(libroEnStream)
        End Using
        'LibroSpread.SaveExcel(libroEnStream, ExcelSaveFlags.UseOOXMLFormat)
        'libroEnStream.Close()

        'Dim f As String
        'f = "D:\mptest.xls"
        'Dim libroEnStream As New System.IO.FileStream(f, IO.FileMode.Open, IO.FileAccess.ReadWrite)
        'LibroSpread.SaveExcel(libroEnStream, FarPoint.Excel.ExcelSaveFlags.NoFlagsSet)
        'libroEnStream.Close()


        'Dim libroEnStream As Stream = New MemoryStream()
        'LibroSpread.SaveExcel(libroEnStream, ExcelSaveFlags.UseOOXMLFormat)
        'libroEnStream.Close()


        'Dim algo = New ConvertidorDeArchivo
        'retorno = algo.ConviertaElArchivoPorCargar(libroEnStream)

    End Sub

    Private Sub GuardarRutaFisica(LibroSpread As FpSpread)
        Dim nuevoNombreArchivo As String = String.Concat(DateTime.Now.Second.ToString, "PruebaLeo", ".xlsx")
        LibroSpread.SaveExcel(String.Concat("D:/ArchivosPrueba/", nuevoNombreArchivo), ExcelSaveFlags.UseOOXMLFormat)
    End Sub
End Class
