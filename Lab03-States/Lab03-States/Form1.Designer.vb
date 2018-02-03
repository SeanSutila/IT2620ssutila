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
        Me.VAButton = New System.Windows.Forms.Button()
        Me.NCButton = New System.Windows.Forms.Button()
        Me.SCButton = New System.Windows.Forms.Button()
        Me.GAButton = New System.Windows.Forms.Button()
        Me.ALButton = New System.Windows.Forms.Button()
        Me.FLButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'VAButton
        '
        Me.VAButton.Location = New System.Drawing.Point(61, 65)
        Me.VAButton.Name = "VAButton"
        Me.VAButton.Size = New System.Drawing.Size(107, 33)
        Me.VAButton.TabIndex = 0
        Me.VAButton.Text = "Virginia"
        Me.VAButton.UseVisualStyleBackColor = True
        '
        'NCButton
        '
        Me.NCButton.Location = New System.Drawing.Point(207, 65)
        Me.NCButton.Name = "NCButton"
        Me.NCButton.Size = New System.Drawing.Size(107, 33)
        Me.NCButton.TabIndex = 1
        Me.NCButton.Text = "North Carolina"
        Me.NCButton.UseVisualStyleBackColor = True
        '
        'SCButton
        '
        Me.SCButton.Location = New System.Drawing.Point(355, 65)
        Me.SCButton.Name = "SCButton"
        Me.SCButton.Size = New System.Drawing.Size(107, 33)
        Me.SCButton.TabIndex = 2
        Me.SCButton.Text = "South Carolina"
        Me.SCButton.UseVisualStyleBackColor = True
        '
        'GAButton
        '
        Me.GAButton.Location = New System.Drawing.Point(61, 138)
        Me.GAButton.Name = "GAButton"
        Me.GAButton.Size = New System.Drawing.Size(107, 33)
        Me.GAButton.TabIndex = 3
        Me.GAButton.Text = "Georgia"
        Me.GAButton.UseVisualStyleBackColor = True
        '
        'ALButton
        '
        Me.ALButton.Location = New System.Drawing.Point(207, 138)
        Me.ALButton.Name = "ALButton"
        Me.ALButton.Size = New System.Drawing.Size(107, 33)
        Me.ALButton.TabIndex = 4
        Me.ALButton.Text = "Alabama"
        Me.ALButton.UseVisualStyleBackColor = True
        '
        'FLButton
        '
        Me.FLButton.Location = New System.Drawing.Point(355, 138)
        Me.FLButton.Name = "FLButton"
        Me.FLButton.Size = New System.Drawing.Size(107, 33)
        Me.FLButton.TabIndex = 5
        Me.FLButton.Text = "Florida"
        Me.FLButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(192, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 41)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Abbreviation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 373)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FLButton)
        Me.Controls.Add(Me.ALButton)
        Me.Controls.Add(Me.GAButton)
        Me.Controls.Add(Me.SCButton)
        Me.Controls.Add(Me.NCButton)
        Me.Controls.Add(Me.VAButton)
        Me.Name = "Form1"
        Me.Text = "State Abbreviations"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VAButton As Button
    Friend WithEvents NCButton As Button
    Friend WithEvents SCButton As Button
    Friend WithEvents GAButton As Button
    Friend WithEvents ALButton As Button
    Friend WithEvents FLButton As Button
    Friend WithEvents Label1 As Label
End Class
