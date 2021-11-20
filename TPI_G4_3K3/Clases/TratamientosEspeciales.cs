using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

namespace BankApp.Clases
{
    class TratamientosEspeciales
    {
        public enum RespuestaValidacion { Correcta, Error }

        public RespuestaValidacion Validar(Control.ControlCollection Controles)
        {
            foreach (var item in Controles)
            {
                if (item.GetType().Name == "LabelText")
                    if (((LabelText)item)._Validable == true)
                    {
                        if (((LabelText)item)._Text == "")
                        {
                            MessageBox.Show(((LabelText)item)._MensajeError);
                            ((LabelText)item).Focus();
                            return RespuestaValidacion.Error;
                        }
                    }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item)._Validable == true)
                    {
                        if (((ComboBox01)item).SelectedIndex == -1)
                        {
                            MessageBox.Show(((ComboBox01)item)._MensajeError);
                            return RespuestaValidacion.Error;
                        }
                    }
                }
            }
            return RespuestaValidacion.Correcta;
        }
        public RespuestaValidacion ValidarFecha(string fecha)
        {
            DateTime fechadev;

            if (DateTime.TryParseExact(fecha, "dd/mm/yyyy", null, DateTimeStyles.AssumeLocal, out fechadev))
                return RespuestaValidacion.Correcta;
            else
                return RespuestaValidacion.Error;
        }
        public RespuestaValidacion ValidarFecha1(string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return RespuestaValidacion.Correcta;
            }
            catch (Exception)
            {
                return RespuestaValidacion.Error;
            }
        }
        public String SqlInsertAutomatico(string NombreTabla, Control.ControlCollection Controles)
        {
            DataTable Est_Tabla = new DataTable();
            string NombreColumna = "";
            string TipoDato = "";
            string ValorColumna = "";
            string BloqueColumnas = "";
            string BloqueDatos = "";

            Est_Tabla = EstructuraTabla(NombreTabla);

            for (int i = 0; i < Est_Tabla.Columns.Count; i++)
            {
                NombreColumna = Est_Tabla.Columns[i].ColumnName;
                TipoDato = Est_Tabla.Columns[i].DataType.ToString();
                ValorColumna = DatoParaColumna(NombreColumna, Controles);
                if (ValorColumna == "")
                    continue;

                if (BloqueColumnas == "")
                {
                    BloqueColumnas += "(" + NombreColumna;
                    BloqueDatos += "(" + FormatearDato(ValorColumna, TipoDato);
                }
                else
                {
                    BloqueColumnas += ", " + NombreColumna;
                    BloqueDatos += ", " + FormatearDato(ValorColumna, TipoDato);
                }
            }
            return "INSERT INTO " +NombreTabla + BloqueColumnas+") VALUES "+BloqueDatos+")";
        }
        private DataTable EstructuraTabla(string NombreTabla)
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            string SqlConsulta = "SELECT TOP 1 * FROM " + NombreTabla;
            return _BD.EjecutarSelect(SqlConsulta);
        }
        private string DatoParaColumna(string NombreColumna, Control.ControlCollection Controles)
        {
            foreach (var item in Controles)
            {
                if (item.GetType().Name == "LabelText")
                    if (((LabelText)item)._Nombre_Campo == NombreColumna)
                        return ((LabelText)item)._Text;
                if (item.GetType().Name == "ComboBox01")
                    if (((ComboBox01)item)._Nombre_campo == NombreColumna)
                        return ((ComboBox01)item).SelectedValue.ToString();
            }
            return "";
        }
        public string FormatearDato(string dato, string TipoDato)
        {
            switch (TipoDato)
            {
                case "System.String":
                    return "'" + dato.Trim() + "'";
                case "System.Int16":
                case "System.Int32":
                case "System.Int64":
                case "System.Double":
                    return dato.Trim();
                case "fecha":
                case "System.DateTime":
                    return "convert(date, '" + dato + "', 103)";
                default:
                    return dato;
            }
        }
        public string RecuperarFechaSistema()
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();

            string sql = "SELECT convert(char(10), GETDATE(), 103)";
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }
        public string RecuperarHoraSistema()
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();

            string sql = "SELECT convert(char(10), GETDATE(), 108)";
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }
    }
}
