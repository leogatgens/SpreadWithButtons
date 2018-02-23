<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ButtonCellType9 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim ButtonCellType10 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim ButtonCellType11 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim ButtonCellType12 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim ButtonCellType13 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim ButtonCellType14 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim ButtonCellType15 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Dim ButtonCellType16 As FarPoint.Win.Spread.CellType.ButtonCellType = New FarPoint.Win.Spread.CellType.ButtonCellType()
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.FpSpread1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = "FpSpread1, Sheet1, Row 0, Column 0, "
        Me.FpSpread1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread1.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpSpread1_Sheet1})
        Me.FpSpread1.Size = New System.Drawing.Size(747, 396)
        Me.FpSpread1.TabIndex = 0
        '
        'FpSpread1_Sheet1
        '
        Me.FpSpread1_Sheet1.Reset()
        Me.FpSpread1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.FpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.FpSpread1_Sheet1.Cells.Get(6, 4).CellPadding.Bottom = 1
        Me.FpSpread1_Sheet1.Cells.Get(6, 4).CellPadding.Left = 1
        Me.FpSpread1_Sheet1.Cells.Get(6, 4).CellPadding.Right = 1
        Me.FpSpread1_Sheet1.Cells.Get(6, 4).CellPadding.Top = 1
        ButtonCellType9.ButtonColor2 = System.Drawing.SystemColors.ButtonFace
        Me.FpSpread1_Sheet1.Cells.Get(6, 4).CellType = ButtonCellType9
        Me.FpSpread1_Sheet1.Cells.Get(6, 10).NoteStyle = FarPoint.Win.Spread.NoteStyle.StickyNote
        ButtonCellType10.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer))
        ButtonCellType10.ButtonColor2 = System.Drawing.Color.Blue
        ButtonCellType10.DarkColor = System.Drawing.Color.Gray
        ButtonCellType10.LightColor = System.Drawing.Color.Yellow
        ButtonCellType10.Text = "Prueba"
        Me.FpSpread1_Sheet1.Columns.Get(0).CellType = ButtonCellType10
        ButtonCellType11.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer))
        ButtonCellType11.ButtonColor2 = System.Drawing.Color.Blue
        ButtonCellType11.DarkColor = System.Drawing.Color.Gray
        ButtonCellType11.LightColor = System.Drawing.Color.Yellow
        ButtonCellType11.Text = "Prueba"
        Me.FpSpread1_Sheet1.Columns.Get(1).CellType = ButtonCellType11
        ButtonCellType12.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer))
        ButtonCellType12.ButtonColor2 = System.Drawing.Color.Blue
        ButtonCellType12.DarkColor = System.Drawing.Color.Gray
        ButtonCellType12.LightColor = System.Drawing.Color.Yellow
        ButtonCellType12.Text = "Prueba"
        Me.FpSpread1_Sheet1.Columns.Get(2).CellType = ButtonCellType12
        ButtonCellType13.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer))
        ButtonCellType13.ButtonColor2 = System.Drawing.Color.Blue
        ButtonCellType13.DarkColor = System.Drawing.Color.Gray
        ButtonCellType13.LightColor = System.Drawing.Color.Yellow
        ButtonCellType13.Text = "Prueba"
        Me.FpSpread1_Sheet1.Columns.Get(3).CellType = ButtonCellType13
        ButtonCellType14.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer))
        ButtonCellType14.ButtonColor2 = System.Drawing.Color.Blue
        ButtonCellType14.DarkColor = System.Drawing.Color.Gray
        ButtonCellType14.LightColor = System.Drawing.Color.Yellow
        ButtonCellType14.Text = "Prueba"
        Me.FpSpread1_Sheet1.Columns.Get(4).CellType = ButtonCellType14
        ButtonCellType15.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer))
        ButtonCellType15.ButtonColor2 = System.Drawing.Color.Blue
        ButtonCellType15.DarkColor = System.Drawing.Color.Gray
        ButtonCellType15.LightColor = System.Drawing.Color.Yellow
        ButtonCellType15.Text = "Prueba"
        Me.FpSpread1_Sheet1.Columns.Get(5).CellType = ButtonCellType15
        ButtonCellType16.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer))
        ButtonCellType16.ButtonColor2 = System.Drawing.Color.Blue
        ButtonCellType16.DarkColor = System.Drawing.Color.Gray
        ButtonCellType16.LightColor = System.Drawing.Color.Yellow
        ButtonCellType16.Text = "Prueba"
        Me.FpSpread1_Sheet1.Columns.Get(6).CellType = ButtonCellType16
        Me.FpSpread1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.FpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 396)
        Me.Controls.Add(Me.FpSpread1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView
End Class
