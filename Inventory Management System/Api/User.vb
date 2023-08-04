
Imports MySql.Data.MySqlClient

Public Class UserJSON
    Public UserID As Integer
    Public UserName As String
    Public Phone As String
    Public DateOfBirth As String
    Public Address As String
    Public ShopName As String
End Class

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

    Public Shared Function GetAllUsersJSON() As UserJSON()
        Dim UserList As New List(Of UserJSON)()

        Database.Connection.Open()

        Dim Query = "select user_id, name, phone, date_of_birth, address, shop_name from users"

        Using Command As New MySqlCommand(Query, Database.Connection)
            Using Reader As MySqlDataReader = Command.ExecuteReader()
                While Reader.Read()
                    Dim User As New UserJSON With {
                        .UserID = Convert.ToInt32(Reader("user_id")),
                        .UserName = Reader("name").ToString(),
                        .Phone = Reader("phone").ToString(),
                        .DateOfBirth = Reader("date_of_birth").ToString(),
                        .Address = Reader("address").ToString(),
                        .ShopName = Reader("shop_name").ToString()
                    }

                    UserList.Add(User)
                End While
            End Using
        End Using

        Database.Connection.Close()

        Return UserList.ToArray()
    End Function

    Public Shared Function GetUser(ByVal UserID As Integer) As DataRow
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
