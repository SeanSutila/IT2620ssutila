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
        Me.Setup = New System.Windows.Forms.Button()
        Me.Punchline = New System.Windows.Forms.Button()
        Me.Joke = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Setup
        '
        Me.Setup.Location = New System.Drawing.Point(95, 174)
        Me.Setup.Name = "Setup"
        Me.Setup.Size = New System.Drawing.Size(75, 23)
        Me.Setup.TabIndex = 0
        Me.Setup.Text = "Setup"
        Me.Setup.UseVisualStyleBackColor = True
        '
        'Punchline
        '
        Me.Punchline.Location = New System.Drawing.Point(281, 174)
        Me.Punchline.Name = "Punchline"
        Me.Punchline.Size = New System.Drawing.Size(75, 23)
        Me.Punchline.TabIndex = 1
        Me.Punchline.Text = "Punch line"
        Me.Punchline.UseVisualStyleBackColor = True
        '
        'Joke
        '
        Me.Joke.Location = New System.Drawing.Point(92, 45)
        Me.Joke.Name = "Joke"
        Me.Joke.Size = New System.Drawing.Size(264, 88)
        Me.Joke.TabIndex = 2
        Me.Joke.Text = "Joke"
        Me.Joke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 280)
        Me.Controls.Add(Me.Joke)
        Me.Controls.Add(Me.Punchline)
        Me.Controls.Add(Me.Setup)
        Me.Name = "Form1"
        Me.Text = "Setup and Punch line"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Setup As Button
    Friend WithEvents Punchline As Button
    Friend WithEvents Joke As Label
End Class
