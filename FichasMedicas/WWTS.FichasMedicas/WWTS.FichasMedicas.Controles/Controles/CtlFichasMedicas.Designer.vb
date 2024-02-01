Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlFichasMedicas
  Inherits System.Windows.Forms.UserControl

  'UserControl reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(disposing As Boolean)
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.pnlfichas = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.BSFichas = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeaderStrip2 = New Infoware.Consola.Base.HeaderStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnnuevaficha = New System.Windows.Forms.ToolStripDropDownButton()
        Me.FichaPreocupacionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichaOcupacionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichaDeReintegroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichaDeRetiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnduplicar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DuplicarEnEsteContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CrearCopiaEnContratoActivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnabrirficha = New System.Windows.Forms.ToolStripButton()
        Me.btneliminarficha = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnimprimirficha = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnpag1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnpag2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnpag3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewTextBoxColumn383 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlfichas.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSFichas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlfichas
        '
        Me.pnlfichas.Controls.Add(Me.DataGridView3)
        Me.pnlfichas.Controls.Add(Me.HeaderStrip2)
        Me.pnlfichas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlfichas.Location = New System.Drawing.Point(0, 0)
        Me.pnlfichas.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.pnlfichas.Name = "pnlfichas"
        Me.pnlfichas.Size = New System.Drawing.Size(1164, 365)
        Me.pnlfichas.TabIndex = 3
        '
        'DataGridView3
        '
        Me.DataGridView3.AgruparRepetidos = False
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.DataSource = Me.BSFichas
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(0, 38)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(1164, 327)
        Me.DataGridView3.TabIndex = 1
        '
        'HeaderStrip2
        '
        Me.HeaderStrip2.AutoSize = False
        Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
        Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HeaderStrip2.HeaderStyle = Infoware.Consola.Base.AreaHeaderStyle.Small
        Me.HeaderStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator3, Me.btnnuevaficha, Me.btnduplicar, Me.ToolStripSeparator1, Me.btnabrirficha, Me.btneliminarficha, Me.ToolStripSeparator2, Me.btnimprimirficha})
        Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
        Me.HeaderStrip2.Name = "HeaderStrip2"
        Me.HeaderStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.HeaderStrip2.Size = New System.Drawing.Size(1164, 38)
        Me.HeaderStrip2.TabIndex = 0
        Me.HeaderStrip2.Text = "Opciones"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(174, 32)
        Me.ToolStripLabel2.Text = "Fichas médicas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'btnnuevaficha
        '
        Me.btnnuevaficha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevaficha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichaPreocupacionalToolStripMenuItem, Me.FichaOcupacionalToolStripMenuItem, Me.FichaDeReintegroToolStripMenuItem, Me.FichaDeRetiroToolStripMenuItem})
        Me.btnnuevaficha.Image = Global.WWTS.FichasMedicas.Controles.My.Resources.Resources._new
        Me.btnnuevaficha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevaficha.Name = "btnnuevaficha"
        Me.btnnuevaficha.Size = New System.Drawing.Size(42, 32)
        Me.btnnuevaficha.Text = "Nuevo"
        '
        'FichaPreocupacionalToolStripMenuItem
        '
        Me.FichaPreocupacionalToolStripMenuItem.Name = "FichaPreocupacionalToolStripMenuItem"
        Me.FichaPreocupacionalToolStripMenuItem.Size = New System.Drawing.Size(374, 44)
        Me.FichaPreocupacionalToolStripMenuItem.Text = "Ficha preocupacional"
        '
        'FichaOcupacionalToolStripMenuItem
        '
        Me.FichaOcupacionalToolStripMenuItem.Name = "FichaOcupacionalToolStripMenuItem"
        Me.FichaOcupacionalToolStripMenuItem.Size = New System.Drawing.Size(374, 44)
        Me.FichaOcupacionalToolStripMenuItem.Text = "Ficha ocupacional"
        '
        'FichaDeReintegroToolStripMenuItem
        '
        Me.FichaDeReintegroToolStripMenuItem.Name = "FichaDeReintegroToolStripMenuItem"
        Me.FichaDeReintegroToolStripMenuItem.Size = New System.Drawing.Size(374, 44)
        Me.FichaDeReintegroToolStripMenuItem.Text = "Ficha de reintegro"
        '
        'FichaDeRetiroToolStripMenuItem
        '
        Me.FichaDeRetiroToolStripMenuItem.Name = "FichaDeRetiroToolStripMenuItem"
        Me.FichaDeRetiroToolStripMenuItem.Size = New System.Drawing.Size(374, 44)
        Me.FichaDeRetiroToolStripMenuItem.Text = "Ficha de retiro"
        '
        'btnduplicar
        '
        Me.btnduplicar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnduplicar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuplicarEnEsteContratoToolStripMenuItem, Me.ToolStripMenuItem1, Me.CrearCopiaEnContratoActivoToolStripMenuItem})
        Me.btnduplicar.Image = Global.WWTS.FichasMedicas.Controles.My.Resources.Resources.copy
        Me.btnduplicar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnduplicar.Name = "btnduplicar"
        Me.btnduplicar.Size = New System.Drawing.Size(42, 32)
        Me.btnduplicar.Text = "Duplicar"
        '
        'DuplicarEnEsteContratoToolStripMenuItem
        '
        Me.DuplicarEnEsteContratoToolStripMenuItem.Name = "DuplicarEnEsteContratoToolStripMenuItem"
        Me.DuplicarEnEsteContratoToolStripMenuItem.Size = New System.Drawing.Size(469, 44)
        Me.DuplicarEnEsteContratoToolStripMenuItem.Text = "Duplicar en este contrato"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(466, 6)
        '
        'CrearCopiaEnContratoActivoToolStripMenuItem
        '
        Me.CrearCopiaEnContratoActivoToolStripMenuItem.Name = "CrearCopiaEnContratoActivoToolStripMenuItem"
        Me.CrearCopiaEnContratoActivoToolStripMenuItem.Size = New System.Drawing.Size(469, 44)
        Me.CrearCopiaEnContratoActivoToolStripMenuItem.Text = "Crear copia en contrato activo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'btnabrirficha
        '
        Me.btnabrirficha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnabrirficha.Image = Global.WWTS.FichasMedicas.Controles.My.Resources.Resources.open
        Me.btnabrirficha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnabrirficha.Name = "btnabrirficha"
        Me.btnabrirficha.Size = New System.Drawing.Size(46, 32)
        Me.btnabrirficha.Text = "Abrir"
        '
        'btneliminarficha
        '
        Me.btneliminarficha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btneliminarficha.Image = Global.WWTS.FichasMedicas.Controles.My.Resources.Resources.delete
        Me.btneliminarficha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btneliminarficha.Name = "btneliminarficha"
        Me.btneliminarficha.Size = New System.Drawing.Size(46, 32)
        Me.btneliminarficha.Text = "Eliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'btnimprimirficha
        '
        Me.btnimprimirficha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnimprimirficha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnpag1, Me.btnpag2, Me.btnpag3})
        Me.btnimprimirficha.Image = Global.WWTS.FichasMedicas.Controles.My.Resources.Resources.print
        Me.btnimprimirficha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnimprimirficha.Name = "btnimprimirficha"
        Me.btnimprimirficha.Size = New System.Drawing.Size(42, 32)
        Me.btnimprimirficha.Text = "Imprimir"
        '
        'btnpag1
        '
        Me.btnpag1.Name = "btnpag1"
        Me.btnpag1.Size = New System.Drawing.Size(239, 44)
        Me.btnpag1.Text = "Página 1"
        '
        'btnpag2
        '
        Me.btnpag2.Name = "btnpag2"
        Me.btnpag2.Size = New System.Drawing.Size(239, 44)
        Me.btnpag2.Text = "Página 2"
        '
        'btnpag3
        '
        Me.btnpag3.Name = "btnpag3"
        Me.btnpag3.Size = New System.Drawing.Size(239, 44)
        Me.btnpag3.Text = "Página 3"
        '
        'DataGridViewTextBoxColumn383
        '
        Me.DataGridViewTextBoxColumn383.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn383.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn383.Name = "DataGridViewTextBoxColumn383"
        Me.DataGridViewTextBoxColumn383.Width = 125
        '
        'CtlFichasMedicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlfichas)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CtlFichasMedicas"
        Me.Size = New System.Drawing.Size(1164, 365)
        Me.pnlfichas.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSFichas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderStrip2.ResumeLayout(False)
        Me.HeaderStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlfichas As Panel
  Friend WithEvents DataGridView3 As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn383 As DataGridViewTextBoxColumn
  Friend WithEvents HeaderStrip2 As Infoware.Consola.Base.HeaderStrip
  Friend WithEvents ToolStripLabel2 As ToolStripLabel
  Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
  Friend WithEvents btnnuevaficha As ToolStripDropDownButton
  Friend WithEvents FichaPreocupacionalToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents FichaOcupacionalToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents FichaDeReintegroToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents FichaDeRetiroToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents btnabrirficha As ToolStripButton
  Friend WithEvents btneliminarficha As ToolStripButton
  Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
  Friend WithEvents btnimprimirficha As ToolStripDropDownButton
  Friend WithEvents btnpag1 As ToolStripMenuItem
  Friend WithEvents btnpag2 As ToolStripMenuItem
  Friend WithEvents btnpag3 As ToolStripMenuItem
  Friend WithEvents BSFichas As BindingSource
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnduplicar As ToolStripDropDownButton
    Friend WithEvents DuplicarEnEsteContratoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CrearCopiaEnContratoActivoToolStripMenuItem As ToolStripMenuItem
End Class
