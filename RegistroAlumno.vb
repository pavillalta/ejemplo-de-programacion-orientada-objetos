Public Class RegistroAlumno

    Dim alumno As New Alumno

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        alumno.datosAlumno(TxtCodigo.Text, txtNombre.Text, txtApellido.Text, txtSexo.Text, txtDireccion.Text)

        If alumno.datosAceptados Then
            MsgBox("Datos de " & alumno.nombreAlumno & "Registrados")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text = "" Then
            MsgBox("Debe agregar un nombre")

        Else
            TxtCodigo.Text = alumno.generarCodigo(txtNombre.Text)

            'Datagridview.Rows.Add(TxtFecha.Text, TxtDeposito.Text)

        End If
    End Sub
End Class