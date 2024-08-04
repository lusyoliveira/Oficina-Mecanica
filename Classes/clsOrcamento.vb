Imports System.Data.SqlClient
Imports System.Text

Public Class clsOrcamento
    Dim ClasseConexao As New clsConexao, tbOrcamento, tbOrcamento_pecas, tbOrcamento_servico, tbClientes, TbPecas, TbFuncionarios, tbServico As New DataTable()
#Region "PROPRIEDADES"
    Private Property _CodCli As Integer
    Public Property CodCli As Integer
        Get
            Return _CodCli
        End Get
        Set(value As Integer)
            _CodCli = value
        End Set
    End Property
    Private Property _CodFunc As Integer
    Public Property CodFunc As Integer
        Get
            Return _CodFunc
        End Get
        Set(value As Integer)
            _CodFunc = value
        End Set
    End Property
    Private Property _CodServico As Integer
    Public Property CodServico As Integer
        Get
            Return _CodServico
        End Get
        Set(value As Integer)
            _CodServico = value
        End Set
    End Property
    Private Property _CodPeca As Integer
    Public Property CodPeca As Integer
        Get
            Return _CodPeca
        End Get
        Set(value As Integer)
            _CodPeca = value
        End Set
    End Property
#End Region
#Region "METODOS"
    Public Function PesquisaOrcamento(Grade As DataGridView, nrorcamento As Integer) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbOrcamento WHERE 1=1 ")

                If nrorcamento <> 0 Then
                    sql.AppendLine("AND nrorcamento = @nrorcamento")
                End If
                sql.AppendLine("ORDER BY nrorcamento")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If nrorcamento <> 0 Then
                        command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    End If

                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbOrcamento)

                        Dim x As Integer = 0
                        If tbOrcamento.Rows.Count > 0 Then
                            With Grade
                                .Rows.Clear()

                                For Each row As DataRow In tbOrcamento.Rows
                                    .Rows.Add(False)
                                    .Item(0, x).Value = row("nrorcamento").ToString()
                                    .Item(1, x).Value = row("cliente").ToString()
                                    .Item(2, x).Value = row("totalgeral").ToString()
                                    .Item(3, x).Value = row("desconto").ToString()
                                    .Item(4, x).Value = row("data").ToString()
                                    .Item(5, x).Value = row("aprovado").ToString()
                                    x += 1
                                Next
                            End With
                        Else
                            MessageBox.Show("Esse Cliente não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
        Return tbOrcamento
    End Function
    Public Sub SalvarOrcamento(nrorcamento As Integer, data As Date)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim Sql As String = "insert into tbOrcamento (data,nrorcamento) values (@data,@nrorcamento)"
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@data", data)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o orçamento!" & ex.Message)
        End Try
    End Sub
    Public Sub SalvarServico(nrorcamento As Integer, data As Date, cliente As Integer, funcionario As Integer, servico As Integer, valortotal As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim Sql As String = "insert into tbOrcamento_servico (nrorcamento,data,cliente,funcionario,servico,valortotal) values (@nrorcamento,@data,@cliente,@funcionario,@servico,@valortotal)"
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    command.Parameters.AddWithValue("@data", data)
                    command.Parameters.AddWithValue("@cliente", cliente)
                    command.Parameters.AddWithValue("@funcionario", funcionario)
                    command.Parameters.AddWithValue("@servico", servico)
                    command.Parameters.AddWithValue("@valortotal", valortotal)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar serviço " & ex.Message)
        End Try
    End Sub
    Public Function ObterCodigoOrcamento() As String
        Dim codigo As String
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT TOP 1 * FROM tbOrcamento ORDER BY nrorcamento DESC"
                Using command As New SqlCommand(sql, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbOrcamento)

                        If tbOrcamento.Rows.Count > 0 Then
                            ' Obter o código do último cliente
                            codigo = tbOrcamento.Rows(0)("codigo").ToString()
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
        Return codigo
    End Function
    Public Sub Aprovar(nrorcamento As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim Sql As String = "update tbOrcamento Set aprovado = 1 where nrorcamento = @nrorcamento"
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao aprovar o orçamento!" & ex.Message)
        End Try
    End Sub
    Public Function PreencheServico(dgvGrade As DataGridView, nrorcamento As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbOrcamento_servico WHERE nrorcamento = @nrorcamento"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbOrcamento_servico)
                        If tbOrcamento.Rows.Count > 0 Then
                            With dgvGrade
                                .Rows.Clear()
                                For Each row As DataRow In tbOrcamento_servico.Rows
                                    .Rows.Add(False)
                                    Dim x As Integer = .Rows.Count - 1
                                    .Rows(x).Cells(0).Value = row("nrorcamento").ToString()
                                    .Rows(x).Cells(1).Value = row("data").ToString()
                                    .Rows(x).Cells(2).Value = row("cliente").ToString()
                                    .Rows(x).Cells(3).Value = row("funcionario").ToString()
                                    .Rows(x).Cells(4).Value = row("servico").ToString()
                                    .Rows(x).Cells(5).Value = FormatCurrency(row("valortotal"))
                                Next
                            End With
                        Else
                            MessageBox.Show("Esse serviço do orçamento não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o serviço do orçamento: " & ex.Message)
        End Try
        Return tbOrcamento_servico
    End Function

    Public Function PreencherPeca(dgvGrade As DataGridView, nrorcamento As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbOrcamento_pecas WHERE nrorcamento = @nrorcamento"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbOrcamento_pecas)
                        If tbOrcamento_pecas.Rows.Count <> 0 Then
                            With dgvGrade
                                For Each row As DataRow In tbOrcamento_pecas.Rows
                                    .Rows.Add(False)
                                    Dim x As Integer = .Rows.Count - 1
                                    .Rows(x).Cells(0).Value = row("nrorcamento").ToString()
                                    .Rows(x).Cells(1).Value = row("peca").ToString()
                                    .Rows(x).Cells(2).Value = FormatCurrency(row("valorunitario"))
                                    .Rows(x).Cells(3).Value = row("quantidade").ToString()
                                    .Rows(x).Cells(4).Value = FormatCurrency(row("valortotal"))
                                Next
                            End With
                        Else
                            MessageBox.Show("Esse pecas dos orçamento não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar as peças do orçamento: " & ex.Message)
        End Try
        Return tbOrcamento_pecas
    End Function
    Public Sub ExcluirPecas(Pecas As Integer, nrorcamento As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim Sql As String = "delete from tbOrcamento_pecas where nrorcamento = @nrorcamento AND Codigo = @Pecas"
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    command.Parameters.AddWithValue("@Pecas", Pecas)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir a peça!" & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirServico(Servico As Integer, nrorcamento As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim Sql As String = "delete from tbOrcamento_servico where nrorcamento = @nrorcamento AND Codigo = @Servico"
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    command.Parameters.AddWithValue("@Servico", Servico)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o serviço!" & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirOrcamento(nrorcamento As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim Sql As String = "delete from tbOrcamento where nrorcamento = @nrorcamento"
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o orçamento!" & ex.Message)
        End Try
    End Sub
#End Region
End Class
