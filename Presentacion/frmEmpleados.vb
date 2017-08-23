Imports Entidades.EntidadEmpleado
Imports Logica.Logica
Public Class frmEmpleados
    ''variables
    Dim Registro_Nuevo As Boolean
    Dim EntidadRegistrada As clsEmpleado
    Public Sub Limpiar()
        txtId.Text = String.Empty
        txtNombre.Text = String.Empty
        txtApellido1.Text = String.Empty
        txtApellido2.Text = String.Empty
        txtTelefono.Text = String.Empty
        txtProvincia.Text = String.Empty
        txtCanton.Text = String.Empty
        txtDistrito.Text = String.Empty
        txtOtras_S.Text = String.Empty
        chkPension.Checked = False
        txtCantPension.Text = String.Empty
        txtPuesto.Text = String.Empty
        Registro_Nuevo = True
    End Sub
    Private Function GenerarEmpleado() As clsEmpleado
        Dim vlo_EntidadEmpleado As clsEmpleado

        Try
            '' si el objeto cliente No existe se genera uno nuevo
            '' si no se le asigna el objeto ya registrado
            If Registro_Nuevo = True Then
                vlo_EntidadEmpleado = New clsEmpleado
            Else
                vlo_EntidadEmpleado = EntidadRegistrada
            End If
            vlo_EntidadEmpleado.Identificacion = txtId.Text.Trim ''el .Trim es para eliminar espacios
            vlo_EntidadEmpleado.Nombre = txtNombre.Text.Trim
            vlo_EntidadEmpleado.Apellido1 = txtApellido1.Text.Trim
            vlo_EntidadEmpleado.Apellido2 = txtApellido2.Text.Trim
            vlo_EntidadEmpleado.Telefono = txtTelefono.Text.Trim
            vlo_EntidadEmpleado.Provincia = txtProvincia.Text.Trim
            vlo_EntidadEmpleado.Canton = txtCanton.Text.Trim
            vlo_EntidadEmpleado.Distrito = txtDistrito.Text.Trim
            vlo_EntidadEmpleado.OtrasSenias = txtOtras_S.Text.Trim
            If chkPension.Checked = True Then
                vlo_EntidadEmpleado.Pension = txtCantPension.Text.Trim
            Else
                vlo_EntidadEmpleado.Pension = 0
            End If
        Catch ex As Exception
            Throw
        End Try
        Return vlo_EntidadEmpleado
    End Function

    Private Sub chkPension_CheckedChanged(sender As Object, e As EventArgs) Handles chkPension.CheckedChanged
        If chkPension.Checked = True Then
            lblPension.Visible = True
            txtCantPension.Visible = True
        ElseIf chkPension.Checked = False Then
            lblPension.Visible = False
            txtCantPension.Visible = False
        End If
    End Sub

    Public Function GuardarEmpleado() As Integer
        Dim vlo_EntidadEmpleado As clsEmpleado
        Dim vlo_LogicaEmpleado As New clsLogicaEmpleado
        Dim vln_Resultado As Integer = 0

        Try
            vlo_EntidadEmpleado = GenerarEmpleado()
            If Registro_Nuevo = True Then
                vln_Resultado = vlo_LogicaEmpleado.InsertarEmpleado(vlo_EntidadEmpleado)
            Else
                vln_Resultado = vlo_LogicaEmpleado.ModificarEmpleado(vlo_EntidadEmpleado)
            End If
            If vln_Resultado > 0 Then
                MessageBox.Show("Operación realizada satisfactoriamente", "Información")
            End If
            Limpiar()
        Catch ex As Exception
            Throw
        End Try
        Return vln_Resultado
    End Function
    'Private Sub CargarListaEmpleados()
    '    Dim vlo_dsDatos As DataSet
    '    Dim vlo_LogicaEmpleado As New clsLogicaEmpleado
    '    Try
    '        vlo_dsDatos = vlo_LogicaEmpleado.ListarRegistros(String.Empty, String.Empty)

    '        If Not vlo_dsDatos Is Nothing Then
    '            dgvListaPuestos.DataSource = vlo_dsDatos
    '            dgvListaPuestos.DataMember = vlo_dsDatos.Tables(0).TableName
    '        End If
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim bandera As Boolean = True
        Try
            If Not String.IsNullOrEmpty(txtId.Text) And
                    Not String.IsNullOrEmpty(txtNombre.Text) And
                    Not String.IsNullOrEmpty(txtApellido1.Text) And
                    Not String.IsNullOrEmpty(txtApellido2.Text) And
                    Not String.IsNullOrEmpty(txtTelefono.Text) And
                    Not String.IsNullOrEmpty(txtProvincia.Text) And
                    Not String.IsNullOrEmpty(txtCanton.Text) And
                    Not String.IsNullOrEmpty(txtDistrito.Text) And
                    Not String.IsNullOrEmpty(txtOtras_S.Text) And
                    Not String.IsNullOrEmpty(txtPuesto.Text) Then
                If chkPension.Checked = True Then
                    If String.IsNullOrEmpty(txtCantPension.Text) Then
                        bandera = False
                        MessageBox.Show("Debe digitar una cantidad de pensiones,  si tiene 1 o más", "Mensaje")
                    End If
                End If
                If bandera = True Then
                    GuardarEmpleado()
                End If
            Else
                MessageBox.Show("Faltan Datos", "Mensaje")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Public Sub Eliminar(pvn_identificacion As Integer)
        Dim vlo_LogicaEmpleado As New clsLogicaEmpleado
        Dim vlo_EntidadEmpleado As clsEmpleado
        Dim vlc_Condicion As String

        Try
            If Not String.IsNullOrEmpty(txtId.Text) Then
                vlc_Condicion = String.Format("Identificacion = {0}", pvn_identificacion.ToString)
                vlo_EntidadEmpleado = vlo_LogicaEmpleado.ObtenerRegistros(vlc_Condicion)

                If vlo_EntidadEmpleado.ExisteRegistro Then
                    If vlo_LogicaEmpleado.EliminarEmpleado(vlo_EntidadEmpleado) > 0 Then
                        MessageBox.Show("Operación realizada satisfactoriamente")
                    Else
                        MessageBox.Show("El empleado no se pudo eliminar")
                    End If
                End If
                Limpiar()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not String.IsNullOrEmpty(txtId.Text) Then
                Eliminar(CType(txtId.Text, Integer))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class