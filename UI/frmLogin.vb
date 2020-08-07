Imports BLL
Public Class frmLogin
    Dim usuario As Class_Usuario = New Class_Usuario

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlLogin.Visible = False
        pnlRestaurarPassword.Visible = False
        pnlUsuarios.Visible = True
        DibujarUsuariosActivos()
        'Centrar la posicion de los paneles
        pnlUsuarios.Location = New Point((Width - pnlUsuarios.Width) / 2, (Height - pnlUsuarios.Height) / 2)
        pnlLogin.Location = New Point((Width - pnlLogin.Width) / 2, (Height - pnlLogin.Height) / 2)

    End Sub

    Sub DibujarUsuariosActivos()
        pnlDibujarUser.Controls.Clear()
        Try
            Dim dt As DataTable = New DataTable
            dt = usuario.UsuariosActivos()

            Dim reader As DataTableReader
            reader = dt.CreateDataReader
            While reader.Read()
                Dim b As New Label()
                Dim p1 As New Panel
                Dim I1 As New PictureBox
                b.Text = reader("login").ToString()
                b.Name = reader("idUsuario").ToString()
                b.Size = New System.Drawing.Size(170, 22)
                b.Font = New System.Drawing.Font("Segoe UI", 12)
                b.FlatStyle = FlatStyle.Flat
                b.BackColor = Color.Black
                b.ForeColor = Color.White
                b.Dock = DockStyle.Bottom
                b.TextAlign = ContentAlignment.MiddleCenter
                b.Cursor = Cursors.Hand
                p1.Size = New System.Drawing.Size(170, 178)
                p1.BorderStyle = BorderStyle.None
                p1.Dock = DockStyle.Bottom
                p1.BackColor = Color.Black

                I1.Size = New System.Drawing.Size(150, 150)
                I1.Dock = DockStyle.Top
                I1.BackgroundImage = Nothing
                Dim bi() As Byte = reader("icono")
                Dim ms As New IO.MemoryStream(bi)
                I1.Image = Image.FromStream(ms)
                I1.SizeMode = PictureBoxSizeMode.Zoom
                I1.Tag = reader("login").ToString()
                I1.Cursor = Cursors.Hand
                p1.Controls.Add(b)
                p1.Controls.Add(I1)
                b.BringToFront()

                flpUsuarios.Controls.Add(p1)
                AddHandler b.Click, AddressOf miEventoLabel
                AddHandler I1.Click, AddressOf miEventoImagen
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub miEventoLabel(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            lblLogin.Text = DirectCast(sender, Label).Text
            pnlUsuarios.Visible = False
            pnlLogin.Visible = True
            'MOSTRAR_PERMISOS()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub miEventoImagen(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            lblLogin.Text = DirectCast(sender, PictureBox).Tag

            pnlUsuarios.Visible = False
            pnlLogin.Visible = True
            'MOSTRAR_PERMISOS()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ValidarUsuarios()
        Contar()
        If flpUsuarios.Text > 0 Then
            Me.Hide()
            Dim frm As frmMenuVentas = New frmMenuVentas
            frm.ShowDialog()

        End If
    End Sub

    Sub ValidarUsuarios()
        Dim passEncriptada As String
        passEncriptada = Encriptar(txtPassword.Text.Trim)
        Try
            dgvUsuarios.DataSource = usuario.ValidarUsuario(lblLogin.Text, passEncriptada)
        Catch ex As Exception

        End Try
    End Sub

    Sub Contar()
        Dim x As Integer
        x = dgvUsuarios.Rows.Count
        flpUsuarios.Text = CStr(x)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtPassword.Text = txtPassword.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtPassword.Text = txtPassword.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtPassword.Text = txtPassword.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtPassword.Text = txtPassword.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtPassword.Text = txtPassword.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtPassword.Text = txtPassword.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtPassword.Text = txtPassword.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtPassword.Text = txtPassword.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtPassword.Text = txtPassword.Text & "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtPassword.Text = txtPassword.Text & "0"
    End Sub

    Private Sub btnBorrarUno_Click(sender As Object, e As EventArgs) Handles btnBorrarUno.Click
        Try
            Dim largo As Integer
            If txtPassword.Text <> String.Empty Then
                largo = txtPassword.Text.Length
                txtPassword.Text = Mid(txtPassword.Text, 1, largo - 1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnBorrarTodo.Click
        txtPassword.ResetText()
        txtPassword.Focus()
    End Sub

    Private Sub tsVer_Click(sender As Object, e As EventArgs) Handles tsVer.Click
        txtPassword.PasswordChar = ""
        tsOcultar.Visible = True
        tsVer.Visible = False
    End Sub

    Private Sub tsOcultar_Click(sender As Object, e As EventArgs) Handles tsOcultar.Click
        txtPassword.PasswordChar = "*"
        tsOcultar.Visible = False
        tsVer.Visible = True
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        MessageBox.Show("Usuario o contraseña Incorrectos", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub btnRecuperarPass_Click(sender As Object, e As EventArgs) Handles btnRecuperarPass.Click
        pnlRestaurarPassword.Location = New Point((Width - pnlRestaurarPassword.Width) / 2, (Height - pnlRestaurarPassword.Height) / 2)
        pnlRestaurarPassword.Visible = True
        pnlUsuarios.Visible = False
        pnlLogin.Visible = False
        MostrarCorreo()
    End Sub

    Sub MostrarCorreo()
        Try
            cboCorreo.DataSource = usuario.CorreosActivos()
            cboCorreo.ValueMember = "correo"
            cboCorreo.DisplayMember = "correo"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        ObtenerPassword()
    End Sub

    Sub ObtenerPassword()
        Dim pass As String
        Try
            pass = usuario.ObtenerPassword(cboCorreo.SelectedValue)

            lblPassword.Text = Desencriptar(pass)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class