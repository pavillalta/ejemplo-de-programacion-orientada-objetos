<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroAlumno
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
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.grpCodigo.SuspendLayout()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCodigo
        '
        Me.grpCodigo.Controls.Add(Me.TxtCodigo)
        Me.grpCodigo.Controls.Add(Me.btnGenerar)
        Me.grpCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCodigo.Location = New System.Drawing.Point(35, 62)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Size = New System.Drawing.Size(417, 77)
        Me.grpCodigo.TabIndex = 0
        Me.grpCodigo.TabStop = False
        Me.grpCodigo.Text = "Generar Código"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(18, 36)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(197, 24)
        Me.TxtCodigo.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(257, 25)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(148, 35)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Código"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.Label3)
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.btnAgregar)
        Me.grpDatos.Controls.Add(Me.txtDireccion)
        Me.grpDatos.Controls.Add(Me.txtSexo)
        Me.grpDatos.Controls.Add(Me.txtApellido)
        Me.grpDatos.Controls.Add(Me.txtNombre)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(35, 161)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(753, 264)
        Me.grpDatos.TabIndex = 1
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos de Alumno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Género"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(257, 192)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(148, 34)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Alumno"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(152, 152)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(253, 24)
        Me.txtDireccion.TabIndex = 3
        '
        'txtSexo
        '
        Me.txtSexo.Location = New System.Drawing.Point(152, 113)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(79, 24)
        Me.txtSexo.TabIndex = 2
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(152, 74)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(253, 24)
        Me.txtApellido.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(152, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(253, 24)
        Me.txtNombre.TabIndex = 0
        '
        'RegistroAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpDatos)
        Me.Controls.Add(Me.grpCodigo)
        Me.Name = "RegistroAlumno"
        Me.Text = "RegistroAlumno"
        Me.grpCodigo.ResumeLayout(False)
        Me.grpCodigo.PerformLayout()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
