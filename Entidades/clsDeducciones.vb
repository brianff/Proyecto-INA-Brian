Namespace EntidadDeduccion
    Public Class clsDeducciones
        Private vgn_Cod_Deduccion As Integer
        Private vgc_Descripcion As String
        Private vgn_Monto As Double
        Private vgn_Tipo As Integer
        Private vgn_ValorDeduccion1 As Double
        Private vgn_ValorDeduccion2 As Double
        Private vgb_ExisteRegistro As Boolean

        Public Sub New(vgn_Cod_Deduccion As Integer, vgc_Descripcion As String, vgn_Monto As Double, vgn_Tipo As Integer, vgn_ValorPago1 As Double, vgn_ValorPago2 As Double, vgb_ExisteRegistro As Boolean)
            Me.vgn_Cod_Deduccion = vgn_Cod_Deduccion
            Me.vgc_Descripcion = vgc_Descripcion
            Me.vgn_Monto = vgn_Monto
            Me.vgn_Tipo = vgn_Tipo
            Me.vgn_ValorDeduccion1 = vgn_ValorPago1
            Me.vgn_ValorDeduccion2 = vgn_ValorPago2
            Me.vgb_ExisteRegistro = vgb_ExisteRegistro
        End Sub
        Public Sub New()
            vgn_Cod_Deduccion = 0
            vgc_Descripcion = String.Empty
            vgn_Monto = 0
            vgn_Tipo = 0
            vgn_ValorDeduccion1 = 0
            vgn_ValorDeduccion2 = 0
            vgb_ExisteRegistro = False
        End Sub
        Public Property Cod_Deduccion As Integer
            Get
                Return vgn_Cod_Deduccion
            End Get
            Set(value As Integer)
                vgn_Cod_Deduccion = value
            End Set
        End Property

        Public Property Descripcion As String
            Get
                Return vgc_Descripcion
            End Get
            Set(value As String)
                vgc_Descripcion = value
            End Set
        End Property

        Public Property Monto As Double
            Get
                Return vgn_Monto
            End Get
            Set(value As Double)
                vgn_Monto = value
            End Set
        End Property

        Public Property Tipo As Integer
            Get
                Return vgn_Tipo
            End Get
            Set(value As Integer)
                vgn_Tipo = value
            End Set
        End Property

        Public Property ValorDeduccion1 As Double
            Get
                Return vgn_ValorDeduccion1
            End Get
            Set(value As Double)
                vgn_ValorDeduccion1 = value
            End Set
        End Property

        Public Property ValorDeduccion2 As Double
            Get
                Return vgn_ValorDeduccion2
            End Get
            Set(value As Double)
                vgn_ValorDeduccion2 = value
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