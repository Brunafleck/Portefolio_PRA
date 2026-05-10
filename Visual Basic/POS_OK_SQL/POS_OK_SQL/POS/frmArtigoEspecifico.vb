'

Public Class frmArtigoEspecifico
    Private Sub btnAceitar_Click(sender As Object, e As EventArgs) Handles btnAceitar.Click
        If txtDescricao.Text.Length = 0 Then
            MsgBox("Digite um nome para o artigo", MsgBoxStyle.Critical, "Atenção")
            txtDescricao.BackColor = Color.White
            txtDescricao.Focus()
            Exit Sub
        End If

        If txtValor.Text.Length = 0 Then
            MsgBox("Digite um preço para o artigo", MsgBoxStyle.Critical, "Atenção")
            txtDescricao.BackColor = Color.White
            txtValor.Focus()
            Exit Sub
        End If

        frmPrincipal.AdicionaProduto(frmPrincipal.picEspecial, txtDescricao.Text, txtValor.Text)
        Close()
    End Sub
End Class