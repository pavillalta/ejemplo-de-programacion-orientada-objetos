Public Class RegistroAlumno

    Dim alumno As New Alumno

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        If txtnombre.Text = "" Then
            MsgBox("Debe agregar un nombre")

        Else
            Txtcodigo.Text = alumno.generarCodigo(txtnombre.Text)
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        alumno.datosAlumno(Txtcodigo.Text,
                           txtnombre.Text,
                           txtapellido.Text,
                           txtgenero.Text,
                           txtdireccion.Text,
                           txtdui.Text,
                           txtedad.Text,
                           txtcorreo.Text)

        datosAlumno.Rows.Add(Txtcodigo.Text,
                             alumno.nombreAlumno,
                             alumno.apellidoAlumno,
                             alumno.generoAlumno,
                             alumno.direccionAlumno,
                             alumno.duiAlumno,
                             alumno.edadAlumno,
                             alumno.correoAlumno)

        If alumno.datosAceptados Then
            MsgBox("Datos de " & alumno.nombreAlumno & "Registrados con Éxito")
        End If

        Txtcodigo.Text = ""
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtgenero.Text = ""
        txtdireccion.Text = ""
        txtdui.Text = ""
        txtedad.Text = ""
        txtcorreo.Text = ""

    End Sub

End Class