Public Class FrmMainMenu
    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PicLogo_Click(sender As Object, e As EventArgs) Handles PicLogo.Click
        MsgBox("Jogo feito por Tiago Silva & Afonso Agostinho, aproveita e diverte-te. :)", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Me.Hide()
        FrmGame.Show()
    End Sub

    Private Sub BtnPoints_Click(sender As Object, e As EventArgs) Handles BtnPoints.Click
        
    End Sub
End Class
