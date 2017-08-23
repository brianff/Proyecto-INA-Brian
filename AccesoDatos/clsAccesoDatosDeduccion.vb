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
#End Region
    End Class
End Namespace