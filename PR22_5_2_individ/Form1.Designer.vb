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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxX0 = New System.Windows.Forms.TextBox()
        Me.TextBoxY0 = New System.Windows.Forms.TextBox()
        Me.TextBoxR1 = New System.Windows.Forms.TextBox()
        Me.TextBoxR2 = New System.Windows.Forms.TextBox()
        Me.TextBoxX = New System.Windows.Forms.TextBox()
        Me.TextBoxY = New System.Windows.Forms.TextBox()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(285, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Введіть координати центральної точки О"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Х0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "У0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "R1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "R2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(273, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Введіть координати точки А"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(216, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Х"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(216, 316)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "У"
        '
        'TextBoxX0
        '
        Me.TextBoxX0.Location = New System.Drawing.Point(242, 90)
        Me.TextBoxX0.Name = "TextBoxX0"
        Me.TextBoxX0.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxX0.TabIndex = 8
        '
        'TextBoxY0
        '
        Me.TextBoxY0.Location = New System.Drawing.Point(242, 123)
        Me.TextBoxY0.Name = "TextBoxY0"
        Me.TextBoxY0.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxY0.TabIndex = 9
        '
        'TextBoxR1
        '
        Me.TextBoxR1.Location = New System.Drawing.Point(204, 176)
        Me.TextBoxR1.Name = "TextBoxR1"
        Me.TextBoxR1.Size = New System.Drawing.Size(158, 23)
        Me.TextBoxR1.TabIndex = 10
        '
        'TextBoxR2
        '
        Me.TextBoxR2.Location = New System.Drawing.Point(204, 214)
        Me.TextBoxR2.Name = "TextBoxR2"
        Me.TextBoxR2.Size = New System.Drawing.Size(158, 23)
        Me.TextBoxR2.TabIndex = 11
        '
        'TextBoxX
        '
        Me.TextBoxX.Location = New System.Drawing.Point(245, 273)
        Me.TextBoxX.Name = "TextBoxX"
        Me.TextBoxX.Size = New System.Drawing.Size(162, 23)
        Me.TextBoxX.TabIndex = 12
        '
        'TextBoxY
        '
        Me.TextBoxY.Location = New System.Drawing.Point(245, 313)
        Me.TextBoxY.Name = "TextBoxY"
        Me.TextBoxY.Size = New System.Drawing.Size(162, 23)
        Me.TextBoxY.TabIndex = 13
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(349, 379)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(215, 23)
        Me.TextBoxResult.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(204, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 49)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Результат"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.TextBoxY)
        Me.Controls.Add(Me.TextBoxX)
        Me.Controls.Add(Me.TextBoxR2)
        Me.Controls.Add(Me.TextBoxR1)
        Me.Controls.Add(Me.TextBoxY0)
        Me.Controls.Add(Me.TextBoxX0)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxX0 As TextBox
    Friend WithEvents TextBoxY0 As TextBox
    Friend WithEvents TextBoxR1 As TextBox
    Friend WithEvents TextBoxR2 As TextBox
    Friend WithEvents TextBoxX As TextBox
    Friend WithEvents TextBoxY As TextBox
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Button1 As Button
End Class
