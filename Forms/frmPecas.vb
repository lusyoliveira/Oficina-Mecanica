Public Class frmPecas
    Dim ClassePecas As New clsPecas
    Dim x, wcpagina As Integer
    Dim wcimagem As Image
    Private Sub frmPecas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClassePecas.PesquisaPecas(dgvPeca, Val(txtCodigo.Text), txtDescricao.Text)
    End Sub
    Private Sub limpar()
        dgvPeca.Rows.Clear()
        txtCodigo.Text = ""
        txtDescricao.Text = ""
        txtValor.Text = ""
        txtModelo.Text = ""
        txtTipo.Text = ""
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja salvar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClassePecas.SalvarPeca(txtDescricao.Text, txtValor.Text, txtModelo.Text, txtTipo.Text)
        Else
            Exit Sub
        End If
        ClassePecas.PesquisaPecas(dgvPeca, Val(txtCodigo.Text), txtDescricao.Text)
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClassePecas.AlterarPeca(Val(txtCodigo.Text), txtDescricao.Text, txtValor.Text, txtModelo.Text, txtTipo.Text)
        Else
            Exit Sub
        End If
        ClassePecas.PesquisaPecas(dgvPeca, Val(txtCodigo.Text), txtDescricao.Text)
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClassePecas.ExcluirPeca(Val(txtCodigo.Text))
        Else
            Exit Sub
        End If
        ClassePecas.PesquisaPecas(dgvPeca, Val(txtCodigo.Text), txtDescricao.Text)
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClassePecas.PesquisaPecas(dgvPeca, Val(txtCodigo.Text), txtDescricao.Text)
    End Sub

End Class