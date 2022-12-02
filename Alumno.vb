Public Class Alumno

    'Declaración de variables
    Private Codigo As String
    Private nombre As String
    Private apellido As String
    Private sexo As String
    Private direccion As String

    'datos completos
    Private datosCompletos As Boolean

    'Metodos

    'Procesar nombre
    Public Property nombreAlumno() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    'Procesar apellido
    Private Property ApellidoAlumno() As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    'Procesar genero
    Private Property sexoAlumno() As String
        Get
            Return sexo
        End Get
        Set(value As String)
            sexo = value
        End Set
    End Property

    'Procesar direccion
    Private Property direccionAlumno() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    'metodo datos aceptados
    Public ReadOnly Property datosAceptados() As Boolean
        Get
            Return datosCompletos
        End Get
    End Property

    'Constructor de clase
    Public Sub New()
        datosCompletos = False
    End Sub


    'Determina si los datos ingresados son correctos.
    Public Sub datosAlumno(ByVal codigoA As String, ByVal nombreA As String, ByVal apellidoA As String, ByVal sexoA As String, ByVal direccionA As String)

        datosCompletos = False 'si los datos son incorrectos

        If codigoA.Length = 0 Then
            MsgBox("Debe generar el código del alumno")
        Else
            Codigo = codigoA
        End If

        If nombreA.Length = 0 Then
            MsgBox("Debe escribir el nombre del alumno")
        Else
            nombre = nombreA
        End If

        If apellidoA.Length = 0 Then
            MsgBox("Debe escribir apellido del alumno")
        Else
            apellido = apellidoA
        End If

        If sexoA.Length = 0 Then
            MsgBox("Debe escribir el sexo del alumno")
        Else
            sexo = sexoA
        End If

        If sexoA = "F" Or sexoA = "M" Then
            MsgBox("Debe esdcribir F para femenido o M para masculino")
        End If

        If direccionA.Length = 0 Then
            MsgBox("Debe escribir dirección del alumno")
        Else
            direccion = direccionA
            datosCompletos = True
        End If

    End Sub

    Public Function generarCodigo(ByVal nombre As String)
        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        'Primera letra del nombre en mayuscula
        valor1 = UCase(Left(nombre, 1))
        'Ultimas dos letras del nombre
        valor2 = Right(nombre, 2)
        'Generacion de numero aleatorio
        numero = Int(Rnd() * 1000) + 65

        'Retornar codigo generado
        Return valor1 & numero & valor2

    End Function

End Class
