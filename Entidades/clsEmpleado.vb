Namespace EntidadEmpleado
    Public Class clsEmpleado

        Inherits clsPersona

        Private vgc_Grado_Academico As String
        Private vgc_Titulo As String
        Private vgn_Pension As Integer
        Private vgn_CodPuesto As Integer
        Private vgb_ExisteRegistro As Boolean

        Public Sub New(vgn_Identificacion As Integer, vgc_Nombre As String, vgc_Apellido1 As String, vgc_Apellido2 As String, vgc_Telefono As String, vgc_Provincia As String, vgc_Canton As String, vgc_Distrito As String, vgc_OtrasSenias As String, vgc_Grado_Academico As String, vgc_Titulo As String, vgn_Pension As Integer, vgn_CodPuesto As Integer, vgb_ExisteRegistro As Boolean)
            Me.vgn_Identificacion = vgn_Identificacion
            Me.vgc_Nombre = vgc_Nombre
            Me.vgc_Apellido1 = vgc_Apellido1
            Me.vgc_Apellido2 = vgc_Apellido2
            Me.vgc_Telefono = vgc_Telefono
            Me.vgc_Provincia = vgc_Provincia
            Me.vgc_Canton = vgc_Canton
            Me.vgc_Distrito = vgc_Distrito
            Me.vgc_OtrasSenias = vgc_OtrasSenias
            Me.vgc_Grado_Academico = vgc_Grado_Academico
            Me.vgc_Titulo = vgc_Titulo
            Me.vgn_Pension = vgn_Pension
            Me.vgn_CodPuesto = vgn_CodPuesto
            Me.vgb_ExisteRegistro = vgb_ExisteRegistro
        End Sub
        Public Sub New()
            vgn_Identificacion = 0
            vgc_Nombre = String.Empty
            vgc_Apellido1 = String.Empty
            vgc_Apellido2 = String.Empty
            vgc_Telefono = String.Empty
            vgc_Provincia = String.Empty
            vgc_Canton = String.Empty
            vgc_Distrito = String.Empty
            vgc_OtrasSenias = String.Empty
            vgc_Grado_Academico = String.Empty
            vgc_Titulo = String.Empty
            vgn_Pension = 0
            vgn_CodPuesto = 0
            vgb_ExisteRegistro = False
        End Sub

        Public Property Identificacion As Integer
            Get
                Return vgn_Identificacion
            End Get
            Set(value As Integer)
                vgn_Identificacion = value
            End Set
        End Property

        Public Property Nombre As String
            Get
                Return vgc_Nombre
            End Get
            Set(value As String)
                vgc_Nombre = value
            End Set
        End Property

        Public Property Apellido1 As String
            Get
                Return vgc_Apellido1
            End Get
            Set(value As String)
                vgc_Apellido1 = value
            End Set
        End Property

        Public Property Apellido2 As String
            Get
                Return vgc_Apellido2
            End Get
            Set(value As String)
                vgc_Apellido2 = value
            End Set
        End Property

        Public Property Telefono As String
            Get
                Return vgc_Telefono
            End Get
            Set(value As String)
                vgc_Telefono = value
            End Set
        End Property

        Public Property Provincia As String
            Get
                Return vgc_Provincia
            End Get
            Set(value As String)
                vgc_Provincia = value
            End Set
        End Property

        Public Property Canton As String
            Get
                Return vgc_Canton
            End Get
            Set(value As String)
                vgc_Canton = value
            End Set
        End Property

        Public Property Distrito As String
            Get
                Return vgc_Distrito
            End Get
            Set(value As String)
                vgc_Distrito = value
            End Set
        End Property

        Public Property OtrasSenias As String
            Get
                Return vgc_OtrasSenias
            End Get
            Set(value As String)
                vgc_OtrasSenias = value
            End Set
        End Property

        Public Property Grado_Academico As String
            Get
                Return vgc_Grado_Academico
            End Get
            Set(value As String)
                vgc_Grado_Academico = value
            End Set
        End Property

        Public Property Titulo As String
            Get
                Return vgc_Titulo
            End Get
            Set(value As String)
                vgc_Titulo = value
            End Set
        End Property

        Public Property Pension As Integer
            Get
                Return vgn_Pension
            End Get
            Set(value As Integer)
                vgn_Pension = value
            End Set
        End Property

        Public Property CodPuesto As Integer
            Get
                Return vgn_CodPuesto
            End Get
            Set(value As Integer)
                vgn_CodPuesto = value
            End Set
        End Property
        Public Property ExisteRegistro As Boolean
            Get
                Return vgb_ExisteRegistro
            End Get
            Set(value As Boolean)
                vgb_ExisteRegistro = value
            End Set
        End Property
    End Class
End Namespace