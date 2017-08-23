Imports Entidades.EntidadDeduccion
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient

Namespace AccesoDatos
    Public Class clsAccesoDatosDeduccion
        'atributo
        Private vgc_CadenaConexion As String

        'Constructor
        Public Sub New(pvc_CadenaConexion As String)
            vgc_CadenaConexion = pvc_CadenaConexion
        End Sub
#Region "Metodos"
        Public Function Insertar(pvo_EntidadDeduccion As clsDeducciones) As Integer
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vln_IdDeduccion As Integer = 0
            Dim vlc_Sentencia As String = String.Empty

            vlo_SqlCommand.Connection = vlo_SqlConnection

            Try
                vlc_Sentencia = "INSERT INTO Deducciones (Descripcion, Monto, Tipo, ValorDeduccion1, ValorDeduccion2)
                                VALUES (@Descripcion, @Monto, @Tipo, @ValorDeduccion1, @ValorDeduccion2) SELECT @@Identity"

                vlo_SqlCommand.Parameters.AddWithValue("@Descripcion", pvo_EntidadDeduccion.Descripcion)
                vlo_SqlCommand.Parameters.AddWithValue("@Monto", pvo_EntidadDeduccion.Monto)
                vlo_SqlCommand.Parameters.AddWithValue("@Tipo", pvo_EntidadDeduccion.Tipo)
                vlo_SqlCommand.Parameters.AddWithValue("@ValorDeduccion1", pvo_EntidadDeduccion.ValorDeduccion1)
                vlo_SqlCommand.Parameters.AddWithValue("@ValorDeduccion2", pvo_EntidadDeduccion.ValorDeduccion2)

                vlo_SqlCommand.CommandText = vlc_Sentencia
                vlo_SqlConnection.Open()
                vln_IdDeduccion = CType(vlo_SqlCommand.ExecuteScalar(), Integer)
                vlo_SqlConnection.Close()
            Catch ex As Exception
                Throw
            Finally
                vlo_SqlCommand.Dispose()
                vlo_SqlConnection.Dispose()
            End Try
            Return vln_IdDeduccion
        End Function
        Public Function Modificar(pvo_EntidadDeduccion As clsDeducciones) As Integer
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vln_IdResultado As Integer = -1
            Dim vlc_Sentencia As String = String.Empty

            vlo_SqlCommand.Connection = vlo_SqlConnection

            Try
                vlc_Sentencia = "UPDATE Deducciones SET Descripcion = @Descripcion, Monto = @Monto, Tipo = @Tipo, 
                                  ValorDeduccion1 = @ValorDeduccion1, ValorDeduccion2 = @ValorDeduccion2 
                                 WHERE Cod_Pago = @Cod_Pago"

                vlo_SqlCommand.Parameters.AddWithValue("@Descripcion", pvo_EntidadDeduccion.Descripcion)
                vlo_SqlCommand.Parameters.AddWithValue("@Monto", pvo_EntidadDeduccion.Monto)
                vlo_SqlCommand.Parameters.AddWithValue("@Tipo", pvo_EntidadDeduccion.Tipo)
                vlo_SqlCommand.Parameters.AddWithValue("@ValorDeduccion1", pvo_EntidadDeduccion.ValorDeduccion1)
                vlo_SqlCommand.Parameters.AddWithValue("@ValorDeduccion2", pvo_EntidadDeduccion.ValorDeduccion2)

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
        Public Function Eliminar(pvo_EntidadPago As clsDeducciones) As Integer
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vln_IdResultado As Integer = -1
            Dim vlc_Sentencia As String = String.Empty

            vlo_SqlCommand.Connection = vlo_SqlConnection
            Try
                vlc_Sentencia = "DELETE FROM Deducciones WHERE Cod_Deduccion = @Cod_Deduccion"

                vlo_SqlCommand.Parameters.AddWithValue("@Cod_Deduccion", pvo_EntidadPago.Cod_Deduccion)

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

            vlc_Sentencia = "SELECT Cod_Deduccion, Descripcion, Monto, Tipo, ValorDeduccio1, ValorDeduccion2 FROM Deducciones"

            If Not String.IsNullOrEmpty(pvc_Condicion) Then
                '' el 0 representa la vlc_Sentencia y el 1 la pvc_Condicion
                vlc_Sentencia = String.Format("{0} WHERE {1}", vlc_Sentencia, pvc_Condicion)
            End If
            If Not String.IsNullOrEmpty(pvc_Orden) Then
                vlc_Sentencia = String.Format("{0} ORDER BY {1}", vlc_Sentencia, pvc_Orden)
            End If
            Try
                vlo_SqlDataAdapter = New SqlDataAdapter(vlc_Sentencia, vlo_SqlConnection)
                vlo_SqlDataAdapter.Fill(vlo_dsDatos, "Deducciones")
            Catch ex As Exception
                Throw
            Finally
                vlo_SqlConnection.Dispose()
            End Try
            Return vlo_dsDatos
        End Function
        ''cuando la sentencia es un select hay que usarlo con executedatareader
        Public Function ObtenerRegistro(ByVal pvc_Condicion As String) As clsDeducciones
            Dim vlo_SqlConnection As New SqlConnection(vgc_CadenaConexion)
            Dim vlo_SqlCommand As New SqlCommand
            Dim vlo_SqlDataReader As SqlDataReader
            Dim vlc_Sentencia As String = String.Empty
            Dim vlo_EntidadPago As New clsDeducciones

            vlc_Sentencia = "SELECT Cod_Deduccion, Descripcion, Monto, Tipo, ValorDeduccion1, ValorDeduccion2 FROM Deducciones"

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
                    vlo_EntidadPago.ExisteRegistro = True
                    vlo_EntidadPago.Cod_Deduccion = CType(vlo_SqlDataReader("Cod_Deduccion"), Integer)
                    vlo_EntidadPago.Descripcion = CType(vlo_SqlDataReader("Descripcion"), String)
                    vlo_EntidadPago.Monto = CType(vlo_SqlDataReader("Monto"), Double)
                    vlo_EntidadPago.Tipo = CType(vlo_SqlDataReader("Tipo"), Integer)
                    vlo_EntidadPago.ValorDeduccion1 = CType(vlo_SqlDataReader("ValorDeduccion1"), Double)
                    vlo_EntidadPago.ValorDeduccion2 = CType(vlo_SqlDataReader("ValorDeduccion2"), Double)

                End If
                vlo_SqlConnection.Close()

            Catch ex As Exception
                Throw
            Finally
                vlo_SqlCommand.Dispose()
                vlo_SqlConnection.Dispose()
            End Try
            Return vlo_EntidadPago
        End Function
#End Region
    End Class
End Namespace