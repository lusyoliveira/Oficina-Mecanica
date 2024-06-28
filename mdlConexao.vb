Imports System.IO
Imports System.ServiceProcess
Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient

Module mdlconexao

    Private DataBase = "dbOficina"
    Const user = "sa"
    Const password = "123456"
    Private Server = "(local)"

    ''' <summary>
    ''' Esta função obtem o nome do servidor SQL Server.
    ''' </summary>
    ''' <returns>Retorna o nome do servidor.</returns>

    Public Function GetNomeSQLServer() As String
        'Nome do PC local
        Dim strPCname As String = Environment.MachineName
        ' nome do serviço do SQL Server Express
        Dim strInstancia As String = "MSSQL$SQLEXPRESS"
        Dim strNomeSQLServer As String = String.Empty

        ' Inclua uma referência a : System.ServiceProcess;
        Dim servicos As ServiceController() = ServiceController.GetServices()
        ' percorre os serviços 
        For Each servico As ServiceController In servicos
            If servico Is Nothing Then
                Continue For
            End If
            Dim strNomeDoServico As String = servico.ServiceName
            If strNomeDoServico.Contains(strInstancia) Then
                strNomeSQLServer = strNomeDoServico
            End If
        Next
        Dim IndiceInicio As Integer = strNomeSQLServer.IndexOf("$")
        If IndiceInicio > -1 Then
            'strSqlServerName=NomeDoSeuPC\SQLEXPRESS;
            strNomeSQLServer = strPCname + "\" + strNomeSQLServer.Substring(IndiceInicio + 1)
        End If
        Return strNomeSQLServer
    End Function
    Public Function OpenRecordset(query As String) As DataTable
        Dim connectionString As String = "Data Source=VAR223\SQLEXPRESS;Initial Catalog=dbOficina;User ID=sa;Password=123456"
        Dim dt As New DataTable()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function
    'Public Function OpenRecordset(ByVal Sql As String, Optional ByVal servidor As tpServidor = tpServidor.Access) As DataTable
    '    Dim factory As DbProviderFactory = DbProviderFactories.GetFactory(GetProviderInvariantName(servidor))
    '    aConexao = factory.CreateConnection()
    '    aConexao.ConnectionString = GetConnectionString(servidor)

    '    Dim dt As New DataTable()
    '    Try
    '        aConexao.Open()
    '        Dim cmd As DbCommand = aConexao.CreateCommand()
    '        cmd.CommandText = Sql
    '        Dim adapter As DbDataAdapter = factory.CreateDataAdapter()
    '        adapter.SelectCommand = cmd
    '        adapter.Fill(dt)
    '    Catch ex As Exception
    '        dt = Nothing
    '        MsgBox("Banco de Dados não encontrado!")
    '    Finally
    '        If aConexao.State = ConnectionState.Open Then
    '            aConexao.Close()
    '        End If
    '    End Try

    '    Return dt
    'End Function

End Module
