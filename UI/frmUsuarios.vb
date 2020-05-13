Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports BLL

Public Class frmUsuarios

    Private r As Random
    Private nuevo As Boolean = False

    Dim logica As Class_Usuario = New Class_Usuario()

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel4.Visible = False
        pnl_Iconos.Visible = False
        pnl_Iconos.Dock = DockStyle.Fill
        ListarUsuarios()
        guardarToolStripMenuItem.Visible = True
        GuardarCambiosToolStripMenuItem.Visible = False

        dgvListaUsuarios.Columns(0).Width = 60
        dgvListaUsuarios.Columns(1).Width = 300

    End Sub

    Public Function validarMail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub guardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles guardarToolStripMenuItem.Click
        Dim contraseñaEncryptada As String
        contraseñaEncryptada = Encriptar(txtPassword.Text.Trim)

        If Not ValidarCampos() Then Return
        'If lblContadorPassword.Text = 6 Then
        Try
            Dim ms As New IO.MemoryStream()
            picIcono.Image.Save(ms, picIcono.Image.RawFormat)

            Dim mensaje = logica.InsertarUsuario(txtNombreApellido.Text, txtUsuario.Text, contraseñaEncryptada, ms.GetBuffer, lblNumeroIcono.Text, txtEmail.Text, cmbRol.Text, "ACTIVO")
            MessageBox.Show(Me, mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Panel4.Visible = False
            ListarUsuarios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Limpiar()
        guardarToolStripMenuItem.Visible = True
        GuardarCambiosToolStripMenuItem.Visible = False
        txtNombreApellido.Text = String.Empty
        txtUsuario.Text = String.Empty
        txtPassword.Text = String.Empty
        txtEmail.Text = String.Empty
        cmbRol.ResetText()
    End Sub

    Sub ListarUsuarios()
        Try
            lblUsuarios.Text = "USUARIOS"
            Me.dgvListaUsuarios.DataSource = logica.ListarUsuarios()
            Me.dgvListaUsuarios.Refresh()
            DgvConfiguracion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DgvConfiguracion()
        Try
            'dgvListaUsuarios.Columns(0).Width = 30
            dgvListaUsuarios.Columns(4).Visible = False
            dgvListaUsuarios.Columns(5).Visible = False
            dgvListaUsuarios.Columns(6).Visible = False
            dgvListaUsuarios.Columns(7).Visible = False
            dgvListaUsuarios.Columns(8).Visible = False
            dgvListaUsuarios.Columns(9).Visible = False

            Me.dgvListaUsuarios.EnableHeadersVisualStyles = False
            Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
            styCabeceras.BackColor = Color.White
            styCabeceras.ForeColor = Color.Black
            styCabeceras.Font = New Font("Segoe UI", 12, FontStyle.Regular Or
        FontStyle.Bold)
            Me.dgvListaUsuarios.ColumnHeadersDefaultCellStyle = styCabeceras
            For Each row As DataGridViewRow In dgvListaUsuarios.Rows
                If row.Cells("Estado").Value = "ELIMINADO" Then
                    row.DefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Strikeout)
                    row.DefaultCellStyle.ForeColor = Color.Red
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub picIcono_Click(sender As Object, e As EventArgs) Handles picIcono.Click
        CargarEstadoIconos()
        pnl_Iconos.Visible = True
        lblEnUso.Visible = False
    End Sub
    'Funcion que verifica el estado de los iconos
    Sub CargarEstadoIconos()
        lbl1.Visible = False
        lbl2.Visible = False
        lbl3.Visible = False
        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False

        pic1.Enabled = True
        pic2.Enabled = True
        pic3.Enabled = True
        pic4.Enabled = True
        pic5.Enabled = True
        pic6.Enabled = True
        pic7.Enabled = True
        pic8.Enabled = True

        Try
            For Each row As DataGridViewRow In dgvListaUsuarios.Rows
                Try
                    Dim Icono As String = Convert.ToString(row.Cells("nombre_icono").Value)
                    If Icono = "1" Then
                        lbl1.Visible = True
                    ElseIf Icono = "2" Then
                        lbl2.Visible = True
                    ElseIf Icono = "3" Then
                        lbl3.Visible = True
                    ElseIf Icono = "4" Then
                        lbl4.Visible = True
                    ElseIf Icono = "5" Then
                        lbl5.Visible = True
                    ElseIf Icono = "6" Then
                        lbl6.Visible = True
                    ElseIf Icono = "7" Then
                        lbl7.Visible = True
                    ElseIf Icono = "8" Then
                        lbl8.Visible = True
                    End If

                    If Icono = "1" Then
                        pic1.Enabled = False
                    ElseIf Icono = "2" Then
                        pic2.Enabled = False
                    ElseIf Icono = "3" Then
                        pic3.Enabled = False
                    ElseIf Icono = "4" Then
                        pic4.Enabled = False
                    ElseIf Icono = "5" Then
                        pic5.Enabled = False
                    ElseIf Icono = "6" Then
                        pic6.Enabled = False
                    ElseIf Icono = "7" Then
                        pic7.Enabled = False
                    ElseIf Icono = "8" Then
                        pic8.Enabled = False
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lblAnuncioIcono_Click(sender As Object, e As EventArgs) Handles lblAnuncioIcono.Click
        CargarEstadoIconos()
        pnl_Iconos.Visible = True
        lblEnUso.Visible = False
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dispose()

    End Sub

    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click
        picIcono.Image = pic1.Image
        lblNumeroIcono.Text = 1
        lblAnuncioIcono.Visible = False
        pnl_Iconos.Visible = False
    End Sub

    Private Sub pic2_Click(sender As Object, e As EventArgs) Handles pic2.Click
        picIcono.Image = pic2.Image
        lblNumeroIcono.Text = 2
        lblAnuncioIcono.Visible = False
        pnl_Iconos.Visible = False
    End Sub

    Private Sub pic3_Click(sender As Object, e As EventArgs) Handles pic3.Click
        picIcono.Image = pic3.Image
        lblNumeroIcono.Text = 3
        lblAnuncioIcono.Visible = False
        pnl_Iconos.Visible = False
    End Sub

    Private Sub pic4_Click(sender As Object, e As EventArgs) Handles pic4.Click
        picIcono.Image = pic4.Image
        lblNumeroIcono.Text = 4
        lblAnuncioIcono.Visible = False
        pnl_Iconos.Visible = False
    End Sub

    Private Sub pic5_Click(sender As Object, e As EventArgs) Handles pic5.Click
        picIcono.Image = pic5.Image
        lblNumeroIcono.Text = 5
        lblAnuncioIcono.Visible = False
        pnl_Iconos.Visible = False
    End Sub

    Private Sub pic6_Click(sender As Object, e As EventArgs) Handles pic6.Click
        picIcono.Image = pic6.Image
        lblNumeroIcono.Text = 6
        lblAnuncioIcono.Visible = False
        pnl_Iconos.Visible = False
    End Sub

    Private Sub pic7_Click(sender As Object, e As EventArgs) Handles pic7.Click
        picIcono.Image = pic7.Image
        lblNumeroIcono.Text = 7
        lblAnuncioIcono.Visible = False
        pnl_Iconos.Visible = False
    End Sub

    Private Sub pic8_Click(sender As Object, e As EventArgs) Handles pic8.Click
        picIcono.Image = pic8.Image
        lblNumeroIcono.Text = 8
        lblAnuncioIcono.Visible = False
        pnl_Iconos.Visible = False
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Panel4.Visible = False
        lblUsuarios.Visible = True
        lblUsuarios.Text = "USUARIOS"
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        pnl_Iconos.Visible = False
    End Sub

    Private Sub pic9_Click(sender As Object, e As EventArgs) Handles pic9.Click
        With ofdCargarImagen
            .InitialDirectory = ""
            .Filter = "Imagenes|*.jpg;*.png"
            .FilterIndex = 2
            .Title = "Cargador de Imagenes ADA 369"

        End With

        If ofdCargarImagen.ShowDialog() = DialogResult.OK Then
            picIcono.BackgroundImage = Nothing
            picIcono.Image = New Bitmap(ofdCargarImagen.FileName)
            picIcono.SizeMode = PictureBoxSizeMode.Zoom
            lblNumeroIcono.Text = Path.GetFileName(ofdCargarImagen.FileName)
            lblAnuncioIcono.Visible = False
            pnl_Iconos.Visible = False


            Try
                For Each row As DataGridViewRow In dgvListaUsuarios.Rows
                    Try
                        Dim Icono As String = Convert.ToString(row.Cells("nombre_icono").Value)
                        If Icono = lblNumeroIcono.Text Then
                            MessageBox.Show("Ya existe este Icono Registrado, Elije Otro Icono", "Icono en Uso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            lblAnuncioIcono.Visible = True
                        End If

                    Catch ex As Exception

                    End Try
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub generarPassToolStrip_Click(sender As Object, e As EventArgs) Handles generarPassToolStrip.Click
        GenerarPass()
    End Sub
    Private Sub GenerarPass()
        Try
            For Each row As DataGridViewRow In dgvListaUsuarios.Rows
                Try
                    r = New Random()
                    txtPassword.Text = r.[Next](0, 9) & r.[Next](0, 9) & r.[Next](0, 9) & r.[Next](0, 9) & r.[Next](0, 9) & r.[Next](0, 9)
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        nuevo = True
        lblUsuarios.Text = "NUEVO USUARIO"
        txtUsuario.Enabled = True
        txtEmail.Enabled = True
        Limpiar()
        CargarEstadoIconos()
        lblAnuncioIcono.Visible = True
        Panel4.Visible = True

    End Sub

    Private Sub MenuStripBuscar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStripBuscar.ItemClicked
        Try
            Me.dgvListaUsuarios.DataSource = logica.BuscarUsuario(txtBuscar.Text)
            DgvConfiguracion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        lblContadorPassword.Text = Len(txtPassword.Text)
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then

            e.KeyChar =
                Threading.Thread.CurrentThread.
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)

        End If
        NumerosDecimal(txtPassword, e)
    End Sub

    'funcion que solo deja escribir numero en la caja de texto de password
    Public Sub NumerosDecimal(ByVal CajaTexto As System.Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Me.dgvListaUsuarios.DataSource = logica.BuscarUsuario(txtBuscar.Text)
            Me.dgvListaUsuarios.Refresh()
            DgvConfiguracion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ActivarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivarUsuarioToolStripMenuItem.Click

    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        'Boton utulizado para guardar cambios al editar
        Dim passEncryptadaUpdate As String
        passEncryptadaUpdate = Encriptar(txtPassword.Text.Trim)

        If Not ValidarCampos() Then Return
        'If lblContadorPassword.Text = 6 Then
        Try
            Dim ms As New IO.MemoryStream()
            picIcono.Image.Save(ms, picIcono.Image.RawFormat)

            Dim mensaje = logica.UpdateUser(lbl_IdUsuario.Text, txtNombreApellido.Text, txtUsuario.Text, passEncryptadaUpdate, ms.GetBuffer, lblNumeroIcono.Text, txtEmail.Text, cmbRol.Text)
            MessageBox.Show(Me, mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Panel4.Visible = False
            ListarUsuarios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ValidarCampos()
        If txtNombreApellido.Text = String.Empty Then
            ErrorProvider1.SetError(txtNombreApellido, "Ingresa un nombre y un apellido.")
            txtNombreApellido.Focus()
            Return False
        End If
        ErrorProvider1.Clear()
        If nuevo Then
            If txtUsuario.Text = String.Empty Then
                ErrorProvider1.SetError(txtUsuario, "Ingresa un nombre de usuario.")
                txtUsuario.Focus()
                Return False
            End If
            ErrorProvider1.Clear()

            If (logica.ExisteUser(txtUsuario.Text)) Then
                ErrorProvider1.SetError(txtUsuario, "Este usuario ya esta registrado, ingresa otro.")
                txtUsuario.Focus()
                txtUsuario.SelectAll()
                Return False
            End If
            ErrorProvider1.Clear()
        End If


        If txtPassword.Text = String.Empty Then
            ErrorProvider1.SetError(txtPassword, "Ingresa una contraseña.")
            txtPassword.Focus()
            Return False
        End If
        ErrorProvider1.Clear()

        If txtEmail.Text = String.Empty Then
            ErrorProvider1.SetError(txtEmail, "Ingresa un correo electronico.")
            txtEmail.Focus()
            Return False
        End If
        ErrorProvider1.Clear()

        If validarMail(LCase(txtEmail.Text)) = False Then
            ErrorProvider1.SetError(txtEmail, "Dirección de correo electronico no valida. Ejemplo: nombre@dominio.com")
            txtEmail.Focus()
            Return False
        End If
        ErrorProvider1.Clear()
        If cmbRol.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbRol, "Debes de seleccionar un Rol.")
            cmbRol.Focus()
            Return False
        End If
        ErrorProvider1.Clear()
        If lblAnuncioIcono.Visible = True Then
            ErrorProvider1.SetError(lblAnuncioIcono, "Debes de seleccionar un ICONO.")
            lblAnuncioIcono.Focus()
            Return False
        End If
        ErrorProvider1.Clear()
        Return True
    End Function

    Dim estado As String
    Private Sub dgvListaUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaUsuarios.CellDoubleClick
        Try

            nuevo = False
            lblUsuarios.Text = "EDITAR USUARIO"
            txtEmail.Enabled = False

            lbl_IdUsuario.Text = dgvListaUsuarios.SelectedCells.Item(4).Value
            txtNombreApellido.Text = dgvListaUsuarios.SelectedCells.Item(1).Value
            txtUsuario.Text = dgvListaUsuarios.SelectedCells.Item(2).Value
            'txtPassword.Text = dgvListaUsuarios.SelectedCells.Item(5).Value
            txtEmail.Text = dgvListaUsuarios.SelectedCells.Item(8).Value
            cmbRol.Text = dgvListaUsuarios.SelectedCells.Item(9).Value
            estado = dgvListaUsuarios.SelectedCells.Item(3).Value
            If estado = "ELIMINADO" Then
                RestaurarUsuarios()
            Else
                If txtUsuario.Text = "admin" Then
                    txtUsuario.Enabled = False 'el administrador no puede ser editado
                    cmbRol.Enabled = False
                Else
                    txtUsuario.Enabled = True 'si no es el admin habilitamos los campos
                    cmbRol.Enabled = True
                End If
                'desencriptamos
                Try
                    Me.txtPassword.Text = Desencriptar(dgvListaUsuarios.SelectedCells.Item(5).Value.Trim)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                'quitamos la imagen q exista en picturebox
                picIcono.BackgroundImage = Nothing
                Dim b As Byte() = dgvListaUsuarios.SelectedCells.Item(6).Value
                'lo transformamos a la memoria stream
                Dim ms As New IO.MemoryStream(b)
                'cargamos la imagen ya procesada
                picIcono.Image = Image.FromStream(ms)
                picIcono.SizeMode = PictureBoxSizeMode.Zoom

                lblAnuncioIcono.Visible = False

                guardarToolStripMenuItem.Visible = False
                GuardarCambiosToolStripMenuItem.Visible = True


                Panel4.Visible = True
                CargarEstadoIconos()



            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message).ToString()
        End Try
    End Sub

    Sub RestaurarUsuarios()
        lblUsuarios.Text = "ACTIVAR USUARIO"
        Dim resp2 As DialogResult = MessageBox.Show("Este usuario se eliminó, ¿Desea restaurar este usuarip?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If resp2 = DialogResult.No Then
            'lblUsuarios.Text = "USUARIOS"
            ListarUsuarios()
            Return
        End If
        Try
            For Each row As DataGridViewRow In dgvListaUsuarios.SelectedRows
                Dim idUser As Integer = Convert.ToInt32(row.Cells("idUsuario").Value)
                Dim user As String = Convert.ToString(row.Cells("Usuario").Value)

                Try
                    Dim msj = logica.RestaurarUser(idUser, user)
                    MessageBox.Show(Me, msj, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            'lblUsuarios.Text = "USUARIOS"
            ListarUsuarios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub dgvListaUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaUsuarios.CellClick
        If e.ColumnIndex = Me.dgvListaUsuarios.Columns.Item("Eli").Index Then
            Dim resp As DialogResult = MessageBox.Show("Esta seguro de borrar el registro actual?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If resp = DialogResult.No Then Return
            Try
                For Each row As DataGridViewRow In dgvListaUsuarios.SelectedRows
                    Dim idUser As Integer = Convert.ToInt32(row.Cells("idUsuario").Value)
                    Dim user As String = Convert.ToString(row.Cells("Usuario").Value)

                    Try
                        Dim mensaje = logica.DeleteUser(idUser, user)
                        MessageBox.Show(Me, mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next
                ListarUsuarios()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
