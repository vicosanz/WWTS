Imports WWTS.FichasMedicas.Reglas

Public Class CtlFactorRiesgoTrabajoActual

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

  Private mNumeral As Integer = 1
  Public Property Numeral As Integer
    Get
      Return mNumeral
    End Get
    Set(value As Integer)
      mNumeral = value
    End Set
  End Property

  Public Sub Actualizar()
    If mNumeral = 1 Then
      Ficha_FactRieArea.Text = mFichaMedica.Ficha_FactRieArea1
      Ficha_FactRieActividad.Text = mFichaMedica.Ficha_FactRieActividad1

      Ficha_FactRieF01.Checked = mFichaMedica.Ficha_FactRieF011
      Ficha_FactRieF02.Checked = mFichaMedica.Ficha_FactRieF021
      Ficha_FactRieF03.Checked = mFichaMedica.Ficha_FactRieF031
      Ficha_FactRieF04.Checked = mFichaMedica.Ficha_FactRieF041
      Ficha_FactRieF05.Checked = mFichaMedica.Ficha_FactRieF051
      Ficha_FactRieF06.Checked = mFichaMedica.Ficha_FactRieF061
      Ficha_FactRieF07.Checked = mFichaMedica.Ficha_FactRieF071
      Ficha_FactRieF08.Checked = mFichaMedica.Ficha_FactRieF081
      Ficha_FactRieF09.Checked = mFichaMedica.Ficha_FactRieF091
      Ficha_FactRieF10.Checked = mFichaMedica.Ficha_FactRieF101

      Ficha_FactRieM01.Checked = mFichaMedica.Ficha_FactRieM011
      Ficha_FactRieM02.Checked = mFichaMedica.Ficha_FactRieM021
      Ficha_FactRieM03.Checked = mFichaMedica.Ficha_FactRieM031
      Ficha_FactRieM04.Checked = mFichaMedica.Ficha_FactRieM041
      Ficha_FactRieM05.Checked = mFichaMedica.Ficha_FactRieM051
      Ficha_FactRieM06.Checked = mFichaMedica.Ficha_FactRieM061
      Ficha_FactRieM07.Checked = mFichaMedica.Ficha_FactRieM071
      Ficha_FactRieM08.Checked = mFichaMedica.Ficha_FactRieM081
      Ficha_FactRieM09.Checked = mFichaMedica.Ficha_FactRieM091
      Ficha_FactRieM10.Checked = mFichaMedica.Ficha_FactRieM101
      Ficha_FactRieM11.Checked = mFichaMedica.Ficha_FactRieM111
      Ficha_FactRieM12.Checked = mFichaMedica.Ficha_FactRieM121
      Ficha_FactRieM13.Checked = mFichaMedica.Ficha_FactRieM131
      Ficha_FactRieM14.Checked = mFichaMedica.Ficha_FactRieM141
      Ficha_FactRieM15.Checked = mFichaMedica.Ficha_FactRieM151

      Ficha_FactRieQ01.Checked = mFichaMedica.Ficha_FactRieQ011
      Ficha_FactRieQ02.Checked = mFichaMedica.Ficha_FactRieQ021
      Ficha_FactRieQ03.Checked = mFichaMedica.Ficha_FactRieQ031
      Ficha_FactRieQ04.Checked = mFichaMedica.Ficha_FactRieQ041
      Ficha_FactRieQ05.Checked = mFichaMedica.Ficha_FactRieQ051
      Ficha_FactRieQ06.Checked = mFichaMedica.Ficha_FactRieQ061
      Ficha_FactRieQ07.Checked = mFichaMedica.Ficha_FactRieQ071
      Ficha_FactRieQ08.Checked = mFichaMedica.Ficha_FactRieQ081
      Ficha_FactRieQ09.Checked = mFichaMedica.Ficha_FactRieQ091

      Ficha_FactRieB01.Checked = mFichaMedica.Ficha_FactRieB011
      Ficha_FactRieB02.Checked = mFichaMedica.Ficha_FactRieB021
      Ficha_FactRieB03.Checked = mFichaMedica.Ficha_FactRieB031
      Ficha_FactRieB04.Checked = mFichaMedica.Ficha_FactRieB041
      Ficha_FactRieB05.Checked = mFichaMedica.Ficha_FactRieB051
      Ficha_FactRieB06.Checked = mFichaMedica.Ficha_FactRieB061
      Ficha_FactRieB07.Checked = mFichaMedica.Ficha_FactRieB071

      Ficha_FactRieE01.Checked = mFichaMedica.Ficha_FactRieE011
      Ficha_FactRieE02.Checked = mFichaMedica.Ficha_FactRieE021
      Ficha_FactRieE03.Checked = mFichaMedica.Ficha_FactRieE031
      Ficha_FactRieE04.Checked = mFichaMedica.Ficha_FactRieE041
      Ficha_FactRieE05.Checked = mFichaMedica.Ficha_FactRieE051

      Ficha_FactRieP01.Checked = mFichaMedica.Ficha_FactRieP011
      Ficha_FactRieP02.Checked = mFichaMedica.Ficha_FactRieP021
      Ficha_FactRieP03.Checked = mFichaMedica.Ficha_FactRieP031
      Ficha_FactRieP04.Checked = mFichaMedica.Ficha_FactRieP041
      Ficha_FactRieP05.Checked = mFichaMedica.Ficha_FactRieP051
      Ficha_FactRieP06.Checked = mFichaMedica.Ficha_FactRieP061
      Ficha_FactRieP07.Checked = mFichaMedica.Ficha_FactRieP071
      Ficha_FactRieP08.Checked = mFichaMedica.Ficha_FactRieP081
      Ficha_FactRieP09.Checked = mFichaMedica.Ficha_FactRieP091
      Ficha_FactRieP10.Checked = mFichaMedica.Ficha_FactRieP101
      Ficha_FactRieP11.Checked = mFichaMedica.Ficha_FactRieP111
      Ficha_FactRieP12.Checked = mFichaMedica.Ficha_FactRieP121
      Ficha_FactRieP13.Checked = mFichaMedica.Ficha_FactRieP131

      Ficha_FactRieMedPrev.Text = mFichaMedica.Ficha_FactRieMedPrev1
    ElseIf mNumeral = 2 Then
      Ficha_FactRieArea.Text = mFichaMedica.Ficha_FactRieArea2
      Ficha_FactRieActividad.Text = mFichaMedica.Ficha_FactRieActividad2

      Ficha_FactRieF01.Checked = mFichaMedica.Ficha_FactRieF012
      Ficha_FactRieF02.Checked = mFichaMedica.Ficha_FactRieF022
      Ficha_FactRieF03.Checked = mFichaMedica.Ficha_FactRieF032
      Ficha_FactRieF04.Checked = mFichaMedica.Ficha_FactRieF042
      Ficha_FactRieF05.Checked = mFichaMedica.Ficha_FactRieF052
      Ficha_FactRieF06.Checked = mFichaMedica.Ficha_FactRieF062
      Ficha_FactRieF07.Checked = mFichaMedica.Ficha_FactRieF072
      Ficha_FactRieF08.Checked = mFichaMedica.Ficha_FactRieF082
      Ficha_FactRieF09.Checked = mFichaMedica.Ficha_FactRieF092
      Ficha_FactRieF10.Checked = mFichaMedica.Ficha_FactRieF102

      Ficha_FactRieM01.Checked = mFichaMedica.Ficha_FactRieM012
      Ficha_FactRieM02.Checked = mFichaMedica.Ficha_FactRieM022
      Ficha_FactRieM03.Checked = mFichaMedica.Ficha_FactRieM032
      Ficha_FactRieM04.Checked = mFichaMedica.Ficha_FactRieM042
      Ficha_FactRieM05.Checked = mFichaMedica.Ficha_FactRieM052
      Ficha_FactRieM06.Checked = mFichaMedica.Ficha_FactRieM062
      Ficha_FactRieM07.Checked = mFichaMedica.Ficha_FactRieM072
      Ficha_FactRieM08.Checked = mFichaMedica.Ficha_FactRieM082
      Ficha_FactRieM09.Checked = mFichaMedica.Ficha_FactRieM092
      Ficha_FactRieM10.Checked = mFichaMedica.Ficha_FactRieM102
      Ficha_FactRieM11.Checked = mFichaMedica.Ficha_FactRieM112
      Ficha_FactRieM12.Checked = mFichaMedica.Ficha_FactRieM122
      Ficha_FactRieM13.Checked = mFichaMedica.Ficha_FactRieM132
      Ficha_FactRieM14.Checked = mFichaMedica.Ficha_FactRieM142
      Ficha_FactRieM15.Checked = mFichaMedica.Ficha_FactRieM152

      Ficha_FactRieQ01.Checked = mFichaMedica.Ficha_FactRieQ012
      Ficha_FactRieQ02.Checked = mFichaMedica.Ficha_FactRieQ022
      Ficha_FactRieQ03.Checked = mFichaMedica.Ficha_FactRieQ032
      Ficha_FactRieQ04.Checked = mFichaMedica.Ficha_FactRieQ042
      Ficha_FactRieQ05.Checked = mFichaMedica.Ficha_FactRieQ052
      Ficha_FactRieQ06.Checked = mFichaMedica.Ficha_FactRieQ062
      Ficha_FactRieQ07.Checked = mFichaMedica.Ficha_FactRieQ072
      Ficha_FactRieQ08.Checked = mFichaMedica.Ficha_FactRieQ082
      Ficha_FactRieQ09.Checked = mFichaMedica.Ficha_FactRieQ092

      Ficha_FactRieB01.Checked = mFichaMedica.Ficha_FactRieB012
      Ficha_FactRieB02.Checked = mFichaMedica.Ficha_FactRieB022
      Ficha_FactRieB03.Checked = mFichaMedica.Ficha_FactRieB032
      Ficha_FactRieB04.Checked = mFichaMedica.Ficha_FactRieB042
      Ficha_FactRieB05.Checked = mFichaMedica.Ficha_FactRieB052
      Ficha_FactRieB06.Checked = mFichaMedica.Ficha_FactRieB062
      Ficha_FactRieB07.Checked = mFichaMedica.Ficha_FactRieB072

      Ficha_FactRieE01.Checked = mFichaMedica.Ficha_FactRieE012
      Ficha_FactRieE02.Checked = mFichaMedica.Ficha_FactRieE022
      Ficha_FactRieE03.Checked = mFichaMedica.Ficha_FactRieE032
      Ficha_FactRieE04.Checked = mFichaMedica.Ficha_FactRieE042
      Ficha_FactRieE05.Checked = mFichaMedica.Ficha_FactRieE052

      Ficha_FactRieP01.Checked = mFichaMedica.Ficha_FactRieP012
      Ficha_FactRieP02.Checked = mFichaMedica.Ficha_FactRieP022
      Ficha_FactRieP03.Checked = mFichaMedica.Ficha_FactRieP032
      Ficha_FactRieP04.Checked = mFichaMedica.Ficha_FactRieP042
      Ficha_FactRieP05.Checked = mFichaMedica.Ficha_FactRieP052
      Ficha_FactRieP06.Checked = mFichaMedica.Ficha_FactRieP062
      Ficha_FactRieP07.Checked = mFichaMedica.Ficha_FactRieP072
      Ficha_FactRieP08.Checked = mFichaMedica.Ficha_FactRieP082
      Ficha_FactRieP09.Checked = mFichaMedica.Ficha_FactRieP092
      Ficha_FactRieP10.Checked = mFichaMedica.Ficha_FactRieP102
      Ficha_FactRieP11.Checked = mFichaMedica.Ficha_FactRieP112
      Ficha_FactRieP12.Checked = mFichaMedica.Ficha_FactRieP122
      Ficha_FactRieP13.Checked = mFichaMedica.Ficha_FactRieP132

      Ficha_FactRieMedPrev.Text = mFichaMedica.Ficha_FactRieMedPrev2
    ElseIf mNumeral = 3 Then
      Ficha_FactRieArea.Text = mFichaMedica.Ficha_FactRieArea3
      Ficha_FactRieActividad.Text = mFichaMedica.Ficha_FactRieActividad3

      Ficha_FactRieF01.Checked = mFichaMedica.Ficha_FactRieF013
      Ficha_FactRieF02.Checked = mFichaMedica.Ficha_FactRieF023
      Ficha_FactRieF03.Checked = mFichaMedica.Ficha_FactRieF033
      Ficha_FactRieF04.Checked = mFichaMedica.Ficha_FactRieF043
      Ficha_FactRieF05.Checked = mFichaMedica.Ficha_FactRieF053
      Ficha_FactRieF06.Checked = mFichaMedica.Ficha_FactRieF063
      Ficha_FactRieF07.Checked = mFichaMedica.Ficha_FactRieF073
      Ficha_FactRieF08.Checked = mFichaMedica.Ficha_FactRieF083
      Ficha_FactRieF09.Checked = mFichaMedica.Ficha_FactRieF093
      Ficha_FactRieF10.Checked = mFichaMedica.Ficha_FactRieF103

      Ficha_FactRieM01.Checked = mFichaMedica.Ficha_FactRieM013
      Ficha_FactRieM02.Checked = mFichaMedica.Ficha_FactRieM023
      Ficha_FactRieM03.Checked = mFichaMedica.Ficha_FactRieM033
      Ficha_FactRieM04.Checked = mFichaMedica.Ficha_FactRieM043
      Ficha_FactRieM05.Checked = mFichaMedica.Ficha_FactRieM053
      Ficha_FactRieM06.Checked = mFichaMedica.Ficha_FactRieM063
      Ficha_FactRieM07.Checked = mFichaMedica.Ficha_FactRieM073
      Ficha_FactRieM08.Checked = mFichaMedica.Ficha_FactRieM083
      Ficha_FactRieM09.Checked = mFichaMedica.Ficha_FactRieM093
      Ficha_FactRieM10.Checked = mFichaMedica.Ficha_FactRieM103
      Ficha_FactRieM11.Checked = mFichaMedica.Ficha_FactRieM113
      Ficha_FactRieM12.Checked = mFichaMedica.Ficha_FactRieM123
      Ficha_FactRieM13.Checked = mFichaMedica.Ficha_FactRieM133
      Ficha_FactRieM14.Checked = mFichaMedica.Ficha_FactRieM143
      Ficha_FactRieM15.Checked = mFichaMedica.Ficha_FactRieM153

      Ficha_FactRieQ01.Checked = mFichaMedica.Ficha_FactRieQ013
      Ficha_FactRieQ02.Checked = mFichaMedica.Ficha_FactRieQ023
      Ficha_FactRieQ03.Checked = mFichaMedica.Ficha_FactRieQ033
      Ficha_FactRieQ04.Checked = mFichaMedica.Ficha_FactRieQ043
      Ficha_FactRieQ05.Checked = mFichaMedica.Ficha_FactRieQ053
      Ficha_FactRieQ06.Checked = mFichaMedica.Ficha_FactRieQ063
      Ficha_FactRieQ07.Checked = mFichaMedica.Ficha_FactRieQ073
      Ficha_FactRieQ08.Checked = mFichaMedica.Ficha_FactRieQ083
      Ficha_FactRieQ09.Checked = mFichaMedica.Ficha_FactRieQ093

      Ficha_FactRieB01.Checked = mFichaMedica.Ficha_FactRieB013
      Ficha_FactRieB02.Checked = mFichaMedica.Ficha_FactRieB023
      Ficha_FactRieB03.Checked = mFichaMedica.Ficha_FactRieB033
      Ficha_FactRieB04.Checked = mFichaMedica.Ficha_FactRieB043
      Ficha_FactRieB05.Checked = mFichaMedica.Ficha_FactRieB053
      Ficha_FactRieB06.Checked = mFichaMedica.Ficha_FactRieB063
      Ficha_FactRieB07.Checked = mFichaMedica.Ficha_FactRieB073

      Ficha_FactRieE01.Checked = mFichaMedica.Ficha_FactRieE013
      Ficha_FactRieE02.Checked = mFichaMedica.Ficha_FactRieE023
      Ficha_FactRieE03.Checked = mFichaMedica.Ficha_FactRieE033
      Ficha_FactRieE04.Checked = mFichaMedica.Ficha_FactRieE043
      Ficha_FactRieE05.Checked = mFichaMedica.Ficha_FactRieE053

      Ficha_FactRieP01.Checked = mFichaMedica.Ficha_FactRieP013
      Ficha_FactRieP02.Checked = mFichaMedica.Ficha_FactRieP023
      Ficha_FactRieP03.Checked = mFichaMedica.Ficha_FactRieP033
      Ficha_FactRieP04.Checked = mFichaMedica.Ficha_FactRieP043
      Ficha_FactRieP05.Checked = mFichaMedica.Ficha_FactRieP053
      Ficha_FactRieP06.Checked = mFichaMedica.Ficha_FactRieP063
      Ficha_FactRieP07.Checked = mFichaMedica.Ficha_FactRieP073
      Ficha_FactRieP08.Checked = mFichaMedica.Ficha_FactRieP083
      Ficha_FactRieP09.Checked = mFichaMedica.Ficha_FactRieP093
      Ficha_FactRieP10.Checked = mFichaMedica.Ficha_FactRieP103
      Ficha_FactRieP11.Checked = mFichaMedica.Ficha_FactRieP113
      Ficha_FactRieP12.Checked = mFichaMedica.Ficha_FactRieP123
      Ficha_FactRieP13.Checked = mFichaMedica.Ficha_FactRieP133

      Ficha_FactRieMedPrev.Text = mFichaMedica.Ficha_FactRieMedPrev3
    ElseIf mNumeral = 4 Then
      Ficha_FactRieArea.Text = mFichaMedica.Ficha_FactRieArea4
      Ficha_FactRieActividad.Text = mFichaMedica.Ficha_FactRieActividad4

      Ficha_FactRieF01.Checked = mFichaMedica.Ficha_FactRieF014
      Ficha_FactRieF02.Checked = mFichaMedica.Ficha_FactRieF024
      Ficha_FactRieF03.Checked = mFichaMedica.Ficha_FactRieF034
      Ficha_FactRieF04.Checked = mFichaMedica.Ficha_FactRieF044
      Ficha_FactRieF05.Checked = mFichaMedica.Ficha_FactRieF054
      Ficha_FactRieF06.Checked = mFichaMedica.Ficha_FactRieF064
      Ficha_FactRieF07.Checked = mFichaMedica.Ficha_FactRieF074
      Ficha_FactRieF08.Checked = mFichaMedica.Ficha_FactRieF084
      Ficha_FactRieF09.Checked = mFichaMedica.Ficha_FactRieF094
      Ficha_FactRieF10.Checked = mFichaMedica.Ficha_FactRieF104

      Ficha_FactRieM01.Checked = mFichaMedica.Ficha_FactRieM014
      Ficha_FactRieM02.Checked = mFichaMedica.Ficha_FactRieM024
      Ficha_FactRieM03.Checked = mFichaMedica.Ficha_FactRieM034
      Ficha_FactRieM04.Checked = mFichaMedica.Ficha_FactRieM044
      Ficha_FactRieM05.Checked = mFichaMedica.Ficha_FactRieM054
      Ficha_FactRieM06.Checked = mFichaMedica.Ficha_FactRieM064
      Ficha_FactRieM07.Checked = mFichaMedica.Ficha_FactRieM074
      Ficha_FactRieM08.Checked = mFichaMedica.Ficha_FactRieM084
      Ficha_FactRieM09.Checked = mFichaMedica.Ficha_FactRieM094
      Ficha_FactRieM10.Checked = mFichaMedica.Ficha_FactRieM104
      Ficha_FactRieM11.Checked = mFichaMedica.Ficha_FactRieM114
      Ficha_FactRieM12.Checked = mFichaMedica.Ficha_FactRieM124
      Ficha_FactRieM13.Checked = mFichaMedica.Ficha_FactRieM134
      Ficha_FactRieM14.Checked = mFichaMedica.Ficha_FactRieM144
      Ficha_FactRieM15.Checked = mFichaMedica.Ficha_FactRieM154

      Ficha_FactRieQ01.Checked = mFichaMedica.Ficha_FactRieQ014
      Ficha_FactRieQ02.Checked = mFichaMedica.Ficha_FactRieQ024
      Ficha_FactRieQ03.Checked = mFichaMedica.Ficha_FactRieQ034
      Ficha_FactRieQ04.Checked = mFichaMedica.Ficha_FactRieQ044
      Ficha_FactRieQ05.Checked = mFichaMedica.Ficha_FactRieQ054
      Ficha_FactRieQ06.Checked = mFichaMedica.Ficha_FactRieQ064
      Ficha_FactRieQ07.Checked = mFichaMedica.Ficha_FactRieQ074
      Ficha_FactRieQ08.Checked = mFichaMedica.Ficha_FactRieQ084
      Ficha_FactRieQ09.Checked = mFichaMedica.Ficha_FactRieQ094

      Ficha_FactRieB01.Checked = mFichaMedica.Ficha_FactRieB014
      Ficha_FactRieB02.Checked = mFichaMedica.Ficha_FactRieB024
      Ficha_FactRieB03.Checked = mFichaMedica.Ficha_FactRieB034
      Ficha_FactRieB04.Checked = mFichaMedica.Ficha_FactRieB044
      Ficha_FactRieB05.Checked = mFichaMedica.Ficha_FactRieB054
      Ficha_FactRieB06.Checked = mFichaMedica.Ficha_FactRieB064
      Ficha_FactRieB07.Checked = mFichaMedica.Ficha_FactRieB074

      Ficha_FactRieE01.Checked = mFichaMedica.Ficha_FactRieE014
      Ficha_FactRieE02.Checked = mFichaMedica.Ficha_FactRieE024
      Ficha_FactRieE03.Checked = mFichaMedica.Ficha_FactRieE034
      Ficha_FactRieE04.Checked = mFichaMedica.Ficha_FactRieE044
      Ficha_FactRieE05.Checked = mFichaMedica.Ficha_FactRieE054

      Ficha_FactRieP01.Checked = mFichaMedica.Ficha_FactRieP014
      Ficha_FactRieP02.Checked = mFichaMedica.Ficha_FactRieP024
      Ficha_FactRieP03.Checked = mFichaMedica.Ficha_FactRieP034
      Ficha_FactRieP04.Checked = mFichaMedica.Ficha_FactRieP044
      Ficha_FactRieP05.Checked = mFichaMedica.Ficha_FactRieP054
      Ficha_FactRieP06.Checked = mFichaMedica.Ficha_FactRieP064
      Ficha_FactRieP07.Checked = mFichaMedica.Ficha_FactRieP074
      Ficha_FactRieP08.Checked = mFichaMedica.Ficha_FactRieP084
      Ficha_FactRieP09.Checked = mFichaMedica.Ficha_FactRieP094
      Ficha_FactRieP10.Checked = mFichaMedica.Ficha_FactRieP104
      Ficha_FactRieP11.Checked = mFichaMedica.Ficha_FactRieP114
      Ficha_FactRieP12.Checked = mFichaMedica.Ficha_FactRieP124
      Ficha_FactRieP13.Checked = mFichaMedica.Ficha_FactRieP134

      Ficha_FactRieMedPrev.Text = mFichaMedica.Ficha_FactRieMedPrev4
    End If
  End Sub

  Public Sub Mapear()
    If mNumeral = 1 Then
      mFichaMedica.Ficha_FactRieArea1 = Ficha_FactRieArea.Text
      mFichaMedica.Ficha_FactRieActividad1 = Ficha_FactRieActividad.Text

      mFichaMedica.Ficha_FactRieF011 = Ficha_FactRieF01.Checked
      mFichaMedica.Ficha_FactRieF021 = Ficha_FactRieF02.Checked
      mFichaMedica.Ficha_FactRieF031 = Ficha_FactRieF03.Checked
      mFichaMedica.Ficha_FactRieF041 = Ficha_FactRieF04.Checked
      mFichaMedica.Ficha_FactRieF051 = Ficha_FactRieF05.Checked
      mFichaMedica.Ficha_FactRieF061 = Ficha_FactRieF06.Checked
      mFichaMedica.Ficha_FactRieF071 = Ficha_FactRieF07.Checked
      mFichaMedica.Ficha_FactRieF081 = Ficha_FactRieF08.Checked
      mFichaMedica.Ficha_FactRieF091 = Ficha_FactRieF09.Checked
      mFichaMedica.Ficha_FactRieF101 = Ficha_FactRieF10.Checked

      mFichaMedica.Ficha_FactRieM011 = Ficha_FactRieM01.Checked
      mFichaMedica.Ficha_FactRieM021 = Ficha_FactRieM02.Checked
      mFichaMedica.Ficha_FactRieM031 = Ficha_FactRieM03.Checked
      mFichaMedica.Ficha_FactRieM041 = Ficha_FactRieM04.Checked
      mFichaMedica.Ficha_FactRieM051 = Ficha_FactRieM05.Checked
      mFichaMedica.Ficha_FactRieM061 = Ficha_FactRieM06.Checked
      mFichaMedica.Ficha_FactRieM071 = Ficha_FactRieM07.Checked
      mFichaMedica.Ficha_FactRieM081 = Ficha_FactRieM08.Checked
      mFichaMedica.Ficha_FactRieM091 = Ficha_FactRieM09.Checked
      mFichaMedica.Ficha_FactRieM101 = Ficha_FactRieM10.Checked
      mFichaMedica.Ficha_FactRieM111 = Ficha_FactRieM11.Checked
      mFichaMedica.Ficha_FactRieM121 = Ficha_FactRieM12.Checked
      mFichaMedica.Ficha_FactRieM131 = Ficha_FactRieM13.Checked
      mFichaMedica.Ficha_FactRieM141 = Ficha_FactRieM14.Checked
      mFichaMedica.Ficha_FactRieM151 = Ficha_FactRieM15.Checked

      mFichaMedica.Ficha_FactRieQ011 = Ficha_FactRieQ01.Checked
      mFichaMedica.Ficha_FactRieQ021 = Ficha_FactRieQ02.Checked
      mFichaMedica.Ficha_FactRieQ031 = Ficha_FactRieQ03.Checked
      mFichaMedica.Ficha_FactRieQ041 = Ficha_FactRieQ04.Checked
      mFichaMedica.Ficha_FactRieQ051 = Ficha_FactRieQ05.Checked
      mFichaMedica.Ficha_FactRieQ061 = Ficha_FactRieQ06.Checked
      mFichaMedica.Ficha_FactRieQ071 = Ficha_FactRieQ07.Checked
      mFichaMedica.Ficha_FactRieQ081 = Ficha_FactRieQ08.Checked
      mFichaMedica.Ficha_FactRieQ091 = Ficha_FactRieQ09.Checked

      mFichaMedica.Ficha_FactRieB011 = Ficha_FactRieB01.Checked
      mFichaMedica.Ficha_FactRieB021 = Ficha_FactRieB02.Checked
      mFichaMedica.Ficha_FactRieB031 = Ficha_FactRieB03.Checked
      mFichaMedica.Ficha_FactRieB041 = Ficha_FactRieB04.Checked
      mFichaMedica.Ficha_FactRieB051 = Ficha_FactRieB05.Checked
      mFichaMedica.Ficha_FactRieB061 = Ficha_FactRieB06.Checked
      mFichaMedica.Ficha_FactRieB071 = Ficha_FactRieB07.Checked

      mFichaMedica.Ficha_FactRieE011 = Ficha_FactRieE01.Checked
      mFichaMedica.Ficha_FactRieE021 = Ficha_FactRieE02.Checked
      mFichaMedica.Ficha_FactRieE031 = Ficha_FactRieE03.Checked
      mFichaMedica.Ficha_FactRieE041 = Ficha_FactRieE04.Checked
      mFichaMedica.Ficha_FactRieE051 = Ficha_FactRieE05.Checked

      mFichaMedica.Ficha_FactRieP011 = Ficha_FactRieP01.Checked
      mFichaMedica.Ficha_FactRieP021 = Ficha_FactRieP02.Checked
      mFichaMedica.Ficha_FactRieP031 = Ficha_FactRieP03.Checked
      mFichaMedica.Ficha_FactRieP041 = Ficha_FactRieP04.Checked
      mFichaMedica.Ficha_FactRieP051 = Ficha_FactRieP05.Checked
      mFichaMedica.Ficha_FactRieP061 = Ficha_FactRieP06.Checked
      mFichaMedica.Ficha_FactRieP071 = Ficha_FactRieP07.Checked
      mFichaMedica.Ficha_FactRieP081 = Ficha_FactRieP08.Checked
      mFichaMedica.Ficha_FactRieP091 = Ficha_FactRieP09.Checked
      mFichaMedica.Ficha_FactRieP101 = Ficha_FactRieP10.Checked
      mFichaMedica.Ficha_FactRieP111 = Ficha_FactRieP11.Checked
      mFichaMedica.Ficha_FactRieP121 = Ficha_FactRieP12.Checked
      mFichaMedica.Ficha_FactRieP131 = Ficha_FactRieP13.Checked

      mFichaMedica.Ficha_FactRieMedPrev1 = Ficha_FactRieMedPrev.Text
    ElseIf mNumeral = 2 Then
      mFichaMedica.Ficha_FactRieArea2 = Ficha_FactRieArea.Text
      mFichaMedica.Ficha_FactRieActividad2 = Ficha_FactRieActividad.Text

      mFichaMedica.Ficha_FactRieF012 = Ficha_FactRieF01.Checked
      mFichaMedica.Ficha_FactRieF022 = Ficha_FactRieF02.Checked
      mFichaMedica.Ficha_FactRieF032 = Ficha_FactRieF03.Checked
      mFichaMedica.Ficha_FactRieF042 = Ficha_FactRieF04.Checked
      mFichaMedica.Ficha_FactRieF052 = Ficha_FactRieF05.Checked
      mFichaMedica.Ficha_FactRieF062 = Ficha_FactRieF06.Checked
      mFichaMedica.Ficha_FactRieF072 = Ficha_FactRieF07.Checked
      mFichaMedica.Ficha_FactRieF082 = Ficha_FactRieF08.Checked
      mFichaMedica.Ficha_FactRieF092 = Ficha_FactRieF09.Checked
      mFichaMedica.Ficha_FactRieF102 = Ficha_FactRieF10.Checked

      mFichaMedica.Ficha_FactRieM012 = Ficha_FactRieM01.Checked
      mFichaMedica.Ficha_FactRieM022 = Ficha_FactRieM02.Checked
      mFichaMedica.Ficha_FactRieM032 = Ficha_FactRieM03.Checked
      mFichaMedica.Ficha_FactRieM042 = Ficha_FactRieM04.Checked
      mFichaMedica.Ficha_FactRieM052 = Ficha_FactRieM05.Checked
      mFichaMedica.Ficha_FactRieM062 = Ficha_FactRieM06.Checked
      mFichaMedica.Ficha_FactRieM072 = Ficha_FactRieM07.Checked
      mFichaMedica.Ficha_FactRieM082 = Ficha_FactRieM08.Checked
      mFichaMedica.Ficha_FactRieM092 = Ficha_FactRieM09.Checked
      mFichaMedica.Ficha_FactRieM102 = Ficha_FactRieM10.Checked
      mFichaMedica.Ficha_FactRieM112 = Ficha_FactRieM11.Checked
      mFichaMedica.Ficha_FactRieM122 = Ficha_FactRieM12.Checked
      mFichaMedica.Ficha_FactRieM132 = Ficha_FactRieM13.Checked
      mFichaMedica.Ficha_FactRieM142 = Ficha_FactRieM14.Checked
      mFichaMedica.Ficha_FactRieM152 = Ficha_FactRieM15.Checked

      mFichaMedica.Ficha_FactRieQ012 = Ficha_FactRieQ01.Checked
      mFichaMedica.Ficha_FactRieQ022 = Ficha_FactRieQ02.Checked
      mFichaMedica.Ficha_FactRieQ032 = Ficha_FactRieQ03.Checked
      mFichaMedica.Ficha_FactRieQ042 = Ficha_FactRieQ04.Checked
      mFichaMedica.Ficha_FactRieQ052 = Ficha_FactRieQ05.Checked
      mFichaMedica.Ficha_FactRieQ062 = Ficha_FactRieQ06.Checked
      mFichaMedica.Ficha_FactRieQ072 = Ficha_FactRieQ07.Checked
      mFichaMedica.Ficha_FactRieQ082 = Ficha_FactRieQ08.Checked
      mFichaMedica.Ficha_FactRieQ092 = Ficha_FactRieQ09.Checked

      mFichaMedica.Ficha_FactRieB012 = Ficha_FactRieB01.Checked
      mFichaMedica.Ficha_FactRieB022 = Ficha_FactRieB02.Checked
      mFichaMedica.Ficha_FactRieB032 = Ficha_FactRieB03.Checked
      mFichaMedica.Ficha_FactRieB042 = Ficha_FactRieB04.Checked
      mFichaMedica.Ficha_FactRieB052 = Ficha_FactRieB05.Checked
      mFichaMedica.Ficha_FactRieB062 = Ficha_FactRieB06.Checked
      mFichaMedica.Ficha_FactRieB072 = Ficha_FactRieB07.Checked

      mFichaMedica.Ficha_FactRieE012 = Ficha_FactRieE01.Checked
      mFichaMedica.Ficha_FactRieE022 = Ficha_FactRieE02.Checked
      mFichaMedica.Ficha_FactRieE032 = Ficha_FactRieE03.Checked
      mFichaMedica.Ficha_FactRieE042 = Ficha_FactRieE04.Checked
      mFichaMedica.Ficha_FactRieE052 = Ficha_FactRieE05.Checked

      mFichaMedica.Ficha_FactRieP012 = Ficha_FactRieP01.Checked
      mFichaMedica.Ficha_FactRieP022 = Ficha_FactRieP02.Checked
      mFichaMedica.Ficha_FactRieP032 = Ficha_FactRieP03.Checked
      mFichaMedica.Ficha_FactRieP042 = Ficha_FactRieP04.Checked
      mFichaMedica.Ficha_FactRieP052 = Ficha_FactRieP05.Checked
      mFichaMedica.Ficha_FactRieP062 = Ficha_FactRieP06.Checked
      mFichaMedica.Ficha_FactRieP072 = Ficha_FactRieP07.Checked
      mFichaMedica.Ficha_FactRieP082 = Ficha_FactRieP08.Checked
      mFichaMedica.Ficha_FactRieP092 = Ficha_FactRieP09.Checked
      mFichaMedica.Ficha_FactRieP102 = Ficha_FactRieP10.Checked
      mFichaMedica.Ficha_FactRieP112 = Ficha_FactRieP11.Checked
      mFichaMedica.Ficha_FactRieP122 = Ficha_FactRieP12.Checked
      mFichaMedica.Ficha_FactRieP132 = Ficha_FactRieP13.Checked

      mFichaMedica.Ficha_FactRieMedPrev2 = Ficha_FactRieMedPrev.Text
    ElseIf mNumeral = 3 Then
      mFichaMedica.Ficha_FactRieArea3 = Ficha_FactRieArea.Text
      mFichaMedica.Ficha_FactRieActividad3 = Ficha_FactRieActividad.Text

      mFichaMedica.Ficha_FactRieF013 = Ficha_FactRieF01.Checked
      mFichaMedica.Ficha_FactRieF023 = Ficha_FactRieF02.Checked
      mFichaMedica.Ficha_FactRieF033 = Ficha_FactRieF03.Checked
      mFichaMedica.Ficha_FactRieF043 = Ficha_FactRieF04.Checked
      mFichaMedica.Ficha_FactRieF053 = Ficha_FactRieF05.Checked
      mFichaMedica.Ficha_FactRieF063 = Ficha_FactRieF06.Checked
      mFichaMedica.Ficha_FactRieF073 = Ficha_FactRieF07.Checked
      mFichaMedica.Ficha_FactRieF083 = Ficha_FactRieF08.Checked
      mFichaMedica.Ficha_FactRieF093 = Ficha_FactRieF09.Checked
      mFichaMedica.Ficha_FactRieF103 = Ficha_FactRieF10.Checked

      mFichaMedica.Ficha_FactRieM013 = Ficha_FactRieM01.Checked
      mFichaMedica.Ficha_FactRieM023 = Ficha_FactRieM02.Checked
      mFichaMedica.Ficha_FactRieM033 = Ficha_FactRieM03.Checked
      mFichaMedica.Ficha_FactRieM043 = Ficha_FactRieM04.Checked
      mFichaMedica.Ficha_FactRieM053 = Ficha_FactRieM05.Checked
      mFichaMedica.Ficha_FactRieM063 = Ficha_FactRieM06.Checked
      mFichaMedica.Ficha_FactRieM073 = Ficha_FactRieM07.Checked
      mFichaMedica.Ficha_FactRieM083 = Ficha_FactRieM08.Checked
      mFichaMedica.Ficha_FactRieM093 = Ficha_FactRieM09.Checked
      mFichaMedica.Ficha_FactRieM103 = Ficha_FactRieM10.Checked
      mFichaMedica.Ficha_FactRieM113 = Ficha_FactRieM11.Checked
      mFichaMedica.Ficha_FactRieM123 = Ficha_FactRieM12.Checked
      mFichaMedica.Ficha_FactRieM133 = Ficha_FactRieM13.Checked
      mFichaMedica.Ficha_FactRieM143 = Ficha_FactRieM14.Checked
      mFichaMedica.Ficha_FactRieM153 = Ficha_FactRieM15.Checked

      mFichaMedica.Ficha_FactRieQ013 = Ficha_FactRieQ01.Checked
      mFichaMedica.Ficha_FactRieQ023 = Ficha_FactRieQ02.Checked
      mFichaMedica.Ficha_FactRieQ033 = Ficha_FactRieQ03.Checked
      mFichaMedica.Ficha_FactRieQ043 = Ficha_FactRieQ04.Checked
      mFichaMedica.Ficha_FactRieQ053 = Ficha_FactRieQ05.Checked
      mFichaMedica.Ficha_FactRieQ063 = Ficha_FactRieQ06.Checked
      mFichaMedica.Ficha_FactRieQ073 = Ficha_FactRieQ07.Checked
      mFichaMedica.Ficha_FactRieQ083 = Ficha_FactRieQ08.Checked
      mFichaMedica.Ficha_FactRieQ093 = Ficha_FactRieQ09.Checked

      mFichaMedica.Ficha_FactRieB013 = Ficha_FactRieB01.Checked
      mFichaMedica.Ficha_FactRieB023 = Ficha_FactRieB02.Checked
      mFichaMedica.Ficha_FactRieB033 = Ficha_FactRieB03.Checked
      mFichaMedica.Ficha_FactRieB043 = Ficha_FactRieB04.Checked
      mFichaMedica.Ficha_FactRieB053 = Ficha_FactRieB05.Checked
      mFichaMedica.Ficha_FactRieB063 = Ficha_FactRieB06.Checked
      mFichaMedica.Ficha_FactRieB073 = Ficha_FactRieB07.Checked

      mFichaMedica.Ficha_FactRieE013 = Ficha_FactRieE01.Checked
      mFichaMedica.Ficha_FactRieE023 = Ficha_FactRieE02.Checked
      mFichaMedica.Ficha_FactRieE033 = Ficha_FactRieE03.Checked
      mFichaMedica.Ficha_FactRieE043 = Ficha_FactRieE04.Checked
      mFichaMedica.Ficha_FactRieE053 = Ficha_FactRieE05.Checked

      mFichaMedica.Ficha_FactRieP013 = Ficha_FactRieP01.Checked
      mFichaMedica.Ficha_FactRieP023 = Ficha_FactRieP02.Checked
      mFichaMedica.Ficha_FactRieP033 = Ficha_FactRieP03.Checked
      mFichaMedica.Ficha_FactRieP043 = Ficha_FactRieP04.Checked
      mFichaMedica.Ficha_FactRieP053 = Ficha_FactRieP05.Checked
      mFichaMedica.Ficha_FactRieP063 = Ficha_FactRieP06.Checked
      mFichaMedica.Ficha_FactRieP073 = Ficha_FactRieP07.Checked
      mFichaMedica.Ficha_FactRieP083 = Ficha_FactRieP08.Checked
      mFichaMedica.Ficha_FactRieP093 = Ficha_FactRieP09.Checked
      mFichaMedica.Ficha_FactRieP103 = Ficha_FactRieP10.Checked
      mFichaMedica.Ficha_FactRieP113 = Ficha_FactRieP11.Checked
      mFichaMedica.Ficha_FactRieP123 = Ficha_FactRieP12.Checked
      mFichaMedica.Ficha_FactRieP133 = Ficha_FactRieP13.Checked

      mFichaMedica.Ficha_FactRieMedPrev3 = Ficha_FactRieMedPrev.Text
    ElseIf mNumeral = 4 Then
      mFichaMedica.Ficha_FactRieArea4 = Ficha_FactRieArea.Text
      mFichaMedica.Ficha_FactRieActividad4 = Ficha_FactRieActividad.Text

      mFichaMedica.Ficha_FactRieF014 = Ficha_FactRieF01.Checked
      mFichaMedica.Ficha_FactRieF024 = Ficha_FactRieF02.Checked
      mFichaMedica.Ficha_FactRieF034 = Ficha_FactRieF03.Checked
      mFichaMedica.Ficha_FactRieF044 = Ficha_FactRieF04.Checked
      mFichaMedica.Ficha_FactRieF054 = Ficha_FactRieF05.Checked
      mFichaMedica.Ficha_FactRieF064 = Ficha_FactRieF06.Checked
      mFichaMedica.Ficha_FactRieF074 = Ficha_FactRieF07.Checked
      mFichaMedica.Ficha_FactRieF084 = Ficha_FactRieF08.Checked
      mFichaMedica.Ficha_FactRieF094 = Ficha_FactRieF09.Checked
      mFichaMedica.Ficha_FactRieF104 = Ficha_FactRieF10.Checked

      mFichaMedica.Ficha_FactRieM014 = Ficha_FactRieM01.Checked
      mFichaMedica.Ficha_FactRieM024 = Ficha_FactRieM02.Checked
      mFichaMedica.Ficha_FactRieM034 = Ficha_FactRieM03.Checked
      mFichaMedica.Ficha_FactRieM044 = Ficha_FactRieM04.Checked
      mFichaMedica.Ficha_FactRieM054 = Ficha_FactRieM05.Checked
      mFichaMedica.Ficha_FactRieM064 = Ficha_FactRieM06.Checked
      mFichaMedica.Ficha_FactRieM074 = Ficha_FactRieM07.Checked
      mFichaMedica.Ficha_FactRieM084 = Ficha_FactRieM08.Checked
      mFichaMedica.Ficha_FactRieM094 = Ficha_FactRieM09.Checked
      mFichaMedica.Ficha_FactRieM104 = Ficha_FactRieM10.Checked
      mFichaMedica.Ficha_FactRieM114 = Ficha_FactRieM11.Checked
      mFichaMedica.Ficha_FactRieM124 = Ficha_FactRieM12.Checked
      mFichaMedica.Ficha_FactRieM134 = Ficha_FactRieM13.Checked
      mFichaMedica.Ficha_FactRieM144 = Ficha_FactRieM14.Checked
      mFichaMedica.Ficha_FactRieM154 = Ficha_FactRieM15.Checked

      mFichaMedica.Ficha_FactRieQ014 = Ficha_FactRieQ01.Checked
      mFichaMedica.Ficha_FactRieQ024 = Ficha_FactRieQ02.Checked
      mFichaMedica.Ficha_FactRieQ034 = Ficha_FactRieQ03.Checked
      mFichaMedica.Ficha_FactRieQ044 = Ficha_FactRieQ04.Checked
      mFichaMedica.Ficha_FactRieQ054 = Ficha_FactRieQ05.Checked
      mFichaMedica.Ficha_FactRieQ064 = Ficha_FactRieQ06.Checked
      mFichaMedica.Ficha_FactRieQ074 = Ficha_FactRieQ07.Checked
      mFichaMedica.Ficha_FactRieQ084 = Ficha_FactRieQ08.Checked
      mFichaMedica.Ficha_FactRieQ094 = Ficha_FactRieQ09.Checked

      mFichaMedica.Ficha_FactRieB014 = Ficha_FactRieB01.Checked
      mFichaMedica.Ficha_FactRieB024 = Ficha_FactRieB02.Checked
      mFichaMedica.Ficha_FactRieB034 = Ficha_FactRieB03.Checked
      mFichaMedica.Ficha_FactRieB044 = Ficha_FactRieB04.Checked
      mFichaMedica.Ficha_FactRieB054 = Ficha_FactRieB05.Checked
      mFichaMedica.Ficha_FactRieB064 = Ficha_FactRieB06.Checked
      mFichaMedica.Ficha_FactRieB074 = Ficha_FactRieB07.Checked

      mFichaMedica.Ficha_FactRieE014 = Ficha_FactRieE01.Checked
      mFichaMedica.Ficha_FactRieE024 = Ficha_FactRieE02.Checked
      mFichaMedica.Ficha_FactRieE034 = Ficha_FactRieE03.Checked
      mFichaMedica.Ficha_FactRieE044 = Ficha_FactRieE04.Checked
      mFichaMedica.Ficha_FactRieE054 = Ficha_FactRieE05.Checked

      mFichaMedica.Ficha_FactRieP014 = Ficha_FactRieP01.Checked
      mFichaMedica.Ficha_FactRieP024 = Ficha_FactRieP02.Checked
      mFichaMedica.Ficha_FactRieP034 = Ficha_FactRieP03.Checked
      mFichaMedica.Ficha_FactRieP044 = Ficha_FactRieP04.Checked
      mFichaMedica.Ficha_FactRieP054 = Ficha_FactRieP05.Checked
      mFichaMedica.Ficha_FactRieP064 = Ficha_FactRieP06.Checked
      mFichaMedica.Ficha_FactRieP074 = Ficha_FactRieP07.Checked
      mFichaMedica.Ficha_FactRieP084 = Ficha_FactRieP08.Checked
      mFichaMedica.Ficha_FactRieP094 = Ficha_FactRieP09.Checked
      mFichaMedica.Ficha_FactRieP104 = Ficha_FactRieP10.Checked
      mFichaMedica.Ficha_FactRieP114 = Ficha_FactRieP11.Checked
      mFichaMedica.Ficha_FactRieP124 = Ficha_FactRieP12.Checked
      mFichaMedica.Ficha_FactRieP134 = Ficha_FactRieP13.Checked

      mFichaMedica.Ficha_FactRieMedPrev4 = Ficha_FactRieMedPrev.Text
    End If
  End Sub
End Class
