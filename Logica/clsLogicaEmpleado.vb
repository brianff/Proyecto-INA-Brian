Imports AccesoDatos.AccesoDatos
Imports Configuracion.Configuracion
Imports Entidades.EntidadEmpleado
Imports System.Data
Imports System.Data.Common

Namespace Logica
    Public Class clsLogicaEmpleado
#Region "Metodos"
        Public Function InsertarEmpleado(pvo_EntidadEmpleado As clsEmpleado) As Integer
            ''variables
            Dim vln_Resultado As Integer = 0
            Dim vlo_DA_Empleado As clsAccesoDatosEmpleado
            Dim vlo_Config As clsConfiguracion

            Try
                vlo_Config = New clsConfiguracion()
                vlo_DA_Empleado = New clsAccesoDatosEmpleado(vlo_Config.GetConnectionString)

                vln_Resultado = vlo_DA_Empleado.Insertar(pvo_EntidadEmpleado)

            Catch ex As Exception
                Throw
            End Try
            Return vln_Resultado
        End Function
        Public Function ModificarEmpleado(pvo_EntidadEmpleado As clsEmpleado) As Integer
            ''variables
            Dim vln_Resultado As Integer = 0
            Dim vlo_DA_Empleado As clsAccesoDatosEmpleado
            Dim vlo_Config As clsConfiguracion

            Try
                vlo_Config = New clsConfiguracion()
                vlo_DA_Empleado = New clsAccesoDatosEmpleado(vlo_Config.GetConnectionString)

                vln_Resultado = vlo_DA_Empleado.Modificar(pvo_EntidadEmpleado)

            Catch ex As Exception
                Throw
            End Try
            Return vln_Resultado
        End Function
        Public Function EliminarEmpleado(pvo_EntidadEmpleado As clsEmpleado) As Integer
            ''variables
            Dim vln_Resultado As Integer = 0
            Dim vlo_DA_Empleado As clsAccesoDatosEmpleado
            Dim vlo_Config As clsConfiguracion

            Try
                vlo_Config = New clsConfiguracion()
                vlo_DA_Empleado = New clsAccesoDatosEmpleado(vlo_Config.GetConnectionString)

                vln_Resultado = vlo_DA_Empleado.Eliminar(pvo_EntidadEmpleado)

            Catch ex As Exception
                Throw
            End Try
            Return vln_Resultado
        End Function
        Public Function ListarRegistros(ByVal pvc_Condicion As String, ByVal pvc_Orden As String) As DataSet
            ''variables
            Dim vlo_dsDatos As DataSet
            Dim vlo_DA_Empleado As clsAccesoDatosEmpleado
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Empleado = New clsAccesoDatosEmpleado(vlo_Config.GetConnectionString)

                vlo_dsDatos = vlo_DA_Empleado.ListarRegistros(pvc_Condicion, pvc_Orden)

            Catch ex As Exception
                Throw
            End Try
            Return vlo_dsDatos
        End Function
        Public Function ObtenerRegistros(ByVal pvc_Condicion As String) As clsEmpleado
            ''variables
            Dim vlo_EntidadEmpleado As clsEmpleado
            Dim vlo_DA_Empleado As clsAccesoDatosEmpleado
            Dim vlo_Config As clsConfiguracion

            Try
                ''Se abren las instancias
                vlo_Config = New clsConfiguracion()
                vlo_DA_Empleado = New clsAccesoDatosEmpleado(vlo_Config.GetConnectionString)

                vlo_EntidadEmpleado = vlo_DA_Empleado.ObtenerRegistro(pvc_Condicion)

            Catch ex As Exception
                Throw
            End Try
            Return vlo_EntidadEmpleado
        End Function
#End Region
    End Class
End Namespace