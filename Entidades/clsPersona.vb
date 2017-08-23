Public MustInherit Class clsPersona
    Protected vgn_Identificacion As Integer
    Protected vgc_Nombre As String
    Protected vgc_Apellido1 As String
    Protected vgc_Apellido2 As String
    Protected vgc_Telefono As String
    Protected vgc_Provincia As String
    Protected vgc_Canton As String
    Protected vgc_Distrito As String
    Protected vgc_OtrasSenias As String

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
    End Sub
End Class
