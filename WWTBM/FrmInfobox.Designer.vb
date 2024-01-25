<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInfobox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfobox))
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.BtnContinuar = New System.Windows.Forms.Button()
        Me.LblText = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicLogo
        '
        Me.PicLogo.BackColor = System.Drawing.Color.Transparent
        Me.PicLogo.Image = Global.QQSUM.My.Resources.Resources.logo2
        Me.PicLogo.Location = New System.Drawing.Point(12, 12)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(118, 118)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 0
        Me.PicLogo.TabStop = False
        '
        'BtnStop
        '
        Me.BtnStop.BackgroundImage = Global.QQSUM.My.Resources.Resources.background
        Me.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStop.Font = New System.Drawing.Font("Poppins Medium", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BtnStop.ForeColor = System.Drawing.Color.White
        Me.BtnStop.Location = New System.Drawing.Point(355, 89)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(122, 28)
        Me.BtnStop.TabIndex = 7
        Me.BtnStop.Text = "Parar"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'BtnContinuar
        '
        Me.BtnContinuar.BackgroundImage = Global.QQSUM.My.Resources.Resources.background
        Me.BtnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnContinuar.Font = New System.Drawing.Font("Poppins Medium", 8.0!, System.Drawing.FontStyle.Bold)
        Me.BtnContinuar.ForeColor = System.Drawing.Color.White
        Me.BtnContinuar.Location = New System.Drawing.Point(187, 89)
        Me.BtnContinuar.Name = "BtnContinuar"
        Me.BtnContinuar.Size = New System.Drawing.Size(122, 28)
        Me.BtnContinuar.TabIndex = 8
        Me.BtnContinuar.Text = "Continuar"
        Me.BtnContinuar.UseVisualStyleBackColor = True
        '
        'LblText
        '
        Me.LblText.BackColor = System.Drawing.Color.Transparent
        Me.LblText.Font = New System.Drawing.Font("Poppins Medium", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LblText.ForeColor = System.Drawing.Color.White
        Me.LblText.Location = New System.Drawing.Point(183, 18)
        Me.LblText.Name = "LblText"
        Me.LblText.Size = New System.Drawing.Size(294, 65)
        Me.LblText.TabIndex = 9
        Me.LblText.Text = "Label1"
        Me.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.White
        Me.TxtName.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(184, 88)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(149, 31)
        Me.TxtName.TabIndex = 10
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmInfobox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QQSUM.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(527, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblText)
        Me.Controls.Add(Me.BtnContinuar)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.PicLogo)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(543, 189)
        Me.MinimumSize = New System.Drawing.Size(543, 189)
        Me.Name = "FrmInfobox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInfobox"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents BtnStop As Button
    Friend WithEvents BtnContinuar As Button
    Friend WithEvents LblText As Label
    Friend WithEvents TxtName As TextBox
End Class
