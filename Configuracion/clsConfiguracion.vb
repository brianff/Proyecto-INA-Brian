Imports System.Configuration
Namespace Configuracion
    Public Class clsConfiguracion
        Public ReadOnly Property GetConnectionString() As String
            Get
                Return ConfigurationManager.AppSettings("ConnectionString")
            End Get
        End Property
    End Class
End Namespace