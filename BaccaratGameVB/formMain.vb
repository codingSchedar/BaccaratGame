Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace BaccaratGameVB
    Partial Public Class formMain
        Inherits Form
        Private playerPoints As Integer = 1000
        Private betAmount As Integer = 0
        Private betPlaced As Boolean = False ' Indicates whether a bet is placed
        Private choice As String = ""



        Private WithEvents btnReset As Button
        Private WithEvents rd250 As RadioButton
        Private WithEvents rd100 As RadioButton
        Private WithEvents rd25 As RadioButton
        Private WithEvents rd10 As RadioButton
        Private WithEvents label8 As Label
        Private WithEvents label7 As Label
        Private WithEvents label5 As Label
        Private WithEvents btnDeal As Button
        Private WithEvents label4 As Label
        Private WithEvents lblScore As Label
        Private WithEvents label6 As Label
        Private WithEvents lblBankerPts As Label
        Private WithEvents lblPlayerPts As Label
        Private WithEvents lblWinner As Label
        Private WithEvents label3 As Label
        Private WithEvents lblCardB1 As Label
        Private WithEvents lblCardB2 As Label
        Private WithEvents lblCardP2 As Label
        Private WithEvents lblCardP1 As Label
        Private WithEvents label2 As Label
        Private WithEvents label1 As Label
        Private WithEvents btnTie As Button
        Private WithEvents btnBanker As Button
        Private WithEvents btnPlayer As Button

        Private Sub InitializeComponent()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.rd250 = New System.Windows.Forms.RadioButton()
            Me.rd100 = New System.Windows.Forms.RadioButton()
            Me.rd25 = New System.Windows.Forms.RadioButton()
            Me.rd10 = New System.Windows.Forms.RadioButton()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.btnDeal = New System.Windows.Forms.Button()
            Me.label4 = New System.Windows.Forms.Label()
            Me.lblScore = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.lblBankerPts = New System.Windows.Forms.Label()
            Me.lblPlayerPts = New System.Windows.Forms.Label()
            Me.lblWinner = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.lblCardB1 = New System.Windows.Forms.Label()
            Me.lblCardB2 = New System.Windows.Forms.Label()
            Me.lblCardP2 = New System.Windows.Forms.Label()
            Me.lblCardP1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.btnTie = New System.Windows.Forms.Button()
            Me.btnBanker = New System.Windows.Forms.Button()
            Me.btnPlayer = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'btnReset
            '
            Me.btnReset.Location = New System.Drawing.Point(914, 681)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(121, 45)
            Me.btnReset.TabIndex = 54
            Me.btnReset.Text = "RESTART"
            Me.btnReset.UseVisualStyleBackColor = True
            '
            'rd250
            '
            Me.rd250.AutoSize = True
            Me.rd250.Font = New System.Drawing.Font("Tahoma", 15.0!)
            Me.rd250.Location = New System.Drawing.Point(788, 684)
            Me.rd250.Name = "rd250"
            Me.rd250.Size = New System.Drawing.Size(76, 34)
            Me.rd250.TabIndex = 53
            Me.rd250.TabStop = True
            Me.rd250.Text = "250"
            Me.rd250.UseVisualStyleBackColor = True
            '
            'rd100
            '
            Me.rd100.AutoSize = True
            Me.rd100.Font = New System.Drawing.Font("Tahoma", 15.0!)
            Me.rd100.Location = New System.Drawing.Point(671, 684)
            Me.rd100.Name = "rd100"
            Me.rd100.Size = New System.Drawing.Size(76, 34)
            Me.rd100.TabIndex = 52
            Me.rd100.TabStop = True
            Me.rd100.Text = "100"
            Me.rd100.UseVisualStyleBackColor = True
            '
            'rd25
            '
            Me.rd25.AutoSize = True
            Me.rd25.Font = New System.Drawing.Font("Tahoma", 15.0!)
            Me.rd25.Location = New System.Drawing.Point(578, 684)
            Me.rd25.Name = "rd25"
            Me.rd25.Size = New System.Drawing.Size(62, 34)
            Me.rd25.TabIndex = 51
            Me.rd25.TabStop = True
            Me.rd25.Text = "25"
            Me.rd25.UseVisualStyleBackColor = True
            '
            'rd10
            '
            Me.rd10.AutoSize = True
            Me.rd10.Font = New System.Drawing.Font("Tahoma", 15.0!)
            Me.rd10.Location = New System.Drawing.Point(489, 684)
            Me.rd10.Name = "rd10"
            Me.rd10.Size = New System.Drawing.Size(62, 34)
            Me.rd10.TabIndex = 50
            Me.rd10.TabStop = True
            Me.rd10.Text = "10"
            Me.rd10.UseVisualStyleBackColor = True
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.BackColor = System.Drawing.Color.Chartreuse
            Me.label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.Location = New System.Drawing.Point(652, 360)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(43, 24)
            Me.label8.TabIndex = 49
            Me.label8.Text = "8:1"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.BackColor = System.Drawing.Color.RoyalBlue
            Me.label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.Location = New System.Drawing.Point(1045, 360)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(43, 24)
            Me.label7.TabIndex = 48
            Me.label7.Text = "1:1"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.Red
            Me.label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(264, 360)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(43, 24)
            Me.label5.TabIndex = 47
            Me.label5.Text = "1:1"
            '
            'btnDeal
            '
            Me.btnDeal.BackColor = System.Drawing.Color.Black
            Me.btnDeal.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDeal.ForeColor = System.Drawing.SystemColors.ControlLight
            Me.btnDeal.Location = New System.Drawing.Point(534, 279)
            Me.btnDeal.Name = "btnDeal"
            Me.btnDeal.Size = New System.Drawing.Size(296, 56)
            Me.btnDeal.TabIndex = 46
            Me.btnDeal.Text = "D E A L"
            Me.btnDeal.UseVisualStyleBackColor = False
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(1096, 668)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(131, 72)
            Me.label4.TabIndex = 45
            Me.label4.Text = "Reach" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10,000 points" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to WIN!!!"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblScore
            '
            Me.lblScore.AutoSize = True
            Me.lblScore.Font = New System.Drawing.Font("Tahoma", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblScore.Location = New System.Drawing.Point(259, 668)
            Me.lblScore.Name = "lblScore"
            Me.lblScore.Size = New System.Drawing.Size(130, 52)
            Me.lblScore.TabIndex = 44
            Me.lblScore.Text = "1000"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.Location = New System.Drawing.Point(167, 684)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(85, 24)
            Me.label6.TabIndex = 43
            Me.label6.Text = "SCORE:"
            '
            'lblBankerPts
            '
            Me.lblBankerPts.AutoSize = True
            Me.lblBankerPts.Font = New System.Drawing.Font("Tahoma", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBankerPts.Location = New System.Drawing.Point(869, 254)
            Me.lblBankerPts.Name = "lblBankerPts"
            Me.lblBankerPts.Size = New System.Drawing.Size(78, 81)
            Me.lblBankerPts.TabIndex = 42
            Me.lblBankerPts.Text = "0"
            '
            'lblPlayerPts
            '
            Me.lblPlayerPts.AutoSize = True
            Me.lblPlayerPts.Font = New System.Drawing.Font("Tahoma", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPlayerPts.Location = New System.Drawing.Point(405, 254)
            Me.lblPlayerPts.Name = "lblPlayerPts"
            Me.lblPlayerPts.Size = New System.Drawing.Size(78, 81)
            Me.lblPlayerPts.TabIndex = 41
            Me.lblPlayerPts.Text = "0"
            '
            'lblWinner
            '
            Me.lblWinner.AutoSize = True
            Me.lblWinner.Font = New System.Drawing.Font("Tahoma", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblWinner.Location = New System.Drawing.Point(615, 78)
            Me.lblWinner.Name = "lblWinner"
            Me.lblWinner.Size = New System.Drawing.Size(160, 145)
            Me.lblWinner.TabIndex = 40
            Me.lblWinner.Text = ">"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(636, 234)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(98, 24)
            Me.label3.TabIndex = 39
            Me.label3.Text = "WINNER"
            '
            'lblCardB1
            '
            Me.lblCardB1.AutoSize = True
            Me.lblCardB1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCardB1.Location = New System.Drawing.Point(976, 124)
            Me.lblCardB1.Name = "lblCardB1"
            Me.lblCardB1.Size = New System.Drawing.Size(112, 72)
            Me.lblCardB1.TabIndex = 38
            Me.lblCardB1.Text = "XX"
            '
            'lblCardB2
            '
            Me.lblCardB2.AutoSize = True
            Me.lblCardB2.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCardB2.Location = New System.Drawing.Point(858, 124)
            Me.lblCardB2.Name = "lblCardB2"
            Me.lblCardB2.Size = New System.Drawing.Size(112, 72)
            Me.lblCardB2.TabIndex = 37
            Me.lblCardB2.Text = "XX"
            '
            'lblCardP2
            '
            Me.lblCardP2.AutoSize = True
            Me.lblCardP2.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCardP2.Location = New System.Drawing.Point(374, 124)
            Me.lblCardP2.Name = "lblCardP2"
            Me.lblCardP2.Size = New System.Drawing.Size(112, 72)
            Me.lblCardP2.TabIndex = 36
            Me.lblCardP2.Text = "XX"
            '
            'lblCardP1
            '
            Me.lblCardP1.AutoSize = True
            Me.lblCardP1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCardP1.Location = New System.Drawing.Point(256, 124)
            Me.lblCardP1.Name = "lblCardP1"
            Me.lblCardP1.Size = New System.Drawing.Size(112, 72)
            Me.lblCardP1.TabIndex = 35
            Me.lblCardP1.Text = "XX"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.RoyalBlue
            Me.label2.Location = New System.Drawing.Point(866, 34)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(94, 24)
            Me.label2.TabIndex = 34
            Me.label2.Text = "BANKER"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Red
            Me.label1.Location = New System.Drawing.Point(395, 34)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(88, 24)
            Me.label1.TabIndex = 33
            Me.label1.Text = "PLAYER"
            '
            'btnTie
            '
            Me.btnTie.BackColor = System.Drawing.Color.Chartreuse
            Me.btnTie.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTie.Location = New System.Drawing.Point(489, 342)
            Me.btnTie.Name = "btnTie"
            Me.btnTie.Size = New System.Drawing.Size(375, 313)
            Me.btnTie.TabIndex = 32
            Me.btnTie.Text = "T I E"
            Me.btnTie.UseVisualStyleBackColor = False
            '
            'btnBanker
            '
            Me.btnBanker.BackColor = System.Drawing.Color.RoyalBlue
            Me.btnBanker.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBanker.Location = New System.Drawing.Point(870, 342)
            Me.btnBanker.Name = "btnBanker"
            Me.btnBanker.Size = New System.Drawing.Size(375, 313)
            Me.btnBanker.TabIndex = 31
            Me.btnBanker.Text = "B A N K E R"
            Me.btnBanker.UseVisualStyleBackColor = False
            '
            'btnPlayer
            '
            Me.btnPlayer.BackColor = System.Drawing.Color.Red
            Me.btnPlayer.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPlayer.Location = New System.Drawing.Point(108, 342)
            Me.btnPlayer.Name = "btnPlayer"
            Me.btnPlayer.Size = New System.Drawing.Size(375, 313)
            Me.btnPlayer.TabIndex = 30
            Me.btnPlayer.Text = "P L A Y E R"
            Me.btnPlayer.UseVisualStyleBackColor = False
            '
            'formMain
            '
            Me.ClientSize = New System.Drawing.Size(1352, 774)
            Me.Controls.Add(Me.btnReset)
            Me.Controls.Add(Me.rd250)
            Me.Controls.Add(Me.rd100)
            Me.Controls.Add(Me.rd25)
            Me.Controls.Add(Me.rd10)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.btnDeal)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.lblScore)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.lblBankerPts)
            Me.Controls.Add(Me.lblPlayerPts)
            Me.Controls.Add(Me.lblWinner)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.lblCardB1)
            Me.Controls.Add(Me.lblCardB2)
            Me.Controls.Add(Me.lblCardP2)
            Me.Controls.Add(Me.lblCardP1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.btnTie)
            Me.Controls.Add(Me.btnBanker)
            Me.Controls.Add(Me.btnPlayer)
            Me.Name = "formMain"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub formMain_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Add event handlers for your buttons
            AddHandler btnPlayer.Click, AddressOf btnPlayer_Click
            AddHandler btnTie.Click, AddressOf btnTie_Click
            AddHandler btnBanker.Click, AddressOf btnBanker_Click
            AddHandler btnDeal.Click, AddressOf btnDeal_Click
            AddHandler btnReset.Click, AddressOf btnReset_Click

            ' Disable player, banker, and tie buttons initially
            SetButtonEnabledState(False)
        End Sub

        Private Sub btnPlayer_Click(sender As Object, e As EventArgs) Handles btnPlayer.Click
            If betAmount <= 0 Then
                MessageBox.Show("Please select a bet amount first.")
                Return
            End If
            If betAmount > playerPoints Then
                betAmount = playerPoints ' Bet the maximum if not enough points
            End If
            choice = "p"
            consecutiveNoBetsCount = 0
            DeductBetAmount()
            UpdateButtonLabel(btnPlayer, betAmount.ToString())
            SetButtonEnabledState(False)
            betPlaced = True ' Set betPlaced flag after a bet is placed
        End Sub

        Private Sub btnTie_Click(sender As Object, e As EventArgs) Handles btnTie.Click
            If betAmount <= 0 Then
                ShowMessage("Please select a bet amount first.")
                Return
            End If
            If betAmount > playerPoints Then
                betAmount = playerPoints ' Bet the maximum if not enough points
            End If
            choice = "t"
            consecutiveNoBetsCount = 0
            DeductBetAmount()
            UpdateButtonLabel(btnTie, betAmount.ToString())
            SetButtonEnabledState(False)
            betPlaced = True ' Set betPlaced flag after a bet is placed
        End Sub

        Private Sub btnBanker_Click(sender As Object, e As EventArgs) Handles btnBanker.Click
            choice = "b"
            If betAmount <= 0 Then
                ShowMessage("Please select a bet amount first.")
                Return
            End If
            If betAmount > playerPoints Then
                betAmount = playerPoints ' Bet the maximum if not enough points
            End If
            consecutiveNoBetsCount = 0
            DeductBetAmount()
            UpdateButtonLabel(btnBanker, betAmount.ToString())
            SetButtonEnabledState(False)
            betPlaced = True ' Set betPlaced flag after a bet is placed
        End Sub


        Private consecutiveNoBetsCount As Integer = 0
        Private Sub btnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click
            If consecutiveNoBetsCount >= 4 Then
                ShowMessage("You need to place a bet to continue playing.")
                Return
            End If
            If Not betPlaced Then
                consecutiveNoBetsCount += 1
            End If

            ' Create and shuffle a deck for each game
            Dim deck As List(Of String) = CreateShuffledDeck()

            ' Deal cards
            Dim playerCard1 As String = DealCard(deck)
            Dim playerCard2 As String = DealCard(deck)
            Dim bankerCard1 As String = DealCard(deck)
            Dim bankerCard2 As String = DealCard(deck)

            ' Calculate card values
            Dim playerCardValue As Integer = CalculateCardValue(playerCard1, playerCard2)
            Dim bankerCardValue As Integer = CalculateCardValue(bankerCard1, bankerCard2)

            If playerCardValue >= 10 Then
                playerCardValue -= 10
            End If

            If bankerCardValue >= 10 Then
                bankerCardValue -= 10
            End If

            ' Update UI
            lblCardP1.Text = playerCard1
            lblCardP2.Text = playerCard2
            lblCardB1.Text = bankerCard1
            lblCardB2.Text = bankerCard2

            lblPlayerPts.Text = playerCardValue.ToString()
            lblBankerPts.Text = bankerCardValue.ToString()

            If playerCardValue > bankerCardValue Then
                lblWinner.Text = "<"
                If choice = "p" Then
                    ShowMessage($"PLAYER WINS!{Environment.NewLine}You win {2 * betAmount} points!")
                    playerPoints += (2 * betAmount)
                ElseIf choice = "" Then
                    ShowMessage($"PLAYER WINS!{Environment.NewLine}You have no valid bet!")
                Else
                    ShowMessage($"PLAYER WINS!{Environment.NewLine}You lose {betAmount} points!")
                End If
            ElseIf playerCardValue < bankerCardValue Then
                lblWinner.Text = ">"
                If choice = "b" Then
                    ShowMessage($"BANKER WINS!{Environment.NewLine}You win {2 * betAmount} points!")
                    playerPoints += (2 * betAmount)
                ElseIf choice = "" Then
                    ShowMessage($"BANKER WINS!{Environment.NewLine}You have no valid bet!")
                Else
                    ShowMessage($"BANKER WINS!{Environment.NewLine}You lose {betAmount} points!")
                End If
            ElseIf playerCardValue = bankerCardValue Then
                lblWinner.Text = "TIE"
                ShowMessage("It's a tie!")
                lblWinner.Text = "<"
                If choice = "t" Then
                    ShowMessage($"You win {9 * betAmount} points!")
                    playerPoints += (9 * betAmount)
                ElseIf choice = "p" OrElse choice = "b" Then
                    ShowMessage($"You win {betAmount} points!")
                    playerPoints += betAmount
                ElseIf choice = "" Then
                    ShowMessage($"IT'S A TIE!{Environment.NewLine}You have no valid bet!")
                Else
                    ShowMessage($"You lose {betAmount} points!")
                End If
            End If

            ' Ensure the score is not over 9
            playerPoints = Math.Max(playerPoints, 0)

            lblScore.Text = playerPoints.ToString()
            For Each control As Control In Controls
                If TypeOf control Is Button Then
                    Dim btn As Button = DirectCast(control, Button)
                    Select Case btn.Name
                        Case "btnPlayer"
                            btn.Text = "P L A Y E R"
                        Case "btnTie"
                            btn.Text = "T I E"
                        Case "btnBanker"
                            btn.Text = "B A N K E R"
                    End Select
                End If
            Next

            For Each control As Control In Controls
                If TypeOf control Is RadioButton Then
                    Dim radioButton As RadioButton = DirectCast(control, RadioButton)
                    radioButton.Checked = False
                End If
            Next

            If playerPoints >= 10000 Then
                ShowMessage($"CONGRATULATIONS!{Environment.NewLine}YOU WON THE GAME!{Environment.NewLine}You have achieved {playerPoints}!")
                playerPoints = 1000
                lblScore.Text = playerPoints.ToString()
            End If

            choice = ""
            betAmount = 0
            betPlaced = False
            ' Disable player, banker, and tie buttons after dealing
            SetButtonEnabledState(True)
        End Sub


        Private Sub DeductBetAmount()
            If betAmount > playerPoints Then
                betAmount = playerPoints ' Bet the maximum if not enough points
            End If

            playerPoints -= betAmount
            lblScore.Text = playerPoints.ToString()
        End Sub

        Private Sub UpdateButtonLabel(ByVal button As Button, ByVal newLabel As String)
            ' Save the original label text
            Dim originalText As String = button.Text

            ' Update the button text temporarily
            button.Text = newLabel

            ' Use a Timer to revert the button text after a short delay (e.g., 1000 milliseconds)
            'Dim timer As Timer = New Timer()
            'timer.Interval = 1000 ' Set the delay in milliseconds
            'AddHandler timer.Tick, Sub(sender, e) 
            '    button.Text = originalText
            '    timer.Stop()
            '    timer.Dispose()
            'End Sub

            'timer.Start()
        End Sub

        Private Function CreateShuffledDeck() As List(Of String)
            ' Create a standard deck of cards (assuming 4 suits and 13 ranks)
            Dim deck As List(Of String) = New List(Of String)()
            Dim suits As String() = {"♥", "♦", "♣", "♠"} ' Hearts, Diamonds, Clubs, Spades
            Dim ranks As String() = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"} ' 2 to Ace

            ' Define rank values
            Dim rankValues As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer) From {
                {"A", 1},   ' Change to 1 for Ace
                {"2", 2},
                {"3", 3},
                {"4", 4},
                {"5", 5},
                {"6", 6},
                {"7", 7},
                {"8", 8},
                {"9", 9},
                {"10", 10},
                {"J", 10},
                {"Q", 10},
                {"K", 10}
            }

            For Each suit As String In suits
                For Each rank As String In ranks
                    Dim displayRank As String = If((rank = "A"), "A", rank)
                    deck.Add(displayRank & suit)
                Next
            Next

            ' Shuffle the deck
            Dim rng As Random = New Random()
            Dim n As Integer = deck.Count
            While n > 1
                n -= 1
                Dim k As Integer = rng.Next(n + 1)
                Dim value As String = deck(k)
                deck(k) = deck(n)
                deck(n) = value
            End While

            ' Assign values to the cards based on rank
            For i As Integer = 0 To deck.Count - 1
                Dim rank As String = deck(i).Substring(0, deck(i).Length - 1)
                Dim value As Integer = rankValues(rank)
                deck(i) = value & deck(i).Substring(deck(i).Length - 1)
            Next

            Return deck
        End Function

        Private Function DealCard(ByVal deck As List(Of String)) As String
            ' Deal the top card from the deck
            Dim card As String = deck(0)
            deck.RemoveAt(0)
            Return card
        End Function

        Private Function CalculateCardValue(ByVal ParamArray cards As String()) As Integer
            ' Your logic to calculate the card value based on your game rules
            ' Example: (replace this with your own logic)
            Dim totalValue As Integer = 0
            For Each card As String In cards
                ' Extract the numeric part of the card (assuming "XX" format)
                Dim valueString As String = card.Substring(0, card.Length - 1)

                If Integer.TryParse(valueString, totalValue) Then
                    ' Handle 10, J, Q, K as 0 points
                    If totalValue > 9 Then
                        totalValue = 0
                    End If
                Else
                    ' Handle face cards or Ace if needed
                    ' For simplicity, this example assumes numeric values for face cards and Ace
                    totalValue += 0
                End If
            Next

            Return totalValue
        End Function

        Private Sub SetButtonEnabledState(ByVal enabled As Boolean)
            ' Enable or disable player, banker, and tie buttons
            btnPlayer.Enabled = enabled
            btnBanker.Enabled = enabled
            btnTie.Enabled = enabled
        End Sub

        Private Sub ShowMessage(ByVal message As String)
            MessageBox.Show(message, "Baccarat Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub rd10_CheckedChanged(sender As Object, e As EventArgs) Handles rd10.CheckedChanged
            If playerPoints > 0 Then
                If rd10.Checked Then
                    betAmount += 10
                Else
                    betAmount = 0
                End If
            Else
                ShowMessage($"You have {playerPoints} points!{Environment.NewLine}You lose!{Environment.NewLine}Try again next time!")
            End If
        End Sub

        Private Sub rd25_CheckedChanged(sender As Object, e As EventArgs) Handles rd25.CheckedChanged
            If playerPoints > 0 Then
                If rd25.Checked Then
                    betAmount += 25
                Else
                    betAmount = 0
                End If
            Else
                ShowMessage($"You have {playerPoints} points!{Environment.NewLine}You lose!{Environment.NewLine}Try again next time!")
            End If
        End Sub

        Private Sub rd100_CheckedChanged(sender As Object, e As EventArgs) Handles rd100.CheckedChanged
            If playerPoints > 0 Then
                If rd100.Checked Then
                    betAmount += 100
                Else
                    betAmount = 0
                End If
            Else
                ShowMessage($"You have {playerPoints} points!{Environment.NewLine}You lose!{Environment.NewLine}Try again next time!")
            End If
        End Sub

        Private Sub rd250_CheckedChanged(sender As Object, e As EventArgs) Handles rd250.CheckedChanged
            If playerPoints > 0 Then
                If rd250.Checked Then
                    betAmount += 250
                Else
                    betAmount = 0
                End If
            Else
                ShowMessage($"You have {playerPoints} points!{Environment.NewLine}You lose!{Environment.NewLine}Try again next time!")
            End If
        End Sub

        Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
            If playerPoints <> 1000 Then
                playerPoints = 1000
                consecutiveNoBetsCount = 0
                lblScore.Text = playerPoints.ToString()
            End If

            ShowMessage("GAME RESTART! Good luck!")
        End Sub

        Private Sub label8_Click(sender As Object, e As EventArgs) Handles label8.Click

        End Sub

        Private Sub label7_Click(sender As Object, e As EventArgs) Handles label7.Click

        End Sub

        Private Sub label5_Click(sender As Object, e As EventArgs) Handles label5.Click

        End Sub

        Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click

        End Sub

        Private Sub lblScore_Click(sender As Object, e As EventArgs) Handles lblScore.Click

        End Sub

        Private Sub label6_Click(sender As Object, e As EventArgs) Handles label6.Click

        End Sub

        Private Sub lblBankerPts_Click(sender As Object, e As EventArgs) Handles lblBankerPts.Click

        End Sub

        Private Sub lblPlayerPts_Click(sender As Object, e As EventArgs) Handles lblPlayerPts.Click

        End Sub

        Private Sub lblWinner_Click(sender As Object, e As EventArgs) Handles lblWinner.Click

        End Sub

        Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click

        End Sub

        Private Sub lblCardB1_Click(sender As Object, e As EventArgs) Handles lblCardB1.Click

        End Sub

        Private Sub lblCardB2_Click(sender As Object, e As EventArgs) Handles lblCardB2.Click

        End Sub

        Private Sub lblCardP2_Click(sender As Object, e As EventArgs) Handles lblCardP2.Click

        End Sub

        Private Sub lblCardP1_Click(sender As Object, e As EventArgs) Handles lblCardP1.Click

        End Sub

        Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click

        End Sub

        Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

        End Sub
    End Class
End Namespace
