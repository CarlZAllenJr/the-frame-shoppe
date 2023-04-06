Public Class frmMain
    Public Sub btnWidth_Click(sender As Object, e As EventArgs) Handles btnWidth.Click
        Dim Message, Title, setWidth As String
        Message = "Please set the width of your art."
        Title = "Width Setter"
        setWidth = InputBox(Message, Title, 0, ,) 'To allow for width input
        lblWidth.Text = setWidth

        If (setWidth <= -1) Then                     'To give error if number is below 1
            MessageBox.Show("Error: Width must be greater than zero inches")
        End If
        Call UpdateFields()                         'To update the price groupbox
    End Sub

    Public Sub btnHeight_Click(sender As Object, e As EventArgs) Handles btnHeight.Click
        Dim Message, Title, setHeight As String
        Message = "Please set the height of your art."
        Title = "Height Setter"
        setHeight = InputBox(Message, Title, 0, ,) 'To allow height input
        lblHeight.Text = setHeight

        If (setHeight <= -1) Then                    'To give error if number is below 1
            MessageBox.Show("Error: Height must be greater than zero inches")
        End If
        Call UpdateFields()
    End Sub

    Public Sub btnFrame_Click(sender As Object, e As EventArgs) Handles btnFrame.Click
        frmFrame.Show()                             'To show frame selection screen
        Call UpdateFields()
    End Sub

    Private Sub btnMat_Click(sender As Object, e As EventArgs) Handles btnMat.Click
        frmMat.Show()                               'To show mat selection screen
        Call UpdateFields()
    End Sub

    Private Sub btnCover_Click(sender As Object, e As EventArgs) Handles btnCover.Click
        frmCover.Show()                             'To show cover selection screen
        Call UpdateFields()
    End Sub

    Public Sub UpdateFields()                                                    'Subroutine to update Price group box
        Dim Subtotal = CDbl(txtFrame.Text + +txtMatting.Text + +txtCover.Text)
        lblSubtotal.Text = FormatCurrency(Subtotal)                              'To get Subtotal

        Dim Tax = CDbl(Subtotal * 0.07)
        lblTax.Text = FormatCurrency(Tax)                                        'To get Taxes

        Dim Total = CDbl(Subtotal + +Tax)
        lblTotal.Text = FormatCurrency(Total)                                    'To get Total
    End Sub
End Class
