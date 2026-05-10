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
        txtTitulo = New TextBox()
        Label2 = New Label()
        txtAutor = New TextBox()
        Label3 = New Label()
        lstTitulo = New ListBox()
        lstAutor = New ListBox()
        lstAno = New ListBox()
        btnAdicionar = New Button()
        btnRemover = New Button()
        btnLimpar = New Button()
        btnGuardar = New Button()
        txtAno = New MaskedTextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 25)
        Label1.TabIndex = 0
        Label1.Text = "Título"
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(104, 49)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(287, 31)
        txtTitulo.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 25)
        Label2.TabIndex = 2
        Label2.Text = "Autor"
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(104, 110)
        txtAutor.Name = "txtAutor"
        txtAutor.Size = New Size(287, 31)
        txtAutor.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 25)
        Label3.TabIndex = 4
        Label3.Text = "Ano"
        ' 
        ' lstTitulo
        ' 
        lstTitulo.FormattingEnabled = True
        lstTitulo.Location = New Point(415, 22)
        lstTitulo.Name = "lstTitulo"
        lstTitulo.Size = New Size(180, 354)
        lstTitulo.TabIndex = 6
        ' 
        ' lstAutor
        ' 
        lstAutor.FormattingEnabled = True
        lstAutor.Location = New Point(608, 22)
        lstAutor.Name = "lstAutor"
        lstAutor.Size = New Size(180, 354)
        lstAutor.TabIndex = 7
        ' 
        ' lstAno
        ' 
        lstAno.FormattingEnabled = True
        lstAno.Location = New Point(803, 22)
        lstAno.Name = "lstAno"
        lstAno.Size = New Size(180, 354)
        lstAno.TabIndex = 8
        ' 
        ' btnAdicionar
        ' 
        btnAdicionar.Location = New Point(26, 269)
        btnAdicionar.Name = "btnAdicionar"
        btnAdicionar.Size = New Size(112, 34)
        btnAdicionar.TabIndex = 9
        btnAdicionar.Text = "Adicionar"
        btnAdicionar.UseVisualStyleBackColor = True
        ' 
        ' btnRemover
        ' 
        btnRemover.Location = New Point(154, 269)
        btnRemover.Name = "btnRemover"
        btnRemover.Size = New Size(112, 34)
        btnRemover.TabIndex = 10
        btnRemover.Text = "Remover"
        btnRemover.UseVisualStyleBackColor = True
        ' 
        ' btnLimpar
        ' 
        btnLimpar.Location = New Point(279, 269)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(112, 34)
        btnLimpar.TabIndex = 11
        btnLimpar.Text = "Limpar"
        btnLimpar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(62, 326)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(288, 34)
        btnGuardar.TabIndex = 12
        btnGuardar.Text = "Guardar na base de dados"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' txtAno
        ' 
        txtAno.Location = New Point(104, 175)
        txtAno.Mask = "0000"
        txtAno.Name = "txtAno"
        txtAno.Size = New Size(118, 31)
        txtAno.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1037, 450)
        Controls.Add(txtAno)
        Controls.Add(btnGuardar)
        Controls.Add(btnLimpar)
        Controls.Add(btnRemover)
        Controls.Add(btnAdicionar)
        Controls.Add(lstAno)
        Controls.Add(lstAutor)
        Controls.Add(lstTitulo)
        Controls.Add(Label3)
        Controls.Add(txtAutor)
        Controls.Add(Label2)
        Controls.Add(txtTitulo)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Livros"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstTitulo As ListBox
    Friend WithEvents lstAutor As ListBox
    Friend WithEvents lstAno As ListBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtAno As MaskedTextBox

End Class
