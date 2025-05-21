<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
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
        Me.btnReset.Location = New System.Drawing.Point(911, 675)
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
        Me.rd250.Location = New System.Drawing.Point(785, 678)
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
        Me.rd100.Location = New System.Drawing.Point(668, 678)
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
        Me.rd25.Location = New System.Drawing.Point(575, 678)
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
        Me.rd10.Location = New System.Drawing.Point(486, 678)
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
        Me.label8.Location = New System.Drawing.Point(649, 354)
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
        Me.label7.Location = New System.Drawing.Point(1042, 354)
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
        Me.label5.Location = New System.Drawing.Point(261, 354)
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
        Me.btnDeal.Location = New System.Drawing.Point(531, 273)
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
        Me.label4.Location = New System.Drawing.Point(1093, 662)
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
        Me.lblScore.Location = New System.Drawing.Point(256, 662)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(130, 52)
        Me.lblScore.TabIndex = 44
        Me.lblScore.Text = "1000"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(164, 678)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(85, 24)
        Me.label6.TabIndex = 43
        Me.label6.Text = "SCORE:"
        '
        'lblBankerPts
        '
        Me.lblBankerPts.AutoSize = True
        Me.lblBankerPts.Font = New System.Drawing.Font("Tahoma", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBankerPts.Location = New System.Drawing.Point(866, 248)
        Me.lblBankerPts.Name = "lblBankerPts"
        Me.lblBankerPts.Size = New System.Drawing.Size(78, 81)
        Me.lblBankerPts.TabIndex = 42
        Me.lblBankerPts.Text = "0"
        '
        'lblPlayerPts
        '
        Me.lblPlayerPts.AutoSize = True
        Me.lblPlayerPts.Font = New System.Drawing.Font("Tahoma", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerPts.Location = New System.Drawing.Point(402, 248)
        Me.lblPlayerPts.Name = "lblPlayerPts"
        Me.lblPlayerPts.Size = New System.Drawing.Size(78, 81)
        Me.lblPlayerPts.TabIndex = 41
        Me.lblPlayerPts.Text = "0"
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Font = New System.Drawing.Font("Tahoma", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.Location = New System.Drawing.Point(612, 72)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(160, 145)
        Me.lblWinner.TabIndex = 40
        Me.lblWinner.Text = ">"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(633, 228)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(98, 24)
        Me.label3.TabIndex = 39
        Me.label3.Text = "WINNER"
        '
        'lblCardB1
        '
        Me.lblCardB1.AutoSize = True
        Me.lblCardB1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardB1.Location = New System.Drawing.Point(973, 118)
        Me.lblCardB1.Name = "lblCardB1"
        Me.lblCardB1.Size = New System.Drawing.Size(112, 72)
        Me.lblCardB1.TabIndex = 38
        Me.lblCardB1.Text = "XX"
        '
        'lblCardB2
        '
        Me.lblCardB2.AutoSize = True
        Me.lblCardB2.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardB2.Location = New System.Drawing.Point(855, 118)
        Me.lblCardB2.Name = "lblCardB2"
        Me.lblCardB2.Size = New System.Drawing.Size(112, 72)
        Me.lblCardB2.TabIndex = 37
        Me.lblCardB2.Text = "XX"
        '
        'lblCardP2
        '
        Me.lblCardP2.AutoSize = True
        Me.lblCardP2.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardP2.Location = New System.Drawing.Point(371, 118)
        Me.lblCardP2.Name = "lblCardP2"
        Me.lblCardP2.Size = New System.Drawing.Size(112, 72)
        Me.lblCardP2.TabIndex = 36
        Me.lblCardP2.Text = "XX"
        '
        'lblCardP1
        '
        Me.lblCardP1.AutoSize = True
        Me.lblCardP1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardP1.Location = New System.Drawing.Point(253, 118)
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
        Me.label2.Location = New System.Drawing.Point(863, 28)
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
        Me.label1.Location = New System.Drawing.Point(392, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(88, 24)
        Me.label1.TabIndex = 33
        Me.label1.Text = "PLAYER"
        '
        'btnTie
        '
        Me.btnTie.BackColor = System.Drawing.Color.Chartreuse
        Me.btnTie.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTie.Location = New System.Drawing.Point(486, 336)
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
        Me.btnBanker.Location = New System.Drawing.Point(867, 336)
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
        Me.btnPlayer.Location = New System.Drawing.Point(105, 336)
        Me.btnPlayer.Name = "btnPlayer"
        Me.btnPlayer.Size = New System.Drawing.Size(375, 313)
        Me.btnPlayer.TabIndex = 30
        Me.btnPlayer.Text = "P L A Y E R"
        Me.btnPlayer.UseVisualStyleBackColor = False
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 762)
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
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
