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
        Me.LabelX = New System.Windows.Forms.Label()
        Me.LabelY = New System.Windows.Forms.Label()
        Me.TextBoxX = New System.Windows.Forms.TextBox()
        Me.TextBoxY = New System.Windows.Forms.TextBox()
        Me.TextBoxZ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelX.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelX.Location = New System.Drawing.Point(113, 107)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(84, 21)
        Me.LabelX.TabIndex = 0
        Me.LabelX.Text = "Введіть х"
        '
        'LabelY
        '
        Me.LabelY.AutoSize = True
        Me.LabelY.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelY.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelY.Location = New System.Drawing.Point(409, 107)
        Me.LabelY.Name = "LabelY"
        Me.LabelY.Size = New System.Drawing.Size(84, 21)
        Me.LabelY.TabIndex = 1
        Me.LabelY.Text = "Введіть у"
        '
        'TextBoxX
        '
        Me.TextBoxX.Location = New System.Drawing.Point(203, 107)
        Me.TextBoxX.Name = "TextBoxX"
        Me.TextBoxX.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxX.TabIndex = 2
        '
        'TextBoxY
        '
        Me.TextBoxY.Location = New System.Drawing.Point(504, 107)
        Me.TextBoxY.Name = "TextBoxY"
        Me.TextBoxY.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxY.TabIndex = 3
        '
        'TextBoxZ
        '
        Me.TextBoxZ.Location = New System.Drawing.Point(351, 190)
        Me.TextBoxZ.Name = "TextBoxZ"
        Me.TextBoxZ.Size = New System.Drawing.Size(127, 20)
        Me.TextBoxZ.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Результат Z"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(296, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 55)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxZ)
        Me.Controls.Add(Me.TextBoxY)
        Me.Controls.Add(Me.TextBoxX)
        Me.Controls.Add(Me.LabelY)
        Me.Controls.Add(Me.LabelX)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelX As Label
    Friend WithEvents LabelY As Label
    Friend WithEvents TextBoxX As TextBox
    Friend WithEvents TextBoxY As TextBox
    Friend WithEvents TextBoxZ As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
