Imports System.IO
Module mdlconexao
    Dim x As Integer
    Private aConexao As New ADODB.Connection
    Private aconexao2 As New ADODB.Connection

    Dim server, acess_db, user, acess_pwd

    Public Function OpenRecordset(ByVal sqlquery As String)
        Dim aResultado As New ADODB.Recordset

        database = "dbOficina"
        user = "userOficina"
        password = "1234"
        server = "(local)"

        If aConexao.State = 0 Then
            aConexao.ConnectionString = "driver={sql server};" & _
                                            "server=" + server + ";" & _
                                            "Database=" + database + ";" & _
                                            "PWD=" + password + ";" & _
                                            "UID=" + user + ";"
            aConexao.ConnectionTimeout = 30
            aConexao.CommandTimeout = 180
            aConexao.Open()
        End If

        aResultado.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        aResultado.Open(sqlquery, aConexao, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        OpenRecordset = aResultado
        aResultado = Nothing

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
End Module
