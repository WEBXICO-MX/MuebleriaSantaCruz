Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Conexion
    Public conString As String = "Data Source=localhost;Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
    Public con As New SqlConnection(conString)
End Class
