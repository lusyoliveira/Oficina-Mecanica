Public Class frmClientes
    Dim ClasseClientes As New clsClientes
    Dim x, wcpagina As Integer
    Dim wcimagem As Image
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

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseClientes.ConsultaCliente(Grade, Val(lblCodigo.Text), txtNome.Text)
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja salvar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.SalvarCliente(Val(lblCodigo.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, mkdTelefone.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        txtCodigo.Text = ClasseClientes.ObterCodigoCliente()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.AlterarCliente(Val(lblCodigo.Text), txtNome.Text, txtEndereco.Text, txtBairro.Text, mkdTelefone.Text)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.ExcluirCliente(Val(lblCodigo.Text))
        Else
            Exit Sub
        End If
    End Sub

    Private Sub gpbClientes_Enter(sender As Object, e As EventArgs) Handles gpbClientes.Enter

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseClientes.ConsultaCliente(Grade, Val(lblCodigo.Text), txtNome.Text)
    End Sub

End Class
