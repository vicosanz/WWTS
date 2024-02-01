Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtlFichasMedicasPreocupacionales
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
        Me.btnduplicar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnabrirficha = New System.Windows.Forms.ToolStripButton()
        Me.btneliminarficha = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnimprimirficha = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnpag1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnpag2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnpag3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.sepAdjuntarContrato = New System.Windows.Forms.ToolStripSeparator()
        Me.btnadjuntaraContrato = New System.Windows.Forms.ToolStripButton()
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
        Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripSeparator3, Me.btnnuevaficha, Me.btnduplicar, Me.ToolStripSeparator1, Me.btnabrirficha, Me.btneliminarficha, Me.ToolStripSeparator2, Me.btnimprimirficha, Me.sepAdjuntarContrato, Me.btnadjuntaraContrato})
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
        Me.ToolStripLabel2.Size = New System.Drawing.Size(548, 32)
        Me.ToolStripLabel2.Text = "Fichas médicas Preocupacionales Precontractuales"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'btnnuevaficha
        '
        Me.btnnuevaficha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnuevaficha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichaPreocupacionalToolStripMenuItem})
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
        'btnduplicar
        '
        Me.btnduplicar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnduplicar.Image = Global.WWTS.FichasMedicas.Controles.My.Resources.Resources.copy
        Me.btnduplicar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnduplicar.Name = "btnduplicar"
        Me.btnduplicar.Size = New System.Drawing.Size(46, 32)
        Me.btnduplicar.Text = "Duplicar"
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
        'sepAdjuntarContrato
        '
        Me.sepAdjuntarContrato.Name = "sepAdjuntarContrato"
        Me.sepAdjuntarContrato.Size = New System.Drawing.Size(6, 40)
        Me.sepAdjuntarContrato.Visible = False
        '
        'btnadjuntaraContrato
        '
        Me.btnadjuntaraContrato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnadjuntaraContrato.Image = Global.WWTS.FichasMedicas.Controles.My.Resources.Resources.attach
        Me.btnadjuntaraContrato.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnadjuntaraContrato.Name = "btnadjuntaraContrato"
        Me.btnadjuntaraContrato.Size = New System.Drawing.Size(46, 34)
        Me.btnadjuntaraContrato.Text = "Adjuntar ficha a contrato seleccionado"
        Me.btnadjuntaraContrato.Visible = False
        '
        'DataGridViewTextBoxColumn383
        '
        Me.DataGridViewTextBoxColumn383.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn383.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn383.Name = "DataGridViewTextBoxColumn383"
        Me.DataGridViewTextBoxColumn383.Width = 125
        '
        'CtlFichasMedicasPreocupacionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlfichas)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CtlFichasMedicasPreocupacionales"
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
    Friend WithEvents btnabrirficha As ToolStripButton
    Friend WithEvents btneliminarficha As ToolStripButton
  Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
  Friend WithEvents btnimprimirficha As ToolStripDropDownButton
  Friend WithEvents btnpag1 As ToolStripMenuItem
  Friend WithEvents btnpag2 As ToolStripMenuItem
  Friend WithEvents btnpag3 As ToolStripMenuItem
  Friend WithEvents BSFichas As BindingSource
    Friend WithEvents btnadjuntaraContrato As ToolStripButton
    Friend WithEvents sepAdjuntarContrato As ToolStripSeparator
    Friend WithEvents btnduplicar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
