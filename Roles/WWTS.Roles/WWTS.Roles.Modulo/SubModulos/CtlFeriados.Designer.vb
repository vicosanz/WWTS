<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlFeriados
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.components = New System.ComponentModel.Container
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.CtlPais1 = New WWTS.General.Controles.ComboBoxParametroDet
    Me.Label1 = New System.Windows.Forms.Label
    Me.dgferiados = New Infoware.Consola.Base.DataGridViewAutoDiscover
    Me.FerfechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FerdescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FeriadoListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.Panel1.SuspendLayout()
    CType(Me.dgferiados, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.FeriadoListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CtlPais1)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(513, 45)
    Me.Panel1.TabIndex = 0
    '
    'CtlPais1
    '
    Me.CtlPais1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.CtlPais1.FormattingEnabled = True
    Me.CtlPais1.Location = New System.Drawing.Point(92, 10)
    Me.CtlPais1.Name = "CtlPais1"
    Me.CtlPais1.OperadorDatos = Nothing
    Me.CtlPais1.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.CtlPais1.ParametroDet = Nothing
    Me.CtlPais1.PuedeActualizar = True
    Me.CtlPais1.PuedeEliminar = True
    Me.CtlPais1.PuedeModificar = True
    Me.CtlPais1.PuedeNuevo = True
    Me.CtlPais1.Size = New System.Drawing.Size(161, 21)
    Me.CtlPais1.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(33, 13)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(29, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "País"
    '
    'dgferiados
    '
    Me.dgferiados.AllowUserToOrderColumns = True
    Me.dgferiados.AutoGenerateColumns = False
    Me.dgferiados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgferiados.DataSource = Me.FeriadoListBindingSource
    Me.dgferiados.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgferiados.Location = New System.Drawing.Point(0, 45)
    Me.dgferiados.Name = "dgferiados"
    Me.dgferiados.Size = New System.Drawing.Size(513, 356)
    Me.dgferiados.TabIndex = 1
    '
    'FerfechaDataGridViewTextBoxColumn
    '
    Me.FerfechaDataGridViewTextBoxColumn.DataPropertyName = "Feriad_Fecha"
    DataGridViewCellStyle1.Format = "d"
    Me.FerfechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
    Me.FerfechaDataGridViewTextBoxColumn.HeaderText = "Feriad_Fecha"
    Me.FerfechaDataGridViewTextBoxColumn.Name = "FerfechaDataGridViewTextBoxColumn"
    '
    'FerdescripcionDataGridViewTextBoxColumn
    '
    Me.FerdescripcionDataGridViewTextBoxColumn.DataPropertyName = "fer_descripcion"
    Me.FerdescripcionDataGridViewTextBoxColumn.HeaderText = "fer_descripcion"
    Me.FerdescripcionDataGridViewTextBoxColumn.Name = "FerdescripcionDataGridViewTextBoxColumn"
    Me.FerdescripcionDataGridViewTextBoxColumn.Width = 300
    '
    'FeriadoListBindingSource
    '
    Me.FeriadoListBindingSource.DataSource = GetType(WWTS.Roles.Reglas.FeriadoList)
    '
    'CtlFeriados
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.dgferiados)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "CtlFeriados"
    Me.Size = New System.Drawing.Size(513, 401)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.dgferiados, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.FeriadoListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents CtlPais1 As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents dgferiados As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents FerfechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FerdescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FeriadoListBindingSource As System.Windows.Forms.BindingSource

End Class
