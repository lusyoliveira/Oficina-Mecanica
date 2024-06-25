Public Class frmVeiculos
    Dim sql As String
    Dim tbVeiculos As ADODB.Recordset
    Dim x, wcpagina As Integer
    Dim wcimagem As Image
    Private Sub limpar()
        Grade.Rows.Clear()
        txtCodigo.Text = ""
        txtPlacaletra.Text = ""
        txtPlacanumero.Text = ""
        txtAno.Text = ""
        txtModelo.Text = ""
        txtCombustivel.Text = ""
        txtChassiss.Text = ""
        txtRenavan.Text = ""
    End Sub
    Private Sub montargrade()
        With Grade
            .Rows.Clear()
            sql = "Select * from tbVeiculos order by codigo "
            tbveiculos = OpenRecordset(sql)
            If tbveiculos.RecordCount <> 0 Then
                tbveiculos.MoveFirst()
                x = 0
                While tbveiculos.EOF = False
                    .Rows.Add(False)
                    .Item(0, x).Value = tbveiculos.Fields("codigo").Value.ToString
                    .Item(1, x).Value = tbveiculos.Fields("placalt").Value.ToString
                    .Item(2, x).Value = tbVeiculos.Fields("placanr").Value.ToString
                    .Item(3, x).Value = tbveiculos.Fields("modelo").Value.ToString
                    .Item(4, x).Value = tbveiculos.Fields("ano").Value.ToString
                    .Item(5, x).Value = tbveiculos.Fields("combustivel").Value.ToString
                    .Item(6, x).Value = tbVeiculos.Fields("chassiss").Value.ToString
                    .Item(7, x).Value = tbVeiculos.Fields("renavan").Value.ToString
                    x += 1
                    tbveiculos.MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        sql = "update tbVeiculos set placalt = '" & txtPlacaletra.Text & "', placanr = " & txtPlacanumero.Text & ", modelo = '" & txtModelo.Text & "', ano = " & txtAno.Text & ", combustivel = '" & txtCombustivel.Text & "', chassis = " & txtChassiss.Text & ", renvan = " & txtRenavan.Text & " where codigo = " & txtCodigo.Text
        tbveiculos = OpenRecordset(sql)
        MsgBox("Peça gravada com sucesso !", MsgBoxStyle.Information)
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        limpar()
        txtPlacaletra.Focus()
        montargrade()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        sql = "insert into tbVeiculos (placalt,placanr) values ('" & txtPlacaletra.Text & "', '" & txtPlacanumero.Text & "')"
        tbveiculos = OpenRecordset(sql)
        sql = "select * from tbVeiculos order by codigo desc"
        tbveiculos = OpenRecordset(sql)
        tbveiculos.MoveFirst()
        txtCodigo.Text = tbveiculos.Fields("codigo").Value.ToString
        txtModelo.Focus()
    End Sub



    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If txtCodigo.Text = "" Then
            MsgBox("Digite um codigo válido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "Select * from tbVeiculos where codigo = " & txtCodigo.Text
        tbveiculos = OpenRecordset(sql)
        If tbveiculos.RecordCount = 0 Then
            MsgBox("Não existem clientes com o codigo digitado !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtPlacaletra.Text = tbVeiculos.Fields("placalt").Value.ToString
        txtPlacanumero.Text = tbVeiculos.Fields("placanr").Value.ToString
        txtModelo.Text = tbveiculos.Fields("modelo").Value.ToString
        txtAno.Text = tbVeiculos.Fields("ano").Value.ToString
        txtCombustivel.Text = tbVeiculos.Fields("combustivel").Value.ToString
        txtChassiss.Text = tbVeiculos.Fields("chassiss").Value.ToString
        txtRenavan.Text = tbVeiculos.Fields("renavan").Value.ToString
        If MsgBox("Tem Certeza Que Deseja Excluir o veículo ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            sql = "delete from tbVeiculos where codigo = " & txtCodigo.Text
            tbVeiculos = OpenRecordset(sql)
        End If
        limpar()
        txtPlacaletra.Focus()
        montargrade()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If txtCodigo.Text = "" Then
            MsgBox("Digite um codigo válido !", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "Select * from tbVeiculos where codigo = " & txtCodigo.Text
        tbveiculos = OpenRecordset(sql)
        If tbveiculos.RecordCount = 0 Then
            MsgBox("Não existem clientes com o codigo digitado !", MsgBoxStyle.Critical)
            Exit Sub
        End If
        txtPlacaletra.Text = tbVeiculos.Fields("placalt").Value.ToString
        txtPlacanumero.Text = tbVeiculos.Fields("placanr").Value.ToString
        txtModelo.Text = tbVeiculos.Fields("modelo").Value.ToString
        txtAno.Text = tbVeiculos.Fields("ano").Value.ToString
        txtCombustivel.Text = tbVeiculos.Fields("combustivel").Value.ToString
        txtChassiss.Text = tbVeiculos.Fields("chassiss").Value.ToString
        txtRenavan.Text = tbVeiculos.Fields("renavan").Value.ToString
    End Sub

    Private Sub btnImpirmir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpirmir.Click
        sql = "Select * from tbVeiculos where modelo <> '' order by modelo"
        tbveiculos = OpenRecordset(sql)
        If tbveiculos.RecordCount = 0 Then
            MsgBox("Não existem veículos !")
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
        e.Graphics.DrawString("Relatório de Veículos", MYFONT3, Brushes.Black, X1 + 100, Y1)
        Y1 += Line3
        e.Graphics.DrawString("Código", MYFONT3, Brushes.Black, X1, Y1)
        e.Graphics.DrawString("Modelo", MYFONT3, Brushes.Black, X1 + 80, Y1)
        e.Graphics.DrawString("Combustivél", MYFONT3, Brushes.Black, X1 + 300, Y1)
        Y1 += Line3
        e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 600, Y1)
        While tbveiculos.EOF = False
            e.Graphics.DrawString(tbveiculos.Fields("codigo").Value.ToString, MYFONT, Brushes.Black, X1, Y1)
            e.Graphics.DrawString(Microsoft.VisualBasic.Left(tbVeiculos.Fields("modelo").Value.ToString, 30), MYFONT, Brushes.Black, X1 + 80, Y1)
            e.Graphics.DrawString(FormatCurrency(tbVeiculos.Fields("combustivel").Value.ToString), MYFONT, Brushes.Black, X1 + 300, Y1)
            Y1 += Line
            tbveiculos.MoveNext()
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

    Private Sub frmVeiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        montargrade()
    End Sub

    Private Sub gpbVeiculos_Enter(sender As Object, e As EventArgs) Handles gpbVeiculos.Enter

    End Sub

    Private Sub Grade_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grade.CellContentClick

    End Sub
End Class