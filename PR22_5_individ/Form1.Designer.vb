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
        Me.TextBoxX0 = New System.Windows.Forms.TextBox()
        Me.TextBoxY0 = New System.Windows.Forms.TextBox()
        Me.TextBoxR1 = New System.Windows.Forms.TextBox()
        Me.TextBoxX = New System.Windows.Forms.TextBox()
        Me.TextBoxY = New System.Windows.Forms.TextBox()
        Me.TextBoxR2 = New System.Windows.Forms.TextBox()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxX0
        '
        Me.TextBoxX0.Location = New System.Drawing.Point(268, 49)
        Me.TextBoxX0.Name = "TextBoxX0"
        Me.TextBoxX0.Size = New System.Drawing.Size(105, 23)
        Me.TextBoxX0.TabIndex = 0
        '
        'TextBoxY0
        '
        Me.TextBoxY0.Location = New System.Drawing.Point(268, 78)
        Me.TextBoxY0.Name = "TextBoxY0"
        Me.TextBoxY0.Size = New System.Drawing.Size(105, 23)
        Me.TextBoxY0.TabIndex = 1
        '
        'TextBoxR1
        '
        Me.TextBoxR1.Location = New System.Drawing.Point(291, 131)
        Me.TextBoxR1.Name = "TextBoxR1"
        Me.TextBoxR1.Size = New System.Drawing.Size(157, 23)
        Me.TextBoxR1.TabIndex = 2
        '
        'TextBoxX
        '
        Me.TextBoxX.Location = New System.Drawing.Point(291, 247)
        Me.TextBoxX.Name = "TextBoxX"
        Me.TextBoxX.Size = New System.Drawing.Size(82, 23)
        Me.TextBoxX.TabIndex = 3
        '
        'TextBoxY
        '
        Me.TextBoxY.Location = New System.Drawing.Point(291, 288)
        Me.TextBoxY.Name = "TextBoxY"
        Me.TextBoxY.Size = New System.Drawing.Size(82, 23)
        Me.TextBoxY.TabIndex = 4
        '
        'TextBoxR2
        '
        Me.TextBoxR2.Location = New System.Drawing.Point(291, 170)
        Me.TextBoxR2.Name = "TextBoxR2"
        Me.TextBoxR2.Size = New System.Drawing.Size(157, 23)
        Me.TextBoxR2.TabIndex = 5
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(317, 360)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(253, 23)
        Me.TextBoxResult.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(154, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Введіть  координати центральної точки О"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Х0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "R2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Х"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "У"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 42)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Розрахувати"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(209, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Введіть координати точки А"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "У0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "R1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(857, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.TextBoxR2)
        Me.Controls.Add(Me.TextBoxY)
        Me.Controls.Add(Me.TextBoxX)
        Me.Controls.Add(Me.TextBoxR1)
        Me.Controls.Add(Me.TextBoxY0)
        Me.Controls.Add(Me.TextBoxX0)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxX0 As TextBox
    Friend WithEvents TextBoxY0 As TextBox
    Friend WithEvents TextBoxR1 As TextBox
    Friend WithEvents TextBoxX As TextBox
    Friend WithEvents TextBoxY As TextBox
    Friend WithEvents TextBoxR2 As TextBox
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
