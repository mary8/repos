Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Username As String = Nothing
        Username = InputBox("Enter staff Id",,,)
        MessageBox.Show("enter staff id", MessageBoxButtons.OK)




    End Sub

    Private Sub LBLshiftId_Click(sender As Object, e As EventArgs) Handles LBLshiftId.Click
        Dim Username As Integer = Nothing
        Username = InputBox("Enter shift Id",,,)
        MessageBox.Show("enter shift id", MessageBoxButtons.OK)


    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        MessageBox.Show("delete record")
        MessageBox.Show("form deleted", MessageBoxButtons.OK)
    End Sub
End Class
