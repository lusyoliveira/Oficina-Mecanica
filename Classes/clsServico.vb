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
    Private Property _Valor As Decimal
    Public Property Valor As Decimal
        Get
            Return _Valor
        End Get
        Set(value As Decimal)
            _Valor = value
        End Set
    End Property
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function PesquisaServicos(dgvGrade As DataGridView, Codigo As Integer, Peca As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbServicos WHERE 1=1 ")
                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Peca) Then
                    sql.AppendLine("AND Descricao LIKE @Peca")
                End If

                sql.AppendLine("ORDER BY Descricao")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Peca) Then
                        command.Parameters.AddWithValue("@Peca", "%" & Peca & "%")
                    End If
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbServicos)
                    If tbServicos.Rows.Count > 0 Then
                        With dgvGrade
                            .Rows.Clear()
                            For Each row As DataRow In tbServicos.Rows
                                .Rows.Add(False)
                                Dim x As Integer = tbServicos.Rows.Count - 1
                                .Rows(x).Cells(0).Value = row("codigo").ToString()
                                .Rows(x).Cells(1).Value = row("descricao").ToString()
                                .Rows(x).Cells(2).Value = FormatCurrency(row("valor"))
                                .Rows(x).Cells(3).Value = row("modelo").ToString()
                                .Rows(x).Cells(4).Value = row("tipo").ToString()
                            Next
                        End With
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o serviço: " & ex.Message)
        End Try
        Return tbServicos
    End Function
    Public Sub ConsultaServico(CodServico As Integer, ByRef DadosServico As clsServicos)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM tbServicos WHERE Codigo = @CodServico"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@CodServico", CodServico)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DadosServico._CodServico = reader.GetInt32(0)
                            DadosServico._Descricao = reader.GetString(1)
                            DadosServico._Valor = reader.GetDecimal(2)
                        End While
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o serviço: " & ex.Message)
        End Try
    End Sub
    Public Sub SalvarPeca(descricao As String, valor As Decimal, modelo As String, tipo As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbServicos (descricao,valor,modelo,tipo) VALUES (@descricao, @valor, @modelo, @tipo)"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@descricao", descricao)
                    command.Parameters.AddWithValue("@valor", valor)
                    command.Parameters.AddWithValue("@modelo", modelo)
                    command.Parameters.AddWithValue("@tipo", tipo)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Serviço salvo com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar serviço: " & ex.Message)
        End Try
    End Sub
    Public Sub AlterarPeca(Codprod As Integer, descricao As String, valor As Decimal, modelo As String, tipo As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbServicos SET codigo = @codprod, descricao = @descricao, valor = @validavalorde, modelo = @modelo, tipo = @tipo WHERE codprod = @codprod"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codprod", Codprod)
                    command.Parameters.AddWithValue("@descricao", descricao)
                    command.Parameters.AddWithValue("@valor", valor)
                    command.Parameters.AddWithValue("@modelo", modelo)
                    command.Parameters.AddWithValue("@tipo", tipo)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Serviço alterado com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar serviço: " & ex.Message)

        End Try
    End Sub
    Public Sub ExcluirPeca(Codigo As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbServicos WHERE Codigo = @Codigo"
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
