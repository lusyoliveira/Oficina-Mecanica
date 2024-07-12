Public Class frmFuncionarios
    Dim ClasseFuncionario As New clsFuncionarios
    Dim x, wcpagina As Integer
    Dim wcimagem As Image
    Private Sub frmFuncionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseFuncionario.ConsultaFuncionario(Grade, Val(lblCodigo.Text), txtNome.Text)
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


    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.SalvarFuncionario(txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, mkdCpf.Text, mkdRg.Text, mkdCep.Text, mkdTelefone.Text, txtCargo.Text, txtSalario.Text)
            ClasseFuncionario.ConsultaFuncionario(Grade, Val(lblCodigo.Text), txtNome.Text)
            limpar()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.AlterarFuncionario(lblCodigo.Text, txtNome.Text, txtEndereco.Text, txtBairro.Text, cboCidade.Text, cbouf.Text, mkdCpf.Text, mkdRg.Text, mkdCep.Text, mkdTelefone.Text, txtNumero.Text, mkdcelular.Text, mkdCarteira.Text, txtCargo.Text, txtSalario.Text, mkdPis.Text)
            ClasseFuncionario.ConsultaFuncionario(Grade, Val(lblCodigo.Text), txtNome.Text)
            limpar()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a excluir do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.ExcluirFuncionario(Val(lblCodigo.Text))
            ClasseFuncionario.ConsultaFuncionario(Grade, Val(lblCodigo.Text), txtNome.Text)
            limpar()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseFuncionario.ConsultaFuncionario(Grade, Val(lblCodigo.Text), txtNome.Text)
    End Sub


End Class