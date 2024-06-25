Public Class frmLogin
    Dim tbUsuarios, tbConfig As ADODB.Recordset
    Dim existe As Boolean
    Dim x, z As Integer
    Dim sql As String

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim esconde As Boolean
        If tbConfig.Fields("esconder").Value.ToString = "true" Then
            esconde = True
        Else
            esconde = False
        End If
        sql = "Select * from tbusuarios where usuario = '" & txtUsuario.Text & "'"
        tbUsuarios = OpenRecordset(sql)
        If tbUsuarios.RecordCount = 0 Then
            MsgBox("Usuário não existe !", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtSenha.Text.ToUpper = tbUsuarios.Fields("senha").Value.ToString.ToUpper Then

            CtrlMenu(tbUsuarios.Fields("permissao").Value.ToString, esconde)
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
            If tbUsuarios.RecordCount <> 0 Then
                txtUsuario.Text = tbUsuarios.Fields("usuario").Value
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
            If tbUsuarios.RecordCount <> 0 Then
                txtPermissao.Text = tbUsuarios.Fields("permissao").Value
            Else
                MsgBox("Esse Usuário não existe!")
            End If
        End If

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tbConfig = OpenRecordset("Select * from tbconfig")

        If muncripto(tbConfig.Fields("ctrl").Value.ToString).ToString.ToUpper <> "OK" Then
            If tbConfig.Fields("ctrl").Value.ToString = "" Then
                sql = "update tbconfig set ctrl = '" & mcripto(Date.Now.Date.ToString.Replace("/", "").Substring(0, 8)) & "'"
                tbConfig = OpenRecordset(sql)
                sql = "Select * from tbconfig"
                tbConfig = OpenRecordset(sql)
            End If
            If CDate(tratadata2(muncripto(tbConfig.Fields("ctrl").Value.ToString))).AddDays(30) > Date.Now.Date Then
                MsgBox("Sua versão de testes venceu! Por favor, entre em contato com desenvolvedor !", MsgBoxStyle.Critical)
                End
            End If
        End If 'Versão trial
        tbConfig = OpenRecordset("Select * from tbusuarios order by usuario")
        If tbConfig.RecordCount <> 0 Then
            tbConfig.MoveFirst()
            While tbConfig.EOF = False
                txtUsuario.AutoCompleteCustomSource.Add(tbConfig.Fields("usuario").Value.ToString)
                tbConfig.MoveNext()
            End While
        End If
    End Sub
End Class
