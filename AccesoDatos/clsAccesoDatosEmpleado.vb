Imports Entidades.EntidadEmpleado
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Namespace AccesoDatos
    Public Class clsAccesoDatosEmpleado
        'atributo
        Private vgc_CadenaConexion As String

        'Constructor
        Public Sub New(pvc_CadenaConexion As String)
            vgc_CadenaConexion = pvc_CadenaConexion
        End Sub
#Region "Metodos"
        Public Function Insertar(pvo_EntidadEmpleado As clsEmpleado) As Integer
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vln_Identificacion As Integer = 0
            Dim vlc_Sentencia As String = String.Empty

            vlo_SqlCommand.Connection = vlo_SqlConnection

            Try
                vlc_Sentencia = "Insert INTO Empleados (Identificacion, Nombre, Apellido1, Apellido2, 
                                Telefono, Provincia, Canton, Distrito, Otras_Senias, Grado_Academico, 
                                Titulo, Pension, Cod_Puesto)
                                VALUES (@Identificacion, @Nombre, @Apellido1, @Apellido2, 
                                @Telefono, @Provincia, @Canton, @Distrito, @Otras_Senias, @Grado_Academico, 
                                @Titulo, @Pension, @Cod_Puesto)"

                vlo_SqlCommand.Parameters.AddWithValue("@Identificacion", pvo_EntidadEmpleado.Identificacion)
                vlo_SqlCommand.Parameters.AddWithValue("@Nombre", pvo_EntidadEmpleado.Nombre)
                vlo_SqlCommand.Parameters.AddWithValue("@Apellido1", pvo_EntidadEmpleado.Apellido1)
                vlo_SqlCommand.Parameters.AddWithValue("@Apellido2", pvo_EntidadEmpleado.Apellido2)
                vlo_SqlCommand.Parameters.AddWithValue("@Telefono", pvo_EntidadEmpleado.Telefono)
                vlo_SqlCommand.Parameters.AddWithValue("@Provincia", pvo_EntidadEmpleado.Provincia)
                vlo_SqlCommand.Parameters.AddWithValue("@Canton", pvo_EntidadEmpleado.Canton)
                vlo_SqlCommand.Parameters.AddWithValue("@Distrito", pvo_EntidadEmpleado.Distrito)
                vlo_SqlCommand.Parameters.AddWithValue("@Otras_Senias", pvo_EntidadEmpleado.OtrasSenias)
                vlo_SqlCommand.Parameters.AddWithValue("@Grado_Academico", pvo_EntidadEmpleado.Grado_Academico)
                vlo_SqlCommand.Parameters.AddWithValue("@Titulo", pvo_EntidadEmpleado.Titulo)
                vlo_SqlCommand.Parameters.AddWithValue("@Pension", pvo_EntidadEmpleado.Pension)
                vlo_SqlCommand.Parameters.AddWithValue("@Cod_Puesto", pvo_EntidadEmpleado.CodPuesto)

                vlo_SqlCommand.CommandText = vlc_Sentencia
                vlo_SqlConnection.Open()
                vln_Identificacion = CType(vlo_SqlCommand.ExecuteScalar(), Integer)
                vlo_SqlConnection.Close()
            Catch ex As Exception
                Throw
            Finally
                vlo_SqlCommand.Dispose()
                vlo_SqlConnection.Dispose()
            End Try
            Return vln_Identificacion
        End Function
        Public Function Modificar(pvo_EntidadEmpleado As clsEmpleado) As Integer
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vln_IdResultado As Integer = -1
            Dim vlc_Sentencia As String = String.Empty

            vlo_SqlCommand.Connection = vlo_SqlConnection

            Try

                vlc_Sentencia = "UPDATE Empleados SET Identificacion = @Identificacion, Nombre = @Nombre, 
                                Apellido1 = @Apellido1, Apellido2 = @Apellido2,Telefono = @Telefono, 
                                Provincia = @Provincia, Canton = @Canton, Distrito = @Distrito, 
                                Otras_Senias = @Otras_Senias, Grado_Academico = @Grado_Academico, 
                                Titulo = @Titulo, Pension = @Pension, Cod_Puesto = @Cod_Puesto
                                WHERE Identificacion = @Identificacion"

                vlo_SqlCommand.Parameters.AddWithValue("@Identificacion", pvo_EntidadEmpleado.Identificacion)
                vlo_SqlCommand.Parameters.AddWithValue("@Nombre", pvo_EntidadEmpleado.Nombre)
                vlo_SqlCommand.Parameters.AddWithValue("@Apellido1", pvo_EntidadEmpleado.Apellido1)
                vlo_SqlCommand.Parameters.AddWithValue("@Apellido2", pvo_EntidadEmpleado.Apellido2)
                vlo_SqlCommand.Parameters.AddWithValue("@Telefono", pvo_EntidadEmpleado.Telefono)
                vlo_SqlCommand.Parameters.AddWithValue("@Provincia", pvo_EntidadEmpleado.Provincia)
                vlo_SqlCommand.Parameters.AddWithValue("@Canton", pvo_EntidadEmpleado.Canton)
                vlo_SqlCommand.Parameters.AddWithValue("@Distrito", pvo_EntidadEmpleado.Distrito)
                vlo_SqlCommand.Parameters.AddWithValue("@Otras_Senias", pvo_EntidadEmpleado.OtrasSenias)
                vlo_SqlCommand.Parameters.AddWithValue("@Grado_Academico", pvo_EntidadEmpleado.Grado_Academico)
                vlo_SqlCommand.Parameters.AddWithValue("@Titulo", pvo_EntidadEmpleado.Titulo)
                vlo_SqlCommand.Parameters.AddWithValue("@Pension", pvo_EntidadEmpleado.Pension)
                vlo_SqlCommand.Parameters.AddWithValue("@Cod_Puesto", pvo_EntidadEmpleado.CodPuesto)

                vlo_SqlCommand.CommandText = vlc_Sentencia
                vlo_SqlConnection.Open()
                vlo_SqlCommand.ExecuteNonQuery()
                vln_IdResultado = 1
                vlo_SqlConnection.Close()
            Catch ex As Exception
                vln_IdResultado = -1
                Throw
            Finally
                vlo_SqlCommand.Dispose()
                vlo_SqlConnection.Dispose()
            End Try
            Return vln_IdResultado
        End Function
        Public Function Eliminar(pvo_EntidadEmpleado As clsEmpleado) As Integer
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vln_IdResultado As Integer = -1
            Dim vlc_Sentencia As String = String.Empty

            vlo_SqlCommand.Connection = vlo_SqlConnection

            Try
                vlc_Sentencia = "DELETE FROM Empleados WHERE Identificacion = @Identificacion"

                vlo_SqlCommand.Parameters.AddWithValue("@Identificacion", pvo_EntidadEmpleado.Identificacion)

                vlo_SqlCommand.CommandText = vlc_Sentencia
                vlo_SqlConnection.Open()
                vlo_SqlCommand.ExecuteNonQuery()
                vln_IdResultado = 1
                vlo_SqlConnection.Close()
            Catch ex As Exception
                vln_IdResultado = -1
                Throw
            Finally
                vlo_SqlCommand.Dispose()
                vlo_SqlConnection.Dispose()
            End Try
            Return vln_IdResultado
        End Function
        ''Condicion para ver el parametro que se va a buscar
        ''Orden para ordenarlos
        Public Function ListarRegistros(ByVal pvc_Condicion As String, ByVal pvc_Orden As String) As DataSet
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlDataAdapter As SqlDataAdapter
            Dim vlo_dsDatos As New DataSet
            Dim vlc_Sentencia As String = String.Empty

            vlc_Sentencia = "Select Identificacion, Nombre, Apellido1, Apellido2, 
                                Telefono, Provincia, Canton, Distrito, Otras_Senias, Grado_Academico, 
                                Titulo, Pension, Cod_Puesto FROM Empleados"
            If Not String.IsNullOrEmpty(pvc_Condicion) Then
                '' el 0 representa la vlc_Sentencia y el 1 la pvc_Condicion
                vlc_Sentencia = String.Format("{0} WHERE {1}", vlc_Sentencia, pvc_Condicion)
            End If
            If Not String.IsNullOrEmpty(pvc_Orden) Then
                vlc_Sentencia = String.Format("{0} ORDER BY {1}", vlc_Sentencia, pvc_Orden)
            End If
            Try
                vlo_SqlDataAdapter = New SqlDataAdapter(vlc_Sentencia, vlo_SqlConnection)
                vlo_SqlDataAdapter.Fill(vlo_dsDatos, "Empleados")
            Catch ex As Exception
                Throw
            Finally
                vlo_SqlConnection.Dispose()
            End Try
            Return vlo_dsDatos
        End Function
        Public Function ObtenerRegistro(ByVal pvc_Condicion As String) As clsEmpleado
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vlo_SqlDataReader As SqlDataReader
            Dim vlc_Sentencia As String = String.Empty
            Dim vlo_EntidadEmpleado As New clsEmpleado

            vlc_Sentencia = "Select Identificacion, Nombre, Apellido1, Apellido2, 
                                Telefono, Provincia, Canton, Distrito, Otras_Senias, Grado_Academico, 
                                Titulo, Pension, Cod_Puesto FROM Empleados"

            If Not String.IsNullOrEmpty(pvc_Condicion) Then
                vlc_Sentencia = String.Format("{0} WHERE {1}", vlc_Sentencia, pvc_Condicion)
            End If
            Try
                vlo_SqlCommand.Connection = vlo_SqlConnection
                vlo_SqlConnection.Open()
                vlo_SqlCommand.CommandText = vlc_Sentencia

                vlo_SqlDataReader = vlo_SqlCommand.ExecuteReader()
                If vlo_SqlDataReader.HasRows Then
                    vlo_SqlDataReader.Read()
                    vlo_EntidadEmpleado.ExisteRegistro = True
                    vlo_EntidadEmpleado.Identificacion = CType(vlo_SqlDataReader("Identificacion"), Integer)
                    vlo_EntidadEmpleado.Nombre = CType(vlo_SqlDataReader("Nombre"), String)
                    vlo_EntidadEmpleado.Apellido1 = CType(vlo_SqlDataReader("Apellido1"), String)
                    vlo_EntidadEmpleado.Apellido2 = CType(vlo_SqlDataReader("Apellido2"), String)
                    vlo_EntidadEmpleado.Telefono = CType(vlo_SqlDataReader("Telefono"), String)
                    vlo_EntidadEmpleado.Provincia = CType(vlo_SqlDataReader("Provincia"), String)
                    vlo_EntidadEmpleado.Canton = CType(vlo_SqlDataReader("Canton"), String)
                    vlo_EntidadEmpleado.Distrito = CType(vlo_SqlDataReader("Distrito"), String)
                    vlo_EntidadEmpleado.OtrasSenias = CType(vlo_SqlDataReader("Otras_Senias"), String)
                    vlo_EntidadEmpleado.Grado_Academico = CType(vlo_SqlDataReader("Grado_Academico"), String)
                    vlo_EntidadEmpleado.Titulo = CType(vlo_SqlDataReader("Titulo"), String)
                    vlo_EntidadEmpleado.Pension = CType(vlo_SqlDataReader("Pension"), Integer)
                    vlo_EntidadEmpleado.CodPuesto = CType(vlo_SqlDataReader("Cod_Puesto"), Integer)

                End If
                vlo_SqlConnection.Close()
            Catch ex As Exception
                Throw
            Finally
                vlo_SqlCommand.Dispose()
                vlo_SqlConnection.Dispose()
            End Try
            Return vlo_EntidadEmpleado
        End Function
#End Region
    End Class
End Namespace