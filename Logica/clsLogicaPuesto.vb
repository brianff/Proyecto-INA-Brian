Imports AccesoDatos.AccesoDatos
Imports Configuracion.Configuracion
Imports Entidades.EntidadPuesto
Imports System.Data
Imports System.Data.Common

Namespace Logica
    Public Class clsLogicaPuesto
#Region "Metodos"
        Public Function InsertarPuesto(pvo_EntidadPuesto As clsPuestos) As Integer
            ''variables
            Dim vln_Resultado As Integer = 0
            Dim vlo_DA_Puesto As clsAccesoDatosPuesto
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Puesto = New clsAccesoDatosPuesto(vlo_Config.GetConnectionString)

                vln_Resultado = vlo_DA_Puesto.Insertar(pvo_EntidadPuesto)

            Catch ex As Exception
                Throw
            End Try
            Return vln_Resultado
        End Function

        Public Function ModificarPuesto(pvo_EntidadPuesto As clsPuestos) As Integer
            ''variables
            Dim vln_Resultado As Integer = 0
            Dim vlo_DA_Puesto As clsAccesoDatosPuesto
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Puesto = New clsAccesoDatosPuesto(vlo_Config.GetConnectionString)

                vln_Resultado = vlo_DA_Puesto.Modificar(pvo_EntidadPuesto)

            Catch ex As Exception
                Throw
            End Try
            Return vln_Resultado
        End Function
        Public Function EliminarPuesto(pvo_EntidadPuesto As clsPuestos) As Integer
            ''variables
            Dim vln_Resultado As Integer = 0
            Dim vlo_DA_Puesto As clsAccesoDatosPuesto
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Puesto = New clsAccesoDatosPuesto(vlo_Config.GetConnectionString)

                vln_Resultado = vlo_DA_Puesto.Eliminar(pvo_EntidadPuesto)

            Catch ex As Exception
                Throw
            End Try
            Return vln_Resultado
        End Function
        Public Function ListarRegistros(ByVal pvc_Condicion As String, ByVal pvc_Orden As String) As DataSet
            ''variables
            Dim vlo_dsDatos As DataSet
            Dim vlo_DA_Puesto As clsAccesoDatosPuesto
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Puesto = New clsAccesoDatosPuesto(vlo_Config.GetConnectionString)

                vlo_dsDatos = vlo_DA_Puesto.ListarRegistros(pvc_Condicion, pvc_Orden)

            Catch ex As Exception
                Throw
            End Try
            Return vlo_dsDatos
        End Function
        Public Function ObtenerRegistros(ByVal pvc_Condicion As String) As clsPuestos
            ''variables
            Dim vlo_EntidadCliente As clsPuestos
            Dim vlo_DA_Puesto As clsAccesoDatosPuesto
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Puesto = New clsAccesoDatosPuesto(vlo_Config.GetConnectionString)

                vlo_EntidadCliente = vlo_DA_Puesto.ObtenerRegistro(pvc_Condicion)

            Catch ex As Exception
                Throw
            End Try
            Return vlo_EntidadCliente
        End Function
#End Region
    End Class
End Namespace