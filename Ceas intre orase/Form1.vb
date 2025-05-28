Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ora1, ora2 As Date

        Select Case ComboBox1.SelectedItem
            Case "Bucuresti"

                TextBox1.Text = Now.ToString("f")
            Case "Londra"

                TextBox1.Text = Now.AddHours(-2).ToString("f")
            Case "New York"

                TextBox1.Text = Now.AddHours(-7).ToString("f")
            Case "Beijing"

                TextBox1.Text = Now.AddHours(5).ToString("f")
            Case "Tokyo"

                TextBox1.Text = Now.AddHours(6).ToString("f")
            Case "Berlin"

                TextBox1.Text = Now.AddHours(1).ToString("f")
        End Select


        Select Case ComboBox2.SelectedItem
            Case "Bucuresti"

                TextBox2.Text = Now.ToString("f")
            Case "Londra"

                TextBox2.Text = Now.AddHours(-2).ToString("f")
            Case "New York"

                TextBox2.Text = Now.AddHours(-7).ToString("f")
            Case "Beijing"

                TextBox2.Text = Now.AddHours(5).ToString("f")
            Case "Tokyo"

                TextBox2.Text = Now.AddHours(6).ToString("f")
            Case "Berlin"
                TextBox2.Text = Now.AddHours(1).ToString("f")
        End Select

        If TextBox1.Text <> String.Empty And TextBox2.Text <> String.Empty Then
            ora1 = TextBox1.Text
            ora2 = TextBox2.Text
            Dim diferenta As Integer
            If ora1 >= ora2 Then
                diferenta = (ora1 - ora2).TotalHours
                If diferenta = 1 Then
                    Label1.Text = ComboBox1.SelectedItem() + " este inainte cu o ora"
                Else
                    Label1.Text = ComboBox1.SelectedItem() + " este inainte cu " + diferenta.ToString + " ore"
                End If

            Else
                diferenta = (ora2 - ora1).TotalHours
                If diferenta = 1 Then
                    Label1.Text = ComboBox2.SelectedItem() + " este inainte cu o ora"
                Else Label1.Text = ComboBox2.SelectedItem() + " este inainte cu " + diferenta.ToString + " ore"
                End If
            End If
            If ComboBox1.SelectedItem() = ComboBox2.SelectedItem() Then
                Label1.Text = "Acelasi oras"
            End If
        End If
    End Sub
End Class
