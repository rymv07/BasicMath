<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBasicMath
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubr = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDivi = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFirstNumber = New System.Windows.Forms.TextBox()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblFirstNumber = New System.Windows.Forms.Label()
        Me.lblSecondNumber = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(30, 18)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubr
        '
        Me.btnSubr.Location = New System.Drawing.Point(30, 47)
        Me.btnSubr.Name = "btnSubr"
        Me.btnSubr.Size = New System.Drawing.Size(75, 23)
        Me.btnSubr.TabIndex = 1
        Me.btnSubr.Text = "Subtract"
        Me.btnSubr.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(30, 76)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(75, 23)
        Me.btnMult.TabIndex = 2
        Me.btnMult.Text = "Multiply"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnDivi
        '
        Me.btnDivi.Location = New System.Drawing.Point(30, 105)
        Me.btnDivi.Name = "btnDivi"
        Me.btnDivi.Size = New System.Drawing.Size(75, 23)
        Me.btnDivi.TabIndex = 3
        Me.btnDivi.Text = "Divide"
        Me.btnDivi.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(261, 159)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFirstNumber
        '
        Me.txtFirstNumber.Location = New System.Drawing.Point(236, 44)
        Me.txtFirstNumber.Name = "txtFirstNumber"
        Me.txtFirstNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstNumber.TabIndex = 5
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.Location = New System.Drawing.Point(236, 73)
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtSecondNumber.TabIndex = 6
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(236, 114)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 7
        '
        'lblFirstNumber
        '
        Me.lblFirstNumber.AutoSize = True
        Me.lblFirstNumber.Location = New System.Drawing.Point(144, 47)
        Me.lblFirstNumber.Name = "lblFirstNumber"
        Me.lblFirstNumber.Size = New System.Drawing.Size(69, 13)
        Me.lblFirstNumber.TabIndex = 8
        Me.lblFirstNumber.Text = "First Number:"
        '
        'lblSecondNumber
        '
        Me.lblSecondNumber.AutoSize = True
        Me.lblSecondNumber.Location = New System.Drawing.Point(144, 76)
        Me.lblSecondNumber.Name = "lblSecondNumber"
        Me.lblSecondNumber.Size = New System.Drawing.Size(90, 13)
        Me.lblSecondNumber.TabIndex = 9
        Me.lblSecondNumber.Text = "Second Number: "
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(144, 117)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(45, 13)
        Me.lblAnswer.TabIndex = 10
        Me.lblAnswer.Text = "Answer:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(30, 159)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmBasicMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 194)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblSecondNumber)
        Me.Controls.Add(Me.lblFirstNumber)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtSecondNumber)
        Me.Controls.Add(Me.txtFirstNumber)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDivi)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnSubr)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmBasicMath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basic Math"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubr As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnDivi As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFirstNumber As TextBox
    Friend WithEvents txtSecondNumber As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblFirstNumber As Label
    Friend WithEvents lblSecondNumber As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnClear As Button
End Class
