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
        Me.Label_A = New System.Windows.Forms.Label()
        Me.Label_B = New System.Windows.Forms.Label()
        Me.TextBox_A = New System.Windows.Forms.TextBox()
        Me.TextBox_B = New System.Windows.Forms.TextBox()
        Me.Label_Number = New System.Windows.Forms.Label()
        Me.Label_Result = New System.Windows.Forms.Label()
        Me.TextBox_Number = New System.Windows.Forms.TextBox()
        Me.TextBox_Result = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_A
        '
        Me.Label_A.AutoSize = True
        Me.Label_A.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_A.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_A.Location = New System.Drawing.Point(461, 59)
        Me.Label_A.Name = "Label_A"
        Me.Label_A.Size = New System.Drawing.Size(110, 17)
        Me.Label_A.TabIndex = 0
        Me.Label_A.Text = "Введіть число Б"
        '
        'Label_B
        '
        Me.Label_B.AutoSize = True
        Me.Label_B.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_B.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_B.Location = New System.Drawing.Point(97, 53)
        Me.Label_B.Name = "Label_B"
        Me.Label_B.Size = New System.Drawing.Size(118, 19)
        Me.Label_B.TabIndex = 1
        Me.Label_B.Text = "Введіть число А"
        '
        'TextBox_A
        '
        Me.TextBox_A.Location = New System.Drawing.Point(221, 53)
        Me.TextBox_A.Name = "TextBox_A"
        Me.TextBox_A.Size = New System.Drawing.Size(138, 23)
        Me.TextBox_A.TabIndex = 2
        '
        'TextBox_B
        '
        Me.TextBox_B.Location = New System.Drawing.Point(577, 57)
        Me.TextBox_B.Name = "TextBox_B"
        Me.TextBox_B.Size = New System.Drawing.Size(127, 23)
        Me.TextBox_B.TabIndex = 3
        '
        'Label_Number
        '
        Me.Label_Number.AutoSize = True
        Me.Label_Number.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Number.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Number.Location = New System.Drawing.Point(105, 126)
        Me.Label_Number.Name = "Label_Number"
        Me.Label_Number.Size = New System.Drawing.Size(97, 17)
        Me.Label_Number.TabIndex = 4
        Me.Label_Number.Text = "Введіть число"
        '
        'Label_Result
        '
        Me.Label_Result.AutoSize = True
        Me.Label_Result.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Result.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label_Result.Location = New System.Drawing.Point(108, 217)
        Me.Label_Result.Name = "Label_Result"
        Me.Label_Result.Size = New System.Drawing.Size(70, 17)
        Me.Label_Result.TabIndex = 5
        Me.Label_Result.Text = "Результат"
        '
        'TextBox_Number
        '
        Me.TextBox_Number.Location = New System.Drawing.Point(309, 124)
        Me.TextBox_Number.Name = "TextBox_Number"
        Me.TextBox_Number.Size = New System.Drawing.Size(180, 23)
        Me.TextBox_Number.TabIndex = 6
        '
        'TextBox_Result
        '
        Me.TextBox_Result.Location = New System.Drawing.Point(309, 217)
        Me.TextBox_Result.Name = "TextBox_Result"
        Me.TextBox_Result.Size = New System.Drawing.Size(180, 23)
        Me.TextBox_Result.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 67)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox_Result)
        Me.Controls.Add(Me.TextBox_Number)
        Me.Controls.Add(Me.Label_Result)
        Me.Controls.Add(Me.Label_Number)
        Me.Controls.Add(Me.TextBox_B)
        Me.Controls.Add(Me.TextBox_A)
        Me.Controls.Add(Me.Label_B)
        Me.Controls.Add(Me.Label_A)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_A As Label
    Friend WithEvents Label_B As Label
    Friend WithEvents TextBox_A As TextBox
    Friend WithEvents TextBox_B As TextBox
    Friend WithEvents Label_Number As Label
    Friend WithEvents Label_Result As Label
    Friend WithEvents TextBox_Number As TextBox
    Friend WithEvents TextBox_Result As TextBox
    Friend WithEvents Button1 As Button
End Class
