<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PequeñoFormulario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PequeñoFormulario))
        LNya = New Label()
        LDni = New Label()
        LModificar = New Label()
        LApellido = New Label()
        LNombre = New Label()
        TGuardar = New Button()
        TEliminar = New Button()
        TDni = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        Panel1 = New Panel()
        CMastercard = New CheckBox()
        CVisa = New CheckBox()
        CNaranja = New CheckBox()
        LTarjeta = New Label()
        TTelefono = New TextBox()
        LTelefono = New Label()
        LTitulo = New Label()
        PictureBox1 = New PictureBox()
        RBVaron = New RadioButton()
        RBMujer = New RadioButton()
        BSalir = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.Location = New Point(16, 13)
        LNya.Name = "LNya"
        LNya.Size = New Size(110, 15)
        LNya.TabIndex = 0
        LNya.Text = "Nombre y Apellido:"
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(16, 52)
        LDni.Name = "LDni"
        LDni.Size = New Size(35, 15)
        LDni.TabIndex = 1
        LDni.Text = "* DNI"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(132, 13)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 2
        LModificar.Text = "modificar"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(16, 81)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(59, 15)
        LApellido.TabIndex = 3
        LApellido.Text = "* Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(16, 110)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(59, 15)
        LNombre.TabIndex = 4
        LNombre.Text = "* Nombre"
        ' 
        ' TGuardar
        ' 
        TGuardar.Image = CType(resources.GetObject("TGuardar.Image"), Image)
        TGuardar.ImageAlign = ContentAlignment.MiddleLeft
        TGuardar.Location = New Point(40, 329)
        TGuardar.Name = "TGuardar"
        TGuardar.Size = New Size(98, 47)
        TGuardar.TabIndex = 5
        TGuardar.Text = "Guardar"
        TGuardar.TextAlign = ContentAlignment.MiddleRight
        TGuardar.UseVisualStyleBackColor = True
        ' 
        ' TEliminar
        ' 
        TEliminar.Image = CType(resources.GetObject("TEliminar.Image"), Image)
        TEliminar.ImageAlign = ContentAlignment.MiddleLeft
        TEliminar.Location = New Point(157, 329)
        TEliminar.Name = "TEliminar"
        TEliminar.Size = New Size(98, 47)
        TEliminar.TabIndex = 6
        TEliminar.Text = "Eliminar"
        TEliminar.TextAlign = ContentAlignment.MiddleRight
        TEliminar.UseVisualStyleBackColor = True
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(90, 49)
        TDni.Name = "TDni"
        TDni.Size = New Size(100, 23)
        TDni.TabIndex = 7
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(90, 78)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(100, 23)
        TApellido.TabIndex = 8
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(90, 107)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(100, 23)
        TNombre.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(CMastercard)
        Panel1.Controls.Add(CVisa)
        Panel1.Controls.Add(CNaranja)
        Panel1.Controls.Add(LTarjeta)
        Panel1.Controls.Add(TTelefono)
        Panel1.Controls.Add(LTelefono)
        Panel1.Controls.Add(LDni)
        Panel1.Controls.Add(TNombre)
        Panel1.Controls.Add(LNya)
        Panel1.Controls.Add(TApellido)
        Panel1.Controls.Add(LModificar)
        Panel1.Controls.Add(TDni)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(LNombre)
        Panel1.Location = New Point(12, 57)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(289, 249)
        Panel1.TabIndex = 10
        ' 
        ' CMastercard
        ' 
        CMastercard.AutoSize = True
        CMastercard.Location = New Point(145, 227)
        CMastercard.Name = "CMastercard"
        CMastercard.Size = New Size(85, 19)
        CMastercard.TabIndex = 15
        CMastercard.Text = "Mastercard"
        CMastercard.UseVisualStyleBackColor = True
        ' 
        ' CVisa
        ' 
        CVisa.AutoSize = True
        CVisa.Location = New Point(145, 202)
        CVisa.Name = "CVisa"
        CVisa.Size = New Size(47, 19)
        CVisa.TabIndex = 14
        CVisa.Text = "Visa"
        CVisa.UseVisualStyleBackColor = True
        ' 
        ' CNaranja
        ' 
        CNaranja.AutoSize = True
        CNaranja.Location = New Point(145, 177)
        CNaranja.Name = "CNaranja"
        CNaranja.Size = New Size(67, 19)
        CNaranja.TabIndex = 13
        CNaranja.Text = "Naranja"
        CNaranja.UseVisualStyleBackColor = True
        ' 
        ' LTarjeta
        ' 
        LTarjeta.AutoSize = True
        LTarjeta.Location = New Point(20, 177)
        LTarjeta.Name = "LTarjeta"
        LTarjeta.Size = New Size(105, 15)
        LTarjeta.TabIndex = 12
        LTarjeta.Text = "Tarjeta de creditos:"
        ' 
        ' TTelefono
        ' 
        TTelefono.Location = New Point(90, 136)
        TTelefono.Name = "TTelefono"
        TTelefono.Size = New Size(100, 23)
        TTelefono.TabIndex = 11
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Location = New Point(16, 139)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(52, 15)
        LTelefono.TabIndex = 10
        LTelefono.Text = "Telefono"
        ' 
        ' LTitulo
        ' 
        LTitulo.AutoSize = True
        LTitulo.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        LTitulo.ForeColor = Color.DodgerBlue
        LTitulo.Location = New Point(199, 9)
        LTitulo.Name = "LTitulo"
        LTitulo.Size = New Size(158, 30)
        LTitulo.TabIndex = 11
        LTitulo.Text = "Nuevo Cliente"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(352, 57)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(162, 136)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' RBVaron
        ' 
        RBVaron.AutoSize = True
        RBVaron.Checked = True
        RBVaron.Location = New Point(352, 207)
        RBVaron.Name = "RBVaron"
        RBVaron.Size = New Size(55, 19)
        RBVaron.TabIndex = 13
        RBVaron.TabStop = True
        RBVaron.Text = "Varon"
        RBVaron.UseVisualStyleBackColor = True
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.Location = New Point(413, 207)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(56, 19)
        RBMujer.TabIndex = 14
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' BSalir
        ' 
        BSalir.Image = CType(resources.GetObject("BSalir.Image"), Image)
        BSalir.ImageAlign = ContentAlignment.MiddleLeft
        BSalir.Location = New Point(416, 329)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(98, 47)
        BSalir.TabIndex = 15
        BSalir.Text = "Salir"
        BSalir.TextAlign = ContentAlignment.MiddleRight
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' PequeñoFormulario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(585, 388)
        Controls.Add(BSalir)
        Controls.Add(RBMujer)
        Controls.Add(RBVaron)
        Controls.Add(PictureBox1)
        Controls.Add(LTitulo)
        Controls.Add(Panel1)
        Controls.Add(TEliminar)
        Controls.Add(TGuardar)
        Name = "PequeñoFormulario"
        Text = "Pequeño Formulario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LNya As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TGuardar As Button
    Friend WithEvents TEliminar As Button
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CMastercard As CheckBox
    Friend WithEvents CVisa As CheckBox
    Friend WithEvents CNaranja As CheckBox
    Friend WithEvents LTarjeta As Label
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents LTelefono As Label
    Friend WithEvents LTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents BSalir As Button

End Class
