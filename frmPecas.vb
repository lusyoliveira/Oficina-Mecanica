Public Class frmPecas
    Dim sql As String
    Dim tbPecas As DataTable 'ADODB.Recordset
    Dim x, wcpagina As Integer
    Dim wcimagem As Image
    Private Sub frmPecas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        montargrade()
        MdiParent = frmPrincipal
    End Sub
    Private Sub limpar()
        Grade.Rows.Clear()
        txtCodigo.Text = ""
        txtDescricao.Text = ""
        txtValor.Text = ""
        txtModelo.Text = ""
        txtTipo.Text = ""
    End Sub
    'Private Sub montargrade()
    '    With Grade
    '        .Rows.Clear()
    '        sql = "Select * from tbPecas order by codigo "
    '        tbPecas = OpenRecordset(sql)
    '        If tbPecas.RecordCount <> 0 Then
    '            tbPecas.MoveFirst()
    '            x = 0
    '            While tbPecas.EOF = False
    '                .Rows.Add(False)
    '                .Item(0, x).Value = tbPecas.Fields("codigo").Value.ToString
    '                .Item(1, x).Value = tbPecas.Fields("descricao").Value.ToString
    '                .Item(2, x).Value = FormatCurrency(tbPecas.Fields("valor").Value.ToString)
    '                .Item(3, x).Value = tbPecas.Fields("modelo").Value.ToString
    '                .Item(4, x).Value = tbPecas.Fields("tipo").Value.ToString
    '                x += 1
    '                tbPecas.MoveNext()
    '            End While
    '        End If
    '    End With
    'End Sub
    Private Sub montargrade()
        With Grade
            .Rows.Clear()
            sql = "Select * from tbPecas order by codigo "
            tbPecas = OpenRecordset(sql)
            If tbPecas.Rows.Count <> 0 Then
                For Each row As DataRow In tbPecas.Rows
                    .Rows.Add(False)
                    Dim x As Integer = .Rows.Count - 1
                    .Rows(x).Cells(0).Value = row("codigo").ToString()
                    .Rows(x).Cells(1).Value = row("descricao").ToString()
                    .Rows(x).Cells(2).Value = FormatCurrency(row("valor"))
                    .Rows(x).Cells(3).Value = row("modelo").ToString()
                    .Rows(x).Cells(4).Value = row("tipo").ToString()
                Next
            End If
        End With
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        sql = "update tbPecas set descricao = '" & txtDescricao.Text & "', valor = " & moeda(txtValor.Text) & ", modelo = '" & txtModelo.Text & "', tipo = '" & txtTipo.Text & "' where codigo = " & txtCodigo.Text
        tbPecas = OpenRecordset(sql)
        MsgBox("Peça gravada com sucesso !", MsgBoxStyle.Information)
        btnNovo.Enabled = True
        btnSalvar.Enabled = True
        limpar()
        txtDescricao.Focus()
        montargrade()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        sql = "insert into tbPecas (descricao) values ('" & txtDescricao.Text & "')"
        OpenRecordset(sql) ' Assuming ExecuteSQL is a function to execute SQL queries
        sql = "select * from tbPecas order by codigo desc"
        tbPecas = OpenRecordset(sql)
        If tbPecas.Rows.Count > 0 Then
            txtCodigo.Text = tbPecas.Rows(0)("codigo").ToString
        End If
        txtDescricao.Focus()
    End Sub
    'Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
    '    sql = "insert into tbPecas (descricao) values ('" & txtDescricao.Text & "')"
    '    tbPecas = OpenRecordset(sql)
    '    sql = "select * from tbPecas order by codigo desc"
    '    tbPecas = OpenRecordset(sql)
    '    tbPecas.MoveFirst()
    '    txtCodigo.Text = tbPecas.Fields("codigo").Value.ToString
    '    txtDescricao.Focus()
    'End Sub

    'Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
    '    If btnAlterar.Text = "Alterar" Then
    '        If txtCodigo.Text = "" Then
    '            MsgBox("Digite um codigo válido !", MsgBoxStyle.Information)
    '            Exit Sub
    '        End If
    '        sql = "Select * from tbPecas where codigo = " & txtCodigo.Text
    '        tbPecas = OpenRecordset(sql)
    '        If tbPecas.RecordCount = 0 Then
    '            MsgBox("Este Código Não Existe !", MsgBoxStyle.Critical)
    '            Exit Sub
    '        End If
    '        txtDescricao.Text = tbPecas.Fields("descricao").Value.ToString
    '        txtValor.Text = FormatCurrency(tbPecas.Fields("valor").Value.ToString)
    '        txtModelo.Text = tbPecas.Fields("modelo").Value.ToString
    '        txtTipo.Text = tbPecas.Fields("tipo").Value.ToString
    '        btnSalvar.Enabled = False
    '        btnExcluir.Enabled = False
    '        btnConsultar.Enabled = False
    '        btnAlterar.Text = "Salvar"
    '    Else
    '        sql = "update tbPecas set descricao = '" & txtDescricao.Text & "', valor = " & moeda(txtValor.Text) & ", modelo = '" & txtModelo.Text & "', tipo = '" & txtTipo.Text & "' where codigo = " & txtCodigo.Text
    '        tbPecas = OpenRecordset(sql)
    '        btnSalvar.Enabled = True
    '        btnExcluir.Enabled = True
    '        btnConsultar.Enabled = True
    '        btnAlterar.Text = "Alterar"
    '        limpar()
    '        txtDescricao.Focus()
    '        montargrade()
    '    End If
    'End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If btnAlterar.Text = "Alterar" Then
            If txtCodigo.Text = "" Then
                MsgBox("Digite um código válido !", MsgBoxStyle.Information)
                Exit Sub
            End If
            sql = "Select * from tbPecas where codigo = " & txtCodigo.Text
            tbPecas = OpenRecordset(sql)
            If tbPecas.Rows.Count = 0 Then
                MsgBox("Este Código Não Existe !", MsgBoxStyle.Critical)
                Exit Sub
            End If
            txtDescricao.Text = tbPecas.Rows(0)("descricao").ToString
            txtValor.Text = FormatCurrency(tbPecas.Rows(0)("valor"))
            txtModelo.Text = tbPecas.Rows(0)("modelo").ToString
            txtTipo.Text = tbPecas.Rows(0)("tipo").ToString
            btnSalvar.Enabled = False
            btnExcluir.Enabled = False
            btnConsultar.Enabled = False
            btnAlterar.Text = "Salvar"
        Else
            sql = "update tbPecas set descricao = '" & txtDescricao.Text & "', valor = " & moeda(txtValor.Text) & ", modelo = '" & txtModelo.Text & "', tipo = '" & txtTipo.Text & "' where codigo = " & txtCodigo.Text
            OpenRecordset(sql) ' Assuming ExecuteSQL is a function to execute SQL queries
            btnSalvar.Enabled = True
            btnExcluir.Enabled = True
            btnConsultar.Enabled = True
            btnAlterar.Text = "Alterar"
            limpar()
            txtDescricao.Focus()
            montargrade()
        End If
    End Sub
    'Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
    '    If txtCodigo.Text = "" Then
    '        MsgBox("Digite um codigo válido !", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If
    '    sql = "Select * from tbPecas where codigo = " & txtCodigo.Text
    '    tbPecas = OpenRecordset(sql)
    '    If tbPecas.RecordCount = 0 Then
    '        MsgBox("Não existem clientes com o codigo digitado !", MsgBoxStyle.Critical)
    '        Exit Sub
    '    End If
    '    txtDescricao.Text = tbPecas.Fields("descricao").Value.ToString
    '    txtValor.Text = FormatCurrency(tbPecas.Fields("valor").Value.ToString)
    '    txtModelo.Text = tbPecas.Fields("modelo").Value.ToString
    '    txtTipo.Text = tbPecas.Fields("tipo").Value.ToString
    '    If MsgBox("Tem Certeza Que Deseja Excluir o Cliente ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
    '        sql = "delete from tbPecas where codigo = " & txtCodigo.Text
    '        tbPecas = OpenRecordset(sql)
    '    End If
    '    limpar()
    '    txtDescricao.Focus()
    '    montargrade()
    'End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If txtCodigo.Text = "" Then
            MsgBox("Digite um código válido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "Select * from tbPecas where codigo = " & txtCodigo.Text
        tbPecas = OpenRecordset(sql)
        If tbPecas.Rows.Count = 0 Then
            MsgBox("Não existem clientes com o código digitado !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtDescricao.Text = tbPecas.Rows(0)("descricao").ToString
        txtValor.Text = FormatCurrency(tbPecas.Rows(0)("valor"))
        txtModelo.Text = tbPecas.Rows(0)("modelo").ToString
        txtTipo.Text = tbPecas.Rows(0)("tipo").ToString
        If MsgBox("Tem Certeza Que Deseja Excluir o Cliente ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            sql = "delete from tbPecas where codigo = " & txtCodigo.Text
            OpenRecordset(sql) ' Assuming ExecuteSQL is a function to execute SQL queries
        End If
        limpar()
        txtDescricao.Focus()
        montargrade()
    End Sub
    'Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
    '    If txtCodigo.Text = "" Then
    '        MsgBox("Digite um codigo válido !", MsgBoxStyle.Information)
    '        Exit Sub
    '    End If
    '    sql = "Select * from tbPecas where codigo = " & txtCodigo.Text
    '    tbPecas = OpenRecordset(sql)
    '    If tbPecas.RecordCount = 0 Then
    '        MsgBox("Não existem clientes com o codigo digitado !", MsgBoxStyle.Critical)
    '        Exit Sub
    '    End If
    '    txtDescricao.Text = tbPecas.Fields("descricao").Value.ToString
    '    txtValor.Text = FormatCurrency(tbPecas.Fields("valor").Value.ToString)
    '    txtModelo.Text = tbPecas.Fields("modelo").Value.ToString
    '    txtTipo.Text = tbPecas.Fields("tipo").Value.ToString
    'End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If txtCodigo.Text = "" Then
            MsgBox("Digite um código válido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "Select * from tbPecas where codigo = " & txtCodigo.Text
        tbPecas = OpenRecordset(sql)
        If tbPecas.Rows.Count = 0 Then
            MsgBox("Não existem clientes com o código digitado !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtDescricao.Text = tbPecas.Rows(0)("descricao").ToString
        txtValor.Text = FormatCurrency(tbPecas.Rows(0)("valor"))
        txtModelo.Text = tbPecas.Rows(0)("modelo").ToString
        txtTipo.Text = tbPecas.Rows(0)("tipo").ToString
    End Sub
    Private Sub btnImpirmir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpirmir.Click
        sql = "Select * from tbPecas where descricao <> '' order by descricao"
        tbPecas = OpenRecordset(sql)
        If tbPecas.Rows.Count = 0 Then
            MsgBox("Não existem clientes !")
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
    '    e.Graphics.DrawString("Relatório de Peças", MYFONT3, Brushes.Black, X1 + 100, Y1)
    '    Y1 += Line3
    '    e.Graphics.DrawString("Código", MYFONT3, Brushes.Black, X1, Y1)
    '    e.Graphics.DrawString("Descrição", MYFONT3, Brushes.Black, X1 + 80, Y1)
    '    e.Graphics.DrawString("Valor", MYFONT3, Brushes.Black, X1 + 300, Y1)
    '    Y1 += Line3
    '    e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
    '    While tbPecas.EOF = False
    '        e.Graphics.DrawString(tbPecas.Fields("codigo").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
    '        e.Graphics.DrawString(Microsoft.VisualBasic.Left(tbPecas.Fields("descricao").Value.ToString, 30), MYFONT, Brushes.Black, X1 + 80, Y1)
    '        e.Graphics.DrawString(FormatCurrency(tbPecas.Fields("valor").Value.ToString), MYFONT, Brushes.Black, X1 + 300, Y1)
    '        Y1 += Line
    '        tbPecas.MoveNext()
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
        e.Graphics.DrawString("Relatório de Peças", MYFONT3, Brushes.Black, X1 + 100, Y1)
        Y1 += Line3
        e.Graphics.DrawString("Código", MYFONT3, Brushes.Black, X1, Y1)
        e.Graphics.DrawString("Descrição", MYFONT3, Brushes.Black, X1 + 80, Y1)
        e.Graphics.DrawString("Valor", MYFONT3, Brushes.Black, X1 + 300, Y1)
        Y1 += Line3
        e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
        For Each row As DataRow In tbPecas.Rows
            e.Graphics.DrawString(row("codigo").ToString, MYFONT, Brushes.Black, X1, Y1)
            e.Graphics.DrawString(Microsoft.VisualBasic.Left(row("descricao").ToString, 30), MYFONT, Brushes.Black, X1 + 80, Y1)
            e.Graphics.DrawString(FormatCurrency(row("valor")), MYFONT, Brushes.Black, X1 + 300, Y1)
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
End Class