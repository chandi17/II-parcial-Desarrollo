<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArreglosBidimencional_Banco_
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIntereses = New System.Windows.Forms.MaskedTextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnApertura = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.MaskedTextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.MaskedTextBox()
        Me.txtID = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataHistorial = New System.Windows.Forms.DataGridView()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtValor = New System.Windows.Forms.MaskedTextBox()
        Me.chkRetirar = New System.Windows.Forms.CheckBox()
        Me.chkDepositar = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Retiros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco Occidente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIntereses)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.BtnApertura)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.txtPais)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 436)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apertura de Cuenta"
        '
        'txtIntereses
        '
        Me.txtIntereses.Location = New System.Drawing.Point(81, 228)
        Me.txtIntereses.Mask = "99999999"
        Me.txtIntereses.Name = "txtIntereses"
        Me.txtIntereses.Size = New System.Drawing.Size(100, 22)
        Me.txtIntereses.TabIndex = 16
        Me.txtIntereses.ValidatingType = GetType(Integer)
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(179, 277)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(106, 50)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnApertura
        '
        Me.BtnApertura.Location = New System.Drawing.Point(18, 277)
        Me.BtnApertura.Name = "BtnApertura"
        Me.BtnApertura.Size = New System.Drawing.Size(106, 50)
        Me.BtnApertura.TabIndex = 4
        Me.BtnApertura.Text = "Apertura Cuenta"
        Me.BtnApertura.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(81, 195)
        Me.txtSaldo.Mask = "99999999"
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 22)
        Me.txtSaldo.TabIndex = 15
        Me.txtSaldo.ValidatingType = GetType(Integer)
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(81, 167)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(100, 22)
        Me.txtCiudad.TabIndex = 14
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(81, 139)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(100, 22)
        Me.txtPais.TabIndex = 13
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(81, 83)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 22)
        Me.txtApellido.TabIndex = 12
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(81, 55)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 22)
        Me.txtNombre.TabIndex = 11
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(81, 111)
        Me.txtEdad.Mask = "99999"
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(43, 22)
        Me.txtEdad.TabIndex = 10
        Me.txtEdad.ValidatingType = GetType(Integer)
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(81, 27)
        Me.txtID.Mask = "0000-0000-00000"
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Ciudad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Pais:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Edad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Intereses:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Saldo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataHistorial)
        Me.GroupBox2.Location = New System.Drawing.Point(750, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 436)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial"
        '
        'DataHistorial
        '
        Me.DataHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ingreso, Me.Retiros, Me.MontoActual})
        Me.DataHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataHistorial.Location = New System.Drawing.Point(3, 18)
        Me.DataHistorial.Name = "DataHistorial"
        Me.DataHistorial.RowHeadersWidth = 51
        Me.DataHistorial.RowTemplate.Height = 24
        Me.DataHistorial.Size = New System.Drawing.Size(350, 415)
        Me.DataHistorial.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(24, 277)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(106, 50)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(202, 277)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(106, 50)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtValor)
        Me.GroupBox3.Controls.Add(Me.chkRetirar)
        Me.GroupBox3.Controls.Add(Me.chkDepositar)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btnOk)
        Me.GroupBox3.Controls.Add(Me.BtnCancelar)
        Me.GroupBox3.Location = New System.Drawing.Point(381, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 436)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(144, 53)
        Me.txtValor.Mask = "99999999"
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 22)
        Me.txtValor.TabIndex = 17
        Me.txtValor.ValidatingType = GetType(Integer)
        '
        'chkRetirar
        '
        Me.chkRetirar.AutoSize = True
        Me.chkRetirar.Location = New System.Drawing.Point(171, 114)
        Me.chkRetirar.Name = "chkRetirar"
        Me.chkRetirar.Size = New System.Drawing.Size(73, 21)
        Me.chkRetirar.TabIndex = 10
        Me.chkRetirar.Text = "Retirar"
        Me.chkRetirar.UseVisualStyleBackColor = True
        '
        'chkDepositar
        '
        Me.chkDepositar.AutoSize = True
        Me.chkDepositar.Location = New System.Drawing.Point(39, 114)
        Me.chkDepositar.Name = "chkDepositar"
        Me.chkDepositar.Size = New System.Drawing.Size(91, 21)
        Me.chkDepositar.TabIndex = 9
        Me.chkDepositar.Text = "Depositar"
        Me.chkDepositar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Ingrese el monto:"
        '
        'Ingreso
        '
        Me.Ingreso.HeaderText = "Ingresos"
        Me.Ingreso.MinimumWidth = 6
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.ReadOnly = True
        '
        'Retiros
        '
        Me.Retiros.HeaderText = "Retiros"
        Me.Retiros.MinimumWidth = 6
        Me.Retiros.Name = "Retiros"
        Me.Retiros.ReadOnly = True
        '
        'MontoActual
        '
        Me.MontoActual.HeaderText = "Monto Actual"
        Me.MontoActual.MinimumWidth = 6
        Me.MontoActual.Name = "MontoActual"
        Me.MontoActual.ReadOnly = True
        '
        'ArreglosBidimencional_Banco_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 561)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ArreglosBidimencional_Banco_"
        Me.Text = "ArreglosBidimencional_Banco_"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnApertura As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkRetirar As CheckBox
    Friend WithEvents chkDepositar As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIntereses As MaskedTextBox
    Friend WithEvents txtSaldo As MaskedTextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As MaskedTextBox
    Friend WithEvents txtID As MaskedTextBox
    Friend WithEvents txtValor As MaskedTextBox
    Friend WithEvents DataHistorial As DataGridView
    Friend WithEvents Ingreso As DataGridViewTextBoxColumn
    Friend WithEvents Retiros As DataGridViewTextBoxColumn
    Friend WithEvents MontoActual As DataGridViewTextBoxColumn
End Class
