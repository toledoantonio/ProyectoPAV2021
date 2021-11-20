using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BankApp.Clases
{
    public class ComboBox01 : ComboBox
    {
        public bool _Validable { get; set; }
        public string _Nombre_campo { get; set; }
        public string _Nombre_tabla { get; set; }
        public string _MensajeError { get; set; }
        public bool _ComboSinSeleccion { get; set; } = false;

        public string _tabla_cargar_combo { get; set; }
        public string _tabla_cargar_descriptor { get; set; }
        public string _tabla_cargar_pk { get; set; }

        public void _Cargar()
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            string sql = "SELECT " + _tabla_cargar_pk + ", " + _tabla_cargar_descriptor + " FROM " + _tabla_cargar_combo;
            this.DisplayMember = _tabla_cargar_descriptor;
            this.ValueMember = _tabla_cargar_pk;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (_ComboSinSeleccion == true)
                this.SelectedIndex = -1;
            else
                this.SelectedIndex = 0;
        }
        public void _Cargar(DataTable tabla, string pk, string descripcion)
        {
            this.DisplayMember = descripcion;
            this.ValueMember = pk;
            this.DataSource = tabla;
            if (_ComboSinSeleccion == true)
                this.SelectedIndex = -1;
            else
                this.SelectedIndex = 0;
        }
    }
}
