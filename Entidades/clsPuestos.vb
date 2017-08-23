Namespace EntidadPuesto
    Public Class clsPuestos
        Private vgn_Cod_Puesto As Integer
        Private vgc_Nombre_Puesto As String
        Private vgn_Categoria As Integer
        Private vgn_SalarioBase As Double
        Private vgb_ExisteRegistro As Boolean

        Public Sub New(vgn_Cod_Puesto As Integer, vgc_Nombre_Puesto As String, vgn_Categoria As Integer, vgn_SalarioBase As Double, vgb_ExisteRegistro As Boolean)
            Me.vgn_Cod_Puesto = vgn_Cod_Puesto
            Me.vgc_Nombre_Puesto = vgc_Nombre_Puesto
            Me.vgn_Categoria = vgn_Categoria
            Me.vgn_SalarioBase = vgn_SalarioBase
            Me.vgb_ExisteRegistro = vgb_ExisteRegistro
        End Sub
        Public Sub New()
            vgn_Cod_Puesto = 0
            vgc_Nombre_Puesto = String.Empty
            vgn_Categoria = 0
            vgn_SalarioBase = 0
            vgb_ExisteRegistro = False
        End Sub
        Public Property Cod_Puesto As Integer
            Get
                Return vgn_Cod_Puesto
            End Get
            Set(value As Integer)
                vgn_Cod_Puesto = value
            End Set
        End Property

        Public Property Nombre_Puesto As String
            Get
                Return vgc_Nombre_Puesto
            End Get
            Set(value As String)
                vgc_Nombre_Puesto = value
            End Set
        End Property

        Public Property Categoria As Integer
            Get
                Return vgn_Categoria
            End Get
            Set(value As Integer)
                vgn_Categoria = value
            End Set
        End Property

        Public Property SalarioBase As Double
            Get
                Return vgn_SalarioBase
            End Get
            Set(value As Double)
                vgn_SalarioBase = value
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