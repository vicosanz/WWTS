<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLabor
  Inherits Infoware.Consola.Base.FrmDialogoBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lblmensaje = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.chkcontrolarhe = New System.Windows.Forms.CheckBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.CtlCargoSeccion = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.CtlModeloLabor1 = New WWTS.Roles.Controles.CtlModeloLabor()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(96, 34)
    Me.txtcodigo.MaxLength = 3
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(60, 20)
    Me.txtcodigo.TabIndex = 2
    Me.txtcodigo.Text = "0"
    Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtcodigo.Value = 0.0R
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 34)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Código:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(96, 60)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(168, 20)
    Me.txtdescripcion.TabIndex = 4
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 60)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Descripción:"
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblmensaje.Location = New System.Drawing.Point(0, 0)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(273, 24)
    Me.lblmensaje.TabIndex = 0
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 89)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(71, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Modelo labor:"
    '
    'chkcontrolarhe
    '
    Me.chkcontrolarhe.AutoSize = True
    Me.chkcontrolarhe.Location = New System.Drawing.Point(96, 113)
    Me.chkcontrolarhe.Name = "chkcontrolarhe"
    Me.chkcontrolarhe.Size = New System.Drawing.Size(128, 17)
    Me.chkcontrolarhe.TabIndex = 7
    Me.chkcontrolarhe.Text = "Controlar horas extras"
    Me.chkcontrolarhe.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(13, 139)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(49, 13)
    Me.Label4.TabIndex = 5
    Me.Label4.Text = "Sección:"
    '
    'CtlCargoSeccion
    '
    Me.CtlCargoSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlCargoSeccion.FormattingEnabled = True
    Me.CtlCargoSeccion.Location = New System.Drawing.Point(97, 136)
    Me.CtlCargoSeccion.Name = "CtlCargoSeccion"
    Me.CtlCargoSeccion.OperadorDatos = Nothing
    Me.CtlCargoSeccion.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CtlCargoSeccion.ParametroDet = Nothing
    Me.CtlCargoSeccion.PuedeActualizar = True
    Me.CtlCargoSeccion.PuedeEliminar = True
    Me.CtlCargoSeccion.PuedeModificar = True
    Me.CtlCargoSeccion.PuedeNuevo = True
    Me.CtlCargoSeccion.Size = New System.Drawing.Size(168, 21)
    Me.CtlCargoSeccion.TabIndex = 6
    '
    'CtlModeloLabor1
    '
    Me.CtlModeloLabor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlModeloLabor1.FormattingEnabled = True
    Me.CtlModeloLabor1.Location = New System.Drawing.Point(96, 86)
    Me.CtlModeloLabor1.ModeloLabor = Nothing
    Me.CtlModeloLabor1.Name = "CtlModeloLabor1"
    Me.CtlModeloLabor1.Op = Nothing
    Me.CtlModeloLabor1.PuedeActualizar = True
    Me.CtlModeloLabor1.PuedeEliminar = True
    Me.CtlModeloLabor1.PuedeModificar = True
    Me.CtlModeloLabor1.PuedeNuevo = True
    Me.CtlModeloLabor1.Size = New System.Drawing.Size(168, 21)
    Me.CtlModeloLabor1.TabIndex = 6
    '
    'FrmLabor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(273, 233)
    Me.Controls.Add(Me.chkcontrolarhe)
    Me.Controls.Add(Me.CtlCargoSeccion)
    Me.Controls.Add(Me.CtlModeloLabor1)
    Me.Controls.Add(Me.lblmensaje)
    Me.Controls.Add(Me.txtcodigo)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtdescripcion)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Name = "FrmLabor"
    Me.Text = "Labores"
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label3, 0)
    Me.Controls.SetChildIndex(Me.txtdescripcion, 0)
    Me.Controls.SetChildIndex(Me.Label4, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.txtcodigo, 0)
    Me.Controls.SetChildIndex(Me.lblmensaje, 0)
    Me.Controls.SetChildIndex(Me.CtlModeloLabor1, 0)
    Me.Controls.SetChildIndex(Me.CtlCargoSeccion, 0)
    Me.Controls.SetChildIndex(Me.chkcontrolarhe, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblmensaje As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents chkcontrolarhe As System.Windows.Forms.CheckBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents CtlCargoSeccion As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents CtlModeloLabor1 As WWTS.Roles.Controles.CtlModeloLabor

End Class
