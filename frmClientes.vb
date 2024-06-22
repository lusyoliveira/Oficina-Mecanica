Public Class frmClientes
    Dim sql As String
    Dim tbClientes As ADODB.Recordset
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
    Private Sub montargrade()
        With Grade
            .Rows.Clear()
            sql = "Select * from tbClientes order by codigo "
            tbClientes = OpenRecordset(sql)
            If tbClientes.RecordCount <> 0 Then
                tbClientes.MoveFirst()
                x = 0
                While tbClientes.EOF = False
                    .Rows.Add(False)
                    .Item(0, x).Value = tbClientes.Fields("codigo").Value.ToString
                    .Item(1, x).Value = tbClientes.Fields("nome").Value.ToString
                    .Item(2, x).Value = tbClientes.Fields("endereco").Value.ToString
                    .Item(3, x).Value = tbClientes.Fields("bairro").Value.ToString
                    .Item(4, x).Value = tbClientes.Fields("cidade").Value.ToString
                    .Item(5, x).Value = tbClientes.Fields("estado").Value.ToString
                    .Item(6, x).Value = tbClientes.Fields("telefone").Value.ToString
                    .Item(7, x).Value = tbClientes.Fields("cep").Value.ToString
                    .Item(8, x).Value = tbClientes.Fields("cpf").Value.ToString
                    .Item(9, x).Value = tbClientes.Fields("rg").Value
                    x += 1
                    tbClientes.MoveNext()
                End While
            End If
        End With
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        montargrade()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        sql = "update tbClientes set nome = '" & txtNome.Text & "', endereco = '" & txtEndereco.Text & "', bairro = '" & txtBairro.Text & "', cidade = '" & txtCidade.Text & "', estado = '" & txtEstado.Text & "', telefone = '" & mkdTelefone.Text & "', cep = '" & mkdCep.Text & "', cpf = '" & mkdCpf.Text & "', rg = '" & mkdRg.Text & "' where codigo = " & txtCodigo.Text
        tbClientes = OpenRecordset(sql)
        MsgBox("Clientes gravado com sucesso !", MsgBoxStyle.Information)
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        limpar()
        txtNome.Focus()
        montargrade()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        sql = "insert into tbClientes (nome) values ('" & txtNome.Text & "')"
        tbClientes = OpenRecordset(sql)
        sql = "select * from tbClientes order by codigo desc"
        tbClientes = OpenRecordset(sql)
        tbClientes.MoveFirst()
        txtCodigo.Text = tbClientes.Fields("codigo").Value.ToString
        txtNome.Focus()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If btnAlterar.Text = "Alterar" Then
            If txtCodigo.Text = "" Then
                MsgBox("Digite um codigo válido !", MsgBoxStyle.Information)
                Exit Sub
            End If
            sql = "Select * from tbClientes where codigo = " & txtCodigo.Text
            tbClientes = OpenRecordset(sql)
            If tbClientes.RecordCount = 0 Then
                MsgBox("Este Código Não Existe !", MsgBoxStyle.Critical)
                Exit Sub
            End If
            txtNome.Text = tbClientes.Fields("nome").Value.ToString
            txtEndereco.Text = tbClientes.Fields("endereco").Value.ToString
            txtBairro.Text = tbClientes.Fields("bairro").Value.ToString
            txtCidade.Text = tbClientes.Fields("cidade").Value.ToString
            txtEstado.Text = tbClientes.Fields("estado").Value.ToString
            mkdTelefone.Text = tbClientes.Fields("telefone").Value.ToString
            mkdCep.Text = tbClientes.Fields("cep").Value.ToString
            mkdCpf.Text = tbClientes.Fields("cpf").Value.ToString
            mkdRg.Text = tbClientes.Fields("rg").Value.ToString
            btnSalvar.Enabled = False
            btnExcluir.Enabled = False
            btnConsultar.Enabled = False
            btnAlterar.Text = "Salvar"
        Else
            sql = "update tbclientes set nome = '" & txtNome.Text & "', endereco = '" & txtEndereco.Text & "', bairro = '" & txtBairro.Text & "', cidade = '" & txtCidade.Text & "', estado = '" & txtEstado.Text & "', telefone = '" & mkdTelefone.Text & "', cep = '" & mkdCep.Text & "', cpf = '" & mkdCpf.Text & "', rg = '" & mkdRg.Text & "' where codigo = " & txtCodigo.Text
            tbClientes = OpenRecordset(sql)
            btnSalvar.Enabled = True
            btnExcluir.Enabled = True
            btnConsultar.Enabled = True
            btnAlterar.Text = "Alterar"
            limpar()
            txtNome.Focus()
            montargrade()
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If txtCodigo.Text = "" Then
            MsgBox("Digite um codigo válido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "Select * from tbClientes where codigo = " & txtCodigo.Text
        tbClientes = OpenRecordset(sql)
        If tbClientes.RecordCount = 0 Then
            MsgBox("Não existem clientes com o codigo digitado !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtNome.Text = tbClientes.Fields("nome").Value.ToString
        txtEndereco.Text = tbClientes.Fields("endereco").Value.ToString
        txtBairro.Text = tbClientes.Fields("bairro").Value.ToString
        txtCidade.Text = tbClientes.Fields("cidade").Value.ToString
        txtEstado.Text = tbClientes.Fields("estado").Value.ToString
        mkdTelefone.Text = tbClientes.Fields("telefone").Value.ToString
        mkdCep.Text = tbClientes.Fields("cep").Value.ToString
        mkdCpf.Text = tbClientes.Fields("cpf").Value.ToString
        mkdRg.Text = tbClientes.Fields("rg").Value.ToString
        If MsgBox("Tem Certeza Que Deseja Excluir o Cliente ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            sql = "delete from tbClientes where codigo = " & txtCodigo.Text
            tbClientes = OpenRecordset(sql)
        End If
        limpar()
        txtNome.Focus()
        montargrade()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If txtCodigo.Text = "" Then
            MsgBox("Digite um codigo válido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "Select * from tbClientes where codigo = " & txtCodigo.Text
        tbClientes = OpenRecordset(sql)
        If tbClientes.RecordCount = 0 Then
            MsgBox("Não existem clientes com o codigo digitado !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtNome.Text = tbClientes.Fields("nome").Value.ToString
        txtEndereco.Text = tbClientes.Fields("endereco").Value.ToString
        txtBairro.Text = tbClientes.Fields("bairro").Value.ToString
        txtCidade.Text = tbClientes.Fields("cidade").Value.ToString
        txtEstado.Text = tbClientes.Fields("estado").Value.ToString
        mkdTelefone.Text = tbClientes.Fields("telefone").Value.ToString
        mkdCep.Text = tbClientes.Fields("cep").Value.ToString
        mkdCpf.Text = tbClientes.Fields("cpf").Value.ToString
        mkdRg.Text = tbClientes.Fields("rg").Value.ToString
    End Sub

    Private Sub btnImpirmir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpirmir.Click
        sql = "Select * from tbClientes where nome <> '' order by nome"
        tbClientes = OpenRecordset(sql)
        If tbClientes.RecordCount = 0 Then
            MsgBox("Não existem clientes !")
            Exit Sub
        End If
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        wcpagina = 1
        If PrintDocument1.PrintController.IsPreview = False Then
            PrintDialog1.ShowDialog()
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim MYFONT As New Font("ARIAL", 8)
        Dim MYFONT3 As New Font("ARIAL", 10, FontStyle.Bold)
        Dim MYFONT2 As New Font("ARIAL", 12, FontStyle.Bold)
        Dim Pulou As Boolean = False

        Dim X1 As Single = e.MarginBounds.Left ' Variavel que controla a coluna
        Dim Y1 As Single = e.MarginBounds.Top  ' Variavel que controla a linha
        Dim Line As Single = MYFONT.GetHeight(e.Graphics) ' Pega o tamanho da linha a ser adicionada quando usar a myfont
        Dim Line2 As Single = MYFONT2.GetHeight(e.Graphics) ' Pega o tamanho da
        Dim Line3 As Single = MYFONT3.GetHeight(e.Graphics) ' Pega o tamanho da

        wcimagem = Image.FromFile("C:\Documents and Settings\Administrador\Meus documentos\Técnico\2º Período\VB.net\Oficina Mecânica\Oficina Mecânica\drag.png")
        e.Graphics.DrawImage(wcimagem, X1, Y1 - 30, 50, 50)
        e.Graphics.DrawString("Oficina Mecânica", MYFONT2, Brushes.Black, X1 + 100, Y1)
        Y1 += Line2
        e.Graphics.DrawString("Relatório de Clientes", MYFONT3, Brushes.Black, X1 + 100, Y1)
        Y1 += Line3
        e.Graphics.DrawString("Matrícula", MYFONT3, Brushes.Black, X1, Y1)
        e.Graphics.DrawString("Nome", MYFONT3, Brushes.Black, X1 + 80, Y1)
        e.Graphics.DrawString("Endereço", MYFONT3, Brushes.Black, X1 + 300, Y1)
        Y1 += Line3
        e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
        While tbClientes.EOF = False
            e.Graphics.DrawString(tbClientes.Fields("codigo").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
            e.Graphics.DrawString(Microsoft.VisualBasic.Left(tbClientes.Fields("nome").Value.ToString, 30), MYFONT, Brushes.Black, X1 + 80, Y1)
            e.Graphics.DrawString(tbClientes.Fields("endereco").Value.ToString, MYFONT, Brushes.Black, X1 + 300, Y1)
            Y1 += Line
            tbClientes.MoveNext()
            If Y1 >= e.MarginBounds.Bottom - 100 Then
                Pulou = True
                Exit While
            End If
        End While
        If Pulou Then
            e.HasMorePages = True
            Y1 = e.MarginBounds.Bottom
            e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
            Y1 += Line
            e.Graphics.DrawString("Página:" & wcpagina, MYFONT2, Brushes.Black, X1, Y1)
            wcpagina += 1
        End If
    End Sub
End Class
