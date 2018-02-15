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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtInt = New System.Windows.Forms.TextBox()
        Me.lblRomanNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(43, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a decimal integer in the range of 1-10:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(43, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Equivelant Roman Numeral:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(64, 141)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(182, 141)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtInt
        '
        Me.txtInt.Location = New System.Drawing.Point(172, 36)
        Me.txtInt.Name = "txtInt"
        Me.txtInt.Size = New System.Drawing.Size(100, 20)
        Me.txtInt.TabIndex = 4
        '
        'lblRomanNum
        '
        Me.lblRomanNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRomanNum.Location = New System.Drawing.Point(172, 86)
        Me.lblRomanNum.Name = "lblRomanNum"
        Me.lblRomanNum.Size = New System.Drawing.Size(100, 23)
        Me.lblRomanNum.TabIndex = 5
        Me.lblRomanNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 199)
        Me.Controls.Add(Me.lblRomanNum)
        Me.Controls.Add(Me.txtInt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Roman Nurmeral Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtInt As TextBox
    Friend WithEvents lblRomanNum As Label
End Class
