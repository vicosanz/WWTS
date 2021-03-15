Imports Microsoft.Office.Interop

Public Class FichaMedicaExcel
  Public Shared Sub CombinarCorrespondenciaFichaPreocupacionalPag1(ByVal _objeto As FichaMedica, ByVal _direccionarchivo As String)
    If Not My.Computer.FileSystem.FileExists(_direccionarchivo) Then
      MsgBox("No existe la carta modelo para realizar la combinación de correspondencia", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _nombreHoja As String = "Hoja1"

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet =
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      _nombreHoja = excelWorksheet.Name

      excelApp.Visible = False
      With excelWorksheet
        .Columns().ColumnWidth = 80
        .Columns.NumberFormat = "@"
        .Cells(1, 1).value = "EMPRESA"
        .Cells(1, 2).value = "RUC"
        .Cells(1, 3).value = "CIU"
        .Cells(1, 4).value = "CLINICA"
        .Cells(1, 5).value = "CLINICANUM"
        .Cells(1, 6).value = "ARCHIVONUM"
        .Cells(1, 7).value = "APELLIDOPAT"
        .Cells(1, 8).value = "APELLIDOMAT"
        .Cells(1, 9).value = "NOMBRE1"
        .Cells(1, 10).value = "NOMBRE2"
        .Cells(1, 11).value = "SEXO"
        .Cells(1, 12).value = "EDAD"
        .Cells(1, 13).value = "RELIGCAT"
        .Cells(1, 14).value = "RELIGEV"
        .Cells(1, 15).value = "RELIGTEST"
        .Cells(1, 16).value = "RELIGMOR"
        .Cells(1, 17).value = "RELIGOTR"
        .Cells(1, 18).value = "GENLESB"
        .Cells(1, 19).value = "GENGAY"
        .Cells(1, 20).value = "GENBIS"
        .Cells(1, 21).value = "GENHET"
        .Cells(1, 22).value = "GENNN"
        .Cells(1, 23).value = "GENMASC"
        .Cells(1, 24).value = "GENFEM"
        .Cells(1, 25).value = "GENTRANSF"
        .Cells(1, 26).value = "GENTRANSM"
        .Cells(1, 27).value = "DISCAPSI"
        .Cells(1, 28).value = "DISCAPNO"
        .Cells(1, 29).value = "DISCAPTIPO"
        .Cells(1, 30).value = "DISCAPPORC"
        .Cells(1, 31).value = "FECING"
        .Cells(1, 32).value = "PUESTCIU"
        .Cells(1, 33).value = "AREATRAB"
        .Cells(1, 34).value = "ACTIVIDADES"
        .Cells(1, 35).value = "MOTIVCONSUL"
        .Cells(1, 36).value = "ASN"
        .Cells(1, 37).value = "FECMENARQ"
        .Cells(1, 38).value = "CICLOS"
        .Cells(1, 39).value = "FUM"
        .Cells(1, 40).value = "GESTAS"
        .Cells(1, 41).value = "PARTOS"
        .Cells(1, 42).value = "CESAREAS"
        .Cells(1, 43).value = "ABORTOS"
        .Cells(1, 44).value = "HIJVIVOS"
        .Cells(1, 45).value = "HIJMUERTOS"
        .Cells(1, 46).value = "VSASI"
        .Cells(1, 47).value = "VSANO"
        .Cells(1, 48).value = "FEMMPFSI"
        .Cells(1, 49).value = "FEMMPFNO"
        .Cells(1, 50).value = "FEMMPFTIPO"
        .Cells(1, 51).value = "PAPANICSI"
        .Cells(1, 52).value = "PAPANICNO"
        .Cells(1, 53).value = "COLOSCOPSI"
        .Cells(1, 54).value = "COLOSCOPNO"
        .Cells(1, 55).value = "TIEMPOPAPANIC"
        .Cells(1, 56).value = "TIEMPOCOLOSCOP"
        .Cells(1, 57).value = "PAPANICRESULT"
        .Cells(1, 58).value = "COLOSCOPRESULT"
        .Cells(1, 59).value = "ECOMAMARIOSI"
        .Cells(1, 60).value = "ECOMAMARIONO"
        .Cells(1, 61).value = "MAMOGRAFSI"
        .Cells(1, 62).value = "MAMOGRAFNO"
        .Cells(1, 63).value = "ECOMAMARIOTIEMPO"
        .Cells(1, 64).value = "ECOMAMARIORESULT"
        .Cells(1, 65).value = "MAMOGRAFTIEMPO"
        .Cells(1, 66).value = "MAMOGRAFRESULT"
        .Cells(1, 67).value = "ANTIGENPROSTATSI"
        .Cells(1, 68).value = "ANTIGENPROSTATNO"
        .Cells(1, 69).value = "ECOPROSTATISI"
        .Cells(1, 70).value = "ECOPROSTATINO"
        .Cells(1, 71).value = "ANTIGENPROSTATTIEMPO"
        .Cells(1, 72).value = "ECOPROSTATTIEMPO"
        .Cells(1, 73).value = "ANTIGENPROSTATRESULTADO"
        .Cells(1, 74).value = "ECOPROSTATRESULTADO"
        .Cells(1, 75).value = "MASMPFSI"
        .Cells(1, 76).value = "MASMPFNO"
        .Cells(1, 77).value = "MASMPFTIPO"
        .Cells(1, 78).value = "MASMPFTIPO2"
        .Cells(1, 79).value = "HIJVIVOS1"
        .Cells(1, 80).value = "HIJMUERTOS1"
        .Cells(1, 81).value = "CONSTABACOSI"
        .Cells(1, 82).value = "CONSTABACONO"
        .Cells(1, 83).value = "CONSALCOHOLSI"
        .Cells(1, 84).value = "CONSUALCOHOLNO"
        .Cells(1, 85).value = "OTRDROGSI"
        .Cells(1, 86).value = "OTRDRO2GSI"
        .Cells(1, 87).value = "OTRDROGNO"
        .Cells(1, 88).value = "OTRDROG2NO"
        .Cells(1, 89).value = "CONSTABACOTIEMPO"
        .Cells(1, 90).value = "CONSALCOHOLTIEMPO"
        .Cells(1, 91).value = "CONSOTRDROGTIEMPO"
        .Cells(1, 92).value = "CONSOTRDROG2TIEMPO"
        .Cells(1, 93).value = "CONSTABACOCANTIDAD"
        .Cells(1, 94).value = "CONSALCOHOLCANTIDAD"
        .Cells(1, 95).value = "CONSOTRDROGCANTIDAD"
        .Cells(1, 96).value = "CONSOTRDROG2CANTIDAD"
        .Cells(1, 97).value = "EXCONSUTABACO"
        .Cells(1, 98).value = "EXCONSUALCOHOL"
        .Cells(1, 99).value = "EXCONSUOTRDROG"
        .Cells(1, 100).value = "EXCONSUOTRDROG2"
        .Cells(1, 101).value = "TIEMPABSTINENCIATABACO"
        .Cells(1, 102).value = "TIEMPABSTINENCIAALCOHOL"
        .Cells(1, 103).value = "TIEMPABSTINENCIAOTRDROG"
        .Cells(1, 104).value = "TIEMPABSTINENCIAOTRDROG2"
        .Cells(1, 105).value = "ACTFISICASI"
        .Cells(1, 106).value = "ACTFISICANO"
        .Cells(1, 107).value = "MEDICHABITSI"
        .Cells(1, 108).value = "MEDICHABITNO"
        .Cells(1, 109).value = "ACTFISICADESCRP"
        .Cells(1, 110).value = "MEDICHABITDESCRIP"
        .Cells(1, 111).value = "MEDICHABITDESCRIP2"
        .Cells(1, 112).value = "MEDICHABITDESCRIP3"
        .Cells(1, 113).value = "ACTFISICSEMANAL"
        .Cells(1, 114).value = "MEDHABITCANTIDAD"
        .Cells(1, 115).value = "MEDHABITCANTIDAD2"
        .Cells(1, 116).value = "MEDHABITCANTIDAD3"
        .Cells(1, 117).value = "EMPANT1"
        .Cells(1, 118).value = "EMPANT2"
        .Cells(1, 119).value = "EMPANT3"
        .Cells(1, 120).value = "EMPANT4"
        .Cells(1, 121).value = "EMPANTPUESTO1"
        .Cells(1, 122).value = "EMPANTPUESTO2"
        .Cells(1, 123).value = "EMPANTPUESTO3"
        .Cells(1, 124).value = "EMPANTPUESTO4"
        .Cells(1, 125).value = "EMPANTACTIVIDAD1"
        .Cells(1, 126).value = "EMPANTACTIVIDAD2"
        .Cells(1, 127).value = "EMPANTACTIVIDAD3"
        .Cells(1, 128).value = "EMPANTACTIVIDAD4"
        .Cells(1, 129).value = "EMPANTTIEMPTRABAJO1"
        .Cells(1, 130).value = "EMPANTTIEMPTRABAJO2"
        .Cells(1, 131).value = "EMPANTTIEMPTRABAJO3"
        .Cells(1, 132).value = "EMPANTTIEMPTRABAJO4"
        .Cells(1, 133).value = "EMPANTRIESGFISICO1"
        .Cells(1, 134).value = "EMPANTRIESGFISICO2"
        .Cells(1, 135).value = "EMPANTRIESGFISICO3"
        .Cells(1, 136).value = "EMPANTRIESGFISICO4"
        .Cells(1, 137).value = "EMPANTRIESGMECANIC1"
        .Cells(1, 138).value = "EMPANTRIESGMECANIC2"
        .Cells(1, 139).value = "EMPANTRIESGMECANIC3"
        .Cells(1, 140).value = "EMAPNTRIESGMECANIC4"
        .Cells(1, 141).value = "EMPANTRIESGQUIMICO1"
        .Cells(1, 142).value = "EMPANTRIESGQUIMICO2"
        .Cells(1, 143).value = "EMPANTRIESGQUIMICO3"
        .Cells(1, 144).value = "EMPANTRIESGQUIMICO4"
        .Cells(1, 145).value = "EMPANTRIESGBIOLOG1"
        .Cells(1, 146).value = "EMPANTRIESGBIOLOG2"
        .Cells(1, 147).value = "EMPANTRIESGBIOLOG3"
        .Cells(1, 148).value = "EMPANTRIESGBIOLOG4"
        .Cells(1, 149).value = "EMPANTRIESGERGONOMICO1"
        .Cells(1, 150).value = "EMPANTRIESGERGONOMICO2"
        .Cells(1, 151).value = "EMPANTRIESGERGONOMICO3"
        .Cells(1, 152).value = "EMPANTRIESGERGONOMICO4"
        .Cells(1, 153).value = "EMPANTRIESGPSICOSOCIAL1"
        .Cells(1, 154).value = "EMPANTRIESGPSICOSOCIAL2"
        .Cells(1, 155).value = "EMPANTRIESGPSICOSOCIAL3"
        .Cells(1, 156).value = "EMPANTRIESGPSICOSOCIAL4"
        .Cells(1, 157).value = "EMPANTOBSERVACION1"
        .Cells(1, 158).value = "EMPANTOBSERVACION2"
        .Cells(1, 159).value = "EMPANTOBSERVACION3"
        .Cells(1, 160).value = "EMPANTOBSERVACION4"
        .Cells(1, 161).value = "ANTECALIFIESS"
        .Cells(1, 162).value = "ANTECALIFIESSSi"
        .Cells(1, 163).value = "ANTECALIFDESCRIP"
        .Cells(1, 164).value = "ANTECALIFNO"
        .Cells(1, 165).value = "ANTECALIFFECHA"
        .Cells(1, 166).value = "ENFERMEDADESCALIFIESS"
        .Cells(1, 167).value = "ENFERMEDADESCALIFIESSSI"
        .Cells(1, 168).value = "ENFERMEDADESCALIFDESCRIP"
        .Cells(1, 169).value = "ENFERMEDADESCALIFNO"
        .Cells(1, 170).value = "ENFERMEDADESCALIFFECHA"
        .Cells(1, 171).value = "ENFCARDIOVASCULAR"
        .Cells(1, 172).value = "ENFMETABOLICA"
        .Cells(1, 173).value = "ENFNEUROLOG"
        .Cells(1, 174).value = "ENFONCOLOG"
        .Cells(1, 175).value = "ENFINFECC"
        .Cells(1, 176).value = "ENFHEREDITAR"
        .Cells(1, 177).value = "AFDISCAPACIDAD"
        .Cells(1, 178).value = "AFOTROS"
        .Cells(1, 179).value = "AFDESCRIP"


        .Cells(2, 1).value = _objeto.Contrato.Patrono.NombreCompleto
        .Cells(2, 2).value = _objeto.Contrato.Patrono.Ruc
        .Cells(2, 3).value = _objeto.Contrato.Patrono.Ciudad.Descripcion
        .Cells(2, 4).value = _objeto.PardetClinica.Pardet_Descripcion
        .Cells(2, 5).value = _objeto.PardetClinica.Pardet_DatoStr1
        .Cells(2, 6).value = _objeto.Ficha_ArchivoNum
        .Cells(2, 7).value = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Apellidopaterno
        .Cells(2, 8).value = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Apellidomaterno
        Dim nombre1 As String = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Nombres.Trim().Split(" ").FirstOrDefault()
        Dim nombre2 As String = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Nombres.Trim()
        nombre2 = nombre2.Remove(0, Len(nombre1)).Trim()
        .Cells(2, 9).value = nombre1
        .Cells(2, 10).value = nombre2
        .Cells(2, 11).value = _objeto.Contrato.Empleado.Entidadnatural.PardetSexoString
        .Cells(2, 12).value = _objeto.Contrato.Empleado.Entidadnatural.Edad
        .Cells(2, 13).value = IIf(_objeto.Pardet_Religion = 1, "X", "")
        .Cells(2, 14).value = IIf(_objeto.Pardet_Religion = 2, "X", "")
        .Cells(2, 15).value = IIf(_objeto.Pardet_Religion = 3, "X", "")
        .Cells(2, 16).value = IIf(_objeto.Pardet_Religion = 4, "X", "")
        .Cells(2, 17).value = IIf(_objeto.Pardet_Religion = 5, "X", "")
        .Cells(2, 18).value = IIf(_objeto.Pardet_Genero = 1, "X", "")
        .Cells(2, 19).value = IIf(_objeto.Pardet_Genero = 2, "X", "")
        .Cells(2, 20).value = IIf(_objeto.Pardet_Genero = 3, "X", "")
        .Cells(2, 21).value = IIf(_objeto.Pardet_Genero = 4, "X", "")
        .Cells(2, 22).value = IIf(_objeto.Pardet_Genero = 5, "X", "")
        .Cells(2, 23).value = IIf(_objeto.Pardet_Genero = 6, "X", "")
        .Cells(2, 24).value = IIf(_objeto.Pardet_Genero = 7, "X", "")
        .Cells(2, 25).value = IIf(_objeto.Pardet_Genero = 8, "X", "")
        .Cells(2, 26).value = IIf(_objeto.Pardet_Genero = 9, "X", "")
        .Cells(2, 27).value = IIf(_objeto.Contrato.Empleado.Emplea_DiscaAuditiva Or _objeto.Contrato.Empleado.Emplea_DiscaFisica Or _objeto.Contrato.Empleado.Emplea_DiscaIntelectual Or _objeto.Contrato.Empleado.Emplea_DiscaLenguaje Or _objeto.Contrato.Empleado.Emplea_DiscaPsicologica Or _objeto.Contrato.Empleado.Emplea_DiscaVisual, "X", "")
        .Cells(2, 28).value = IIf(_objeto.Contrato.Empleado.Emplea_DiscaAuditiva Or _objeto.Contrato.Empleado.Emplea_DiscaFisica Or _objeto.Contrato.Empleado.Emplea_DiscaIntelectual Or _objeto.Contrato.Empleado.Emplea_DiscaLenguaje Or _objeto.Contrato.Empleado.Emplea_DiscaPsicologica Or _objeto.Contrato.Empleado.Emplea_DiscaVisual, "", "X")
        .Cells(2, 29).value = _objeto.Contrato.Empleado.Discapacidad
        .Cells(2, 30).value = _objeto.Contrato.Empleado.Discapacidad
        .Cells(2, 31).value = _objeto.Contrato.Contra_Desde.ToString("yyyy/MM/dd")
        .Cells(2, 32).value = _objeto.Contrato.PardetArea.Pardet_DatoStr1
        .Cells(2, 33).value = _objeto.Contrato.PardetArea.Descripcion
        .Cells(2, 34).value = _objeto.Contrato.PardetArea.Descripcion
        .Cells(2, 35).value = _objeto.Ficha_MotivoConsulta
        .Cells(2, 36).value = _objeto.Ficha_Antecedentes

        If _objeto.Contrato.Empleado.Entidadnatural.Pardet_Sexo = 2 Then 'femenino
          .Cells(2, 37).value = _objeto.Ficha_FecMenarq.ToString("yyyy/MM/dd")
          .Cells(2, 38).value = _objeto.Ficha_Ciclos
          .Cells(2, 39).value = _objeto.Ficha_FUM
          .Cells(2, 40).value = _objeto.Ficha_Gestas
          .Cells(2, 41).value = _objeto.Ficha_Partos
          .Cells(2, 42).value = _objeto.Ficha_Cesareas
          .Cells(2, 43).value = _objeto.Ficha_Abortos
          .Cells(2, 44).value = _objeto.Ficha_HijosMuertos
          .Cells(2, 45).value = _objeto.Ficha_HijosMuertos
          .Cells(2, 46).value = IIf(_objeto.Ficha_VSA, "X", "")
          .Cells(2, 47).value = IIf(_objeto.Ficha_VSA, "", "X")
          .Cells(2, 48).value = IIf(_objeto.Ficha_MPF, "X", "")
          .Cells(2, 49).value = IIf(_objeto.Ficha_MPF, "", "X")
          .Cells(2, 50).value = _objeto.Ficha_MPFTipo1
          .Cells(2, 51).value = IIf(_objeto.Ficha_Papanic, "X", "")
          .Cells(2, 52).value = IIf(_objeto.Ficha_Papanic, "", "X")
          .Cells(2, 53).value = IIf(_objeto.Ficha_Colposcop, "X", "")
          .Cells(2, 54).value = IIf(_objeto.Ficha_Colposcop, "", "X")
          .Cells(2, 55).value = _objeto.Ficha_PapanicAnios
          .Cells(2, 56).value = _objeto.Ficha_ColposcopAnios
          .Cells(2, 57).value = _objeto.Ficha_PapanicResult
          .Cells(2, 58).value = _objeto.Ficha_ColposcopResult
          .Cells(2, 59).value = IIf(_objeto.Ficha_EcoMamario, "X", "")
          .Cells(2, 60).value = IIf(_objeto.Ficha_EcoMamario, "", "X")
          .Cells(2, 61).value = IIf(_objeto.Ficha_Mamogra, "X", "")
          .Cells(2, 62).value = IIf(_objeto.Ficha_Mamogra, "", "X")
          .Cells(2, 63).value = _objeto.Ficha_EcoMamarioAnios
          .Cells(2, 64).value = _objeto.Ficha_EcoMamarioResult
          .Cells(2, 65).value = _objeto.Ficha_MamograAnios
          .Cells(2, 66).value = _objeto.Ficha_MamograResult


        End If
        If _objeto.Contrato.Empleado.Entidadnatural.Pardet_Sexo = 1 Then 'masculino
          .Cells(2, 67).value = IIf(_objeto.Ficha_AntigProst, "X", "")
          .Cells(2, 68).value = IIf(_objeto.Ficha_AntigProst, "", "X")
          .Cells(2, 69).value = IIf(_objeto.Ficha_EcoProst, "X", "")
          .Cells(2, 70).value = IIf(_objeto.Ficha_EcoProst, "", "X")
          .Cells(2, 71).value = _objeto.Ficha_AntigProstAnios
          .Cells(2, 72).value = _objeto.Ficha_EcoProstAnios
          .Cells(2, 73).value = _objeto.Ficha_AntigProstResult
          .Cells(2, 74).value = _objeto.Ficha_EcoProstResult
          .Cells(2, 75).value = IIf(_objeto.Ficha_MPF, "X", "")
          .Cells(2, 76).value = IIf(_objeto.Ficha_MPF, "", "X")
          .Cells(2, 77).value = _objeto.Ficha_MPFTipo1
          .Cells(2, 78).value = _objeto.Ficha_MPFTipo2
          .Cells(2, 79).value = _objeto.Ficha_HijosVivos
          .Cells(2, 80).value = _objeto.Ficha_HijosMuertos

        End If


        .Cells(2, 81).value = IIf(_objeto.Ficha_Tabaco, "X", "")
        .Cells(2, 82).value = IIf(_objeto.Ficha_Tabaco, "", "X")
        .Cells(2, 83).value = IIf(_objeto.Ficha_Alcohol, "X", "")
        .Cells(2, 84).value = IIf(_objeto.Ficha_Alcohol, "", "X")
        .Cells(2, 85).value = IIf(_objeto.Ficha_Droga1, "X", "")
        .Cells(2, 86).value = IIf(_objeto.Ficha_Droga2, "X", "")
        .Cells(2, 87).value = IIf(_objeto.Ficha_Droga1, "", "X")
        .Cells(2, 88).value = IIf(_objeto.Ficha_Droga2, "", "X")
        .Cells(2, 89).value = _objeto.Ficha_TabacoTiempo
        .Cells(2, 90).value = _objeto.Ficha_AlcoholTiempo
        .Cells(2, 91).value = _objeto.Ficha_Droga1Tiempo
        .Cells(2, 92).value = _objeto.Ficha_Droga2Tiempo
        .Cells(2, 93).value = _objeto.Ficha_TabacoCantidad
        .Cells(2, 94).value = _objeto.Ficha_AlcoholCantidad
        .Cells(2, 95).value = _objeto.Ficha_Droga1Cantidad
        .Cells(2, 96).value = _objeto.Ficha_Droga2Cantidad
        .Cells(2, 97).value = IIf(_objeto.Ficha_TabacoExConsumidor, "X", "")
        .Cells(2, 98).value = IIf(_objeto.Ficha_AlcoholExConsumidor, "X", "")
        .Cells(2, 99).value = IIf(_objeto.Ficha_Droga1ExConsumidor, "X", "")
        .Cells(2, 100).value = IIf(_objeto.Ficha_Droga2ExConsumidor, "X", "")
        .Cells(2, 101).value = _objeto.Ficha_TabacoTiempoAbstinencia
        .Cells(2, 102).value = _objeto.Ficha_AlcoholTiempoAbstinencia
        .Cells(2, 103).value = _objeto.Ficha_Droga1TiempoAbstinencia
        .Cells(2, 104).value = _objeto.Ficha_Droga2TiempoAbstinencia
        .Cells(2, 105).value = IIf(_objeto.Ficha_ActivFisica, "X", "")
        .Cells(2, 106).value = IIf(_objeto.Ficha_ActivFisica, "", "X")
        .Cells(2, 107).value = IIf(_objeto.Ficha_MedicHabit, "X", "")
        .Cells(2, 108).value = IIf(_objeto.Ficha_MedicHabit, "", "X")
        .Cells(2, 109).value = _objeto.Ficha_ActivFisicaDescripcion
        .Cells(2, 110).value = _objeto.Ficha_MedicHabitDescripcion1
        .Cells(2, 111).value = _objeto.Ficha_MedicHabitDescripcion2
        .Cells(2, 112).value = _objeto.Ficha_MedicHabitDescripcion3
        .Cells(2, 113).value = _objeto.Ficha_ActivFisicaTiempoSemanal
        .Cells(2, 114).value = _objeto.Ficha_MedicHabitCantidad1
        .Cells(2, 115).value = _objeto.Ficha_MedicHabitCantidad2
        .Cells(2, 116).value = _objeto.Ficha_MedicHabitCantidad3
        .Cells(2, 117).value = _objeto.Ficha_AntEmplEmpresa1
        .Cells(2, 118).value = _objeto.Ficha_AntEmplEmpresa2
        .Cells(2, 119).value = _objeto.Ficha_AntEmplEmpresa3
        .Cells(2, 120).value = _objeto.Ficha_AntEmplEmpresa4
        .Cells(2, 121).value = _objeto.Ficha_AntEmplPuesto1
        .Cells(2, 122).value = _objeto.Ficha_AntEmplPuesto2
        .Cells(2, 123).value = _objeto.Ficha_AntEmplPuesto3
        .Cells(2, 124).value = _objeto.Ficha_AntEmplPuesto4
        .Cells(2, 125).value = _objeto.Ficha_AntEmplActividad1
        .Cells(2, 126).value = _objeto.Ficha_AntEmplActividad2
        .Cells(2, 127).value = _objeto.Ficha_AntEmplActividad3
        .Cells(2, 128).value = _objeto.Ficha_AntEmplActividad4
        .Cells(2, 129).value = _objeto.Ficha_AntEmplTrabMeses1
        .Cells(2, 130).value = _objeto.Ficha_AntEmplTrabMeses2
        .Cells(2, 131).value = _objeto.Ficha_AntEmplTrabMeses3
        .Cells(2, 132).value = _objeto.Ficha_AntEmplTrabMeses4
        .Cells(2, 133).value = IIf(_objeto.Ficha_AntEmplRieFis1, "X", "")
        .Cells(2, 134).value = IIf(_objeto.Ficha_AntEmplRieFis2, "X", "")
        .Cells(2, 135).value = IIf(_objeto.Ficha_AntEmplRieFis3, "X", "")
        .Cells(2, 136).value = IIf(_objeto.Ficha_AntEmplRieFis4, "X", "")
        .Cells(2, 137).value = IIf(_objeto.Ficha_AntEmplRieMec1, "X", "")
        .Cells(2, 138).value = IIf(_objeto.Ficha_AntEmplRieMec2, "X", "")
        .Cells(2, 139).value = IIf(_objeto.Ficha_AntEmplRieMec3, "X", "")
        .Cells(2, 140).value = IIf(_objeto.Ficha_AntEmplRieMec4, "X", "")
        .Cells(2, 141).value = IIf(_objeto.Ficha_AntEmplRieQui1, "X", "")
        .Cells(2, 142).value = IIf(_objeto.Ficha_AntEmplRieQui2, "X", "")
        .Cells(2, 143).value = IIf(_objeto.Ficha_AntEmplRieQui3, "X", "")
        .Cells(2, 144).value = IIf(_objeto.Ficha_AntEmplRieQui4, "X", "")
        .Cells(2, 145).value = IIf(_objeto.Ficha_AntEmplRieBio1, "X", "")
        .Cells(2, 146).value = IIf(_objeto.Ficha_AntEmplRieBio2, "X", "")
        .Cells(2, 147).value = IIf(_objeto.Ficha_AntEmplRieBio3, "X", "")
        .Cells(2, 148).value = IIf(_objeto.Ficha_AntEmplRieBio4, "X", "")
        .Cells(2, 149).value = IIf(_objeto.Ficha_AntEmplRieErg1, "X", "")
        .Cells(2, 150).value = IIf(_objeto.Ficha_AntEmplRieErg2, "X", "")
        .Cells(2, 151).value = IIf(_objeto.Ficha_AntEmplRieErg3, "X", "")
        .Cells(2, 152).value = IIf(_objeto.Ficha_AntEmplRieErg4, "X", "")
        .Cells(2, 153).value = IIf(_objeto.Ficha_AntEmplRiePsi1, "X", "")
        .Cells(2, 154).value = IIf(_objeto.Ficha_AntEmplRiePsi2, "X", "")
        .Cells(2, 155).value = IIf(_objeto.Ficha_AntEmplRiePsi3, "X", "")
        .Cells(2, 156).value = IIf(_objeto.Ficha_AntEmplRiePsi4, "X", "")
        .Cells(2, 157).value = _objeto.Ficha_AntEmplObs1
        .Cells(2, 158).value = _objeto.Ficha_AntEmplObs2
        .Cells(2, 159).value = _objeto.Ficha_AntEmplObs3
        .Cells(2, 160).value = _objeto.Ficha_AntEmplObs4
        .Cells(2, 161).value = _objeto.Ficha_AntTrabCalifObservacion
        .Cells(2, 162).value = IIf(_objeto.Ficha_AntTrabCalif, "X", "")
        .Cells(2, 163).value = _objeto.Ficha_AntTrabCalifDescripcion
        .Cells(2, 164).value = IIf(_objeto.Ficha_AntTrabCalif, "", "X")
        .Cells(2, 165).value = _objeto.Ficha_AntTrabCalifFecha.ToString("yyyy/MM/dd")
        .Cells(2, 166).value = _objeto.Ficha_EnfProfCalifObservacion
        .Cells(2, 167).value = IIf(_objeto.Ficha_EnfProfCalif, "X", "")
        .Cells(2, 168).value = _objeto.Ficha_EnfProfCalifDescripcion
        .Cells(2, 169).value = IIf(_objeto.Ficha_EnfProfCalif, "", "X")
        .Cells(2, 170).value = _objeto.Ficha_EnfProfCalifFecha.ToString("yyyy/MM/dd")
        .Cells(2, 171).value = IIf(_objeto.Ficha_AntFamEnfCard, "X", "")
        .Cells(2, 172).value = IIf(_objeto.Ficha_AntFamEnfMet, "X", "")
        .Cells(2, 173).value = IIf(_objeto.Ficha_AntFamEnfNeu, "X", "")
        .Cells(2, 174).value = IIf(_objeto.Ficha_AntFamEnfOnc, "X", "")
        .Cells(2, 175).value = IIf(_objeto.Ficha_AntFamEnfInf, "X", "")
        .Cells(2, 176).value = IIf(_objeto.Ficha_AntFamEnfHer, "X", "")
        .Cells(2, 177).value = IIf(_objeto.Ficha_AntFamEnfDisc, "X", "")
        .Cells(2, 178).value = IIf(_objeto.Ficha_AntFamEnfOtro, "X", "")
        .Cells(2, 179).value = _objeto.Ficha_AntFamObservacion


      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecombinacionpag1.xls"
      Try
        Kill(rutfte)
      Catch ex As Exception
      End Try

      excelBook.SaveAs(Filename:=rutfte)
      excelBook.Close()
      excelApp.Visible = True
      excelApp.Quit()

      Dim WordApp As New Word.Application
      Dim WordDocument As Word.Document = WordApp.Documents.Open(_direccionarchivo)
      'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
      WordApp.Visible = True
      WordDocument.Activate()
      With WordDocument.MailMerge
        .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & _nombreHoja & "$`")
        .ViewMailMergeFieldCodes = False
        .Destination = 0     'nuevo documento
        .SuppressBlankLines = True
        With .DataSource
          .FirstRecord = 1
          .LastRecord = -16
        End With
        .Execute(Pause:=False)
      End With
      WordDocument.ActiveWindow.Close(False)

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub
  Public Shared Sub CombinarCorrespondenciaFichaPreocupacionalPag2(ByVal _objeto As FichaMedica, ByVal _direccionarchivo As String)
    If Not My.Computer.FileSystem.FileExists(_direccionarchivo) Then
      MsgBox("No existe la carta modelo para realizar la combinación de correspondencia", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _nombreHoja As String = "Hoja1"

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet =
           CType(excelBook.Worksheets(1), Excel.Worksheet)
      _nombreHoja = excelWorksheet.Name

      excelApp.Visible = False
      With excelWorksheet

        .Cells(1, 1).value = "RIESGACTUALPUESTTRABAJ1"
        .Cells(1, 2).value = "RIESGACTUALPUESTTRABAJ2"
        .Cells(1, 3).value = "RIESGACTUALPUESTTRABAJ3"
        .Cells(1, 4).value = "RIESGACTUALPUESTTRABAJ4"
        .Cells(1, 5).value = "RIESGACTUALACTIVIDADES1"
        .Cells(1, 6).value = "RIESGACTUALACTIVIDADES2"
        .Cells(1, 7).value = "RIESGACTUALACTIVIDADES3"
        .Cells(1, 8).value = "RIESGACTUALACTIVIDADES4"
        .Cells(1, 9).value = "FISCTEMALTA1"
        .Cells(1, 10).value = "FISCTEMALTA2"
        .Cells(1, 11).value = "FISCTEMALTA3"
        .Cells(1, 12).value = "FISCTEMALTA4"
        .Cells(1, 13).value = "FISCTEMBAJA1"
        .Cells(1, 14).value = "FISCTEMBAJA2"
        .Cells(1, 15).value = "FISCTEMBAJA3"
        .Cells(1, 16).value = "FISCTEMBAJA4"
        .Cells(1, 17).value = "FISCRADIAC1"
        .Cells(1, 18).value = "FISCRADIAC2"
        .Cells(1, 19).value = "FISCRADIAC3"
        .Cells(1, 20).value = "FISCRADIAC4"
        .Cells(1, 21).value = "FISCRADIANOLONIZANT1"
        .Cells(1, 22).value = "FISCRADIANOLONIZANT2"
        .Cells(1, 23).value = "FISCRADIANOLONIZANT3"
        .Cells(1, 24).value = "FISCRADIANOLONIZANT4"
        .Cells(1, 25).value = "FISCRUIDO1"
        .Cells(1, 26).value = "FISCRUIDO2"
        .Cells(1, 27).value = "FISCRUIDO3"
        .Cells(1, 28).value = "FISCRUIDO4"
        .Cells(1, 29).value = "FISICVIBRACION1"
        .Cells(1, 30).value = "FISICVIBRACION2"
        .Cells(1, 31).value = "FISICVIBRACION3"
        .Cells(1, 32).value = "FISICVIBRACION4"
        .Cells(1, 33).value = "FISICILUMIN1"
        .Cells(1, 34).value = "FISICILUMIN2"
        .Cells(1, 35).value = "FISICILUMIN3"
        .Cells(1, 36).value = "FISICILUMIN4"
        .Cells(1, 37).value = "FISICVENTILA1"
        .Cells(1, 38).value = "FISICVENTILA2"
        .Cells(1, 39).value = "FISICVENTILA3"
        .Cells(1, 40).value = "FISICVENTILA4"
        .Cells(1, 41).value = "FISICFLUIDOELECTRI1"
        .Cells(1, 42).value = "FISICFLUIDOELECTRI2"
        .Cells(1, 43).value = "FISICFLUIDOELECTRI3"
        .Cells(1, 44).value = "FISICFLUIDOELECTRI4"
        .Cells(1, 45).value = "FISICOTRO1"
        .Cells(1, 46).value = "FISICOTRO2"
        .Cells(1, 47).value = "FISICOTRO3"
        .Cells(1, 48).value = "FISICOTRO4"
        .Cells(1, 49).value = "MECANICATRAPAMAQUINA1"
        .Cells(1, 50).value = "MECANICATRAPAMAQUINA2"
        .Cells(1, 51).value = "MECANICATRAPAMAQUINA3"
        .Cells(1, 52).value = "MECANICATRAPAMAQUINA4"
        .Cells(1, 53).value = "MECANICATRAPSUPER1"
        .Cells(1, 54).value = "MECANICATRAPSUPER2"
        .Cells(1, 55).value = "MECANICATRAPSUPER3"
        .Cells(1, 56).value = "MECANICATRAPSUPER4"
        .Cells(1, 57).value = "MECANICATRAPOBJETOS1"
        .Cells(1, 58).value = "MECANICATRAPOBJETOS2"
        .Cells(1, 59).value = "MECANICATRAPOBJETOS3"
        .Cells(1, 60).value = "MECANICATRAPOBJETOS4"

        .Cells(1, 61).value = "MECANICCAIDAOBJETOS1"
        .Cells(1, 62).value = "MECANICCAIDAOBJETOS2"
        .Cells(1, 63).value = "MECANICCAIDAOBJETOS3"
        .Cells(1, 64).value = "MECANICCAIDAOBJETOS4"

        .Cells(1, 65).value = "MECANICCAIMISMONIVEL1"
        .Cells(1, 66).value = "MECANICCAIMISMONIVEL2"
        .Cells(1, 67).value = "MECANICCAIMISMONIVEL3"
        .Cells(1, 68).value = "MECANICCAIMISMONIVEL4"
        .Cells(1, 69).value = "MECANICCAIDIFERNIVEL1"
        .Cells(1, 70).value = "MECANICCAIDIFERNIVEL2"
        .Cells(1, 71).value = "MECANICCAIDIFERNIVEL3"
        .Cells(1, 72).value = "MECANICCAIDIFERNIVEL4"
        .Cells(1, 73).value = "MECANICCONTACELECT1"
        .Cells(1, 74).value = "MECANICCONTACELECT2"
        .Cells(1, 75).value = "MECANICCONTACELECT3"
        .Cells(1, 76).value = "MECANICCONTACELECT4"
        .Cells(1, 77).value = "MECANICCONTACSUERFTRABJ1"
        .Cells(1, 78).value = "MECANICCONTACSUERFTRABJ2"
        .Cells(1, 79).value = "MECANICCONTACSUERFTRABJ3"
        .Cells(1, 80).value = "MECANICCONTACSUERFTRABJ4"
        .Cells(1, 81).value = "MECANICPROYECPARTIC1"
        .Cells(1, 82).value = "MECANICPROYECPARTIC2"
        .Cells(1, 83).value = "MECANICPROYECPARTIC3"
        .Cells(1, 84).value = "MECANICPROYECPARTIC4"

        .Cells(1, 85).value = "MECANICPROYECFLU1"
        .Cells(1, 86).value = "MECANICPROYECFLU2"
        .Cells(1, 87).value = "MECANICPROYECFLU3"
        .Cells(1, 88).value = "MECANICPROYECFLU4"
        .Cells(1, 89).value = "MECANICPINCHA1"
        .Cells(1, 90).value = "MECANICPINCHA2"
        .Cells(1, 91).value = "MECANICPINCHA3"
        .Cells(1, 92).value = "MECANICPINCHA4"
        .Cells(1, 93).value = "MECANICCORTES1"
        .Cells(1, 94).value = "MECANICCORTES2"
        .Cells(1, 95).value = "MECANICCORTES3"
        .Cells(1, 96).value = "MECANICCORTES4"
        .Cells(1, 97).value = "MECANICATROPELL1"
        .Cells(1, 98).value = "MECANICATROPELL2"
        .Cells(1, 99).value = "MECANICATROPELL3"
        .Cells(1, 100).value = "MECANICATROPELL4"



        .Cells(1, 101).value = "MECANICCHOQUEVEHIC1"
        .Cells(1, 102).value = "MECANICCHOQUEVEHIC2"
        .Cells(1, 103).value = "MECANICCHOQUEVEHIC3"
        .Cells(1, 104).value = "MECANICCHOQUEVEHIC4"
        .Cells(1, 105).value = "MECANICOTRO1"
        .Cells(1, 106).value = "MECANICOTRO2"
        .Cells(1, 107).value = "MECANICOTRO3"
        .Cells(1, 108).value = "MECANICOTRO4"

        .Cells(1, 109).value = "QQSOLIDO1"
        .Cells(1, 110).value = "QQSOLIDO2"
        .Cells(1, 111).value = "QQSOLIDO3"
        .Cells(1, 112).value = "QQSOLIDO4"
        .Cells(1, 113).value = "QQPOLVO1"
        .Cells(1, 114).value = "QQPOLVO2"
        .Cells(1, 115).value = "QQPOLVO3"
        .Cells(1, 116).value = "QQPOLVO4"
        .Cells(1, 117).value = "QQHUMO1"
        .Cells(1, 118).value = "QQHUMO2"
        .Cells(1, 119).value = "QQHUMO3"
        .Cells(1, 120).value = "QQHUMO4"
        .Cells(1, 121).value = "QQLIQUID1"
        .Cells(1, 122).value = "QQLIQUID2"
        .Cells(1, 123).value = "QQLIQUID3"
        .Cells(1, 124).value = "QQLIQUID4"
        .Cells(1, 125).value = "QQVAPOR1"
        .Cells(1, 126).value = "QQVAPOR2"
        .Cells(1, 127).value = "QQVAPOR3"
        .Cells(1, 128).value = "QQVAPOR4"
        .Cells(1, 129).value = "QQAEROSOL1"
        .Cells(1, 130).value = "QQAEROSOL2"
        .Cells(1, 131).value = "QQAEROSOL3"
        .Cells(1, 132).value = "QQAEROSOL4"
        .Cells(1, 133).value = "QQNEBLINA1"
        .Cells(1, 134).value = "QQNEBLINA2"
        .Cells(1, 135).value = "QQNEBLINA3"
        .Cells(1, 136).value = "QQNEBLINA4"
        .Cells(1, 137).value = "QQGASES1"
        .Cells(1, 138).value = "QQGASES2"
        .Cells(1, 139).value = "QQGASES3"
        .Cells(1, 140).value = "QQGASES4"
        .Cells(1, 141).value = "QQOTRO1"
        .Cells(1, 142).value = "QQOTRO2"
        .Cells(1, 143).value = "QQOTRO3"
        .Cells(1, 144).value = "QQOTRO4"
        .Cells(1, 145).value = "BIOLOGVIRUS1"
        .Cells(1, 146).value = "BIOLOGVIRUS2"
        .Cells(1, 147).value = "BIOLOGVIRUS3"
        .Cells(1, 148).value = "BIOLOGVIRUS4"
        .Cells(1, 149).value = "BIOLOGHONGO1"
        .Cells(1, 150).value = "BIOLOGHONGO2"
        .Cells(1, 151).value = "BIOLOGHONGO3"
        .Cells(1, 152).value = "BIOLOGHONGO4"
        .Cells(1, 153).value = "BIOLOGBACTERIA1"
        .Cells(1, 154).value = "BIOLOGBACTERIA2"
        .Cells(1, 155).value = "BIOLOGBACTERIA3"
        .Cells(1, 156).value = "BIOLOGBACTERIA4"
        .Cells(1, 157).value = "BIOLOGPARACIT1"
        .Cells(1, 158).value = "BIOLOGPARACIT2"
        .Cells(1, 159).value = "BIOLOGPARACIT3"
        .Cells(1, 160).value = "BIOLOGPARACIT4"
        .Cells(1, 161).value = "BIOLOGEXPOVECTORES1"
        .Cells(1, 162).value = "BIOLOGEXPOVECTORES2"
        .Cells(1, 163).value = "BIOLOGEXPOVECTORES3"
        .Cells(1, 164).value = "BIOLOGEXPOVECTORES4"

        .Cells(1, 165).value = "BIOLOGEXPOANIMALSELV1"
        .Cells(1, 166).value = "BIOLOGEXPOANIMALSELV2"
        .Cells(1, 167).value = "BIOLOGEXPOANIMALSELV3"
        .Cells(1, 168).value = "BIOLOGEXPOANIMALSELV4"
        .Cells(1, 169).value = "BIOLOGOTROS1"
        .Cells(1, 170).value = "BIOLOGOTROS2"
        .Cells(1, 171).value = "BIOLOGOTROS3"
        .Cells(1, 172).value = "BIOLOGOTROS4"
        .Cells(1, 173).value = "ERGONOMANEJOMANUALCARG1"
        .Cells(1, 174).value = "ERGONOMANEJOMANUALCARG2"
        .Cells(1, 175).value = "ERGONOMANEJOMANUALCARG3"
        .Cells(1, 176).value = "ERGONOMANEJOMANUALCARG14"
        .Cells(1, 177).value = "ERGONOMOVREP1"
        .Cells(1, 178).value = "ERGONOMOVREP2"
        .Cells(1, 179).value = "ERGONOMOVREP3"
        .Cells(1, 180).value = "ERGONOMOVREP4"
        .Cells(1, 181).value = "ERGONOPOSTFORZAD1"
        .Cells(1, 182).value = "ERGONOPOSTFORZAD2"
        .Cells(1, 183).value = "ERGONOPOSTFORZAD3"
        .Cells(1, 184).value = "ERGONOPOSTFORZAD4"
        .Cells(1, 185).value = "ERGONOTRAJPDV1"
        .Cells(1, 186).value = "ERGONOTRAJPDV2"
        .Cells(1, 187).value = "ERGONOTRAJPDV3"
        .Cells(1, 188).value = "ERGONOTRAJPDV4"
        .Cells(1, 189).value = "ERGONOOTRO1"
        .Cells(1, 190).value = "ERGONOOTRO2"
        .Cells(1, 191).value = "ERGONOOTRO3"
        .Cells(1, 192).value = "ERGONOOTRO4"
        .Cells(1, 193).value = "PSICOMONOTONIALABO1"
        .Cells(1, 194).value = "PSICOMONOTONIALABO2"
        .Cells(1, 195).value = "PSICOMONOTONIALABO3"
        .Cells(1, 196).value = "PSICOMONOTONIALABO4"
        .Cells(1, 197).value = "PSICOSOBRECARGLABO1"
        .Cells(1, 198).value = "PSICOSOBRECARGLABO2"
        .Cells(1, 199).value = "PSICOSOBRECARGLABO3"
        .Cells(1, 200).value = "PSICOSOBRECARGLABO4"
        .Cells(1, 201).value = "PSICOMINUCIOSIDADTAREA1"
        .Cells(1, 202).value = "PSICOMINUCIOSIDADTAREA2"
        .Cells(1, 203).value = "PSICOMINUCIOSIDADTAREA3"
        .Cells(1, 204).value = "PSICOMINUCIOSIDADTAREA4"
        .Cells(1, 205).value = "PSICORESPONS1"
        .Cells(1, 206).value = "PSICORESPONS2"
        .Cells(1, 207).value = "PSICORESPONS3"
        .Cells(1, 208).value = "PSICORESPONS4"
        .Cells(1, 209).value = "PSICOTOMADESICION1"
        .Cells(1, 210).value = "PSICOTOMADESICION2"
        .Cells(1, 211).value = "PSICOTOMADESICION3"
        .Cells(1, 212).value = "PSICOTOMADESICION4"
        .Cells(1, 213).value = "PSICOSUPERVDIREC1"
        .Cells(1, 214).value = "PSICOSUPERVDIREC2"
        .Cells(1, 215).value = "PSICOSUPERVDIREC3"
        .Cells(1, 216).value = "PSICOSUPERVDIREC4"
        .Cells(1, 217).value = "PSICOCONFLICTOROL1"
        .Cells(1, 218).value = "PSICOCONFLICTOROL2"
        .Cells(1, 219).value = "PSICOCONFLICTOROL3"
        .Cells(1, 220).value = "PSICOCONFLICTOROL4"
        .Cells(1, 221).value = "PSICOCLARIDFUNCIONES1"
        .Cells(1, 222).value = "PSICOCLARIDFUNCIONES2"
        .Cells(1, 223).value = "PSICOCLARIDFUNCIONES3"
        .Cells(1, 224).value = "PSICOCLARIDFUNCIONES4"
        .Cells(1, 225).value = "PISCOINCORRECDISTRITRABJ1"
        .Cells(1, 226).value = "PISCOINCORRECDISTRITRABJ2"
        .Cells(1, 227).value = "PISCOINCORRECDISTRITRABJ3"
        .Cells(1, 228).value = "PISCOINCORRECDISTRITRABJ4"
        .Cells(1, 229).value = "PSICOTURNOSROT1"
        .Cells(1, 230).value = "PSICOTURNOSROT2"
        .Cells(1, 231).value = "PSICOTURNOSROT3"
        .Cells(1, 232).value = "PSICOTURNOSROT4"
        .Cells(1, 233).value = "PISCORELACINTERPERSON1"
        .Cells(1, 234).value = "PISCORELACINTERPERSON2"
        .Cells(1, 235).value = "PISCORELACINTERPERSON3"
        .Cells(1, 236).value = "PISCORELACINTERPERSON4"
        .Cells(1, 237).value = "PSICOINESTABLABO1"
        .Cells(1, 238).value = "PSICOINESTABLABO2"
        .Cells(1, 239).value = "PSICOINESTABLABO3"
        .Cells(1, 240).value = "PSICOINESTABLABO4"
        .Cells(1, 241).value = "PSICOOTRO1"
        .Cells(1, 242).value = "PSICOOTRO2"
        .Cells(1, 243).value = "PSICOOTRO3"
        .Cells(1, 244).value = "PSICOOTRO4"
        .Cells(1, 245).value = "MEDIDASPREVENTIVAS1"
        .Cells(1, 246).value = "MEDIDASPREVENTIVAS2"
        .Cells(1, 247).value = "MEDIDASPREVENTIVAS3"
        .Cells(1, 248).value = "MEDIDASPREVENTIVAS4"
        .Cells(1, 249).value = "ACTIVEXTRALABO"
        .Cells(1, 250).value = "ENFERMACTUAL1"



        .Cells(2, 1).value = _objeto.Ficha_FactRieArea1
        .Cells(2, 2).value = _objeto.Ficha_FactRieArea2
        .Cells(2, 3).value = _objeto.Ficha_FactRieArea3
        .Cells(2, 4).value = _objeto.Ficha_FactRieArea4
        .Cells(2, 5).value = _objeto.Ficha_FactRieActividad1
        .Cells(2, 6).value = _objeto.Ficha_FactRieActividad2
        .Cells(2, 7).value = _objeto.Ficha_FactRieActividad3
        .Cells(2, 8).value = _objeto.Ficha_FactRieActividad4
        .Cells(2, 9).value = IIf(_objeto.Ficha_FactRieF011, "X", "")
        .Cells(2, 10).value = IIf(_objeto.Ficha_FactRieF012, "X", "")
        .Cells(2, 11).value = IIf(_objeto.Ficha_FactRieF013, "X", "")
        .Cells(2, 12).value = IIf(_objeto.Ficha_FactRieF014, "X", "")
        .Cells(2, 13).value = IIf(_objeto.Ficha_FactRieF021, "X", "")
        .Cells(2, 14).value = IIf(_objeto.Ficha_FactRieF022, "X", "")
        .Cells(2, 15).value = IIf(_objeto.Ficha_FactRieF023, "X", "")
        .Cells(2, 16).value = IIf(_objeto.Ficha_FactRieF024, "X", "")
        .Cells(2, 17).value = IIf(_objeto.Ficha_FactRieF031, "X", "")
        .Cells(2, 18).value = IIf(_objeto.Ficha_FactRieF032, "X", "")
        .Cells(2, 19).value = IIf(_objeto.Ficha_FactRieF033, "X", "")
        .Cells(2, 20).value = IIf(_objeto.Ficha_FactRieF034, "X", "")
        .Cells(2, 21).value = IIf(_objeto.Ficha_FactRieF041, "X", "")
        .Cells(2, 22).value = IIf(_objeto.Ficha_FactRieF042, "X", "")
        .Cells(2, 23).value = IIf(_objeto.Ficha_FactRieF043, "X", "")
        .Cells(2, 24).value = IIf(_objeto.Ficha_FactRieF044, "X", "")
        .Cells(2, 25).value = IIf(_objeto.Ficha_FactRieF051, "X", "")
        .Cells(2, 26).value = IIf(_objeto.Ficha_FactRieF052, "X", "")
        .Cells(2, 27).value = IIf(_objeto.Ficha_FactRieF053, "X", "")
        .Cells(2, 28).value = IIf(_objeto.Ficha_FactRieF054, "X", "")
        .Cells(2, 29).value = IIf(_objeto.Ficha_FactRieF061, "X", "")
        .Cells(2, 30).value = IIf(_objeto.Ficha_FactRieF062, "X", "")
        .Cells(2, 31).value = IIf(_objeto.Ficha_FactRieF063, "X", "")
        .Cells(2, 32).value = IIf(_objeto.Ficha_FactRieF064, "X", "")
        .Cells(2, 33).value = IIf(_objeto.Ficha_FactRieF071, "X", "")
        .Cells(2, 34).value = IIf(_objeto.Ficha_FactRieF072, "X", "")
        .Cells(2, 35).value = IIf(_objeto.Ficha_FactRieF073, "X", "")
        .Cells(2, 36).value = IIf(_objeto.Ficha_FactRieF074, "X", "")
        .Cells(2, 37).value = IIf(_objeto.Ficha_FactRieF081, "X", "")
        .Cells(2, 38).value = IIf(_objeto.Ficha_FactRieF082, "X", "")
        .Cells(2, 39).value = IIf(_objeto.Ficha_FactRieF083, "X", "")
        .Cells(2, 40).value = IIf(_objeto.Ficha_FactRieF084, "X", "")
        .Cells(2, 41).value = IIf(_objeto.Ficha_FactRieF091, "X", "")
        .Cells(2, 42).value = IIf(_objeto.Ficha_FactRieF092, "X", "")
        .Cells(2, 43).value = IIf(_objeto.Ficha_FactRieF093, "X", "")
        .Cells(2, 44).value = IIf(_objeto.Ficha_FactRieF094, "X", "")
        .Cells(2, 45).value = IIf(_objeto.Ficha_FactRieF101, "X", "")
        .Cells(2, 46).value = IIf(_objeto.Ficha_FactRieF102, "X", "")
        .Cells(2, 47).value = IIf(_objeto.Ficha_FactRieF103, "X", "")
        .Cells(2, 48).value = IIf(_objeto.Ficha_FactRieF104, "X", "")
        .Cells(2, 49).value = IIf(_objeto.Ficha_FactRieM011, "X", "")
        .Cells(2, 50).value = IIf(_objeto.Ficha_FactRieM012, "X", "")
        .Cells(2, 51).value = IIf(_objeto.Ficha_FactRieM013, "X", "")
        .Cells(2, 52).value = IIf(_objeto.Ficha_FactRieM014, "X", "")
        .Cells(2, 53).value = IIf(_objeto.Ficha_FactRieM021, "X", "")
        .Cells(2, 54).value = IIf(_objeto.Ficha_FactRieM022, "X", "")
        .Cells(2, 55).value = IIf(_objeto.Ficha_FactRieM023, "X", "")
        .Cells(2, 56).value = IIf(_objeto.Ficha_FactRieM024, "X", "")
        .Cells(2, 57).value = IIf(_objeto.Ficha_FactRieM031, "X", "")
        .Cells(2, 58).value = IIf(_objeto.Ficha_FactRieM032, "X", "")
        .Cells(2, 59).value = IIf(_objeto.Ficha_FactRieM033, "X", "")
        .Cells(2, 60).value = IIf(_objeto.Ficha_FactRieM034, "X", "")
        .Cells(2, 61).value = IIf(_objeto.Ficha_FactRieM041, "X", "")
        .Cells(2, 62).value = IIf(_objeto.Ficha_FactRieM042, "X", "")
        .Cells(2, 63).value = IIf(_objeto.Ficha_FactRieM043, "X", "")
        .Cells(2, 64).value = IIf(_objeto.Ficha_FactRieM044, "X", "")
        .Cells(2, 65).value = IIf(_objeto.Ficha_FactRieM051, "X", "")
        .Cells(2, 66).value = IIf(_objeto.Ficha_FactRieM052, "X", "")
        .Cells(2, 67).value = IIf(_objeto.Ficha_FactRieM053, "X", "")
        .Cells(2, 68).value = IIf(_objeto.Ficha_FactRieM054, "X", "")
        .Cells(2, 69).value = IIf(_objeto.Ficha_FactRieM061, "X", "")
        .Cells(2, 70).value = IIf(_objeto.Ficha_FactRieM062, "X", "")
        .Cells(2, 71).value = IIf(_objeto.Ficha_FactRieM063, "X", "")
        .Cells(2, 72).value = IIf(_objeto.Ficha_FactRieM064, "X", "")
        .Cells(2, 73).value = IIf(_objeto.Ficha_FactRieM071, "X", "")
        .Cells(2, 74).value = IIf(_objeto.Ficha_FactRieM072, "X", "")
        .Cells(2, 75).value = IIf(_objeto.Ficha_FactRieM073, "X", "")
        .Cells(2, 76).value = IIf(_objeto.Ficha_FactRieM074, "X", "")
        .Cells(2, 77).value = IIf(_objeto.Ficha_FactRieM081, "X", "")
        .Cells(2, 78).value = IIf(_objeto.Ficha_FactRieM082, "X", "")
        .Cells(2, 79).value = IIf(_objeto.Ficha_FactRieM083, "X", "")
        .Cells(2, 80).value = IIf(_objeto.Ficha_FactRieM084, "X", "")
        .Cells(2, 81).value = IIf(_objeto.Ficha_FactRieM091, "X", "")
        .Cells(2, 82).value = IIf(_objeto.Ficha_FactRieM092, "X", "")
        .Cells(2, 83).value = IIf(_objeto.Ficha_FactRieM093, "X", "")
        .Cells(2, 84).value = IIf(_objeto.Ficha_FactRieM094, "X", "")
        .Cells(2, 85).value = IIf(_objeto.Ficha_FactRieM101, "X", "")
        .Cells(2, 86).value = IIf(_objeto.Ficha_FactRieM102, "X", "")
        .Cells(2, 87).value = IIf(_objeto.Ficha_FactRieM103, "X", "")
        .Cells(2, 88).value = IIf(_objeto.Ficha_FactRieM104, "X", "")

        .Cells(2, 89).value = IIf(_objeto.Ficha_FactRieM111, "X", "")
        .Cells(2, 90).value = IIf(_objeto.Ficha_FactRieM112, "X", "")
        .Cells(2, 91).value = IIf(_objeto.Ficha_FactRieM113, "X", "")
        .Cells(2, 92).value = IIf(_objeto.Ficha_FactRieM114, "X", "")
        .Cells(2, 93).value = IIf(_objeto.Ficha_FactRieM121, "X", "")
        .Cells(2, 94).value = IIf(_objeto.Ficha_FactRieM122, "X", "")
        .Cells(2, 95).value = IIf(_objeto.Ficha_FactRieM123, "X", "")
        .Cells(2, 96).value = IIf(_objeto.Ficha_FactRieM124, "X", "")
        .Cells(2, 97).value = IIf(_objeto.Ficha_FactRieM131, "X", "")
        .Cells(2, 98).value = IIf(_objeto.Ficha_FactRieM132, "X", "")
        .Cells(2, 99).value = IIf(_objeto.Ficha_FactRieM133, "X", "")
        .Cells(2, 100).value = IIf(_objeto.Ficha_FactRieM134, "X", "")
        .Cells(2, 101).value = IIf(_objeto.Ficha_FactRieM141, "X", "")
        .Cells(2, 102).value = IIf(_objeto.Ficha_FactRieM142, "X", "")
        .Cells(2, 103).value = IIf(_objeto.Ficha_FactRieM143, "X", "")
        .Cells(2, 104).value = IIf(_objeto.Ficha_FactRieM144, "X", "")
        .Cells(2, 105).value = IIf(_objeto.Ficha_FactRieM151, "X", "")
        .Cells(2, 106).value = IIf(_objeto.Ficha_FactRieM152, "X", "")
        .Cells(2, 107).value = IIf(_objeto.Ficha_FactRieM153, "X", "")
        .Cells(2, 108).value = IIf(_objeto.Ficha_FactRieM154, "X", "")


        .Cells(2, 109).value = IIf(_objeto.Ficha_FactRieQ011, "X", "")
        .Cells(2, 110).value = IIf(_objeto.Ficha_FactRieQ012, "X", "")
        .Cells(2, 111).value = IIf(_objeto.Ficha_FactRieQ013, "X", "")
        .Cells(2, 112).value = IIf(_objeto.Ficha_FactRieQ014, "X", "")
        .Cells(2, 113).value = IIf(_objeto.Ficha_FactRieQ021, "X", "")
        .Cells(2, 114).value = IIf(_objeto.Ficha_FactRieQ022, "X", "")
        .Cells(2, 115).value = IIf(_objeto.Ficha_FactRieQ023, "X", "")
        .Cells(2, 116).value = IIf(_objeto.Ficha_FactRieQ024, "X", "")
        .Cells(2, 117).value = IIf(_objeto.Ficha_FactRieQ031, "X", "")
        .Cells(2, 118).value = IIf(_objeto.Ficha_FactRieQ032, "X", "")
        .Cells(2, 119).value = IIf(_objeto.Ficha_FactRieQ033, "X", "")
        .Cells(2, 120).value = IIf(_objeto.Ficha_FactRieQ034, "X", "")
        .Cells(2, 121).value = IIf(_objeto.Ficha_FactRieQ041, "X", "")
        .Cells(2, 122).value = IIf(_objeto.Ficha_FactRieQ042, "X", "")
        .Cells(2, 123).value = IIf(_objeto.Ficha_FactRieQ043, "X", "")
        .Cells(2, 124).value = IIf(_objeto.Ficha_FactRieQ044, "X", "")
        .Cells(2, 125).value = IIf(_objeto.Ficha_FactRieQ051, "X", "")
        .Cells(2, 126).value = IIf(_objeto.Ficha_FactRieQ052, "X", "")
        .Cells(2, 127).value = IIf(_objeto.Ficha_FactRieQ053, "X", "")
        .Cells(2, 128).value = IIf(_objeto.Ficha_FactRieQ054, "X", "")
        .Cells(2, 129).value = IIf(_objeto.Ficha_FactRieQ061, "X", "")
        .Cells(2, 130).value = IIf(_objeto.Ficha_FactRieQ062, "X", "")
        .Cells(2, 131).value = IIf(_objeto.Ficha_FactRieQ063, "X", "")
        .Cells(2, 132).value = IIf(_objeto.Ficha_FactRieQ064, "X", "")
        .Cells(2, 133).value = IIf(_objeto.Ficha_FactRieQ071, "X", "")
        .Cells(2, 134).value = IIf(_objeto.Ficha_FactRieQ072, "X", "")
        .Cells(2, 135).value = IIf(_objeto.Ficha_FactRieQ073, "X", "")
        .Cells(2, 136).value = IIf(_objeto.Ficha_FactRieQ074, "X", "")
        .Cells(2, 137).value = IIf(_objeto.Ficha_FactRieQ081, "X", "")
        .Cells(2, 138).value = IIf(_objeto.Ficha_FactRieQ082, "X", "")
        .Cells(2, 139).value = IIf(_objeto.Ficha_FactRieQ083, "X", "")
        .Cells(2, 140).value = IIf(_objeto.Ficha_FactRieQ084, "X", "")
        .Cells(2, 141).value = IIf(_objeto.Ficha_FactRieQ091, "X", "")
        .Cells(2, 142).value = IIf(_objeto.Ficha_FactRieQ092, "X", "")
        .Cells(2, 143).value = IIf(_objeto.Ficha_FactRieQ093, "X", "")
        .Cells(2, 144).value = IIf(_objeto.Ficha_FactRieQ094, "X", "")
        .Cells(2, 145).value = IIf(_objeto.Ficha_FactRieB011, "X", "")
        .Cells(2, 146).value = IIf(_objeto.Ficha_FactRieB012, "X", "")
        .Cells(2, 147).value = IIf(_objeto.Ficha_FactRieB013, "X", "")
        .Cells(2, 148).value = IIf(_objeto.Ficha_FactRieB014, "X", "")
        .Cells(2, 149).value = IIf(_objeto.Ficha_FactRieB021, "X", "")
        .Cells(2, 150).value = IIf(_objeto.Ficha_FactRieB022, "X", "")
        .Cells(2, 151).value = IIf(_objeto.Ficha_FactRieB023, "X", "")
        .Cells(2, 152).value = IIf(_objeto.Ficha_FactRieB024, "X", "")
        .Cells(2, 153).value = IIf(_objeto.Ficha_FactRieB031, "X", "")
        .Cells(2, 154).value = IIf(_objeto.Ficha_FactRieB032, "X", "")
        .Cells(2, 155).value = IIf(_objeto.Ficha_FactRieB033, "X", "")
        .Cells(2, 156).value = IIf(_objeto.Ficha_FactRieB034, "X", "")
        .Cells(2, 157).value = IIf(_objeto.Ficha_FactRieB041, "X", "")
        .Cells(2, 158).value = IIf(_objeto.Ficha_FactRieB042, "X", "")
        .Cells(2, 159).value = IIf(_objeto.Ficha_FactRieB043, "X", "")
        .Cells(2, 160).value = IIf(_objeto.Ficha_FactRieB044, "X", "")
        .Cells(2, 161).value = IIf(_objeto.Ficha_FactRieB051, "X", "")
        .Cells(2, 162).value = IIf(_objeto.Ficha_FactRieB052, "X", "")
        .Cells(2, 163).value = IIf(_objeto.Ficha_FactRieB053, "X", "")
        .Cells(2, 164).value = IIf(_objeto.Ficha_FactRieB054, "X", "")
        .Cells(2, 165).value = IIf(_objeto.Ficha_FactRieB061, "X", "")
        .Cells(2, 166).value = IIf(_objeto.Ficha_FactRieB062, "X", "")
        .Cells(2, 167).value = IIf(_objeto.Ficha_FactRieB063, "X", "")
        .Cells(2, 168).value = IIf(_objeto.Ficha_FactRieB064, "X", "")
        .Cells(2, 169).value = IIf(_objeto.Ficha_FactRieB071, "X", "")
        .Cells(2, 170).value = IIf(_objeto.Ficha_FactRieB072, "X", "")
        .Cells(2, 171).value = IIf(_objeto.Ficha_FactRieB073, "X", "")
        .Cells(2, 172).value = IIf(_objeto.Ficha_FactRieB074, "X", "")
        .Cells(2, 173).value = IIf(_objeto.Ficha_FactRieE011, "X", "")
        .Cells(2, 174).value = IIf(_objeto.Ficha_FactRieE012, "X", "")
        .Cells(2, 175).value = IIf(_objeto.Ficha_FactRieE013, "X", "")
        .Cells(2, 176).value = IIf(_objeto.Ficha_FactRieE014, "X", "")
        .Cells(2, 177).value = IIf(_objeto.Ficha_FactRieE021, "X", "")
        .Cells(2, 178).value = IIf(_objeto.Ficha_FactRieE022, "X", "")
        .Cells(2, 179).value = IIf(_objeto.Ficha_FactRieE023, "X", "")
        .Cells(2, 180).value = IIf(_objeto.Ficha_FactRieE024, "X", "")
        .Cells(2, 181).value = IIf(_objeto.Ficha_FactRieE031, "X", "")
        .Cells(2, 182).value = IIf(_objeto.Ficha_FactRieE032, "X", "")
        .Cells(2, 183).value = IIf(_objeto.Ficha_FactRieE033, "X", "")
        .Cells(2, 184).value = IIf(_objeto.Ficha_FactRieE034, "X", "")
        .Cells(2, 185).value = IIf(_objeto.Ficha_FactRieE041, "X", "")
        .Cells(2, 186).value = IIf(_objeto.Ficha_FactRieE042, "X", "")
        .Cells(2, 187).value = IIf(_objeto.Ficha_FactRieE043, "X", "")
        .Cells(2, 188).value = IIf(_objeto.Ficha_FactRieE044, "X", "")
        .Cells(2, 189).value = IIf(_objeto.Ficha_FactRieE051, "X", "")
        .Cells(2, 190).value = IIf(_objeto.Ficha_FactRieE052, "X", "")
        .Cells(2, 191).value = IIf(_objeto.Ficha_FactRieE053, "X", "")
        .Cells(2, 192).value = IIf(_objeto.Ficha_FactRieE054, "X", "")
        .Cells(2, 193).value = IIf(_objeto.Ficha_FactRieP011, "X", "")
        .Cells(2, 194).value = IIf(_objeto.Ficha_FactRieP012, "X", "")
        .Cells(2, 195).value = IIf(_objeto.Ficha_FactRieP013, "X", "")
        .Cells(2, 196).value = IIf(_objeto.Ficha_FactRieP014, "X", "")
        .Cells(2, 197).value = IIf(_objeto.Ficha_FactRieP021, "X", "")
        .Cells(2, 198).value = IIf(_objeto.Ficha_FactRieP022, "X", "")
        .Cells(2, 199).value = IIf(_objeto.Ficha_FactRieP023, "X", "")
        .Cells(2, 200).value = IIf(_objeto.Ficha_FactRieP024, "X", "")
        .Cells(2, 201).value = IIf(_objeto.Ficha_FactRieP031, "X", "")
        .Cells(2, 202).value = IIf(_objeto.Ficha_FactRieP032, "X", "")
        .Cells(2, 203).value = IIf(_objeto.Ficha_FactRieP033, "X", "")
        .Cells(2, 204).value = IIf(_objeto.Ficha_FactRieP034, "X", "")
        .Cells(2, 205).value = IIf(_objeto.Ficha_FactRieP041, "X", "")
        .Cells(2, 206).value = IIf(_objeto.Ficha_FactRieP042, "X", "")
        .Cells(2, 207).value = IIf(_objeto.Ficha_FactRieP043, "X", "")
        .Cells(2, 208).value = IIf(_objeto.Ficha_FactRieP044, "X", "")
        .Cells(2, 209).value = IIf(_objeto.Ficha_FactRieP051, "X", "")
        .Cells(2, 210).value = IIf(_objeto.Ficha_FactRieP052, "X", "")
        .Cells(2, 211).value = IIf(_objeto.Ficha_FactRieP053, "X", "")
        .Cells(2, 212).value = IIf(_objeto.Ficha_FactRieP054, "X", "")
        .Cells(2, 213).value = IIf(_objeto.Ficha_FactRieP061, "X", "")
        .Cells(2, 214).value = IIf(_objeto.Ficha_FactRieP062, "X", "")
        .Cells(2, 215).value = IIf(_objeto.Ficha_FactRieP063, "X", "")
        .Cells(2, 216).value = IIf(_objeto.Ficha_FactRieP064, "X", "")
        .Cells(2, 217).value = IIf(_objeto.Ficha_FactRieP071, "X", "")
        .Cells(2, 218).value = IIf(_objeto.Ficha_FactRieP072, "X", "")
        .Cells(2, 219).value = IIf(_objeto.Ficha_FactRieP073, "X", "")
        .Cells(2, 220).value = IIf(_objeto.Ficha_FactRieP074, "X", "")
        .Cells(2, 221).value = IIf(_objeto.Ficha_FactRieP081, "X", "")
        .Cells(2, 222).value = IIf(_objeto.Ficha_FactRieP082, "X", "")
        .Cells(2, 223).value = IIf(_objeto.Ficha_FactRieP083, "X", "")
        .Cells(2, 224).value = IIf(_objeto.Ficha_FactRieP084, "X", "")
        .Cells(2, 225).value = IIf(_objeto.Ficha_FactRieP091, "X", "")
        .Cells(2, 226).value = IIf(_objeto.Ficha_FactRieP092, "X", "")
        .Cells(2, 227).value = IIf(_objeto.Ficha_FactRieP093, "X", "")
        .Cells(2, 228).value = IIf(_objeto.Ficha_FactRieP094, "X", "")
        .Cells(2, 229).value = IIf(_objeto.Ficha_FactRieP101, "X", "")
        .Cells(2, 230).value = IIf(_objeto.Ficha_FactRieP102, "X", "")
        .Cells(2, 231).value = IIf(_objeto.Ficha_FactRieP103, "X", "")
        .Cells(2, 232).value = IIf(_objeto.Ficha_FactRieP104, "X", "")
        .Cells(2, 233).value = IIf(_objeto.Ficha_FactRieP111, "X", "")
        .Cells(2, 234).value = IIf(_objeto.Ficha_FactRieP112, "X", "")
        .Cells(2, 235).value = IIf(_objeto.Ficha_FactRieP113, "X", "")
        .Cells(2, 236).value = IIf(_objeto.Ficha_FactRieP114, "X", "")
        .Cells(2, 237).value = IIf(_objeto.Ficha_FactRieP121, "X", "")
        .Cells(2, 238).value = IIf(_objeto.Ficha_FactRieP122, "X", "")
        .Cells(2, 239).value = IIf(_objeto.Ficha_FactRieP123, "X", "")
        .Cells(2, 240).value = IIf(_objeto.Ficha_FactRieP124, "X", "")
        .Cells(2, 241).value = IIf(_objeto.Ficha_FactRieP131, "X", "")
        .Cells(2, 242).value = IIf(_objeto.Ficha_FactRieP132, "X", "")
        .Cells(2, 243).value = IIf(_objeto.Ficha_FactRieP133, "X", "")
        .Cells(2, 244).value = IIf(_objeto.Ficha_FactRieP134, "X", "")
        .Cells(2, 245).value = _objeto.Ficha_FactRieMedPrev1
        .Cells(2, 246).value = _objeto.Ficha_FactRieMedPrev2
        .Cells(2, 247).value = _objeto.Ficha_FactRieMedPrev3
        .Cells(2, 248).value = _objeto.Ficha_FactRieMedPrev4
        .Cells(2, 249).value = _objeto.Ficha_ActExtrLab
        .Cells(2, 250).value = _objeto.Ficha_EnfActual

      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecombinacionpag2.xls"
      Try
        Kill(rutfte)
      Catch ex As Exception
      End Try

      excelBook.SaveAs(Filename:=rutfte)
      excelBook.Close()
      excelApp.Visible = True
      excelApp.Quit()

      Dim WordApp As New Word.Application
      Dim WordDocument As Word.Document = WordApp.Documents.Open(_direccionarchivo)
      'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
      WordApp.Visible = True
      WordDocument.Activate()
      With WordDocument.MailMerge
        .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & _nombreHoja & "$`")
        .ViewMailMergeFieldCodes = False
        .Destination = 0     'nuevo documento
        .SuppressBlankLines = True
        With .DataSource
          .FirstRecord = 1
          .LastRecord = -16
        End With
        .Execute(Pause:=False)
      End With
      WordDocument.ActiveWindow.Close()

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub
  Public Shared Sub CombinarCorrespondenciaFichaPreocupacionalPag3(ByVal _objeto As FichaMedica, ByVal _direccionarchivo As String)
    If Not My.Computer.FileSystem.FileExists(_direccionarchivo) Then
      MsgBox("No existe la carta modelo para realizar la combinación de correspondencia", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _nombreHoja As String = "Hoja1"

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet =
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      _nombreHoja = excelWorksheet.Name

      excelApp.Visible = False
      With excelWorksheet
        .Columns().ColumnWidth = 80
        .Columns.NumberFormat = "@"

        .Cells(1, 1).value = "PIEL"
        .Cells(1, 2).value = "ORGANSENTIDOS"
        .Cells(1, 3).value = "RESPIRATORIO1"
        .Cells(1, 4).value = "CARDIOVASCULAR1"
        .Cells(1, 5).value = "DIGESTIVO"
        .Cells(1, 6).value = "URINARIO"
        .Cells(1, 7).value = "MUSCULOESQUELETO"
        .Cells(1, 8).value = "ENDOCRINO"
        .Cells(1, 9).value = "HEMOLINFATICO"
        .Cells(1, 10).value = "NERVIOSO"

        .Cells(1, 11).value = "CVPRESIONARTEIAL"
        .Cells(1, 12).value = "CVTEMPERATURA"
        .Cells(1, 13).value = "CVFRECCARDIACA"
        .Cells(1, 14).value = "CVSATOXIGEN"
        .Cells(1, 15).value = "CVRESPIRATORIA"
        .Cells(1, 16).value = "CVPESO"
        .Cells(1, 17).value = "CVTALLA"
        .Cells(1, 18).value = "CVIMC"
        .Cells(1, 19).value = "CVPERIMETRABDOMIN"
        .Cells(1, 20).value = "PIELCICATRICES"
        .Cells(1, 21).value = "PIELTATOO"
        .Cells(1, 22).value = "PIELANERAS"
        .Cells(1, 23).value = "OJOSPARPADOS"
        .Cells(1, 24).value = "OJOSCONJUNTIV"
        .Cells(1, 25).value = "OJOSPUPILAS"
        .Cells(1, 26).value = "OJOSCORNEAS"
        .Cells(1, 27).value = "OJOSMOTILIDAD"
        .Cells(1, 28).value = "OIDOAUDEXTERN"
        .Cells(1, 29).value = "OIDOPABELLON"
        .Cells(1, 30).value = "OIDOTIMPANO"
        .Cells(1, 31).value = "FARINGLABIOS"
        .Cells(1, 32).value = "FARINGLENGUA"
        .Cells(1, 33).value = "FARINGFARING"
        .Cells(1, 34).value = "FARINGAMIGDALAS"
        .Cells(1, 35).value = "FARINGDENTA"
        .Cells(1, 36).value = "NARIZTABIQUE"
        .Cells(1, 37).value = "NARIZCORETES"
        .Cells(1, 38).value = "NARIZMUCOSA"
        .Cells(1, 39).value = "NARIZSENOSNASAL"
        .Cells(1, 40).value = "CUELLOTIROIDES"
        .Cells(1, 41).value = "CUELLOMOVILIDAD"
        .Cells(1, 42).value = "TORAXMAMAS"
        .Cells(1, 43).value = "TORAXCORAZON"
        .Cells(1, 44).value = "TORAXPULMON"
        .Cells(1, 45).value = "TORAXPARRILLACOSTAL"
        .Cells(1, 46).value = "ABSVISCERAS"
        .Cells(1, 47).value = "ABSPAREDADS"
        .Cells(1, 48).value = "COLUMNFLEXIBILID"
        .Cells(1, 49).value = "COLUMDESVIACION"
        .Cells(1, 50).value = "COLUMNDOLOR"
        .Cells(1, 51).value = "PELVIS"
        .Cells(1, 52).value = "PELVISGENITAL"
        .Cells(1, 53).value = "EXTREMIDSVASCULAR"
        .Cells(1, 54).value = "EXTREMIDSMIEMBRSUP"
        .Cells(1, 55).value = "EXTREMIDSMIEMBINFE"
        .Cells(1, 56).value = "NERUROFUERZA"
        .Cells(1, 57).value = "NEUROSENSIBILID"
        .Cells(1, 58).value = "NEUROLOGMARCH"
        .Cells(1, 59).value = "NEUROLOGREFLEJ"
        .Cells(1, 60).value = "RIESTRABEXAOBSERVACIONES"
        .Cells(1, 61).value = "RIESTRABEXAMGENERAL1"
        .Cells(1, 62).value = "RIESTRABEXAMGENERAL2"
        .Cells(1, 63).value = "RIESTRABEXAMGENERAL3"
        .Cells(1, 64).value = "RIESTRABEXAMGENERAL4"
        .Cells(1, 65).value = "RIESTRABEXAMFECHA1"
        .Cells(1, 66).value = "RIESTRABEXAMFECHA2"
        .Cells(1, 67).value = "RIESTRABEXAMFECHA3"
        .Cells(1, 68).value = "RIESTRABEXAMFECHA4"
        .Cells(1, 69).value = "RIESTRABEXAMRESULTADO1"
        .Cells(1, 70).value = "RIESTRABEXAMRESULTADO2"
        .Cells(1, 71).value = "RIESTRABEXAMRESULTADO3"
        .Cells(1, 72).value = "RIESTRABEXAMRESULTADO4"
        .Cells(1, 73).value = "RIESTRABEXAMDESCRIP"
        .Cells(1, 74).value = "DIAGNOSTICO1"
        .Cells(1, 75).value = "DIAGNOSTICO2"
        .Cells(1, 76).value = "DIAGNOSTICO3"
        .Cells(1, 77).value = "DIAGNOSTICOCIE1"
        .Cells(1, 78).value = "DIAGNOSTICOCIE2"
        .Cells(1, 79).value = "DIAGNOSTICOCIE3"
        .Cells(1, 80).value = "DIAGNOSTICOPRE1"
        .Cells(1, 81).value = "DIAGNOSTICOPRE2"
        .Cells(1, 82).value = "DIAGNOSTICOPRE3"
        .Cells(1, 83).value = "DIAGNOSTICODEF1"
        .Cells(1, 84).value = "DIAGNOSTICODEF2"
        .Cells(1, 85).value = "DIAGNOSTICODEF3"
        .Cells(1, 86).value = "APTO"
        .Cells(1, 87).value = "APTOOBSER"
        .Cells(1, 88).value = "APTOLIM"
        .Cells(1, 89).value = "NOAPTO"
        .Cells(1, 90).value = "APTOOBSERVAC"
        .Cells(1, 91).value = "APTOLIMITA"
        .Cells(1, 92).value = "TRATAMEINTDESCRIP"
        .Cells(1, 93).value = "DPROFECHA"
        .Cells(1, 94).value = "DPROHORA"
        .Cells(1, 95).value = "DPRONOMAPELL"
        .Cells(1, 96).value = "DPROCODIGO"
        .Cells(1, 97).value = "DPROFIRM"
        .Cells(1, 98).value = "FIRM"



        .Cells(2, 1).value = IIf(_objeto.Ficha_RevOrgSistPiel, "X", "")
        .Cells(2, 2).value = IIf(_objeto.Ficha_RevOrgSistOrg, "X", "")
        .Cells(2, 3).value = IIf(_objeto.Ficha_RevOrgSistResp, "X", "")
        .Cells(2, 4).value = IIf(_objeto.Ficha_RevOrgSistCard, "X", "")
        .Cells(2, 5).value = IIf(_objeto.Ficha_RevOrgSistDig, "X", "")
        .Cells(2, 6).value = IIf(_objeto.Ficha_RevOrgSistGen, "X", "")
        .Cells(2, 7).value = IIf(_objeto.Ficha_RevOrgSistMus, "X", "")
        .Cells(2, 8).value = IIf(_objeto.Ficha_RevOrgSistEnd, "X", "")
        .Cells(2, 9).value = IIf(_objeto.Ficha_RevOrgSistHem, "X", "")
        .Cells(2, 10).value = IIf(_objeto.Ficha_RevOrgSistNerv, "X", "")

        .Cells(2, 11).value = _objeto.Ficha_ConstVitPresArt
        .Cells(2, 12).value = _objeto.Ficha_ConstVitTemp
        .Cells(2, 13).value = _objeto.Ficha_ConstVitFrecCard
        .Cells(2, 14).value = _objeto.Ficha_ConstVitSatOxi
        .Cells(2, 15).value = _objeto.Ficha_ConstVitFrecResp
        .Cells(2, 16).value = _objeto.Ficha_ConstVitPeso
        .Cells(2, 17).value = _objeto.Ficha_ConstVitTalla
        .Cells(2, 18).value = _objeto.Ficha_ConstVitIMC
        .Cells(2, 19).value = _objeto.Ficha_ConstVitPeriAbdo
        .Cells(2, 20).value = IIf(_objeto.Ficha_ExaFis1a, "X", "")
        .Cells(2, 21).value = IIf(_objeto.Ficha_ExaFis1b, "X", "")
        .Cells(2, 22).value = IIf(_objeto.Ficha_ExaFis1c, "X", "")
        .Cells(2, 23).value = IIf(_objeto.Ficha_ExaFis2a, "X", "")
        .Cells(2, 24).value = IIf(_objeto.Ficha_ExaFis2b, "X", "")
        .Cells(2, 25).value = IIf(_objeto.Ficha_ExaFis2c, "X", "")
        .Cells(2, 26).value = IIf(_objeto.Ficha_ExaFis2d, "X", "")
        .Cells(2, 27).value = IIf(_objeto.Ficha_ExaFis2e, "X", "")
        .Cells(2, 28).value = IIf(_objeto.Ficha_ExaFis3a, "X", "")
        .Cells(2, 29).value = IIf(_objeto.Ficha_ExaFis3b, "X", "")
        .Cells(2, 30).value = IIf(_objeto.Ficha_ExaFis3c, "X", "")
        .Cells(2, 31).value = IIf(_objeto.Ficha_ExaFis4a, "X", "")
        .Cells(2, 32).value = IIf(_objeto.Ficha_ExaFis4b, "X", "")
        .Cells(2, 33).value = IIf(_objeto.Ficha_ExaFis4c, "X", "")
        .Cells(2, 34).value = IIf(_objeto.Ficha_ExaFis4d, "X", "")
        .Cells(2, 35).value = IIf(_objeto.Ficha_ExaFis4e, "X", "")
        .Cells(2, 36).value = IIf(_objeto.Ficha_ExaFis5a, "X", "")
        .Cells(2, 37).value = IIf(_objeto.Ficha_ExaFis5b, "X", "")
        .Cells(2, 38).value = IIf(_objeto.Ficha_ExaFis5c, "X", "")
        .Cells(2, 39).value = IIf(_objeto.Ficha_ExaFis5d, "X", "")
        .Cells(2, 40).value = IIf(_objeto.Ficha_ExaFis6a, "X", "")
        .Cells(2, 41).value = IIf(_objeto.Ficha_ExaFis6b, "X", "")
        .Cells(2, 42).value = IIf(_objeto.Ficha_ExaFis7a, "X", "")
        .Cells(2, 43).value = IIf(_objeto.Ficha_ExaFis7b, "X", "")
        .Cells(2, 44).value = IIf(_objeto.Ficha_ExaFis8a, "X", "")
        .Cells(2, 45).value = IIf(_objeto.Ficha_ExaFis8b, "X", "")
        .Cells(2, 46).value = IIf(_objeto.Ficha_ExaFis9a, "X", "")
        .Cells(2, 47).value = IIf(_objeto.Ficha_ExaFis9b, "X", "")
        .Cells(2, 48).value = IIf(_objeto.Ficha_ExaFis10a, "X", "")
        .Cells(2, 49).value = IIf(_objeto.Ficha_ExaFis10b, "X", "")
        .Cells(2, 50).value = IIf(_objeto.Ficha_ExaFis10c, "X", "")
        .Cells(2, 51).value = IIf(_objeto.Ficha_ExaFis11a, "X", "")
        .Cells(2, 52).value = IIf(_objeto.Ficha_ExaFis11b, "X", "")
        .Cells(2, 53).value = IIf(_objeto.Ficha_ExaFis12a, "X", "")
        .Cells(2, 54).value = IIf(_objeto.Ficha_ExaFis12b, "X", "")
        .Cells(2, 55).value = IIf(_objeto.Ficha_ExaFis12c, "X", "")
        .Cells(2, 56).value = IIf(_objeto.Ficha_ExaFis13a, "X", "")
        .Cells(2, 57).value = IIf(_objeto.Ficha_ExaFis13b, "X", "")
        .Cells(2, 58).value = IIf(_objeto.Ficha_ExaFis13c, "X", "")
        .Cells(2, 59).value = IIf(_objeto.Ficha_ExaFis13d, "X", "")
        .Cells(2, 60).value = _objeto.Ficha_ExaFisObservacion
        .Cells(2, 61).value = _objeto.Ficha_ResExaGen1
        .Cells(2, 62).value = _objeto.Ficha_ResExaGen2
        .Cells(2, 63).value = _objeto.Ficha_ResExaGen3
        .Cells(2, 64).value = _objeto.Ficha_ResExaGen4
        .Cells(2, 65).value = _objeto.Ficha_ResExaGenFec1.ToString("yyyy/MM/dd")
        .Cells(2, 66).value = _objeto.Ficha_ResExaGenFec2.ToString("yyyy/MM/dd")
        .Cells(2, 67).value = _objeto.Ficha_ResExaGenFec3.ToString("yyyy/MM/dd")
        .Cells(2, 68).value = _objeto.Ficha_ResExaGenFec4.ToString("yyyy/MM/dd")
        .Cells(2, 69).value = _objeto.Ficha_ResExaGenRes1
        .Cells(2, 70).value = _objeto.Ficha_ResExaGenRes2
        .Cells(2, 71).value = _objeto.Ficha_ResExaGenRes3
        .Cells(2, 72).value = _objeto.Ficha_ResExaGenRes4
        .Cells(2, 73).value = _objeto.Ficha_ResExaGenObservacion
        .Cells(2, 74).value = _objeto.Ficha_Diag1
        .Cells(2, 75).value = _objeto.Ficha_Diag2
        .Cells(2, 76).value = _objeto.Ficha_Diag3
        .Cells(2, 77).value = _objeto.Ficha_DiagCIE1
        .Cells(2, 78).value = _objeto.Ficha_DiagCIE2
        .Cells(2, 79).value = _objeto.Ficha_DiagCIE3
        .Cells(2, 80).value = IIf(_objeto.Ficha_DiagDef1, "X", "")
        .Cells(2, 81).value = IIf(_objeto.Ficha_DiagDef1, "", "X")
        .Cells(2, 82).value = IIf(_objeto.Ficha_DiagDef2, "X", "")
        .Cells(2, 83).value = IIf(_objeto.Ficha_DiagDef2, "", "X")
        .Cells(2, 84).value = IIf(_objeto.Ficha_DiagDef3, "X", "")
        .Cells(2, 85).value = IIf(_objeto.Ficha_DiagDef3, "", "X")
        .Cells(2, 86).value = _objeto.Ficha_AptMedApto
        .Cells(2, 87).value = _objeto.Ficha_AptMedAptoenOb
        .Cells(2, 88).value = _objeto.Ficha_AptMedAptoconLim
        .Cells(2, 89).value = _objeto.Ficha_AptMedNoApto
        .Cells(2, 90).value = _objeto.Ficha_AptMedObservacion
        .Cells(2, 91).value = _objeto.Ficha_AptMedLimitacion
        .Cells(2, 92).value = _objeto.Ficha_RecomTratamiento

      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecombinacion.xls"
      Try
        Kill(rutfte)
      Catch ex As Exception
      End Try

      excelBook.SaveAs(Filename:=rutfte)
      excelBook.Close()
      excelApp.Visible = True
      excelApp.Quit()

      Dim WordApp As New Word.Application
      Dim WordDocument As Word.Document = WordApp.Documents.Open(_direccionarchivo)
      'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
      WordApp.Visible = True
      WordDocument.Activate()
      With WordDocument.MailMerge
        .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & _nombreHoja & "$`")
        .ViewMailMergeFieldCodes = False
        .Destination = 0     'nuevo documento
        .SuppressBlankLines = True
        With .DataSource
          .FirstRecord = 1
          .LastRecord = -16
        End With
        .Execute(Pause:=False)
      End With
      WordDocument.ActiveWindow.Close()

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub
  Public Shared Sub CombinarCorrespondenciaFichaOcupacionalPag1(ByVal _objeto As FichaMedica, ByVal _direccionarchivo As String)
    If Not My.Computer.FileSystem.FileExists(_direccionarchivo) Then
      MsgBox("No existe la carta modelo para realizar la combinación de correspondencia", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _nombreHoja As String = "Hoja1"

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet =
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      _nombreHoja = excelWorksheet.Name

      excelApp.Visible = False
      With excelWorksheet
        .Columns().ColumnWidth = 80
        .Columns.NumberFormat = "@"
        .Cells(1, 1).value = "EMPRESA"
        .Cells(1, 2).value = "RUC"
        .Cells(1, 3).value = "CIU"
        .Cells(1, 4).value = "CLINICA"
        .Cells(1, 5).value = "CLINICANUM"
        .Cells(1, 6).value = "ARCHIVONUM"
        .Cells(1, 7).value = "APELLIDOPAT"
        .Cells(1, 8).value = "APELLIDOMAT"
        .Cells(1, 9).value = "NOMBRE1"
        .Cells(1, 10).value = "NOMBRE2"
        .Cells(1, 11).value = "SEXO"
        .Cells(1, 12).value = "PUESTTRABAJ"
        .Cells(1, 13).value = "MOTIVCONSUL"
        .Cells(1, 14).value = "ASN"
        .Cells(1, 15).value = "CONSTABACOSI"
        .Cells(1, 16).value = "CONSTABACONO"
        .Cells(1, 17).value = "CONSALCOHOLSI"
        .Cells(1, 18).value = "CONSUALCOHOLNO"
        .Cells(1, 19).value = "OTRDROGSI"
        .Cells(1, 20).value = "OTRDRO2GSI"
        .Cells(1, 21).value = "OTRDROGNO"
        .Cells(1, 22).value = "OTRDROG2NO"
        .Cells(1, 23).value = "CONSTABACOTIEMPO"
        .Cells(1, 24).value = "CONSALCOHOLTIEMPO"
        .Cells(1, 25).value = "CONSOTRDROGTIEMPO"
        .Cells(1, 26).value = "CONSOTRDROG2TIEMPO"
        .Cells(1, 27).value = "CONSTABACOCANTIDAD"
        .Cells(1, 28).value = "CONSALCOHOLCANTIDAD"
        .Cells(1, 29).value = "CONSOTRDROGCANTIDAD"
        .Cells(1, 30).value = "CONSOTRDROG2CANTIDAD"
        .Cells(1, 31).value = "EXCONSUTABACO"
        .Cells(1, 32).value = "EXCONSUALCOHOL"
        .Cells(1, 33).value = "EXCONSUOTRDROG"
        .Cells(1, 34).value = "EXCONSUOTRDROG2"
        .Cells(1, 35).value = "TIEMPABSTINENCIATABACO"
        .Cells(1, 36).value = "TIEMPABSTINENCIAALCOHOL"
        .Cells(1, 37).value = "TIEMPABSTINENCIAOTRDROG"
        .Cells(1, 38).value = "TIEMPABSTINENCIAOTRDROG2"
        .Cells(1, 39).value = "ACTFISICASI"
        .Cells(1, 40).value = "ACTFISICANO"
        .Cells(1, 41).value = "MEDICHABITSI"
        .Cells(1, 42).value = "MEDICHABITNO"
        .Cells(1, 43).value = "ACTFISICADESCRP"
        .Cells(1, 44).value = "MEDICHABITDESCRIP"
        .Cells(1, 45).value = "MEDICHABITDESCRIP2"
        .Cells(1, 46).value = "MEDICHABITDESCRIP3"
        .Cells(1, 47).value = "ACTFISICSEMANAL"
        .Cells(1, 48).value = "MEDHABITCANTIDAD"
        .Cells(1, 49).value = "MEDHABITCANTIDAD2"
        .Cells(1, 50).value = "MEDHABITCANTIDAD3"
        .Cells(1, 51).value = "CANTEINCID"
        .Cells(1, 52).value = "ANTECCALIFIESS"
        .Cells(1, 53).value = "ANTECALIFIESSSI"
        .Cells(1, 54).value = "ANTECCALIFIESSESPE"
        .Cells(1, 55).value = "ANTECALIFNO"
        .Cells(1, 56).value = "ANTECALIFFECHA"
        .Cells(1, 57).value = "ENFERMEDADESCALIFIESS"
        .Cells(1, 58).value = "ENFERMEDADESCALIFIESSSI"
        .Cells(1, 59).value = "ENFERMEDADESCALIFIESSESPE"
        .Cells(1, 60).value = "ENFERMEDADESCALIFNO"
        .Cells(1, 61).value = "ENFERMEDADESCALIFIESSFECH"
        .Cells(1, 62).value = "ENFCARDIOVASCULAR"
        .Cells(1, 63).value = "ENFMETABOLICA"
        .Cells(1, 64).value = "ENFNEUROLOG"
        .Cells(1, 65).value = "ENFONCOLOG"
        .Cells(1, 66).value = "ENFINFECC"
        .Cells(1, 67).value = "ENFHEREDITAR"
        .Cells(1, 68).value = "AFDISCAPACIDAD"
        .Cells(1, 69).value = "AFOTROS"
        .Cells(1, 70).value = "AFDESCRIP"

        .Cells(2, 1).value = _objeto.Contrato.Patrono.NombreCompleto
        .Cells(2, 2).value = _objeto.Contrato.Patrono.Ruc
        .Cells(2, 3).value = _objeto.Contrato.Patrono.Ciudad.Descripcion
        .Cells(2, 4).value = _objeto.PardetClinica.Pardet_Descripcion
        .Cells(2, 5).value = _objeto.PardetClinica.Pardet_DatoStr1
        .Cells(2, 6).value = _objeto.Ficha_ArchivoNum
        .Cells(2, 7).value = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Apellidopaterno
        .Cells(2, 8).value = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Apellidomaterno
        Dim nombre1 As String = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Nombres.Trim().Split(" ").FirstOrDefault()
        Dim nombre2 As String = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Nombres.Trim()
        nombre2 = nombre2.Remove(0, Len(nombre1)).Trim()
        .Cells(2, 9).value = nombre1
        .Cells(2, 10).value = nombre2
        .Cells(2, 11).value = _objeto.Contrato.Empleado.Entidadnatural.PardetSexoString
        .Cells(2, 12).value = _objeto.Contrato.PardetArea.Pardet_DatoStr1
        .Cells(2, 13).value = _objeto.Ficha_MotivoConsulta
        .Cells(2, 14).value = _objeto.Ficha_Antecedentes
        .Cells(2, 15).value = IIf(_objeto.Ficha_Tabaco, "X", "")
        .Cells(2, 16).value = IIf(_objeto.Ficha_Tabaco, "", "X")
        .Cells(2, 17).value = IIf(_objeto.Ficha_Alcohol, "X", "")
        .Cells(2, 18).value = IIf(_objeto.Ficha_Alcohol, "", "X")
        .Cells(2, 19).value = IIf(_objeto.Ficha_Droga1, "X", "")
        .Cells(2, 20).value = IIf(_objeto.Ficha_Droga2, "X", "")
        .Cells(2, 21).value = IIf(_objeto.Ficha_Droga1, "", "X")
        .Cells(2, 22).value = IIf(_objeto.Ficha_Droga2, "", "X")
        .Cells(2, 23).value = _objeto.Ficha_TabacoTiempo
        .Cells(2, 24).value = _objeto.Ficha_AlcoholTiempo
        .Cells(2, 25).value = _objeto.Ficha_Droga1Tiempo
        .Cells(2, 26).value = _objeto.Ficha_Droga2Tiempo
        .Cells(2, 27).value = _objeto.Ficha_TabacoCantidad
        .Cells(2, 28).value = _objeto.Ficha_AlcoholCantidad
        .Cells(2, 29).value = _objeto.Ficha_Droga1Cantidad
        .Cells(2, 30).value = _objeto.Ficha_Droga2Cantidad
        .Cells(2, 31).value = IIf(_objeto.Ficha_TabacoExConsumidor, "X", "")
        .Cells(2, 32).value = IIf(_objeto.Ficha_AlcoholExConsumidor, "X", "")
        .Cells(2, 33).value = IIf(_objeto.Ficha_Droga1ExConsumidor, "X", "")
        .Cells(2, 34).value = IIf(_objeto.Ficha_Droga2ExConsumidor, "X", "")
        .Cells(2, 35).value = _objeto.Ficha_TabacoTiempoAbstinencia
        .Cells(2, 36).value = _objeto.Ficha_AlcoholTiempoAbstinencia
        .Cells(2, 37).value = _objeto.Ficha_Droga1TiempoAbstinencia
        .Cells(2, 38).value = _objeto.Ficha_Droga2TiempoAbstinencia
        .Cells(2, 39).value = IIf(_objeto.Ficha_ActivFisica, "X", "")
        .Cells(2, 40).value = IIf(_objeto.Ficha_ActivFisica, "", "X")
        .Cells(2, 41).value = IIf(_objeto.Ficha_MedicHabit, "X", "")
        .Cells(2, 42).value = IIf(_objeto.Ficha_MedicHabit, "", "X")
        .Cells(2, 43).value = _objeto.Ficha_ActivFisicaDescripcion
        .Cells(2, 44).value = _objeto.Ficha_MedicHabitDescripcion1
        .Cells(2, 45).value = _objeto.Ficha_MedicHabitDescripcion2
        .Cells(2, 46).value = _objeto.Ficha_MedicHabitDescripcion3
        .Cells(2, 47).value = _objeto.Ficha_ActivFisicaTiempoSemanal
        .Cells(2, 48).value = _objeto.Ficha_MedicHabitCantidad1
        .Cells(2, 49).value = _objeto.Ficha_MedicHabitCantidad2
        .Cells(2, 50).value = _objeto.Ficha_MedicHabitCantidad3
        .Cells(2, 51).value = _objeto.Ficha_Incidentes
        .Cells(2, 52).value = _objeto.Ficha_AntTrabCalifObservacion
        .Cells(2, 53).value = _objeto.Ficha_AntTrabCalif
        .Cells(2, 54).value = _objeto.Ficha_AntTrabCalifDescripcion
        .Cells(2, 55).value = _objeto.Ficha_AntTrabCalifNoReportado
        .Cells(2, 56).value = _objeto.Ficha_AntTrabCalifFecha.ToString("yyyy/MM/dd")
        .Cells(2, 57).value = _objeto.Ficha_EnfProfCalifObservacion
        .Cells(2, 58).value = _objeto.Ficha_EnfProfCalif
        .Cells(2, 59).value = _objeto.Ficha_EnfProfCalifDescripcion
        .Cells(2, 60).value = _objeto.Ficha_EnfProfCalifNoReportado
        .Cells(2, 61).value = _objeto.Ficha_EnfProfCalifFecha.ToString("yyyy/MM/dd")
        .Cells(2, 62).value = IIf(_objeto.Ficha_AntFamEnfCard, "X", "")
        .Cells(2, 63).value = IIf(_objeto.Ficha_AntFamEnfMet, "X", "")
        .Cells(2, 64).value = IIf(_objeto.Ficha_AntFamEnfNeu, "X", "")
        .Cells(2, 65).value = IIf(_objeto.Ficha_AntFamEnfOnc, "X", "")
        .Cells(2, 66).value = IIf(_objeto.Ficha_AntFamEnfInf, "X", "")
        .Cells(2, 67).value = IIf(_objeto.Ficha_AntFamEnfHer, "X", "")
        .Cells(2, 68).value = IIf(_objeto.Ficha_AntFamEnfDisc, "X", "")
        .Cells(2, 69).value = IIf(_objeto.Ficha_AntFamEnfOtro, "X", "")
        .Cells(2, 70).value = _objeto.Ficha_AntFamObservacion

      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecombinacion.xls"
      Try
        Kill(rutfte)
      Catch ex As Exception
      End Try

      excelBook.SaveAs(Filename:=rutfte)
      excelBook.Close()
      excelApp.Visible = True
      excelApp.Quit()

      Dim WordApp As New Word.Application
      Dim WordDocument As Word.Document = WordApp.Documents.Open(_direccionarchivo)
      'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
      WordApp.Visible = True
      WordDocument.Activate()
      With WordDocument.MailMerge
        .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & _nombreHoja & "$`")
        .ViewMailMergeFieldCodes = False
        .Destination = 0     'nuevo documento
        .SuppressBlankLines = True
        With .DataSource
          .FirstRecord = 1
          .LastRecord = -16
        End With
        .Execute(Pause:=False)
      End With
      WordDocument.ActiveWindow.Close()

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub
  Public Shared Sub CombinarCorrespondenciaFichaOcupacionalPag2(ByVal _objeto As FichaMedica, ByVal _direccionarchivo As String)
    If Not My.Computer.FileSystem.FileExists(_direccionarchivo) Then
      MsgBox("No existe la carta modelo para realizar la combinación de correspondencia", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _nombreHoja As String = "Hoja1"

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet =
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      _nombreHoja = excelWorksheet.Name

      excelApp.Visible = False
      With excelWorksheet
        .Columns().ColumnWidth = 80
        .Columns.NumberFormat = "@"
        .Cells(1, 1).value = "RIESGACTUALPUESTTRABAJ1"
        .Cells(1, 2).value = "RIESGACTUALPUESTTRABAJ2"
        .Cells(1, 3).value = "RIESGACTUALPUESTTRABAJ3"
        .Cells(1, 4).value = "RIESGACTUALPUESTTRABAJ4"
        .Cells(1, 5).value = "RIESGACTUALACTIVIDADES1"
        .Cells(1, 6).value = "RIESGACTUALACTIVIDADES2"
        .Cells(1, 7).value = "RIESGACTUALACTIVIDADES3"
        .Cells(1, 8).value = "RIESGACTUALACTIVIDADES4"
        .Cells(1, 9).value = "FISCTEMALTA1"
        .Cells(1, 10).value = "FISCTEMALTA2"
        .Cells(1, 11).value = "FISCTEMALTA3"
        .Cells(1, 12).value = "FISCTEMALTA4"
        .Cells(1, 13).value = "FISCTEMBAJA1"
        .Cells(1, 14).value = "FISCTEMBAJA2"
        .Cells(1, 15).value = "FISCTEMBAJA3"
        .Cells(1, 16).value = "FISCTEMBAJA4"
        .Cells(1, 17).value = "FISCRADIAC1"
        .Cells(1, 18).value = "FISCRADIAC2"
        .Cells(1, 19).value = "FISCRADIAC3"
        .Cells(1, 20).value = "FISCRADIAC4"
        .Cells(1, 21).value = "FISCRADIANOLONIZANT1"
        .Cells(1, 22).value = "FISCRADIANOLONIZANT2"
        .Cells(1, 23).value = "FISCRADIANOLONIZANT3"
        .Cells(1, 24).value = "FISCRADIANOLONIZANT4"
        .Cells(1, 25).value = "FISCRUIDO1"
        .Cells(1, 26).value = "FISCRUIDO2"
        .Cells(1, 27).value = "FISCRUIDO3"
        .Cells(1, 28).value = "FISCRUIDO4"
        .Cells(1, 29).value = "FISICVIBRACION1"
        .Cells(1, 30).value = "FISICVIBRACION2"
        .Cells(1, 31).value = "FISICVIBRACION3"
        .Cells(1, 32).value = "FISICVIBRACION4"
        .Cells(1, 33).value = "FISICILUMIN1"
        .Cells(1, 34).value = "FISICILUMIN2"
        .Cells(1, 35).value = "FISICILUMIN3"
        .Cells(1, 36).value = "FISICILUMIN4"
        .Cells(1, 37).value = "FISICVENTILA1"
        .Cells(1, 38).value = "FISICVENTILA2"
        .Cells(1, 39).value = "FISICVENTILA3"
        .Cells(1, 40).value = "FISICVENTILA4"
        .Cells(1, 41).value = "FISICFLUIDOELECTRI1"
        .Cells(1, 42).value = "FISICFLUIDOELECTRI2"
        .Cells(1, 43).value = "FISICFLUIDOELECTRI3"
        .Cells(1, 44).value = "FISICFLUIDOELECTRI4"
        .Cells(1, 45).value = "FISICOTRO1"
        .Cells(1, 46).value = "FISICOTRO2"
        .Cells(1, 47).value = "FISICOTRO3"
        .Cells(1, 48).value = "FISICOTRO4"
        .Cells(1, 49).value = "MECANICATRAPAMAQUINA1"
        .Cells(1, 50).value = "MECANICATRAPAMAQUINA2"
        .Cells(1, 51).value = "MECANICATRAPAMAQUINA3"
        .Cells(1, 52).value = "MECANICATRAPAMAQUINA4"
        .Cells(1, 53).value = "MECANICATRAPSUPER1"
        .Cells(1, 54).value = "MECANICATRAPSUPER2"
        .Cells(1, 55).value = "MECANICATRAPSUPER3"
        .Cells(1, 56).value = "MECANICATRAPSUPER4"
        .Cells(1, 57).value = "MECANICATRAPOBJETOS1"
        .Cells(1, 58).value = "MECANICATRAPOBJETOS2"
        .Cells(1, 59).value = "MECANICATRAPOBJETOS3"
        .Cells(1, 60).value = "MECANICATRAPOBJETOS4"

        .Cells(1, 61).value = "MECANICCAIDAOBJETOS1"
        .Cells(1, 62).value = "MECANICCAIDAOBJETOS2"
        .Cells(1, 63).value = "MECANICCAIDAOBJETOS3"
        .Cells(1, 64).value = "MECANICCAIDAOBJETOS4"

        .Cells(1, 65).value = "MECANICCAIMISMONIVEL1"
        .Cells(1, 66).value = "MECANICCAIMISMONIVEL2"
        .Cells(1, 67).value = "MECANICCAIMISMONIVEL3"
        .Cells(1, 68).value = "MECANICCAIMISMONIVEL4"
        .Cells(1, 69).value = "MECANICCAIDIFERNIVEL1"
        .Cells(1, 70).value = "MECANICCAIDIFERNIVEL2"
        .Cells(1, 71).value = "MECANICCAIDIFERNIVEL3"
        .Cells(1, 72).value = "MECANICCAIDIFERNIVEL4"
        .Cells(1, 73).value = "MECANICCONTACELECT1"
        .Cells(1, 74).value = "MECANICCONTACELECT2"
        .Cells(1, 75).value = "MECANICCONTACELECT3"
        .Cells(1, 76).value = "MECANICCONTACELECT4"
        .Cells(1, 77).value = "MECANICCONTACSUERFTRABJ1"
        .Cells(1, 78).value = "MECANICCONTACSUERFTRABJ2"
        .Cells(1, 79).value = "MECANICCONTACSUERFTRABJ3"
        .Cells(1, 80).value = "MECANICCONTACSUERFTRABJ4"
        .Cells(1, 81).value = "MECANICPROYECPARTIC1"
        .Cells(1, 82).value = "MECANICPROYECPARTIC2"
        .Cells(1, 83).value = "MECANICPROYECPARTIC3"
        .Cells(1, 84).value = "MECANICPROYECPARTIC4"

        .Cells(1, 85).value = "MECANICPROYECFLU1"
        .Cells(1, 86).value = "MECANICPROYECFLU2"
        .Cells(1, 87).value = "MECANICPROYECFLU3"
        .Cells(1, 88).value = "MECANICPROYECFLU4"
        .Cells(1, 89).value = "MECANICPINCHA1"
        .Cells(1, 90).value = "MECANICPINCHA2"
        .Cells(1, 91).value = "MECANICPINCHA3"
        .Cells(1, 92).value = "MECANICPINCHA4"
        .Cells(1, 93).value = "MECANICCORTES1"
        .Cells(1, 94).value = "MECANICCORTES2"
        .Cells(1, 95).value = "MECANICCORTES3"
        .Cells(1, 96).value = "MECANICCORTES4"
        .Cells(1, 97).value = "MECANICATROPELL1"
        .Cells(1, 98).value = "MECANICATROPELL2"
        .Cells(1, 99).value = "MECANICATROPELL3"
        .Cells(1, 100).value = "MECANICATROPELL4"



        .Cells(1, 101).value = "MECANICCHOQUEVEHIC1"
        .Cells(1, 102).value = "MECANICCHOQUEVEHIC2"
        .Cells(1, 103).value = "MECANICCHOQUEVEHIC3"
        .Cells(1, 104).value = "MECANICCHOQUEVEHIC4"
        .Cells(1, 105).value = "MECANICOTRO1"
        .Cells(1, 106).value = "MECANICOTRO2"
        .Cells(1, 107).value = "MECANICOTRO3"
        .Cells(1, 108).value = "MECANICOTRO4"

        .Cells(1, 109).value = "QQSOLIDO1"
        .Cells(1, 110).value = "QQSOLIDO2"
        .Cells(1, 111).value = "QQSOLIDO3"
        .Cells(1, 112).value = "QQSOLIDO4"
        .Cells(1, 113).value = "QQPOLVO1"
        .Cells(1, 114).value = "QQPOLVO2"
        .Cells(1, 115).value = "QQPOLVO3"
        .Cells(1, 116).value = "QQPOLVO4"
        .Cells(1, 117).value = "QQHUMO1"
        .Cells(1, 118).value = "QQHUMO2"
        .Cells(1, 119).value = "QQHUMO3"
        .Cells(1, 120).value = "QQHUMO4"
        .Cells(1, 121).value = "QQLIQUID1"
        .Cells(1, 122).value = "QQLIQUID2"
        .Cells(1, 123).value = "QQLIQUID3"
        .Cells(1, 124).value = "QQLIQUID4"
        .Cells(1, 125).value = "QQVAPOR1"
        .Cells(1, 126).value = "QQVAPOR2"
        .Cells(1, 127).value = "QQVAPOR3"
        .Cells(1, 128).value = "QQVAPOR4"
        .Cells(1, 129).value = "QQAEROSOL1"
        .Cells(1, 130).value = "QQAEROSOL2"
        .Cells(1, 131).value = "QQAEROSOL3"
        .Cells(1, 132).value = "QQAEROSOL4"
        .Cells(1, 133).value = "QQNEBLINA1"
        .Cells(1, 134).value = "QQNEBLINA2"
        .Cells(1, 135).value = "QQNEBLINA3"
        .Cells(1, 136).value = "QQNEBLINA4"
        .Cells(1, 137).value = "QQGASES1"
        .Cells(1, 138).value = "QQGASES2"
        .Cells(1, 139).value = "QQGASES3"
        .Cells(1, 140).value = "QQGASES4"
        .Cells(1, 141).value = "QQOTRO1"
        .Cells(1, 142).value = "QQOTRO2"
        .Cells(1, 143).value = "QQOTRO3"
        .Cells(1, 144).value = "QQOTRO4"
        .Cells(1, 145).value = "BIOLOGVIRUS1"
        .Cells(1, 146).value = "BIOLOGVIRUS2"
        .Cells(1, 147).value = "BIOLOGVIRUS3"
        .Cells(1, 148).value = "BIOLOGVIRUS4"
        .Cells(1, 149).value = "BIOLOGHONGO1"
        .Cells(1, 150).value = "BIOLOGHONGO2"
        .Cells(1, 151).value = "BIOLOGHONGO3"
        .Cells(1, 152).value = "BIOLOGHONGO4"
        .Cells(1, 153).value = "BIOLOGBACTERIA1"
        .Cells(1, 154).value = "BIOLOGBACTERIA2"
        .Cells(1, 155).value = "BIOLOGBACTERIA3"
        .Cells(1, 156).value = "BIOLOGBACTERIA4"
        .Cells(1, 157).value = "BIOLOGPARACIT1"
        .Cells(1, 158).value = "BIOLOGPARACIT2"
        .Cells(1, 159).value = "BIOLOGPARACIT3"
        .Cells(1, 160).value = "BIOLOGPARACIT4"
        .Cells(1, 161).value = "BIOLOGEXPOVECTORES1"
        .Cells(1, 162).value = "BIOLOGEXPOVECTORES2"
        .Cells(1, 163).value = "BIOLOGEXPOVECTORES3"
        .Cells(1, 164).value = "BIOLOGEXPOVECTORES4"

        .Cells(1, 165).value = "BIOLOGEXPOANIMALSELV1"
        .Cells(1, 166).value = "BIOLOGEXPOANIMALSELV2"
        .Cells(1, 167).value = "BIOLOGEXPOANIMALSELV3"
        .Cells(1, 168).value = "BIOLOGEXPOANIMALSELV4"
        .Cells(1, 169).value = "BIOLOGOTROS1"
        .Cells(1, 170).value = "BIOLOGOTROS2"
        .Cells(1, 171).value = "BIOLOGOTROS3"
        .Cells(1, 172).value = "BIOLOGOTROS4"
        .Cells(1, 173).value = "ERGONOMANEJOMANUALCARG1"
        .Cells(1, 174).value = "ERGONOMANEJOMANUALCARG2"
        .Cells(1, 175).value = "ERGONOMANEJOMANUALCARG3"
        .Cells(1, 176).value = "ERGONOMANEJOMANUALCARG14"
        .Cells(1, 177).value = "ERGONOMOVREP1"
        .Cells(1, 178).value = "ERGONOMOVREP2"
        .Cells(1, 179).value = "ERGONOMOVREP3"
        .Cells(1, 180).value = "ERGONOMOVREP4"
        .Cells(1, 181).value = "ERGONOPOSTFORZAD1"
        .Cells(1, 182).value = "ERGONOPOSTFORZAD2"
        .Cells(1, 183).value = "ERGONOPOSTFORZAD3"
        .Cells(1, 184).value = "ERGONOPOSTFORZAD4"
        .Cells(1, 185).value = "ERGONOTRAJPDV1"
        .Cells(1, 186).value = "ERGONOTRAJPDV2"
        .Cells(1, 187).value = "ERGONOTRAJPDV3"
        .Cells(1, 188).value = "ERGONOTRAJPDV4"
        .Cells(1, 189).value = "ERGONOOTRO1"
        .Cells(1, 190).value = "ERGONOOTRO2"
        .Cells(1, 191).value = "ERGONOOTRO3"
        .Cells(1, 192).value = "ERGONOOTRO4"
        .Cells(1, 193).value = "PSICOMONOTONIALABO1"
        .Cells(1, 194).value = "PSICOMONOTONIALABO2"
        .Cells(1, 195).value = "PSICOMONOTONIALABO3"
        .Cells(1, 196).value = "PSICOMONOTONIALABO4"
        .Cells(1, 197).value = "PSICOSOBRECARGLABO1"
        .Cells(1, 198).value = "PSICOSOBRECARGLABO2"
        .Cells(1, 199).value = "PSICOSOBRECARGLABO3"
        .Cells(1, 200).value = "PSICOSOBRECARGLABO4"
        .Cells(1, 201).value = "PSICOMINUCIOSIDADTAREA1"
        .Cells(1, 202).value = "PSICOMINUCIOSIDADTAREA2"
        .Cells(1, 203).value = "PSICOMINUCIOSIDADTAREA3"
        .Cells(1, 204).value = "PSICOMINUCIOSIDADTAREA4"
        .Cells(1, 205).value = "PSICORESPONS1"
        .Cells(1, 206).value = "PSICORESPONS2"
        .Cells(1, 207).value = "PSICORESPONS3"
        .Cells(1, 208).value = "PSICORESPONS4"
        .Cells(1, 209).value = "PSICOTOMADESICION1"
        .Cells(1, 210).value = "PSICOTOMADESICION2"
        .Cells(1, 211).value = "PSICOTOMADESICION3"
        .Cells(1, 212).value = "PSICOTOMADESICION4"
        .Cells(1, 213).value = "PSICOSUPERVDIREC1"
        .Cells(1, 214).value = "PSICOSUPERVDIREC2"
        .Cells(1, 215).value = "PSICOSUPERVDIREC3"
        .Cells(1, 216).value = "PSICOSUPERVDIREC4"
        .Cells(1, 217).value = "PSICOCONFLICTOROL1"
        .Cells(1, 218).value = "PSICOCONFLICTOROL2"
        .Cells(1, 219).value = "PSICOCONFLICTOROL3"
        .Cells(1, 220).value = "PSICOCONFLICTOROL4"
        .Cells(1, 221).value = "PSICOCLARIDFUNCIONES1"
        .Cells(1, 222).value = "PSICOCLARIDFUNCIONES2"
        .Cells(1, 223).value = "PSICOCLARIDFUNCIONES3"
        .Cells(1, 224).value = "PSICOCLARIDFUNCIONES4"
        .Cells(1, 225).value = "PISCOINCORRECDISTRITRABJ1"
        .Cells(1, 226).value = "PISCOINCORRECDISTRITRABJ2"
        .Cells(1, 227).value = "PISCOINCORRECDISTRITRABJ3"
        .Cells(1, 228).value = "PISCOINCORRECDISTRITRABJ4"
        .Cells(1, 229).value = "PSICOTURNOSROT1"
        .Cells(1, 230).value = "PSICOTURNOSROT2"
        .Cells(1, 231).value = "PSICOTURNOSROT3"
        .Cells(1, 232).value = "PSICOTURNOSROT4"
        .Cells(1, 233).value = "PISCORELACINTERPERSON1"
        .Cells(1, 234).value = "PISCORELACINTERPERSON2"
        .Cells(1, 235).value = "PISCORELACINTERPERSON3"
        .Cells(1, 236).value = "PISCORELACINTERPERSON4"
        .Cells(1, 237).value = "PSICOINESTABLABO1"
        .Cells(1, 238).value = "PSICOINESTABLABO2"
        .Cells(1, 239).value = "PSICOINESTABLABO3"
        .Cells(1, 240).value = "PSICOINESTABLABO4"
        .Cells(1, 241).value = "PSICOOTRO1"
        .Cells(1, 242).value = "PSICOOTRO2"
        .Cells(1, 243).value = "PSICOOTRO3"
        .Cells(1, 244).value = "PSICOOTRO4"
        .Cells(1, 245).value = "MEDIDASPREVENTIVAS1"
        .Cells(1, 246).value = "MEDIDASPREVENTIVAS2"
        .Cells(1, 247).value = "MEDIDASPREVENTIVAS3"
        .Cells(1, 248).value = "MEDIDASPREVENTIVAS4"
        .Cells(1, 249).value = "ACTIVEXTRALABO"
        .Cells(1, 250).value = "ENFERMACTUAL1"



        .Cells(2, 1).value = _objeto.Ficha_FactRieArea1
        .Cells(2, 2).value = _objeto.Ficha_FactRieArea2
        .Cells(2, 3).value = _objeto.Ficha_FactRieArea3
        .Cells(2, 4).value = _objeto.Ficha_FactRieArea4
        .Cells(2, 5).value = _objeto.Ficha_FactRieActividad1
        .Cells(2, 6).value = _objeto.Ficha_FactRieActividad2
        .Cells(2, 7).value = _objeto.Ficha_FactRieActividad3
        .Cells(2, 8).value = _objeto.Ficha_FactRieActividad4
        .Cells(2, 9).value = IIf(_objeto.Ficha_FactRieF011, "X", "")
        .Cells(2, 10).value = IIf(_objeto.Ficha_FactRieF012, "X", "")
        .Cells(2, 11).value = IIf(_objeto.Ficha_FactRieF013, "X", "")
        .Cells(2, 12).value = IIf(_objeto.Ficha_FactRieF014, "X", "")
        .Cells(2, 13).value = IIf(_objeto.Ficha_FactRieF021, "X", "")
        .Cells(2, 14).value = IIf(_objeto.Ficha_FactRieF022, "X", "")
        .Cells(2, 15).value = IIf(_objeto.Ficha_FactRieF023, "X", "")
        .Cells(2, 16).value = IIf(_objeto.Ficha_FactRieF024, "X", "")
        .Cells(2, 17).value = IIf(_objeto.Ficha_FactRieF031, "X", "")
        .Cells(2, 18).value = IIf(_objeto.Ficha_FactRieF032, "X", "")
        .Cells(2, 19).value = IIf(_objeto.Ficha_FactRieF033, "X", "")
        .Cells(2, 20).value = IIf(_objeto.Ficha_FactRieF034, "X", "")
        .Cells(2, 21).value = IIf(_objeto.Ficha_FactRieF041, "X", "")
        .Cells(2, 22).value = IIf(_objeto.Ficha_FactRieF042, "X", "")
        .Cells(2, 23).value = IIf(_objeto.Ficha_FactRieF043, "X", "")
        .Cells(2, 24).value = IIf(_objeto.Ficha_FactRieF044, "X", "")
        .Cells(2, 25).value = IIf(_objeto.Ficha_FactRieF051, "X", "")
        .Cells(2, 26).value = IIf(_objeto.Ficha_FactRieF052, "X", "")
        .Cells(2, 27).value = IIf(_objeto.Ficha_FactRieF053, "X", "")
        .Cells(2, 28).value = IIf(_objeto.Ficha_FactRieF054, "X", "")
        .Cells(2, 29).value = IIf(_objeto.Ficha_FactRieF061, "X", "")
        .Cells(2, 30).value = IIf(_objeto.Ficha_FactRieF062, "X", "")
        .Cells(2, 31).value = IIf(_objeto.Ficha_FactRieF063, "X", "")
        .Cells(2, 32).value = IIf(_objeto.Ficha_FactRieF064, "X", "")
        .Cells(2, 33).value = IIf(_objeto.Ficha_FactRieF071, "X", "")
        .Cells(2, 34).value = IIf(_objeto.Ficha_FactRieF072, "X", "")
        .Cells(2, 35).value = IIf(_objeto.Ficha_FactRieF073, "X", "")
        .Cells(2, 36).value = IIf(_objeto.Ficha_FactRieF074, "X", "")
        .Cells(2, 37).value = IIf(_objeto.Ficha_FactRieF081, "X", "")
        .Cells(2, 38).value = IIf(_objeto.Ficha_FactRieF082, "X", "")
        .Cells(2, 39).value = IIf(_objeto.Ficha_FactRieF083, "X", "")
        .Cells(2, 40).value = IIf(_objeto.Ficha_FactRieF084, "X", "")
        .Cells(2, 41).value = IIf(_objeto.Ficha_FactRieF091, "X", "")
        .Cells(2, 42).value = IIf(_objeto.Ficha_FactRieF092, "X", "")
        .Cells(2, 43).value = IIf(_objeto.Ficha_FactRieF093, "X", "")
        .Cells(2, 44).value = IIf(_objeto.Ficha_FactRieF094, "X", "")
        .Cells(2, 45).value = IIf(_objeto.Ficha_FactRieF101, "X", "")
        .Cells(2, 46).value = IIf(_objeto.Ficha_FactRieF102, "X", "")
        .Cells(2, 47).value = IIf(_objeto.Ficha_FactRieF103, "X", "")
        .Cells(2, 48).value = IIf(_objeto.Ficha_FactRieF104, "X", "")
        .Cells(2, 49).value = IIf(_objeto.Ficha_FactRieM011, "X", "")
        .Cells(2, 50).value = IIf(_objeto.Ficha_FactRieM012, "X", "")
        .Cells(2, 51).value = IIf(_objeto.Ficha_FactRieM013, "X", "")
        .Cells(2, 52).value = IIf(_objeto.Ficha_FactRieM014, "X", "")
        .Cells(2, 53).value = IIf(_objeto.Ficha_FactRieM021, "X", "")
        .Cells(2, 54).value = IIf(_objeto.Ficha_FactRieM022, "X", "")
        .Cells(2, 55).value = IIf(_objeto.Ficha_FactRieM023, "X", "")
        .Cells(2, 56).value = IIf(_objeto.Ficha_FactRieM024, "X", "")
        .Cells(2, 57).value = IIf(_objeto.Ficha_FactRieM031, "X", "")
        .Cells(2, 58).value = IIf(_objeto.Ficha_FactRieM032, "X", "")
        .Cells(2, 59).value = IIf(_objeto.Ficha_FactRieM033, "X", "")
        .Cells(2, 60).value = IIf(_objeto.Ficha_FactRieM034, "X", "")
        .Cells(2, 61).value = IIf(_objeto.Ficha_FactRieM041, "X", "")
        .Cells(2, 62).value = IIf(_objeto.Ficha_FactRieM042, "X", "")
        .Cells(2, 63).value = IIf(_objeto.Ficha_FactRieM043, "X", "")
        .Cells(2, 64).value = IIf(_objeto.Ficha_FactRieM044, "X", "")
        .Cells(2, 65).value = IIf(_objeto.Ficha_FactRieM051, "X", "")
        .Cells(2, 66).value = IIf(_objeto.Ficha_FactRieM052, "X", "")
        .Cells(2, 67).value = IIf(_objeto.Ficha_FactRieM053, "X", "")
        .Cells(2, 68).value = IIf(_objeto.Ficha_FactRieM054, "X", "")
        .Cells(2, 69).value = IIf(_objeto.Ficha_FactRieM061, "X", "")
        .Cells(2, 70).value = IIf(_objeto.Ficha_FactRieM062, "X", "")
        .Cells(2, 71).value = IIf(_objeto.Ficha_FactRieM063, "X", "")
        .Cells(2, 72).value = IIf(_objeto.Ficha_FactRieM064, "X", "")
        .Cells(2, 73).value = IIf(_objeto.Ficha_FactRieM071, "X", "")
        .Cells(2, 74).value = IIf(_objeto.Ficha_FactRieM072, "X", "")
        .Cells(2, 75).value = IIf(_objeto.Ficha_FactRieM073, "X", "")
        .Cells(2, 76).value = IIf(_objeto.Ficha_FactRieM074, "X", "")
        .Cells(2, 77).value = IIf(_objeto.Ficha_FactRieM081, "X", "")
        .Cells(2, 78).value = IIf(_objeto.Ficha_FactRieM082, "X", "")
        .Cells(2, 79).value = IIf(_objeto.Ficha_FactRieM083, "X", "")
        .Cells(2, 80).value = IIf(_objeto.Ficha_FactRieM084, "X", "")
        .Cells(2, 81).value = IIf(_objeto.Ficha_FactRieM091, "X", "")
        .Cells(2, 82).value = IIf(_objeto.Ficha_FactRieM092, "X", "")
        .Cells(2, 83).value = IIf(_objeto.Ficha_FactRieM093, "X", "")
        .Cells(2, 84).value = IIf(_objeto.Ficha_FactRieM094, "X", "")
        .Cells(2, 85).value = IIf(_objeto.Ficha_FactRieM101, "X", "")
        .Cells(2, 86).value = IIf(_objeto.Ficha_FactRieM102, "X", "")
        .Cells(2, 87).value = IIf(_objeto.Ficha_FactRieM103, "X", "")
        .Cells(2, 88).value = IIf(_objeto.Ficha_FactRieM104, "X", "")

        .Cells(2, 89).value = IIf(_objeto.Ficha_FactRieM111, "X", "")
        .Cells(2, 90).value = IIf(_objeto.Ficha_FactRieM112, "X", "")
        .Cells(2, 91).value = IIf(_objeto.Ficha_FactRieM113, "X", "")
        .Cells(2, 92).value = IIf(_objeto.Ficha_FactRieM114, "X", "")
        .Cells(2, 93).value = IIf(_objeto.Ficha_FactRieM121, "X", "")
        .Cells(2, 94).value = IIf(_objeto.Ficha_FactRieM122, "X", "")
        .Cells(2, 95).value = IIf(_objeto.Ficha_FactRieM123, "X", "")
        .Cells(2, 96).value = IIf(_objeto.Ficha_FactRieM124, "X", "")
        .Cells(2, 97).value = IIf(_objeto.Ficha_FactRieM131, "X", "")
        .Cells(2, 98).value = IIf(_objeto.Ficha_FactRieM132, "X", "")
        .Cells(2, 99).value = IIf(_objeto.Ficha_FactRieM133, "X", "")
        .Cells(2, 100).value = IIf(_objeto.Ficha_FactRieM134, "X", "")
        .Cells(2, 101).value = IIf(_objeto.Ficha_FactRieM141, "X", "")
        .Cells(2, 102).value = IIf(_objeto.Ficha_FactRieM142, "X", "")
        .Cells(2, 103).value = IIf(_objeto.Ficha_FactRieM143, "X", "")
        .Cells(2, 104).value = IIf(_objeto.Ficha_FactRieM144, "X", "")
        .Cells(2, 105).value = IIf(_objeto.Ficha_FactRieM151, "X", "")
        .Cells(2, 106).value = IIf(_objeto.Ficha_FactRieM152, "X", "")
        .Cells(2, 107).value = IIf(_objeto.Ficha_FactRieM153, "X", "")
        .Cells(2, 108).value = IIf(_objeto.Ficha_FactRieM154, "X", "")


        .Cells(2, 109).value = IIf(_objeto.Ficha_FactRieQ011, "X", "")
        .Cells(2, 110).value = IIf(_objeto.Ficha_FactRieQ012, "X", "")
        .Cells(2, 111).value = IIf(_objeto.Ficha_FactRieQ013, "X", "")
        .Cells(2, 112).value = IIf(_objeto.Ficha_FactRieQ014, "X", "")
        .Cells(2, 113).value = IIf(_objeto.Ficha_FactRieQ021, "X", "")
        .Cells(2, 114).value = IIf(_objeto.Ficha_FactRieQ022, "X", "")
        .Cells(2, 115).value = IIf(_objeto.Ficha_FactRieQ023, "X", "")
        .Cells(2, 116).value = IIf(_objeto.Ficha_FactRieQ024, "X", "")
        .Cells(2, 117).value = IIf(_objeto.Ficha_FactRieQ031, "X", "")
        .Cells(2, 118).value = IIf(_objeto.Ficha_FactRieQ032, "X", "")
        .Cells(2, 119).value = IIf(_objeto.Ficha_FactRieQ033, "X", "")
        .Cells(2, 120).value = IIf(_objeto.Ficha_FactRieQ034, "X", "")
        .Cells(2, 121).value = IIf(_objeto.Ficha_FactRieQ041, "X", "")
        .Cells(2, 122).value = IIf(_objeto.Ficha_FactRieQ042, "X", "")
        .Cells(2, 123).value = IIf(_objeto.Ficha_FactRieQ043, "X", "")
        .Cells(2, 124).value = IIf(_objeto.Ficha_FactRieQ044, "X", "")
        .Cells(2, 125).value = IIf(_objeto.Ficha_FactRieQ051, "X", "")
        .Cells(2, 126).value = IIf(_objeto.Ficha_FactRieQ052, "X", "")
        .Cells(2, 127).value = IIf(_objeto.Ficha_FactRieQ053, "X", "")
        .Cells(2, 128).value = IIf(_objeto.Ficha_FactRieQ054, "X", "")
        .Cells(2, 129).value = IIf(_objeto.Ficha_FactRieQ061, "X", "")
        .Cells(2, 130).value = IIf(_objeto.Ficha_FactRieQ062, "X", "")
        .Cells(2, 131).value = IIf(_objeto.Ficha_FactRieQ063, "X", "")
        .Cells(2, 132).value = IIf(_objeto.Ficha_FactRieQ064, "X", "")
        .Cells(2, 133).value = IIf(_objeto.Ficha_FactRieQ071, "X", "")
        .Cells(2, 134).value = IIf(_objeto.Ficha_FactRieQ072, "X", "")
        .Cells(2, 135).value = IIf(_objeto.Ficha_FactRieQ073, "X", "")
        .Cells(2, 136).value = IIf(_objeto.Ficha_FactRieQ074, "X", "")
        .Cells(2, 137).value = IIf(_objeto.Ficha_FactRieQ081, "X", "")
        .Cells(2, 138).value = IIf(_objeto.Ficha_FactRieQ082, "X", "")
        .Cells(2, 139).value = IIf(_objeto.Ficha_FactRieQ083, "X", "")
        .Cells(2, 140).value = IIf(_objeto.Ficha_FactRieQ084, "X", "")
        .Cells(2, 141).value = IIf(_objeto.Ficha_FactRieQ091, "X", "")
        .Cells(2, 142).value = IIf(_objeto.Ficha_FactRieQ092, "X", "")
        .Cells(2, 143).value = IIf(_objeto.Ficha_FactRieQ093, "X", "")
        .Cells(2, 144).value = IIf(_objeto.Ficha_FactRieQ094, "X", "")
        .Cells(2, 145).value = IIf(_objeto.Ficha_FactRieB011, "X", "")
        .Cells(2, 146).value = IIf(_objeto.Ficha_FactRieB012, "X", "")
        .Cells(2, 147).value = IIf(_objeto.Ficha_FactRieB013, "X", "")
        .Cells(2, 148).value = IIf(_objeto.Ficha_FactRieB014, "X", "")
        .Cells(2, 149).value = IIf(_objeto.Ficha_FactRieB021, "X", "")
        .Cells(2, 150).value = IIf(_objeto.Ficha_FactRieB022, "X", "")
        .Cells(2, 151).value = IIf(_objeto.Ficha_FactRieB023, "X", "")
        .Cells(2, 152).value = IIf(_objeto.Ficha_FactRieB024, "X", "")
        .Cells(2, 153).value = IIf(_objeto.Ficha_FactRieB031, "X", "")
        .Cells(2, 154).value = IIf(_objeto.Ficha_FactRieB032, "X", "")
        .Cells(2, 155).value = IIf(_objeto.Ficha_FactRieB033, "X", "")
        .Cells(2, 156).value = IIf(_objeto.Ficha_FactRieB034, "X", "")
        .Cells(2, 157).value = IIf(_objeto.Ficha_FactRieB041, "X", "")
        .Cells(2, 158).value = IIf(_objeto.Ficha_FactRieB042, "X", "")
        .Cells(2, 159).value = IIf(_objeto.Ficha_FactRieB043, "X", "")
        .Cells(2, 160).value = IIf(_objeto.Ficha_FactRieB044, "X", "")
        .Cells(2, 161).value = IIf(_objeto.Ficha_FactRieB051, "X", "")
        .Cells(2, 162).value = IIf(_objeto.Ficha_FactRieB052, "X", "")
        .Cells(2, 163).value = IIf(_objeto.Ficha_FactRieB053, "X", "")
        .Cells(2, 164).value = IIf(_objeto.Ficha_FactRieB054, "X", "")
        .Cells(2, 165).value = IIf(_objeto.Ficha_FactRieB061, "X", "")
        .Cells(2, 166).value = IIf(_objeto.Ficha_FactRieB062, "X", "")
        .Cells(2, 167).value = IIf(_objeto.Ficha_FactRieB063, "X", "")
        .Cells(2, 168).value = IIf(_objeto.Ficha_FactRieB064, "X", "")
        .Cells(2, 169).value = IIf(_objeto.Ficha_FactRieB071, "X", "")
        .Cells(2, 170).value = IIf(_objeto.Ficha_FactRieB072, "X", "")
        .Cells(2, 171).value = IIf(_objeto.Ficha_FactRieB073, "X", "")
        .Cells(2, 172).value = IIf(_objeto.Ficha_FactRieB074, "X", "")
        .Cells(2, 173).value = IIf(_objeto.Ficha_FactRieE011, "X", "")
        .Cells(2, 174).value = IIf(_objeto.Ficha_FactRieE012, "X", "")
        .Cells(2, 175).value = IIf(_objeto.Ficha_FactRieE013, "X", "")
        .Cells(2, 176).value = IIf(_objeto.Ficha_FactRieE014, "X", "")
        .Cells(2, 177).value = IIf(_objeto.Ficha_FactRieE021, "X", "")
        .Cells(2, 178).value = IIf(_objeto.Ficha_FactRieE022, "X", "")
        .Cells(2, 179).value = IIf(_objeto.Ficha_FactRieE023, "X", "")
        .Cells(2, 180).value = IIf(_objeto.Ficha_FactRieE024, "X", "")
        .Cells(2, 181).value = IIf(_objeto.Ficha_FactRieE031, "X", "")
        .Cells(2, 182).value = IIf(_objeto.Ficha_FactRieE032, "X", "")
        .Cells(2, 183).value = IIf(_objeto.Ficha_FactRieE033, "X", "")
        .Cells(2, 184).value = IIf(_objeto.Ficha_FactRieE034, "X", "")
        .Cells(2, 185).value = IIf(_objeto.Ficha_FactRieE041, "X", "")
        .Cells(2, 186).value = IIf(_objeto.Ficha_FactRieE042, "X", "")
        .Cells(2, 187).value = IIf(_objeto.Ficha_FactRieE043, "X", "")
        .Cells(2, 188).value = IIf(_objeto.Ficha_FactRieE044, "X", "")
        .Cells(2, 189).value = IIf(_objeto.Ficha_FactRieE051, "X", "")
        .Cells(2, 190).value = IIf(_objeto.Ficha_FactRieE052, "X", "")
        .Cells(2, 191).value = IIf(_objeto.Ficha_FactRieE053, "X", "")
        .Cells(2, 192).value = IIf(_objeto.Ficha_FactRieE054, "X", "")
        .Cells(2, 193).value = IIf(_objeto.Ficha_FactRieP011, "X", "")
        .Cells(2, 194).value = IIf(_objeto.Ficha_FactRieP012, "X", "")
        .Cells(2, 195).value = IIf(_objeto.Ficha_FactRieP013, "X", "")
        .Cells(2, 196).value = IIf(_objeto.Ficha_FactRieP014, "X", "")
        .Cells(2, 197).value = IIf(_objeto.Ficha_FactRieP021, "X", "")
        .Cells(2, 198).value = IIf(_objeto.Ficha_FactRieP022, "X", "")
        .Cells(2, 199).value = IIf(_objeto.Ficha_FactRieP023, "X", "")
        .Cells(2, 200).value = IIf(_objeto.Ficha_FactRieP024, "X", "")
        .Cells(2, 201).value = IIf(_objeto.Ficha_FactRieP031, "X", "")
        .Cells(2, 202).value = IIf(_objeto.Ficha_FactRieP032, "X", "")
        .Cells(2, 203).value = IIf(_objeto.Ficha_FactRieP033, "X", "")
        .Cells(2, 204).value = IIf(_objeto.Ficha_FactRieP034, "X", "")
        .Cells(2, 205).value = IIf(_objeto.Ficha_FactRieP041, "X", "")
        .Cells(2, 206).value = IIf(_objeto.Ficha_FactRieP042, "X", "")
        .Cells(2, 207).value = IIf(_objeto.Ficha_FactRieP043, "X", "")
        .Cells(2, 208).value = IIf(_objeto.Ficha_FactRieP044, "X", "")
        .Cells(2, 209).value = IIf(_objeto.Ficha_FactRieP051, "X", "")
        .Cells(2, 210).value = IIf(_objeto.Ficha_FactRieP052, "X", "")
        .Cells(2, 211).value = IIf(_objeto.Ficha_FactRieP053, "X", "")
        .Cells(2, 212).value = IIf(_objeto.Ficha_FactRieP054, "X", "")
        .Cells(2, 213).value = IIf(_objeto.Ficha_FactRieP061, "X", "")
        .Cells(2, 214).value = IIf(_objeto.Ficha_FactRieP062, "X", "")
        .Cells(2, 215).value = IIf(_objeto.Ficha_FactRieP063, "X", "")
        .Cells(2, 216).value = IIf(_objeto.Ficha_FactRieP064, "X", "")
        .Cells(2, 217).value = IIf(_objeto.Ficha_FactRieP071, "X", "")
        .Cells(2, 218).value = IIf(_objeto.Ficha_FactRieP072, "X", "")
        .Cells(2, 219).value = IIf(_objeto.Ficha_FactRieP073, "X", "")
        .Cells(2, 220).value = IIf(_objeto.Ficha_FactRieP074, "X", "")
        .Cells(2, 221).value = IIf(_objeto.Ficha_FactRieP081, "X", "")
        .Cells(2, 222).value = IIf(_objeto.Ficha_FactRieP082, "X", "")
        .Cells(2, 223).value = IIf(_objeto.Ficha_FactRieP083, "X", "")
        .Cells(2, 224).value = IIf(_objeto.Ficha_FactRieP084, "X", "")
        .Cells(2, 225).value = IIf(_objeto.Ficha_FactRieP091, "X", "")
        .Cells(2, 226).value = IIf(_objeto.Ficha_FactRieP092, "X", "")
        .Cells(2, 227).value = IIf(_objeto.Ficha_FactRieP093, "X", "")
        .Cells(2, 228).value = IIf(_objeto.Ficha_FactRieP094, "X", "")
        .Cells(2, 229).value = IIf(_objeto.Ficha_FactRieP101, "X", "")
        .Cells(2, 230).value = IIf(_objeto.Ficha_FactRieP102, "X", "")
        .Cells(2, 231).value = IIf(_objeto.Ficha_FactRieP103, "X", "")
        .Cells(2, 232).value = IIf(_objeto.Ficha_FactRieP104, "X", "")
        .Cells(2, 233).value = IIf(_objeto.Ficha_FactRieP111, "X", "")
        .Cells(2, 234).value = IIf(_objeto.Ficha_FactRieP112, "X", "")
        .Cells(2, 235).value = IIf(_objeto.Ficha_FactRieP113, "X", "")
        .Cells(2, 236).value = IIf(_objeto.Ficha_FactRieP114, "X", "")
        .Cells(2, 237).value = IIf(_objeto.Ficha_FactRieP121, "X", "")
        .Cells(2, 238).value = IIf(_objeto.Ficha_FactRieP122, "X", "")
        .Cells(2, 239).value = IIf(_objeto.Ficha_FactRieP123, "X", "")
        .Cells(2, 240).value = IIf(_objeto.Ficha_FactRieP124, "X", "")
        .Cells(2, 241).value = IIf(_objeto.Ficha_FactRieP131, "X", "")
        .Cells(2, 242).value = IIf(_objeto.Ficha_FactRieP132, "X", "")
        .Cells(2, 243).value = IIf(_objeto.Ficha_FactRieP133, "X", "")
        .Cells(2, 244).value = IIf(_objeto.Ficha_FactRieP134, "X", "")
        .Cells(2, 245).value = _objeto.Ficha_FactRieMedPrev1
        .Cells(2, 246).value = _objeto.Ficha_FactRieMedPrev2
        .Cells(2, 247).value = _objeto.Ficha_FactRieMedPrev3
        .Cells(2, 248).value = _objeto.Ficha_FactRieMedPrev4
        .Cells(2, 249).value = _objeto.Ficha_ActExtrLab
        .Cells(2, 250).value = _objeto.Ficha_EnfActual



      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecombinacionpag2.xls"
      Try
        Kill(rutfte)
      Catch ex As Exception
      End Try

      excelBook.SaveAs(Filename:=rutfte)
      excelBook.Close()
      excelApp.Visible = True
      excelApp.Quit()

      Dim WordApp As New Word.Application
      Dim WordDocument As Word.Document = WordApp.Documents.Open(_direccionarchivo)
      'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
      WordApp.Visible = True
      WordDocument.Activate()
      With WordDocument.MailMerge
        .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & _nombreHoja & "$`")
        .ViewMailMergeFieldCodes = False
        .Destination = 0     'nuevo documento
        .SuppressBlankLines = True
        With .DataSource
          .FirstRecord = 1
          .LastRecord = -16
        End With
        .Execute(Pause:=False)
      End With
      WordDocument.ActiveWindow.Close()

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub
  Public Shared Sub CombinarCorrespondenciaFichaOcupacionalPag3(ByVal _objeto As FichaMedica, ByVal _direccionarchivo As String)
    If Not My.Computer.FileSystem.FileExists(_direccionarchivo) Then
      MsgBox("No existe la carta modelo para realizar la combinación de correspondencia", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _nombreHoja As String = "Hoja1"

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet =
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      _nombreHoja = excelWorksheet.Name

      excelApp.Visible = False
      With excelWorksheet
        .Columns().ColumnWidth = 80
        .Columns.NumberFormat = "@"
        .Cells(1, 1).value = "PIEL"
        .Cells(1, 2).value = "ORGANSENTIDOS"
        .Cells(1, 3).value = "RESPIRATORIO1"
        .Cells(1, 4).value = "CARDIOVASCULAR1"
        .Cells(1, 5).value = "DIGESTIVO"
        .Cells(1, 6).value = "URINARIO"
        .Cells(1, 7).value = "MUSCULOESQUELETO"

        .Cells(1, 8).value = "ENDOCRINO"
        .Cells(1, 9).value = "HEMOLINFATICO"
        .Cells(1, 10).value = "NERVIOSO"
        .Cells(1, 11).value = "CVPRESIONARTEIAL"
        .Cells(1, 12).value = "CVTEMPERATURA"
        .Cells(1, 13).value = "CVFRECCARDIACA"
        .Cells(1, 14).value = "CVSATOXIGEN"
        .Cells(1, 15).value = "CVRESPIRATORIA"
        .Cells(1, 16).value = "CVPESO"
        .Cells(1, 17).value = "CVTALLA"
        .Cells(1, 18).value = "CVIMC"
        .Cells(1, 19).value = "CVPERIMETRABDOMIN"
        .Cells(1, 20).value = "PIELCICATRICES"
        .Cells(1, 21).value = "PIELTATOO"
        .Cells(1, 22).value = "PIELANERAS"
        .Cells(1, 23).value = "OJOSPARPADOS"
        .Cells(1, 24).value = "OJOSCONJUNTIV"
        .Cells(1, 25).value = "OJOSPUPILAS"
        .Cells(1, 26).value = "OJOSCORNEAS"
        .Cells(1, 27).value = "OJOSMOTILIDAD"
        .Cells(1, 28).value = "OIDOAUDEXTERN"
        .Cells(1, 29).value = "OIDOPABELLON"
        .Cells(1, 30).value = "OIDOTIMPANO"
        .Cells(1, 31).value = "FARINGLABIOS"
        .Cells(1, 32).value = "FARINGLENGUA"
        .Cells(1, 33).value = "FARINGFARING"
        .Cells(1, 34).value = "FARINGAMIGDALAS"
        .Cells(1, 35).value = "FARINGDENTA"
        .Cells(1, 36).value = "NARIZTABIQUE"
        .Cells(1, 37).value = "NARIZCORETES"
        .Cells(1, 38).value = "NARIZMUCOSA"
        .Cells(1, 39).value = "NARIZSENOSNASAL"
        .Cells(1, 40).value = "CUELLOTIROIDES"
        .Cells(1, 41).value = "CUELLOMOVILIDAD"
        .Cells(1, 42).value = "TORAXMAMAS"
        .Cells(1, 43).value = "TORAXCORAZON"
        .Cells(1, 44).value = "TORAXPULMON"
        .Cells(1, 45).value = "TORAXPARRILLACOSTAL"
        .Cells(1, 46).value = "ABSVISCERAS"
        .Cells(1, 47).value = "ABSPAREDADS"
        .Cells(1, 48).value = "COLUMNFLEXIBILID"
        .Cells(1, 49).value = "COLUMDESVIACION"
        .Cells(1, 50).value = "COLUMNDOLOR"
        .Cells(1, 51).value = "PELVIS"
        .Cells(1, 52).value = "PELVISGENITAL"
        .Cells(1, 53).value = "EXTREMIDSVASCULAR"
        .Cells(1, 54).value = "EXTREMIDSMIEMBRSUP"
        .Cells(1, 55).value = "EXTREMIDSMIEMBINFE"
        .Cells(1, 56).value = "NERUROFUERZA"
        .Cells(1, 57).value = "NEUROSENSIBILID"
        .Cells(1, 58).value = "NEUROLOGMARCH"
        .Cells(1, 59).value = "NEUROLOGREFLEJ"
        .Cells(1, 60).value = "RIESTRABEXAOBSERVACIONES"
        .Cells(1, 61).value = "RIESTRABEXAMGENERAL1"
        .Cells(1, 62).value = "RIESTRABEXAMGENERAL2"
        .Cells(1, 63).value = "RIESTRABEXAMGENERAL3"
        .Cells(1, 64).value = "RIESTRABEXAMGENERAL4"
        .Cells(1, 65).value = "RIESTRABEXAMFECHA1"
        .Cells(1, 66).value = "RIESTRABEXAMFECHA2"
        .Cells(1, 67).value = "RIESTRABEXAMFECHA3"
        .Cells(1, 68).value = "RIESTRABEXAMFECHA4"
        .Cells(1, 69).value = "RIESTRABEXAMRESULTADO1"
        .Cells(1, 70).value = "RIESTRABEXAMRESULTADO2"
        .Cells(1, 71).value = "RIESTRABEXAMRESULTADO3"
        .Cells(1, 72).value = "RIESTRABEXAMRESULTADO4"
        .Cells(1, 73).value = "RIESTRABEXAMDESCRIP"
        .Cells(1, 74).value = "DIAGNOSTICO1"
        .Cells(1, 75).value = "DIAGNOSTICO2"
        .Cells(1, 76).value = "DIAGNOSTICO3"
        .Cells(1, 77).value = "DIAGNOSTICOCIE1"
        .Cells(1, 78).value = "DIAGNOSTICOCIE2"
        .Cells(1, 79).value = "DIAGNOSTICOCIE3"
        .Cells(1, 80).value = "DIAGNOSTICOPRE1"
        .Cells(1, 81).value = "DIAGNOSTICOPRE2"
        .Cells(1, 82).value = "DIAGNOSTICOPRE3"
        .Cells(1, 83).value = "DIAGNOSTICODEF1"
        .Cells(1, 84).value = "DIAGNOSTICODEF2"
        .Cells(1, 85).value = "DIAGNOSTICODEF3"
        .Cells(1, 86).value = "APTO"
        .Cells(1, 87).value = "APTOOBSER"
        .Cells(1, 88).value = "APTOLIM"
        .Cells(1, 89).value = "NOAPTO"
        .Cells(1, 90).value = "APTOOBSERVAC"
        .Cells(1, 91).value = "APTOLIMITA"
        .Cells(1, 92).value = "TRATAMEINTDESCRIP"



        .Cells(2, 1).value = IIf(_objeto.Ficha_RevOrgSistPiel, "X", "")
        .Cells(2, 2).value = IIf(_objeto.Ficha_RevOrgSistOrg, "X", "")
        .Cells(2, 3).value = IIf(_objeto.Ficha_RevOrgSistResp, "X", "")
        .Cells(2, 4).value = IIf(_objeto.Ficha_RevOrgSistCard, "X", "")
        .Cells(2, 5).value = IIf(_objeto.Ficha_RevOrgSistDig, "X", "")
        .Cells(2, 6).value = IIf(_objeto.Ficha_RevOrgSistGen, "X", "")
        .Cells(2, 7).value = IIf(_objeto.Ficha_RevOrgSistMus, "X", "")
        .Cells(2, 8).value = IIf(_objeto.Ficha_RevOrgSistEnd, "X", "")
        .Cells(2, 9).value = IIf(_objeto.Ficha_RevOrgSistHem, "X", "")
        .Cells(2, 10).value = IIf(_objeto.Ficha_RevOrgSistNerv, "X", "")

        .Cells(2, 11).value = _objeto.Ficha_ConstVitPresArt
        .Cells(2, 12).value = _objeto.Ficha_ConstVitTemp
        .Cells(2, 13).value = _objeto.Ficha_ConstVitFrecCard
        .Cells(2, 14).value = _objeto.Ficha_ConstVitSatOxi
        .Cells(2, 15).value = _objeto.Ficha_ConstVitFrecResp
        .Cells(2, 16).value = _objeto.Ficha_ConstVitPeso
        .Cells(2, 17).value = _objeto.Ficha_ConstVitTalla
        .Cells(2, 18).value = _objeto.Ficha_ConstVitIMC
        .Cells(2, 19).value = _objeto.Ficha_ConstVitPeriAbdo

        .Cells(2, 20).value = IIf(_objeto.Ficha_ExaFis1a, "X", "")
        .Cells(2, 21).value = IIf(_objeto.Ficha_ExaFis1b, "X", "")
        .Cells(2, 22).value = IIf(_objeto.Ficha_ExaFis1c, "X", "")
        .Cells(2, 23).value = IIf(_objeto.Ficha_ExaFis2a, "X", "")
        .Cells(2, 24).value = IIf(_objeto.Ficha_ExaFis2b, "X", "")
        .Cells(2, 25).value = IIf(_objeto.Ficha_ExaFis2c, "X", "")
        .Cells(2, 26).value = IIf(_objeto.Ficha_ExaFis2d, "X", "")
        .Cells(2, 27).value = IIf(_objeto.Ficha_ExaFis2e, "X", "")
        .Cells(2, 28).value = IIf(_objeto.Ficha_ExaFis3a, "X", "")
        .Cells(2, 29).value = IIf(_objeto.Ficha_ExaFis3b, "X", "")
        .Cells(2, 30).value = IIf(_objeto.Ficha_ExaFis3c, "X", "")
        .Cells(2, 31).value = IIf(_objeto.Ficha_ExaFis4a, "X", "")
        .Cells(2, 32).value = IIf(_objeto.Ficha_ExaFis4b, "X", "")
        .Cells(2, 33).value = IIf(_objeto.Ficha_ExaFis4c, "X", "")
        .Cells(2, 34).value = IIf(_objeto.Ficha_ExaFis4d, "X", "")
        .Cells(2, 35).value = IIf(_objeto.Ficha_ExaFis4e, "X", "")
        .Cells(2, 36).value = IIf(_objeto.Ficha_ExaFis5a, "X", "")
        .Cells(2, 37).value = IIf(_objeto.Ficha_ExaFis5b, "X", "")
        .Cells(2, 38).value = IIf(_objeto.Ficha_ExaFis5c, "X", "")
        .Cells(2, 39).value = IIf(_objeto.Ficha_ExaFis5d, "X", "")
        .Cells(2, 40).value = IIf(_objeto.Ficha_ExaFis6a, "X", "")
        .Cells(2, 41).value = IIf(_objeto.Ficha_ExaFis6b, "X", "")
        .Cells(2, 42).value = IIf(_objeto.Ficha_ExaFis7a, "X", "")
        .Cells(2, 43).value = IIf(_objeto.Ficha_ExaFis7b, "X", "")
        .Cells(2, 44).value = IIf(_objeto.Ficha_ExaFis8a, "X", "")
        .Cells(2, 45).value = IIf(_objeto.Ficha_ExaFis8b, "X", "")
        .Cells(2, 46).value = IIf(_objeto.Ficha_ExaFis9a, "X", "")
        .Cells(2, 47).value = IIf(_objeto.Ficha_ExaFis9b, "X", "")
        .Cells(2, 48).value = IIf(_objeto.Ficha_ExaFis10a, "X", "")
        .Cells(2, 49).value = IIf(_objeto.Ficha_ExaFis10b, "X", "")
        .Cells(2, 50).value = IIf(_objeto.Ficha_ExaFis10c, "X", "")
        .Cells(2, 51).value = IIf(_objeto.Ficha_ExaFis11a, "X", "")
        .Cells(2, 52).value = IIf(_objeto.Ficha_ExaFis11b, "X", "")
        .Cells(2, 53).value = IIf(_objeto.Ficha_ExaFis12a, "X", "")
        .Cells(2, 54).value = IIf(_objeto.Ficha_ExaFis12b, "X", "")
        .Cells(2, 55).value = IIf(_objeto.Ficha_ExaFis12c, "X", "")
        .Cells(2, 56).value = IIf(_objeto.Ficha_ExaFis13a, "X", "")
        .Cells(2, 57).value = IIf(_objeto.Ficha_ExaFis13b, "X", "")
        .Cells(2, 58).value = IIf(_objeto.Ficha_ExaFis13c, "X", "")
        .Cells(2, 59).value = IIf(_objeto.Ficha_ExaFis13d, "X", "")
        .Cells(2, 60).value = _objeto.Ficha_ExaFisObservacion
        .Cells(2, 61).value = _objeto.Ficha_ResExaGen1
        .Cells(2, 62).value = _objeto.Ficha_ResExaGen2
        .Cells(2, 63).value = _objeto.Ficha_ResExaGen3
        .Cells(2, 64).value = _objeto.Ficha_ResExaGen4
        .Cells(2, 65).value = _objeto.Ficha_ResExaGenFec1.ToString("yyyy/MM/dd")
        .Cells(2, 66).value = _objeto.Ficha_ResExaGenFec2.ToString("yyyy/MM/dd")
        .Cells(2, 67).value = _objeto.Ficha_ResExaGenFec3.ToString("yyyy/MM/dd")
        .Cells(2, 68).value = _objeto.Ficha_ResExaGenFec4.ToString("yyyy/MM/dd")
        .Cells(2, 69).value = _objeto.Ficha_ResExaGenRes1
        .Cells(2, 70).value = _objeto.Ficha_ResExaGenRes2
        .Cells(2, 71).value = _objeto.Ficha_ResExaGenRes3
        .Cells(2, 72).value = _objeto.Ficha_ResExaGenRes4
        .Cells(2, 73).value = _objeto.Ficha_ResExaGenObservacion
        .Cells(2, 74).value = _objeto.Ficha_Diag1
        .Cells(2, 75).value = _objeto.Ficha_Diag2
        .Cells(2, 76).value = _objeto.Ficha_Diag3
        .Cells(2, 77).value = _objeto.Ficha_DiagCIE1
        .Cells(2, 78).value = _objeto.Ficha_DiagCIE2
        .Cells(2, 79).value = _objeto.Ficha_DiagCIE3
        .Cells(2, 80).value = IIf(_objeto.Ficha_DiagDef1, "X", "")
        .Cells(2, 81).value = IIf(_objeto.Ficha_DiagDef1, "", "X")
        .Cells(2, 82).value = IIf(_objeto.Ficha_DiagDef2, "X", "")
        .Cells(2, 83).value = IIf(_objeto.Ficha_DiagDef2, "", "X")
        .Cells(2, 84).value = IIf(_objeto.Ficha_DiagDef3, "X", "")
        .Cells(2, 85).value = IIf(_objeto.Ficha_DiagDef3, "", "X")
        .Cells(2, 86).value = IIf(_objeto.Ficha_AptMedApto, "X", "")
        .Cells(2, 87).value = IIf(_objeto.Ficha_AptMedAptoenOb, "X", "")
        .Cells(2, 88).value = IIf(_objeto.Ficha_AptMedAptoconLim, "X", "")
        .Cells(2, 89).value = IIf(_objeto.Ficha_AptMedNoApto, "X", "")
        .Cells(2, 90).value = _objeto.Ficha_AptMedObservacion
        .Cells(2, 91).value = _objeto.Ficha_AptMedLimitacion
        .Cells(2, 92).value = _objeto.Ficha_RecomTratamiento



      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecombinacionpag3.xls"
      Try
        Kill(rutfte)
      Catch ex As Exception
      End Try

      excelBook.SaveAs(Filename:=rutfte)
      excelBook.Close()
      excelApp.Visible = True
      excelApp.Quit()

      Dim WordApp As New Word.Application
      Dim WordDocument As Word.Document = WordApp.Documents.Open(_direccionarchivo)
      'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
      WordApp.Visible = True
      WordDocument.Activate()
      With WordDocument.MailMerge
        .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & _nombreHoja & "$`")
        .ViewMailMergeFieldCodes = False
        .Destination = 0     'nuevo documento
        .SuppressBlankLines = True
        With .DataSource
          .FirstRecord = 1
          .LastRecord = -16
        End With
        .Execute(Pause:=False)
      End With
      WordDocument.ActiveWindow.Close()

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub
  Public Shared Sub CombinarCorrespondenciaFichaReingresolPag1(ByVal _objeto As FichaMedica, ByVal _direccionarchivo As String)
    If Not My.Computer.FileSystem.FileExists(_direccionarchivo) Then
      MsgBox("No existe la carta modelo para realizar la combinación de correspondencia", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _nombreHoja As String = "Hoja1"

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet =
       CType(excelBook.Worksheets(1), Excel.Worksheet)
      _nombreHoja = excelWorksheet.Name

      excelApp.Visible = False
      With excelWorksheet
        .Columns().ColumnWidth = 80
        .Columns.NumberFormat = "@"
        .Cells(1, 1).value = "EMPRESA"
        .Cells(1, 2).value = "RUC"
        .Cells(1, 3).value = "CIU"
        .Cells(1, 4).value = "CLINICA"
        .Cells(1, 5).value = "CLINICANUM"
        .Cells(1, 6).value = "ARCHIVONUM"
        .Cells(1, 7).value = "APELLIDOPAT"
        .Cells(1, 8).value = "APELLIDOMAT"
        .Cells(1, 9).value = "NOMBRE1"
        .Cells(1, 10).value = "NOMBRE2"
        .Cells(1, 11).value = "SEXO"
        .Cells(1, 12).value = "EDAD"
        .Cells(1, 13).value = "PUESTTRABAJ"
        .Cells(1, 14).value = "FECHAULTIMODIALABO"
        .Cells(1, 15).value = "FECHADEREINGRESO"
        .Cells(1, 16).value = "TOTALDIAS"
        .Cells(1, 17).value = "CAUSADESALIDA"
        .Cells(1, 18).value = "MOTIVCONSUL"
        .Cells(1, 19).value = "ENFERMACTUAL1"

        .Cells(1, 20).value = "CVPRESIONARTEIAL"
        .Cells(1, 21).value = "CVTEMPERATURA"
        .Cells(1, 22).value = "CVFRECCARDIACA"
        .Cells(1, 23).value = "CVSATOXIGEN"
        .Cells(1, 24).value = "CVRESPIRATORIA"
        .Cells(1, 25).value = "CVPESO"
        .Cells(1, 26).value = "CVTALLA"
        .Cells(1, 27).value = "CVIMC"
        .Cells(1, 28).value = "CVPERIMETRABDOMIN"
        .Cells(1, 29).value = "PIELCICATRICES"
        .Cells(1, 30).value = "PIELTATOO"
        .Cells(1, 31).value = "PIELANERAS"
        .Cells(1, 32).value = "OJOSPARPADOS"
        .Cells(1, 33).value = "OJOSCONJUNTIV"
        .Cells(1, 34).value = "OJOSPUPILAS"
        .Cells(1, 35).value = "OJOSCORNEAS"
        .Cells(1, 36).value = "OJOSMOTILIDAD"
        .Cells(1, 37).value = "OIDOAUDEXTERN"
        .Cells(1, 38).value = "OIDOPABELLON"
        .Cells(1, 39).value = "OIDOTIMPANO"
        .Cells(1, 40).value = "FARINGLABIOS"
        .Cells(1, 41).value = "FARINGLENGUA"
        .Cells(1, 42).value = "FARINGFARING"
        .Cells(1, 43).value = "FARINGAMIGDALAS"
        .Cells(1, 44).value = "FARINGDENTA"
        .Cells(1, 45).value = "NARIZTABIQUE"
        .Cells(1, 46).value = "NARIZCORETES"
        .Cells(1, 47).value = "NARIZMUCOSA"
        .Cells(1, 48).value = "NARIZSENOSNASAL"
        .Cells(1, 49).value = "CUELLOTIROIDES"
        .Cells(1, 50).value = "CUELLOMOVILIDAD"
        .Cells(1, 51).value = "TORAXMAMAS"
        .Cells(1, 52).value = "TORAXCORAZON"
        .Cells(1, 53).value = "TORAXPULMON"
        .Cells(1, 54).value = "TORAXPARRILLACOSTAL"
        .Cells(1, 55).value = "ABSVISCERAS"
        .Cells(1, 56).value = "ABSPAREDADS"
        .Cells(1, 57).value = "COLUMNFLEXIBILID"
        .Cells(1, 58).value = "COLUMDESVIACION"
        .Cells(1, 59).value = "COLUMNDOLOR"
        .Cells(1, 60).value = "PELVIS"
        .Cells(1, 61).value = "PELVISGENITAL"
        .Cells(1, 62).value = "EXTREMIDSVASCULAR"
        .Cells(1, 63).value = "EXTREMIDSMIEMBRSUP"
        .Cells(1, 64).value = "EXTREMIDSMIEMBINFE"
        .Cells(1, 65).value = "NERUROFUERZA"
        .Cells(1, 66).value = "NEUROSENSIBILID"
        .Cells(1, 67).value = "NEUROLOGMARCH"
        .Cells(1, 68).value = "NEUROLOGREFLEJ"
        .Cells(1, 69).value = "RIESTRABEXAOBSERVACIONES"
        .Cells(1, 70).value = "RIESTRABEXAMGENERAL1"
        .Cells(1, 71).value = "RIESTRABEXAMGENERAL2"
        .Cells(1, 72).value = "RIESTRABEXAMGENERAL3"
        .Cells(1, 73).value = "RIESTRABEXAMGENERAL4"
        .Cells(1, 74).value = "RIESTRABEXAMFECHA1"
        .Cells(1, 75).value = "RIESTRABEXAMFECHA2"
        .Cells(1, 76).value = "RIESTRABEXAMFECHA3"
        .Cells(1, 77).value = "RIESTRABEXAMFECHA4"
        .Cells(1, 78).value = "RIESTRABEXAMRESULTADO1"
        .Cells(1, 79).value = "RIESTRABEXAMRESULTADO2"
        .Cells(1, 80).value = "RIESTRABEXAMRESULTADO3"
        .Cells(1, 81).value = "RIESTRABEXAMRESULTADO4"
        .Cells(1, 82).value = "RESULTEXAOBVSER"
        .Cells(1, 83).value = "DIAGNOSTICO1"
        .Cells(1, 84).value = "DIAGNOSTICO2"
        .Cells(1, 85).value = "DIAGNOSTICO3"
        .Cells(1, 86).value = "DIAGNOSTICOCIE1"
        .Cells(1, 87).value = "DIAGNOSTICOCIE2"
        .Cells(1, 88).value = "DIAGNOSTICOCIE3"
        .Cells(1, 89).value = "DIAGNOSTICOPRE1"
        .Cells(1, 90).value = "DIAGNOSTICOPRE2"
        .Cells(1, 91).value = "DIAGNOSTICOPRE3"
        .Cells(1, 92).value = "DIAGNOSTICODEF1"
        .Cells(1, 93).value = "DIAGNOSTICODEF2"
        .Cells(1, 94).value = "DIAGNOSTICODEF3"
        .Cells(1, 95).value = "APTO"
        .Cells(1, 96).value = "APTOOBSER"
        .Cells(1, 97).value = "APTOLIMLIM"
        .Cells(1, 98).value = "NOAPTO"
        .Cells(1, 99).value = "APTOOBSERVAC"
        .Cells(1, 100).value = "APTOLIMITA"
        .Cells(1, 101).value = "APTOREUBIC"
        .Cells(1, 102).value = "TRATAMEINTDESCRIP"


        .Cells(2, 1).value = _objeto.Contrato.Patrono.NombreCompleto
        .Cells(2, 2).value = _objeto.Contrato.Patrono.Ruc
        .Cells(2, 3).value = _objeto.Contrato.Patrono.Ciudad.Descripcion
        .Cells(2, 4).value = _objeto.PardetClinica.Pardet_Descripcion
        .Cells(2, 5).value = _objeto.PardetClinica.Pardet_DatoStr1
        .Cells(2, 6).value = _objeto.Ficha_ArchivoNum
        .Cells(2, 7).value = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Apellidopaterno
        .Cells(2, 8).value = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Apellidomaterno
        Dim nombre1 As String = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Nombres.Trim().Split(" ").FirstOrDefault()
        Dim nombre2 As String = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Nombres.Trim()
        nombre2 = nombre2.Remove(0, Len(nombre1)).Trim()

        .Cells(2, 9).value = nombre1
        .Cells(2, 10).value = nombre2
        .Cells(2, 11).value = _objeto.Contrato.Empleado.Entidadnatural.PardetSexoString
        .Cells(2, 12).value = _objeto.Contrato.Empleado.Entidadnatural.Edad
        .Cells(2, 13).value = _objeto.Contrato.PardetArea.Descripcion
        .Cells(2, 14).value = _objeto.Contrato.Contra_Hasta
        .Cells(2, 15).value = _objeto.Contrato.Contra_Hasta
        .Cells(2, 16).value = _objeto.Contrato.Diastrabajados
        .Cells(2, 17).value = _objeto.Contrato.Contra_MotivoSalida
        .Cells(2, 18).value = _objeto.Ficha_MotivoConsulta
        .Cells(2, 19).value = _objeto.Ficha_EnfActual
        .Cells(2, 20).value = _objeto.Ficha_ConstVitPresArt
        .Cells(2, 21).value = _objeto.Ficha_ConstVitTemp
        .Cells(2, 22).value = _objeto.Ficha_ConstVitFrecCard
        .Cells(2, 23).value = _objeto.Ficha_ConstVitSatOxi
        .Cells(2, 24).value = _objeto.Ficha_ConstVitFrecResp
        .Cells(2, 25).value = _objeto.Ficha_ConstVitPeso
        .Cells(2, 26).value = _objeto.Ficha_ConstVitTalla
        .Cells(2, 27).value = _objeto.Ficha_ConstVitIMC
        .Cells(2, 28).value = _objeto.Ficha_ConstVitPeriAbdo
        .Cells(2, 29).value = IIf(_objeto.Ficha_ExaFis1a, "X", "")
        .Cells(2, 30).value = IIf(_objeto.Ficha_ExaFis1b, "X", "")
        .Cells(2, 31).value = IIf(_objeto.Ficha_ExaFis1c, "X", "")
        .Cells(2, 32).value = IIf(_objeto.Ficha_ExaFis2a, "X", "")
        .Cells(2, 33).value = IIf(_objeto.Ficha_ExaFis2b, "X", "")
        .Cells(2, 34).value = IIf(_objeto.Ficha_ExaFis2c, "X", "")
        .Cells(2, 35).value = IIf(_objeto.Ficha_ExaFis2d, "X", "")
        .Cells(2, 36).value = IIf(_objeto.Ficha_ExaFis2e, "X", "")
        .Cells(2, 37).value = IIf(_objeto.Ficha_ExaFis3a, "X", "")
        .Cells(2, 38).value = IIf(_objeto.Ficha_ExaFis3b, "X", "")
        .Cells(2, 39).value = IIf(_objeto.Ficha_ExaFis3c, "X", "")
        .Cells(2, 40).value = IIf(_objeto.Ficha_ExaFis4a, "X", "")
        .Cells(2, 41).value = IIf(_objeto.Ficha_ExaFis4b, "X", "")
        .Cells(2, 42).value = IIf(_objeto.Ficha_ExaFis4c, "X", "")
        .Cells(2, 43).value = IIf(_objeto.Ficha_ExaFis4d, "X", "")
        .Cells(2, 44).value = IIf(_objeto.Ficha_ExaFis4e, "X", "")
        .Cells(2, 45).value = IIf(_objeto.Ficha_ExaFis5a, "X", "")
        .Cells(2, 46).value = IIf(_objeto.Ficha_ExaFis5b, "X", "")
        .Cells(2, 47).value = IIf(_objeto.Ficha_ExaFis5c, "X", "")
        .Cells(2, 48).value = IIf(_objeto.Ficha_ExaFis5d, "X", "")
        .Cells(2, 49).value = IIf(_objeto.Ficha_ExaFis6a, "X", "")
        .Cells(2, 50).value = IIf(_objeto.Ficha_ExaFis6b, "X", "")
        .Cells(2, 51).value = IIf(_objeto.Ficha_ExaFis7a, "X", "")
        .Cells(2, 52).value = IIf(_objeto.Ficha_ExaFis7b, "X", "")
        .Cells(2, 53).value = IIf(_objeto.Ficha_ExaFis8a, "X", "")
        .Cells(2, 54).value = IIf(_objeto.Ficha_ExaFis8b, "X", "")
        .Cells(2, 55).value = IIf(_objeto.Ficha_ExaFis9a, "X", "")
        .Cells(2, 56).value = IIf(_objeto.Ficha_ExaFis9b, "X", "")
        .Cells(2, 57).value = IIf(_objeto.Ficha_ExaFis10a, "X", "")
        .Cells(2, 58).value = IIf(_objeto.Ficha_ExaFis10b, "X", "")
        .Cells(2, 59).value = IIf(_objeto.Ficha_ExaFis10c, "X", "")
        .Cells(2, 60).value = IIf(_objeto.Ficha_ExaFis11a, "X", "")
        .Cells(2, 61).value = IIf(_objeto.Ficha_ExaFis11b, "X", "")
        .Cells(2, 62).value = IIf(_objeto.Ficha_ExaFis12a, "X", "")
        .Cells(2, 63).value = IIf(_objeto.Ficha_ExaFis12b, "X", "")
        .Cells(2, 64).value = IIf(_objeto.Ficha_ExaFis12c, "X", "")
        .Cells(2, 65).value = IIf(_objeto.Ficha_ExaFis13a, "X", "")
        .Cells(2, 66).value = IIf(_objeto.Ficha_ExaFis13b, "X", "")
        .Cells(2, 67).value = IIf(_objeto.Ficha_ExaFis13c, "X", "")
        .Cells(2, 68).value = IIf(_objeto.Ficha_ExaFis13d, "X", "")
        .Cells(2, 69).value = _objeto.Ficha_ExaFisObservacion
        .Cells(2, 70).value = _objeto.Ficha_ResExaGen1
        .Cells(2, 71).value = _objeto.Ficha_ResExaGen2
        .Cells(2, 72).value = _objeto.Ficha_ResExaGen3
        .Cells(2, 73).value = _objeto.Ficha_ResExaGen4
        .Cells(2, 74).value = _objeto.Ficha_ResExaGenFec1.ToString("yyyy/MM/dd")
        .Cells(2, 75).value = _objeto.Ficha_ResExaGenFec2.ToString("yyyy/MM/dd")
        .Cells(2, 76).value = _objeto.Ficha_ResExaGenFec3.ToString("yyyy/MM/dd")
        .Cells(2, 77).value = _objeto.Ficha_ResExaGenFec4.ToString("yyyy/MM/dd")
        .Cells(2, 78).value = _objeto.Ficha_ResExaGenRes1
        .Cells(2, 79).value = _objeto.Ficha_ResExaGenRes2
        .Cells(2, 80).value = _objeto.Ficha_ResExaGenRes3
        .Cells(2, 81).value = _objeto.Ficha_ResExaGenRes4
        .Cells(2, 82).value = _objeto.Ficha_ResExaGenObservacion
        .Cells(2, 83).value = _objeto.Ficha_Diag1
        .Cells(2, 84).value = _objeto.Ficha_Diag2
        .Cells(2, 85).value = _objeto.Ficha_Diag3
        .Cells(2, 86).value = _objeto.Ficha_DiagCIE1
        .Cells(2, 87).value = _objeto.Ficha_DiagCIE2
        .Cells(2, 88).value = _objeto.Ficha_DiagCIE3
        .Cells(2, 89).value = IIf(_objeto.Ficha_DiagDef1, "X", "")
        .Cells(2, 90).value = IIf(_objeto.Ficha_DiagDef1, "", "X")
        .Cells(2, 91).value = IIf(_objeto.Ficha_DiagDef2, "X", "")
        .Cells(2, 92).value = IIf(_objeto.Ficha_DiagDef2, "", "X")
        .Cells(2, 93).value = IIf(_objeto.Ficha_DiagDef3, "X", "")
        .Cells(2, 94).value = IIf(_objeto.Ficha_DiagDef3, "", "X")
        .Cells(2, 95).value = IIf(_objeto.Ficha_AptMedApto, "X", "")
        .Cells(2, 96).value = IIf(_objeto.Ficha_AptMedAptoenOb, "X", "")
        .Cells(2, 97).value = IIf(_objeto.Ficha_AptMedAptoconLim, "X", "")
        .Cells(2, 98).value = IIf(_objeto.Ficha_AptMedNoApto, "X", "")
        .Cells(2, 99).value = _objeto.Ficha_AptMedObservacion
        .Cells(2, 100).value = _objeto.Ficha_AptMedLimitacion
        '.Cells(2, 101).value = _objeto."APTO REUBICACION"
        .Cells(2, 102).value = _objeto.Ficha_RecomTratamiento

      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecombinacion.xls"
      Try
        Kill(rutfte)
      Catch ex As Exception
      End Try

      excelBook.SaveAs(Filename:=rutfte)
      excelBook.Close()
      excelApp.Visible = True
      excelApp.Quit()

      Dim WordApp As New Word.Application
      Dim WordDocument As Word.Document = WordApp.Documents.Open(_direccionarchivo)
      'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
      WordApp.Visible = True
      WordDocument.Activate()
      With WordDocument.MailMerge
        .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & _nombreHoja & "$`")
        .ViewMailMergeFieldCodes = False
        .Destination = 0     'nuevo documento
        .SuppressBlankLines = True
        With .DataSource
          .FirstRecord = 1
          .LastRecord = -16
        End With
        .Execute(Pause:=False)
      End With
      WordDocument.ActiveWindow.Close()

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub
  Public Shared Sub CombinarCorrespondenciaFichaRetiroPag1(ByVal _objeto As FichaMedica, ByVal _direccionarchivo As String)
    If Not My.Computer.FileSystem.FileExists(_direccionarchivo) Then
      MsgBox("No existe la carta modelo para realizar la combinación de correspondencia", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _nombreHoja As String = "Hoja1"

    Try
      Dim excelApp As New Excel.Application
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet =
           CType(excelBook.Worksheets(1), Excel.Worksheet)
      _nombreHoja = excelWorksheet.Name

      excelApp.Visible = False
      With excelWorksheet
        .Columns().ColumnWidth = 80
        .Columns.NumberFormat = "@"
        .Cells(1, 1).value = "EMPRESA"
        .Cells(1, 2).value = "RUC"
        .Cells(1, 3).value = "CIU"
        .Cells(1, 4).value = "CLINICA"
        .Cells(1, 5).value = "CLINICANUM"
        .Cells(1, 6).value = "ARCHIVONUM"
        .Cells(1, 7).value = "APELLIDOPAT"
        .Cells(1, 8).value = "APELLIDOMAT"
        .Cells(1, 9).value = "NOMBRE1"
        .Cells(1, 10).value = "NOMBRE2"
        .Cells(1, 11).value = "SEXO"
        .Cells(1, 12).value = "FECHINILABO"
        .Cells(1, 13).value = "FECHSALIDA"
        .Cells(1, 14).value = "TIEMPTRABAJO"
        .Cells(1, 15).value = "PUESTCIU"
        .Cells(1, 16).value = "ACTIVIDA1"
        .Cells(1, 17).value = "ACTIVIDA2"
        .Cells(1, 18).value = "ACTIVIDA3"
        .Cells(1, 19).value = "FRIESG1"
        .Cells(1, 20).value = "FRIESG2"
        .Cells(1, 21).value = "FRIESG3"
        .Cells(1, 22).value = "ANTECEDCLINICQUIRURGI"
        .Cells(1, 23).value = "ACCIDENTESCALIFIESS"
        .Cells(1, 24).value = "ACCIDENTESCALIFIESSESPE"
        .Cells(1, 25).value = "ACCIDENTESCALIFIESSFECH"
        .Cells(1, 26).value = "ACCIDENTNOREPOR"
        .Cells(1, 27).value = "ENFERMEDADESCALIFIESS"
        .Cells(1, 28).value = "ENFERMEDADESCALIFIESSESPE"
        .Cells(1, 29).value = "ENFERMEDADESCALIFIESSFECH"
        .Cells(1, 30).value = "ENFERMEDADNOREPOR"
        .Cells(1, 31).value = "CVPRESIONARTEIAL"
        .Cells(1, 32).value = "CVTEMPERATURA"
        .Cells(1, 33).value = "CVFRECCARDIACA"
        .Cells(1, 34).value = "CVSATOXIGEN"
        .Cells(1, 35).value = "CVRESPIRATORIA"
        .Cells(1, 36).value = "CVPESO"
        .Cells(1, 37).value = "CVTALLA"
        .Cells(1, 38).value = "CVIMC"
        .Cells(1, 39).value = "CVPERIMETRABDOMIN"
        .Cells(1, 40).value = "PIELCICATRICES"
        .Cells(1, 41).value = "PIELTATOO"
        .Cells(1, 42).value = "PIELANERAS"
        .Cells(1, 43).value = "OJOSPARPADOS"
        .Cells(1, 44).value = "OJOSCONJUNTIV"
        .Cells(1, 45).value = "OJOSPUPILAS"
        .Cells(1, 46).value = "OJOSCORNEAS"
        .Cells(1, 47).value = "OJOSMOTILIDAD"
        .Cells(1, 48).value = "OIDOAUDEXTERN"
        .Cells(1, 49).value = "OIDOPABELLON"
        .Cells(1, 50).value = "OIDOTIMPANO"
        .Cells(1, 51).value = "FARINGLABIOS"
        .Cells(1, 52).value = "FARINGLENGUA"
        .Cells(1, 53).value = "FARINGFARING"
        .Cells(1, 54).value = "FARINGAMIGDALAS"
        .Cells(1, 55).value = "FARINGDENTA"
        .Cells(1, 56).value = "NARIZTABIQUE"
        .Cells(1, 57).value = "NARIZCORETES"
        .Cells(1, 58).value = "NARIZMUCOSA"
        .Cells(1, 59).value = "NARIZSENOSNASAL"
        .Cells(1, 60).value = "CUELLOTIROIDES"
        .Cells(1, 61).value = "CUELLOMOVILIDAD"
        .Cells(1, 62).value = "TORAXMAMAS"
        .Cells(1, 63).value = "TORAXCORAZON"
        .Cells(1, 64).value = "TORAXPULMON"
        .Cells(1, 65).value = "TORAXPARRILLACOSTAL"
        .Cells(1, 66).value = "ABSVISCERAS"
        .Cells(1, 67).value = "ABSPAREDADS"
        .Cells(1, 68).value = "COLUMNFLEXIBILID"
        .Cells(1, 69).value = "COLUMDESVIACION"
        .Cells(1, 70).value = "COLUMNDOLOR"
        .Cells(1, 71).value = "PELVIS"
        .Cells(1, 72).value = "PELVISGENITAL"
        .Cells(1, 73).value = "EXTREMIDSVASCULAR"
        .Cells(1, 74).value = "EXTREMIDSMIEMBRSUP"
        .Cells(1, 75).value = "EXTREMIDSMIEMBINFE"
        .Cells(1, 76).value = "NERUROFUERZA"
        .Cells(1, 77).value = "NEUROSENSIBILID"
        .Cells(1, 78).value = "NEUROLOGMARCH"
        .Cells(1, 79).value = "NEUROLOGREFLEJ"
        .Cells(1, 80).value = "RIESTRABEXAOBSERVACIONES"
        .Cells(1, 81).value = "RIESTRABEXAMGENERAL1"
        .Cells(1, 82).value = "RIESTRABEXAMGENERAL2"
        .Cells(1, 83).value = "RIESTRABEXAMGENERAL3"
        .Cells(1, 84).value = "RIESTRABEXAMGENERAL4"
        .Cells(1, 85).value = "RIESTRABEXAMFECHA1"
        .Cells(1, 86).value = "RIESTRABEXAMFECHA2"
        .Cells(1, 87).value = "RIESTRABEXAMFECHA3"
        .Cells(1, 88).value = "RIESTRABEXAMFECHA4"
        .Cells(1, 89).value = "RIESTRABEXAMRESULTADO1"
        .Cells(1, 90).value = "RIESTRABEXAMRESULTADO2"
        .Cells(1, 91).value = "RIESTRABEXAMRESULTADO3"
        .Cells(1, 92).value = "RIESTRABEXAMRESULTADO4"
        .Cells(1, 93).value = "RESULTEXAOBVSER"
        .Cells(1, 94).value = "DIAGNOSTICO1"
        .Cells(1, 95).value = "DIAGNOSTICO2"
        .Cells(1, 96).value = "DIAGNOSTICO3"
        .Cells(1, 97).value = "DIAGNOSTICOCIE1"
        .Cells(1, 98).value = "DIAGNOSTICOCIE2"
        .Cells(1, 99).value = "DIAGNOSTICOCIE3"
        .Cells(1, 100).value = "DIAGNOSTICOPRE1"
        .Cells(1, 101).value = "DIAGNOSTICOPRE2"
        .Cells(1, 102).value = "DIAGNOSTICOPRE3"
        .Cells(1, 103).value = "DIAGNOSTICODEF1"
        .Cells(1, 104).value = "DIAGNOSTICODEF2"
        .Cells(1, 105).value = "DIAGNOSTICODEF3"
        .Cells(1, 106).value = "APTOSI"
        .Cells(1, 107).value = "NOAPTO"
        .Cells(1, 108).value = "APTOOBSER"
        .Cells(1, 109).value = "TRATAMEINTDESCRIP"

        .Cells(2, 1).value = _objeto.Contrato.Patrono.NombreCompleto
        .Cells(2, 2).value = _objeto.Contrato.Patrono.Ruc
        .Cells(2, 3).value = _objeto.Contrato.Patrono.Ciudad.Descripcion
        .Cells(2, 4).value = _objeto.PardetClinica.Pardet_Descripcion
        .Cells(2, 5).value = _objeto.PardetClinica.Pardet_DatoStr1
        .Cells(2, 6).value = _objeto.Ficha_ArchivoNum
        .Cells(2, 7).value = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Apellidopaterno
        .Cells(2, 8).value = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Apellidomaterno
        Dim nombre1 As String = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Nombres.Trim().Split(" ").FirstOrDefault()
        Dim nombre2 As String = _objeto.Contrato.Empleado.Entidadnatural.Entnat_Nombres.Trim()
        nombre2 = nombre2.Remove(0, Len(nombre1)).Trim()
        .Cells(2, 9).value = nombre1
        .Cells(2, 10).value = nombre2
        .Cells(2, 11).value = _objeto.Contrato.Empleado.Entidadnatural.PardetSexoString
        .Cells(2, 12).value = _objeto.Contrato.FechaDesdeString
        .Cells(2, 13).value = _objeto.Contrato.Contra_Hasta
        .Cells(2, 14).value = _objeto.Contrato.Diastrabajados / 30
        .Cells(2, 15).value = _objeto.Contrato.PardetArea.Descripcion
        .Cells(2, 16).value = _objeto.Ficha_FactRieActividad1
        .Cells(2, 17).value = _objeto.Ficha_FactRieActividad2
        .Cells(2, 18).value = _objeto.Ficha_FactRieActividad3
        .Cells(2, 19).value = _objeto.Ficha_FactRieMedPrev1
        .Cells(2, 20).value = _objeto.Ficha_FactRieMedPrev2
        .Cells(2, 21).value = _objeto.Ficha_FactRieMedPrev3

        .Cells(2, 22).value = _objeto.Ficha_Antecedentes
        .Cells(2, 23).value = _objeto.Ficha_AntTrabCalifObservacion
        .Cells(2, 24).value = _objeto.Ficha_AntTrabCalifDescripcion
        .Cells(2, 25).value = _objeto.Ficha_AntTrabCalifFecha.ToString("yyyy/MM/dd")
        .Cells(2, 26).value = _objeto.Ficha_AntTrabCalifNoReportado
        .Cells(2, 27).value = _objeto.Ficha_EnfProfCalifObservacion
        .Cells(2, 28).value = _objeto.Ficha_EnfProfCalifDescripcion
        .Cells(1, 29).value = _objeto.Ficha_EnfProfCalifFecha.ToString("yyyy/MM/dd")
        .Cells(2, 30).value = _objeto.Ficha_EnfProfCalifNoReportado
        .Cells(2, 31).value = _objeto.Ficha_ConstVitPresArt
        .Cells(2, 32).value = _objeto.Ficha_ConstVitTemp
        .Cells(2, 33).value = _objeto.Ficha_ConstVitFrecCard
        .Cells(2, 34).value = _objeto.Ficha_ConstVitSatOxi
        .Cells(2, 35).value = _objeto.Ficha_ConstVitFrecResp
        .Cells(2, 36).value = _objeto.Ficha_ConstVitPeso
        .Cells(2, 37).value = _objeto.Ficha_ConstVitTalla
        .Cells(2, 38).value = _objeto.Ficha_ConstVitIMC
        .Cells(2, 39).value = _objeto.Ficha_ConstVitPeriAbdo
        .Cells(2, 40).value = IIf(_objeto.Ficha_ExaFis1a, "X", "")
        .Cells(2, 41).value = IIf(_objeto.Ficha_ExaFis1b, "X", "")
        .Cells(2, 42).value = IIf(_objeto.Ficha_ExaFis1c, "X", "")
        .Cells(2, 43).value = IIf(_objeto.Ficha_ExaFis2a, "X", "")
        .Cells(2, 44).value = IIf(_objeto.Ficha_ExaFis2b, "X", "")
        .Cells(2, 45).value = IIf(_objeto.Ficha_ExaFis2c, "X", "")
        .Cells(2, 46).value = IIf(_objeto.Ficha_ExaFis2d, "X", "")
        .Cells(2, 47).value = IIf(_objeto.Ficha_ExaFis2e, "X", "")
        .Cells(2, 48).value = IIf(_objeto.Ficha_ExaFis3a, "X", "")
        .Cells(2, 49).value = IIf(_objeto.Ficha_ExaFis3b, "X", "")
        .Cells(2, 50).value = IIf(_objeto.Ficha_ExaFis3c, "X", "")
        .Cells(2, 51).value = IIf(_objeto.Ficha_ExaFis4a, "X", "")
        .Cells(2, 52).value = IIf(_objeto.Ficha_ExaFis4b, "X", "")
        .Cells(2, 53).value = IIf(_objeto.Ficha_ExaFis4c, "X", "")
        .Cells(2, 54).value = IIf(_objeto.Ficha_ExaFis4d, "X", "")
        .Cells(2, 55).value = IIf(_objeto.Ficha_ExaFis4e, "X", "")
        .Cells(2, 56).value = IIf(_objeto.Ficha_ExaFis5a, "X", "")
        .Cells(2, 57).value = IIf(_objeto.Ficha_ExaFis5b, "X", "")
        .Cells(2, 58).value = IIf(_objeto.Ficha_ExaFis5c, "X", "")
        .Cells(2, 59).value = IIf(_objeto.Ficha_ExaFis5d, "X", "")
        .Cells(2, 60).value = IIf(_objeto.Ficha_ExaFis6a, "X", "")
        .Cells(2, 61).value = IIf(_objeto.Ficha_ExaFis6b, "X", "")
        .Cells(2, 62).value = IIf(_objeto.Ficha_ExaFis7a, "X", "")
        .Cells(2, 63).value = IIf(_objeto.Ficha_ExaFis7b, "X", "")
        .Cells(2, 64).value = IIf(_objeto.Ficha_ExaFis8a, "X", "")
        .Cells(2, 65).value = IIf(_objeto.Ficha_ExaFis8b, "X", "")
        .Cells(2, 66).value = IIf(_objeto.Ficha_ExaFis9a, "X", "")
        .Cells(2, 67).value = IIf(_objeto.Ficha_ExaFis9b, "X", "")
        .Cells(2, 68).value = IIf(_objeto.Ficha_ExaFis10a, "X", "")
        .Cells(2, 69).value = IIf(_objeto.Ficha_ExaFis10b, "X", "")
        .Cells(2, 70).value = IIf(_objeto.Ficha_ExaFis10c, "X", "")
        .Cells(2, 71).value = IIf(_objeto.Ficha_ExaFis11a, "X", "")
        .Cells(2, 72).value = IIf(_objeto.Ficha_ExaFis11b, "X", "")
        .Cells(2, 73).value = IIf(_objeto.Ficha_ExaFis12a, "X", "")
        .Cells(2, 74).value = IIf(_objeto.Ficha_ExaFis12b, "X", "")
        .Cells(2, 75).value = IIf(_objeto.Ficha_ExaFis12c, "X", "")
        .Cells(2, 76).value = IIf(_objeto.Ficha_ExaFis13a, "X", "")
        .Cells(2, 77).value = IIf(_objeto.Ficha_ExaFis13b, "X", "")
        .Cells(2, 78).value = IIf(_objeto.Ficha_ExaFis13c, "X", "")
        .Cells(2, 79).value = IIf(_objeto.Ficha_ExaFis13d, "X", "")
        .Cells(2, 80).value = _objeto.Ficha_ExaFisObservacion
        .Cells(2, 81).value = _objeto.Ficha_ResExaGen1
        .Cells(2, 82).value = _objeto.Ficha_ResExaGen2
        .Cells(2, 83).value = _objeto.Ficha_ResExaGen3
        .Cells(2, 84).value = _objeto.Ficha_ResExaGen4
        .Cells(2, 85).value = _objeto.Ficha_ResExaGenFec1.ToString("yyyy/MM/dd")
        .Cells(2, 86).value = _objeto.Ficha_ResExaGenFec2.ToString("yyyy/MM/dd")
        .Cells(2, 87).value = _objeto.Ficha_ResExaGenFec3.ToString("yyyy/MM/dd")
        .Cells(2, 88).value = _objeto.Ficha_ResExaGenFec4.ToString("yyyy/MM/dd")
        .Cells(2, 89).value = _objeto.Ficha_ResExaGenRes1
        .Cells(2, 90).value = _objeto.Ficha_ResExaGenRes2
        .Cells(2, 91).value = _objeto.Ficha_ResExaGenRes3
        .Cells(2, 92).value = _objeto.Ficha_ResExaGenRes4
        .Cells(2, 93).value = _objeto.Ficha_ResExaGenObservacion
        .Cells(2, 94).value = _objeto.Ficha_Diag1
        .Cells(2, 95).value = _objeto.Ficha_Diag2
        .Cells(2, 96).value = _objeto.Ficha_Diag3
        .Cells(2, 97).value = _objeto.Ficha_DiagCIE1
        .Cells(2, 98).value = _objeto.Ficha_DiagCIE2
        .Cells(2, 99).value = _objeto.Ficha_DiagCIE3
        .Cells(2, 100).value = IIf(_objeto.Ficha_DiagDef1, "X", "")
        .Cells(2, 101).value = IIf(_objeto.Ficha_DiagDef1, "", "X")
        .Cells(2, 102).value = IIf(_objeto.Ficha_DiagDef2, "X", "")
        .Cells(2, 103).value = IIf(_objeto.Ficha_DiagDef2, "", "X")
        .Cells(2, 104).value = IIf(_objeto.Ficha_DiagDef3, "X", "")
        .Cells(2, 105).value = IIf(_objeto.Ficha_DiagDef3, "", "X")
        .Cells(2, 106).value = IIF(_objeto.Ficha_AptMedApto, "X", "")
        .Cells(2, 107).value = IIf(_objeto.Ficha_AptMedNoApto, "X", "")
        .Cells(2, 108).value = _objeto.Ficha_AptMedObservacion
        .Cells(2, 109).value = _objeto.Ficha_RecomTratamiento

      End With

      Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\ftecombinacion.xls"
      Try
        Kill(rutfte)
      Catch ex As Exception
      End Try

      excelBook.SaveAs(Filename:=rutfte)
      excelBook.Close()
      excelApp.Visible = True
      excelApp.Quit()

      Dim WordApp As New Word.Application
      Dim WordDocument As Word.Document = WordApp.Documents.Open(_direccionarchivo)
      'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
      WordApp.Visible = True
      WordDocument.Activate()
      With WordDocument.MailMerge
        .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & _nombreHoja & "$`")
        .ViewMailMergeFieldCodes = False
        .Destination = 0     'nuevo documento
        .SuppressBlankLines = True
        With .DataSource
          .FirstRecord = 1
          .LastRecord = -16
        End With
        .Execute(Pause:=False)
      End With
      WordDocument.ActiveWindow.Close()

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try

  End Sub

End Class
