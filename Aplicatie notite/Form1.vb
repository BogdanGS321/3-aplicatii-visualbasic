Imports System.IO

Public Class Form1
    Public Titluri As String()
    Public listaTitluri As String = "listaTitluri.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If File.Exists(listaTitluri) Then
            Titluri = File.ReadAllLines(listaTitluri)
            ListBox1.Items.AddRange(Titluri)
        Else
            File.WriteAllText(listaTitluri, "")
            Titluri = File.ReadAllLines(listaTitluri)
        End If



    End Sub

    Private Sub AdaugaNotiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdaugaNotiteToolStripMenuItem.Click
        Form2.ShowDialog()
        Application.Restart()


    End Sub


    Private Sub EditeazaNotitaSelectataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditeazaNotitaSelectataToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub
End Class
