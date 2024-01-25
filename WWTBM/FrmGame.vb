Public Class FrmGame
    Private Sub FrmGame_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
        FrmInfobox.Close()
    End Sub

    Dim answer As String
    Dim lineCountFromFile As Integer
    Dim Questions(15) As Integer
    Dim FILE_NAME As String = Application.StartupPath & "\questions.txt"
    Dim position As Integer = 0
    Dim graphic As Boolean = False
    Dim _5050 As Boolean = False
    Dim currentLevel As Integer = 1
    Public currentPrize As String = "0"
    Public status As Boolean

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim randomQuestion As Integer
        Dim rand As New Random
        lineCountFromFile = IO.File.ReadAllLines(FILE_NAME).Length
        For i = 0 To 15
            randomQuestion = rand.Next(0, lineCountFromFile)
            While Exists(randomQuestion)
                randomQuestion = rand.Next(0, lineCountFromFile)
            End While
            Questions(i) = randomQuestion
        Next
        GetQuestion()
        PicBarA.Hide()
        PicBarB.Hide()
        PicBarC.Hide()
        PicBarD.Hide()
    End Sub

    Private Sub GetQuestion()
        Dim questionIndex As Integer = 0
        Dim questionString As String = ""
        Dim questionArray() As String
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME, System.Text.Encoding.UTF8)
            For questionIndex = 0 To Questions(position)
                questionString = objReader.ReadLine()
                lineCountFromFile += 1
            Next
        End If
        questionArray = questionString.Split(";")

        LblQuestion.Text = questionArray(0)
        LblAnswerA.Text = questionArray(1)
        LblAnswerB.Text = questionArray(2)
        LblAnswerC.Text = questionArray(3)
        LblAnswerD.Text = questionArray(4)
        answer = questionArray(5)
    End Sub

    Private Function Exists(ByVal number As Integer) As Boolean
        For i = 0 To 15
            If Questions(i) = number Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub OnAnswer(sender As Object, e As EventArgs) Handles LblAnswerA.Click, LblAnswerB.Click, LblAnswerC.Click, LblAnswerD.Click
        If sender.tag = answer Then
            If Not Questions(position) = 16 Then
                FrmMainMenu_Load(Nothing, Nothing)
                position += 1
                GetQuestion()
                If graphic Then
                    TmrHideG.Stop()
                    PicBarA.Hide()
                    PicBarB.Hide()
                    PicBarC.Hide()
                    PicBarD.Hide()
                    PicLogo.Image = My.Resources.logo2
                End If
                If _5050 Then
                    LblAnswerA.Enabled = True
                    LblAnswerB.Enabled = True
                    LblAnswerC.Enabled = True
                    LblAnswerD.Enabled = True
                End If
                currentLevel += 1

                For levelIndex As Integer = 1 To 15
                    Dim levelLabel As Label = CType(Me.Controls.Find("LblLevel" & levelIndex.ToString(), True).FirstOrDefault(), Label)
                    Dim prizeLabel As Label = CType(Me.Controls.Find("LblPrize" & levelIndex.ToString(), True).FirstOrDefault(), Label)
                    If levelLabel IsNot Nothing AndAlso prizeLabel IsNot Nothing Then
                        If levelIndex = currentLevel Then

                            levelLabel.ForeColor = Color.Orange
                            prizeLabel.ForeColor = Color.Orange
                            currentPrize = prizeLabel.Text
                        Else

                            levelLabel.ForeColor = Color.White
                            prizeLabel.ForeColor = Color.White
                        End If
                    End If
                Next
                status = True
                FrmInfobox.Show()
            Else
                MsgBox("congrats you win!!!e2ue82ue82y euahed2yatgde 8972ayd2ayd 2at d862adt8a")
            End If
        Else
                For Each ctrl As Control In Me.Controls
                ctrl.Enabled = False
            Next
            status = False
            FrmInfobox.Show()
        End If
    End Sub

    Private Sub OnHelp(sender As Object, e As EventArgs) Handles PicGraphic.Click, PicSwitch.Click, PicCall.Click, Pic5050.Click
        Dim picBox As PictureBox = DirectCast(sender, PictureBox)
        If picBox.Tag = "E" Then
            On5050()
            _5050 = True
            Pic5050.Enabled = False
            Pic5050.BackgroundImage = My.Resources._5050x
        ElseIf picBox.Tag = "F" Then
            picBox.Enabled = False
            picBox.BackgroundImage = My.Resources.phonex
            MsgBox(answer)
        ElseIf picBox.Tag = "G" Then
            position += 1
            GetQuestion()
            picBox.Enabled = False
            picBox.BackgroundImage = My.Resources.skipx
        ElseIf picBox.Tag = "H" Then
            GraphicRequested()
            graphic = True
            picBox.Enabled = False
            picBox.BackgroundImage = My.Resources.graphicx
        End If
    End Sub

    Private Sub On5050()
        Dim availableChoices As New List(Of String) From {"A", "B", "C", "D"}
        availableChoices.Remove(answer)

        Dim incorrectAnswer1 As String = availableChoices(New Random().Next(availableChoices.Count))
        availableChoices.Remove(incorrectAnswer1)

        Dim incorrectAnswer2 As String = availableChoices(New Random().Next(availableChoices.Count))
        DisableAnswerLabel(incorrectAnswer1)
        DisableAnswerLabel(incorrectAnswer2)
    End Sub

    Private Sub DisableAnswerLabel(answerToDisable As String)
        Select Case answerToDisable
            Case "A"
                LblAnswerA.Enabled = False
            Case "B"
                LblAnswerB.Enabled = False
            Case "C"
                LblAnswerC.Enabled = False
            Case "D"
                LblAnswerD.Enabled = False
        End Select
    End Sub

    Private Sub GraphicRequested()
        PicLogo.Image = My.Resources.gload
        TmrGraphic.Start()
        LblAnswerA.Enabled = False
        LblAnswerB.Enabled = False
        LblAnswerC.Enabled = False
        LblAnswerD.Enabled = False
    End Sub


    Private Sub TmrGraphic_Tick(sender As Object, e As EventArgs) Handles TmrGraphic.Tick
        TmrGraphic.Stop()
        LblAnswerA.Enabled = True
        LblAnswerB.Enabled = True
        LblAnswerC.Enabled = True
        LblAnswerD.Enabled = True
        PicLogo.Image = My.Resources.gloaded
        PicBarA.Show()
        PicBarB.Show()
        PicBarC.Show()
        PicBarD.Show()

        If answer = "A" Then
            PicBarA.Size = New Size(15, 128)
            PicBarA.Location = New Point(198, 109)
            PicBarB.Size = New Size(15, 39)
            PicBarC.Size = New Size(15, 53)
            PicBarD.Size = New Size(15, 81)
        ElseIf answer = "B" Then
            PicBarA.Size = New Size(15, 65)
            PicBarB.Size = New Size(15, 128)
            PicBarB.Location = New Point(236, 109)
            PicBarC.Size = New Size(15, 53)
            PicBarD.Size = New Size(15, 81)
        ElseIf answer = "C" Then
            PicBarA.Size = New Size(15, 65)
            PicBarB.Size = New Size(15, 39)
            PicBarC.Size = New Size(15, 128)
            PicBarC.Location = New Point(273, 109)
            PicBarD.Size = New Size(15, 81)
        ElseIf answer = "D" Then
            PicBarA.Size = New Size(15, 65)
            PicBarB.Size = New Size(15, 39)
            PicBarC.Size = New Size(15, 53)
            PicBarD.Size = New Size(15, 128)
            PicBarD.Location = New Point(310, 109)
        End If
        TmrHideG.Start()
    End Sub

    Private Sub TmrHideG_Tick(sender As Object, e As EventArgs) Handles TmrHideG.Tick
        TmrHideG.Stop()
        PicBarA.Hide()
        PicBarB.Hide()
        PicBarC.Hide()
        PicBarD.Hide()
        PicLogo.Image = My.Resources.logo2
        graphic = False
    End Sub
End Class