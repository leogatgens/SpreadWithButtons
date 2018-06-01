Imports FarPoint.Win.Spread
Imports FarPoint.Win.Spread.Model

Public Class Class1


    Private Sub RecorrerFormulasDeHoja(ByVal sheet As SheetView)

        Dim enumerator As DefaultSheetDataModel.DefaultSheetDataModelEnumerator = (CType(sheet.Models.Data, DefaultSheetDataModel)).EnumErrorText
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

End Class
