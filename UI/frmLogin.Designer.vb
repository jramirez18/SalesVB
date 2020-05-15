<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblNombreSW = New System.Windows.Forms.Label()
        Me.pnlUsuarios = New System.Windows.Forms.Panel()
        Me.lblContador = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTituloSesion = New System.Windows.Forms.Label()
        Me.pnlRecuperarPass = New System.Windows.Forms.Panel()
        Me.btnRecuperarPass = New System.Windows.Forms.Button()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnCambiarUser = New System.Windows.Forms.Button()
        Me.btnOlvidePass = New System.Windows.Forms.Button()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.pnlContieneNumeros = New System.Windows.Forms.Panel()
        Me.flpNumeros = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnBorrarTodo = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnBorrarUno = New System.Windows.Forms.Button()
        Me.pnlContienePass = New System.Windows.Forms.Panel()
        Me.pnlLinea1 = New System.Windows.Forms.Panel()
        Me.msMostrarPass = New System.Windows.Forms.MenuStrip()
        Me.tsVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsOcultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.pnlRestaurarPassword = New System.Windows.Forms.Panel()
        Me.lblRestaurarPass = New System.Windows.Forms.Label()
        Me.cboCorreo = New System.Windows.Forms.ComboBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.pnlLinea2 = New System.Windows.Forms.Panel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.pnlDibujarUser = New System.Windows.Forms.Panel()
        Me.picImagenUser = New System.Windows.Forms.PictureBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUsuarios.SuspendLayout()
        Me.lblContador.SuspendLayout()
        Me.pnlRecuperarPass.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        Me.pnlContieneNumeros.SuspendLayout()
        Me.flpNumeros.SuspendLayout()
        Me.pnlContienePass.SuspendLayout()
        Me.msMostrarPass.SuspendLayout()
        Me.pnlRestaurarPassword.SuspendLayout()
        Me.pnlDibujarUser.SuspendLayout()
        CType(Me.picImagenUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(34, 14)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(88, 88)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblNombreSW
        '
        Me.lblNombreSW.AutoSize = True
        Me.lblNombreSW.ForeColor = System.Drawing.Color.White
        Me.lblNombreSW.Location = New System.Drawing.Point(13, 107)
        Me.lblNombreSW.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreSW.Name = "lblNombreSW"
        Me.lblNombreSW.Size = New System.Drawing.Size(128, 21)
        Me.lblNombreSW.TabIndex = 1
        Me.lblNombreSW.Text = "JR Systems 2020"
        '
        'pnlUsuarios
        '
        Me.pnlUsuarios.Controls.Add(Me.lblContador)
        Me.pnlUsuarios.Controls.Add(Me.lblTituloSesion)
        Me.pnlUsuarios.Controls.Add(Me.pnlRecuperarPass)
        Me.pnlUsuarios.Location = New System.Drawing.Point(171, 14)
        Me.pnlUsuarios.Name = "pnlUsuarios"
        Me.pnlUsuarios.Size = New System.Drawing.Size(1109, 723)
        Me.pnlUsuarios.TabIndex = 2
        '
        'lblContador
        '
        Me.lblContador.Controls.Add(Me.pnlDibujarUser)
        Me.lblContador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContador.Location = New System.Drawing.Point(0, 88)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(1109, 535)
        Me.lblContador.TabIndex = 0
        '
        'lblTituloSesion
        '
        Me.lblTituloSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTituloSesion.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloSesion.ForeColor = System.Drawing.Color.White
        Me.lblTituloSesion.Location = New System.Drawing.Point(0, 0)
        Me.lblTituloSesion.Name = "lblTituloSesion"
        Me.lblTituloSesion.Size = New System.Drawing.Size(1109, 88)
        Me.lblTituloSesion.TabIndex = 2
        Me.lblTituloSesion.Text = "¿Quién esta iniciando sesión?"
        Me.lblTituloSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlRecuperarPass
        '
        Me.pnlRecuperarPass.Controls.Add(Me.btnRecuperarPass)
        Me.pnlRecuperarPass.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRecuperarPass.Location = New System.Drawing.Point(0, 623)
        Me.pnlRecuperarPass.Name = "pnlRecuperarPass"
        Me.pnlRecuperarPass.Size = New System.Drawing.Size(1109, 100)
        Me.pnlRecuperarPass.TabIndex = 1
        '
        'btnRecuperarPass
        '
        Me.btnRecuperarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecuperarPass.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperarPass.ForeColor = System.Drawing.Color.Gray
        Me.btnRecuperarPass.Location = New System.Drawing.Point(481, 25)
        Me.btnRecuperarPass.Name = "btnRecuperarPass"
        Me.btnRecuperarPass.Size = New System.Drawing.Size(248, 50)
        Me.btnRecuperarPass.TabIndex = 0
        Me.btnRecuperarPass.Text = "OLVIDE MI CONTRASEÑA"
        Me.btnRecuperarPass.UseVisualStyleBackColor = True
        '
        'pnlLogin
        '
        Me.pnlLogin.Controls.Add(Me.btnCambiarUser)
        Me.pnlLogin.Controls.Add(Me.btnOlvidePass)
        Me.pnlLogin.Controls.Add(Me.btnIniciarSesion)
        Me.pnlLogin.Controls.Add(Me.pnlContieneNumeros)
        Me.pnlLogin.Controls.Add(Me.pnlContienePass)
        Me.pnlLogin.Location = New System.Drawing.Point(247, 76)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(406, 615)
        Me.pnlLogin.TabIndex = 3
        '
        'btnCambiarUser
        '
        Me.btnCambiarUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnCambiarUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarUser.FlatAppearance.BorderSize = 0
        Me.btnCambiarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarUser.ForeColor = System.Drawing.Color.DarkGray
        Me.btnCambiarUser.Location = New System.Drawing.Point(48, 496)
        Me.btnCambiarUser.Name = "btnCambiarUser"
        Me.btnCambiarUser.Size = New System.Drawing.Size(252, 35)
        Me.btnCambiarUser.TabIndex = 616
        Me.btnCambiarUser.Text = "Cambiar de Usuario"
        Me.btnCambiarUser.UseVisualStyleBackColor = False
        '
        'btnOlvidePass
        '
        Me.btnOlvidePass.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnOlvidePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOlvidePass.FlatAppearance.BorderSize = 0
        Me.btnOlvidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOlvidePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOlvidePass.ForeColor = System.Drawing.Color.White
        Me.btnOlvidePass.Location = New System.Drawing.Point(48, 532)
        Me.btnOlvidePass.Name = "btnOlvidePass"
        Me.btnOlvidePass.Size = New System.Drawing.Size(252, 35)
        Me.btnOlvidePass.TabIndex = 615
        Me.btnOlvidePass.Text = "¿Olvidaste tu contraseña?"
        Me.btnOlvidePass.UseVisualStyleBackColor = False
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciarSesion.FlatAppearance.BorderSize = 0
        Me.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnIniciarSesion.ForeColor = System.Drawing.Color.White
        Me.btnIniciarSesion.Location = New System.Drawing.Point(48, 438)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(252, 52)
        Me.btnIniciarSesion.TabIndex = 614
        Me.btnIniciarSesion.Text = "Iniciar sesion"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'pnlContieneNumeros
        '
        Me.pnlContieneNumeros.Controls.Add(Me.flpNumeros)
        Me.pnlContieneNumeros.Location = New System.Drawing.Point(45, 88)
        Me.pnlContieneNumeros.Name = "pnlContieneNumeros"
        Me.pnlContieneNumeros.Size = New System.Drawing.Size(261, 348)
        Me.pnlContieneNumeros.TabIndex = 1
        '
        'flpNumeros
        '
        Me.flpNumeros.Controls.Add(Me.btn1)
        Me.flpNumeros.Controls.Add(Me.btn2)
        Me.flpNumeros.Controls.Add(Me.btn3)
        Me.flpNumeros.Controls.Add(Me.btn4)
        Me.flpNumeros.Controls.Add(Me.btn5)
        Me.flpNumeros.Controls.Add(Me.btn6)
        Me.flpNumeros.Controls.Add(Me.btn7)
        Me.flpNumeros.Controls.Add(Me.btn8)
        Me.flpNumeros.Controls.Add(Me.btn9)
        Me.flpNumeros.Controls.Add(Me.btnBorrarTodo)
        Me.flpNumeros.Controls.Add(Me.btn0)
        Me.flpNumeros.Controls.Add(Me.btnBorrarUno)
        Me.flpNumeros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpNumeros.Location = New System.Drawing.Point(0, 0)
        Me.flpNumeros.Name = "flpNumeros"
        Me.flpNumeros.Size = New System.Drawing.Size(261, 348)
        Me.flpNumeros.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Gray
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(3, 3)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(80, 80)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Gray
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(89, 3)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(80, 80)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Gray
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(175, 3)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(80, 80)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Gray
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(3, 89)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(80, 80)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Gray
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Location = New System.Drawing.Point(89, 89)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(80, 80)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.Gray
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Location = New System.Drawing.Point(175, 89)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(80, 80)
        Me.btn6.TabIndex = 5
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.Gray
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Location = New System.Drawing.Point(3, 175)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(80, 80)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.Gray
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(89, 175)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(80, 80)
        Me.btn8.TabIndex = 7
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.Gray
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Location = New System.Drawing.Point(175, 175)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(80, 80)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btnBorrarTodo
        '
        Me.btnBorrarTodo.BackColor = System.Drawing.Color.Gray
        Me.btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarTodo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarTodo.ForeColor = System.Drawing.Color.White
        Me.btnBorrarTodo.Location = New System.Drawing.Point(3, 261)
        Me.btnBorrarTodo.Name = "btnBorrarTodo"
        Me.btnBorrarTodo.Size = New System.Drawing.Size(80, 80)
        Me.btnBorrarTodo.TabIndex = 9
        Me.btnBorrarTodo.Text = "Borrar"
        Me.btnBorrarTodo.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.Gray
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.White
        Me.btn0.Location = New System.Drawing.Point(89, 261)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(80, 80)
        Me.btn0.TabIndex = 10
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnBorrarUno
        '
        Me.btnBorrarUno.BackColor = System.Drawing.Color.Gray
        Me.btnBorrarUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarUno.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarUno.ForeColor = System.Drawing.Color.White
        Me.btnBorrarUno.Location = New System.Drawing.Point(175, 261)
        Me.btnBorrarUno.Name = "btnBorrarUno"
        Me.btnBorrarUno.Size = New System.Drawing.Size(80, 80)
        Me.btnBorrarUno.TabIndex = 11
        Me.btnBorrarUno.Text = "<-"
        Me.btnBorrarUno.UseVisualStyleBackColor = False
        '
        'pnlContienePass
        '
        Me.pnlContienePass.Controls.Add(Me.pnlLinea1)
        Me.pnlContienePass.Controls.Add(Me.msMostrarPass)
        Me.pnlContienePass.Controls.Add(Me.txtPassword)
        Me.pnlContienePass.Location = New System.Drawing.Point(27, 10)
        Me.pnlContienePass.Name = "pnlContienePass"
        Me.pnlContienePass.Size = New System.Drawing.Size(358, 71)
        Me.pnlContienePass.TabIndex = 0
        '
        'pnlLinea1
        '
        Me.pnlLinea1.BackColor = System.Drawing.Color.Gray
        Me.pnlLinea1.Location = New System.Drawing.Point(21, 55)
        Me.pnlLinea1.Name = "pnlLinea1"
        Me.pnlLinea1.Size = New System.Drawing.Size(253, 1)
        Me.pnlLinea1.TabIndex = 605
        '
        'msMostrarPass
        '
        Me.msMostrarPass.AutoSize = False
        Me.msMostrarPass.BackColor = System.Drawing.Color.Black
        Me.msMostrarPass.Dock = System.Windows.Forms.DockStyle.None
        Me.msMostrarPass.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsVer, Me.tsOcultar})
        Me.msMostrarPass.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.msMostrarPass.Location = New System.Drawing.Point(241, 24)
        Me.msMostrarPass.Name = "msMostrarPass"
        Me.msMostrarPass.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.msMostrarPass.ShowItemToolTips = True
        Me.msMostrarPass.Size = New System.Drawing.Size(97, 28)
        Me.msMostrarPass.TabIndex = 604
        Me.msMostrarPass.Text = "MenuStrip15"
        '
        'tsVer
        '
        Me.tsVer.BackColor = System.Drawing.Color.Black
        Me.tsVer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tsVer.ForeColor = System.Drawing.Color.Black
        Me.tsVer.Image = CType(resources.GetObject("tsVer.Image"), System.Drawing.Image)
        Me.tsVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsVer.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsVer.Name = "tsVer"
        Me.tsVer.Size = New System.Drawing.Size(28, 24)
        Me.tsVer.ToolTipText = "Ver contraseña"
        '
        'tsOcultar
        '
        Me.tsOcultar.BackColor = System.Drawing.Color.Black
        Me.tsOcultar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tsOcultar.ForeColor = System.Drawing.Color.Black
        Me.tsOcultar.Image = CType(resources.GetObject("tsOcultar.Image"), System.Drawing.Image)
        Me.tsOcultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsOcultar.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsOcultar.Name = "tsOcultar"
        Me.tsOcultar.Size = New System.Drawing.Size(28, 24)
        Me.tsOcultar.ToolTipText = "Ocultar contraseña"
        Me.tsOcultar.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Black
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(21, 17)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(202, 39)
        Me.txtPassword.TabIndex = 0
        '
        'pnlRestaurarPassword
        '
        Me.pnlRestaurarPassword.Controls.Add(Me.cboCorreo)
        Me.pnlRestaurarPassword.Controls.Add(Me.btnVolver)
        Me.pnlRestaurarPassword.Controls.Add(Me.btnEnviar)
        Me.pnlRestaurarPassword.Controls.Add(Me.pnlLinea2)
        Me.pnlRestaurarPassword.Controls.Add(Me.lblEmail)
        Me.pnlRestaurarPassword.Controls.Add(Me.lblRestaurarPass)
        Me.pnlRestaurarPassword.Location = New System.Drawing.Point(452, 107)
        Me.pnlRestaurarPassword.Name = "pnlRestaurarPassword"
        Me.pnlRestaurarPassword.Size = New System.Drawing.Size(543, 288)
        Me.pnlRestaurarPassword.TabIndex = 4
        '
        'lblRestaurarPass
        '
        Me.lblRestaurarPass.BackColor = System.Drawing.Color.Transparent
        Me.lblRestaurarPass.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRestaurarPass.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestaurarPass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblRestaurarPass.Location = New System.Drawing.Point(0, 0)
        Me.lblRestaurarPass.Name = "lblRestaurarPass"
        Me.lblRestaurarPass.Size = New System.Drawing.Size(543, 37)
        Me.lblRestaurarPass.TabIndex = 603
        Me.lblRestaurarPass.Text = "Restaurar Contraseña"
        Me.lblRestaurarPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboCorreo
        '
        Me.cboCorreo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCorreo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCorreo.FormattingEnabled = True
        Me.cboCorreo.Location = New System.Drawing.Point(165, 65)
        Me.cboCorreo.Name = "cboCorreo"
        Me.cboCorreo.Size = New System.Drawing.Size(318, 29)
        Me.cboCorreo.TabIndex = 621
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Black
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(410, 164)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(73, 35)
        Me.btnVolver.TabIndex = 619
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Location = New System.Drawing.Point(165, 114)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(318, 35)
        Me.btnEnviar.TabIndex = 620
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'pnlLinea2
        '
        Me.pnlLinea2.BackColor = System.Drawing.Color.Silver
        Me.pnlLinea2.Location = New System.Drawing.Point(165, 96)
        Me.pnlLinea2.Name = "pnlLinea2"
        Me.pnlLinea2.Size = New System.Drawing.Size(318, 1)
        Me.pnlLinea2.TabIndex = 618
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(7, 69)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(155, 21)
        Me.lblEmail.TabIndex = 617
        Me.lblEmail.Text = "Correo electronico:"
        '
        'pnlDibujarUser
        '
        Me.pnlDibujarUser.Controls.Add(Me.lblNombreUsuario)
        Me.pnlDibujarUser.Controls.Add(Me.picImagenUser)
        Me.pnlDibujarUser.Location = New System.Drawing.Point(3, 3)
        Me.pnlDibujarUser.Name = "pnlDibujarUser"
        Me.pnlDibujarUser.Size = New System.Drawing.Size(170, 178)
        Me.pnlDibujarUser.TabIndex = 0
        '
        'picImagenUser
        '
        Me.picImagenUser.Image = CType(resources.GetObject("picImagenUser.Image"), System.Drawing.Image)
        Me.picImagenUser.Location = New System.Drawing.Point(9, 3)
        Me.picImagenUser.Name = "picImagenUser"
        Me.picImagenUser.Size = New System.Drawing.Size(150, 150)
        Me.picImagenUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImagenUser.TabIndex = 0
        Me.picImagenUser.TabStop = False
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.lblNombreUsuario.Location = New System.Drawing.Point(0, 156)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(170, 22)
        Me.lblNombreUsuario.TabIndex = 1
        Me.lblNombreUsuario.Text = "Label1"
        Me.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(13, 151)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(66, 21)
        Me.lblLogin.TabIndex = 5
        Me.lblLogin.Text = "lblLogin"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AllowUserToOrderColumns = True
        Me.dgvUsuarios.AllowUserToResizeRows = False
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.dgvUsuarios.EnableHeadersVisualStyles = False
        Me.dgvUsuarios.Location = New System.Drawing.Point(8, 191)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.RowHeadersWidth = 5
        Me.dgvUsuarios.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvUsuarios.RowTemplate.Height = 30
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(146, 67)
        Me.dgvUsuarios.TabIndex = 537
        '
        'Eli
        '
        Me.Eli.DataPropertyName = "Eli"
        Me.Eli.HeaderText = ""
        Me.Eli.Image = CType(resources.GetObject("Eli.Image"), System.Drawing.Image)
        Me.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eli.Name = "Eli"
        Me.Eli.ReadOnly = True
        Me.Eli.Width = 661
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 538
        Me.Label1.Text = "lblContador"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.pnlUsuarios)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.pnlRestaurarPassword)
        Me.Controls.Add(Me.lblNombreSW)
        Me.Controls.Add(Me.picLogo)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JR Systems"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUsuarios.ResumeLayout(False)
        Me.lblContador.ResumeLayout(False)
        Me.pnlRecuperarPass.ResumeLayout(False)
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlContieneNumeros.ResumeLayout(False)
        Me.flpNumeros.ResumeLayout(False)
        Me.pnlContienePass.ResumeLayout(False)
        Me.pnlContienePass.PerformLayout()
        Me.msMostrarPass.ResumeLayout(False)
        Me.msMostrarPass.PerformLayout()
        Me.pnlRestaurarPassword.ResumeLayout(False)
        Me.pnlRestaurarPassword.PerformLayout()
        Me.pnlDibujarUser.ResumeLayout(False)
        CType(Me.picImagenUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblNombreSW As Label
    Friend WithEvents pnlUsuarios As Panel
    Friend WithEvents pnlRecuperarPass As Panel
    Friend WithEvents lblContador As FlowLayoutPanel
    Friend WithEvents lblTituloSesion As Label
    Friend WithEvents btnRecuperarPass As Button
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents pnlContieneNumeros As Panel
    Friend WithEvents flpNumeros As FlowLayoutPanel
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnBorrarTodo As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnBorrarUno As Button
    Friend WithEvents pnlContienePass As Panel
    Friend WithEvents msMostrarPass As MenuStrip
    Friend WithEvents tsVer As ToolStripMenuItem
    Friend WithEvents tsOcultar As ToolStripMenuItem
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents pnlLinea1 As Panel
    Friend WithEvents btnCambiarUser As Button
    Friend WithEvents btnOlvidePass As Button
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents pnlRestaurarPassword As Panel
    Friend WithEvents cboCorreo As ComboBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents pnlLinea2 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblRestaurarPass As Label
    Friend WithEvents pnlDibujarUser As Panel
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents picImagenUser As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Eli As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
End Class
