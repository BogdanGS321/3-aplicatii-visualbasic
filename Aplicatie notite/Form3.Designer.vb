<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TextBoxContinut = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBoxContinut
        ' 
        TextBoxContinut.Location = New Point(15, 27)
        TextBoxContinut.Multiline = True
        TextBoxContinut.Name = "TextBoxContinut"
        TextBoxContinut.Size = New Size(340, 296)
        TextBoxContinut.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 5
        Label2.Text = "Continut"' 
        ' Button1
        ' 
        Button1.Location = New Point(15, 329)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Salveaza"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(369, 358)
        Controls.Add(Button1)
        Controls.Add(TextBoxContinut)
        Controls.Add(Label2)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxContinut As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
