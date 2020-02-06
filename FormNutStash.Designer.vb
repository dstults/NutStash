<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNutStash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNutStash))
        Me.BtnFile1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnFiles2 = New System.Windows.Forms.Button()
        Me.LblFile1 = New System.Windows.Forms.Label()
        Me.LblFile2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkShow = New System.Windows.Forms.CheckBox()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.RadEncryptAES256 = New System.Windows.Forms.RadioButton()
        Me.RadEncryptROT13 = New System.Windows.Forms.RadioButton()
        Me.RadEncryptNone = New System.Windows.Forms.RadioButton()
        Me.BtnProcess = New System.Windows.Forms.Button()
        Me.BtnClearFile1 = New System.Windows.Forms.Button()
        Me.BtnClearFile2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnClearOutput = New System.Windows.Forms.Button()
        Me.LblOutput = New System.Windows.Forms.Label()
        Me.BtnOutput = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFile1
        '
        Me.BtnFile1.Location = New System.Drawing.Point(11, 12)
        Me.BtnFile1.Name = "BtnFile1"
        Me.BtnFile1.Size = New System.Drawing.Size(96, 32)
        Me.BtnFile1.TabIndex = 6
        Me.BtnFile1.Text = "Load Image"
        Me.BtnFile1.UseVisualStyleBackColor = True
        '
        'BtnFiles2
        '
        Me.BtnFiles2.Location = New System.Drawing.Point(11, 53)
        Me.BtnFiles2.Name = "BtnFiles2"
        Me.BtnFiles2.Size = New System.Drawing.Size(96, 32)
        Me.BtnFiles2.TabIndex = 7
        Me.BtnFiles2.Text = "Load Text"
        Me.BtnFiles2.UseVisualStyleBackColor = True
        '
        'LblFile1
        '
        Me.LblFile1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblFile1.Location = New System.Drawing.Point(113, 12)
        Me.LblFile1.Name = "LblFile1"
        Me.LblFile1.Size = New System.Drawing.Size(96, 32)
        Me.LblFile1.TabIndex = 8
        Me.LblFile1.Text = "(no file 1)"
        Me.LblFile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFile2
        '
        Me.LblFile2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblFile2.Location = New System.Drawing.Point(113, 53)
        Me.LblFile2.Name = "LblFile2"
        Me.LblFile2.Size = New System.Drawing.Size(96, 32)
        Me.LblFile2.TabIndex = 9
        Me.LblFile2.Text = "(no file 2)"
        Me.LblFile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkShow)
        Me.GroupBox1.Controls.Add(Me.txtPass2)
        Me.GroupBox1.Controls.Add(Me.txtPass1)
        Me.GroupBox1.Controls.Add(Me.RadEncryptAES256)
        Me.GroupBox1.Controls.Add(Me.RadEncryptROT13)
        Me.GroupBox1.Controls.Add(Me.RadEncryptNone)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 143)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encryption"
        '
        'ChkShow
        '
        Me.ChkShow.AutoSize = True
        Me.ChkShow.Enabled = False
        Me.ChkShow.Location = New System.Drawing.Point(124, 67)
        Me.ChkShow.Name = "ChkShow"
        Me.ChkShow.Size = New System.Drawing.Size(53, 17)
        Me.ChkShow.TabIndex = 17
        Me.ChkShow.Text = "Show"
        Me.ChkShow.UseVisualStyleBackColor = True
        '
        'txtPass2
        '
        Me.txtPass2.Enabled = False
        Me.txtPass2.Location = New System.Drawing.Point(49, 114)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(128, 20)
        Me.txtPass2.TabIndex = 16
        '
        'txtPass1
        '
        Me.txtPass1.Enabled = False
        Me.txtPass1.Location = New System.Drawing.Point(49, 89)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass1.Size = New System.Drawing.Size(128, 20)
        Me.txtPass1.TabIndex = 15
        '
        'RadEncryptAES256
        '
        Me.RadEncryptAES256.AutoSize = True
        Me.RadEncryptAES256.Location = New System.Drawing.Point(16, 66)
        Me.RadEncryptAES256.Name = "RadEncryptAES256"
        Me.RadEncryptAES256.Size = New System.Drawing.Size(107, 17)
        Me.RadEncryptAES256.TabIndex = 14
        Me.RadEncryptAES256.Text = "Strong (AES-256)"
        Me.RadEncryptAES256.UseVisualStyleBackColor = True
        '
        'RadEncryptROT13
        '
        Me.RadEncryptROT13.AutoSize = True
        Me.RadEncryptROT13.Location = New System.Drawing.Point(16, 43)
        Me.RadEncryptROT13.Name = "RadEncryptROT13"
        Me.RadEncryptROT13.Size = New System.Drawing.Size(98, 17)
        Me.RadEncryptROT13.TabIndex = 13
        Me.RadEncryptROT13.Text = "Weak (ROT13)"
        Me.RadEncryptROT13.UseVisualStyleBackColor = True
        '
        'RadEncryptNone
        '
        Me.RadEncryptNone.AutoSize = True
        Me.RadEncryptNone.Checked = True
        Me.RadEncryptNone.Location = New System.Drawing.Point(16, 19)
        Me.RadEncryptNone.Name = "RadEncryptNone"
        Me.RadEncryptNone.Size = New System.Drawing.Size(51, 17)
        Me.RadEncryptNone.TabIndex = 12
        Me.RadEncryptNone.TabStop = True
        Me.RadEncryptNone.Text = "None"
        Me.RadEncryptNone.UseVisualStyleBackColor = True
        '
        'BtnProcess
        '
        Me.BtnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProcess.Location = New System.Drawing.Point(222, 14)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(95, 253)
        Me.BtnProcess.TabIndex = 13
        Me.BtnProcess.Text = "Attach / Detach"
        Me.BtnProcess.UseVisualStyleBackColor = True
        '
        'BtnClearFile1
        '
        Me.BtnClearFile1.Location = New System.Drawing.Point(193, 8)
        Me.BtnClearFile1.Name = "BtnClearFile1"
        Me.BtnClearFile1.Size = New System.Drawing.Size(20, 20)
        Me.BtnClearFile1.TabIndex = 14
        Me.BtnClearFile1.Text = "x"
        Me.BtnClearFile1.UseVisualStyleBackColor = True
        '
        'BtnClearFile2
        '
        Me.BtnClearFile2.Location = New System.Drawing.Point(193, 49)
        Me.BtnClearFile2.Name = "BtnClearFile2"
        Me.BtnClearFile2.Size = New System.Drawing.Size(20, 20)
        Me.BtnClearFile2.TabIndex = 15
        Me.BtnClearFile2.Text = "x"
        Me.BtnClearFile2.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "All Files|*.*"
        '
        'BtnClearOutput
        '
        Me.BtnClearOutput.Location = New System.Drawing.Point(193, 87)
        Me.BtnClearOutput.Name = "BtnClearOutput"
        Me.BtnClearOutput.Size = New System.Drawing.Size(20, 20)
        Me.BtnClearOutput.TabIndex = 18
        Me.BtnClearOutput.Text = "x"
        Me.BtnClearOutput.UseVisualStyleBackColor = True
        '
        'LblOutput
        '
        Me.LblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblOutput.Location = New System.Drawing.Point(113, 91)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(96, 32)
        Me.LblOutput.TabIndex = 17
        Me.LblOutput.Text = "(no output file)"
        Me.LblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnOutput
        '
        Me.BtnOutput.Location = New System.Drawing.Point(11, 91)
        Me.BtnOutput.Name = "BtnOutput"
        Me.BtnOutput.Size = New System.Drawing.Size(96, 32)
        Me.BtnOutput.TabIndex = 16
        Me.BtnOutput.Text = "Set Output File"
        Me.BtnOutput.UseVisualStyleBackColor = True
        '
        'FrmNutStash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 277)
        Me.Controls.Add(Me.BtnClearOutput)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.BtnOutput)
        Me.Controls.Add(Me.BtnClearFile2)
        Me.Controls.Add(Me.BtnClearFile1)
        Me.Controls.Add(Me.BtnProcess)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblFile2)
        Me.Controls.Add(Me.LblFile1)
        Me.Controls.Add(Me.BtnFiles2)
        Me.Controls.Add(Me.BtnFile1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmNutStash"
        Me.Text = "Darren's NutStash"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnFile1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnFiles2 As Button
    Friend WithEvents LblFile1 As Label
    Friend WithEvents LblFile2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadEncryptAES256 As RadioButton
    Friend WithEvents RadEncryptROT13 As RadioButton
    Friend WithEvents RadEncryptNone As RadioButton
    Friend WithEvents BtnProcess As Button
    Friend WithEvents BtnClearFile1 As Button
    Friend WithEvents BtnClearFile2 As Button
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents txtPass1 As TextBox
    Friend WithEvents ChkShow As CheckBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BtnClearOutput As Button
    Friend WithEvents LblOutput As Label
    Friend WithEvents BtnOutput As Button
End Class
