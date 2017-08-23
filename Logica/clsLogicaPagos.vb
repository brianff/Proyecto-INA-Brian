Imports AccesoDatos.AccesoDatos
Imports Configuracion.Configuracion
Imports Entidades.EntidadPagos
Imports System.Data
Imports System.Data.Common

Namespace Logica
    Public Class clsLogicaPagos
#Region "Metodos"
        Public Function InsertarPago(pvo_EntidadPago As clsPagos) As Integer
            ''variables
            Dim vln_Resultado As Integer = 0
            Dim vlo_DA_Pago As clsAccesoDatosPagos
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Pago = New clsAccesoDatosPagos(vlo_Config.GetConnectionString)

                vln_Resultado = vlo_DA_Pago.Insertar(pvo_EntidadPago)

            Catch ex As Exception
                Throw
            End Try
            Return vln_Resultado
        End Function

        Public Function ModificarPago(pvo_EntidadPago As clsPagos) As Integer
            ''variables
            Dim vln_Resultado As Integer = 0
            Dim vlo_DA_Pago As clsAccesoDatosPagos
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Pago = New clsAccesoDatosPagos(vlo_Config.GetConnectionString)

                vln_Resultado = vlo_DA_Pago.Modificar(pvo_EntidadPago)

            Catch ex As Exception
                Throw
            End Try
            Return vln_Resultado
        End Function
        Public Function ElimimarPago(pvo_EntidadPago As clsPagos) As Integer
            ''variables
            Dim vln_Resultado As Integer = 0
            Dim vlo_DA_Pago As clsAccesoDatosPagos
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Pago = New clsAccesoDatosPagos(vlo_Config.GetConnectionString)

                vln_Resultado = vlo_DA_Pago.Eliminar(pvo_EntidadPago)

            Catch ex As Exception
                Throw
            End Try
            Return vln_Resultado
        End Function
        Public Function ListarRegistros(ByVal pvc_Condicion As String, ByVal pvc_Orden As String) As DataSet
            ''variables
            Dim vlo_dsDatos As DataSet
            Dim vlo_DA_Pago As clsAccesoDatosPagos
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Pago = New clsAccesoDatosPagos(vlo_Config.GetConnectionString)

                vlo_dsDatos = vlo_DA_Pago.ListarRegistros(pvc_Condicion, pvc_Orden)

            Catch ex As Exception
                Throw
            End Try
            Return vlo_dsDatos
        End Function
        Public Function ObtenerRegistros(ByVal pvc_Condicion As String) As clsPagos
            ''variables
            Dim vlo_EntidadCliente As clsPagos
            Dim vlo_DA_Pago As clsAccesoDatosPagos
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Pago = New clsAccesoDatosPagos(vlo_Config.GetConnectionString)

                vlo_EntidadCliente = vlo_DA_Pago.ObtenerRegistro(pvc_Condicion)

            Catch ex As Exception
                Throw
            End Try
            Return vlo_EntidadCliente
        End Function
#End Region
    End Class
End Namespace