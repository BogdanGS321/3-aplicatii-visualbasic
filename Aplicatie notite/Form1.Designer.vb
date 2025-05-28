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
        MenuStrip1 = New MenuStrip()
        NotiteToolStripMenuItem = New ToolStripMenuItem()
        AdaugaNotiteToolStripMenuItem = New ToolStripMenuItem()
        EditeazaNotitaSelectataToolStripMenuItem = New ToolStripMenuItem()
        ListBox1 = New ListBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {NotiteToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(273, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"' 
        ' NotiteToolStripMenuItem
        ' 
        NotiteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdaugaNotiteToolStripMenuItem, EditeazaNotitaSelectataToolStripMenuItem})
        NotiteToolStripMenuItem.Name = "NotiteToolStripMenuItem"
        NotiteToolStripMenuItem.Size = New Size(52, 20)
        NotiteToolStripMenuItem.Text = "Notite"' 
        ' AdaugaNotiteToolStripMenuItem
        ' 
        AdaugaNotiteToolStripMenuItem.Name = "AdaugaNotiteToolStripMenuItem"
        AdaugaNotiteToolStripMenuItem.Size = New Size(180, 22)
        AdaugaNotiteToolStripMenuItem.Text = "Adauga notite"' 
        ' EditeazaNotitaSelectataToolStripMenuItem
        ' 
        EditeazaNotitaSelectataToolStripMenuItem.Name = "EditeazaNotitaSelectataToolStripMenuItem"
        EditeazaNotitaSelectataToolStripMenuItem.Size = New Size(180, 22)
        EditeazaNotitaSelectataToolStripMenuItem.Text = "Editeaza continut"' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 40)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(249, 244)
        ListBox1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(273, 298)
        Controls.Add(ListBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NotiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdaugaNotiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents EditeazaNotitaSelectataToolStripMenuItem As ToolStripMenuItem
End Class
