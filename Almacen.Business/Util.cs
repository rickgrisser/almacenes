using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using NHibernate.Validator.Engine;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System;

namespace Almacen.Business
{
    public class Util
    {
        ///<summary>
        ///</summary>
        ///<returns></returns>
        public static string ipTerminal()
        {
            //Nombre del equipo
            //IPHostEntry iphost = Dns.GetHostEntry(Dns.GetHostName());
            //Obtener IP en XP o W7
            IPAddress iphost = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(addr => addr.AddressFamily.Equals(AddressFamily.InterNetwork));
            //return iphost.HostName;
            return iphost.ToString();//.AddressList[1].ToString();
        }

        /// <summary>
        /// Valida todos los campos del entity
        /// </summary>
        /// <returns>True si los campos son validos</returns>
        public static bool DatosValidos<TE>(TE entity)
        {
            var result = true;
            var engine = new ValidatorEngine();
            engine.Configure();
            if (!engine.IsValid(entity))
            {
                var values = engine.Validate(entity);
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Valida un entity y da un detalle de los errores
        /// </summary>
        /// <typeparam name="TE"></typeparam>
        /// <param name="entity">La entidad a validar</param>
        /// <param name="numErrores">El numero de errores al momento</param>
        /// <param name="listaErrores"></param>
        /// <returns></returns>
        public static bool DatosValidos<TE>(TE entity, Label numErrores, ListBox listaErrores)
        {
            var result = true;
            var engine = new ValidatorEngine();
            engine.Configure();
            if (!engine.IsValid(entity))
            {
                var values = engine.Validate(entity);
                numErrores.Text = values.Length + " Errores";
                LlenarErroresEnLista(values, ref listaErrores);
                result = false;
            }
            return result;
        }


        /// <summary>
        /// Llena los errores generados por el engine
        /// </summary>
        /// <param name="values"></param>
        /// <param name="listaError"></param>
        public static void LlenarErroresEnLista(InvalidValue[] values, ref ListBox listaError)
        {
            listaError.Items.Clear();

            foreach (var message in
                values.Select(value => value.PropertyName + ":" + value.Message))
            {
                listaError.Items.Add(message);
            }
        }

        public static bool DatosValidos2<TE>(TE entity, Label numErrores, RichTextBox listaErrores)
        {
            var result = true;
            var engine = new ValidatorEngine();
            engine.Configure();
            if (!engine.IsValid(entity))
            {
                var values = engine.Validate(entity);
                numErrores.Text = values.Length + " Errores";
                LlenarErroresEnLista2(values, ref listaErrores);
                result = false;
            }
            return result;
        }
        public static void LlenarErroresEnLista2(InvalidValue[] values, ref RichTextBox listaError)
        {
            listaError.Text = "";
            foreach (var message in values.Select(value => value.Message + "\r"))
            {
                listaError.Text = listaError.Text + message;
            }
        }

        /// <summary>
        /// Transforma la lista al dataset con los parametros especificados
        /// </summary>
        /// <param name="valores"></param>
        /// <param name="combo"></param>
        /// <returns></returns>
        public static void Dicc2Combo<TV, TL>(Dictionary<TV, TL> valores, ComboBox combo)
        {
            var tabla = new DataTable();
            tabla.Columns.Add("value", typeof(TV));
            tabla.Columns.Add("label", typeof(TL));

            foreach (var kvp in valores)
            {
                var fila = tabla.NewRow();
                fila["value"] = kvp.Key;
                fila["label"] = kvp.Value;

                tabla.Rows.Add(fila);
            }

            combo.DataSource = tabla;
            combo.DisplayMember = "label";
            combo.ValueMember = "value";

        }

        /// <summary>
        /// Transforma la lista al dataset con los parametros especificados
        /// </summary>
        /// <param name="valores"></param>
        /// <param name="combo"></param>
        /// <returns></returns>
        public static void Dicc2ComboColumn<TV, TL>(Dictionary<TV, TL> valores, DataGridViewComboBoxColumn comboboxColumn)
        {
            var tabla = new DataTable();
            tabla.Columns.Add("value", typeof(TV));
            tabla.Columns.Add("label", typeof(TL));

            foreach (var kvp in valores)
            {
                var fila = tabla.NewRow();
                fila["value"] = kvp.Key;
                fila["label"] = kvp.Value;

                tabla.Rows.Add(fila);
            }

            comboboxColumn.DataSource = tabla;
            comboboxColumn.DisplayMember = "label";
            comboboxColumn.ValueMember = "value";

        }
        public static string ReverseString(string s)
        {
            var arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string GetSHA1(string rfc)
        {
            rfc = ReverseString(rfc);
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            byte[] message = UE.GetBytes(rfc);

            SHA1Managed hashString = new SHA1Managed();
            string hex = "";

            hashValue = hashString.ComputeHash(message);
            
            hex = Convert.ToBase64String(hashValue);

            return hex;
        }
    }
}
