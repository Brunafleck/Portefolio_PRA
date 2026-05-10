Imports System.Globalization
Imports Microsoft.Data
Imports Microsoft.Data.SqlClient
Public Class Form1
    Dim ligacao As New SqlConnection
    Dim comando As New SqlCommand
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        If btnNovo.Text = "Novo" Then
            btnNovo.Text = "Cancelar"
            btnCancelar.Enabled = True
            btnGuardar.Enabled = True
            txtNome.Enabled = True
            txtCategoria.Enabled = True
            txtData.Enabled = True
            txtGenero.Enabled = True
            txtNacionalidade.Enabled = True
        Else
            Inicializa()
        End If
    End Sub

    Sub Inicializa()
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        txtNome.Enabled = False
        txtCategoria.Enabled = False
        txtData.Enabled = False
        txtGenero.Enabled = False
        txtNacionalidade.Enabled = False
        btnNovo.Text = "Novo"

        ' Para apagar a informação se clicar no botão cancelar
        txtCategoria.ResetText()
        txtData.ResetText()
        txtGenero.ResetText()
        txtNacionalidade.ResetText()
        txtNome.ResetText()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ligacao.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bruna\Documents\bdfuncionarios.mdf;Integrated Security=True;Connect Timeout=30" ' Caminho para a base de dados

        Try
            ligacao.Open()
            MsgBox("Ligado à base de dados")
        Catch ex As Exception
            MsgBox("Erro ao abrir a base de dados")
        End Try

        Inicializa()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Depois de imprimir, vai guardar os dados na base de dados
        ' Usar a estrutura do try catch, para mostrar algum erro ao invés de parar o programa
        Try
            Dim sql As String
            ' O @ indica que são variáveis
            ' Dessa forma, guarda os pedidos e o total
            sql = "insert into funcionarios (nome, nacionalidade, genero, categoria, data) values (@no, @na, @ge, @ca, @da)"
            comando = New SqlCommand(sql, ligacao) ' Para atribuir valores às variáveis
            comando.Parameters.AddWithValue("@no", txtNome.Text)
            comando.Parameters.AddWithValue("@na", txtNacionalidade.Text)
            comando.parameters.AddWithValue("@ge", txtGenero.Text)
            comando.parameters.AddWithValue("@ca", txtCategoria.Text)
            comando.parameters.AddWithValue("@da", txtData.Text)
            comando.ExecuteNonQuery()

            MsgBox("Registro do funcionário efetuado", MsgBoxStyle.Information, "Registro de funcionários")
            Inicializa()
        Catch ex As Exception
            MsgBox("Erro ao efetuar registro", MsgBoxStyle.Critical, "Registro de funcionários")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Inicializa()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub
End Class
