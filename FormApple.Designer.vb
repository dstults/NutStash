<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmApple))
        Me.BtnAttachApple = New System.Windows.Forms.Button()
        Me.BtnDetachApple = New System.Windows.Forms.Button()
        Me.BtnDetachNormal = New System.Windows.Forms.Button()
        Me.BtnAttachNormal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAttachApple
        '
        Me.BtnAttachApple.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAttachApple.Location = New System.Drawing.Point(12, 29)
        Me.BtnAttachApple.Name = "BtnAttachApple"
        Me.BtnAttachApple.Size = New System.Drawing.Size(96, 83)
        Me.BtnAttachApple.TabIndex = 0
        Me.BtnAttachApple.Text = "+"
        Me.BtnAttachApple.UseVisualStyleBackColor = True
        '
        'BtnDetachApple
        '
        Me.BtnDetachApple.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetachApple.Location = New System.Drawing.Point(114, 29)
        Me.BtnDetachApple.Name = "BtnDetachApple"
        Me.BtnDetachApple.Size = New System.Drawing.Size(96, 83)
        Me.BtnDetachApple.TabIndex = 1
        Me.BtnDetachApple.Text = "-"
        Me.BtnDetachApple.UseVisualStyleBackColor = True
        '
        'BtnDetachNormal
        '
        Me.BtnDetachNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetachNormal.Location = New System.Drawing.Point(318, 29)
        Me.BtnDetachNormal.Name = "BtnDetachNormal"
        Me.BtnDetachNormal.Size = New System.Drawing.Size(96, 83)
        Me.BtnDetachNormal.TabIndex = 3
        Me.BtnDetachNormal.Text = "-"
        Me.BtnDetachNormal.UseVisualStyleBackColor = True
        '
        'BtnAttachNormal
        '
        Me.BtnAttachNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAttachNormal.Location = New System.Drawing.Point(216, 29)
        Me.BtnAttachNormal.Name = "BtnAttachNormal"
        Me.BtnAttachNormal.Size = New System.Drawing.Size(96, 83)
        Me.BtnAttachNormal.TabIndex = 2
        Me.BtnAttachNormal.Text = "+"
        Me.BtnAttachNormal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Apple"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "No Apple"
        '
        'FrmApple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 123)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDetachNormal)
        Me.Controls.Add(Me.BtnAttachNormal)
        Me.Controls.Add(Me.BtnDetachApple)
        Me.Controls.Add(Me.BtnAttachApple)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmApple"
        Me.Text = "Darren's Apple Addon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAttachApple As Button
    Friend WithEvents BtnDetachApple As Button
    Friend WithEvents BtnDetachNormal As Button
    Friend WithEvents BtnAttachNormal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
