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
        Me.TextBoxX0 = New System.Windows.Forms.TextBox()
        Me.TextBoxY0 = New System.Windows.Forms.TextBox()
        Me.TextBoxR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxX = New System.Windows.Forms.TextBox()
        Me.TextBoxY = New System.Windows.Forms.TextBox()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(199, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Введіть координати центральной точки 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Х0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "У0"
        '
        'TextBoxX0
        '
        Me.TextBoxX0.Location = New System.Drawing.Point(317, 82)
        Me.TextBoxX0.Name = "TextBoxX0"
        Me.TextBoxX0.Size = New System.Drawing.Size(70, 23)
        Me.TextBoxX0.TabIndex = 3
        '
        'TextBoxY0
        '
        Me.TextBoxY0.Location = New System.Drawing.Point(317, 119)
        Me.TextBoxY0.Name = "TextBoxY0"
        Me.TextBoxY0.Size = New System.Drawing.Size(70, 23)
        Me.TextBoxY0.TabIndex = 4
        '
        'TextBoxR
        '
        Me.TextBoxR.Location = New System.Drawing.Point(361, 173)
        Me.TextBoxR.Name = "TextBoxR"
        Me.TextBoxR.Size = New System.Drawing.Size(184, 23)
        Me.TextBoxR.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Введіть R кола"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(241, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Введіть координати точки А"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Х"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "У"
        '
        'TextBoxX
        '
        Me.TextBoxX.Location = New System.Drawing.Point(318, 265)
        Me.TextBoxX.Name = "TextBoxX"
        Me.TextBoxX.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxX.TabIndex = 10
        '
        'TextBoxY
        '
        Me.TextBoxY.Location = New System.Drawing.Point(318, 294)
        Me.TextBoxY.Name = "TextBoxY"
        Me.TextBoxY.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxY.TabIndex = 11
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(372, 368)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(320, 23)
        Me.TextBoxResult.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 52)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Результат"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.TextBoxY)
        Me.Controls.Add(Me.TextBoxX)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxR)
        Me.Controls.Add(Me.TextBoxY0)
        Me.Controls.Add(Me.TextBoxX0)
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
    Friend WithEvents TextBoxX0 As TextBox
    Friend WithEvents TextBoxY0 As TextBox
    Friend WithEvents TextBoxR As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxX As TextBox
    Friend WithEvents TextBoxY As TextBox
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Button1 As Button
End Class
