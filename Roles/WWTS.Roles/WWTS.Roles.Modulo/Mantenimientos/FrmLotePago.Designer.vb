<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLotePago
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLotePago))
    Me.cbotipopago = New WWTS.General.Controles.ComboBoxParametroDet()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.btnnuevo = New Infoware.Controles.Base.ButtonStd()
    Me.btnbuscararch = New Infoware.Controles.Base.ButtonStd()
    Me.txtarchivo = New Infoware.Controles.Base.TextBoxStd()
    Me.txtobservacion = New Infoware.Controles.Base.TextBoxStd()
    Me.lblmensaje = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btneditar = New Infoware.Controles.Base.ButtonStd()
    Me.ofd = New System.Windows.Forms.OpenFileDialog()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cbotipopago
    '
    Me.cbotipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipopago.Location = New System.Drawing.Point(139, 103)
    Me.cbotipopago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.cbotipopago.Name = "cbotipopago"
    Me.cbotipopago.OperadorDatos = Nothing
    Me.cbotipopago.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipopago.ParametroDet = Nothing
    Me.cbotipopago.PuedeActualizar = True
    Me.cbotipopago.PuedeEliminar = True
    Me.cbotipopago.PuedeModificar = True
    Me.cbotipopago.PuedeNuevo = True
    Me.cbotipopago.Size = New System.Drawing.Size(265, 24)
    Me.cbotipopago.TabIndex = 1009
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(16, 107)
    Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(72, 17)
    Me.Label5.TabIndex = 1008
    Me.Label5.Text = "Concepto:"
    '
    'btnnuevo
    '
    Me.btnnuevo.Location = New System.Drawing.Point(453, 69)
    Me.btnnuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(120, 23)
    Me.btnnuevo.TabIndex = 1007
    Me.btnnuevo.Text = "&Nuevo"
    '
    'btnbuscararch
    '
    Me.btnbuscararch.Location = New System.Drawing.Point(413, 69)
    Me.btnbuscararch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btnbuscararch.Name = "btnbuscararch"
    Me.btnbuscararch.Size = New System.Drawing.Size(26, 23)
    Me.btnbuscararch.TabIndex = 1005
    Me.btnbuscararch.Text = "..."
    '
    'txtarchivo
    '
    Me.txtarchivo.Location = New System.Drawing.Point(139, 71)
    Me.txtarchivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtarchivo.Mensaje = ""
    Me.txtarchivo.Name = "txtarchivo"
    Me.txtarchivo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtarchivo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtarchivo.PromptText = ""
    Me.txtarchivo.Size = New System.Drawing.Size(265, 22)
    Me.txtarchivo.TabIndex = 1004
    '
    'txtobservacion
    '
    Me.txtobservacion.Location = New System.Drawing.Point(139, 137)
    Me.txtobservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.txtobservacion.Mensaje = ""
    Me.txtobservacion.Name = "txtobservacion"
    Me.txtobservacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtobservacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtobservacion.PromptText = ""
    Me.txtobservacion.Size = New System.Drawing.Size(471, 22)
    Me.txtobservacion.TabIndex = 1013
    '
    'lblmensaje
    '
    Me.lblmensaje.BackColor = System.Drawing.SystemColors.Info
    Me.lblmensaje.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblmensaje.Location = New System.Drawing.Point(0, 0)
    Me.lblmensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(625, 59)
    Me.lblmensaje.TabIndex = 1001
    Me.lblmensaje.Text = resources.GetString("lblmensaje.Text")
    Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(16, 75)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(59, 17)
    Me.Label1.TabIndex = 1003
    Me.Label1.Text = "Archivo:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(16, 140)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(92, 17)
    Me.Label2.TabIndex = 1012
    Me.Label2.Text = "Observación:"
    '
    'btneditar
    '
    Me.btneditar.Location = New System.Drawing.Point(536, 69)
    Me.btneditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
    Me.btneditar.Name = "btneditar"
    Me.btneditar.Size = New System.Drawing.Size(120, 23)
    Me.btneditar.TabIndex = 1006
    Me.btneditar.Text = "&Editar"
    '
    'ofd
    '
    Me.ofd.Filter = "Archivos de Microsoft Excel (*.xls, *.xlsx, *.xlsm)|*.xls;*.xlsx;*.xlsm|Todos los" & _
    " archivos (*.*)|*.*"
    Me.ofd.Title = "Seleccionar formato de contrato"
    '
    'FrmLotePago
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.ClientSize = New System.Drawing.Size(625, 368)
    Me.Controls.Add(Me.cbotipopago)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.btnnuevo)
    Me.Controls.Add(Me.btnbuscararch)
    Me.Controls.Add(Me.txtarchivo)
    Me.Controls.Add(Me.txtobservacion)
    Me.Controls.Add(Me.lblmensaje)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.btneditar)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Name = "FrmLotePago"
    Me.Text = "Lote de pagos"
    Me.Controls.SetChildIndex(Me.btneditar, 0)
    Me.Controls.SetChildIndex(Me.Label2, 0)
    Me.Controls.SetChildIndex(Me.Label1, 0)
    Me.Controls.SetChildIndex(Me.lblmensaje, 0)
    Me.Controls.SetChildIndex(Me.txtobservacion, 0)
    Me.Controls.SetChildIndex(Me.txtarchivo, 0)
    Me.Controls.SetChildIndex(Me.btnbuscararch, 0)
    Me.Controls.SetChildIndex(Me.btnnuevo, 0)
    Me.Controls.SetChildIndex(Me.Label5, 0)
    Me.Controls.SetChildIndex(Me.cbotipopago, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cbotipopago As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents btnnuevo As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnbuscararch As Infoware.Controles.Base.ButtonStd
  Friend WithEvents txtarchivo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtobservacion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lblmensaje As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btneditar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog

End Class
