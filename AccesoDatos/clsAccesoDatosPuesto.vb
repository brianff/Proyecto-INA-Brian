Imports Entidades.EntidadPuesto
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Namespace AccesoDatos
    Public Class clsAccesoDatosPuesto
        'atributo
        Private vgc_CadenaConexion As String

        'Constructor
        Public Sub New(pvc_CadenaConexion As String)
            vgc_CadenaConexion = pvc_CadenaConexion
        End Sub
#Region "Metodos"
        Public Function Insertar(pvo_EntidadPuesto As clsPuestos) As Integer
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vln_IdPuesto As Integer = 0
            Dim vlc_Sentencia As String = String.Empty

            vlo_SqlCommand.Connection = vlo_SqlConnection

            Try
                vlc_Sentencia = "INSERT INTO Puestos (Nombre_Puesto, Categoria, Salario_Base)
                                VALUES (@Nombre_Puesto, @Categoria, @Salario_Base) SELECT @@Identity"

                vlo_SqlCommand.Parameters.AddWithValue("@Nombre_Puesto", pvo_EntidadPuesto.Nombre_Puesto)
                vlo_SqlCommand.Parameters.AddWithValue("@Categoria", pvo_EntidadPuesto.Categoria)
                vlo_SqlCommand.Parameters.AddWithValue("@Salario_Base", pvo_EntidadPuesto.SalarioBase)

                vlo_SqlCommand.CommandText = vlc_Sentencia
                vlo_SqlConnection.Open()
                vln_IdPuesto = CType(vlo_SqlCommand.ExecuteScalar(), Integer)
                vlo_SqlConnection.Close()
            Catch ex As Exception
                Throw
            Finally
                vlo_SqlCommand.Dispose()
                vlo_SqlConnection.Dispose()
            End Try
            Return vln_IdPuesto
        End Function
        Public Function Modificar(pvo_EntidadPuesto As clsPuestos) As Integer
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vln_IdResultado As Integer = -1
            Dim vlc_Sentencia As String = String.Empty

            vlo_SqlCommand.Connection = vlo_SqlConnection

            Try
                vlc_Sentencia = "UPDATE Puestos SET Nombre_Puesto = @Nombre_Puesto, Categoria = @Categoria, Salario_Base = @Salario_Base 
                                 WHERE Cod_Puesto = @Cod_Puesto"

                vlo_SqlCommand.Parameters.AddWithValue("@Cod_Puesto", pvo_EntidadPuesto.Cod_Puesto)
                vlo_SqlCommand.Parameters.AddWithValue("@Nombre_Puesto", pvo_EntidadPuesto.Nombre_Puesto)
                vlo_SqlCommand.Parameters.AddWithValue("@Categoria", pvo_EntidadPuesto.Categoria)
                vlo_SqlCommand.Parameters.AddWithValue("@Salario_Base", pvo_EntidadPuesto.SalarioBase)

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
        Public Function Eliminar(pvo_EntidadPuesto As clsPuestos) As Integer
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vln_IdResultado As Integer = -1
            Dim vlc_Sentencia As String = String.Empty

            vlo_SqlCommand.Connection = vlo_SqlConnection
            Try
                vlc_Sentencia = "DELETE FROM Puestos WHERE Cod_Puesto = @Cod_Puesto"

                vlo_SqlCommand.Parameters.AddWithValue("@Cod_Puesto", pvo_EntidadPuesto.Cod_Puesto)

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

            vlc_Sentencia = "SELECT Cod_Puesto, Nombre_Puesto, Categoria, Salario_Base FROM Puestos"

            If Not String.IsNullOrEmpty(pvc_Condicion) Then
                '' el 0 representa la vlc_Sentencia y el 1 la pvc_Condicion
                vlc_Sentencia = String.Format("{0} WHERE {1}", vlc_Sentencia, pvc_Condicion)
            End If
            If Not String.IsNullOrEmpty(pvc_Orden) Then
                vlc_Sentencia = String.Format("{0} ORDER BY {1}", vlc_Sentencia, pvc_Orden)
            End If
            Try
                vlo_SqlDataAdapter = New SqlDataAdapter(vlc_Sentencia, vlo_SqlConnection)
                vlo_SqlDataAdapter.Fill(vlo_dsDatos, "Puestos")
            Catch ex As Exception
                Throw
            Finally
                vlo_SqlConnection.Dispose()
            End Try
            Return vlo_dsDatos
        End Function
        ''cuando la sentencia es un select hay que usarlo con executedatareader
        Public Function ObtenerRegistro(ByVal pvc_Condicion As String) As clsPuestos
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vlo_SqlDataReader As SqlDataReader
            Dim vlc_Sentencia As String = String.Empty
            Dim vlo_EntidadPuesto As New clsPuestos

            vlc_Sentencia = "SELECT Cod_Puesto, Nombre_Puesto, Categoria, Salario_Base FROM Puestos"

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
                    vlo_EntidadPuesto.ExisteRegistro = True
                    vlo_EntidadPuesto.Cod_Puesto = CType(vlo_SqlDataReader("Cod_Puesto"), Integer)
                    vlo_EntidadPuesto.Nombre_Puesto = CType(vlo_SqlDataReader("Nombre_Puesto"), String)
                    vlo_EntidadPuesto.Categoria = CType(vlo_SqlDataReader("Categoria"), String)
                    vlo_EntidadPuesto.SalarioBase = CType(vlo_SqlDataReader("Salario_Base"), Double)

                End If
                vlo_SqlConnection.Close()

            Catch ex As Exception
                Throw
            Finally
                vlo_SqlCommand.Dispose()
                vlo_SqlConnection.Dispose()
            End Try
            Return vlo_EntidadPuesto
        End Function
#End Region
    End Class
End Namespace