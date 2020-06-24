Public Class BolsaSolidaria
#Region "Declaracion Departamentos"
    Private Atlantida(7) As String
    Private Colon(9) As String
    Private Comayagua(20) As String
    Private Copan(22) As String
    Private Cortes(11) As String
    Private Choluteca(15) As String
    Private Paraiso(19) As String
    Private FMorazan(28) As String
    Private GDios(5) As String
    Private Intibuca(17) As String
    Private IBahia(3) As String
    Private LaPaz(18) As String
    Private Lempira(17) As String
    Private Ocotepeque(15) As String
    Private Olancho(23) As String
    Private SantaBarbara(27) As String
    Private Valle(8) As String
    Private Yoro(11) As String

    Private Sub BolsaSolidaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
    Private Identidad(10) As String
    Private contador As Integer

    Private Sub Limpiar()
        txtID.Clear()
        txtNombre.Clear()
        cmbEstado.Text = ""
        txtIntegrantes.Clear()
        chkBasico.Checked = False
        chkRegular.Checked = False
        txtDepartamento.Clear()
        txtMunicipios.Clear()
        txtDireccion.Clear()

    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre, estado, tipoBolsa, departamento, municipios, direccion As String
        Dim NIntegrantes As Integer

        Try
            If txtNombre.Text = "" Or txtID.Text = "" Or cmbEstado.Text = "" Or txtIntegrantes.Text = "" Or txtDepartamento.Text = "" Or txtMunicipios.Text = "" Or txtDireccion.Text = "" Then
                MessageBox.Show("Debe llenar todos los campos", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            nombre = txtNombre.Text
            estado = cmbEstado.Text
            Identidad(contador) = txtID.Text

            If Identidad(contador).Length < 15 Then
                MessageBox.Show("Numero de Identidad incompleto", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtID.Focus()
                Exit Sub
            End If
            NIntegrantes = Val(txtIntegrantes.Text)
            departamento = txtDepartamento.Text
            municipios = txtMunicipios.Text
            direccion = txtDireccion.Text
            If chkBasico.Checked = True Then
                tipoBolsa = "Basica"
            Else
                tipoBolsa = "Regular"
            End If
            If contador <> 0 Then
                For i = 0 To contador - 1 Step 1
                    If Identidad(i) = Identidad(contador) Then
                        MessageBox.Show("Ya se le entrego Bolsa Solidaria a este Ciudadano", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
            End If


            DataHistorial.Rows.Add(Identidad(contador), nombre, estado, NIntegrantes, tipoBolsa, departamento, municipios, direccion)
            contador += 1
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub txtIntegrantes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIntegrantes.KeyPress
        Dim NIntegrantes As Integer
        NIntegrantes = Val(txtIntegrantes.Text)

        If NIntegrantes > 0 And NIntegrantes < 4 Then
            chkBasico.Checked = True
            chkRegular.Checked = False
        End If
        If NIntegrantes > 3 Then
            chkRegular.Checked = True
            chkBasico.Checked = False
        End If
        If NIntegrantes = 0 Then
            chkBasico.Checked = False
            chkRegular.Checked = False
        End If
    End Sub

    Private Sub txtIntegrantes_LostFocus(sender As Object, e As EventArgs) Handles txtIntegrantes.LostFocus
        Dim NIntegrantes As Integer
        NIntegrantes = Val(txtIntegrantes.Text)

        If NIntegrantes > 0 And NIntegrantes < 4 Then
            chkBasico.Checked = True
            chkRegular.Checked = False
        End If
        If NIntegrantes > 3 Then
            chkRegular.Checked = True
            chkBasico.Checked = False
        End If
        If NIntegrantes = 0 Then
            chkBasico.Checked = False
            chkRegular.Checked = False
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub
End Class