Public Class frmUsuarios
    Dim ClasseUsuario As New clsUsuario
    Dim x, wcpagina As Integer
    Dim wcimagem As Image

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseUsuario.ConsultaUsuario(dgvUsuario, Val(lblCodigo.Text), txtUsuario.Text)
        txtUsuario.Focus()
    End Sub
    Private Sub limpar()
        dgvUsuario.Rows.Clear()
        txtCod.Text = ""
        txtUsuario.Text = ""
        txtSenha.Text = ""
        cboPermissao.Text = ""
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja salvar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.SalvarUsuario(txtUsuario.Text, cboPermissao.Text, txtSenha.Text, txtSenha.Text)
            ClasseUsuario.ConsultaUsuario(dgvUsuario, Val(lblCodigo.Text), txtUsuario.Text)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.AlterarUsuario(Val(lblCodigo.Text), txtUsuario.Text, cboPermissao.Text, txtSenha.Text, txtSenha.Text)
            ClasseUsuario.ConsultaUsuario(dgvUsuario, Val(lblCodigo.Text), txtUsuario.Text)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.ExcluirUsuario(Val(lblCodigo.Text))
            ClasseUsuario.ConsultaUsuario(dgvUsuario, Val(lblCodigo.Text), txtUsuario.Text)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseUsuario.ConsultaUsuario(dgvUsuario, 0, txtUsuario.Text)
    End Sub

End Class