Public Class frmPermissao
    Dim tbPermissao As DataTable
    Dim sql As String
    Dim x As Integer
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click


        If cboPermissao.Text = "" Then
            MsgBox("Selecione a permissão para gravar.", MsgBoxStyle.Information)
            cboPermissao.Focus()
            Exit Sub
        End If
        For x = 0 To lstMenus.Items.Count - 1
            sql = "Select * from tbpermissoes where permissao = '" & cboPermissao.Text & "' and menu ='" & lstMenus.Items(x).ToString & "'"
            tbPermissao = OpenRecordset(sql)
            If tbPermissao.Rows.Count = 0 Then
                sql = "Insert into tbpermissoes (permissao,menu,ativo) values ('" & cboPermissao.Text & "','" & lstMenus.Items(x).ToString & "','" & IIf(lstMenus.GetItemChecked(x) = True, "1", "0") & "')"
            Else
                sql = "update tbpermissoes set ativo= '" & IIf(lstMenus.GetItemChecked(x) = True, "1", "0") & "' where permissao = '" & cboPermissao.Text & "' and menu ='" & lstMenus.Items(x).ToString & "'"
            End If
            tbPermissao = OpenRecordset(sql)
            lstMenus.SetItemChecked(x, False)
        Next
        limpar()

    End Sub

    Private Sub cboPermissao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPermissao.GotFocus
        With cboPermissao
            .Items.Clear()
            tbPermissao = OpenRecordset("Select distinct permissao from tbpermissoes order by permissao")
            If tbPermissao.Rows.Count <> 0 Then
                For Each row As DataRow In tbPermissao.Rows
                    .Items.Add(row("permissao").ToString)
                Next
            End If
        End With
    End Sub

    Private Sub limpar()
        cboPermissao.Text = ""
        lstMenus.Items.Clear()
        pegamenus(lstMenus, frmPrincipal.MenuStrip1)
    End Sub

    Private Sub frmPermissao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pegamenus(lstMenus, frmPrincipal.MenuStrip1)
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If cboPermissao.Text = "" Then
            MsgBox("Selecione a permissão para gravar.", MsgBoxStyle.Information)
            cboPermissao.Focus()
            Exit Sub
        End If
        sql = "Select * from tbpermissoes where permissao = '" & cboPermissao.Text & "'"
        tbPermissao = OpenRecordset(sql)
        If tbPermissao.Rows.Count <> 0 Then
            For Each row As DataRow In tbPermissao.Rows
                For x = 0 To lstMenus.Items.Count - 1
                    If row("menu").ToString.ToUpper = lstMenus.Items(x).ToString.ToUpper Then
                        lstMenus.SetItemChecked(x, IIf(row("ativo"), True, False))
                    End If
                Next
            Next
        End If
    End Sub

End Class