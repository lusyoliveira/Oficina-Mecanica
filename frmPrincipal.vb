Public Class frmPrincipal

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        'Dim frmAbrePrincipal As New frmClientes()
        'frmAbrePrincipal.MdiParent = Me
        frmClientes.Show()
    End Sub

    Private Sub FuncináriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncináriosToolStripMenuItem.Click
        frmFuncionarios.Show()
    End Sub

    Private Sub PeçasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeçasToolStripMenuItem.Click
        frmPecas.Show()
    End Sub

    Private Sub VeículosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VeículosToolStripMenuItem.Click
        frmVeiculos.Show()
    End Sub

    Private Sub FToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FToolStripMenuItem.Click
        frmOrcamento.Show()
    End Sub

    Private Sub NovoUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoUsuárioToolStripMenuItem.Click
        frmUsuarios.Show()
    End Sub

    Private Sub PermissãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissãoToolStripMenuItem.Click
        frmPermissao.Show()
    End Sub

    Private Sub ConfiguraçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçõesToolStripMenuItem.Click
        frmConfig.Show()
    End Sub

End Class