<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.LabelNumber = New System.Windows.Forms.Label()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.TextBoxNumber = New System.Windows.Forms.TextBox()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelNumber
        '
        Me.LabelNumber.AutoSize = True
        Me.LabelNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelNumber.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelNumber.Location = New System.Drawing.Point(220, 68)
        Me.LabelNumber.Name = "LabelNumber"
        Me.LabelNumber.Size = New System.Drawing.Size(144, 24)
        Me.LabelNumber.TabIndex = 0
        Me.LabelNumber.Text = "Введіть число"
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelResult.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelResult.Location = New System.Drawing.Point(220, 172)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(101, 24)
        Me.LabelResult.TabIndex = 1
        Me.LabelResult.Text = "Результат"
        '
        'TextBoxNumber
        '
        Me.TextBoxNumber.Location = New System.Drawing.Point(316, 106)
        Me.TextBoxNumber.Name = "TextBoxNumber"
        Me.TextBoxNumber.Size = New System.Drawing.Size(176, 23)
        Me.TextBoxNumber.TabIndex = 2
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(316, 217)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(176, 23)
        Me.TextBoxResult.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(286, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 72)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(837, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.TextBoxNumber)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.LabelNumber)
        Me.Name = "Form1"
        Me.Text = "Перевірка"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNumber As Label
    Friend WithEvents LabelResult As Label
    Friend WithEvents TextBoxNumber As TextBox
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Button1 As Button
End Class
