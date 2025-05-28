Imports System.Configuration
Imports System.IO

Public Class Form2
    Public titlu As String
    Public continut As String
    Private Sub ButonAdauga_Click(sender As Object, e As EventArgs) Handles ButonAdauga.Click
        titlu = TextBoxTitlu.Text
        continut = TextBoxContinut.Text
        If titlu = "" Or continut = "" Then
            MessageBox.Show("Notita trebuie sa aiba titlu/continut.")
        Else
            If File.Exists(titlu + ".txt") Then
                MessageBox.Show("Exista deja un fisier cu acest titlu.")
            Else
                File.WriteAllText(titlu + ".txt", continut)
            End If
            File.AppendAllText(Form1.listaTitluri, titlu + vbCrLf)
        End If
        TextBoxTitlu.Clear()
        TextBoxContinut.Clear()

        Me.Hide()
        Me.Close()

    End Sub
End Class