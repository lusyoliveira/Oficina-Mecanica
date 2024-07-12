Imports System.Data.SqlClient
Imports System.Text
Public Class clsClientes
    Dim ClasseConexao As New clsConexao, tbClientes, TbDependentes As New DataTable()
#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaCliente(Grade As DataGridView, Codigo As Integer, Nome As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbClientes WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Nome) Then
                    sql.AppendLine("AND Nome LIKE @Nome")
                End If

                sql.AppendLine("ORDER BY Nome")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Nome) Then
                        command.Parameters.AddWithValue("@Nome", "%" & Nome & "%")
                    End If
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbClientes)

                        Dim x As Integer = 0
                        If tbClientes.Rows.Count > 0 Then
                            With Grade
                                .Rows.Clear()

                                For Each row As DataRow In tbClientes.Rows
                                    .Rows.Add(False)
                                    .Item(0, x).Value = row("codigo").ToString()
                                    .Item(1, x).Value = row("nome").ToString()
                                    .Item(2, x).Value = row("endereco").ToString()
                                    .Item(3, x).Value = row("bairro").ToString()
                                    .Item(4, x).Value = row("cidade").ToString()
                                    .Item(5, x).Value = row("estado").ToString()
                                    .Item(6, x).Value = row("telefone").ToString()
                                    .Item(7, x).Value = row("cep").ToString()
                                    .Item(8, x).Value = row("cpf").ToString()
                                    .Item(9, x).Value = row("rg")
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
        Return tbClientes
    End Function
    Public Sub SalvarCliente(nrficha As Integer, nome As String, endereco As String, bairro As String, telefone As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "INSERT INTO tbClientes (nrficha, nome, endereco, bairro, telefone, datacad) VALUES (@nrficha, @nome, @endereco, @bairro, @telefone, GETDATE())"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@nrficha", nrficha)
                command.Parameters.AddWithValue("@Nome", nome)
                command.Parameters.AddWithValue("@endereco", endereco)
                command.Parameters.AddWithValue("@bairro", bairro)
                command.Parameters.AddWithValue("@Telefone", telefone)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub AlterarCliente(nrficha As Integer, nome As String, endereco As String, bairro As String, telefone As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()

            Dim sql As String = "UPDATE tbClientes SET nome = @nome, endereco = @endereco, bairro = @bairro, telefone = @telefone WHERE nome = @nome"

            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@nrficha", nrficha)
                command.Parameters.AddWithValue("@Nome", nome)
                command.Parameters.AddWithValue("@endereco", endereco)
                command.Parameters.AddWithValue("@bairro", bairro)
                command.Parameters.AddWithValue("@Telefone", telefone)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ExcluirCliente(codigo As Integer)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "DELETE FROM tbClientes WHERE Codigo = @Codigo"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Codigo", codigo)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function ObterCodigoCliente() As String
        Dim codigo As String
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT TOP 1 * FROM tbClientes ORDER BY codigo DESC"
                Using command As New SqlCommand(sql, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbClientes)

                        If tbClientes.Rows.Count > 0 Then
                            ' Obter o código do último cliente
                            codigo = tbClientes.Rows(0)("codigo").ToString()
                            Return codigo
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
#End Region
End Class
