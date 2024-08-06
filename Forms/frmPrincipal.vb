Public Class frmPrincipal

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim frmAbreClientes As New frmClientes()
        frmAbreClientes.MdiParent = Me
        frmAbreClientes.Show()
    End Sub

    Private Sub FuncináriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncináriosToolStripMenuItem.Click
        Dim frmAbreFuncionarios As New frmFuncionarios()
        frmAbreFuncionarios.MdiParent = Me
        frmAbreFuncionarios.Show()
    End Sub

    Private Sub PeçasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeçasToolStripMenuItem.Click
        Dim frmAbrePecas As New frmPecas()
        frmAbrePecas.MdiParent = Me
        frmAbrePecas.Show()
    End Sub

    Private Sub VeículosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VeículosToolStripMenuItem.Click
        Dim frmAbreVeiculos As New frmVeiculos
        frmAbreVeiculos.MdiParent = Me
        frmAbreVeiculos.Show()
    End Sub

    Private Sub FToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FToolStripMenuItem.Click
        Dim frmAbreOrcamento As New frmOrcamento
        frmAbreOrcamento.MdiParent = Me
        frmAbreOrcamento.Show()
    End Sub

    Private Sub NovoUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoUsuárioToolStripMenuItem.Click
        Dim frmAbreUsuarios = New frmUsuarios()
        frmAbreUsuarios.MdiParent = Me
        frmAbreUsuarios.Show()
    End Sub

    Private Sub PermissãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissãoToolStripMenuItem.Click
        Dim frmAbrePermissao As New frmPermissao
        frmAbrePermissao.MdiParent = Me
        frmAbrePermissao.Show()
    End Sub

    Private Sub ConfiguraçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçõesToolStripMenuItem.Click
        Dim frmAbreConfig As New frmConfig
        frmAbreConfig.MdiParent = Me
        frmAbreConfig.Show()
    End Sub

    Private Sub ServiçosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiçosToolStripMenuItem1.Click
        Dim frmAbreServico As New frmServico
        frmAbreServico.MdiParent = Me
        frmAbreServico.Show()
    End Sub
End Class