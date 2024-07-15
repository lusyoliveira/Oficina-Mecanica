
Imports System.Data.SqlClient

Public Class frmLogin
    Dim ClasseUsuario As New clsUsuario
    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        ClasseUsuario.Autenticar(txtUsuario.Text, txtSenha.Text)
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class
