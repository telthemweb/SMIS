Imports MySql.Data.MySqlClient
Module Database
    Public Function myconn() As MySqlConnection
        '"server=localhost;userid=root;password=!physmach89;SslMode=none;database=sims"
        Return New MySqlConnection("server=localhost;userid=root;password=!physmach89;SslMode=none;database=sims")

    End Function
End Module
