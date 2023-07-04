
Imports MySql.Data.MySqlClient

Public Class User
    Public Shared Function Login(ByVal Phone As String, Password As String) As DataRow
        Database.Connection.Open()

        Dim Query As String = "SELECT * FROM users WHERE phone = @Phone AND password = @Password;"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@Phone", Phone)

        Command.Parameters.AddWithValue("@Password", Password)

        Dim Adapter As New MySqlDataAdapter(Command)

        Dim DataSet As New DataSet()

        Adapter.Fill(DataSet, "users")

        Dim Record As DataRow

        If DataSet.Tables("users").Rows.Count > 0 Then
            Record = DataSet.Tables("users").Rows(0)
        Else
            Database.Connection.Close()
            Throw New Exception("Invalid Credentials")
        End If

        Database.Connection.Close()

        Return Record
    End Function

    Public Shared Function GetUser(ByVal UserID As String) As DataRow
        Database.Connection.Open()

        Dim Query As String = "SELECT * FROM users WHERE user_id = @UserID;"

        Dim Command As New MySqlCommand(Query, Database.Connection)

        Command.Parameters.AddWithValue("@UserID", UserID)

        Dim Adapter As New MySqlDataAdapter(Command)

        Dim DataSet As New DataSet()

        Adapter.Fill(DataSet, "users")

        Dim Record As DataRow

        If DataSet.Tables("users").Rows.Count > 0 Then
            Record = DataSet.Tables("users").Rows(0)
        Else
            Database.Connection.Close()
            Throw New Exception("Record not found")
        End If

        Database.Connection.Close()

        Return Record
    End Function
End Class
