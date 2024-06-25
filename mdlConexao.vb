Imports System.IO
Imports System.ServiceProcess
Imports System.Data.Common
Imports System.Configuration
Imports System.Data.SqlClient
Module mdlconexao
    Dim x As Integer
    Private aConexao As New ADODB.Connection
    Private aconexao2 As New ADODB.Connection

    'Dim server, database, user, password As String

    Dim database = "dbOficina"
    Dim user = "sa"
    Dim password = "123456"
    Dim server = GetNomeSQLServer()

    Public Function OpenRecordset(ByVal sqlquery As String) As DataTable 'As ADODB.Recordset

        Dim aResultado As New ADODB.Recordset
        Dim aConexao As New ADODB.Connection
        Try
            If aConexao.State = 0 Then
                aConexao.ConnectionString = $"Provider=SqlServer;Server={server};Database={database};User Id={user};Password={password};"
                aConexao.ConnectionTimeout = 30
                aConexao.CommandTimeout = 180
                aConexao.Open()
            End If

            If aConexao.State = 1 Then ' Verifica se a conexão está aberta
                aResultado.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                aResultado.Open(sqlquery, aConexao, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            End If

            Return aResultado
        Catch ex As Exception
            Throw New ApplicationException("Erro ao abrir o Recordset: " & ex.Message)
        Finally
            ' Certifique-se de liberar recursos em caso de erro
            If Not aResultado Is Nothing Then
                If aResultado.State = ADODB.ObjectStateEnum.adStateOpen Then
                    aResultado.Close()
                End If
                aResultado = Nothing
            End If
            If Not aConexao Is Nothing Then
                If aConexao.State = ADODB.ObjectStateEnum.adStateOpen Then
                    aConexao.Close()
                End If
                aConexao = Nothing
            End If
        End Try
    End Function

    Public Function abrir(ByVal sql As String)

        Dim aResultado As New ADODB.Recordset

        database = "C:\Documents and Settings\Administrador\Meus documentos\Técnico\2º Período\VB.net\Permissões\dbexemplo.mdb"
        If File.Exists(database) = False Then
            Return Nothing
            Exit Function
        End If

        If sql.ToUpper = "FECHAR" Then
            aconexao2.Close()
            Return False
            Exit Function
        End If

        If aconexao2.State = 0 Then
            aconexao2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & database
            aconexao2.Open()
        End If

        'aResultado2.Open(sql, aconexao2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        aResultado.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        aResultado.Open(sql, aconexao2, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        abrir = aResultado
        aResultado = Nothing

    End Function

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
End Module
