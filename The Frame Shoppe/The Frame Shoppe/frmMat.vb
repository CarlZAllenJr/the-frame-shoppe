Public Class frmMat
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()                                           'To stow away mat selector
        frmMain.Show()                                      'To pull main form back up

        Dim MatPrice = frmMain.txtMatting
        MatPrice.Text = "$15.00"                            'To put price on main form
        frmMain.lblMatInfo.Text = "Single Mat - Blue"       'To put description in main form 
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        frmMain.Show()

        Dim MatPrice = frmMain.txtMatting
        MatPrice.Text = "$15.00"
        frmMain.lblMatInfo.Text = "Single Mat - Black"
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        frmMain.Show()

        Dim MatPrice = frmMain.txtMatting
        MatPrice.Text = "$30.00"
        frmMain.lblMatInfo.Text = "Double Mat - Black, White"
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Hide()
        frmMain.Show()

        Dim MatPrice = frmMain.txtMatting
        MatPrice.Text = "$30.00"
        frmMain.lblMatInfo.Text = "Double Mat - Blue, White"
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        frmMain.Show()

        Dim MatPrice = frmMain.txtMatting
        MatPrice.Text = "$30.00"
        frmMain.lblMatInfo.Text = "Double Mat - White, Black"
        Call frmMain.UpdateFields()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        frmMain.Show()

        Dim MatPrice = frmMain.txtMatting
        MatPrice.Text = "$30.00"
        frmMain.lblMatInfo.Text = "Double Mat - Dk Blue, Lt Blue"
        Call frmMain.UpdateFields()
    End Sub
End Class