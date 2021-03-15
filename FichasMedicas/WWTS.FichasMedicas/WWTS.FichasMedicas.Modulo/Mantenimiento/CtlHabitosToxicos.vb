Imports WWTS.FichasMedicas.Reglas

Public Class CtlHabitosToxicos

  Private mFichaMedica As FichaMedica
  Public Property FichaMedica As FichaMedica
    Get
      Return mFichaMedica
    End Get
    Set(value As FichaMedica)
      mFichaMedica = value
      If Not value Is Nothing Then
        Actualizar()
      End If
    End Set
  End Property

  Public Sub Actualizar()
    Ficha_Tabaco.Checked = mFichaMedica.Ficha_Tabaco
    Ficha_TabacoTiempo.Text = mFichaMedica.Ficha_TabacoTiempo
    Ficha_TabacoCantidad.Text = mFichaMedica.Ficha_TabacoCantidad
    Ficha_TabacoExConsumidor.Checked = mFichaMedica.Ficha_TabacoExConsumidor
    Ficha_TabacoTiempoAbstinencia.Text = mFichaMedica.Ficha_TabacoTiempoAbstinencia

    Ficha_Alcohol.Checked = mFichaMedica.Ficha_Alcohol
    Ficha_AlcoholTiempo.Text = mFichaMedica.Ficha_AlcoholTiempo
    Ficha_AlcoholCantidad.Text = mFichaMedica.Ficha_AlcoholCantidad
    Ficha_AlcoholExConsumidor.Checked = mFichaMedica.Ficha_AlcoholExConsumidor
    Ficha_AlcoholTiempoAbstinencia.Text = mFichaMedica.Ficha_AlcoholTiempoAbstinencia

    Ficha_Droga1.Checked = mFichaMedica.Ficha_Droga1
    Ficha_Droga1Nombre.Text = mFichaMedica.Ficha_Droga1Nombre
    Ficha_Droga1Tiempo.Text = mFichaMedica.Ficha_Droga1Tiempo
    Ficha_Droga1Cantidad.Text = mFichaMedica.Ficha_Droga1Cantidad
    Ficha_Droga1ExConsumidor.Checked = mFichaMedica.Ficha_Droga1ExConsumidor
    Ficha_Droga1TiempoAbstinencia.Text = mFichaMedica.Ficha_Droga1TiempoAbstinencia

    Ficha_Droga2.Checked = mFichaMedica.Ficha_Droga2
    Ficha_Droga2Nombre.Text = mFichaMedica.Ficha_Droga2Nombre
    Ficha_Droga2Tiempo.Text = mFichaMedica.Ficha_Droga2Tiempo
    Ficha_Droga2Cantidad.Text = mFichaMedica.Ficha_Droga2Cantidad
    Ficha_Droga2ExConsumidor.Checked = mFichaMedica.Ficha_Droga2ExConsumidor
    Ficha_Droga2TiempoAbstinencia.Text = mFichaMedica.Ficha_Droga2TiempoAbstinencia

    Ficha_ActivFisica.Checked = mFichaMedica.Ficha_ActivFisica
    Ficha_ActivFisicaDescripcion.Text = mFichaMedica.Ficha_ActivFisicaDescripcion
    Ficha_ActivFisicaTiempoSemanal.Text = mFichaMedica.Ficha_ActivFisicaTiempoSemanal

    Ficha_MedicHabit.Checked = mFichaMedica.Ficha_MedicHabit
    Ficha_MedicHabitDescripcion1.Text = mFichaMedica.Ficha_MedicHabitDescripcion1
    Ficha_MedicHabitDescripcion2.Text = mFichaMedica.Ficha_MedicHabitDescripcion2
    Ficha_MedicHabitDescripcion3.Text = mFichaMedica.Ficha_MedicHabitDescripcion3
    Ficha_MedicHabitCantidad1.Text = mFichaMedica.Ficha_MedicHabitCantidad1
    Ficha_MedicHabitCantidad2.Text = mFichaMedica.Ficha_MedicHabitCantidad2
    Ficha_MedicHabitCantidad3.Text = mFichaMedica.Ficha_MedicHabitCantidad3

    Ficha_Incidentes.Text = mFichaMedica.Ficha_Incidentes
  End Sub

  Public Sub Mapear()
    mFichaMedica.Ficha_Tabaco = Ficha_Tabaco.Checked
    mFichaMedica.Ficha_TabacoTiempo = Ficha_TabacoTiempo.Text
    mFichaMedica.Ficha_TabacoCantidad = Ficha_TabacoCantidad.Text
    mFichaMedica.Ficha_TabacoExConsumidor = Ficha_TabacoExConsumidor.Checked
    mFichaMedica.Ficha_TabacoTiempoAbstinencia = Ficha_TabacoTiempoAbstinencia.Text

    mFichaMedica.Ficha_Alcohol = Ficha_Alcohol.Checked
    mFichaMedica.Ficha_AlcoholTiempo = Ficha_AlcoholTiempo.Text
    mFichaMedica.Ficha_AlcoholCantidad = Ficha_AlcoholCantidad.Text
    mFichaMedica.Ficha_AlcoholExConsumidor = Ficha_AlcoholExConsumidor.Checked
    mFichaMedica.Ficha_AlcoholTiempoAbstinencia = Ficha_AlcoholTiempoAbstinencia.Text

    mFichaMedica.Ficha_Droga1 = Ficha_Droga1.Checked
    mFichaMedica.Ficha_Droga1Nombre = Ficha_Droga1Nombre.Text
    mFichaMedica.Ficha_Droga1Tiempo = Ficha_Droga1Tiempo.Text
    mFichaMedica.Ficha_Droga1Cantidad = Ficha_Droga1Cantidad.Text
    mFichaMedica.Ficha_Droga1ExConsumidor = Ficha_Droga1ExConsumidor.Checked
    mFichaMedica.Ficha_Droga1TiempoAbstinencia = Ficha_Droga1TiempoAbstinencia.Text

    mFichaMedica.Ficha_Droga2 = Ficha_Droga2.Checked
    mFichaMedica.Ficha_Droga2Nombre = Ficha_Droga2Nombre.Text
    mFichaMedica.Ficha_Droga2Tiempo = Ficha_Droga2Tiempo.Text
    mFichaMedica.Ficha_Droga2Cantidad = Ficha_Droga2Cantidad.Text
    mFichaMedica.Ficha_Droga2ExConsumidor = Ficha_Droga2ExConsumidor.Checked
    mFichaMedica.Ficha_Droga2TiempoAbstinencia = Ficha_Droga2TiempoAbstinencia.Text

    mFichaMedica.Ficha_ActivFisica = Ficha_ActivFisica.Checked
    mFichaMedica.Ficha_ActivFisicaDescripcion = Ficha_ActivFisicaDescripcion.Text
    mFichaMedica.Ficha_ActivFisicaTiempoSemanal = Ficha_ActivFisicaTiempoSemanal.Text

    mFichaMedica.Ficha_MedicHabit = Ficha_MedicHabit.Checked
    mFichaMedica.Ficha_MedicHabitDescripcion1 = Ficha_MedicHabitDescripcion1.Text
    mFichaMedica.Ficha_MedicHabitDescripcion2 = Ficha_MedicHabitDescripcion2.Text
    mFichaMedica.Ficha_MedicHabitDescripcion3 = Ficha_MedicHabitDescripcion3.Text
    mFichaMedica.Ficha_MedicHabitCantidad1 = Ficha_MedicHabitCantidad1.Text
    mFichaMedica.Ficha_MedicHabitCantidad2 = Ficha_MedicHabitCantidad2.Text
    mFichaMedica.Ficha_MedicHabitCantidad3 = Ficha_MedicHabitCantidad3.Text

    mFichaMedica.Ficha_Incidentes = Ficha_Incidentes.Text
  End Sub
End Class
