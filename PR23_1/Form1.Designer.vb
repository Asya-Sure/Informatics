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
        Me.button = New System.Windows.Forms.Button()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.TextBoxN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button
        '
        Me.button.BackColor = System.Drawing.Color.SpringGreen
        Me.button.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.button.Location = New System.Drawing.Point(196, 306)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(182, 50)
        Me.button.TabIndex = 11
        Me.button.Text = "OK"
        Me.button.UseVisualStyleBackColor = False
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(206, 233)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(481, 23)
        Me.TextBoxResult.TabIndex = 10
        '
        'TextBoxN
        '
        Me.TextBoxN.Location = New System.Drawing.Point(213, 176)
        Me.TextBoxN.Name = "TextBoxN"
        Me.TextBoxN.Size = New System.Drawing.Size(142, 23)
        Me.TextBoxN.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(114, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Результат"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(119, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Введіть N"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(133, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Введіть число від 0 до N "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.button)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.TextBoxN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button As Button
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents TextBoxN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
