Public Class frmClientes
    Dim ClasseClientes As New clsEntidades
    Dim x, wcpagina As Integer
    Dim wcimagem As Image
    Private Sub limpar()
        dgvCliente.Rows.Clear()
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

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseClientes.PesquisaEntidade(dgvCliente, Val(lblCodigo.Text), txtNome.Text, "C")
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja salvar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.SalvarEntidade(txtNome.Text, txtNome.Text, "", cboEstadoCivil.Text, txtEndereco.Text, "", txtBairro.Text, txtCidade.Text, txtEstado.Text, mkdCep.Text, "", mkdRg.Text, mkdCpf.Text, "", "C")
            ClasseClientes.SalvarContato(Val(lblCodigo.Text), mkdTelefone.Text, "", mskCel.Text, txtEmail.Text)
            limpar()
            ClasseClientes.PesquisaEntidade(dgvCliente, Val(lblCodigo.Text), txtNome.Text, "C")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.AlterarEntidade(Val(lblCodigo.Text), txtNome.Text, txtNome.Text, mskDnascimento.Text, cboEstadoCivil.Text, txtEndereco.Text, "", txtBairro.Text, txtCidade.Text, txtEstado.Text, mkdCep.Text, "", mkdRg.Text, mkdCpf.Text, "")
            ClasseClientes.AlterarContato(Val(lblCodigo.Text), ClasseClientes.CodContato, mkdTelefone.Text, "", mskCel.Text, txtEmail.Text)
            limpar()
            ClasseClientes.PesquisaEntidade(dgvCliente, Val(lblCodigo.Text), txtNome.Text, "C")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.ExcluirContato(Val(lblCodigo.Text))
            ClasseClientes.ExcluirEntidade(Val(lblCodigo.Text))
            limpar()
            ClasseClientes.PesquisaEntidade(dgvCliente, Val(lblCodigo.Text), txtNome.Text, "C")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub gpbClientes_Enter(sender As Object, e As EventArgs) Handles gpbClientes.Enter

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseClientes.PesquisaEntidade(dgvCliente, Val(lblCodigo.Text), txtNome.Text, "C")
    End Sub

End Class
