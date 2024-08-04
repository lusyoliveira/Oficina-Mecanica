Public Class frmVeiculos
    Dim ClasseVeiculos As New clsVeiculos
    Private Sub limpar()
        dgvVeiculos.Rows.Clear()
        txtCodigo.Text = ""
        txtPlacaletra.Text = ""
        txtPlacanumero.Text = ""
        txtAno.Text = ""
        txtModelo.Text = ""
        txtCombustivel.Text = ""
        txtChassiss.Text = ""
        txtRenavan.Text = ""
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja salvar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseVeiculos.SalvarVeiculos(txtPlacaletra.Text, txtPlacanumero.Text, txtModelo.Text, txtAno.Text, txtCombustivel.Text, txtChassiss.Text, txtRenavan.Text)
        Else
            Exit Sub
        End If
        ClasseVeiculos.ConsultaVeiculos(dgvVeiculos, Val(txtCodigo.Text))
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Tem Certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseVeiculos.ExcluirVeiculos(Val(txtCodigo.Text))
        Else
            Exit Sub
        End If
        ClasseVeiculos.ConsultaVeiculos(dgvVeiculos, Val(txtCodigo.Text))
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseVeiculos.ConsultaVeiculos(dgvVeiculos, Val(txtCodigo.Text))

    End Sub

    Private Sub frmVeiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseVeiculos.ConsultaVeiculos(dgvVeiculos, Val(txtCodigo.Text))
    End Sub

End Class