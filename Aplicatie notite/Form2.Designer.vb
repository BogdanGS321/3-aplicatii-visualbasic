<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TextBoxTitlu = New TextBox()
        TextBoxContinut = New TextBox()
        ButonAdauga = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 0
        Label1.Text = "Titlu"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 1
        Label2.Text = "Continut"' 
        ' TextBoxTitlu
        ' 
        TextBoxTitlu.Location = New Point(74, 19)
        TextBoxTitlu.Name = "TextBoxTitlu"
        TextBoxTitlu.Size = New Size(288, 23)
        TextBoxTitlu.TabIndex = 2
        ' 
        ' TextBoxContinut
        ' 
        TextBoxContinut.Location = New Point(22, 70)
        TextBoxContinut.Multiline = True
        TextBoxContinut.Name = "TextBoxContinut"
        TextBoxContinut.Size = New Size(340, 260)
        TextBoxContinut.TabIndex = 3
        ' 
        ' ButonAdauga
        ' 
        ButonAdauga.Location = New Point(22, 345)
        ButonAdauga.Name = "ButonAdauga"
        ButonAdauga.Size = New Size(97, 23)
        ButonAdauga.TabIndex = 4
        ButonAdauga.Text = "Adauga notita"
        ButonAdauga.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(409, 395)
        Controls.Add(ButonAdauga)
        Controls.Add(TextBoxContinut)
        Controls.Add(TextBoxTitlu)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTitlu As TextBox
    Friend WithEvents TextBoxContinut As TextBox
    Friend WithEvents ButonAdauga As Button
End Class
