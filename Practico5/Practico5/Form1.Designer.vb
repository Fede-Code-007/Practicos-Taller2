<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        BFoto = New Button()
        RBMujer = New RadioButton()
        RBHombre = New RadioButton()
        TFoto = New TextBox()
        TSaldo = New TextBox()
        TNombre = New TextBox()
        TApellido = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        LSaldo = New Label()
        LSexo = New Label()
        LFechaNacimiento = New Label()
        LApellido = New Label()
        LNombre = New Label()
        BAgregar = New Button()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        DataGridView1 = New DataGridView()
        Apellido = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        FechaNacimiento = New DataGridViewTextBoxColumn()
        Sexo = New DataGridViewTextBoxColumn()
        Eliminar = New DataGridViewButtonColumn()
        Saldo = New DataGridViewTextBoxColumn()
        Foto = New DataGridViewImageColumn()
        Ruta = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.images
        Panel1.Controls.Add(BFoto)
        Panel1.Controls.Add(RBMujer)
        Panel1.Controls.Add(RBHombre)
        Panel1.Controls.Add(TFoto)
        Panel1.Controls.Add(TSaldo)
        Panel1.Controls.Add(TNombre)
        Panel1.Controls.Add(TApellido)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(LSaldo)
        Panel1.Controls.Add(LSexo)
        Panel1.Controls.Add(LFechaNacimiento)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(LNombre)
        Panel1.Controls.Add(BAgregar)
        Panel1.Font = New Font("Papyrus", 16F)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(67, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(406, 262)
        Panel1.TabIndex = 0
        ' 
        ' BFoto
        ' 
        BFoto.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BFoto.ForeColor = Color.Black
        BFoto.Location = New Point(21, 177)
        BFoto.Name = "BFoto"
        BFoto.Size = New Size(75, 23)
        BFoto.TabIndex = 14
        BFoto.Text = "Foto"
        BFoto.UseVisualStyleBackColor = True
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.BackColor = Color.Transparent
        RBMujer.Font = New Font("Papyrus", 10F)
        RBMujer.Location = New Point(214, 112)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(65, 26)
        RBMujer.TabIndex = 13
        RBMujer.TabStop = True
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = False
        ' 
        ' RBHombre
        ' 
        RBHombre.AutoSize = True
        RBHombre.BackColor = Color.Transparent
        RBHombre.Checked = True
        RBHombre.Font = New Font("Papyrus", 10F)
        RBHombre.Location = New Point(127, 113)
        RBHombre.Name = "RBHombre"
        RBHombre.Size = New Size(81, 26)
        RBHombre.TabIndex = 12
        RBHombre.TabStop = True
        RBHombre.Text = "Hombre"
        RBHombre.UseVisualStyleBackColor = False
        ' 
        ' TFoto
        ' 
        TFoto.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TFoto.Location = New Point(124, 177)
        TFoto.Name = "TFoto"
        TFoto.Size = New Size(247, 23)
        TFoto.TabIndex = 11
        ' 
        ' TSaldo
        ' 
        TSaldo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TSaldo.Location = New Point(124, 147)
        TSaldo.Name = "TSaldo"
        TSaldo.Size = New Size(247, 23)
        TSaldo.TabIndex = 10
        ' 
        ' TNombre
        ' 
        TNombre.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TNombre.Location = New Point(124, 16)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(247, 23)
        TNombre.TabIndex = 9
        ' 
        ' TApellido
        ' 
        TApellido.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TApellido.Location = New Point(124, 45)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(247, 23)
        TApellido.TabIndex = 8
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(214, 83)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(79, 23)
        DateTimePicker1.TabIndex = 7
        ' 
        ' LSaldo
        ' 
        LSaldo.AutoSize = True
        LSaldo.BackColor = Color.Transparent
        LSaldo.Location = New Point(14, 147)
        LSaldo.Name = "LSaldo"
        LSaldo.Size = New Size(82, 34)
        LSaldo.TabIndex = 6
        LSaldo.Text = "Saldo:"
        ' 
        ' LSexo
        ' 
        LSexo.AutoSize = True
        LSexo.BackColor = Color.Transparent
        LSexo.Location = New Point(14, 113)
        LSexo.Name = "LSexo"
        LSexo.Size = New Size(74, 34)
        LSexo.TabIndex = 5
        LSexo.Text = "Sexo:"
        ' 
        ' LFechaNacimiento
        ' 
        LFechaNacimiento.AutoSize = True
        LFechaNacimiento.BackColor = Color.Transparent
        LFechaNacimiento.Location = New Point(14, 79)
        LFechaNacimiento.Name = "LFechaNacimiento"
        LFechaNacimiento.Size = New Size(194, 34)
        LFechaNacimiento.TabIndex = 4
        LFechaNacimiento.Text = "Fecha Nacimiento:"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.BackColor = Color.Transparent
        LApellido.Location = New Point(14, 45)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(104, 34)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido:"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.BackColor = Color.Transparent
        LNombre.ForeColor = Color.White
        LNombre.Location = New Point(14, 11)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(96, 34)
        LNombre.TabIndex = 2
        LNombre.Text = "Nombre:"
        ' 
        ' BAgregar
        ' 
        BAgregar.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAgregar.ForeColor = Color.Black
        BAgregar.Image = My.Resources.Resources.Diseño_sin_título
        BAgregar.ImageAlign = ContentAlignment.MiddleLeft
        BAgregar.Location = New Point(159, 205)
        BAgregar.Name = "BAgregar"
        BAgregar.Size = New Size(93, 42)
        BAgregar.TabIndex = 1
        BAgregar.Text = "Agregar"
        BAgregar.TextAlign = ContentAlignment.MiddleRight
        BAgregar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.avatar
        PictureBox1.Image = My.Resources.Resources.avatar
        PictureBox1.InitialImage = My.Resources.Resources.avatar
        PictureBox1.Location = New Point(504, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(244, 262)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Apellido, Nombre, FechaNacimiento, Sexo, Eliminar, Saldo, Foto, Ruta})
        DataGridView1.Location = New Point(-7, 304)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(821, 150)
        DataGridView1.TabIndex = 2
        ' 
        ' Apellido
        ' 
        DataGridViewCellStyle3.Font = New Font("Papyrus", 10F, FontStyle.Bold)
        Apellido.DefaultCellStyle = DataGridViewCellStyle3
        Apellido.HeaderText = "Apellido"
        Apellido.Name = "Apellido"
        ' 
        ' Nombre
        ' 
        DataGridViewCellStyle4.Font = New Font("Papyrus", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Nombre.DefaultCellStyle = DataGridViewCellStyle4
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        ' 
        ' FechaNacimiento
        ' 
        FechaNacimiento.HeaderText = "Fecha Nacimiento"
        FechaNacimiento.Name = "FechaNacimiento"
        ' 
        ' Sexo
        ' 
        Sexo.HeaderText = "Sexo"
        Sexo.Name = "Sexo"
        ' 
        ' Eliminar
        ' 
        Eliminar.HeaderText = "Eliminar"
        Eliminar.Name = "Eliminar"
        Eliminar.Resizable = DataGridViewTriState.True
        Eliminar.SortMode = DataGridViewColumnSortMode.Automatic
        Eliminar.Text = "Eliminar"
        Eliminar.UseColumnTextForButtonValue = True
        ' 
        ' Saldo
        ' 
        Saldo.HeaderText = "Saldo"
        Saldo.Name = "Saldo"
        ' 
        ' Foto
        ' 
        Foto.HeaderText = "Foto"
        Foto.ImageLayout = DataGridViewImageCellLayout.Stretch
        Foto.Name = "Foto"
        Foto.Resizable = DataGridViewTriState.True
        Foto.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Ruta
        ' 
        Ruta.HeaderText = "Ruta"
        Ruta.Name = "Ruta"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.cuadros_negros_734708
        ClientSize = New Size(813, 450)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Formulario con Grid"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LNombre As Label
    Friend WithEvents BAgregar As Button
    Friend WithEvents LApellido As Label
    Friend WithEvents LSaldo As Label
    Friend WithEvents LSexo As Label
    Friend WithEvents LFechaNacimiento As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents RBHombre As RadioButton
    Friend WithEvents TFoto As TextBox
    Friend WithEvents TSaldo As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BFoto As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Foto As DataGridViewImageColumn
    Friend WithEvents Ruta As DataGridViewTextBoxColumn

End Class
