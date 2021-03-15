<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoRubrosxCentroCosto
  Inherits Infoware.Consola.Base.FrmDialogoBase

  'Form overrides dispose to clean up the component list.
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

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCentroCosto = New WWTS.General.Controles.ComboBoxParametroDet()
        Me.ComboBoxRubro = New WWTS.General.Controles.ComboBoxParametroDet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCtaCtble = New Infoware.Controles.Base.TextBoxStd()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C. Costo:"
        '
        'ComboBoxCentroCosto
        '
        Me.ComboBoxCentroCosto.AbriralEntrar = False
        Me.ComboBoxCentroCosto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCentroCosto.FormattingEnabled = True
        Me.ComboBoxCentroCosto.Location = New System.Drawing.Point(106, 12)
        Me.ComboBoxCentroCosto.Name = "ComboBoxCentroCosto"
        Me.ComboBoxCentroCosto.OperadorDatos = Nothing
        Me.ComboBoxCentroCosto.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxCentroCosto.ParametroDet = Nothing
        Me.ComboBoxCentroCosto.PuedeActualizar = True
        Me.ComboBoxCentroCosto.PuedeEliminar = True
        Me.ComboBoxCentroCosto.PuedeModificar = True
        Me.ComboBoxCentroCosto.PuedeNuevo = True
        Me.ComboBoxCentroCosto.Size = New System.Drawing.Size(291, 21)
        Me.ComboBoxCentroCosto.TabIndex = 1
        '
        'ComboBoxRubro
        '
        Me.ComboBoxRubro.AbriralEntrar = False
        Me.ComboBoxRubro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRubro.FormattingEnabled = True
        Me.ComboBoxRubro.Location = New System.Drawing.Point(106, 40)
        Me.ComboBoxRubro.Name = "ComboBoxRubro"
        Me.ComboBoxRubro.OperadorDatos = Nothing
        Me.ComboBoxRubro.Parametro = WWTS.General.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.ComboBoxRubro.ParametroDet = Nothing
        Me.ComboBoxRubro.PuedeActualizar = True
        Me.ComboBoxRubro.PuedeEliminar = True
        Me.ComboBoxRubro.PuedeModificar = True
        Me.ComboBoxRubro.PuedeNuevo = True
        Me.ComboBoxRubro.Size = New System.Drawing.Size(291, 21)
        Me.ComboBoxRubro.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rubro:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cuenta contable:"
        '
        'txtCtaCtble
        '
        Me.txtCtaCtble.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtaCtble.Location = New System.Drawing.Point(106, 68)
        Me.txtCtaCtble.Mensaje = ""
        Me.txtCtaCtble.Name = "txtCtaCtble"
        Me.txtCtaCtble.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCtble.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtCtaCtble.PromptText = ""
        Me.txtCtaCtble.Size = New System.Drawing.Size(291, 20)
        Me.txtCtaCtble.TabIndex = 5
        Me.txtCtaCtble.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
        '
        'FrmMantenimientoRubrosxCentroCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 147)
        Me.Controls.Add(Me.txtCtaCtble)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxRubro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxCentroCosto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMantenimientoRubrosxCentroCosto"
        Me.Text = "Rubro por centro de costo"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxCentroCosto, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxRubro, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtCtaCtble, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxCentroCosto As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents ComboBoxRubro As WWTS.General.Controles.ComboBoxParametroDet
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtCtaCtble As Infoware.Controles.Base.TextBoxStd
End Class
