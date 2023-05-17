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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Réseaux = New ListBox()
        Button1 = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Réseaux
        ' 
        Réseaux.FormattingEnabled = True
        Réseaux.ItemHeight = 20
        Réseaux.Location = New Point(12, 12)
        Réseaux.Name = "Réseaux"
        Réseaux.Size = New Size(523, 204)
        Réseaux.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(504, 303)
        Button1.Name = "Button1"
        Button1.Size = New Size(204, 80)
        Button1.TabIndex = 7
        Button1.Text = "Test psexec"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(541, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 20)
        Label6.TabIndex = 8
        Label6.Text = "Tout ping"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(Réseaux)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Formulaire extinction PC"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Réseaux As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
End Class
