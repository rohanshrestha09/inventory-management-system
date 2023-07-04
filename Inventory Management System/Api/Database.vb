Imports MySql.Data.MySqlClient

Public Class Database
    Public Shared Connection As MySqlConnection = New MySqlConnection($"server=localhost;port=3306;username=root;password=RohanBroVeryPro.123;database=inventory_management_system")
End Class