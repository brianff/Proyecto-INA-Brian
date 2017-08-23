Public Class frmPrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PuestosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PuestosToolStripMenuItem1.Click
        Dim Puestos As New frmPuestos
        Puestos.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Dim Empleado As New frmEmpleados
        Empleado.Show()
    End Sub
End Class
