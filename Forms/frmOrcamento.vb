Public Class frmOrcamento
    Dim ClasseOrcamento As New clsOrcamento, ClasseCombo As New clsCombo, ClasseServico As New clsServicos, ClassePecas As New clsPecas, x, wcpagina As Integer, wcimagem As Image, existe As Boolean
    Private Sub frmOrcamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseOrcamento.PesquisaOrcamento(dgvOrcamento, Val(txtNumero.Text))
    End Sub
    Private Sub Limpar()
        dgvServico.Rows.Clear()
        dgvPeca.Rows.Clear()
        txtData.Text = ""
        txtDesconto.Text = ""
        txtTotalgeral.Text = ""
        txtNumero.Text = ""
        txtQuantidadePeca.Text = ""
        txtTotalservico.Text = ""
        txtTotalPeca.Text = ""
        txtValorPeca.Text = ""
        cboClientes.Text = ""
        cboServico.Text = ""
        cboPecas.Text = ""
    End Sub
    Private Sub Habilitar()
        txtNumero.Enabled = True
        txtData.Enabled = True
        cboClientes.Enabled = True
        cboFuncionario.Enabled = True
        txtDesconto.Enabled = True
        txtTotalservico.Enabled = True
        txtTotalPeca.Enabled = True
        txtTotalgeral.Enabled = True
        cboServico.Enabled = True
        txtValortotalservico.Enabled = True
        cboPecas.Enabled = True
        txtValorPeca.Enabled = True
        txtQuantidadePeca.Enabled = True
        txtValortotalpeca.Enabled = True
        txtDesconto.Enabled = True
        cbxAprovado.Enabled = True
        cbxDesconto.Enabled = True
        btnAdicionarPeca.Enabled = True
        btnExcluirPeca.Enabled = True
        btnAdicionarSev.Enabled = True
        btnExcluirServico.Enabled = True
    End Sub
    Private Sub Desabilitar()
        txtNumero.Enabled = False
        txtData.Enabled = False
        cboClientes.Enabled = False
        cboFuncionario.Enabled = False
        txtDesconto.Enabled = False
        txtTotalservico.Enabled = False
        txtTotalPeca.Enabled = False
        txtTotalgeral.Enabled = False
        cboServico.Enabled = False
        txtValortotalservico.Enabled = False
        cboPecas.Enabled = False
        txtValorPeca.Enabled = False
        txtQuantidadePeca.Enabled = False
        txtValortotalpeca.Enabled = False
        txtDesconto.Enabled = False
        cbxAprovado.Enabled = False
        cbxDesconto.Enabled = False
        btnAdicionarPeca.Enabled = False
        btnExcluirPeca.Enabled = False
        btnAdicionarSev.Enabled = False
        btnExcluirServico.Enabled = False
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        ClasseOrcamento.ObterOrcamento(ClasseOrcamento, "SELECT CASE WHEN IDENT_CURRENT('Tbl_Orcamento') IS NULL THEN 1 ELSE IDENT_CURRENT('Tbl_Orcamento')+1 END AS Codigo")
        txtNumero.Text = ClasseOrcamento.CodOrcamento
        btnSalvar.Enabled = True
        btnNovo.Enabled = False
        txtNumero.Enabled = False
        cbxAprovado.Checked = False
        cbxAprovado.Enabled = False
        Habilitar()
    End Sub

    Private Sub btnAprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprovar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Deseja aprovar o orçamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MsgResult = DialogResult.Yes Then
            ClasseOrcamento.Aprovar(Val(txtNumero.Text))
            Limpar()
            Desabilitar()
            btnNovo.Enabled = True
            btnExcluir.Enabled = False
            btnSalvar.Enabled = False
            btnAprovar.Enabled = False
        Else
            Exit Sub
        End If
    End Sub
    Private Sub cboFuncionario_Enter(sender As Object, e As EventArgs) Handles cboFuncionario.Enter
        Dim ListaFuncionario = ClasseCombo.PreencherComboBox("SELECT * FROM tbEntidades WHERE Tipo = 'FU' ORDER BY NomeFantasia", "Codigo", "NomeFantasia")
        With Me.cboFuncionario
            .DataSource = ListaFuncionario
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub cboServico_Enter(sender As Object, e As EventArgs) Handles cboServico.Enter
        Dim ListaServico = ClasseCombo.PreencherComboBox("SELECT * FROM tbServico ORDER BY Descricao", "Codigo", "Descricao")
        With Me.cboServico
            .DataSource = ListaServico
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub cboPecas_Enter(sender As Object, e As EventArgs) Handles cboPecas.Enter
        Dim ListaPecas = ClasseCombo.PreencherComboBox("SELECT * FROM tbPecas ORDER BY Descricao", "Codigo", "Descricao")
        With Me.cboPecas
            .DataSource = ListaPecas
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Deseja salvar o orçamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MsgResult = DialogResult.Yes Then
            ClasseOrcamento.SalvarOrcamento(cboClientes.SelectedValue, cboFuncionario.SelectedValue, txtTotalservico.Text, txtTotalPeca.Text, txtTotalgeral.Text, txtDesconto.Text, IIf(cbxAprovado.Checked = True, True, False))
            For Each row As DataGridViewRow In dgvPeca.Rows
                ClasseOrcamento.SalvarPecas(Val(txtNumero.Text), cboPecas.SelectedValue, txtValorPeca.Text, txtQuantidadePeca.Text, txtTotalPeca.Text)
            Next
            For Each row As DataGridViewRow In dgvServico.Rows
                ClasseOrcamento.SalvarServico(Val(txtNumero.Text), cboServico.SelectedValue, txtTotalservico.Text)
            Next
            btnNovo.Enabled = True
            btnExcluir.Enabled = False
            btnSalvar.Enabled = False
            btnAprovar.Enabled = False
            Limpar()
            Desabilitar()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnAdicionarSev_Click(sender As Object, e As EventArgs) Handles btnAdicionarSev.Click
        If Val(txtNumero.Text) = 0 Then
            MessageBox.Show("Favor informar o orçamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf moeda(txtTotalservico.Text) = 0 Then
            MessageBox.Show("Favor informar o valor do serviço!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            dgvServico.Rows.Add(cboServico.SelectedValue, cboServico.Text, txtTotalservico.Text)
            cboServico.Text = ""
            txtTotalservico.Text = 0
        End If
    End Sub

    Private Sub txtQuantidadePeca_Leave(sender As Object, e As EventArgs) Handles txtQuantidadePeca.Leave
        Dim ValorPecas, TotalPecas As Decimal
        Dim Quantidade As Integer = txtQuantidadePeca.Text
        ValorPecas = txtValorPeca.Text
        TotalPecas = 0
        TotalPecas = (ValorPecas * Quantidade)
        txtTotalPeca.Text = TotalPecas
    End Sub

    Private Sub dgvOrcamento_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOrcamento.CellMouseDoubleClick
        txtNumero.Text = dgvOrcamento.CurrentRow.Cells(0).Value
        txtData.Text = dgvOrcamento.CurrentRow.Cells(1).Value
        cboClientes.Text = dgvOrcamento.CurrentRow.Cells(2).Value
        cboFuncionario.Text = dgvOrcamento.CurrentRow.Cells(3).Value
        txtTotalservico.Text = dgvOrcamento.CurrentRow.Cells(4).Value
        txtTotalPeca.Text = dgvOrcamento.CurrentRow.Cells(5).Value
        txtDesconto.Text = dgvOrcamento.CurrentRow.Cells(6).Value
        If dgvOrcamento.CurrentRow.Cells(7).Value = True Then
            cbxAprovado.Checked = True
        Else
            cbxAprovado.Checked = False
        End If
        txtTotalgeral.Text = dgvOrcamento.CurrentRow.Cells(8).Value
        ClasseOrcamento.PreencherPeca(dgvPeca, Val(txtNumero.Text))
        ClasseOrcamento.PreencherServico(dgvServico, Val(txtNumero.Text))
        tcOrcamento.SelectTab(1)
    End Sub

    Private Sub btnAdicionarPeca_Click(sender As Object, e As EventArgs) Handles btnAdicionarPeca.Click
        If Val(txtNumero.Text) = 0 Then
            MessageBox.Show("Favor informar o orçamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf Val(txtQuantidadePeca.Text) = 0 Then
            MessageBox.Show("Favor informar a quantidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf moeda(txtValorPeca.Text) = 0 Or moeda(txtTotalPeca.Text) = 0 Then
            MessageBox.Show("Favor informar o valores!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            dgvPeca.Rows.Add(cboPecas.SelectedValue, cboPecas.Text, txtValorPeca.Text, txtQuantidadePeca.Text, txtTotalPeca.Text)
            txtTotalservico.Text = 0
            cboServico.Text = ""
            cboServico.Focus()
        End If
        Dim result = ClasseOrcamento.CalcularOrcamento(dgvServico, dgvPeca, txtDesconto.Text)
        Dim TotalServico As Decimal = result.Item1
        Dim TotalPecas As Decimal = result.Item2
        Dim TotalGeral As Decimal = result.Item3

        txtTotalservico.Text = TotalServico.ToString("F2")
        txtTotalPeca.Text = TotalPecas.ToString("F2")
        txtTotalgeral.Text = TotalGeral.ToString("F2")

    End Sub
    Private Sub cboServico_Leave(sender As Object, e As EventArgs) Handles cboServico.Leave
        ClasseServico.ObterServico(ClasseServico, "SELECT * FROM tbServico WHERE Codigo = '" & cboServico.SelectedValue & "'")
        txtTotalservico.Text = ClasseServico.ValorUnit
    End Sub
    Private Sub cboPecas_Leave(sender As Object, e As EventArgs) Handles cboPecas.Leave
        ClassePecas.ObterPecas(ClassePecas, "SELECT * FROM tbPecas WHERE Codigo = '" & cboPecas.SelectedValue & "'")
        txtValorPeca.Text = ClassePecas.ValorUnit
    End Sub
    Private Sub cboClientes_Enter(sender As Object, e As EventArgs) Handles cboClientes.Enter
        Dim ListaClientes = ClasseCombo.PreencherComboBox("SELECT * FROM tbEntidades WHERE Tipo = 'C' ORDER BY NomeFantasia", "Codigo", "NomeFantasia")
        With Me.cboClientes
            .DataSource = ListaClientes
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub btnExcluirservico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirServico.Click
        er.Clear()
        If txtNumero.Text = "" Then
            With dgvServico
                existe = False
                For x = 0 To .Rows.Count - 1
                    If Convert.ToBoolean(.Item(0, x).Value) Then
                        existe = True
                    End If
                Next
                If Not existe Then
                    er.SetError(dgvPeca, "Por favor selecione ao menos uma linha para excluir!")
                    Exit Sub
                End If
                If MsgBox("Confirma a exclusão das linhas selecionadas?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
                For x = 0 To .Rows.Count - 1
                    If Convert.ToBoolean(.Item(0, x).Value) Then
                        ' Obtendo o valor da primeira coluna da linha selecionada
                        Dim idPeca As String = .Item(0, x).Value.ToString()
                        ' Passando o valor da primeira coluna e o valor do txtNumero.Text para o método ExcluirPecas
                        ClasseOrcamento.ExcluirPecas(Val(txtNumero.Text), idPeca)
                    End If
                Next
            End With
        Else
            MessageBox.Show("Favor informar um orçamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Limpar()
        ClasseOrcamento.PreencherServico(dgvServico, Val(txtNumero.Text))
    End Sub

    Private Sub btnExcluirpeca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirPeca.Click
        er.Clear()
        If txtNumero.Text = "" Then
            With dgvPeca
                existe = False
                For x = 0 To .Rows.Count - 1
                    If Convert.ToBoolean(.Item(0, x).Value) Then
                        existe = True
                    End If
                Next
                If Not existe Then
                    er.SetError(dgvPeca, "Por favor selecione ao menos uma linha para excluir!")
                    Exit Sub
                End If
                If MsgBox("Confirma a exclusão das linhas selecionadas?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
                For x = 0 To .Rows.Count - 1
                    If Convert.ToBoolean(.Item(0, x).Value) Then
                        ' Obtendo o valor da primeira coluna da linha selecionada
                        Dim idPeca As String = .Item(0, x).Value.ToString()
                        ' Passando o valor da primeira coluna e o valor do txtNumero.Text para o método ExcluirPecas
                        ClasseOrcamento.ExcluirPecas(Val(txtNumero.Text), idPeca)
                    End If
                Next
            End With
        Else
            MessageBox.Show("Favor informar um orçamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Limpar()
        ClasseOrcamento.PreencherPeca(dgvPeca, Val(txtNumero.Text))
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Deseja excluir o orçamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseOrcamento.ExcluirServico(Val(txtNumero.Text))
            ClasseOrcamento.ExcluirPecas(Val(txtNumero.Text))
            ClasseOrcamento.ExcluirOrcamento(Val(txtNumero.Text))
            Limpar()
            Desabilitar()
            btnNovo.Enabled = True
            btnExcluir.Enabled = False
            btnSalvar.Enabled = False
            btnAprovar.Enabled = False
            txtNumero.Focus()
        Else
            Exit Sub
        End If
    End Sub
End Class