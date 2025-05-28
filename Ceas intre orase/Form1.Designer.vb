<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Timer1 = New Timer(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Bucuresti", "Londra", "New York", "Beijing", "Tokyo", "Berlin"})
        ComboBox1.Location = New Point(37, 112)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(139, 23)
        ComboBox1.TabIndex = 0
        ComboBox1.Text = "Selecteaza capitala"' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Bucuresti", "Londra", "New York", "Beijing", "Tokyo", "Berlin"})
        ComboBox2.Location = New Point(294, 112)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(133, 23)
        ComboBox2.TabIndex = 1
        ComboBox2.Text = "Selecteaza capitala"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(37, 83)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(139, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(294, 83)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(133, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(176, 174)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(488, 238)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
