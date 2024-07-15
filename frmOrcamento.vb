Public Class frmOrcamento
    Dim classeOcamento As New clsOrcamento, x, wcpagina As Integer, wcimagem As Image, existe As Boolean
    Private Sub frmOrcamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        classeOcamento.PreencheServico(dgvServico, Val(txtNumero.Text))
        classeOcamento.PreencherPeca(dgvPeca, Val(txtNumero.Text))
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        btnSalvar.Enabled = True
        btnNovo.Enabled = False
        classeOcamento.ObterCodigoOrcamento()
        txtNumero.Enabled = False
        txtData.Text = Date.Now.Date
        cbxAprovado.Checked = False
        cbxAprovado.Enabled = False
        cboClientes.Focus()
    End Sub

    Private Sub btnOkservico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkservico.Click
        classeOcamento.SalvarServico(Val(txtNumero.Text), Date.Now.Date, cboClientes.Text, cboFuncionario.Text, cboServico.Text, moeda(txtTotalservico.Text))
        txtTotalservico.Text = ""
        cboServico.Text = ""
        cboServico.Focus()
        classeOcamento.PreencheServico(dgvServico, Val(txtNumero.Text))
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        classeOcamento.SalvarOrcamento(Val(txtNumero.Text), Date.Now.Date)

        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        limpar()
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        '  nrorcamento.ConsultaOrcamento(d)
    End Sub

    Private Sub btnAprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprovar.Click

        Dim MsgResult As DialogResult = MessageBox.Show("Deseja aprovar o orçamento ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            classeOcamento.Aprovar(Val(txtNumero.Text))
        Else
            Exit Sub
        End If
        limpar()
    End Sub

    Private Sub limpar()
        dgvServico.Rows.Clear()
        dgvPeca.Rows.Clear()
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
    Private Sub txtQuantidadepeca_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantidadepeca.LostFocus
        txtTotalpeca.Text = FormatCurrency(txtValorpeca.Text * txtQuantidadepeca.Text)
    End Sub

    Private Sub btnExcluirservico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirservico.Click
        er.Clear()
        If txtNumero.Text = "" Then
            With dgvServico
                existe = False
                For x = 0 To .Rows.Count - 1
                    If .Item(0, x).Value = True Then
                        existe = True
                    End If
                Next
                If existe = False Then
                    er.SetError(dgvServico, "Por favor selecione ao menos uma linha para excluir !")
                    Exit Sub
                End If
                If MsgBox("Confirma a exclusão das linhas selecionadas ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
                For x = 0 To .Rows.Count - 1
                    If .Item(0, x).Value = True Then
                        '        classeOcamento.ExcluirPecas(Val(txtNumero.Text), Item(0, x).Value)
                    End If
                Next

            End With
        Else
            MessageBox.Show("Favor informa um orçamento!  ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        limpar()
        classeOcamento.PreencherPeca(dgvServico, Val(txtNumero.Text))
    End Sub

    Private Sub btnExcluirpeca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirpeca.Click
        er.Clear()
        If txtNumero.Text = "" Then
            With dgvPeca
                existe = False
                For x = 0 To .Rows.Count - 1
                    If .Item(0, x).Value = True Then
                        existe = True
                    End If
                Next
                If existe = False Then
                    er.SetError(dgvPeca, "Por favor selecione ao menos uma linha para excluir !")
                    Exit Sub
                End If
                If MsgBox("Confirma a exclusão das linhas selecionadas ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
                For x = 0 To .Rows.Count - 1
                    If .Item(0, x).Value = True Then
                        '        classeOcamento.Excluirservico(Val(txtNumero.Text), Item(0, x).Value)
                    End If
                Next

            End With
        Else
            MessageBox.Show("Favor informa um orçamento!  ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        limpar()
        classeOcamento.PreencheServico(dgvServico, Val(txtNumero.Text))
    End Sub

    Private Sub txtDesconto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesconto.GotFocus
        txtTotalgeral.Text = FormatCurrency(moeda(txtValortotalservico.Text) + moeda(txtValortotalpeca.Text) - moeda(txtDesconto.Text))

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Deseja aprovar o orçamento ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            classeOcamento.ExcluirOrcamento(Val(txtNumero.Text))
        Else
            Exit Sub
        End If
        limpar()
        txtNumero.Focus()
    End Sub
End Class