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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txt_login = New TextBox()
        txt_pw = New TextBox()
        btn_valider = New Button()
        bnt_annuler = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txt_login
        ' 
        txt_login.Location = New Point(447, 165)
        txt_login.Multiline = True
        txt_login.Name = "txt_login"
        txt_login.PlaceholderText = " "
        txt_login.Size = New Size(302, 51)
        txt_login.TabIndex = 2
        ' 
        ' txt_pw
        ' 
        txt_pw.Location = New Point(447, 272)
        txt_pw.Multiline = True
        txt_pw.Name = "txt_pw"
        txt_pw.PasswordChar = "*"c
        txt_pw.PlaceholderText = " "
        txt_pw.Size = New Size(302, 53)
        txt_pw.TabIndex = 3
        ' 
        ' btn_valider
        ' 
        btn_valider.BackgroundImageLayout = ImageLayout.Center
        btn_valider.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_valider.Location = New Point(374, 414)
        btn_valider.Name = "btn_valider"
        btn_valider.Size = New Size(151, 46)
        btn_valider.TabIndex = 4
        btn_valider.Text = "valider"
        btn_valider.UseVisualStyleBackColor = True
        ' 
        ' bnt_annuler
        ' 
        bnt_annuler.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        bnt_annuler.Location = New Point(543, 414)
        bnt_annuler.Name = "bnt_annuler"
        bnt_annuler.Size = New Size(152, 46)
        bnt_annuler.TabIndex = 5
        bnt_annuler.Text = "annuler"
        bnt_annuler.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.MenuText
        Label1.Location = New Point(308, 290)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(244, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 25)
        Label2.TabIndex = 7
        Label2.Text = "Nom d'utilisateur :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(244, 290)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 25)
        Label3.TabIndex = 8
        Label3.Text = "mot de passe :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(782, 603)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(bnt_annuler)
        Controls.Add(btn_valider)
        Controls.Add(txt_pw)
        Controls.Add(txt_login)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_pw As TextBox
    Friend WithEvents btn_valider As Button
    Friend WithEvents bnt_annuler As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
