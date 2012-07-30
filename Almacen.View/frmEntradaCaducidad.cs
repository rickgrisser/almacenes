using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Almacen.Data.Entities;

namespace Almacen.View
{
    public partial class FrmEntradaCaducidad : Form
    {
        #region Variables Miembro
        public Articulo ArticuloActual;
        public BindingSource bisTemp;
        public decimal douPrecioEntrada;
        public decimal douRecibida;
        private decimal douTotal;
        public bool bolModificacion;
        #endregion

        #region Constructores
        
        public FrmEntradaCaducidad()
        {
            InitializeComponent();
            ResizeGridArticulos();
            ChekaCantidad();
        }

        #endregion

        #region Eventos
        
        private void FrmEntradaCaducidad_Load(object sender, EventArgs e)
        {
            Text=ArticuloActual.DesArticulo;
            boxEntradaCaducidad.Text = boxEntradaCaducidad.Text + @" " + douRecibida;
            if (bisTemp.Count > 0)
            {
                foreach (EntradaDetalle entradaDetalle in bisTemp)
                {
                    dgvEntradaCaducidad.Rows.Add(entradaDetalle.NoLote, entradaDetalle.Cantidad, entradaDetalle.FechaCaducidad, entradaDetalle.IdEntradaDetalle);
                }
            }
        }

        private void dgvEntradaCaducidad_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                switch (dgvEntradaCaducidad.CurrentCell.ColumnIndex)
                {
                    case 0:
                        ((TextBox)e.Control).CharacterCasing = CharacterCasing.Upper;
                        break;
                    case 1:
                        var txt = e.Control as TextBox;
                        if (txt != null)
                        {
                            txt.KeyPress -= dgvEntradaCaducidad_KeyPress;
                            txt.KeyPress += dgvEntradaCaducidad_KeyPress;
                        }
                        break;
                    default:
                        ((TextBox)e.Control).CharacterCasing = CharacterCasing.Normal;
                        break;
                }
            }
        }

        private void dgvEntradaCaducidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvEntradaCaducidad.CurrentCell.ColumnIndex == 1)
            {
                Fx.OnDecimal(dgvEntradaCaducidad[dgvEntradaCaducidad.CurrentCell.ColumnIndex, 
                    dgvEntradaCaducidad.CurrentCell.RowIndex].EditedFormattedValue, e);
            }
        }

        private void dgvEntradaCaducidad_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvEntradaCaducidad.CurrentCell.ColumnIndex == 1 )
            //{
                ChekaCantidad();
            //}
        }

        private void dgvEntradaCaducidad_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ChekaCantidad();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (douTotal == douRecibida)
            {
                if (ChekaLlenado())
                {
                    var bisTmp = new BindingSource();
                    for (var i = 0; i < dgvEntradaCaducidad.Rows.Count - 1; i++)
                    {
                        var objTmp = new EntradaDetalle()
                        {
                            //IdEntradaDetalle = (long)dgvEntradaCaducidad[3, i].Value,
                            Articulo = ArticuloActual,
                            NoLote = dgvEntradaCaducidad[0, i].Value.ToString(),
                            Cantidad = Convert.ToDecimal(dgvEntradaCaducidad[1, i].Value.ToString()),
                            Existencia = Convert.ToDecimal(dgvEntradaCaducidad[1, i].Value.ToString()),
                            FechaCaducidad = Convert.ToDateTime(dgvEntradaCaducidad[2, i].Value.ToString()),
                            PrecioEntrada = douPrecioEntrada,
                            Clave = ArticuloActual.Id.CveArt
                        };
                        if (dgvEntradaCaducidad[3, i].Value!=null)
                        {
                            objTmp.IdEntradaDetalle = (long) dgvEntradaCaducidad[3, i].Value;
                        }
                        bisTmp.Add(objTmp);
                    }
                    FrmEntrada.lstEntradaDetalle.Add(bisTmp);
                    bolModificacion = true;
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Celda en Blanco, Verifique . .",
                                   @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Cantidad Total Debe ser Igual a la Cantidad Recibida, Verifique . .",
                                   @"Almacenes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bolModificacion = false;
            Close();
        }


        #endregion

        #region Metodos

        private void ResizeGridArticulos()
        {
            //bisCaducidad.DataSource = new List<EntradaDetalle>();
            dgvEntradaCaducidad.AutoGenerateColumns = false;
            dgvEntradaCaducidad.AllowUserToAddRows = true;
            //dgvArticulos0.AutoSize = true;
            
            DataGridViewColumn column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NoLote",
                Name = "No. Lote",
                Width = 200,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                MaxInputLength = 18
            };
            dgvEntradaCaducidad.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                Name = "Cantidad",
                Width = 60,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight }
            };
            dgvEntradaCaducidad.Columns.Add(column);

            column = new CalendarColumn()
            {
                DataPropertyName = "FechaCaducidad",
                Name = "Caducidad",
                Width = 120,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
            };
            dgvEntradaCaducidad.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdEntradaDetalle",
                Name = "IdEntradaDetalle",
                Width = 0,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Resizable = DataGridViewTriState.False,
            };
            dgvEntradaCaducidad.Columns.Add(column);

            dgvEntradaCaducidad.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private bool ChekaLlenado()
        {
            var result = true;
            for (var i = 0; i < dgvEntradaCaducidad.Rows.Count - 1; i++)
            {
                if (dgvEntradaCaducidad[0, i].Value == null || dgvEntradaCaducidad[1, i].Value==null
                                || Convert.ToDecimal(dgvEntradaCaducidad[1, i].Value) == 0)
                {result=false;}
            }
            return result;
        }

        private void ChekaCantidad()
        {
            douTotal = 0;
            for (var i = 0; i < dgvEntradaCaducidad.Rows.Count-1;i++ )
            {
                douTotal += dgvEntradaCaducidad[1, i].Value==null?
                    0 : Convert.ToDecimal(dgvEntradaCaducidad[1, i].Value.ToString());
            }
            lblTotal.Text = douTotal.ToString();
        }

        #endregion
        
    }
}
