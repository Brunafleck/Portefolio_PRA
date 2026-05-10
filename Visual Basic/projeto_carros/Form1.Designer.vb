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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dados = New GroupBox()
        texto_matricula = New MaskedTextBox()
        botao_limpar = New Button()
        botao_adicionar = New Button()
        Label4 = New Label()
        Label3 = New Label()
        texto_modelo = New TextBox()
        Label2 = New Label()
        texto_marca = New TextBox()
        Label1 = New Label()
        Listas = New GroupBox()
        lista_kms = New ListBox()
        Label8 = New Label()
        lista_matricula = New ListBox()
        lista_modelo = New ListBox()
        Label7 = New Label()
        lista_marca = New ListBox()
        Label6 = New Label()
        Label5 = New Label()
        botao_imprimir = New Button()
        botao_alterar = New Button()
        botao_apagar = New Button()
        botao_sair = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        texto_kms = New MaskedTextBox()
        Dados.SuspendLayout()
        Listas.SuspendLayout()
        SuspendLayout()
        ' 
        ' Dados
        ' 
        Dados.Controls.Add(texto_kms)
        Dados.Controls.Add(texto_matricula)
        Dados.Controls.Add(botao_limpar)
        Dados.Controls.Add(botao_adicionar)
        Dados.Controls.Add(Label4)
        Dados.Controls.Add(Label3)
        Dados.Controls.Add(texto_modelo)
        Dados.Controls.Add(Label2)
        Dados.Controls.Add(texto_marca)
        Dados.Controls.Add(Label1)
        Dados.Location = New Point(12, 12)
        Dados.Name = "Dados"
        Dados.Size = New Size(265, 491)
        Dados.TabIndex = 0
        Dados.TabStop = False
        Dados.Text = "Dados"
        ' 
        ' texto_matricula
        ' 
        texto_matricula.Location = New Point(6, 246)
        texto_matricula.Name = "texto_matricula"
        texto_matricula.Size = New Size(150, 31)
        texto_matricula.TabIndex = 11
        ' 
        ' botao_limpar
        ' 
        botao_limpar.Location = New Point(6, 436)
        botao_limpar.Name = "botao_limpar"
        botao_limpar.Size = New Size(250, 34)
        botao_limpar.TabIndex = 10
        botao_limpar.Text = "Limpar"
        botao_limpar.UseVisualStyleBackColor = True
        ' 
        ' botao_adicionar
        ' 
        botao_adicionar.Location = New Point(6, 387)
        botao_adicionar.Name = "botao_adicionar"
        botao_adicionar.Size = New Size(250, 34)
        botao_adicionar.TabIndex = 9
        botao_adicionar.Text = "Adicionar"
        botao_adicionar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(0, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 25)
        Label4.TabIndex = 7
        Label4.Text = "KMS atuais"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 25)
        Label3.TabIndex = 4
        Label3.Text = "Matrícula"
        ' 
        ' texto_modelo
        ' 
        texto_modelo.Location = New Point(6, 161)
        texto_modelo.Name = "texto_modelo"
        texto_modelo.Size = New Size(250, 31)
        texto_modelo.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 25)
        Label2.TabIndex = 2
        Label2.Text = "Modelo"
        ' 
        ' texto_marca
        ' 
        texto_marca.Location = New Point(6, 79)
        texto_marca.Name = "texto_marca"
        texto_marca.Size = New Size(250, 31)
        texto_marca.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 25)
        Label1.TabIndex = 0
        Label1.Text = "Marca"
        ' 
        ' Listas
        ' 
        Listas.Controls.Add(lista_kms)
        Listas.Controls.Add(Label8)
        Listas.Controls.Add(lista_matricula)
        Listas.Controls.Add(lista_modelo)
        Listas.Controls.Add(Label7)
        Listas.Controls.Add(lista_marca)
        Listas.Controls.Add(Label6)
        Listas.Controls.Add(Label5)
        Listas.Location = New Point(292, 12)
        Listas.Name = "Listas"
        Listas.Size = New Size(748, 491)
        Listas.TabIndex = 9
        Listas.TabStop = False
        Listas.Text = "Listas"
        ' 
        ' lista_kms
        ' 
        lista_kms.FormattingEnabled = True
        lista_kms.Location = New Point(590, 79)
        lista_kms.Name = "lista_kms"
        lista_kms.Size = New Size(138, 404)
        lista_kms.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(590, 40)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 25)
        Label8.TabIndex = 11
        Label8.Text = "KMS atuais"
        ' 
        ' lista_matricula
        ' 
        lista_matricula.FormattingEnabled = True
        lista_matricula.Location = New Point(394, 79)
        lista_matricula.Name = "lista_matricula"
        lista_matricula.Size = New Size(180, 404)
        lista_matricula.TabIndex = 14
        ' 
        ' lista_modelo
        ' 
        lista_modelo.FormattingEnabled = True
        lista_modelo.Location = New Point(202, 79)
        lista_modelo.Name = "lista_modelo"
        lista_modelo.Size = New Size(180, 404)
        lista_modelo.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(394, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 25)
        Label7.TabIndex = 11
        Label7.Text = "Matrícula"
        ' 
        ' lista_marca
        ' 
        lista_marca.FormattingEnabled = True
        lista_marca.Location = New Point(6, 79)
        lista_marca.Name = "lista_marca"
        lista_marca.Size = New Size(180, 404)
        lista_marca.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(202, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 25)
        Label6.TabIndex = 11
        Label6.Text = "Modelo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 25)
        Label5.TabIndex = 11
        Label5.Text = "Marca"
        ' 
        ' botao_imprimir
        ' 
        botao_imprimir.Location = New Point(381, 519)
        botao_imprimir.Name = "botao_imprimir"
        botao_imprimir.Size = New Size(143, 34)
        botao_imprimir.TabIndex = 11
        botao_imprimir.Text = "Imprimir"
        botao_imprimir.UseVisualStyleBackColor = True
        ' 
        ' botao_alterar
        ' 
        botao_alterar.Location = New Point(540, 519)
        botao_alterar.Name = "botao_alterar"
        botao_alterar.Size = New Size(143, 34)
        botao_alterar.TabIndex = 12
        botao_alterar.Text = "Alterar"
        botao_alterar.UseVisualStyleBackColor = True
        ' 
        ' botao_apagar
        ' 
        botao_apagar.Location = New Point(698, 519)
        botao_apagar.Name = "botao_apagar"
        botao_apagar.Size = New Size(143, 34)
        botao_apagar.TabIndex = 13
        botao_apagar.Text = "Apagar"
        botao_apagar.UseVisualStyleBackColor = True
        ' 
        ' botao_sair
        ' 
        botao_sair.Location = New Point(897, 519)
        botao_sair.Name = "botao_sair"
        botao_sair.Size = New Size(143, 34)
        botao_sair.TabIndex = 14
        botao_sair.Text = "Sair"
        botao_sair.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        PrintDocument1.DocumentName = "a"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' texto_kms
        ' 
        texto_kms.Location = New Point(6, 332)
        texto_kms.Mask = "999999999"
        texto_kms.Name = "texto_kms"
        texto_kms.Size = New Size(150, 31)
        texto_kms.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 565)
        Controls.Add(botao_sair)
        Controls.Add(botao_apagar)
        Controls.Add(botao_alterar)
        Controls.Add(botao_imprimir)
        Controls.Add(Listas)
        Controls.Add(Dados)
        Name = "Form1"
        Text = "Form1"
        Dados.ResumeLayout(False)
        Dados.PerformLayout()
        Listas.ResumeLayout(False)
        Listas.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Dados As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents texto_modelo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents texto_marca As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents botao_limpar As Button
    Friend WithEvents botao_adicionar As Button
    Friend WithEvents Listas As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lista_kms As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lista_matricula As ListBox
    Friend WithEvents lista_modelo As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lista_marca As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents botao_imprimir As Button
    Friend WithEvents botao_alterar As Button
    Friend WithEvents botao_apagar As Button
    Friend WithEvents botao_sair As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents texto_matricula As MaskedTextBox
    Friend WithEvents texto_kms As MaskedTextBox

End Class
