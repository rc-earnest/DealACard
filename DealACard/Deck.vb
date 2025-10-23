Public Class Deck
    Private _deck As New Stack(Of Card)


    Sub test()
        Dim ah As New Card("a", "h")
        Dim asp As New Card("a", "s")
        Dim ad As New Card("a", "d")
        Dim ac As New Card("a", "c")
        Me._deck.Push(ah)
        Me._deck.Push(asp)
        Me._deck.Push(ad)
        Me._deck.Push(ac)
    End Sub
    ''' <summary>
    ''' Deals one card off the top of the deck
    ''' </summary>
    ''' <returns></returns>
    Function DealCard() As Card
        Return _deck.Pop()
    End Function
    ''' <summary>
    ''' returns the number of cards remaining in the deck
    ''' </summary>
    ''' <returns></returns>
    Function CardsRemaining() As Integer
        Return _deck.Count
    End Function
    ''' <summary>
    ''' "shuffles" the deck by creating a new ordered deck
    ''' </summary>
    Sub shuffle()
        Dim _suit$, _rank$
        For suit = 1 To 4

            Select Case suit
                Case 1
                    _suit = "s"
                Case 2
                    _suit = "d"
                Case 3
                    _suit = "c"
                Case 4
                    _suit = "h"
            End Select
            For rank = 1 To 13
                Select Case rank
                    Case 1
                        _rank = "a"
                    Case 2 To 10
                        _rank = CStr(rank)
                    Case 11
                        _rank = "j"
                    Case 12
                        _rank = "q"
                    Case 13
                        _rank = "k"
                End Select
                Dim newCard As New Card(_rank, _suit)
                Me._deck.Push(newCard)
            Next
        Next
    End Sub

    Sub New()
        shuffle()
    End Sub

End Class
