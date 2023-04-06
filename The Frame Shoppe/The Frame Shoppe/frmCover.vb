Public Class frmCover
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()                                                                               'To stow away cover selector
        frmMain.Show()                                                                          'To show main form
        Dim setCover = frmMain.txtCover
        Dim CoverPrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 0.01D     'To find price for cover
        setCover.Text = FormatCurrency(CoverPrice)                                              'To convert cost to currency display
        frmMain.lblCoverInfo.Text = "Acrylic"                                                   'To display selected items description
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        frmMain.Show()
        Dim setCover = frmMain.txtCover
        Dim CoverPrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 0.25D
        setCover.Text = FormatCurrency(CoverPrice)
        frmMain.lblCoverInfo.Text = "Glass"
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        frmMain.Show()
        Dim setCover = frmMain.txtCover
        Dim CoverPrice = CDbl(frmMain.lblHeight.Text) * CDbl(frmMain.lblWidth.Text) * 0.3D
        setCover.Text = FormatCurrency(CoverPrice)
        frmMain.lblCoverInfo.Text = "Nonreflective Glass"
        Call frmMain.UpdateFields()
    End Sub
End Class