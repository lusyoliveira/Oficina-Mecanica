Public Class frmConfig
    Dim tbaux As DataTable 'As ADODB.Recordset
    Dim sql As String
    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        carregadados()
    End Sub
    Private Sub carregadados()
        tbaux = OpenRecordset("Select * from tbconfig")
        chkEsconde.Checked = Convert.ToBoolean(tbaux.Rows(0)("esconder").ToString())
        txtCliente.Text = tbaux.Rows(0)("cliente").ToString()
        btnAlterar.Enabled = True
        btnSalvar.Enabled = True
        gpbConfig.Enabled = False
        'tbaux = abrir("Select * from tbconfig")
        'chkEsconde.Checked = IIf(tbaux.Fields("esconder").Value.ToString = "True", True, False)
        'txtCliente.Text = tbaux.Fields("cliente").Value.ToString
        'btnAlterar.Enabled = True
        'btnSalvar.Enabled = True
        'gpbConfig.Enabled = False
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        gpbConfig.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        sql = "update tbconfig set cliente = '" & txtCliente.Text & "', esconder = " & IIf(chkEsconde.Checked = True, True, False)
        tbaux = OpenRecordset(sql)
        btnAlterar.Enabled = True
        btnSalvar.Enabled = False
        gpbConfig.Enabled = False
    End Sub
End Class