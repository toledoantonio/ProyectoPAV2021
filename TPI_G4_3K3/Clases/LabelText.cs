using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp.Clases
{
    public partial class LabelText : UserControl
    {
        public LabelText()
        {
            InitializeComponent();
        }
        public enum TipoDato { texto, numero, fecha }

        public string _Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }
        public bool _Validable { get; set; }
        public string _Nombre_Campo { get; set; }
        public string _Nombre_Tabla { get; set; }
        public string _MensajeError { get; set; }
        //---------------------------------------
        public int _Ancho { get; set; } = 10;
        public int _Decimales { get; set; } = 2;

        TipoDato TipoD = TipoDato.texto;
        public TipoDato _TipoDato
        {
            get { return TipoD; }
            set
            {
                TipoD = value;
                string mascara = "";
                switch (TipoD)
                {
                    case TipoDato.texto:
                        TxtDato.Mask = mascara.PadLeft(_Ancho, 'C');
                        TxtDato.TextAlign = HorizontalAlignment.Left;
                        break;
                    case TipoDato.numero:
                        if (_Decimales >= 1)
                        {
                            mascara = mascara.PadLeft(_Ancho - _Decimales - 1, '9') + ".";
                            mascara = mascara.PadRight(_Ancho, '9');
                        }
                        else
                            mascara = mascara.PadLeft(_Ancho, '9');
                        TxtDato.Mask = mascara;
                        TxtDato.TextAlign = HorizontalAlignment.Left;
                        break;
                    case TipoDato.fecha:
                        TxtDato.Mask = "00/00/0000";
                        TxtDato.TextAlign = HorizontalAlignment.Left;
                        break;
                    default:
                        break;
                }
            }
        }
        public MaskFormat _TextMaskFormat
        {
            get { return TxtDato.TextMaskFormat; }
            set { TxtDato.TextMaskFormat = value; }
        }
        public string _Text
        {
            get => TxtDato.Text;
            set
            {
                //if (TipoD != TipoDato.numero)
                //    TxtDato.Text = value;

                //if (TipoD == TipoDato.numero)
                //{
                //    if (_Decimales == 0)
                //        TxtDato.Text = string.Format("{0:" + TxtDato.Mask.Replace('9', '0') + "}", int.Parse(value));
                //    else
                //        TxtDato.Text = string.Format("{0:" + TxtDato.Mask.Replace('9', '0') + "}", double.Parse(value));
                //    // String.Format("{0:000000.00}", double.Parse("10,25")) => 000010.25
                //    // error 102500.00
                //}

                if (TipoD != TipoDato.numero)
                    TxtDato.Text = value;

                if (TipoD == TipoDato.numero)
                {
                    value = value.Replace(",", ".");
                    if (value.IndexOf(".") == -1 && _Decimales != 0)
                    {
                        value = value + "." + RepetirCaracter("0", _Decimales);
                    }
                    if (value.IndexOf(".") != -1 && _Decimales == 0)
                    {
                        value = value.Substring(0, value.IndexOf("."));
                    }
                    TxtDato.Text = value.PadLeft(_Ancho, ' ');
                }
            }
        }
        public bool _MaskFull => TxtDato.MaskFull;
        public bool _ReadOnly
        {
            get => TxtDato.ReadOnly;
            set => TxtDato.ReadOnly = value;
        }
        public string _Mask
        {
            get => TxtDato.Mask;
            set => TxtDato.Mask = value;
        }

        private void TxtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("."))
            {
                if (this._TipoDato == TipoDato.numero)
                {
                    TxtDato.Text = TxtDato.Text.Trim();
                    int blanco = TxtDato.Text.IndexOf(' ');
                    int entero = _Ancho - _Decimales - 1;

                    if (blanco <= entero && blanco != -1)
                    {
                        for (int i = 0; i < entero - blanco; i++)
                        {
                            TxtDato.Text = " " + TxtDato.Text;
                        }
                    }
                    TxtDato.SelectionStart = TxtDato.Text.Length;
                }
            }
        }
        private string RepetirCaracter(string caracter, int cantidad)
        {
            string texto = "";
            for (int i = 0; i < cantidad; i++)
            {
                texto += caracter;
            }
            return texto;
        }
        private void lblEtiqueta_Click(object sender, EventArgs e)
        {

        }
    }
}
