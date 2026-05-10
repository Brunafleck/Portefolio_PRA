<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNome = New TextBox()
        txtGenero = New TextBox()
        txtData = New TextBox()
        txtNacionalidade = New TextBox()
        txtCategoria = New TextBox()
        btnNovo = New Button()
        btnGuardar = New Button()
        btnCancelar = New Button()
        btnSair = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(68, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nome"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(68, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 25)
        Label2.TabIndex = 1
        Label2.Text = "Gênero"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(501, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 25)
        Label3.TabIndex = 2
        Label3.Text = "Nacionalidade"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 25)
        Label4.TabIndex = 3
        Label4.Text = "Data Nascimento"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(501, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 25)
        Label5.TabIndex = 4
        Label5.Text = "Categoria"
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(151, 46)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(497, 31)
        txtNome.TabIndex = 5
        ' 
        ' txtGenero
        ' 
        txtGenero.Location = New Point(160, 124)
        txtGenero.Name = "txtGenero"
        txtGenero.Size = New Size(237, 31)
        txtGenero.TabIndex = 6
        ' 
        ' txtData
        ' 
        txtData.Location = New Point(239, 198)
        txtData.Name = "txtData"
        txtData.Size = New Size(237, 31)
        txtData.TabIndex = 7
        ' 
        ' txtNacionalidade
        ' 
        txtNacionalidade.Location = New Point(650, 124)
        txtNacionalidade.Name = "txtNacionalidade"
        txtNacionalidade.Size = New Size(237, 31)
        txtNacionalidade.TabIndex = 8
        ' 
        ' txtCategoria
        ' 
        txtCategoria.Location = New Point(615, 201)
        txtCategoria.Name = "txtCategoria"
        txtCategoria.Size = New Size(237, 31)
        txtCategoria.TabIndex = 9
        ' 
        ' btnNovo
        ' 
        btnNovo.Location = New Point(68, 330)
        btnNovo.Name = "btnNovo"
        btnNovo.Size = New Size(126, 79)
        btnNovo.TabIndex = 10
        btnNovo.Text = "Novo"
        btnNovo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(225, 330)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(126, 79)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(383, 330)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(126, 79)
        btnCancelar.TabIndex = 12
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnSair
        ' 
        btnSair.Location = New Point(761, 330)
        btnSair.Name = "btnSair"
        btnSair.Size = New Size(126, 79)
        btnSair.TabIndex = 13
        btnSair.Text = "Sair"
        btnSair.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(911, 430)
        Controls.Add(btnSair)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNovo)
        Controls.Add(txtCategoria)
        Controls.Add(txtNacionalidade)
        Controls.Add(txtData)
        Controls.Add(txtGenero)
        Controls.Add(txtNome)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents txtNacionalidade As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSair As Button

End Class
