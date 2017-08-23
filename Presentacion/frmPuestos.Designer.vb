<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuestos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPuestos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCat2 = New System.Windows.Forms.RadioButton()
        Me.rbCat1 = New System.Windows.Forms.RadioButton()
        Me.txtSalarioB = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListaPuestos = New System.Windows.Forms.DataGridView()
        Me.Cod_Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salario_Base = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListaPuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbCat2)
        Me.GroupBox1.Controls.Add(Me.rbCat1)
        Me.GroupBox1.Controls.Add(Me.txtSalarioB)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Puesto"
        '
        'rbCat2
        '
        Me.rbCat2.AutoSize = True
        Me.rbCat2.Location = New System.Drawing.Point(348, 116)
        Me.rbCat2.Name = "rbCat2"
        Me.rbCat2.Size = New System.Drawing.Size(31, 17)
        Me.rbCat2.TabIndex = 6
        Me.rbCat2.TabStop = True
        Me.rbCat2.Text = "2"
        Me.rbCat2.UseVisualStyleBackColor = True
        '
        'rbCat1
        '
        Me.rbCat1.AutoSize = True
        Me.rbCat1.Location = New System.Drawing.Point(302, 116)
        Me.rbCat1.Name = "rbCat1"
        Me.rbCat1.Size = New System.Drawing.Size(31, 17)
        Me.rbCat1.TabIndex = 5
        Me.rbCat1.TabStop = True
        Me.rbCat1.Text = "1"
        Me.rbCat1.UseVisualStyleBackColor = True
        '
        'txtSalarioB
        '
        Me.txtSalarioB.Location = New System.Drawing.Point(42, 117)
        Me.txtSalarioB.Name = "txtSalarioB"
        Me.txtSalarioB.Size = New System.Drawing.Size(155, 20)
        Me.txtSalarioB.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(42, 54)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(209, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salario Base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del puesto"
        '
        'dgvListaPuestos
        '
        Me.dgvListaPuestos.AllowUserToAddRows = False
        Me.dgvListaPuestos.AllowUserToDeleteRows = False
        Me.dgvListaPuestos.AllowUserToResizeRows = False
        Me.dgvListaPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod_Puesto, Me.Nombre_Puesto, Me.Categoria, Me.Salario_Base})
        Me.dgvListaPuestos.Location = New System.Drawing.Point(12, 177)
        Me.dgvListaPuestos.Name = "dgvListaPuestos"
        Me.dgvListaPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaPuestos.Size = New System.Drawing.Size(495, 150)
        Me.dgvListaPuestos.TabIndex = 1
        '
        'Cod_Puesto
        '
        Me.Cod_Puesto.DataPropertyName = "Cod_Puesto"
        Me.Cod_Puesto.HeaderText = "Codigo"
        Me.Cod_Puesto.Name = "Cod_Puesto"
        Me.Cod_Puesto.Width = 50
        '
        'Nombre_Puesto
        '
        Me.Nombre_Puesto.DataPropertyName = "Nombre_Puesto"
        Me.Nombre_Puesto.HeaderText = "Nombre"
        Me.Nombre_Puesto.Name = "Nombre_Puesto"
        Me.Nombre_Puesto.Width = 150
        '
        'Categoria
        '
        Me.Categoria.DataPropertyName = "Categoria"
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Width = 70
        '
        'Salario_Base
        '
        Me.Salario_Base.DataPropertyName = "Salario_Base"
        Me.Salario_Base.HeaderText = "SalarioBase"
        Me.Salario_Base.Name = "Salario_Base"
        Me.Salario_Base.Width = 160
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(213, 333)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(54, 41)
        Me.btnNuevo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnNuevo, "Nuevo")
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(286, 333)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(54, 41)
        Me.btnGuardar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(357, 333)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(54, 41)
        Me.btnEliminar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar")
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(453, 333)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(54, 41)
        Me.btnSalir.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnSalir, "Salir")
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Codigo"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.ForeColor = System.Drawing.SystemColors.Info
        Me.txtCod.Location = New System.Drawing.Point(299, 54)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(100, 20)
        Me.txtCod.TabIndex = 8
        '
        'frmPuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(519, 386)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvListaPuestos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPuestos"
        Me.Text = "frmPuestos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListaPuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbCat2 As RadioButton
    Friend WithEvents rbCat1 As RadioButton
    Friend WithEvents txtSalarioB As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dgvListaPuestos As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Cod_Puesto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Puesto As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Salario_Base As DataGridViewTextBoxColumn
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Label4 As Label
End Class
