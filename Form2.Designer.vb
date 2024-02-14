<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbItalic = New System.Windows.Forms.CheckBox()
        Me.cbBold = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.rbBlue = New System.Windows.Forms.RadioButton()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.rbGaramond = New System.Windows.Forms.RadioButton()
        Me.rbMagneto = New System.Windows.Forms.RadioButton()
        Me.rbTahoma = New System.Windows.Forms.RadioButton()
        Me.lblDisplayTest = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(81, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Load Picture"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbItalic
        '
        Me.cbItalic.AutoSize = True
        Me.cbItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbItalic.Location = New System.Drawing.Point(503, 136)
        Me.cbItalic.Name = "cbItalic"
        Me.cbItalic.Size = New System.Drawing.Size(72, 26)
        Me.cbItalic.TabIndex = 1
        Me.cbItalic.Text = "Italic"
        Me.cbItalic.UseVisualStyleBackColor = True
        '
        'cbBold
        '
        Me.cbBold.AutoSize = True
        Me.cbBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBold.Location = New System.Drawing.Point(503, 188)
        Me.cbBold.Name = "cbBold"
        Me.cbBold.Size = New System.Drawing.Size(82, 26)
        Me.cbBold.TabIndex = 2
        Me.cbBold.Text = "Bold "
        Me.cbBold.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(503, 242)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(124, 26)
        Me.CheckBox3.TabIndex = 3
        Me.CheckBox3.Text = "Bold Italic"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(499, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Font Style"
        '
        'rbGreen
        '
        Me.rbGreen.AutoSize = True
        Me.rbGreen.Location = New System.Drawing.Point(655, 136)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(79, 24)
        Me.rbGreen.TabIndex = 5
        Me.rbGreen.TabStop = True
        Me.rbGreen.Text = "Green"
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'rbBlue
        '
        Me.rbBlue.AutoSize = True
        Me.rbBlue.Location = New System.Drawing.Point(655, 190)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(66, 24)
        Me.rbBlue.TabIndex = 6
        Me.rbBlue.TabStop = True
        Me.rbBlue.Text = "Blue"
        Me.rbBlue.UseVisualStyleBackColor = True
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(655, 244)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(64, 24)
        Me.rbRed.TabIndex = 7
        Me.rbRed.TabStop = True
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'rbGaramond
        '
        Me.rbGaramond.AutoSize = True
        Me.rbGaramond.Location = New System.Drawing.Point(267, 26)
        Me.rbGaramond.Name = "rbGaramond"
        Me.rbGaramond.Size = New System.Drawing.Size(110, 24)
        Me.rbGaramond.TabIndex = 8
        Me.rbGaramond.TabStop = True
        Me.rbGaramond.Text = "Garamond"
        Me.rbGaramond.UseVisualStyleBackColor = True
        '
        'rbMagneto
        '
        Me.rbMagneto.AutoSize = True
        Me.rbMagneto.Location = New System.Drawing.Point(452, 26)
        Me.rbMagneto.Name = "rbMagneto"
        Me.rbMagneto.Size = New System.Drawing.Size(97, 24)
        Me.rbMagneto.TabIndex = 9
        Me.rbMagneto.TabStop = True
        Me.rbMagneto.Text = "Magneto"
        Me.rbMagneto.UseVisualStyleBackColor = True
        '
        'rbTahoma
        '
        Me.rbTahoma.AutoSize = True
        Me.rbTahoma.Location = New System.Drawing.Point(643, 26)
        Me.rbTahoma.Name = "rbTahoma"
        Me.rbTahoma.Size = New System.Drawing.Size(92, 24)
        Me.rbTahoma.TabIndex = 10
        Me.rbTahoma.TabStop = True
        Me.rbTahoma.Text = "Tahoma"
        Me.rbTahoma.UseVisualStyleBackColor = True
        '
        'lblDisplayTest
        '
        Me.lblDisplayTest.AutoSize = True
        Me.lblDisplayTest.Location = New System.Drawing.Point(47, 26)
        Me.lblDisplayTest.Name = "lblDisplayTest"
        Me.lblDisplayTest.Size = New System.Drawing.Size(98, 20)
        Me.lblDisplayTest.TabIndex = 11
        Me.lblDisplayTest.Text = "Sample Test"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(655, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 55)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(662, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Font Color"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblDisplayTest)
        Me.Controls.Add(Me.rbTahoma)
        Me.Controls.Add(Me.rbMagneto)
        Me.Controls.Add(Me.rbGaramond)
        Me.Controls.Add(Me.rbRed)
        Me.Controls.Add(Me.rbBlue)
        Me.Controls.Add(Me.rbGreen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.cbBold)
        Me.Controls.Add(Me.cbItalic)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cbItalic As CheckBox
    Friend WithEvents cbBold As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbGreen As RadioButton
    Friend WithEvents rbBlue As RadioButton
    Friend WithEvents rbRed As RadioButton
    Friend WithEvents rbGaramond As RadioButton
    Friend WithEvents rbMagneto As RadioButton
    Friend WithEvents rbTahoma As RadioButton
    Friend WithEvents lblDisplayTest As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
