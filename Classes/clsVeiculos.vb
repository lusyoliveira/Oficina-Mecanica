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
                Dim sql As New StringBuilder("SELECT * FROM tbVeiculos WHERE 1=1 ")
                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                sql.AppendLine("ORDER BY Descricao")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbVeiculos)
                    If tbVeiculos.Rows.Count > 0 Then
                        With dgvGrade
                            .Rows.Clear()
                            For Each row As DataRow In tbVeiculos.Rows
                                .Rows.Add(False)
                                Dim x As Integer = tbVeiculos.Rows.Count - 1
                                .Rows(x).Cells(0).Value = row("placalt").ToString()
                                .Rows(x).Cells(1).Value = row("placanr").ToString()
                                .Rows(x).Cells(3).Value = row("modelo").ToString()
                                .Rows(x).Cells(4).Value = row("ano").ToString()
                                .Rows(x).Cells(4).Value = row("combustivel").ToString()
                                .Rows(x).Cells(4).Value = row("chassiss").ToString()
                                .Rows(x).Cells(4).Value = row("renavan").ToString()
                            Next
                        End With
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
