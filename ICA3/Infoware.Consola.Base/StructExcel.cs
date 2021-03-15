using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoware.Consola.Base
{
    public class StructExcel
    {
        private int mNumero;
        public List<StructExcel.StructSubtotales> Subtotales;
        public StructExcel.StructTablaDinamica TablaDinamica;
        public List<StructExcel.StructTotalizar> Totalizar;
        public StructExcel.StructGraficar Graficar;
        public string NombreHoja;

        public int Numero
        {
            get => this.mNumero;
            set => this.mNumero = value;
        }

        public StructExcel()
        {
            this.Subtotales = new List<StructExcel.StructSubtotales>();
            this.TablaDinamica = new StructExcel.StructTablaDinamica();
            this.TablaDinamica.DataPivotFieldasColumn = false;
            this.Totalizar = new List<StructExcel.StructTotalizar>();
            this.Graficar = new StructExcel.StructGraficar();
        }

        public enum EnumFuncion
        {
            Suma,
            Promedio,
            Cuenta,
            Maximo,
            Minimo,
        }

        public struct StructSubtotales
        {
            public int CampoAgrupado;
            public StructExcel.EnumFuncion Funcion;
            public List<int> CamposResultado;
        }

        public struct StructCampoTablaDinamica
        {
            public string Campo;
            public StructExcel.EnumFuncion Funcion;
            public string Formato;
        }

        public struct StructTablaDinamica
        {
            public List<string> Pivots;
            public List<string> PivotsColumns;
            public List<string> PivotsPage;
            public bool DataPivotFieldasColumn;
            public List<StructExcel.StructCampoTablaDinamica> Campos;
        }

        public struct StructTotalizar
        {
            public StructExcel.EnumFuncion Funcion;
            public int Campo;
        }

        public enum enumGraficarOrientacion
        {
            Filas = 1,
            Columnas = 2,
        }

        public struct StructGraficar
        {
            public int TipoGrafico;
            public StructExcel.enumGraficarOrientacion Orientacion;
            public Decimal RelacionAncho;
            public Decimal RelacionAlto;
        }
    }


    public class StructExcelList : BindingList<StructExcel>
    {
        public StructExcel Devolver(int _Numero)
        {
            StructExcel result = null;
            foreach (StructExcel structExcel2 in this)
            {
                if (structExcel2.Numero == _Numero)
                    result = structExcel2;
            }
            if (result == null)
            {
                result = new StructExcel
                {
                    Numero = _Numero
                };
                this.Add(result);
            }
            return result;
        }
    }
}
