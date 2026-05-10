Imports System.Text.RegularExpressions
Imports System.DirectoryServices.ActiveDirectory

Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles texto_kms.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista_modelo.SelectedIndexChanged
        lista_marca.SelectedIndex = lista_modelo.SelectedIndex
        lista_matricula.SelectedIndex = lista_modelo.SelectedIndex
        lista_kms.SelectedIndex = lista_modelo.SelectedIndex
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botao_sair.Click
        End
    End Sub

    Private Sub botao_adicionar_Click(sender As Object, e As EventArgs) Handles botao_adicionar.Click
        If (texto_marca.TextLength = 0 And texto_modelo.TextLength = 0 And texto_matricula.TextLength = 0 And texto_kms.TextLength = 0) Then
            MsgBox("Marca, modelo, matrícula e kms atuais são obrigatórios",
                   MsgBoxStyle.DefaultButton1, "Erro")
            texto_marca.Focus()
            Exit Sub
        End If

        ' Validar matricula
        Dim validar_matricula As New Regex("^[A-Z0-9]{2}-[A-Z0-9]{2}-[A-Z0-9]{2}$")
        If Not validar_matricula.IsMatch(texto_matricula.Text) Then
            MsgBox("Matrícula inválida",
            MsgBoxStyle.DefaultButton1, "Erro")
            texto_matricula.Focus()
            Exit Sub
        End If

        If (botao_adicionar.Text = "Adicionar") Then
            ' Adicionar dados à lista
            lista_marca.Items.Add(texto_marca.Text)
            lista_modelo.Items.Add(texto_modelo.Text)
            lista_matricula.Items.Add(texto_matricula.Text)
            lista_kms.Items.Add(texto_kms.Text)
        Else
            lista_marca.Items(lista_marca.SelectedIndex) = texto_marca.Text
            lista_modelo.Items(lista_modelo.SelectedIndex) = texto_modelo.Text
            lista_matricula.Items(lista_matricula.SelectedIndex) = texto_matricula.Text
            lista_kms.Items(lista_kms.SelectedIndex) = texto_kms.Text

            botao_adicionar.Text = "Adicionar"
        End If

        ' Limpar os campos
        texto_marca.ResetText()
        texto_modelo.ResetText()
        texto_matricula.ResetText()
        texto_kms.ResetText()
    End Sub

    Private Sub botao_limpar_Click(sender As Object, e As EventArgs) Handles botao_limpar.Click
        ' Limpar os campos
        texto_marca.ResetText()
        texto_modelo.ResetText()
        texto_matricula.ResetText()
        texto_kms.ResetText()
    End Sub

    Private Sub botao_alterar_Click(sender As Object, e As EventArgs) Handles botao_alterar.Click
        If (lista_marca.SelectedIndex < 0) Then
            MsgBox("Deve selecionar um item",
                   MsgBoxStyle.Critical, "Atenção")
            Exit Sub
        End If

        texto_marca.Text = lista_marca.GetItemText(lista_marca.SelectedItem)
        texto_modelo.Text = lista_modelo.GetItemText(lista_modelo.SelectedItem)
        texto_matricula.Text = lista_matricula.GetItemText(lista_matricula.SelectedItem)
        texto_kms.Text = lista_kms.GetItemText(lista_kms.SelectedItem)

        botao_adicionar.Text = "Atualizar"
    End Sub

    Private Sub botao_apagar_Click(sender As Object, e As EventArgs) Handles botao_apagar.Click
        If (lista_marca.SelectedIndex < 0) Then
            MsgBox("Deve selecionar um item",
                   MsgBoxStyle.DefaultButton1, "Atenção")
            Exit Sub
        End If

        Dim posicao As Integer
        posicao = lista_marca.SelectedIndex ' Vai guardar o índice do nome que está selecionado na lista

        lista_marca.Items.RemoveAt(posicao)
        lista_modelo.Items.RemoveAt(posicao)
        lista_matricula.Items.RemoveAt(posicao)
        lista_kms.Items.RemoveAt(posicao)
    End Sub

    Private Sub texto_matricula_TextChanged(sender As Object, e As EventArgs) Handles texto_matricula.TextChanged

    End Sub

    Private Sub texto_marca_TextChanged(sender As Object, e As EventArgs) Handles texto_marca.TextChanged

    End Sub

    Private Sub Dados_Enter(sender As Object, e As EventArgs) Handles Dados.Enter

    End Sub

    Private Sub lista_marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista_marca.SelectedIndexChanged
        lista_modelo.SelectedIndex = lista_marca.SelectedIndex
        lista_matricula.SelectedIndex = lista_marca.SelectedIndex
        lista_kms.SelectedIndex = lista_marca.SelectedIndex
    End Sub

    Private Sub lista_matricula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista_matricula.SelectedIndexChanged
        lista_marca.SelectedIndex = lista_matricula.SelectedIndex
        lista_modelo.SelectedIndex = lista_matricula.SelectedIndex
        lista_kms.SelectedIndex = lista_matricula.SelectedIndex
    End Sub

    Private Sub lista_kms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista_kms.SelectedIndexChanged
        lista_marca.SelectedIndex = lista_kms.SelectedIndex
        lista_modelo.SelectedIndex = lista_kms.SelectedIndex
        lista_matricula.SelectedIndex = lista_kms.SelectedIndex
    End Sub

    Private Sub botao_imprimir_Click(sender As Object, e As EventArgs) Handles botao_imprimir.Click
        If (lista_marca.Items.Count = 0) Then
            MsgBox("A lista está vazia", MsgBoxStyle.Critical, "Atenção")
            Exit Sub
        End If

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f1 = New Font("Arial", 14, FontStyle.Bold)
        Dim f2 = New Font("Arial", 10, FontStyle.Regular)

        e.Graphics.DrawString("Carros", f1, Brushes.Blue, 50, 50)
        e.Graphics.DrawString("Marca", f2, Brushes.Black, 50, 100)
        e.Graphics.DrawString("Modelo", f2, Brushes.Black, 250, 100)
        e.Graphics.DrawString("Matrícula", f2, Brushes.Black, 450, 100)
        e.Graphics.DrawString("KMS atuais", f2, Brushes.Black, 650, 100)

        e.Graphics.DrawLine(New Pen(Brushes.Blue), 50, 120, 750, 120)

        Dim linha As Integer = 130
        For i As Integer = 0 To lista_marca.Items.Count - 1
            e.Graphics.DrawString(lista_marca.Items(i), f2, Brushes.Black, 50, linha)
            e.Graphics.DrawString(lista_modelo.Items(i), f2, Brushes.Black, 250, linha)
            e.Graphics.DrawString(lista_matricula.Items(i), f2, Brushes.Black, 450, linha)
            e.Graphics.DrawString(lista_kms.Items(i), f2, Brushes.Black, 650, linha)

            linha += 20
        Next
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class
