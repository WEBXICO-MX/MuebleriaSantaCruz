Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Conexion
    Private ConexionConBD As SqlConnection
    Private Orden As SqlCommand
    Private Lector As SqlDataReader

    Public Function getConexion() As SqlConnection

        'Crear la conexión con la base de datos
        Dim strConexión As String = "Data Source=localhost;" & _
            "Initial Catalog=MuebleriaCASACRUZ; User ID=mccruz; Password=mccruz"
        ConexionConBD = New SqlConnection(strConexión)

        'Abrir la base de datos
        ConexionConBD.Open()

        Return ConexionConBD

    End Function

    Public Sub cerrarConexion()
        ' Cerrar la conexión cuando ya no sea necesaria
        If (Not ConexionConBD Is Nothing) Then
            ConexionConBD.Close()
        End If
    End Sub

End Class
