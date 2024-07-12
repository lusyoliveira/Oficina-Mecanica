Imports System.Data.SqlClient
Imports System.Text
Public Class clsFuncionarios
    Dim ClasseConexao As New clsConexao, tbFuncionarios As New DataTable()

#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaFuncionario(dgvGrade As DataGridView, Codigo As Integer, Matricula As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbFuncionarios WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND codfunc = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Matricula) Then
                    sql.AppendLine("AND numeroregistro LIKE @Matricula")
                End If

                sql.AppendLine("ORDER BY Matricula")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Matricula) Then
                        command.Parameters.AddWithValue("@Matricula", "%" & Matricula & "%")
                    End If
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(tbFuncionarios)

                        Dim x As Integer = 0
                        If tbFuncionarios.Rows.Count > 0 Then
                            With dgvGrade
                                .Rows.Clear()
                                For Each row As DataRow In tbFuncionarios.Rows
                                    .Rows.Add(False)
                                    .Item(0, x).Value = row("codigo").Value.ToString
                                    .Item(1, x).Value = row("nome").Value.ToString
                                    .Item(2, x).Value = row("endereco").Value.ToString
                                    .Item(3, x).Value = row("bairro").Value.ToString
                                    .Item(4, x).Value = row("cidade").Value.ToString
                                    .Item(5, x).Value = row("estado").Value.ToString
                                    .Item(6, x).Value = row("telefone").Value.ToString
                                    .Item(7, x).Value = row("cep").Value.ToString
                                    .Item(8, x).Value = row("cpf").Value.ToString
                                    .Item(9, x).Value = row("rg").Value
                                    .Item(10, x).Value = row("cargo").Value.ToString
                                    .Item(11, x).Value = FormatCurrency(row("salario").Value.ToString)
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
            MessageBox.Show("Erro ao consultar Funcionarios: " & ex.Message)
        End Try
        Return tbFuncionarios
    End Function
    Public Sub SalvarFuncionario(nome As String, endereco As String, bairro As String, cidade As String, uf As String, cpf As String, rg As String, cep As String, telefone As String, cargo As String, salario As Decimal)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "INSERT INTO tbFuncionarios (nome, endereco, bairro, cidade, estado, cep, cpf, rg, telefone, cargo, salario) VALUES (@nome, @endereco, @bairro, @cidade, @estado, @cep, @cpf, @rg, @telefone, @cargo, @salario)"
            Using cmd As New SqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@nome", nome)
                cmd.Parameters.AddWithValue("@endereco", endereco)
                cmd.Parameters.AddWithValue("@bairro", bairro)
                cmd.Parameters.AddWithValue("@cidade", cidade)
                cmd.Parameters.AddWithValue("@estado", uf)
                cmd.Parameters.AddWithValue("@cep", cep)
                cmd.Parameters.AddWithValue("@cpf", cpf)
                cmd.Parameters.AddWithValue("@rg", rg)
                cmd.Parameters.AddWithValue("@telefone", telefone)
                cmd.Parameters.AddWithValue("@cargo", cargo)
                cmd.Parameters.AddWithValue("@salario", salario)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub AlterarFuncionario(Codigo As Integer, nome As String, endereco As String, bairro As String, cidade As String, uf As String, cpf As String, rg As String, cep As String, telefone As String, cargo As String, salario As Decimal)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "UPDATE tbFuncionarios SET matricula = @matricula, nome = @nome, endereco = @endereco,  bairro = @bairro, cidade = @cidade, uf = @estado, cep = @cep, telefone = @telefone, rg = @rg, cpf = @cpf,  cargo = @cargo, salario = @salario WHERE codfunc = @codigo"
            Using cmd As New SqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@codigo", Codigo)
                cmd.Parameters.AddWithValue("@nome", nome)
                cmd.Parameters.AddWithValue("@endereco", endereco)
                cmd.Parameters.AddWithValue("@bairro", bairro)
                cmd.Parameters.AddWithValue("@cidade", cidade)
                cmd.Parameters.AddWithValue("@estado", uf)
                cmd.Parameters.AddWithValue("@cep", cep)
                cmd.Parameters.AddWithValue("@cpf", cpf)
                cmd.Parameters.AddWithValue("@rg", rg)
                cmd.Parameters.AddWithValue("@telefone", telefone)
                cmd.Parameters.AddWithValue("@cargo", cargo)
                cmd.Parameters.AddWithValue("@salario", salario)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ExcluirFuncionario(codigo As Integer)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "DELETE FROM tbFuncionarios WHERE codfunc = @codigo"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@codigo", codigo)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

#End Region
End Class
