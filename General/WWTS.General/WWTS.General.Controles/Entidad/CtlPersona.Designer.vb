<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlPersona
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
    Me.components = New System.ComponentModel.Container()
    Me.pnltipopersona = New System.Windows.Forms.Panel()
    Me.rdopersonajuridica = New System.Windows.Forms.RadioButton()
    Me.rdopersonanatural = New System.Windows.Forms.RadioButton()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.pnlcuerpo = New System.Windows.Forms.Panel()
    Me.btnregproveedor = New Infoware.Controles.Base.ButtonStd()
    Me.btnregcliente = New Infoware.Controles.Base.ButtonStd()
    Me.pnlRegistrar = New Infoware.Controles.Base.TaskBoxStd()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.PictureBoxSQL1 = New Infoware.Controles.Base.ImagenSQL()
    Me.pnltipopersona.SuspendLayout()
    Me.pnlRegistrar.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnltipopersona
    '
    Me.pnltipopersona.Controls.Add(Me.rdopersonajuridica)
    Me.pnltipopersona.Controls.Add(Me.rdopersonanatural)
    Me.pnltipopersona.Controls.Add(Me.Label1)
    Me.pnltipopersona.Location = New System.Drawing.Point(91, 3)
    Me.pnltipopersona.Name = "pnltipopersona"
    Me.pnltipopersona.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.pnltipopersona.Size = New System.Drawing.Size(443, 22)
    Me.pnltipopersona.TabIndex = 4
    Me.pnltipopersona.Visible = False
    '
    'rdopersonajuridica
    '
    Me.rdopersonajuridica.AutoSize = True
    Me.rdopersonajuridica.Location = New System.Drawing.Point(239, 2)
    Me.rdopersonajuridica.Name = "rdopersonajuridica"
    Me.rdopersonajuridica.Size = New System.Drawing.Size(100, 17)
    Me.rdopersonajuridica.TabIndex = 1
    Me.rdopersonajuridica.Text = "Persona juridica"
    Me.rdopersonajuridica.UseVisualStyleBackColor = True
    '
    'rdopersonanatural
    '
    Me.rdopersonanatural.AutoSize = True
    Me.rdopersonanatural.Checked = True
    Me.rdopersonanatural.Location = New System.Drawing.Point(132, 2)
    Me.rdopersonanatural.Name = "rdopersonanatural"
    Me.rdopersonanatural.Size = New System.Drawing.Size(99, 17)
    Me.rdopersonanatural.TabIndex = 1
    Me.rdopersonanatural.TabStop = True
    Me.rdopersonanatural.Text = "Persona natural"
    Me.rdopersonanatural.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(7, 3)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(87, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Tipo de persona:"
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 87)
    Me.pnlcuerpo.Name = "pnlcuerpo"
    Me.pnlcuerpo.Size = New System.Drawing.Size(538, 280)
    Me.pnlcuerpo.TabIndex = 5
    '
    'btnregproveedor
    '
    Me.btnregproveedor.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnregproveedor.Location = New System.Drawing.Point(163, 28)
    Me.btnregproveedor.Name = "btnregproveedor"
    Me.btnregproveedor.Size = New System.Drawing.Size(159, 23)
    Me.btnregproveedor.TabIndex = 0
    Me.btnregproveedor.Text = "Registrar como proveedor"
    Me.btnregproveedor.UseVisualStyleBackColor = True
    '
    'btnregcliente
    '
    Me.btnregcliente.Dock = System.Windows.Forms.DockStyle.Left
    Me.btnregcliente.Location = New System.Drawing.Point(4, 28)
    Me.btnregcliente.Name = "btnregcliente"
    Me.btnregcliente.Size = New System.Drawing.Size(159, 23)
    Me.btnregcliente.TabIndex = 0
    Me.btnregcliente.Text = "Registrar como cliente"
    Me.btnregcliente.UseVisualStyleBackColor = True
    '
    'pnlRegistrar
    '
    Me.pnlRegistrar.BackColor = System.Drawing.Color.Transparent
    Me.pnlRegistrar.Controls.Add(Me.btnregproveedor)
    Me.pnlRegistrar.Controls.Add(Me.btnregcliente)
    Me.pnlRegistrar.HeaderText = "Registrar persona"
    Me.pnlRegistrar.isChevronRight = False
    Me.pnlRegistrar.IsModoMini = True
    Me.pnlRegistrar.Location = New System.Drawing.Point(91, 31)
    Me.pnlRegistrar.Name = "pnlRegistrar"
    Me.pnlRegistrar.Padding = New System.Windows.Forms.Padding(4, 28, 4, 3)
    Me.pnlRegistrar.Size = New System.Drawing.Size(443, 53)
    Me.pnlRegistrar.TabIndex = 0
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.54275!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.45725!))
    Me.TableLayoutPanel1.Controls.Add(Me.pnlRegistrar, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.pnltipopersona, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.PictureBoxSQL1, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(538, 87)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'PictureBoxSQL1
    '
    Me.PictureBoxSQL1.ArchivoImagen = Nothing
    Me.PictureBoxSQL1.BackColor = System.Drawing.Color.Transparent
    Me.PictureBoxSQL1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBoxSQL1.Imagen = Nothing
    Me.PictureBoxSQL1.Location = New System.Drawing.Point(3, 3)
    Me.PictureBoxSQL1.Name = "PictureBoxSQL1"
    Me.PictureBoxSQL1.Padding = New System.Windows.Forms.Padding(3)
    Me.TableLayoutPanel1.SetRowSpan(Me.PictureBoxSQL1, 2)
    Me.PictureBoxSQL1.Size = New System.Drawing.Size(82, 81)
    Me.PictureBoxSQL1.TabIndex = 5
    Me.PictureBoxSQL1.TabStop = False
    '
    'CtlPersona
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.pnlcuerpo)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "CtlPersona"
    Me.Size = New System.Drawing.Size(538, 367)
    Me.pnltipopersona.ResumeLayout(False)
    Me.pnltipopersona.PerformLayout()
    Me.pnlRegistrar.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnltipopersona As System.Windows.Forms.Panel
  Friend WithEvents rdopersonajuridica As System.Windows.Forms.RadioButton
  Friend WithEvents rdopersonanatural As System.Windows.Forms.RadioButton
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pnlcuerpo As System.Windows.Forms.Panel
  Friend WithEvents btnregproveedor As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnregcliente As Infoware.Controles.Base.ButtonStd
  Friend WithEvents pnlRegistrar As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents PictureBoxSQL1 As Infoware.Controles.Base.ImagenSQL
End Class
