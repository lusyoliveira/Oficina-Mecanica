Public Class frmFuncionarios
    Dim ClasseFuncionario As New clsEntidades, ClasseCombo As New clsCombo, x, wcpagina As Integer, wcimagem As Image
    Private Sub frmFuncionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseFuncionario.PesquisaEntidade(Grade, Val(lblCodigo.Text), txtNome.Text, "FU")
    End Sub
    Private Sub limpar()
        Grade.Rows.Clear()
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtEstado.Text = ""
        mkdTelefone.Text = ""
        mkdCep.Text = ""
        mkdCpf.Text = ""
        mkdRg.Text = ""
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.SalvarEntidade(txtNome.Text, txtNome.Text, "", "", txtEndereco.Text, "", txtBairro.Text, txtCidade.Text, txtEstado.Text, mkdCep.Text, "", mkdRg.Text, mkdCpf.Text, "", "FU")
            ClasseFuncionario.SalvarContato(Val(lblCodigo.Text), mkdTelefone.Text, "", mkdcelular.Text, "")
            ClasseFuncionario.SalvarCargo(Val(lblCodigo.Text), Val(txtNumero.Text), Val(mkdCarteira.Text), cboCargo.SelectedValue, txtSalario.Text, "")
            limpar()
            ClasseFuncionario.PesquisaEntidade(Grade, Val(lblCodigo.Text), txtNome.Text, "FU")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cboCargo_Enter(sender As Object, e As EventArgs) Handles cboCargo.Enter
        Dim ListaCargo = ClasseCombo.PreencherComboBox("SELECT * FROM tbCargo ORDER BY Cargo", "Codigo", "Cargo")
        With Me.cboCargo
            .DataSource = ListaCargo
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub
    Private Sub cboEstadoCivil_Enter(sender As Object, e As EventArgs) Handles cboEstadoCivil.Enter
        Dim ListaCivil = ClasseCombo.PreencherComboBox("SELECT * FROM tbEstadoCivil ORDER BY Descricao", "Codigo", "Descricao")
        With Me.cboEstadoCivil
            .DataSource = ListaCivil
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.AlterarCargo(Val(lblCodigo.Text), ClasseFuncionario.CodCargo, txtNumero.Text, mkdCarteira.Text, cboCargo.Text, txtSalario.Text, "")
            ClasseFuncionario.AlterarContato(Val(lblCodigo.Text), ClasseFuncionario.CodContato, mkdTelefone.Text, "", mkdcelular.Text, "")
            ClasseFuncionario.AlterarEntidade(Val(lblCodigo.Text), txtNome.Text, txtNome.Text, "", "", txtEndereco.Text, "", txtBairro.Text, txtCidade.Text, txtEstado.Text, mkdCep.Text, "", mkdRg.Text, mkdCpf.Text, "")
            limpar()
            ClasseFuncionario.PesquisaEntidade(Grade, Val(lblCodigo.Text), txtNome.Text, "FU")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a excluir do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.ExcluirCargo(Val(lblCodigo.Text))
            ClasseFuncionario.ExcluirContato(Val(lblCodigo.Text))
            ClasseFuncionario.ExcluirEntidade(Val(lblCodigo.Text))
            limpar()
            ClasseFuncionario.PesquisaEntidade(Grade, Val(lblCodigo.Text), txtNome.Text, "FU")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseFuncionario.PesquisaEntidade(Grade, Val(lblCodigo.Text), txtNome.Text, "FU")
    End Sub


End Class