
Imports System.Data.SqlClient

Public Class frmLogin
    Dim tbUsuarios, tbConfig As DataTable
    ' Dim tbUsuarios, tbConfig As ADODB.Recordset
    Dim existe As Boolean
    Dim x, z As Integer
    Dim sql As String

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim esconde As Boolean
        If tbConfig.Rows(0)("esconder").ToString = "true" Then
            esconde = True
        Else
            esconde = False
        End If
        sql = "Select * from tbusuarios where usuario = '" & txtUsuario.Text & "'"
        tbUsuarios = OpenRecordset(sql)
        If tbUsuarios.Rows.Count = 0 Then
            MsgBox("Usuário não existe !", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtSenha.Text.ToUpper = tbUsuarios.Rows(0)("senha").ToString.ToUpper Then

            CtrlMenu(tbUsuarios.Rows(0)("permissao").ToString, esconde)
            frmPrincipal.Show()
            Me.Close()
        Else
            MsgBox("Senha inválida !")
        End If
    End Sub

    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        If txtCodigo.Text <> "" Then
            sql = "select * from tbUsuarios where codigo= " & txtCodigo.Text
            tbUsuarios = OpenRecordset(sql)
            If tbUsuarios.Rows.Count <> 0 Then
                txtUsuario.Text = tbUsuarios.Rows(0)("usuario").ToString
            Else
                MsgBox("Esse Usuário não existe!")
            End If
        End If

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub txtSenha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSenha.LostFocus
        If txtSenha.Text <> "" Then
            sql = "select * from tbUsuarios where codigo= " & txtCodigo.Text
            tbUsuarios = OpenRecordset(sql)

            If tbUsuarios.Columns.Count() <> 0 Then
                txtPermissao.Text = tbUsuarios.Rows(0)("permissao").ToString
            Else
                MsgBox("Esse Usuário não existe!")
            End If


            If tbUsuarios.Rows.Count <> 0 Then
                txtPermissao.Text = tbUsuarios.Rows(0)("permissao").ToString
            Else
                MsgBox("Esse Usuário não existe!")
            End If
        End If

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tbConfig As DataTable = OpenRecordset("Select * from tbconfig")

        If muncripto(tbConfig.Rows(0)("ctrl").ToString()).ToUpper() <> "OK" Then
            If tbConfig.Rows(0)("ctrl").ToString() = "" Then
                Dim sql As String = "update tbconfig set ctrl = '" & mcripto(Date.Now.Date.ToString("yyyyMMdd")) & "'"
                OpenRecordset(sql)
                sql = "Select * from tbconfig"
                tbConfig = OpenRecordset(sql)
            End If
            If CDate(tratadata2(muncripto(tbConfig.Rows(0)("ctrl").ToString()))).AddDays(30) > Date.Now.Date Then
                MsgBox("Sua versão de testes venceu! Por favor, entre em contato com desenvolvedor !", MsgBoxStyle.Critical)
                End
            End If
        End If 'Versão trial

        tbConfig = OpenRecordset("Select * from tbusuarios order by usuario")
        If tbConfig.Rows.Count <> 0 Then
            For Each row As DataRow In tbConfig.Rows
                txtUsuario.AutoCompleteCustomSource.Add(row("usuario").ToString())
            Next
        End If

        'tbConfig = OpenRecordset("Select * from tbconfig", tpServidor.SqlServer)

        'If muncripto(tbConfig.Fields("ctrl").Value.ToString).ToString.ToUpper <> "OK" Then
        '    If tbConfig.Fields("ctrl").Value.ToString = "" Then
        '        sql = "update tbconfig set ctrl = '" & mcripto(Date.Now.Date.ToString.Replace("/", "").Substring(0, 8)) & "'"
        '        tbConfig = OpenRecordset(sql)
        '        sql = "Select * from tbconfig"
        '        tbConfig = OpenRecordset(sql)
        '    End If
        '    If CDate(tratadata2(muncripto(tbConfig.Fields("ctrl").Value.ToString))).AddDays(30) > Date.Now.Date Then
        '        MsgBox("Sua versão de testes venceu! Por favor, entre em contato com desenvolvedor !", MsgBoxStyle.Critical)
        '        End
        '    End If
        'End If 'Versão trial
        'tbConfig = OpenRecordset("Select * from tbusuarios order by usuario", tpServidor.SqlServer)
        'If tbConfig.RecordCount <> 0 Then
        '    tbConfig.MoveFirst()
        '    While tbConfig.EOF = False
        '        txtUsuario.AutoCompleteCustomSource.Add(tbConfig.Fields("usuario").Value.ToString)
        '        tbConfig.MoveNext()
        '    End While
        'End If
    End Sub
End Class
