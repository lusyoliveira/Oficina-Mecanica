Imports System.Data.SqlClient
Imports System.Text
Public Class clsVeiculos
    Dim ClasseConexao As New clsConexao, tbVeiculos As New DataTable()

#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaVeiculos(dgvGrade As DataGridView, Codigo As Integer) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbVeiculos WHERE 1=1")

                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                sql.AppendLine("ORDER BY Modelo")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbVeiculos)

                    ' Verifica se o DataTable contém registros
                    If tbVeiculos.Rows.Count > 0 Then

                        ' Limpa as colunas existentes no DataGridView
                        dgvGrade.Columns.Clear()
                        ' Configura o DataGridView para exibir os dados
                        dgvGrade.DataSource = tbVeiculos
                    Else
                        ' Se nenhum dado for encontrado, limpa o DataGridView e exibe uma mensagem
                        dgvGrade.DataSource = Nothing
                        MessageBox.Show("Nenhum cliente encontrado com os critérios fornecidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o peca: " & ex.Message)
        End Try
        Return tbVeiculos
    End Function
    Public Sub SalvarVeiculos(Placalt As String, Placanr As String, Modelo As String, Ano As String, Combustivel As String, Chassiss As String, Renavan As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbVeiculos (Placalt,Placanr,Modelo,Ano,Combustivel,Chassiss,Renavan) VALUES (@Placalt,@Placanr,@Modelo,@Ano,@Combustivel,@Chassiss,@Renavan)"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Placalt", Placalt)
                    command.Parameters.AddWithValue("@Placanr", Placanr)
                    command.Parameters.AddWithValue("@modelo", Modelo)
                    command.Parameters.AddWithValue("@Ano", Ano)
                    command.Parameters.AddWithValue("@Combustivel", Combustivel)
                    command.Parameters.AddWithValue("@Chassiss", Chassiss)
                    command.Parameters.AddWithValue("@Renavan", Renavan)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Veículo salvo com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar Veículo: " & ex.Message)
        End Try
    End Sub
    Public Sub AlterarVeiculos(codigo As Integer, Placalt As String, Placanr As String, Modelo As String, Ano As String, Combustivel As String, Chassiss As String, Renavan As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbVeiculos SET Placalt = @Placalt,Placanr = @Placanr,Modelo = @Modelo,Ano = @Ano,Combustivel = @Combustivel,Chassiss = @Chassiss,Renavan = @Renavan WHERE codigo = @codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@codigo", codigo)
                    command.Parameters.AddWithValue("@Placalt", Placalt)
                    command.Parameters.AddWithValue("@Placanr", Placanr)
                    command.Parameters.AddWithValue("@modelo", Modelo)
                    command.Parameters.AddWithValue("@Ano", Ano)
                    command.Parameters.AddWithValue("@Combustivel", Combustivel)
                    command.Parameters.AddWithValue("@Chassiss", Chassiss)
                    command.Parameters.AddWithValue("@Renavan", Renavan)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Veículo alterado com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar Veículo: " & ex.Message)

        End Try
    End Sub
    Public Sub ExcluirVeiculos(Codigo As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbVeiculos WHERE Codigo = @Codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codigo", Codigo)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Veículo excluído com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir Veículo: " & ex.Message)
        End Try
    End Sub
#End Region
End Class
