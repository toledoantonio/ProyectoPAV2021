using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankApp.Formularios.FrmBase;
using BankApp.Formularios.Usuarios;
using BankApp.Formularios.Premios;

namespace BankApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Escritorio());
            //Application.Run(new Frm_Base());
            //Application.Run(new Frm_ABM_Usuarios());
            //Application.Run(new Form1());
            //Application.Run(new Frm_Usuarios_Alta());
            //Application.Run(new Frm_ABM_Premios());

        }
    }
}
