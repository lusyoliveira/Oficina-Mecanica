Public Class frmOrcamento
    Dim sql As String
    Dim tbOrcamento, tbOrcamento_pecas, tbOrcamento_servico, tbClientes, TbPecas, TbFuncionarios, tbServico As ADODB.Recordset
    Dim x, wcpagina As Integer
    Dim wcimagem As Image
    Dim existe As Boolean
    Private Sub frmOrcamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        montargradeservico()
        montargradepeca()
    End Sub

    Private Sub cboClientes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClientes.GotFocus
        cboClientes.Items.Clear()
        sql = "Select * from tbclientes order by nome"
        tbClientes = OpenRecordset(sql)
        If tbClientes.RecordCount <> 0 Then
            tbClientes.MoveFirst()
            While tbClientes.EOF = False
                cboClientes.Items.Add(tbClientes.Fields("nome").Value.ToString)
                tbClientes.MoveNext()
            End While
        End If
    End Sub

    Private Sub cboClientes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClientes.LostFocus
        If cboClientes.Text = "" Then
            Exit Sub
        End If
        sql = "Select * from tbclientes where nome = '" & cboClientes.Text & "'"
        tbClientes = OpenRecordset(sql)
        If tbClientes.RecordCount = 0 Then
            MsgBox("Atenção: O cliente não existe !")
            cboClientes.Focus()
            Exit Sub
        End If
        cboClientes.Tag = tbClientes.Fields("codigo").Value
    End Sub

    Private Sub cboFuncionario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFuncionario.GotFocus
        cboFuncionario.Items.Clear()
        sql = "Select * from tbFuncionarios order by nome"
        TbFuncionarios = OpenRecordset(sql)
        If TbFuncionarios.RecordCount <> 0 Then
            TbFuncionarios.MoveFirst()
            While TbFuncionarios.EOF = False
                cboFuncionario.Items.Add(TbFuncionarios.Fields("nome").Value.ToString)
                TbFuncionarios.MoveNext()
            End While
        End If
    End Sub

    Private Sub cboFuncionario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFuncionario.LostFocus
        If cboFuncionario.Text = "" Then
            Exit Sub
        End If
        sql = "Select * from TbFuncionarios where nome = '" & cboFuncionario.Text & "'"
        TbFuncionarios = OpenRecordset(sql)
        If TbFuncionarios.RecordCount = 0 Then
            MsgBox("Atenção: O funcionário não existe !")
            cboFuncionario.Focus()
            Exit Sub
        End If
        cboFuncionario.Tag = TbFuncionarios.Fields("codigo").Value
    End Sub

    Private Sub cboPecas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPecas.GotFocus
        cboPecas.Items.Clear()
        sql = "Select * from tbPecas order by descricao"
        TbPecas = OpenRecordset(sql)
        If TbPecas.RecordCount <> 0 Then
            TbPecas.MoveFirst()
            While TbPecas.EOF = False
                cboPecas.Items.Add(TbPecas.Fields("descricao").Value.ToString)
                TbPecas.MoveNext()
            End While
        End If
    End Sub

    Private Sub cboPecas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPecas.LostFocus
        If cboPecas.Text = "" Then
            Exit Sub
        End If
        sql = "Select * from TbPecas where descricao = '" & cboPecas.Text & "'"
        TbPecas = OpenRecordset(sql)
        If TbPecas.RecordCount = 0 Then
            MsgBox("Atenção: A Peça não existe !")
            cboPecas.Focus()
            Exit Sub
        End If
        cboPecas.Tag = TbPecas.Fields("codigo").Value
        txtValorpeca.Text = FormatCurrency(TbPecas.Fields("valor").Value.ToString)
        txtQuantidadepeca.Focus()
    End Sub

    Private Sub cboServico_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboServico.GotFocus
        cboServico.Items.Clear()
        sql = "Select * from tbServico order by tipo"
        tbServico = OpenRecordset(sql)
        If tbServico.RecordCount <> 0 Then
            tbServico.MoveFirst()
            While tbServico.EOF = False
                cboServico.Items.Add(tbServico.Fields("descricao").Value.ToString)
                tbServico.MoveNext()
            End While
        End If
    End Sub

    Private Sub cboServico_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboServico.LostFocus
        If cboServico.Text = "" Then
            Exit Sub
        End If
        sql = "Select * from tbServico where descricao = '" & cboServico.Text & "'"
        tbServico = OpenRecordset(sql)
        If tbServico.RecordCount = 0 Then
            MsgBox("Atenção: O Serviço não existe !")
            cboServico.Focus()
            Exit Sub
        End If
        cboServico.Tag = tbServico.Fields("codigo").Value
        txtTotalservico.Text = FormatCurrency(tbServico.Fields("valor").Value.ToString)
        cboPecas.Focus()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        sql = "insert into tbOrcamento (data,nrorcamento) values ('" & Date.Now.Date & "'," & txtNumero.Text & ")"
        tbOrcamento = OpenRecordset(sql)
        btnSalvar.Enabled = True
        btnNovo.Enabled = False
        sql = "Select * from tbOrcamento order by nrseq desc"
        tbOrcamento = OpenRecordset(sql)
        txtNumero.Text = tbOrcamento.Fields("nrorcamento").Value.ToString
        txtNumero.Enabled = False
        txtData.Text = Date.Now.Date
        cbxAprovado.Checked = False
        cbxAprovado.Enabled = False
        cboClientes.Focus()
    End Sub

    Private Sub btnOkservico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkservico.Click
        sql = "insert into tborcamento_servico (nrorcamento,data,cliente,funcionario,servico,valortotal) values (" & txtNumero.Text & "," & Date.Now.Date & ",'" & cboClientes.Text & "','" & cboFuncionario.Text & "','" & cboServico.Text & "'," & moeda(txtTotalservico.Text) & ")"
        tbOrcamento_servico = OpenRecordset(sql)
        sql = "Select sum(valortotal) as Valortotal from tbOrcamento_servico where nrorcamento = " & txtNumero.Text
        tbOrcamento_servico = OpenRecordset(sql)
        If tbOrcamento_servico.RecordCount <> 0 Then
            txtValortotalservico.Text = FormatCurrency(tbOrcamento_servico.Fields("valortotal").Value)
        Else
            txtValortotalservico.Text = 0
        End If
        txtTotalservico.Text = ""
        cboServico.Text = ""
        cboServico.Focus()
        montargradeservico()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        sql = "update tbOrcamento set cliente = '" & cboClientes.Text & "', funcionario = '" & cboFuncionario.Text & "', desconto = " & moeda(txtDesconto.Text) & ",totalgeral = " & moeda(txtTotalgeral.Text) & ", aprovado = '0', valorservico = " & moeda(txtValortotalservico.Text) & ", valorpeca = " & moeda(txtValortotalpeca.Text) & " where nrorcamento = " & txtNumero.Text
        tbOrcamento = OpenRecordset(sql)
        MsgBox("Orçamento gravado com sucesso !", MsgBoxStyle.Information)
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        limpar()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        sql = "Select * from tbOrcamento where nrorcamento = " & txtNumero.Text
        tbOrcamento = OpenRecordset(sql)
        If tbOrcamento.RecordCount = 0 Then
            MsgBox("Não existe o orçamento solicitado !", MsgBoxStyle.Information)
            Exit Sub
        End If
        cboClientes.Text = tbOrcamento.Fields("cliente").Value.ToString
        txtTotalgeral.Text = tbOrcamento.Fields("totalgeral").Value
        txtDesconto.Text = tbOrcamento.Fields("desconto").Value
        txtData.Text = tbOrcamento.Fields("data").Value
        cbxAprovado.Checked = IIf(tbOrcamento.Fields("aprovado").Value.ToString = "True", True, False)
    End Sub

    Private Sub btnAprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprovar.Click
        sql = "Select * from ttbOrcamento where nrorcamento = " & txtNumero.Text
        tbOrcamento = OpenRecordset(sql)
        If tbOrcamento.RecordCount = 0 Then
            MsgBox("Não existe o orçamento solicitado !", MsgBoxStyle.Information)
            Exit Sub
        End If
        cboClientes.Text = tbOrcamento.Fields("cliente").Value.ToString
        txtTotalgeral.Text = tbOrcamento.Fields("totalgeral").Value
        txtDesconto.Text = tbOrcamento.Fields("desconto").Value
        txtData.Text = tbOrcamento.Fields("data").Value
        cbxAprovado.Checked = IIf(tbOrcamento.Fields("aprovado").Value.ToString = "True", True, False)
        If MsgBox("Deseja aprovar o orçamento ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        sql = "update tbOrcamento set aprovado = '1' where nrorcamento = " & txtNumero.Text
        tbOrcamento = OpenRecordset(sql)
        limpar()
    End Sub
    Private Sub limpar()
        Gradeservico.Rows.Clear()
        Gradepeca.Rows.Clear()
        txtData.Text = ""
        txtDesconto.Text = ""
        txtTotalgeral.Text = ""
        txtNumero.Text = ""
        txtQuantidadepeca.Text = ""
        txtTotalservico.Text = ""
        txtTotalpeca.Text = ""
        txtValorpeca.Text = ""
        cboClientes.Text = ""
        cboServico.Text = ""
        cboPecas.Text = ""
    End Sub
    Private Sub montargradeservico()
        With Gradeservico
            .Rows.Clear()
            sql = "Select * from tbOrcamento_servico order by nrseq"
            tbOrcamento_servico = OpenRecordset(sql)
            If tbOrcamento_servico.RecordCount <> 0 Then
                tbOrcamento_servico.MoveFirst()
                x = 0
                While tbOrcamento_servico.EOF = False
                    .Rows.Add(False)
                    .Item(0, x).Value = tbOrcamento_servico.Fields("nrorcamento").Value
                    .Item(1, x).Value = tbOrcamento_servico.Fields("data").Value.ToString
                    .Item(2, x).Value = tbOrcamento_servico.Fields("cliente").Value
                    .Item(3, x).Value = tbOrcamento_servico.Fields("funcionario").Value
                    .Item(4, x).Value = tbOrcamento_servico.Fields("servico").Value
                    .Item(5, x).Value = FormatCurrency(tbOrcamento_servico.Fields("valortotal").Value)
                    x += 1
                    tbOrcamento_servico.MoveNext()
                End While
            End If
        End With
    End Sub
    Private Sub montargradepeca()
        With Gradepeca
            .Rows.Clear()
            sql = "Select * from tbOrcamento_pecas order by nrseq"
            tbOrcamento_pecas = OpenRecordset(sql)
            If tbOrcamento_pecas.RecordCount <> 0 Then
                tbOrcamento_pecas.MoveFirst()
                x = 0
                While tbOrcamento_pecas.EOF = False
                    .Rows.Add(False)
                    .Item(0, x).Value = tbOrcamento_pecas.Fields("nrorcamento").Value
                    .Item(1, x).Value = tbOrcamento_pecas.Fields("peca").Value.ToString
                    .Item(2, x).Value = FormatCurrency(tbOrcamento_pecas.Fields("valorunitario").Value)
                    .Item(3, x).Value = tbOrcamento_pecas.Fields("quantidade").Value
                    .Item(4, x).Value = FormatCurrency(tbOrcamento_pecas.Fields("valortotal").Value)
                    x += 1
                    tbOrcamento_pecas.MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub btnOkpeca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkpeca.Click
        sql = "insert into tborcamento_pecas (nrorcamento,peca,valorunitario,quantidade,valortotal) values (" & txtNumero.Text & ",'" & cboPecas.Tag & "'," & moeda(txtTotalpeca.Text) & "," & txtQuantidadepeca.Text & "," & moeda(txtValorpeca.Text) & ")"
        tbOrcamento_pecas = OpenRecordset(sql)
        sql = "Select sum(valortotal) as Valortotal from tbOrcamento_pecas where nrorcamento = " & txtNumero.Text
        tbOrcamento_pecas = OpenRecordset(sql)
        If tbOrcamento_pecas.RecordCount <> 0 Then
            txtValortotalpeca.Text = FormatCurrency(tbOrcamento_pecas.Fields("valortotal").Value)
        Else
            txtValortotalpeca.Text = 0
        End If
        txtTotalservico.Text = ""
        cboPecas.Text = ""
        cboPecas.Focus()
        montargradepeca()
    End Sub
    Private Sub txtQuantidadepeca_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantidadepeca.LostFocus
        txtTotalpeca.Text = FormatCurrency(txtValorpeca.Text * txtQuantidadepeca.Text)
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnExcluirservico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirservico.Click
        er.Clear()
        If txtNumero.Text = "" Then
            With Gradeservico
                existe = False
                For x = 0 To .Rows.Count - 1
                    If .Item(0, x).Value = True Then
                        existe = True
                    End If
                Next
                If existe = False Then
                    er.SetError(Gradeservico, "Por favor selecione ao menos uma linha para excluir !")
                    Exit Sub
                End If
                If MsgBox("Confirma a exclusão das linhas selecionadas ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
                For x = 0 To .Rows.Count - 1
                    If .Item(0, x).Value = True Then
                        sql = "delete from tbOrcamento_servico where nrorcamento = " & .Item(1, x).Value
                        tbOrcamento_servico = OpenRecordset(sql)
                    End If
                Next

            End With
        Else

            sql = "Select * from tbOrcamento_servico where nrorcamento = " & txtNumero.Text
            tbOrcamento_servico = OpenRecordset(sql)
            If tbOrcamento_servico.RecordCount = 0 Then
                er.SetError(lblNumero, "O codigo digitado não existe !")
                Exit Sub
            End If
            txtData.Text = tbOrcamento_servico.Fields("data").Value
            cboClientes.Text = tbOrcamento_servico.Fields("cliente").Value.ToString
            cboFuncionario.Text = tbOrcamento_servico.Fields("funcionario").Value.ToString
            cboServico.Text = tbOrcamento_servico.Fields("servico").Value.ToString
            txtTotalservico.Text = tbOrcamento_servico.Fields("valortotal").Value.ToString
            If MsgBox("Confirma a exclusão do codigo selecionado ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            sql = "delete from tbOrcamento_servico where nrorcamento = " & txtNumero.Text
            tbOrcamento_servico = OpenRecordset(sql)
        End If
        limpar()
        montargradeservico()
    End Sub

    Private Sub btnExcluirpeca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirpeca.Click
        er.Clear()
        If txtNumero.Text = "" Then
            With Gradepeca
                existe = False
                For x = 0 To .Rows.Count - 1
                    If .Item(0, x).Value = True Then
                        existe = True
                    End If
                Next
                If existe = False Then
                    er.SetError(Gradepeca, "Por favor selecione ao menos uma linha para excluir !")
                    Exit Sub
                End If
                If MsgBox("Confirma a exclusão das linhas selecionadas ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
                For x = 0 To .Rows.Count - 1
                    If .Item(0, x).Value = True Then
                        sql = "delete from tbOrcamento_pecas where nrorcamento = " & .Item(1, x).Value
                        tbOrcamento_pecas = OpenRecordset(sql)
                    End If
                Next

            End With
        Else

            sql = "Select * from tbOrcamento_pecas where nrorcamento = " & txtNumero.Text
            tbOrcamento_pecas = OpenRecordset(sql)
            If tbOrcamento_pecas.RecordCount = 0 Then
                er.SetError(lblNumero, "O codigo digitado não existe !")
                Exit Sub
            End If
            cboPecas.Text = tbOrcamento_pecas.Fields("peca").Value.ToString
            txtValorpeca.Text = tbOrcamento_pecas.Fields("valorunitario").Value.ToString
            txtQuantidadepeca.Text = tbOrcamento_pecas.Fields("quantidade").Value.ToString
            txtTotalpeca.Text = tbOrcamento_pecas.Fields("valortotal").Value.ToString
            If MsgBox("Confirma a exclusão do codigo selecionado ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            sql = "delete from tbOrcamento_pecas where nrorcamento = " & txtNumero.Text
            tbOrcamento_pecas = OpenRecordset(sql)
        End If
        limpar()
        montargradepeca()
    End Sub

    Private Sub txtDesconto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesconto.GotFocus
        txtTotalgeral.Text = FormatCurrency(moeda(txtValortotalservico.Text) + moeda(txtValortotalpeca.Text) - moeda(txtDesconto.Text))

    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        wcpagina = 1
        If PrintDocument1.PrintController.IsPreview = False Then
            PrintDialog1.ShowDialog()
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim MYFONT As New Font("ARIAL", 8)
        Dim MYFONT3 As New Font("ARIAL", 10, FontStyle.Bold)
        Dim MYFONT2 As New Font("ARIAL", 12, FontStyle.Bold)
        Dim Pulou As Boolean = False

        Dim X1 As Single = e.MarginBounds.Left ' Variavel que controla a coluna
        Dim Y1 As Single = e.MarginBounds.Top  ' Variavel que controla a linha
        Dim Line As Single = MYFONT.GetHeight(e.Graphics) ' Pega o tamanho da linha a ser adicionada quando usar a myfont
        Dim Line2 As Single = MYFONT2.GetHeight(e.Graphics) ' Pega o tamanho da
        Dim Line3 As Single = MYFONT3.GetHeight(e.Graphics) ' Pega o tamanho da

        wcimagem = Image.FromFile("C:\Documents and Settings\Administrador\Meus documentos\Técnico\2º Período\VB.net\Oficina Mecânica\Oficina Mecânica\drag.png")
        e.Graphics.DrawImage(wcimagem, X1, Y1 - 30, 50, 50)
        e.Graphics.DrawString("Oficina Mecânica", MYFONT2, Brushes.Black, X1 + 100, Y1)
        Y1 += Line2
        e.Graphics.DrawString("Relatório de Clientes", MYFONT3, Brushes.Black, X1 + 100, Y1)
        Y1 += Line2
        e.Graphics.DrawString("Número do Orcamento", MYFONT3, Brushes.Black, X1, Y1)
        e.Graphics.DrawString("Data", MYFONT3, Brushes.Black, X1 + 180, Y1)
        e.Graphics.DrawString("Clientes", MYFONT3, Brushes.Black, X1 + 300, Y1)
        e.Graphics.DrawString("Funcionário", MYFONT3, Brushes.Black, X1 + 400, Y1)
        Y1 += Line3
        e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
        Y1 += Line3
        e.Graphics.DrawString("Serviço", MYFONT3, Brushes.Black, X1, Y1 + 20)
        e.Graphics.DrawString("Valor Serviço", MYFONT3, Brushes.Black, X1 + 180, Y1 + 20)
        e.Graphics.DrawString("Desconto", MYFONT3, Brushes.Black, X1 + 300, Y1 + 20)
        e.Graphics.DrawString("Valor Total", MYFONT3, Brushes.Black, X1 + 400, Y1 + 20)
        e.Graphics.DrawLine(Pens.Black, X1, Y1 + 60, X1 + 600, Y1 + 60)
        e.Graphics.DrawString("Peças", MYFONT3, Brushes.Black, X1, Y1 + 70)
        e.Graphics.DrawString("Valor Unitário", MYFONT3, Brushes.Black, X1 + 180, Y1 + 70)
        e.Graphics.DrawString("Quantidade", MYFONT3, Brushes.Black, X1 + 300, Y1 + 70)
        e.Graphics.DrawString("Valor Peças Total", MYFONT3, Brushes.Black, X1 + 400, Y1 + 70)
        While tbOrcamento.EOF = False
            e.Graphics.DrawString(tbOrcamento.Fields("nrorcamento").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
            e.Graphics.DrawString(Microsoft.VisualBasic.Left(tbOrcamento.Fields("data").Value.ToString, 30), MYFONT, Brushes.Black, X1 + 180, Y1)
            e.Graphics.DrawString(tbOrcamento.Fields("cliente").Value.ToString, MYFONT, Brushes.Black, X1 + 300, Y1)
            e.Graphics.DrawString(tbOrcamento.Fields("funcionario").Value.ToString, MYFONT, Brushes.Black, X1 + 400, Y1)
            e.Graphics.DrawString(tbOrcamento.Fields("servico").Value.ToString, MYFONT, Brushes.Black, X1, Y1 + 40)
            e.Graphics.DrawString(Microsoft.VisualBasic.Left(tbOrcamento.Fields("valorservico").Value.ToString, 30), MYFONT, Brushes.Black, X1 + 180, Y1 + 40)
            e.Graphics.DrawString(tbOrcamento.Fields("desconto").Value.ToString, MYFONT, Brushes.Black, X1 + 300, Y1 + 40)
            e.Graphics.DrawString(tbOrcamento.Fields("valortotal").Value.ToString, MYFONT, Brushes.Black, X1 + 400, Y1 + 40)
            e.Graphics.DrawString(tbOrcamento.Fields("pecas").Value.ToString, MYFONT, Brushes.Black, X1 + 5, Y1 + 90)
            e.Graphics.DrawString(Microsoft.VisualBasic.Left(tbOrcamento.Fields("valorunitariopeca").Value.ToString, 30), MYFONT, Brushes.Black, X1 + 185, Y1 + 90)
            e.Graphics.DrawString(tbOrcamento.Fields("quantidade").Value.ToString, MYFONT, Brushes.Black, X1 + 305, Y1 + 90)
            e.Graphics.DrawString(tbOrcamento.Fields("valortotalpeca").Value.ToString, MYFONT, Brushes.Black, X1 + 405, Y1 + 90)

            Y1 += Line2
            e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
            Y1 += Line2
            tbOrcamento.MoveNext()
            If Y1 >= e.MarginBounds.Bottom - 100 Then
                Pulou = True
                Exit While
            End If
        End While
            If Pulou Then
                e.HasMorePages = True
                Y1 = e.MarginBounds.Bottom
                e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
                Y1 += Line
                e.Graphics.DrawString("Página:" & wcpagina, MYFONT2, Brushes.Black, X1, Y1)
                wcpagina += 1
            End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "Select * from tbOrcamento where nrorcamento <> '' order by nrseq"
        tbOrcamento = OpenRecordset(sql)
        If tbOrcamento.RecordCount = 0 Then
            MsgBox("Não existem clientes !")
            Exit Sub
        End If
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If txtNumero.Text = "" Then
            MsgBox("Digite um Orçamento válido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "Select * from tbOrcamento where nrorcamento = " & txtNumero.Text
        tbOrcamento = OpenRecordset(sql)
        If tbOrcamento.RecordCount = 0 Then
            MsgBox("Não existem clientes com o Orçamento digitado !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtData.Text = tbOrcamento.Fields("data").Value.ToString
        cboClientes.Text = tbOrcamento.Fields("cliente").Value.ToString
        cboFuncionario.Text = tbOrcamento.Fields("funcionario").Value.ToString
        txtValortotalservico.Text = tbOrcamento.Fields("valorservico").Value.ToString
        txtValortotalpeca.Text = tbOrcamento.Fields("valorpeca").Value.ToString
        txtDesconto.Text = tbOrcamento.Fields("desconto").Value.ToString
        txtTotalgeral.Text = tbOrcamento.Fields("totalgeral").Value.ToString
        cbxAprovado.Text = tbOrcamento.Fields("aprovado").Value.ToString
        If MsgBox("Tem Certeza Que Deseja Excluir o Orçamento ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            sql = "delete from tbOrcamento where nrorcamento = " & txtNumero.Text
            tbOrcamento = OpenRecordset(sql)
        End If
        limpar()
        txtNumero.Focus()
    End Sub
End Class