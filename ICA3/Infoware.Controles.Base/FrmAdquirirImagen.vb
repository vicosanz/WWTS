Imports WIA
Imports System.IO
Imports System.Runtime.InteropServices

Public Class FrmAdquirirImagen
  Private mimageFileName As String
  Public ReadOnly Property ImageFileName() As String
    Get
      Return mimageFileName
    End Get
  End Property

  Private Sub Adquirir()
    Dim device As Scanner = ToolStripComboBox1.SelectedItem
    If Device Is Nothing Then
      MessageBox.Show("Por favor seleccione un dispositivo primero", "Información", MessageBoxButtons.OK)
      Exit Sub
    End If

    mimageFileName = Path.GetTempFileName
    Dim imagex As ImageFile = device.Scan
    File.Delete(mimageFileName)
    imagex.SaveFile(mimageFileName)
    picfoto.Image = image.FromFile(mimageFileName)
    Me.btnguardar.Enabled = True
    '      
    'Dim wiaManager As WiaClass = Nothing 'WIA manager COM object
    'Dim wiaDevs As CollectionClass = Nothing ''// WIA devices collection COM object
    'Dim wiaRoot As ItemClass = Nothing ''// WIA root device COM object
    'Dim wiaPics As CollectionClass = Nothing ''// WIA collection COM object
    'Dim wiaItem As ItemClass = Nothing ''// WIA image COM object

    'Try
    '  wiaManager = New WiaClass ''// create COM instance of WIA manager

    '  wiaDevs = CType(wiaManager.Devices, CollectionClass) '// call Wia.Devices to get all devices
    '  If ((wiaDevs Is Nothing) Or (wiaDevs.Count = 0)) Then
    '    MessageBox.Show(Me, "No se encontraron dispositivos WIA", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '    Me.DialogResult = Windows.Forms.DialogResult.Cancel
    '    Return
    '  End If

    '  Dim selectUsingUI As Object = System.Reflection.Missing.Value '// = Nothing
    '  wiaRoot = CType(wiaManager.Create(selectUsingUI), ItemClass) '// let user select device
    '  If (wiaRoot Is Nothing) Then '// nothing to do
    '    Return
    '  End If

    '  '// this call shows the common WIA dialog to let the user select a picture:
    '  wiaPics = CType(wiaRoot.GetItemsFromUI(WiaFlag.SingleImage, WiaIntent.ImageTypeColor), CollectionClass)
    '  If (wiaPics Is Nothing) Then
    '    Return
    '  End If


    '  Dim takeFirst As Boolean = True '// this sample uses only one single picture
    '  For Each wiaObj As Object In wiaPics '// enumerate all the pictures the user selected
    '    If (takeFirst) Then
    '      DisposeImage() '// remove previous picture
    '      wiaItem = CType(Marshal.CreateWrapperOfType(wiaObj, wiaRoot.GetType), ItemClass)
    '      mimageFileName = Path.GetTempFileName() '// create temporary file for image
    '      Windows.Forms.Cursor.Current = Cursors.WaitCursor '// could take some time
    '      Me.Refresh()
    '      wiaItem.Transfer(mimageFileName, False) '// transfer picture to our temporary file
    '      picfoto.Image = Image.FromFile(mimageFileName) '// create Image instance from file
    '      Me.btnguardar.Enabled = True '// enable "Save as" menu entry
    '      takeFirst = False '// first and only one done.
    '    End If
    '    Marshal.ReleaseComObject(wiaObj) '// release enumerated COM object
    '  Next

    'Catch e As Exception
    '  MessageBox.Show(Me, "Falló la adquisición de imágenes WIA" & vbCrLf & e.Message, "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '  Me.DialogResult = Windows.Forms.DialogResult.Cancel
    '  Return
    'Finally
    '  If (Not wiaItem Is Nothing) Then
    '    Marshal.ReleaseComObject(wiaItem) '// release WIA image COM object
    '  End If
    '  If (Not wiaPics Is Nothing) Then
    '    Marshal.ReleaseComObject(wiaPics) '// release WIA collection COM object
    '  End If
    '  If (Not wiaRoot Is Nothing) Then
    '    Marshal.ReleaseComObject(wiaRoot) '// release WIA root device COM object
    '  End If
    '  If (Not wiaDevs Is Nothing) Then
    '    Marshal.ReleaseComObject(wiaDevs) '// release WIA devices collection COM object
    '  End If
    '  If (Not wiaManager Is Nothing) Then
    '    Marshal.ReleaseComObject(wiaManager) '// release WIA manager COM object
    '  End If
    '  Windows.Forms.Cursor.Current = Cursors.Default '// restore cursor
    'End Try
  End Sub

  Private Sub DisposeImage()
    Me.btnguardar.Enabled = False '// disable "Save As" menu entry
    Dim oldImg As Image = picfoto.Image
    picfoto.Image = Nothing '// empty picture box
    If Not oldImg Is Nothing Then
      oldImg.Dispose() ' dispose old image (free memory, unlock file)
    End If

    If Not mimageFileName Is Nothing Then '// try delete temporary image file
      Try
        File.Delete(mimageFileName)
      Catch ex As Exception
      End Try
    End If
  End Sub

  Private Sub Guardar()
    If (picfoto.Image Is Nothing) Then   '// no bitmap exists
      Return
    End If
    Me.DialogResult = Windows.Forms.DialogResult.OK
    'Dim rutfoto As String = My.Computer.FileSystem.SpecialDirectories.Temp

    'rutfoto = rutfoto & "\Escaneada.jpg"

    'Try
    '  Kill(rutfoto)
    'Catch ex As Exception
    'End Try
    'Try
    '  picfoto.Image.Save(rutfoto)     '// save to file
    'Catch ex As Exception
    '  MsgBox(ex.Message)
    'End Try
  End Sub

  Private Sub btnadquirir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadquirir.Click
    Adquirir()
  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    Guardar()
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
    DisposeImage()
  End Sub

  Private Sub FrmAdquirirImagen_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    Me.ToolStripComboBox1.Items.Clear()
    Dim devicemng As DeviceManager = New DeviceManager
    Dim i As Integer = devicemng.DeviceInfos.Count
    For Each dev As DeviceInfo In devicemng.DeviceInfos
      If dev.Type = WiaDeviceType.ScannerDeviceType Then
        Me.ToolStripComboBox1.Items.Add(New Scanner(dev))
      End If
    Next
  End Sub

  Public Class Scanner
    Private _deviceInfo As DeviceInfo

    Public Sub New(deviceInfo As DeviceInfo)
      _deviceInfo = deviceInfo
    End Sub

    Public Function Scan() As ImageFile
      Dim Device = _deviceInfo.Connect
      Dim dialog As CommonDialog = New WIA.CommonDialog()

      'Dim item = Device.Items(1)
      'Dim imageFile = item.Transfer(FormatID.wiaFormatJPEG)
      Dim imageFile = dialog.ShowAcquireImage( _
                        WiaDeviceType.ScannerDeviceType, _
                        WiaImageIntent.UnspecifiedIntent, _
                        WiaImageBias.MaximizeQuality, _
                        FormatID.wiaFormatPNG, _
                        True, True, False)
      Return imageFile
    End Function

    Public Overrides Function ToString() As String
      Return _deviceInfo.Properties("Name").Value
    End Function
  End Class

End Class