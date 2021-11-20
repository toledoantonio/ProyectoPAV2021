using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BankApp.Clases
{
    class BE_Acceso_Datos
    {
        public enum EstadoTransaccion { correcto, error }
        public enum TipoConexion { transaccion, simple }
        public enum RecuperacionPk { recuperar, no_recuperar }
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        SqlTransaction Transaccion;

        public EstadoTransaccion ControlTransaccion { get; set; } = EstadoTransaccion.correcto;
        public TipoConexion ControlConexion { get; set; } = TipoConexion.simple;

        public RecuperacionPk _RecuperarId { get; set; } = RecuperacionPk.no_recuperar;

        string cadena_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G04_2021;Persist Security Info=True;User ID=BD3K3G04_2021;Password=BDG04_9852";

        public void IniciarTransaccion()
        {
            ControlConexion = TipoConexion.transaccion;
            ControlTransaccion = EstadoTransaccion.correcto;
        }
        public EstadoTransaccion CerrarTransaccion()
        {
            if (ControlTransaccion == EstadoTransaccion.correcto)
            {
                Transaccion.Commit();
            }
            else
            {
                Transaccion.Rollback();
            }
            ControlConexion = TipoConexion.simple;
            Cerrar();
            return ControlTransaccion;
        }

        private void Conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = cadena_conexion;

                try
                {
                    Conexion.Open();
                    Cmd.Connection = Conexion;
                    Cmd.CommandType = System.Data.CommandType.Text;
                    if (ControlConexion == TipoConexion.transaccion)
                    {
                        Transaccion = Conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                        Cmd.Transaction = Transaccion;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error en apertura de conexión.\n"
                                     + "Mensaje del error: \n" + e.Message);
                    ControlTransaccion = EstadoTransaccion.error;
                }

            }
        }
        private void Cerrar()
        {
            if (ControlConexion == TipoConexion.simple)
            {
                Conexion.Close();
            }
        }
        public DataTable EjecutarSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en ejecución de SELECT.\n\n"
                    + sql
                    + "\n Mensaje del error: \n" + e.Message);
                ControlTransaccion = EstadoTransaccion.error;
            }
            Cerrar();
            return tabla;
        }
        private void EjecutarNoSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en ejecución de comando.\n\n"
                                + sql
                                + "\n Mensaje del error: \n" + e.Message);
                ControlTransaccion = EstadoTransaccion.error;
            }
            Cerrar();
        }
        private string EjecutarNoSelect(string sql, RecuperacionPk RecuperarId)
        {
            Conectar();
            Cmd.CommandText = sql;
            try
            {
                Cmd.ExecuteNonQuery();
                if (RecuperarId == RecuperacionPk.recuperar)
                {
                    DataTable tabla = new DataTable();
                    Cmd.CommandText = "SELECT SCOPE_IDENTITY()";
                    tabla.Load(Cmd.ExecuteReader());
                    Cerrar();
                    return tabla.Rows[0][0].ToString();
                }
                {
                    Cerrar();
                    return "";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en ejecución de comando.\n\n"
                 + sql
                 + "\n Mensaje del error: \n" + e.Message);
                ControlTransaccion = EstadoTransaccion.error;
                Cerrar();
                return "";
            }

        }
        public string Insertar(string sql, RecuperacionPk RecuperarId)
        {
            return EjecutarNoSelect(sql, RecuperarId);
        }
        public void Modificar(string sql)
        {
            EjecutarNoSelect(sql);
        }
        public void Borrar(string sql)
        {
            EjecutarNoSelect(sql);
        }
    }
}
