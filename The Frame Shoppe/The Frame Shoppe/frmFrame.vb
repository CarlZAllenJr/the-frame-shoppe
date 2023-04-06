Public Class frmFrame
    Public Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Frame1.Click
        Me.Hide()                                                                                   'To stow away frame selector
        frmMain.Show()                                                                              'To show main form
        Dim setWidth = frmMain.txtFrame
        Dim FramePrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 0.33D         'To get price for frame
        frmMain.lblFrameInfo.Text = "Basket Weave"                                                  'To show description on main form
        setWidth.Text = FormatCurrency(FramePrice)                                                  'To show frame price on main form
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Frame2.Click
        Me.Hide()
        frmMain.Show()
        frmMain.lblFrameInfo.Text = "Flat Black"
        Dim setWidth = frmMain.txtFrame
        Dim FramePrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 0.45D
        setWidth.Text = FormatCurrency(FramePrice)
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles Frame3.Click
        Me.Hide()
        frmMain.Show()
        frmMain.lblFrameInfo.Text = "Tacked"
        Dim setWidth = frmMain.txtFrame
        Dim FramePrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 0.75D
        setWidth.Text = FormatCurrency(FramePrice)
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles Frame4.Click
        Me.Hide()
        frmMain.Show()
        frmMain.lblFrameInfo.Text = "Gilded"
        Dim setWidth = frmMain.txtFrame
        Dim FramePrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 2.5D
        setWidth.Text = FormatCurrency(FramePrice)
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles Frame5.Click
        Me.Hide()
        frmMain.Show()
        frmMain.lblFrameInfo.Text = "Oak"
        Dim setWidth = frmMain.txtFrame
        Dim FramePrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 1.21D
        setWidth.Text = FormatCurrency(FramePrice)
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles Frame6.Click
        Me.Hide()
        frmMain.Show()
        frmMain.lblFrameInfo.Text = "Pecan"
        Dim setWidth = frmMain.txtFrame
        Dim FramePrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 1.99D
        setWidth.Text = FormatCurrency(FramePrice)
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles Frame7.Click
        Me.Hide()
        frmMain.Show()
        frmMain.lblFrameInfo.Text = "Stripe"
        Dim setWidth = frmMain.txtFrame
        Dim FramePrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 1D
        setWidth.Text = FormatCurrency(FramePrice)
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles Frame8.Click
        Me.Hide()
        frmMain.Show()
        frmMain.lblFrameInfo.Text = "Degree"
        Dim setWidth = frmMain.txtFrame
        Dim FramePrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 3.5D
        setWidth.Text = FormatCurrency(FramePrice)
        Call frmMain.UpdateFields()
    End Sub
End Class