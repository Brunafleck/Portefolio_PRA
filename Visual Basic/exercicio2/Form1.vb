Imports System.Globalization
Imports Microsoft.Data
Imports Microsoft.Data.SqlClient
Public Class Form1
    Dim ligacao As New SqlConnection
    Dim comando As New SqlCommand
    Private Sub lstTitulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTitulo.SelectedIndexChanged
        lstAutor.SelectedIndex = lstTitulo.SelectedIndex
        lstAno.SelectedIndex = lstTitulo.SelectedIndex
    End Sub

    Private Sub lstAutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAutor.SelectedIndexChanged
        lstTitulo.SelectedIndex = lstAutor.SelectedIndex
        lstAno.SelectedIndex = lstAutor.SelectedIndex
    End Sub

    Private Sub lstAno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAno.SelectedIndexChanged
        lstTitulo.SelectedIndex = lstAno.SelectedIndex
        lstAutor.SelectedIndex = lstAno.SelectedIndex
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If (txtTitulo.TextLength = 0 And txtAutor.TextLength = 0 And txtAno.TextLength = 0) Then
            MsgBox("Todos os campos são obrigatórios",
                   MsgBoxStyle.DefaultButton1, "Erro")
            txtTitulo.Focus()
            Exit Sub
        End If

        ' Adicionar dados à lista
        lstTitulo.Items.Add(txtTitulo.Text)
        lstAutor.Items.Add(txtAutor.Text)
        lstAno.Items.Add(txtAno.Text)

        ' Limpar os campos
        txtTitulo.ResetText()
        txtAutor.ResetText()
        txtAno.ResetText()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtTitulo.ResetText()
        txtAutor.ResetText()
        txtAno.ResetText()
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If (lstTitulo.SelectedIndex < 0) Then
            MsgBox("Deve selecionar um item",
                   MsgBoxStyle.DefaultButton1, "Atenção")
            Exit Sub
        End If

        Dim posicao As Integer
        posicao = lstTitulo.SelectedIndex ' Vai guardar o índice do nome que está selecionado na lista

        lstTitulo.Items.RemoveAt(posicao)
        lstAutor.Items.RemoveAt(posicao)
        lstAno.Items.RemoveAt(posicao)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ligacao.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bruna\Documents\bdlivros.mdf;Integrated Security=True;Connect Timeout=30" ' Caminho para a base de dados

        Try
            ligacao.Open()
            MsgBox("Ligado à base de dados")
        Catch ex As Exception
            MsgBox("Erro ao abrir a base de dados")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim sql As String
            Dim posicao As Integer
            For posicao = 0 To lstTitulo.Items.Count - 1
                sql = "insert into Livro (titulo, autor, ano) values (@ti, @au, @an)"
                comando = New SqlCommand(sql, ligacao) ' Para atribuir valores às variáveis
                comando.Parameters.AddWithValue("@ti", lstTitulo.Items(posicao))
                comando.Parameters.AddWithValue("@au", lstAutor.Items(posicao))
                comando.Parameters.AddWithValue("@an", lstAno.Items(posicao))
                comando.ExecuteNonQuery()
            Next
            ' Guardar na base de dados
            ' Para limpar a tela depois de finalizar
            MsgBox("Registo do pedido efetuado", MsgBoxStyle.Information, "POS")
        Catch ex As Exception
            MsgBox("Erro ao efetuar pedido" + ex.Message, MsgBoxStyle.Critical, "POS") ' O ex.Message mostra qual é o erro
        End Try
    End Sub
End Class
