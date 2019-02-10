Imports MySql.Data.MySqlClient
Module PublicVariables
    Public con As MySqlConnection = myconn()
    Public result As Integer
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dReader As MySqlDataReader
    Public dt As DataTable
    Public sql As String = ""
    Public issucess As Boolean
    Public ACCOUNT_NAME As String = ""
    Public ACCOUNT_USERNAME As String = ""
    Public ACCOUNT_TYPE As String = ""
End Module
