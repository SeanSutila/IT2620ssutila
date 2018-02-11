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
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.lblTimeToday = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNightlyCharge = New System.Windows.Forms.TextBox()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtRoomService = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblAddCharges = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Highlander Hotel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Today's Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time:"
        '
        'lblDateToday
        '
        Me.lblDateToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.Location = New System.Drawing.Point(261, 82)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(100, 23)
        Me.lblDateToday.TabIndex = 3
        '
        'lblTimeToday
        '
        Me.lblTimeToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeToday.Location = New System.Drawing.Point(261, 121)
        Me.lblTimeToday.Name = "lblTimeToday"
        Me.lblTimeToday.Size = New System.Drawing.Size(100, 23)
        Me.lblTimeToday.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNightlyCharge)
        Me.GroupBox1.Controls.Add(Me.txtNights)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 120)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Information"
        '
        'txtNightlyCharge
        '
        Me.txtNightlyCharge.Location = New System.Drawing.Point(88, 59)
        Me.txtNightlyCharge.Name = "txtNightlyCharge"
        Me.txtNightlyCharge.Size = New System.Drawing.Size(100, 20)
        Me.txtNightlyCharge.TabIndex = 3
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(88, 30)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 20)
        Me.txtNights.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nightly Charge:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nights:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMisc)
        Me.GroupBox2.Controls.Add(Me.txtTelephone)
        Me.GroupBox2.Controls.Add(Me.txtRoomService)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(275, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 120)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Charges"
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(92, 86)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(97, 20)
        Me.txtMisc.TabIndex = 5
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(92, 59)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(97, 20)
        Me.txtTelephone.TabIndex = 4
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(92, 30)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(97, 20)
        Me.txtRoomService.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Misc:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Telephone:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Room Service:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.lblAddCharges)
        Me.GroupBox3.Controls.Add(Me.lblRoomCharges)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 301)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 210)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Charges"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(229, 165)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 9
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(229, 133)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 8
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(229, 100)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 7
        '
        'lblAddCharges
        '
        Me.lblAddCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddCharges.Location = New System.Drawing.Point(229, 64)
        Me.lblAddCharges.Name = "lblAddCharges"
        Me.lblAddCharges.Size = New System.Drawing.Size(100, 23)
        Me.lblAddCharges.TabIndex = 6
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomCharges.Location = New System.Drawing.Point(229, 26)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(100, 23)
        Me.lblRoomCharges.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(112, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Total Charges:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(160, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Tax:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(139, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Subtotal:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(90, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Additional Charges:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(108, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Room Charges:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(98, 536)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "C&alculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(219, 536)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(348, 536)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 588)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTimeToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Room Charge Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDateToday As Label
    Friend WithEvents lblTimeToday As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNightlyCharge As TextBox
    Friend WithEvents txtNights As TextBox
    Friend WithEvents txtMisc As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtRoomService As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblAddCharges As Label
    Friend WithEvents lblRoomCharges As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
