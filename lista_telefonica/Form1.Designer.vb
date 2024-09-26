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
        lbl1 = New Label()
        lbl_nome = New Label()
        txt_nome = New TextBox()
        lbl_telefone = New Label()
        txt_telefone = New TextBox()
        lbl_email = New Label()
        email_txt = New TextBox()
        endereco_lbl = New Label()
        txt_endereco = New TextBox()
        enviar_btn = New Button()
        sair_btn = New Button()
        editar_btn = New Button()
        SuspendLayout()
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl1.Location = New Point(355, 57)
        lbl1.Margin = New Padding(5, 0, 5, 0)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(396, 38)
        lbl1.TabIndex = 0
        lbl1.Text = "AGENDA TELEFÔNICA"
        ' 
        ' lbl_nome
        ' 
        lbl_nome.AutoSize = True
        lbl_nome.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_nome.Location = New Point(145, 176)
        lbl_nome.Margin = New Padding(5, 0, 5, 0)
        lbl_nome.Name = "lbl_nome"
        lbl_nome.Size = New Size(79, 26)
        lbl_nome.TabIndex = 1
        lbl_nome.Text = "Nome:"
        ' 
        ' txt_nome
        ' 
        txt_nome.Font = New Font("Times New Roman", 14F)
        txt_nome.Location = New Point(272, 173)
        txt_nome.Margin = New Padding(5, 4, 5, 4)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(568, 34)
        txt_nome.TabIndex = 2
        ' 
        ' lbl_telefone
        ' 
        lbl_telefone.AutoSize = True
        lbl_telefone.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        lbl_telefone.Location = New Point(145, 221)
        lbl_telefone.Margin = New Padding(5, 0, 5, 0)
        lbl_telefone.Name = "lbl_telefone"
        lbl_telefone.Size = New Size(105, 26)
        lbl_telefone.TabIndex = 3
        lbl_telefone.Text = "Telefone:"
        ' 
        ' txt_telefone
        ' 
        txt_telefone.Font = New Font("Times New Roman", 14F)
        txt_telefone.Location = New Point(272, 218)
        txt_telefone.Margin = New Padding(5, 4, 5, 4)
        txt_telefone.Name = "txt_telefone"
        txt_telefone.Size = New Size(568, 34)
        txt_telefone.TabIndex = 4
        ' 
        ' lbl_email
        ' 
        lbl_email.AutoSize = True
        lbl_email.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        lbl_email.Location = New Point(145, 269)
        lbl_email.Margin = New Padding(5, 0, 5, 0)
        lbl_email.Name = "lbl_email"
        lbl_email.Size = New Size(81, 26)
        lbl_email.TabIndex = 5
        lbl_email.Text = "Email:"
        ' 
        ' email_txt
        ' 
        email_txt.Font = New Font("Times New Roman", 14F)
        email_txt.Location = New Point(272, 266)
        email_txt.Margin = New Padding(5, 4, 5, 4)
        email_txt.Name = "email_txt"
        email_txt.Size = New Size(568, 34)
        email_txt.TabIndex = 6
        ' 
        ' endereco_lbl
        ' 
        endereco_lbl.AutoSize = True
        endereco_lbl.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        endereco_lbl.Location = New Point(145, 313)
        endereco_lbl.Margin = New Padding(5, 0, 5, 0)
        endereco_lbl.Name = "endereco_lbl"
        endereco_lbl.Size = New Size(118, 26)
        endereco_lbl.TabIndex = 7
        endereco_lbl.Text = "Endereço:"
        ' 
        ' txt_endereco
        ' 
        txt_endereco.Location = New Point(272, 313)
        txt_endereco.Margin = New Padding(5, 4, 5, 4)
        txt_endereco.Name = "txt_endereco"
        txt_endereco.Size = New Size(568, 34)
        txt_endereco.TabIndex = 8
        ' 
        ' enviar_btn
        ' 
        enviar_btn.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        enviar_btn.Location = New Point(484, 377)
        enviar_btn.Name = "enviar_btn"
        enviar_btn.Size = New Size(128, 42)
        enviar_btn.TabIndex = 9
        enviar_btn.Text = "Enviar"
        enviar_btn.UseVisualStyleBackColor = True
        ' 
        ' sair_btn
        ' 
        sair_btn.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        sair_btn.Location = New Point(965, 516)
        sair_btn.Name = "sair_btn"
        sair_btn.Size = New Size(103, 38)
        sair_btn.TabIndex = 10
        sair_btn.Text = "Sair"
        sair_btn.UseVisualStyleBackColor = True
        ' 
        ' editar_btn
        ' 
        editar_btn.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editar_btn.Location = New Point(965, 456)
        editar_btn.Name = "editar_btn"
        editar_btn.Size = New Size(103, 38)
        editar_btn.TabIndex = 11
        editar_btn.Text = "Editar"
        editar_btn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1271, 719)
        Controls.Add(editar_btn)
        Controls.Add(sair_btn)
        Controls.Add(enviar_btn)
        Controls.Add(txt_endereco)
        Controls.Add(endereco_lbl)
        Controls.Add(email_txt)
        Controls.Add(lbl_email)
        Controls.Add(txt_telefone)
        Controls.Add(lbl_telefone)
        Controls.Add(txt_nome)
        Controls.Add(lbl_nome)
        Controls.Add(lbl1)
        Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agenda Telefônica"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents email_txt As TextBox
    Friend WithEvents endereco_lbl As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents enviar_btn As Button
    Friend WithEvents sair_btn As Button
    Friend WithEvents editar_btn As Button

End Class
