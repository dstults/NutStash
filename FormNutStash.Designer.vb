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
        Me.BtnLoadImage = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnLoadText = New System.Windows.Forms.Button()
        Me.LblFile1 = New System.Windows.Forms.Label()
        Me.LblFile2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadEncryptAES256 = New System.Windows.Forms.RadioButton()
        Me.RadEncryptROT13 = New System.Windows.Forms.RadioButton()
        Me.RadEncryptNone = New System.Windows.Forms.RadioButton()
        Me.BtnProcess = New System.Windows.Forms.Button()
        Me.BtnClearFile1 = New System.Windows.Forms.Button()
        Me.BtnClearFile2 = New System.Windows.Forms.Button()
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.ChkShow = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnLoadImage
        '
        Me.BtnLoadImage.Location = New System.Drawing.Point(11, 12)
        Me.BtnLoadImage.Name = "BtnLoadImage"
        Me.BtnLoadImage.Size = New System.Drawing.Size(96, 32)
        Me.BtnLoadImage.TabIndex = 6
        Me.BtnLoadImage.Text = "Load Image"
        Me.BtnLoadImage.UseVisualStyleBackColor = True
        '
        'BtnLoadText
        '
        Me.BtnLoadText.Location = New System.Drawing.Point(11, 53)
        Me.BtnLoadText.Name = "BtnLoadText"
        Me.BtnLoadText.Size = New System.Drawing.Size(96, 32)
        Me.BtnLoadText.TabIndex = 7
        Me.BtnLoadText.Text = "Load Text"
        Me.BtnLoadText.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 143)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encryption"
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
        Me.BtnProcess.Location = New System.Drawing.Point(219, 12)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(95, 234)
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
        'txtPass1
        '
        Me.txtPass1.Location = New System.Drawing.Point(49, 89)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass1.Size = New System.Drawing.Size(128, 20)
        Me.txtPass1.TabIndex = 15
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(49, 114)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(128, 20)
        Me.txtPass2.TabIndex = 16
        '
        'ChkShow
        '
        Me.ChkShow.AutoSize = True
        Me.ChkShow.Location = New System.Drawing.Point(124, 67)
        Me.ChkShow.Name = "ChkShow"
        Me.ChkShow.Size = New System.Drawing.Size(53, 17)
        Me.ChkShow.TabIndex = 17
        Me.ChkShow.Text = "Show"
        Me.ChkShow.UseVisualStyleBackColor = True
        '
        'FrmNutStash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 251)
        Me.Controls.Add(Me.BtnClearFile2)
        Me.Controls.Add(Me.BtnClearFile1)
        Me.Controls.Add(Me.BtnProcess)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblFile2)
        Me.Controls.Add(Me.LblFile1)
        Me.Controls.Add(Me.BtnLoadText)
        Me.Controls.Add(Me.BtnLoadImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmNutStash"
        Me.Text = "Darren's NutStash"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnLoadImage As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnLoadText As Button
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
End Class
