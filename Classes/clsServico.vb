Imports System.Data.SqlClient
Imports System.Text
Public Class clsServicos
    Dim ClasseConexao As New clsConexao, tbServicos As New DataTable()
#Region "PROPRIEDADES"
    Private Property _CodServico As Integer
    Public Property CodServico As Integer
        Get
            Return _CodServico
        End Get
        Set(value As Integer)
            _CodServico = value
        End Set
    End Property
    Private Property _Descricao As String
    Public Property Descricao As String
        Get
            Return _Descricao
        End Get
        Set(value As String)
            _Descricao = value
        End Set
    End Property
    Private Property _ValorUnit As Decimal
    Public Property ValorUnit As Decimal
        Get
            Return _ValorUnit
        End Get
        Set(value As Decimal)
            _ValorUnit = value
        End Set
    End Property

#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function PesquisaServicos(Grid As DataGridView, Codigo As Integer) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbServico WHERE 1=1 ")
                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                sql.AppendLine("ORDER BY Descricao")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbServicos)

                    ' Verifica se o DataTable contém registros
                    If tbServicos.Rows.Count > 0 Then
                        ' Limpa as colunas existentes no DataGridView
                        Grid.Columns.Clear()
                        ' Configura o DataGridView para exibir os dados
                        Grid.DataSource = tbServicos
                    Else
                        ' Se nenhum dado for encontrado, limpa o DataGridView e exibe uma mensagem
                        Grid.DataSource = Nothing
                        MessageBox.Show("Nenhum serviço encontrado com os critérios fornecidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o serviço: " & ex.Message)
        End Try
        Return tbServicos
    End Function
    Public Sub ObterServico(ByRef DadosServico As clsServicos, sql As String)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Using CMD = New SqlCommand(sql, cn)
                    Using RDR As SqlDataReader = CMD.ExecuteReader()
                        While RDR.Read()
                            DadosServico._CodServico = RDR.Item("Codigo")
                            DadosServico._Descricao = RDR.Item("Descricao")
                            DadosServico._ValorUnit = RDR.Item("Valor")
                        End While
                        RDR.Close()
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Não foi possível realizar a consulta!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub
    Public Sub SalvarServico(descricao As String, valor As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbServico (descricao,valor) VALUES (@descricao, @valor)"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@descricao", descricao)
                    command.Parameters.AddWithValue("@valor", valor)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Serviço salvo com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar serviço: " & ex.Message)
        End Try
    End Sub
    Public Sub AlterarServico(CodServico As Integer, Descricao As String, valor As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbServico SET descricao = @descricao, valor = @valor WHERE codigo = @CodServico"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodServico", CodServico)
                    command.Parameters.AddWithValue("@descricao", Descricao)
                    command.Parameters.AddWithValue("@valor", valor)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Serviço alterado com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar serviço: " & ex.Message)

        End Try
    End Sub
    Public Sub ExcluirServico(Codigo As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbServico WHERE Codigo = @Codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codigo", Codigo)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Serviço excluído com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir serviço: " & ex.Message)
        End Try
    End Sub

#End Region
End Class
