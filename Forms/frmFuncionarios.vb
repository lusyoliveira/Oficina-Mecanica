Public Class frmFuncionarios
    Dim ClasseFuncionario As New clsEntidades
    Dim x, wcpagina As Integer
    Dim wcimagem As Image
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
            ClasseFuncionario.SalvarCargo(Val(lblCodigo.Text), txtNumero.Text, mkdCarteira.Text, txtCargo.Text, txtSalario.Text, "")
            limpar()
            ClasseFuncionario.PesquisaEntidade(Grade, Val(lblCodigo.Text), txtNome.Text, "FU")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.AlterarCargo(Val(lblCodigo.Text), ClasseFuncionario.CodCargo, txtNumero.Text, mkdCarteira.Text, txtCargo.Text, txtSalario.Text, "")
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