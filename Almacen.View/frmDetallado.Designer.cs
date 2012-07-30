namespace Almacen.View
{
    partial class FrmDetallado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetallado));
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEntradaFolio = new System.Windows.Forms.CheckBox();
            this.chkEntradaFecha = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPedidoTipo = new System.Windows.Forms.CheckBox();
            this.chkPedidoFecha = new System.Windows.Forms.CheckBox();
            this.chkPedidoFolio = new System.Windows.Forms.CheckBox();
            this.lblPedidoTipo = new System.Windows.Forms.Label();
            this.lblPedidoFecha = new System.Windows.Forms.Label();
            this.lblPedidoFolio = new System.Windows.Forms.Label();
            this.dtFechaPedidoIni = new System.Windows.Forms.DateTimePicker();
            this.dtFechaPedidoFin = new System.Windows.Forms.DateTimePicker();
            this.txtEntradaIni = new System.Windows.Forms.TextBox();
            this.txtEntradaFin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPedidoIni = new System.Windows.Forms.TextBox();
            this.txtPedidoFin = new System.Windows.Forms.TextBox();
            this.cmbTipoPedido = new System.Windows.Forms.ComboBox();
            this.chkSituacion = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSituacion = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.chkArea = new System.Windows.Forms.CheckBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtCveArea = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIni.Location = new System.Drawing.Point(174, 3);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(104, 20);
            this.dtFechaIni.TabIndex = 0;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(310, 3);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(104, 20);
            this.dtFechaFin.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Del";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkEntradaFolio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkEntradaFecha, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtFechaFin, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtFechaIni, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkPedidoTipo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkPedidoFecha, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkPedidoFolio, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPedidoTipo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPedidoFecha, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPedidoFolio, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtFechaPedidoIni, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtFechaPedidoFin, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtEntradaIni, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEntradaFin, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label14, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPedidoIni, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPedidoFin, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoPedido, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkSituacion, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbSituacion, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbArea, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnImprimir, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.chkArea, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblArea, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtCveArea, 2, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 253);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprimir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::Almacen.View.Properties.Resources.print_32;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(332, 188);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(68, 58);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Folio de Entrada";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkEntradaFolio
            // 
            this.chkEntradaFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEntradaFolio.AutoSize = true;
            this.chkEntradaFolio.Location = new System.Drawing.Point(3, 32);
            this.chkEntradaFolio.Name = "chkEntradaFolio";
            this.chkEntradaFolio.Size = new System.Drawing.Size(15, 14);
            this.chkEntradaFolio.TabIndex = 37;
            this.chkEntradaFolio.UseVisualStyleBackColor = true;
            // 
            // chkEntradaFecha
            // 
            this.chkEntradaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEntradaFecha.AutoSize = true;
            this.chkEntradaFecha.Location = new System.Drawing.Point(3, 6);
            this.chkEntradaFecha.Name = "chkEntradaFecha";
            this.chkEntradaFecha.Size = new System.Drawing.Size(15, 14);
            this.chkEntradaFecha.TabIndex = 36;
            this.chkEntradaFecha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Al";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fecha de Entrada";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkPedidoTipo
            // 
            this.chkPedidoTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPedidoTipo.AutoSize = true;
            this.chkPedidoTipo.Location = new System.Drawing.Point(3, 85);
            this.chkPedidoTipo.Name = "chkPedidoTipo";
            this.chkPedidoTipo.Size = new System.Drawing.Size(15, 14);
            this.chkPedidoTipo.TabIndex = 39;
            this.chkPedidoTipo.UseVisualStyleBackColor = true;
            // 
            // chkPedidoFecha
            // 
            this.chkPedidoFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPedidoFecha.AutoSize = true;
            this.chkPedidoFecha.Location = new System.Drawing.Point(3, 112);
            this.chkPedidoFecha.Name = "chkPedidoFecha";
            this.chkPedidoFecha.Size = new System.Drawing.Size(15, 14);
            this.chkPedidoFecha.TabIndex = 40;
            this.chkPedidoFecha.UseVisualStyleBackColor = true;
            // 
            // chkPedidoFolio
            // 
            this.chkPedidoFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPedidoFolio.AutoSize = true;
            this.chkPedidoFolio.Location = new System.Drawing.Point(3, 138);
            this.chkPedidoFolio.Name = "chkPedidoFolio";
            this.chkPedidoFolio.Size = new System.Drawing.Size(15, 14);
            this.chkPedidoFolio.TabIndex = 41;
            this.chkPedidoFolio.UseVisualStyleBackColor = true;
            // 
            // lblPedidoTipo
            // 
            this.lblPedidoTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPedidoTipo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblPedidoTipo, 2);
            this.lblPedidoTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoTipo.Location = new System.Drawing.Point(24, 84);
            this.lblPedidoTipo.Name = "lblPedidoTipo";
            this.lblPedidoTipo.Size = new System.Drawing.Size(111, 16);
            this.lblPedidoTipo.TabIndex = 44;
            this.lblPedidoTipo.Text = "Tipo de Pedido";
            this.lblPedidoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPedidoFecha
            // 
            this.lblPedidoFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPedidoFecha.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblPedidoFecha, 2);
            this.lblPedidoFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoFecha.Location = new System.Drawing.Point(24, 111);
            this.lblPedidoFecha.Name = "lblPedidoFecha";
            this.lblPedidoFecha.Size = new System.Drawing.Size(111, 16);
            this.lblPedidoFecha.TabIndex = 45;
            this.lblPedidoFecha.Text = "Fecha del Pedido";
            this.lblPedidoFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPedidoFolio
            // 
            this.lblPedidoFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPedidoFolio.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblPedidoFolio, 2);
            this.lblPedidoFolio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoFolio.Location = new System.Drawing.Point(24, 137);
            this.lblPedidoFolio.Name = "lblPedidoFolio";
            this.lblPedidoFolio.Size = new System.Drawing.Size(111, 16);
            this.lblPedidoFolio.TabIndex = 46;
            this.lblPedidoFolio.Text = "Folio de Pedido";
            this.lblPedidoFolio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtFechaPedidoIni
            // 
            this.dtFechaPedidoIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPedidoIni.Location = new System.Drawing.Point(174, 109);
            this.dtFechaPedidoIni.Name = "dtFechaPedidoIni";
            this.dtFechaPedidoIni.Size = new System.Drawing.Size(104, 20);
            this.dtFechaPedidoIni.TabIndex = 6;
            // 
            // dtFechaPedidoFin
            // 
            this.dtFechaPedidoFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPedidoFin.Location = new System.Drawing.Point(310, 109);
            this.dtFechaPedidoFin.Name = "dtFechaPedidoFin";
            this.dtFechaPedidoFin.Size = new System.Drawing.Size(104, 20);
            this.dtFechaPedidoFin.TabIndex = 7;
            // 
            // txtEntradaIni
            // 
            this.txtEntradaIni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntradaIni.Location = new System.Drawing.Point(174, 29);
            this.txtEntradaIni.MaxLength = 5;
            this.txtEntradaIni.Name = "txtEntradaIni";
            this.txtEntradaIni.Size = new System.Drawing.Size(104, 20);
            this.txtEntradaIni.TabIndex = 2;
            this.txtEntradaIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntradaIni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntradaIni_KeyDown);
            this.txtEntradaIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntradaIni_KeyPress);
            // 
            // txtEntradaFin
            // 
            this.txtEntradaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntradaFin.Location = new System.Drawing.Point(310, 29);
            this.txtEntradaFin.MaxLength = 5;
            this.txtEntradaFin.Name = "txtEntradaFin";
            this.txtEntradaFin.Size = new System.Drawing.Size(112, 20);
            this.txtEntradaFin.TabIndex = 3;
            this.txtEntradaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntradaFin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntradaFin_KeyDown);
            this.txtEntradaFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntradaFin_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "Del";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(141, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "Del";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(141, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 16);
            this.label11.TabIndex = 53;
            this.label11.Text = "Del";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(284, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 54;
            this.label12.Text = "Al";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(284, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 55;
            this.label13.Text = "Al";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(284, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 16);
            this.label14.TabIndex = 56;
            this.label14.Text = "Al";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPedidoIni
            // 
            this.txtPedidoIni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoIni.Location = new System.Drawing.Point(174, 135);
            this.txtPedidoIni.MaxLength = 5;
            this.txtPedidoIni.Name = "txtPedidoIni";
            this.txtPedidoIni.Size = new System.Drawing.Size(104, 20);
            this.txtPedidoIni.TabIndex = 8;
            this.txtPedidoIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPedidoIni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPedidoIni_KeyDown);
            this.txtPedidoIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPedidoIni_KeyPress);
            // 
            // txtPedidoFin
            // 
            this.txtPedidoFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoFin.Location = new System.Drawing.Point(310, 135);
            this.txtPedidoFin.MaxLength = 5;
            this.txtPedidoFin.Name = "txtPedidoFin";
            this.txtPedidoFin.Size = new System.Drawing.Size(112, 20);
            this.txtPedidoFin.TabIndex = 9;
            this.txtPedidoFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPedidoFin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPedidoFin_KeyDown);
            this.txtPedidoFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPedidoFin_KeyPress);
            // 
            // cmbTipoPedido
            // 
            this.cmbTipoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbTipoPedido, 2);
            this.cmbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPedido.FormattingEnabled = true;
            this.cmbTipoPedido.Location = new System.Drawing.Point(141, 82);
            this.cmbTipoPedido.Name = "cmbTipoPedido";
            this.cmbTipoPedido.Size = new System.Drawing.Size(137, 21);
            this.cmbTipoPedido.TabIndex = 5;
            // 
            // chkSituacion
            // 
            this.chkSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSituacion.AutoSize = true;
            this.chkSituacion.Location = new System.Drawing.Point(3, 58);
            this.chkSituacion.Name = "chkSituacion";
            this.chkSituacion.Size = new System.Drawing.Size(15, 14);
            this.chkSituacion.TabIndex = 62;
            this.chkSituacion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Situación";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSituacion
            // 
            this.cmbSituacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbSituacion, 2);
            this.cmbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacion.FormattingEnabled = true;
            this.cmbSituacion.Location = new System.Drawing.Point(141, 55);
            this.cmbSituacion.Name = "cmbSituacion";
            this.cmbSituacion.Size = new System.Drawing.Size(137, 21);
            this.cmbSituacion.TabIndex = 4;
            // 
            // cmbArea
            // 
            this.cmbArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbArea, 4);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(141, 161);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(281, 21);
            this.cmbArea.TabIndex = 11;
            this.cmbArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbArea_KeyDown);
            // 
            // chkArea
            // 
            this.chkArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkArea.AutoSize = true;
            this.chkArea.Location = new System.Drawing.Point(3, 164);
            this.chkArea.Name = "chkArea";
            this.chkArea.Size = new System.Drawing.Size(15, 14);
            this.chkArea.TabIndex = 65;
            this.chkArea.UseVisualStyleBackColor = true;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(24, 163);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 16);
            this.lblArea.TabIndex = 66;
            this.lblArea.Text = "Area";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCveArea
            // 
            this.txtCveArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCveArea.Location = new System.Drawing.Point(65, 161);
            this.txtCveArea.MaxLength = 4;
            this.txtCveArea.Name = "txtCveArea";
            this.txtCveArea.Size = new System.Drawing.Size(70, 20);
            this.txtCveArea.TabIndex = 10;
            this.txtCveArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCveArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCveArea_KeyDown);
            this.txtCveArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCveArea_KeyPress);
            // 
            // FrmDetallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 267);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetallado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmDetallado_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.CheckBox chkEntradaFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkEntradaFolio;
        private System.Windows.Forms.CheckBox chkPedidoTipo;
        private System.Windows.Forms.CheckBox chkPedidoFecha;
        private System.Windows.Forms.CheckBox chkPedidoFolio;
        private System.Windows.Forms.Label lblPedidoTipo;
        private System.Windows.Forms.Label lblPedidoFecha;
        private System.Windows.Forms.Label lblPedidoFolio;
        private System.Windows.Forms.DateTimePicker dtFechaPedidoIni;
        private System.Windows.Forms.DateTimePicker dtFechaPedidoFin;
        private System.Windows.Forms.TextBox txtEntradaIni;
        private System.Windows.Forms.TextBox txtEntradaFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPedidoIni;
        private System.Windows.Forms.TextBox txtPedidoFin;
        private System.Windows.Forms.ComboBox cmbTipoPedido;
        private System.Windows.Forms.CheckBox chkSituacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSituacion;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.CheckBox chkArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtCveArea;
    }
}