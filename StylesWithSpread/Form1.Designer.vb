﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FormulaTextBox1 = New FarPoint.Win.Spread.FormulaTextBox()
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.FpSpread1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirDesdeBDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarFormulasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        CType(Me.FpSpread1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FpSpread1_Sheet1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FormulaTextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FpSpread1)
        Me.SplitContainer1.Size = New System.Drawing.Size(736, 512)
        Me.SplitContainer1.SplitterDistance = 57
        Me.SplitContainer1.TabIndex = 0
        '
        'FormulaTextBox1
        '
        Me.FormulaTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormulaTextBox1.Location = New System.Drawing.Point(0, 24)
        Me.FormulaTextBox1.Multiline = false
        Me.FormulaTextBox1.Name = "FormulaTextBox1"
        Me.FormulaTextBox1.Size = New System.Drawing.Size(736, 33)
        Me.FormulaTextBox1.TabIndex = 1
        'Attach FormulaTextBox1 to FpSpread1
        Me.FormulaTextBox1.Attach(Me.FpSpread1)
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = ""
        Me.FpSpread1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread1.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpSpread1_Sheet1})
        Me.FpSpread1.Size = New System.Drawing.Size(736, 451)
        Me.FpSpread1.TabIndex = 0
        '
        'FpSpread1_Sheet1
        '
        Me.FpSpread1_Sheet1.Reset
        Me.FpSpread1_Sheet1.SheetName = "Sheet1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.QuitarFormulasToolStripMenuItem, Me.ExportarToolStripMenuItem, Me.GuardarArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirDesdeBDToolStripMenuItem, Me.ArchivoToolStripMenuItem})
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'AbrirDesdeBDToolStripMenuItem
        '
        Me.AbrirDesdeBDToolStripMenuItem.Name = "AbrirDesdeBDToolStripMenuItem"
        Me.AbrirDesdeBDToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbrirDesdeBDToolStripMenuItem.Text = "TestOpen"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'QuitarFormulasToolStripMenuItem
        '
        Me.QuitarFormulasToolStripMenuItem.Name = "QuitarFormulasToolStripMenuItem"
        Me.QuitarFormulasToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.QuitarFormulasToolStripMenuItem.Text = "Quitar formulas"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'GuardarArchivoToolStripMenuItem
        '
        Me.GuardarArchivoToolStripMenuItem.Name = "GuardarArchivoToolStripMenuItem"
        Me.GuardarArchivoToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.GuardarArchivoToolStripMenuItem.Text = "Guardar Archivo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 512)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        CType(Me.FpSpread1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FpSpread1_Sheet1,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents QuitarFormulasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormulaTextBox1 As FarPoint.Win.Spread.FormulaTextBox
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirDesdeBDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
End Class
