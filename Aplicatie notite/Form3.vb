Imports System.IO

Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBoxContinut.Text = "" Then
            MessageBox.Show("Notita trebuie sa aiba continut.")
        Else
            File.WriteAllText(Form1.ListBox1.SelectedItem() + ".txt", TextBoxContinut.Text)
        End If

        Me.Hide()
        Me.Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxContinut.Text = File.ReadAllText(Form1.ListBox1.SelectedItem() + ".txt")
    End Sub
End Class