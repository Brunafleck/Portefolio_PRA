Imports System.Globalization
Imports System.Data
Imports System.Data.SqlClient
Public Class frmPrincipal
    Dim Total As Double
    Dim ligacao As New SqlConnection
    Dim comando As New SqlCommand
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ligacao.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bruna\Desktop\POS_OK_SQL\POS_OK_SQL\POS\bin\Debug\bdrestaurante.mdf;Integrated Security=True;Connect Timeout=30" ' Caminho para a base de dados

        Try
            ligacao.Open()
            MsgBox("Ligado à base de dados")
        Catch ex As Exception
            MsgBox("Erro ao abrir a base de dados")
        End Try

        Inicializa()

    End Sub
    Sub AdicionaProduto(Pic As PictureBox, Nome As String, Preco As Double)
        Dim Posicao, Qtd As Integer
        Dim PrecoAtual As Double

        Posicao = lstitens.FindString(Nome)

        If (Posicao >= 0) Then
            lstitens.SetSelected(Posicao, True)
            Qtd = lstQnt.Items.Item(Posicao) + 1
            PrecoAtual = Qtd * Preco
            lstQnt.Items.Item(Posicao) = Qtd
            lstPrecos.Items.Item(Posicao) = FormatCurrency(PrecoAtual)
            Total += Preco
            lblTotal.Text = FormatCurrency(Total)
        Else
            lstitens.Items.Add(Nome)
            lstQnt.Items.Add(1)
            lstUnitario.Items.Add(FormatCurrency(Preco))
            lstPrecos.Items.Add(FormatCurrency(Preco))
            Total += Preco
            lblTotal.Text = FormatCurrency(Total)
            picViewItem.Image = Pic.Image
        End If

        If lstitens.Items.Count > 0 Then
            btn_MaisUm.Enabled = True
            btn_MenosUm.Enabled = True
            btn_ArtigoEspecifico.Enabled = True
            btn_Pagamento.Enabled = True
            btn_Remover.Enabled = True
        End If
    End Sub

    Sub Inicializa()
        gb_cafetaria.Enabled = False
        gb_Pastelaria.Enabled = False
        gb_Bebidas.Enabled = False
        btn_Pagamento.Enabled = False
        btn_ArtigoEspecifico.Enabled = False
        btn_MaisUm.Enabled = False
        btn_MenosUm.Enabled = False
        btn_Imprimir.Enabled = False
        btn_Remover.Enabled = False
        btn_Novo.Text = "Novo"
        btn_Novo.ForeColor = Color.LightBlue
        ' Para apagar a informação da lista se clicar no botão cancelar
        picViewItem.Image = Nothing
        Total = 0
        lblTotal.ResetText()
        lstitens.Items.Clear()
        lstQnt.Items.Clear()
        lstPrecos.Items.Clear()
        lstUnitario.Items.Clear()
        lblVenda.ResetText()
        lblNumerario.ResetText()
        lblTroco.ResetText()

    End Sub

    Private Sub btn_Novo_Click(sender As Object, e As EventArgs) Handles btn_Novo.Click
        If btn_Novo.Text = "Novo" Then
            btn_Novo.Text = "Cancelar"
            btn_Novo.ForeColor = Color.Green
            lblVenda.Text = "Venda número" & DateTime.Now.ToString("yyyy-MM-dd.hhmmss")
            gb_cafetaria.Enabled = True
            gb_Pastelaria.Enabled = True
            gb_Bebidas.Enabled = True
        Else
            Inicializa()
        End If
    End Sub

    Private Sub picLeite_Click(sender As Object, e As EventArgs) Handles picLeite.Click
        AdicionaProduto(picLeite, "Café com leite", 0.7)
    End Sub

    Private Sub picCafe_Click(sender As Object, e As EventArgs) Handles picCafe.Click
        AdicionaProduto(picCafe, "Café", 0.6)
    End Sub

    Private Sub picTres_Click(sender As Object, e As EventArgs) Handles picTres.Click
        AdicionaProduto(picTres, "Descafeinado", 0.6)
    End Sub

    Private Sub picQuatro_Click(sender As Object, e As EventArgs) Handles picQuatro.Click
        AdicionaProduto(picQuatro, "Café com leite grande", 0.8)
    End Sub

    Private Sub picCinco_Click(sender As Object, e As EventArgs) Handles picCinco.Click
        AdicionaProduto(picCinco, "Café com chocolate", 0.55)
    End Sub

    Private Sub picSeis_Click(sender As Object, e As EventArgs) Handles picSeis.Click
        AdicionaProduto(picSeis, "Café com leite pequeno", 0.65)
    End Sub

    Private Sub picSete_Click(sender As Object, e As EventArgs) Handles picSete.Click
        AdicionaProduto(picSete, "Doces", 1.1)
    End Sub

    Private Sub picOito_Click(sender As Object, e As EventArgs) Handles picOito.Click
        AdicionaProduto(picOito, "Salgados", 1.1)
    End Sub

    Private Sub picNove_Click(sender As Object, e As EventArgs) Handles picNove.Click
        AdicionaProduto(picNove, "Sanduíche", 1.3)
    End Sub

    Private Sub picDez_Click(sender As Object, e As EventArgs) Handles picDez.Click
        AdicionaProduto(picDez, "Torrada", 1.0)
    End Sub

    Private Sub picOnze_Click(sender As Object, e As EventArgs) Handles picOnze.Click
        AdicionaProduto(picOnze, "Torrada de presunto e queijo", 2.0)
    End Sub

    Private Sub picAgua_Click(sender As Object, e As EventArgs) Handles picAgua.Click
        AdicionaProduto(picAgua, "Água", 1.0)
    End Sub

    Private Sub picCatorze_Click(sender As Object, e As EventArgs) Handles picCatorze.Click
        AdicionaProduto(picCatorze, "Bebida", 1.4)
    End Sub

    Private Sub picQuinze_Click(sender As Object, e As EventArgs) Handles picQuinze.Click
        AdicionaProduto(picQuinze, "Suco", 0.95)
    End Sub

    Private Sub picDezasseis_Click(sender As Object, e As EventArgs) Handles picDezasseis.Click
        AdicionaProduto(picDezasseis, "Suco natural", 1.4)
    End Sub

    Private Sub lstitens_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstitens.SelectedIndexChanged
        lstQnt.SelectedIndex = lstitens.SelectedIndex
        lstPrecos.SelectedIndex = lstitens.SelectedIndex
        lstUnitario.SelectedIndex = lstitens.SelectedIndex
    End Sub

    Private Sub lstQnt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstQnt.SelectedIndexChanged
        lstitens.SelectedIndex = lstQnt.SelectedIndex
        lstPrecos.SelectedIndex = lstQnt.SelectedIndex
        lstUnitario.SelectedIndex = lstQnt.SelectedIndex
    End Sub

    Private Sub lstPrecos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrecos.SelectedIndexChanged
        lstitens.SelectedIndex = lstPrecos.SelectedIndex
        lstQnt.SelectedIndex = lstPrecos.SelectedIndex
        lstUnitario.SelectedIndex = lstPrecos.SelectedIndex
    End Sub

    Private Sub btn_MaisUm_Click(sender As Object, e As EventArgs) Handles btn_MaisUm.Click
        Dim posicao, qtd As Integer
        Dim precoUnitario As Double
        posicao = lstQnt.SelectedIndex

        If posicao <> -1 Then
            qtd = lstQnt.Items.Item(posicao) + 1
            precoUnitario = lstUnitario.Items.Item(posicao)
            lstQnt.Items.Item(posicao) = qtd
            lstPrecos.Items.Item(posicao) = FormatCurrency(qtd * precoUnitario)
            Total += precoUnitario
            lblTotal.Text = FormatCurrency(Total)

            If qtd = 0 Then
                lstitens.Items.RemoveAt(posicao)
                lstQnt.Items.RemoveAt(posicao)
                lstUnitario.Items.RemoveAt(posicao)
                lstPrecos.Items.RemoveAt(posicao)
            End If
        Else
            MsgBox("Não existem itens selecionados", MsgBoxStyle.Critical, "POS")
        End If
    End Sub

    Private Sub btn_MenosUm_Click(sender As Object, e As EventArgs) Handles btn_MenosUm.Click
        Dim posicao, qtd As Integer
        Dim precoUnitario As Double
        posicao = lstQnt.SelectedIndex

        If posicao <> -1 Then
            qtd = lstQnt.Items.Item(posicao) - 1
            precoUnitario = lstUnitario.Items.Item(posicao)
            lstQnt.Items.Item(posicao) = qtd
            lstPrecos.Items.Item(posicao) = FormatCurrency(qtd * precoUnitario)
            Total -= precoUnitario
            lblTotal.Text = FormatCurrency(Total) ' Para atualizar o valor

            If qtd = 0 Then
                lstitens.Items.RemoveAt(posicao)
                lstQnt.Items.RemoveAt(posicao)
                lstUnitario.Items.RemoveAt(posicao)
                lstPrecos.Items.RemoveAt(posicao)
            End If
        Else
            MsgBox("Não existem itens selecionados", MsgBoxStyle.Critical, "POS")
        End If
    End Sub

    Private Sub lstUnitario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUnitario.SelectedIndexChanged
        lstQnt.SelectedIndex = lstUnitario.SelectedIndex
        lstPrecos.SelectedIndex = lstUnitario.SelectedIndex
        lstitens.SelectedIndex = lstUnitario.SelectedIndex
    End Sub

    Private Sub btn_ArtigoEspecifico_Click(sender As Object, e As EventArgs) Handles btn_ArtigoEspecifico.Click
        frmArtigoEspecifico.ShowDialog() ' Para abrir o formulário do artigo específico
    End Sub

    Private Sub btn_Remover_Click(sender As Object, e As EventArgs) Handles btn_Remover.Click
        If lstitens.SelectedIndex < 0 Then
            MsgBox("Selecione um artigo", MsgBoxStyle.Critical, "POS")
            Exit Sub
        End If

        Dim posicao As Integer ' Para guardar a posição do item que será removido
        Dim preco As Double
        Dim resposta As String

        posicao = lstitens.SelectedIndex
        preco = lstPrecos.Items.Item(posicao)

        resposta = MsgBox("Confirmar a remoção dos artigos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question,
"Eliminar artigo")
        ' Para verificar se o usuário respondeu sim ou não
        If resposta = vbYes Then
            lstitens.Items.RemoveAt(posicao)
            lstPrecos.Items.RemoveAt(posicao)
            lstQnt.Items.RemoveAt(posicao)
            lstUnitario.Items.RemoveAt(posicao)
            Total -= preco
            lblTotal.Text = FormatCurrency(Total)
        End If

        ' Desativar os botões se não houverem itens na lista
        If lstitens.Items.Count = 0 Then
            picViewItem.Image = Nothing
            btn_Remover.Enabled = False
            btn_MaisUm.Enabled = False
            btn_MenosUm.Enabled = False
            btn_Pagamento.Enabled = False
        End If
    End Sub

    Private Sub btn_Pagamento_Click(sender As Object, e As EventArgs) Handles btn_Pagamento.Click
        Dim valor As Double = InputBox("Digite o valor pago")

        If valor < lblTotal.Text Then

            MsgBox("Valor inferior ao total da compra", MsgBoxStyle.Critical, "POS")
            Exit Sub
        End If

        lblNumerario.Text = FormatCurrency(valor)
        lblTroco.Text = FormatCurrency(valor - Total)

        btn_Imprimir.Enabled = True
        btn_Pagamento.Enabled = False
        btn_Remover.Enabled = False
        btn_MaisUm.Enabled = False
        btn_MenosUm.Enabled = False
        btn_ArtigoEspecifico.Enabled = False

        gb_cafetaria.Enabled = False
        gb_Pastelaria.Enabled = False
        gb_Bebidas.Enabled = False
    End Sub

    Private Sub btn_Imprimir_Click(sender As Object, e As EventArgs) Handles btn_Imprimir.Click
        PrintPreviewDialog1.ShowDialog()

        ' Depois de imprimir, vai guardar os dados na base de dados
        ' Usar a estrutura do try catch, para mostrar algum erro ao invés de parar o programa
        Try
            Dim sql As String
            ' O @ indica que são variáveis
            ' Dessa forma, guarda os pedidos e o total
            sql = "insert into pedidos (pedido, total) values (@pe, @to)"
            comando = New SqlCommand(sql, ligacao) ' Para atribuir valores às variáveis
            comando.Parameters.AddWithValue("@pe", lblVenda.Text)
            comando.Parameters.AddWithValue("@to", Total)
            comando.ExecuteNonQuery()

            ' Guardar o detalhe
            Dim posicao As Integer
            For posicao = 0 To lstitens.Items.Count - 1
                sql = "insert into detalhe (pedido, descricao, qtd, preco, total) values (@pe, @de, @qt, @pr, @to)"
                comando = New SqlCommand(sql, ligacao) ' Para atribuir valores às variáveis
                comando.Parameters.AddWithValue("@pe", lblVenda.Text)
                comando.Parameters.AddWithValue("@de", lstitens.Items(posicao)) ' O lstitens.Items(posicao) é onde está a informação
                comando.Parameters.AddWithValue("@qt", lstQnt.Items(posicao))
                comando.Parameters.AddWithValue("@pr", lstUnitario.Items(posicao))
                comando.Parameters.AddWithValue("@to", lstPrecos.Items(posicao))
                comando.ExecuteNonQuery()
            Next
            ' Guardar na base de dados
            ' Para limpar a tela depois de finalizar
            MsgBox("Registo do pedido efetuado", MsgBoxStyle.Information, "POS")
            Inicializa()
        Catch ex As Exception
            MsgBox("Erro ao efetuar pedido" + ex.Message, MsgBoxStyle.Critical, "POS") ' O ex.Message mostra qual é o erro
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titulo1 As New Font("Verdana", 16, FontStyle.Bold)
        Dim titulo2 As New Font("Verdana", 8, FontStyle.Italic)
        Dim titulo3 As New Font("Verdana", 10, FontStyle.Regular)

        e.Graphics.DrawString("Bar", titulo1, Brushes.Green, 50, 50)
        e.Graphics.DrawString("Rua", titulo2, Brushes.Green, 50, 80)
        e.Graphics.DrawString("Código postal", titulo2, Brushes.Green, 50, 100)
        e.Graphics.DrawString("NIF", titulo2, Brushes.Green, 50, 120)

        e.Graphics.DrawString("Descrição", titulo3, Brushes.Black, 50, 150)
        e.Graphics.DrawString("Qtd.", titulo3, Brushes.Black, 250, 150)
        e.Graphics.DrawString("Preço unitário", titulo3, Brushes.Black, 350, 150)
        e.Graphics.DrawString("Total", titulo3, Brushes.Black, 450, 150)
        e.Graphics.DrawLine(New Pen(Brushes.Black), 50, 170, 600, 170)

        Dim linha As Integer = 180

        ' Para adicionar os produtos na página
        For i = 0 To lstitens.Items.Count - 1
            e.Graphics.DrawString(lstitens.Items(i), titulo3, Brushes.Black, 50, linha)
            e.Graphics.DrawString(lstQnt.Items(i), titulo3, Brushes.Black, 250, linha)
            e.Graphics.DrawString(lstUnitario.Items(i), titulo3, Brushes.Black, 350, linha)
            e.Graphics.DrawString(lstPrecos.Items(i), titulo3, Brushes.Black, 500, linha)

            linha += 20
        Next

        e.Graphics.DrawLine(New Pen(Brushes.Black), 50, linha, 600, linha)
        e.Graphics.DrawString("Total" & lblTotal.Text, titulo2, Brushes.Black, 50, linha + 20)
        e.Graphics.DrawString("Numerário" & lblNumerario.Text, titulo2, Brushes.Black, 50, linha + 40)
        e.Graphics.DrawString("Troco" & lblTroco.Text, titulo2, Brushes.Black, 50, linha + 60)

    End Sub
End Class