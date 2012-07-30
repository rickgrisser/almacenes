using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Almacen.View
{
    public class Fx
    {
        
        public static void OnNumeric(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                { e.Handled = false; }
                else if (Char.IsControl(e.KeyChar))
                { e.Handled = false; }
                else if (Char.IsSeparator(e.KeyChar))
                { e.Handled = true; }
                else
                { e.Handled = true; }
        }

        public static void OnDecimal(object sender, KeyPressEventArgs e)
        {//e.KeyChar == 44 ","  --  46 "."  --  '\b' backspace
            if (Char.IsDigit(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = true; }
            else if (e.KeyChar == 46 && sender.ToString().Contains("."))
            { e.Handled = true; }
            else if (e.KeyChar == 46)
            { e.Handled = false; }
            else
            { e.Handled = true; }
        }

        public static void OnKeyTab(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SendKeys.Send("{TAB}");
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        public static int Porcentaje(double douTotal, double douCantidad)
        {
            douCantidad = douCantidad / douTotal;
            var intPorcentaje = (int)(douCantidad * 100);
            return intPorcentaje;
        }

        public static string NombreMes(int intMonth)
        {
            var nombre = "";
            switch (intMonth)
            {
                case 1: nombre = "Enero"; break;
                case 2: nombre = "Febrero"; break;
                case 3: nombre = "Marzo"; break;
                case 4: nombre = "Abril"; break;
                case 5: nombre = "Mayo"; break;
                case 6: nombre = "Junio"; break;
                case 7: nombre = "Julio"; break;
                case 8: nombre = "Agosto"; break;
                case 9: nombre = "Septiembre"; break;
                case 10: nombre = "Octubre"; break;
                case 11: nombre = "Noviembre"; break;
                case 12: nombre = "Diciembre"; break;
            }
            return nombre;
        }

        public static DateTime UltimoDiaMes(DateTime dtFecha)
        {
            var firstDayOfTheMonth = new DateTime(dtFecha.Year, dtFecha.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }
        
        public static List<Item> Meses()
        {
            var lstMeses = new List<Item>();
            for (var i = 1; i <= 12; i++)
            {
                var Item = new Item(Fx.NombreMes(i), i);
                lstMeses.Add(Item);
            }        
            return lstMeses;
        }

    }
}

