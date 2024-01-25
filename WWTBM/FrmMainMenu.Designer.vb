<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainMenu))
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.PicGif2 = New System.Windows.Forms.PictureBox()
        Me.PicGif1 = New System.Windows.Forms.PictureBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnPoints = New System.Windows.Forms.Button()
        Me.BtnInstructions = New System.Windows.Forms.Button()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGif2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGif1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicLogo
        '
        Me.PicLogo.BackColor = System.Drawing.Color.Transparent
        Me.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicLogo.Image = Global.QQSUM.My.Resources.Resources.logo2
        Me.PicLogo.Location = New System.Drawing.Point(319, 64)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(198, 198)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 2
        Me.PicLogo.TabStop = False
        '
        'PicGif2
        '
        Me.PicGif2.BackColor = System.Drawing.Color.Transparent
        Me.PicGif2.Image = Global.QQSUM.My.Resources.Resources.clock
        Me.PicGif2.Location = New System.Drawing.Point(587, 123)
        Me.PicGif2.Name = "PicGif2"
        Me.PicGif2.Size = New System.Drawing.Size(172, 172)
        Me.PicGif2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicGif2.TabIndex = 3
        Me.PicGif2.TabStop = False
        '
        'PicGif1
        '
        Me.PicGif1.BackColor = System.Drawing.Color.Transparent
        Me.PicGif1.Image = Global.QQSUM.My.Resources.Resources.clock
        Me.PicGif1.Location = New System.Drawing.Point(69, 123)
        Me.PicGif1.Name = "PicGif1"
        Me.PicGif1.Size = New System.Drawing.Size(172, 172)
        Me.PicGif1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicGif1.TabIndex = 4
        Me.PicGif1.TabStop = False
        '
        'BtnStart
        '
        Me.BtnStart.BackgroundImage = Global.QQSUM.My.Resources.Resources.background
        Me.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStart.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(310, 299)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(215, 40)
        Me.BtnStart.TabIndex = 5
        Me.BtnStart.Text = "Jogar"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnPoints
        '
        Me.BtnPoints.BackgroundImage = Global.QQSUM.My.Resources.Resources.background
        Me.BtnPoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPoints.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPoints.ForeColor = System.Drawing.Color.White
        Me.BtnPoints.Location = New System.Drawing.Point(310, 345)
        Me.BtnPoints.Name = "BtnPoints"
        Me.BtnPoints.Size = New System.Drawing.Size(215, 40)
        Me.BtnPoints.TabIndex = 6
        Me.BtnPoints.Text = "Pontuações"
        Me.BtnPoints.UseVisualStyleBackColor = True
        '
        'BtnInstructions
        '
        Me.BtnInstructions.BackgroundImage = Global.QQSUM.My.Resources.Resources.background
        Me.BtnInstructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInstructions.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInstructions.ForeColor = System.Drawing.Color.White
        Me.BtnInstructions.Location = New System.Drawing.Point(310, 391)
        Me.BtnInstructions.Name = "BtnInstructions"
        Me.BtnInstructions.Size = New System.Drawing.Size(215, 40)
        Me.BtnInstructions.TabIndex = 7
        Me.BtnInstructions.Text = "Instruções"
        Me.BtnInstructions.UseVisualStyleBackColor = True
        '
        'FrmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImage = Global.QQSUM.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 523)
        Me.Controls.Add(Me.BtnInstructions)
        Me.Controls.Add(Me.BtnPoints)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.PicGif1)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.PicGif2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(858, 562)
        Me.MinimumSize = New System.Drawing.Size(858, 562)
        Me.Name = "FrmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quem Quer Ser Um Milionário"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGif2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGif1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents PicGif2 As PictureBox
    Friend WithEvents PicGif1 As PictureBox
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnPoints As Button
    Friend WithEvents BtnInstructions As Button
End Class
