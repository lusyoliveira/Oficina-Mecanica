Public Class frmClientes
    Dim ClasseClientes As New clsEntidades, ClasseCombo As New clsCombo, x, wcpagina As Integer, wcimagem As Image
    Private Sub Limpar()
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

    Private Sub cboEstadoCivil_Enter(sender As Object, e As EventArgs) Handles cboEstadoCivil.Enter
        Dim ListaCivil = ClasseCombo.PreencherComboBox("SELECT * FROM tbEstadoCivil ORDER BY Descricao", "Codigo", "Descricao")
        With Me.cboEstadoCivil
            .DataSource = ListaCivil
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseClientes.PesquisaEntidade(dgvCliente, Val(lblCodigo.Text), txtNome.Text, "C")
    End Sub

End Class
