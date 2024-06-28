Imports System.Data.SqlClient

Public Class frmUsuarios
    Dim sql As String
    Dim tbUsuarios As DataTable 'ADODB.Recordset
    Dim x, wcpagina As Integer
    Dim wcimagem As Image

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        montargrade()
    End Sub
    Private Sub limpar()
        Grade.Rows.Clear()
        txtCod.Text = ""
        txtNome.Text = ""
        txtSenha.Text = ""
        cboPermissao.Text = ""
    End Sub
    Private Sub montargrade()
        'With Grade
        '    .Rows.Clear()
        '    sql = "Select * from tbUsuarios order by codigo "
        '    tbUsuarios = OpenRecordset(sql)
        '    If tbUsuarios.RecordCount <> 0 Then
        '        tbUsuarios.MoveFirst()
        '        x = 0
        '        While tbUsuarios.EOF = False
        '            .Rows.Add(False)
        '            .Item(0, x).Value = tbUsuarios.Fields("codigo").Value.ToString
        '            .Item(1, x).Value = tbUsuarios.Fields("usuario").Value.ToString
        '            .Item(2, x).Value = tbUsuarios.Fields("permissao").Value.ToString
        '            x += 1
        '            tbUsuarios.MoveNext()
        '        End While
        '    End If
        'End With
        With Grade
            .Rows.Clear()
            sql = "Select * from tbUsuarios order by codigo "
            tbUsuarios = OpenRecordset(sql)
            If tbUsuarios.Rows.Count <> 0 Then
                For Each row As DataRow In tbUsuarios.Rows
                    .Rows.Add(False)
                    Dim x As Integer = .Rows.Count - 1
                    .Rows(x).Cells(0).Value = row("codigo").ToString()
                    .Rows(x).Cells(1).Value = row("usuario").ToString()
                    .Rows(x).Cells(3).Value = row("permissao").ToString()
                Next
            End If
        End With
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        'sql = "update tbUsuarios set usuario = '" & txtNome.Text & "', senha = '" & txtSenha.Text & "', permissao = '" & cboPermissao.Text & "' where codigo = " & txtCod.Text
        sql = "INSERT INTO tbUsuarios (usuario,senha,permissao) VALUES ('" & txtNome.Text & "','" & txtSenha.Text & "','" & cboPermissao.Text & "')"
        tbUsuarios = OpenRecordset(sql)
        MsgBox("Usuário gravado com sucesso !", MsgBoxStyle.Information)
        btnSalvar.Enabled = False
        limpar()
        txtNome.Focus()
        montargrade()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If btnAlterar.Text = "Alterar" Then
            If txtCod.Text = "" Then
                MsgBox("Digite um código válido !", MsgBoxStyle.Information)
                Exit Sub
            End If
            sql = "Select * from tbUsuarios where codigo = " & txtCod.Text
            tbUsuarios = OpenRecordset(sql)
            If tbUsuarios.Rows.Count = 0 Then
                MsgBox("Este Código Não Existe !", MsgBoxStyle.Critical)
                Exit Sub
            End If
            txtNome.Text = tbUsuarios.Rows(0)("usuario").ToString()
            txtSenha.Text = tbUsuarios.Rows(0)("senha").ToString()
            cboPermissao.Text = tbUsuarios.Rows(0)("permissao").ToString()
            btnSalvar.Enabled = False
            btnExcluir.Enabled = False
            btnConsultar.Enabled = False
            btnAlterar.Text = "Salvar"
        Else
            sql = "update tbUsuarios set usuario = '" & txtNome.Text & "', senha = '" & txtSenha.Text & "', permissao = '" & cboPermissao.Text & "' where codigo = " & txtCod.Text
            tbUsuarios = OpenRecordset(sql)
            btnSalvar.Enabled = True
            btnExcluir.Enabled = True
            btnConsultar.Enabled = True
            btnAlterar.Text = "Alterar"
            limpar()
            txtNome.Focus()
            montargrade()
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If txtCodigo.Text = "" Then
            MsgBox("Digite um codigo válido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "Select * from tbUsuarios where modelo = " & txtNome.Text
        tbUsuarios = OpenRecordset(sql)
        If tbUsuarios.Rows.Count = 0 Then
            MsgBox("Não existem Usuário com o codigo digitado !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtNome.Text = tbUsuarios.Rows(0)("usuario").ToString
        txtSenha.Text = tbUsuarios.Rows(0)("senha").ToString
        cboPermissao.Text = tbUsuarios.Rows(0)("permissao").ToString
        If MsgBox("Tem Certeza Que Deseja Excluir o Usuário ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            sql = "delete from tbUsuarios where codigo = " & txtCod.Text
            tbUsuarios = OpenRecordset(sql)
        End If
        limpar()
        txtNome.Focus()
        montargrade()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If txtCodigo.Text = "" Then
            MsgBox("Digite um código válido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "Select * from tbUsuarios where codigo = " & txtCod.Text
        tbUsuarios = OpenRecordset(sql)
        If tbUsuarios.Rows.Count = 0 Then
            MsgBox("Não existem o usuário !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtNome.Text = tbUsuarios.Rows(0)("usuario").Value.ToString
        txtSenha.Text = tbUsuarios.Rows(0)("senha").Value.ToString
        cboPermissao.Text = tbUsuarios.Rows(0)("permissao").Value.ToString
    End Sub

    Private Sub btnImpirmir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpirmir.Click
        sql = "Select * from tbUsuarios where usuario <> '' order by usuario"
        tbUsuarios = OpenRecordset(sql)
        If tbUsuarios.Rows.Count = 0 Then
            MsgBox("Não existem veiculo !")
            Exit Sub
        End If
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        wcpagina = 1
        If PrintDocument1.PrintController.IsPreview = False Then
            PrintDialog1.ShowDialog()
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If
    End Sub

    'Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    '    Dim MYFONT As New Font("ARIAL", 8)
    '    Dim MYFONT3 As New Font("ARIAL", 10, FontStyle.Bold)
    '    Dim MYFONT2 As New Font("ARIAL", 12, FontStyle.Bold)
    '    Dim Pulou As Boolean = False

    '    Dim X1 As Single = e.MarginBounds.Left ' Variavel que controla a coluna
    '    Dim Y1 As Single = e.MarginBounds.Top  ' Variavel que controla a linha
    '    Dim Line As Single = MYFONT.GetHeight(e.Graphics) ' Pega o tamanho da linha a ser adicionada quando usar a myfont
    '    Dim Line2 As Single = MYFONT2.GetHeight(e.Graphics) ' Pega o tamanho da
    '    Dim Line3 As Single = MYFONT3.GetHeight(e.Graphics) ' Pega o tamanho da

    '    wcimagem = Image.FromFile("C:\Documents and Settings\Administrador\Meus documentos\Técnico\2º Período\VB.net\Oficina Mecânica\Oficina Mecânica\drag.png")
    '    e.Graphics.DrawImage(wcimagem, X1, Y1 - 30, 50, 50)
    '    e.Graphics.DrawString("Oficina Mecânica", MYFONT2, Brushes.Black, X1 + 100, Y1)
    '    Y1 += Line2
    '    e.Graphics.DrawString("Relatório de Usuários", MYFONT3, Brushes.Black, X1 + 100, Y1)
    '    Y1 += Line3
    '    e.Graphics.DrawString("Código", MYFONT3, Brushes.Black, X1, Y1)
    '    e.Graphics.DrawString("Usuário", MYFONT3, Brushes.Black, X1 + 80, Y1)
    '    e.Graphics.DrawString("Permissão", MYFONT3, Brushes.Black, X1 + 300, Y1)
    '    Y1 += Line3
    '    e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
    '    While tbUsuarios.EOF = False
    '        e.Graphics.DrawString(tbUsuarios.Fields("codigo").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
    '        e.Graphics.DrawString(Microsoft.VisualBasic.Left(tbUsuarios.Fields("usuario").Value.ToString, 30), MYFONT, Brushes.Black, X1 + 80, Y1)
    '        e.Graphics.DrawString(tbUsuarios.Fields("permissao").Value.ToString, MYFONT, Brushes.Black, X1 + 300, Y1)
    '        Y1 += Line
    '        tbUsuarios.MoveNext()
    '        If Y1 >= e.MarginBounds.Bottom - 100 Then
    '            Pulou = True
    '            Exit While
    '        End If
    '    End While
    '    If Pulou Then
    '        e.HasMorePages = True
    '        Y1 = e.MarginBounds.Bottom
    '        e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
    '        Y1 += Line
    '        e.Graphics.DrawString("Página:" & wcpagina, MYFONT2, Brushes.Black, X1, Y1)
    '        wcpagina += 1
    '    End If
    'End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim MYFONT As New Font("ARIAL", 8)
        Dim MYFONT3 As New Font("ARIAL", 10, FontStyle.Bold)
        Dim MYFONT2 As New Font("ARIAL", 12, FontStyle.Bold)
        Dim Pulou As Boolean = False

        Dim X1 As Single = e.MarginBounds.Left ' Variavel que controla a coluna
        Dim Y1 As Single = e.MarginBounds.Top ' Variavel que controla a linha
        Dim Line As Single = MYFONT.GetHeight(e.Graphics) ' Pega o tamanho da linha a ser adicionada quando usar a myfont
        Dim Line2 As Single = MYFONT2.GetHeight(e.Graphics) ' Pega o tamanho da
        Dim Line3 As Single = MYFONT3.GetHeight(e.Graphics) ' Pega o tamanho da

        wcimagem = Image.FromFile("C:\Documents and Settings\Administrador\Meus documentos\Técnico\2º Período\VB.net\Oficina Mecânica\Oficina Mecânica\drag.png")
        e.Graphics.DrawImage(wcimagem, X1, Y1 - 30, 50, 50)
        e.Graphics.DrawString("Oficina Mecânica", MYFONT2, Brushes.Black, X1 + 100, Y1)
        Y1 += Line2
        e.Graphics.DrawString("Relatório de Usuários", MYFONT3, Brushes.Black, X1 + 100, Y1)
        Y1 += Line3
        e.Graphics.DrawString("Código", MYFONT3, Brushes.Black, X1, Y1)
        e.Graphics.DrawString("Usuário", MYFONT3, Brushes.Black, X1 + 80, Y1)
        e.Graphics.DrawString("Permissão", MYFONT3, Brushes.Black, X1 + 300, Y1)
        Y1 += Line3
        e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)

        For Each row As DataRow In tbUsuarios.Rows
            e.Graphics.DrawString(row("codigo").ToString(), MYFONT, Brushes.Black, X1, Y1)
            e.Graphics.DrawString(Microsoft.VisualBasic.Left(row("usuario").ToString(), 30), MYFONT, Brushes.Black, X1 + 80, Y1)
            e.Graphics.DrawString(row("permissao").ToString(), MYFONT, Brushes.Black, X1 + 300, Y1)
            Y1 += Line
            If Y1 >= e.MarginBounds.Bottom - 100 Then
                Pulou = True
                Exit For
            End If
        Next

        If Pulou Then
            e.HasMorePages = True
            Y1 = e.MarginBounds.Bottom
            e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
            Y1 += Line
            e.Graphics.DrawString("Página:" & wcpagina, MYFONT2, Brushes.Black, X1, Y1)
            wcpagina += 1
        End If
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

    End Sub

    Private Sub cboPermissao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPermissao.GotFocus
        'With cboPermissao
        '    .Items.Clear()
        '    tbUsuarios = OpenRecordset("Select distinct permissao from tbpermissoes order by permissao")
        '    If tbUsuarios.Rows.Count <> 0 Then
        '        tbUsuarios.MoveFirst()
        '        While tbUsuarios.EOF = False
        '            .Items.Add(tbUsuarios.Fields("permissao").Value.ToString)
        '            tbUsuarios.MoveNext()
        '        End While
        '    End If

        'End With
        With cboPermissao
            .Items.Clear()
            Dim dtPermissoes As DataTable = OpenRecordset("Select distinct permissao from tbpermissoes order by permissao")
            If dtPermissoes.Rows.Count <> 0 Then
                For Each row As DataRow In dtPermissoes.Rows
                    .Items.Add(row("permissao").ToString())
                Next
            End If
        End With
    End Sub
End Class