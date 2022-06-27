Imports System.Data.Odbc
Module Module1
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader

    Public mydb As String

    Public Sub koneksi()
        mydb = "Driver={Mysql ODBC 3.51 Driver};database=db_asetsmpn26;server=localhost;uid=root"
        conn = New OdbcConnection(mydb)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
End Module
