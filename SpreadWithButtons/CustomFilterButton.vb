

<Serializable()> Public Class CustomFilterButton

    'Create a sub-class inheriting BaseFilterItem class.
    Inherits FarPoint.Win.Spread.BaseFilterItem

    Dim sv As FarPoint.Win.Spread.SheetView = Nothing

    Public Sub New()
    End Sub

    Public Sub New(ByVal sheetView As FarPoint.Win.Spread.SheetView)
        Me.sv = sheetView
    End Sub

    '---------------------------------------------------------
    'Return names to be displayed in the drop-down list.
    '---------------------------------------------------------
    Public Overrides ReadOnly Property DisplayName() As String
        Get
            Dim list As New ArrayList
            Dim lista2 As New System.Text.StringBuilder()








            Return "FiltrarBoton"

        End Get
    End Property

    '-----------------------------------------------------------------------------------------
    'Set sheets to filters.
    '-----------------------------------------------------------------------------------------
    Public Overrides WriteOnly Property SheetView() As FarPoint.Win.Spread.SheetView
        Set(ByVal Value As FarPoint.Win.Spread.SheetView)
            sv = Value
        End Set
    End Property

    '-----------------------------------------------------------------------------------------
    'Evaluate specified values by particular conditions.
    '-----------------------------------------------------------------------------------------
    Public Function IsFilteredIn(ByVal value As String) As Boolean
        If (value = "Hola") Then
            'Return True only when the following conditions are satisfied.
            '(1)Values are entered.
            '(2)Values are not lower than 10.
            '(3)Values are not greater than 50.
            Return True
        End If
        Return False
    End Function

    '-----------------------------------------------------------------------------------------
    'Display names returned by DisplayName property.
    '-----------------------------------------------------------------------------------------
    Public Overrides Function ShowInDropDown(ByVal columnIndex As Integer, ByVal filteredInRowList() As Integer) As Boolean
        Return True
    End Function

    '-----------------------------------------------------------------------------------------
    'Execute filtering in the column specified in a sheet.
    '-----------------------------------------------------------------------------------------
    Public Overrides Function Filter(ByVal columnIndex As Integer) As Integer()

        Dim list As New ArrayList
        Dim returnList As Integer() = Nothing
        Dim row As Integer

        If (sv Is Nothing) Then
            Return returnList
        End If

        For row = 0 To sv.RowCount - 1
            Dim celdaBoton = DirectCast(sv.Cells(row, columnIndex).Formatter, FarPoint.Win.Spread.CellType.ButtonCellType).[Text]

            'If Not (sv.GetValue(row, columnIndex) = Nothing) Then


            Dim value As String = celdaBoton
            If IsFilteredIn(value) Then
                'Add row indexes that meet conditions sequentially.
                list.Add(row)
            End If

        Next row

        'When there are any rows that meet conditions, copy them to arrays.
        If list.Count > 0 Then
            returnList = New Integer(list.Count - 1) {}
            list.CopyTo(returnList)
            list.Clear()
        End If

        'Return all row indexes that meet conditions.
        Return returnList

    End Function

    '-----------------------------------------------------------------------------------------
    'When any data that has to be serialized is included in a custom filter class, override it.
    '-----------------------------------------------------------------------------------------
    Public Overrides Function Serialize(ByVal w As System.Xml.XmlTextWriter) As Boolean

        w.WriteStartElement("CustomFilter")
        MyBase.Serialize(w)
        w.WriteEndElement()
        Return True

    End Function

    Public Overrides Function Deserialize(ByVal r As System.Xml.XmlNodeReader) As Boolean

        If r.NodeType = System.Xml.XmlNodeType.Element Then
            If r.Name.Equals("CustomFilter") Then
                MyBase.Deserialize(r)
            End If
        End If
        Return True

    End Function

End Class

