<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblUsuarios = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblBuscarUsuario = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.MenuStripBuscar = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlUsuario = New System.Windows.Forms.Panel()
        Me.lbl_IdUsuario = New System.Windows.Forms.Label()
        Me.pnl_Iconos = New System.Windows.Forms.Panel()
        Me.lblNumeroIcono = New System.Windows.Forms.Label()
        Me.lblEnUso = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.pic9 = New System.Windows.Forms.PictureBox()
        Me.pic8 = New System.Windows.Forms.PictureBox()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.pic7 = New System.Windows.Forms.PictureBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.pic6 = New System.Windows.Forms.PictureBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.lblContadorPassword = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.MenuStripBotonesUser = New System.Windows.Forms.MenuStrip()
        Me.guardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripGenerarPassword = New System.Windows.Forms.MenuStrip()
        Me.generarPassToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtNombreApellido = New System.Windows.Forms.TextBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblAnuncioIcono = New System.Windows.Forms.Label()
        Me.picIcono = New System.Windows.Forms.PictureBox()
        Me.ofdCargarImagen = New System.Windows.Forms.OpenFileDialog()
        Me.dgvListaUsuarios = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MenuActivarUsuario = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActivarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStripBuscar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlUsuario.SuspendLayout()
        Me.pnl_Iconos.SuspendLayout()
        CType(Me.pic9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripBotonesUser.SuspendLayout()
        Me.MenuStripGenerarPassword.SuspendLayout()
        CType(Me.picIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuActivarUsuario.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.lblUsuarios)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 38)
        Me.Panel1.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(725, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(50, 38)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblUsuarios.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(107, 25)
        Me.lblUsuarios.TabIndex = 0
        Me.lblUsuarios.Text = "USUARIOS"
        Me.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblBuscarUsuario)
        Me.Panel2.Controls.Add(Me.txtBuscar)
        Me.Panel2.Controls.Add(Me.MenuStripBuscar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(775, 51)
        Me.Panel2.TabIndex = 1
        '
        'lblBuscarUsuario
        '
        Me.lblBuscarUsuario.AutoSize = True
        Me.lblBuscarUsuario.Location = New System.Drawing.Point(3, 13)
        Me.lblBuscarUsuario.Name = "lblBuscarUsuario"
        Me.lblBuscarUsuario.Size = New System.Drawing.Size(59, 21)
        Me.lblBuscarUsuario.TabIndex = 0
        Me.lblBuscarUsuario.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(68, 13)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(270, 29)
        Me.txtBuscar.TabIndex = 1
        '
        'MenuStripBuscar
        '
        Me.MenuStripBuscar.AutoSize = False
        Me.MenuStripBuscar.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStripBuscar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStripBuscar.Location = New System.Drawing.Point(341, 13)
        Me.MenuStripBuscar.Name = "MenuStripBuscar"
        Me.MenuStripBuscar.Size = New System.Drawing.Size(44, 29)
        Me.MenuStripBuscar.TabIndex = 2
        Me.MenuStripBuscar.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 25)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(662, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(113, 620)
        Me.Panel3.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel4.Controls.Add(Me.pnlUsuario)
        Me.Panel4.Controls.Add(Me.lblAnuncioIcono)
        Me.Panel4.Controls.Add(Me.picIcono)
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 38)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(775, 1157)
        Me.Panel4.TabIndex = 4
        '
        'pnlUsuario
        '
        Me.pnlUsuario.BackColor = System.Drawing.Color.White
        Me.pnlUsuario.Controls.Add(Me.lbl_IdUsuario)
        Me.pnlUsuario.Controls.Add(Me.pnl_Iconos)
        Me.pnlUsuario.Controls.Add(Me.lblContadorPassword)
        Me.pnlUsuario.Controls.Add(Me.btnVolver)
        Me.pnlUsuario.Controls.Add(Me.MenuStripBotonesUser)
        Me.pnlUsuario.Controls.Add(Me.MenuStripGenerarPassword)
        Me.pnlUsuario.Controls.Add(Me.cmbRol)
        Me.pnlUsuario.Controls.Add(Me.Panel9)
        Me.pnlUsuario.Controls.Add(Me.txtEmail)
        Me.pnlUsuario.Controls.Add(Me.Panel8)
        Me.pnlUsuario.Controls.Add(Me.txtPassword)
        Me.pnlUsuario.Controls.Add(Me.Panel7)
        Me.pnlUsuario.Controls.Add(Me.txtUsuario)
        Me.pnlUsuario.Controls.Add(Me.Panel6)
        Me.pnlUsuario.Controls.Add(Me.txtNombreApellido)
        Me.pnlUsuario.Controls.Add(Me.lblRol)
        Me.pnlUsuario.Controls.Add(Me.lblEmail)
        Me.pnlUsuario.Controls.Add(Me.lblPassword)
        Me.pnlUsuario.Controls.Add(Me.lblUser)
        Me.pnlUsuario.Controls.Add(Me.lblNombres)
        Me.pnlUsuario.Location = New System.Drawing.Point(24, 28)
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Size = New System.Drawing.Size(557, 427)
        Me.pnlUsuario.TabIndex = 0
        '
        'lbl_IdUsuario
        '
        Me.lbl_IdUsuario.AutoSize = True
        Me.lbl_IdUsuario.Location = New System.Drawing.Point(3, 343)
        Me.lbl_IdUsuario.Name = "lbl_IdUsuario"
        Me.lbl_IdUsuario.Size = New System.Drawing.Size(101, 21)
        Me.lbl_IdUsuario.TabIndex = 18
        Me.lbl_IdUsuario.Text = "lbl_IdUsuario"
        Me.lbl_IdUsuario.Visible = False
        '
        'pnl_Iconos
        '
        Me.pnl_Iconos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_Iconos.Controls.Add(Me.lblNumeroIcono)
        Me.pnl_Iconos.Controls.Add(Me.lblEnUso)
        Me.pnl_Iconos.Controls.Add(Me.btnRegresar)
        Me.pnl_Iconos.Controls.Add(Me.lbl8)
        Me.pnl_Iconos.Controls.Add(Me.pic9)
        Me.pnl_Iconos.Controls.Add(Me.pic8)
        Me.pnl_Iconos.Controls.Add(Me.lbl7)
        Me.pnl_Iconos.Controls.Add(Me.pic7)
        Me.pnl_Iconos.Controls.Add(Me.lbl6)
        Me.pnl_Iconos.Controls.Add(Me.pic6)
        Me.pnl_Iconos.Controls.Add(Me.lbl5)
        Me.pnl_Iconos.Controls.Add(Me.pic5)
        Me.pnl_Iconos.Controls.Add(Me.lbl4)
        Me.pnl_Iconos.Controls.Add(Me.pic4)
        Me.pnl_Iconos.Controls.Add(Me.lbl3)
        Me.pnl_Iconos.Controls.Add(Me.pic3)
        Me.pnl_Iconos.Controls.Add(Me.lbl2)
        Me.pnl_Iconos.Controls.Add(Me.pic2)
        Me.pnl_Iconos.Controls.Add(Me.lbl1)
        Me.pnl_Iconos.Controls.Add(Me.pic1)
        Me.pnl_Iconos.Location = New System.Drawing.Point(7, 326)
        Me.pnl_Iconos.Name = "pnl_Iconos"
        Me.pnl_Iconos.Size = New System.Drawing.Size(543, 421)
        Me.pnl_Iconos.TabIndex = 2
        Me.pnl_Iconos.Visible = False
        '
        'lblNumeroIcono
        '
        Me.lblNumeroIcono.AutoSize = True
        Me.lblNumeroIcono.Location = New System.Drawing.Point(16, 145)
        Me.lblNumeroIcono.Name = "lblNumeroIcono"
        Me.lblNumeroIcono.Size = New System.Drawing.Size(123, 21)
        Me.lblNumeroIcono.TabIndex = 216
        Me.lblNumeroIcono.Text = "lblNumeroIcono"
        Me.lblNumeroIcono.Visible = False
        '
        'lblEnUso
        '
        Me.lblEnUso.AutoSize = True
        Me.lblEnUso.Location = New System.Drawing.Point(145, 145)
        Me.lblEnUso.Name = "lblEnUso"
        Me.lblEnUso.Size = New System.Drawing.Size(71, 21)
        Me.lblEnUso.TabIndex = 24
        Me.lblEnUso.Text = "lblEnUso"
        Me.lblEnUso.Visible = False
        '
        'btnRegresar
        '
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.Location = New System.Drawing.Point(363, 377)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(160, 41)
        Me.btnRegresar.TabIndex = 23
        Me.btnRegresar.Text = "Volver"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.BackColor = System.Drawing.Color.Transparent
        Me.lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.White
        Me.lbl8.Location = New System.Drawing.Point(30, 219)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(88, 24)
        Me.lbl8.TabIndex = 21
        Me.lbl8.Text = "EN USO"
        '
        'pic9
        '
        Me.pic9.Image = CType(resources.GetObject("pic9.Image"), System.Drawing.Image)
        Me.pic9.Location = New System.Drawing.Point(20, 300)
        Me.pic9.Name = "pic9"
        Me.pic9.Size = New System.Drawing.Size(114, 118)
        Me.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic9.TabIndex = 22
        Me.pic9.TabStop = False
        '
        'pic8
        '
        Me.pic8.Image = CType(resources.GetObject("pic8.Image"), System.Drawing.Image)
        Me.pic8.Location = New System.Drawing.Point(20, 171)
        Me.pic8.Name = "pic8"
        Me.pic8.Size = New System.Drawing.Size(114, 118)
        Me.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic8.TabIndex = 20
        Me.pic8.TabStop = False
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.BackColor = System.Drawing.Color.Transparent
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.White
        Me.lbl7.Location = New System.Drawing.Point(154, 219)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(88, 24)
        Me.lbl7.TabIndex = 19
        Me.lbl7.Text = "EN USO"
        '
        'pic7
        '
        Me.pic7.Image = CType(resources.GetObject("pic7.Image"), System.Drawing.Image)
        Me.pic7.Location = New System.Drawing.Point(144, 171)
        Me.pic7.Name = "pic7"
        Me.pic7.Size = New System.Drawing.Size(114, 118)
        Me.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic7.TabIndex = 18
        Me.pic7.TabStop = False
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.BackColor = System.Drawing.Color.Transparent
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.White
        Me.lbl6.Location = New System.Drawing.Point(290, 219)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(88, 24)
        Me.lbl6.TabIndex = 17
        Me.lbl6.Text = "EN USO"
        '
        'pic6
        '
        Me.pic6.Image = CType(resources.GetObject("pic6.Image"), System.Drawing.Image)
        Me.pic6.Location = New System.Drawing.Point(280, 171)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(108, 118)
        Me.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic6.TabIndex = 16
        Me.pic6.TabStop = False
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.Color.Transparent
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.White
        Me.lbl5.Location = New System.Drawing.Point(419, 219)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(88, 24)
        Me.lbl5.TabIndex = 15
        Me.lbl5.Text = "EN USO"
        '
        'pic5
        '
        Me.pic5.Image = CType(resources.GetObject("pic5.Image"), System.Drawing.Image)
        Me.pic5.Location = New System.Drawing.Point(409, 171)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(114, 118)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic5.TabIndex = 14
        Me.pic5.TabStop = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.Color.Transparent
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(28, 72)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(88, 24)
        Me.lbl4.TabIndex = 13
        Me.lbl4.Text = "EN USO"
        '
        'pic4
        '
        Me.pic4.Image = CType(resources.GetObject("pic4.Image"), System.Drawing.Image)
        Me.pic4.Location = New System.Drawing.Point(20, 24)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(114, 118)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic4.TabIndex = 12
        Me.pic4.TabStop = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(154, 72)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(88, 24)
        Me.lbl3.TabIndex = 11
        Me.lbl3.Text = "EN USO"
        '
        'pic3
        '
        Me.pic3.Image = CType(resources.GetObject("pic3.Image"), System.Drawing.Image)
        Me.pic3.Location = New System.Drawing.Point(144, 24)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(114, 118)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic3.TabIndex = 10
        Me.pic3.TabStop = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(290, 72)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(88, 24)
        Me.lbl2.TabIndex = 9
        Me.lbl2.Text = "EN USO"
        '
        'pic2
        '
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(280, 24)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(108, 118)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic2.TabIndex = 8
        Me.pic2.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(419, 72)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(88, 24)
        Me.lbl1.TabIndex = 7
        Me.lbl1.Text = "EN USO"
        '
        'pic1
        '
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(409, 24)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(114, 118)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'lblContadorPassword
        '
        Me.lblContadorPassword.AutoSize = True
        Me.lblContadorPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblContadorPassword.Location = New System.Drawing.Point(288, 120)
        Me.lblContadorPassword.Name = "lblContadorPassword"
        Me.lblContadorPassword.Size = New System.Drawing.Size(19, 21)
        Me.lblContadorPassword.TabIndex = 9
        Me.lblContadorPassword.Text = "6"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(371, 272)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(81, 48)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'MenuStripBotonesUser
        '
        Me.MenuStripBotonesUser.AutoSize = False
        Me.MenuStripBotonesUser.BackColor = System.Drawing.Color.Transparent
        Me.MenuStripBotonesUser.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripBotonesUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.guardarToolStripMenuItem, Me.GuardarCambiosToolStripMenuItem})
        Me.MenuStripBotonesUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStripBotonesUser.Location = New System.Drawing.Point(66, 272)
        Me.MenuStripBotonesUser.Name = "MenuStripBotonesUser"
        Me.MenuStripBotonesUser.ShowItemToolTips = True
        Me.MenuStripBotonesUser.Size = New System.Drawing.Size(246, 48)
        Me.MenuStripBotonesUser.TabIndex = 16
        Me.MenuStripBotonesUser.Text = "MenuStrip2"
        '
        'guardarToolStripMenuItem
        '
        Me.guardarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.guardarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.guardarToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem"
        Me.guardarToolStripMenuItem.Size = New System.Drawing.Size(83, 44)
        Me.guardarToolStripMenuItem.Text = "&Guardar"
        Me.guardarToolStripMenuItem.ToolTipText = "Guardar "
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.GuardarCambiosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GuardarCambiosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(153, 44)
        Me.GuardarCambiosToolStripMenuItem.Text = "&Guardar Cambios"
        '
        'MenuStripGenerarPassword
        '
        Me.MenuStripGenerarPassword.AutoSize = False
        Me.MenuStripGenerarPassword.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStripGenerarPassword.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.generarPassToolStrip})
        Me.MenuStripGenerarPassword.Location = New System.Drawing.Point(310, 120)
        Me.MenuStripGenerarPassword.Name = "MenuStripGenerarPassword"
        Me.MenuStripGenerarPassword.Size = New System.Drawing.Size(158, 24)
        Me.MenuStripGenerarPassword.TabIndex = 10
        Me.MenuStripGenerarPassword.Text = "MenuStrip3"
        '
        'generarPassToolStrip
        '
        Me.generarPassToolStrip.Image = CType(resources.GetObject("generarPassToolStrip.Image"), System.Drawing.Image)
        Me.generarPassToolStrip.Name = "generarPassToolStrip"
        Me.generarPassToolStrip.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.generarPassToolStrip.Size = New System.Drawing.Size(152, 20)
        Me.generarPassToolStrip.Text = "Generar auto. (Ctrl+A)"
        '
        'cmbRol
        '
        Me.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Items.AddRange(New Object() {"Solo Ventas (no esta autorizado para manejar dinero)", "Cajero (Si esta autorizado para manejar dinero)", "Administrador (Control total)"})
        Me.cmbRol.Location = New System.Drawing.Point(185, 211)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(267, 29)
        Me.cmbRol.TabIndex = 15
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DimGray
        Me.Panel9.Location = New System.Drawing.Point(185, 189)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(267, 1)
        Me.Panel9.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Location = New System.Drawing.Point(185, 165)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(267, 22)
        Me.txtEmail.TabIndex = 12
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DimGray
        Me.Panel8.Location = New System.Drawing.Point(185, 137)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(97, 1)
        Me.Panel8.TabIndex = 8
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Location = New System.Drawing.Point(185, 113)
        Me.txtPassword.MaxLength = 6
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(97, 22)
        Me.txtPassword.TabIndex = 7
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DimGray
        Me.Panel7.Location = New System.Drawing.Point(185, 98)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(267, 1)
        Me.Panel7.TabIndex = 5
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Location = New System.Drawing.Point(185, 74)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(267, 22)
        Me.txtUsuario.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.Location = New System.Drawing.Point(185, 47)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(267, 1)
        Me.Panel6.TabIndex = 2
        '
        'txtNombreApellido
        '
        Me.txtNombreApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreApellido.Location = New System.Drawing.Point(185, 24)
        Me.txtNombreApellido.Name = "txtNombreApellido"
        Me.txtNombreApellido.Size = New System.Drawing.Size(267, 22)
        Me.txtNombreApellido.TabIndex = 1
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(143, 209)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(36, 21)
        Me.lblRol.TabIndex = 14
        Me.lblRol.Text = "Rol:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(38, 169)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(141, 21)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Correo Electronico:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(87, 124)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(92, 21)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Contraseña:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(112, 78)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(67, 21)
        Me.lblUser.TabIndex = 3
        Me.lblUser.Text = "Usuario:"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(21, 27)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(158, 21)
        Me.lblNombres.TabIndex = 0
        Me.lblNombres.Text = "Nombres y Apellidos:"
        '
        'lblAnuncioIcono
        '
        Me.lblAnuncioIcono.BackColor = System.Drawing.Color.DimGray
        Me.lblAnuncioIcono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnuncioIcono.ForeColor = System.Drawing.Color.White
        Me.lblAnuncioIcono.Location = New System.Drawing.Point(598, 28)
        Me.lblAnuncioIcono.Name = "lblAnuncioIcono"
        Me.lblAnuncioIcono.Size = New System.Drawing.Size(148, 154)
        Me.lblAnuncioIcono.TabIndex = 1
        Me.lblAnuncioIcono.Text = "Elige un icono"
        Me.lblAnuncioIcono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAnuncioIcono.Visible = False
        '
        'picIcono
        '
        Me.picIcono.Location = New System.Drawing.Point(598, 28)
        Me.picIcono.Name = "picIcono"
        Me.picIcono.Size = New System.Drawing.Size(148, 154)
        Me.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIcono.TabIndex = 213
        Me.picIcono.TabStop = False
        '
        'dgvListaUsuarios
        '
        Me.dgvListaUsuarios.AllowUserToAddRows = False
        Me.dgvListaUsuarios.AllowUserToDeleteRows = False
        Me.dgvListaUsuarios.AllowUserToOrderColumns = True
        Me.dgvListaUsuarios.AllowUserToResizeRows = False
        Me.dgvListaUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListaUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvListaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.dgvListaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaUsuarios.EnableHeadersVisualStyles = False
        Me.dgvListaUsuarios.Location = New System.Drawing.Point(0, 89)
        Me.dgvListaUsuarios.Name = "dgvListaUsuarios"
        Me.dgvListaUsuarios.ReadOnly = True
        Me.dgvListaUsuarios.RowHeadersVisible = False
        Me.dgvListaUsuarios.RowHeadersWidth = 5
        Me.dgvListaUsuarios.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvListaUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvListaUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListaUsuarios.RowTemplate.Height = 30
        Me.dgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaUsuarios.Size = New System.Drawing.Size(662, 620)
        Me.dgvListaUsuarios.TabIndex = 536
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
        'MenuActivarUsuario
        '
        Me.MenuActivarUsuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivarUsuarioToolStripMenuItem})
        Me.MenuActivarUsuario.Name = "MenuActivarUsuario"
        Me.MenuActivarUsuario.Size = New System.Drawing.Size(154, 26)
        '
        'ActivarUsuarioToolStripMenuItem
        '
        Me.ActivarUsuarioToolStripMenuItem.Image = CType(resources.GetObject("ActivarUsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActivarUsuarioToolStripMenuItem.Name = "ActivarUsuarioToolStripMenuItem"
        Me.ActivarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ActivarUsuarioToolStripMenuItem.Text = "Activar usuario"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 709)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dgvListaUsuarios)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStripBuscar.ResumeLayout(False)
        Me.MenuStripBuscar.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.pnlUsuario.ResumeLayout(False)
        Me.pnlUsuario.PerformLayout()
        Me.pnl_Iconos.ResumeLayout(False)
        Me.pnl_Iconos.PerformLayout()
        CType(Me.pic9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripBotonesUser.ResumeLayout(False)
        Me.MenuStripBotonesUser.PerformLayout()
        Me.MenuStripGenerarPassword.ResumeLayout(False)
        Me.MenuStripGenerarPassword.PerformLayout()
        CType(Me.picIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuActivarUsuario.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblUsuarios As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents MenuStripBuscar As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnl_Iconos As Panel
    Friend WithEvents lblNumeroIcono As Label
    Friend WithEvents lblEnUso As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents lbl8 As Label
    Friend WithEvents pic9 As PictureBox
    Friend WithEvents pic8 As PictureBox
    Friend WithEvents lbl7 As Label
    Friend WithEvents pic7 As PictureBox
    Friend WithEvents lbl6 As Label
    Friend WithEvents pic6 As PictureBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pnlUsuario As Panel
    Friend WithEvents lblAnuncioIcono As Label
    Friend WithEvents picIcono As PictureBox
    Friend WithEvents lblContadorPassword As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents MenuStripBotonesUser As MenuStrip
    Friend WithEvents guardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStripGenerarPassword As MenuStrip
    Friend WithEvents generarPassToolStrip As ToolStripMenuItem
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtNombreApellido As TextBox
    Friend WithEvents lblRol As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents ofdCargarImagen As OpenFileDialog
    Friend WithEvents lblBuscarUsuario As Label
    Friend WithEvents dgvListaUsuarios As DataGridView
    Friend WithEvents MenuActivarUsuario As ContextMenuStrip
    Friend WithEvents ActivarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Eli As DataGridViewImageColumn
    Friend WithEvents lbl_IdUsuario As Label
End Class
