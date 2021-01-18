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
        Me.TextBoxM = New System.Windows.Forms.TextBox()
        Me.TextBoxL = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.BackColor = System.Drawing.Color.Fuchsia
        Me.LabelX.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelX.Location = New System.Drawing.Point(169, 110)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(100, 23)
        Me.LabelX.TabIndex = 0
        Me.LabelX.Text = "Введіть m"
        '
        'LabelY
        '
        Me.LabelY.AutoSize = True
        Me.LabelY.BackColor = System.Drawing.Color.Fuchsia
        Me.LabelY.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelY.Location = New System.Drawing.Point(169, 186)
        Me.LabelY.Name = "LabelY"
        Me.LabelY.Size = New System.Drawing.Size(90, 23)
        Me.LabelY.TabIndex = 1
        Me.LabelY.Text = "Введіть l"
        '
        'TextBoxM
        '
        Me.TextBoxM.Location = New System.Drawing.Point(340, 113)
        Me.TextBoxM.Name = "TextBoxM"
        Me.TextBoxM.Size = New System.Drawing.Size(194, 23)
        Me.TextBoxM.TabIndex = 3
        '
        'TextBoxL
        '
        Me.TextBoxL.Location = New System.Drawing.Point(340, 186)
        Me.TextBoxL.Name = "TextBoxL"
        Me.TextBoxL.Size = New System.Drawing.Size(194, 23)
        Me.TextBoxL.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Fuchsia
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(311, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 60)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxL)
        Me.Controls.Add(Me.TextBoxM)
        Me.Controls.Add(Me.LabelY)
        Me.Controls.Add(Me.LabelX)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelX As Label
    Friend WithEvents LabelY As Label
    Friend WithEvents TextBoxM As TextBox
    Friend WithEvents TextBoxL As TextBox
    Friend WithEvents Button1 As Button
End Class
