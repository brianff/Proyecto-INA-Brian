Imports Entidades.EntidadPuesto
Imports Logica.Logica
Public Class frmPuestos
    ''variables
    Dim Registro_Nuevo As Boolean
    Dim EntidadRegistrada As clsPuestos

    Public Sub Limpiar()
        txtNombre.Text = String.Empty
        txtSalarioB.Text = String.Empty
        txtCod.Text = String.Empty
        rbCat1.Checked = True
        rbCat2.Checked = False
        Registro_Nuevo = True
    End Sub
    Private Function GenerarPuesto() As clsPuestos
        Dim vlo_EntidadPuesto As clsPuestos

        Try
            '' si el objeto cliente No existe se genera uno nuevo
            '' si no se le asigna el objeto ya registrado
            If Registro_Nuevo = True Then
                vlo_EntidadPuesto = New clsPuestos
            Else
                vlo_EntidadPuesto = EntidadRegistrada
            End If
            vlo_EntidadPuesto.Nombre_Puesto = txtNombre.Text.Trim ''el .Trim es para eliminar espacios
            vlo_EntidadPuesto.SalarioBase = txtSalarioB.Text.Trim
            If rbCat1.Checked = True Then
                vlo_EntidadPuesto.Categoria = 1
            ElseIf rbCat2.Checked = True Then
                vlo_EntidadPuesto.Categoria = 2
            End If
        Catch ex As Exception
            Throw
        End Try
        Return vlo_EntidadPuesto
    End Function
    Public Function GuardarPuesto() As Integer
        Dim vlo_EntidadPuesto As clsPuestos
        Dim vlo_LogicaPuesto As New clsLogicaPuesto
        Dim vln_Resultado As Integer = 0

        Try
            vlo_EntidadPuesto = GenerarPuesto()
            If Registro_Nuevo = True Then
                vln_Resultado = vlo_LogicaPuesto.InsertarPuesto(vlo_EntidadPuesto)
            Else
                vln_Resultado = vlo_LogicaPuesto.ModificarPuesto(vlo_EntidadPuesto)
            End If
            If vln_Resultado > 0 Then
                MessageBox.Show("Operación realizada satisfactoriamente", "Información")
            End If
            Limpiar()
            CargarListaPuestos()
        Catch ex As Exception
            Throw
        End Try
        Return vln_Resultado
    End Function
    Private Sub CargarListaPuestos()
        Dim vlo_dsDatos As DataSet
        Dim vlo_LogicaPuesto As New clsLogicaPuesto
        Try
            vlo_dsDatos = vlo_LogicaPuesto.ListarRegistros(String.Empty, String.Empty)

            If Not vlo_dsDatos Is Nothing Then
                dgvListaPuestos.DataSource = vlo_dsDatos
                dgvListaPuestos.DataMember = vlo_dsDatos.Tables(0).TableName
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If Not String.IsNullOrEmpty(txtNombre.Text) And
                    Not String.IsNullOrEmpty(txtSalarioB.Text) Then
                GuardarPuesto()
            Else
                MessageBox.Show("Faltan Datos", "Mensaje")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frmPuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Limpiar()
            CargarListaPuestos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Limpiar()
            CargarListaPuestos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub CargarDatos(ByVal pvn_Cod_Puesto As Integer)
        Dim vlo_LogicaPuesto As New clsLogicaPuesto
        Dim vlo_EntidadPuesto As clsPuestos
        Dim vlc_Condicion As String

        Try
            vlc_Condicion = String.Format("Cod_Puesto = {0}", pvn_Cod_Puesto.ToString)
            vlo_EntidadPuesto = vlo_LogicaPuesto.ObtenerRegistros(vlc_Condicion)

            If vlo_EntidadPuesto.ExisteRegistro Then
                With vlo_EntidadPuesto
                    txtNombre.Text = .Nombre_Puesto
                    txtSalarioB.Text = .SalarioBase
                    txtCod.Text = .Cod_Puesto
                    If vlo_EntidadPuesto.Categoria = 1 Then
                        rbCat1.Checked = True
                        rbCat2.Checked = False
                    Else
                        rbCat1.Checked = False
                        rbCat2.Checked = True
                    End If
                End With
                EntidadRegistrada = vlo_EntidadPuesto
                Registro_Nuevo = False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub dgvListaPuestos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaPuestos.CellDoubleClick
        Dim vln_codpuesto As Integer
        Try
            ''verificar si tiene filas
            If dgvListaPuestos.RowCount > 0 Then
                ''verifica si tiene algo
                If dgvListaPuestos.SelectedRows(0).Cells(0).Value.ToString <> String.Empty Then
                    vln_codpuesto = CType(dgvListaPuestos.CurrentRow.Cells.Item(0).Value, Integer)
                    CargarDatos(vln_codpuesto)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Eliminar(pvn_codpuesto As Integer)
        Dim vlo_LogicaPuesto As New clsLogicaPuesto
        Dim vlo_EntidadPuesto As clsPuestos
        Dim vlc_Condicion As String

        Try
            If Not String.IsNullOrEmpty(txtCod.Text) Then
                vlc_Condicion = String.Format("Cod_Puesto = {0}", pvn_codpuesto.ToString)
                vlo_EntidadPuesto = vlo_LogicaPuesto.ObtenerRegistros(vlc_Condicion)

                If vlo_EntidadPuesto.ExisteRegistro Then
                    If vlo_LogicaPuesto.EliminarPuesto(vlo_EntidadPuesto) > 0 Then
                        MessageBox.Show("Operación realizada satisfactoriamente")
                    Else
                        MessageBox.Show("El puesto no se pudo eliminar")
                    End If
                End If
                Limpiar()
                CargarListaPuestos()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Not String.IsNullOrEmpty(txtCod.Text) Then
                Eliminar(CType(txtCod.Text, Integer))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class