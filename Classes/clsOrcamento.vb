Imports System.Data.SqlClient
Imports System.Text

Public Class clsOrcamento
    Dim ClasseConexao As New clsConexao, tbOrcamento, tbOrcamentoPecas, tbOrcamentoServico, tbClientes, TbPecas, TbFuncionarios, tbServico As New DataTable()
#Region "PROPRIEDADES"
    Private Property _CodOrcamento As Integer
    Public Property CodOrcamento As Integer
        Get
            Return _CodOrcamento
        End Get
        Set(value As Integer)
            _CodOrcamento = value
        End Set
    End Property
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
    Public Sub ObterOrcamento(ByRef DadosOrcamento As clsOrcamento, sql As String)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Using CMD = New SqlCommand(sql, cn)
                    Using RDR As SqlDataReader = CMD.ExecuteReader()
                        While RDR.Read()
                            DadosOrcamento._CodOrcamento = RDR.Item("Codigo")
                        End While
                        RDR.Close()
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Não foi possível realizar obter orçamento!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub
    Public Sub SalvarOrcamento(Cliente As Integer, Funcionario As Integer, ValorServico As Decimal, ValorPecas As Decimal, Total As Decimal, Desconto As Decimal, Aprovado As Boolean)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim Sql As String = "INSERT INTO tbOrcamento (DataOrcamento,Cliente,Funcionario,ValorServico,ValorPeca,Total,Desconto, Aprovado) VALUES (GETDATE(),@Cliente,@Funcionario,@ValorServico,@ValorPecas,@Total,@Desconto, @Aprovado)"
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@cliente", Cliente)
                    command.Parameters.AddWithValue("@funcionario", Funcionario)
                    command.Parameters.AddWithValue("@ValorServico", ValorServico)
                    command.Parameters.AddWithValue("@ValorPecas", ValorPecas)
                    command.Parameters.AddWithValue("@Total", Total)
                    command.Parameters.AddWithValue("@Desconto", Desconto)
                    command.Parameters.AddWithValue("@Aprovado", Aprovado)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o orçamento!" & ex.Message)
        End Try
    End Sub
    Public Sub PreencherServico(Grid As DataGridView, CodOrcamento As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM CsOrcamentoservico WHERE nrorcamento = @CodOrcamento"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodOrcamento", CodOrcamento)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbServico)
                        If tbServico.Rows.Count > 0 Then

                            ' Limpa as colunas existentes no DataGridView
                            Grid.Columns.Clear()
                            ' Configura o DataGridView para exibir os dados
                            Grid.DataSource = tbServico
                        Else
                            ' Se nenhum dado for encontrado, limpa o DataGridView e exibe uma mensagem
                            Grid.DataSource = Nothing
                            Exit Sub
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o serviço do orçamento: " & ex.Message)
        End Try
    End Sub
    Public Sub SalvarServico(nrorcamento As Integer, servico As Integer, valortotal As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim Sql As String = "INSERT INTO tbOrcamentoServico (nrorcamento,servico,valortotal) VALUES (@nrorcamento,@servico,@valortotal)"
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    command.Parameters.AddWithValue("@servico", servico)
                    command.Parameters.AddWithValue("@valortotal", valortotal)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar serviço " & ex.Message)
        End Try
    End Sub
    Public Sub PreencherPeca(Grid As DataGridView, CodOrcamento As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM CsOrcamentoPecas WHERE NrOrcamento = @CodOrcamento"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodOrcamento", CodOrcamento)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(TbPecas)
                        If TbPecas.Rows.Count > 0 Then

                            ' Limpa as colunas existentes no DataGridView
                            Grid.Columns.Clear()
                            ' Configura o DataGridView para exibir os dados
                            Grid.DataSource = TbPecas
                        Else
                            ' Se nenhum dado for encontrado, limpa o DataGridView e exibe uma mensagem
                            Grid.DataSource = Nothing
                            Exit Sub
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o peça do orçamento: " & ex.Message)
        End Try
    End Sub
    Public Sub SalvarPecas(nrorcamento As Integer, Peca As Integer, ValorUnitario As Decimal, Quantidade As Integer, valortotal As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim Sql As String = "INSERT INTO tbOrcamentoPecas(nrorcamento,Peca,ValorUnitario,Quantidade,ValorTotal) VALUES (@nrorcamento,@Peca,@ValorUnitario,@Quantidade,@valortotal)"
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    command.Parameters.AddWithValue("@Peca", Peca)
                    command.Parameters.AddWithValue("@ValorUnitario", ValorUnitario)
                    command.Parameters.AddWithValue("@Quantidade", Quantidade)
                    command.Parameters.AddWithValue("@valortotal", valortotal)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar serviço " & ex.Message)
        End Try
    End Sub
    Public Sub Aprovar(nrorcamento As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim Sql As String = "UPDATE tbOrcamento SET aprovado = 1 WHERE nrorcamento = @nrorcamento"
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@nrorcamento", nrorcamento)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao aprovar o orçamento!" & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirPecas(CodOrcamento As Integer, Optional CodPecas As Integer = 0)
        Dim Sql As String
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                If CodPecas = 0 Then
                    Sql = "DELETE FROM tbOrcamentoPecas WHERE nrorcamento = @CodOrcamento"
                Else
                    Sql = "DELETE FROM tbOrcamentoPecas WHERE nrorcamento = @CodOrcamento AND Codigo = @CodPecas"
                End If
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@CodOrcamento", CodOrcamento)
                    command.Parameters.AddWithValue("@CodPecas", CodPecas)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir a peça!" & ex.Message)
        End Try
    End Sub
    Public Sub ExcluirServico(CodOrcamento As Integer, Optional CodServico As Integer = 0)
        Dim Sql As String

        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                If CodServico = 0 Then
                    Sql = "DELETE FROM tbOrcamentoServico WHERW nrorcamento = @CodOrcamento"
                Else
                    Sql = "DELETE FROM tbOrcamentoServico WHERE nrorcamento = @CodOrcamento AND Codigo = @CodPecas"
                End If
                Using command As New SqlCommand(Sql, connection)
                    command.Parameters.AddWithValue("@CodOrcamento", CodOrcamento)
                    command.Parameters.AddWithValue("@CodServico", CodServico)
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
                Dim Sql As String = "DELETE FROM tbOrcamento WHERE nrorcamento = @nrorcamento"
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
#Region "FUNÇÕES"
    Public Function PesquisaOrcamento(Grid As DataGridView, nrorcamento As Integer) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM CsOrcamento WHERE 1=1 ")

                If nrorcamento <> 0 Then
                    sql.AppendLine("AND Codigo = @nrorcamento")
                End If
                sql.AppendLine("ORDER BY Codigo")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If nrorcamento <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", nrorcamento)
                    End If

                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbOrcamento)

                        If tbOrcamento.Rows.Count > 0 Then

                            ' Limpa as colunas existentes no DataGridView
                            Grid.Columns.Clear()
                            ' Configura o DataGridView para exibir os dados
                            Grid.DataSource = tbOrcamento
                        Else
                            ' Se nenhum dado for encontrado, limpa o DataGridView e exibe uma mensagem
                            Grid.DataSource = Nothing
                            MessageBox.Show("Nenhum orçamento encontrado com os critérios fornecidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Public Function CalcularOrcamento(GridServico As DataGridView, GridPecas As DataGridView, Desconto As Decimal) As (TotalServico As Decimal, TotalPecas As Decimal, TotalGeral As Decimal)
        Dim TotalServico, TotalPecas, TotalGeral As Decimal

        TotalServico = 0
        TotalPecas = 0
        TotalGeral = 0

        For Each colServ As DataGridViewRow In GridServico.Rows
            TotalServico += Convert.ToDecimal(colServ.Cells(2).Value)
        Next

        For Each colPec As DataGridViewRow In GridPecas.Rows
            TotalPecas += Convert.ToDecimal(colPec.Cells(4).Value)
        Next

        TotalGeral = (TotalPecas + TotalServico) - Desconto

        Return (TotalServico, TotalPecas, TotalGeral)
    End Function
#End Region
End Class
