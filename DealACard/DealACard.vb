﻿Public Class DealACard
    Dim theDeck As New Deck() 'put this in GameLogic class later
    Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Dim ah As New Card("a", "h")
        ' Dim twoS As New Card("q", "h")
        'Dim cardName As String = "_AS"
        'Dim cardImage As Image = My.Resources.ResourceManager.GetObject(cardName) ' My.Resources._AS
        'Dim currentCard As New Card("","")
        Dim g As Graphics = Me.CreateGraphics



        'g.DrawImage(ah.backImage, 10, 10)
        g.DrawImage(theDeck.DealCard.frontImage, 100, 100)

        'g.DrawImage(twoS.frontImage, 150, 150)


        g.Dispose()
    End Sub

End Class
