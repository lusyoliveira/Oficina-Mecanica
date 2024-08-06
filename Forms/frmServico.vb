Public Class frmServico
    Dim ClasseServico As New clsServicos, tbServicos As New DataTable()
    Private Sub frmServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Limpar()
        txtCodigo.Text = ""
        txtDescricao.Text = ""
        txtValor.Text = ""
        dgvServico.Rows.Clear()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja salvar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseServico.SalvarServico(txtDescricao.Text, txtValor.Text)
        Else
            Exit Sub
        End If
        ClasseServico.PesquisaServicos(dgvServico, Val(txtCodigo.Text))
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseServico.AlterarServico(Val(txtCodigo.Text), txtDescricao.Text, txtValor.Text)
        Else
            Exit Sub
        End If
        ClasseServico.PesquisaServicos(dgvServico, Val(txtCodigo.Text))
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseServico.ExcluirServico(Val(txtCodigo.Text))
        Else
            Exit Sub
        End If
        ClasseServico.PesquisaServicos(dgvServico, Val(txtCodigo.Text))
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        ClasseServico.PesquisaServicos(dgvServico, Val(txtCodigo.Text))
    End Sub
End Class