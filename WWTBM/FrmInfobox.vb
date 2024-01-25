Public Class FrmInfobox
    Dim infoText As String
    Private Sub FrmInfobox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtName.Hide()
        TxtName.Enabled = False
        If FrmGame.status = False Then
            BtnContinuar.Hide()
            BtnStop.Location = New Point(269, 89)
            BtnStop.Text = "Voltar"
            LblText.Text = "Você errou a resposta, ganhou " + FrmGame.currentPrize.ToString + "."
        Else
            LblText.Text = "Parabéns! Você até agora acumulou " + FrmGame.currentPrize.ToString + ", deseja continuar ou parar. Corre o risco de perder tudo se continuar."
        End If
    End Sub

    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        Me.Close()
        FrmGame.PicBarA.Enabled = True
        FrmGame.PicBarB.Enabled = True
        FrmGame.PicBarC.Enabled = True
        FrmGame.PicBarD.Enabled = True
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        BtnContinuar.Hide()
        TxtName.Show()
        TxtName.Enabled = True
        BtnStop.Location = New Point(355, 89)
        BtnStop.Text = "Guardar Dados"
    End Sub
End Class