Imports System.Data.SqlClient

Public Class clsCombo
    Dim ClasseConexao As New clsConexao, tbClientes, tbProdutos As New DataTable()
#Region "PROPRIEDADES"
    Private Property _Codigo As Integer
    Public Property Codigo As Integer
        Get
            Return _Codigo
        End Get
        Set(value As Integer)
            _Codigo = value
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
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function PreencherComboBox(query As String, campoId As String, campoNome As String) As List(Of clsCombo)
        Dim lista = New List(Of clsCombo)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Using cmd = New SqlCommand(query, cn)
                    Dim rdr As SqlDataReader = cmd.ExecuteReader()
                    While rdr.Read()
                        Dim item As New clsCombo With {
                        ._Codigo = rdr.GetInt32(rdr.GetOrdinal(campoId)),
                        ._Descricao = rdr.GetString(rdr.GetOrdinal(campoNome))
                    }
                        lista.Add(item)
                    End While
                    rdr.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Não foi possível consultar os dados!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
        Return lista
    End Function
#End Region
End Class
