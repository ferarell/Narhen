Imports System.Runtime.Serialization
Imports Microsoft.SqlServer

<DataContract()>
Public Class GeneralBE

    Private _SqlTxt As String
    <DataMember()>
    Public Property SqlTxt() As String
        Get
            Return _SqlTxt
        End Get

        Set(ByVal value As String)
            _SqlTxt = value
        End Set
    End Property

    Private _dtResult As DataTable
    <DataMember()>
    Public Property dtResult() As DataTable
        Get
            Return _dtResult
        End Get

        Set(ByVal value As DataTable)
            _dtResult = value
        End Set
    End Property

End Class
