﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrComboboxNew
    Inherits ClimsoftVer4.ucrValue

    'UserControl overrides dispose to clean up the component list.
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
        Me.cboValues = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboValues
        '
        Me.cboValues.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboValues.FormattingEnabled = True
        Me.cboValues.Location = New System.Drawing.Point(0, 0)
        Me.cboValues.Name = "cboValues"
        Me.cboValues.Size = New System.Drawing.Size(178, 21)
        Me.cboValues.TabIndex = 1
        '
        'ucrComboboxNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboValues)
        Me.Name = "ucrComboboxNew"
        Me.Size = New System.Drawing.Size(178, 21)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboValues As ComboBox
End Class
