namespace Almacen.View
{
    partial class FrmCatalogoArticulo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatalogoArticulo));
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDesArticulo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuadroBasico = new System.Windows.Forms.TextBox();
            this.lblCuadroBasico = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReorden = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCveArt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbLocalizacion = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtAnaquel = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDesPartida = new System.Windows.Forms.Label();
            this.cmbPresentacionUnidad = new System.Windows.Forms.ComboBox();
            this.lblAdmistracion = new System.Windows.Forms.Label();
            this.cmbAdministracion = new System.Windows.Forms.ComboBox();
            this.cmbTipoMed = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblDosis = new System.Windows.Forms.Label();
            this.lblGramaje = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.txtGramaje = new System.Windows.Forms.TextBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTipoMed = new System.Windows.Forms.Label();
            this.cmbPresentacion = new System.Windows.Forms.ComboBox();
            this.bisArticulo = new System.Windows.Forms.BindingSource(this.components);
            this.bisArticuloFarmacia = new System.Windows.Forms.BindingSource(this.components);
            this.gbLocalizacion.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bisArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bisArticuloFarmacia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPartida
            // 
            this.txtPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartida.Location = new System.Drawing.Point(143, 3);
            this.txtPartida.MaxLength = 10;
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(55, 22);
            this.txtPartida.TabIndex = 0;
            this.txtPartida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPartida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartida_KeyDown);
            this.txtPartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartida_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Partida";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbDesArticulo
            // 
            this.rtbDesArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.rtbDesArticulo, 4);
            this.rtbDesArticulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesArticulo.Location = new System.Drawing.Point(332, 31);
            this.rtbDesArticulo.Name = "rtbDesArticulo";
            this.tableLayoutPanel1.SetRowSpan(this.rtbDesArticulo, 2);
            this.rtbDesArticulo.Size = new System.Drawing.Size(405, 51);
            this.rtbDesArticulo.TabIndex = 2;
            this.rtbDesArticulo.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Descripción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCuadroBasico
            // 
            this.txtCuadroBasico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuadroBasico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuadroBasico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuadroBasico.Location = new System.Drawing.Point(431, 88);
            this.txtCuadroBasico.MaxLength = 9;
            this.txtCuadroBasico.Name = "txtCuadroBasico";
            this.txtCuadroBasico.Size = new System.Drawing.Size(218, 22);
            this.txtCuadroBasico.TabIndex = 4;
            this.txtCuadroBasico.Visible = false;
            this.txtCuadroBasico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuadroBasico_KeyDown);
            this.txtCuadroBasico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuadroBasico_KeyPress);
            // 
            // lblCuadroBasico
            // 
            this.lblCuadroBasico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuadroBasico.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblCuadroBasico, 2);
            this.lblCuadroBasico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuadroBasico.Location = new System.Drawing.Point(332, 91);
            this.lblCuadroBasico.Name = "lblCuadroBasico";
            this.lblCuadroBasico.Size = new System.Drawing.Size(93, 16);
            this.lblCuadroBasico.TabIndex = 22;
            this.lblCuadroBasico.Text = "Cuadro Básico";
            this.lblCuadroBasico.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Presentación";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(359, 116);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(66, 22);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "C/";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Unidad de Almacén";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Máximo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaximo
            // 
            this.txtMaximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaximo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximo.Location = new System.Drawing.Point(103, 31);
            this.txtMaximo.MaxLength = 5;
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(71, 22);
            this.txtMaximo.TabIndex = 14;
            this.txtMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaximo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaximo_KeyDown);
            this.txtMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximo_KeyPress);
            // 
            // txtMinimo
            // 
            this.txtMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinimo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimo.Location = new System.Drawing.Point(103, 3);
            this.txtMinimo.MaxLength = 5;
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(71, 22);
            this.txtMinimo.TabIndex = 13;
            this.txtMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinimo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinimo_KeyDown);
            this.txtMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimo_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mínimo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReorden
            // 
            this.txtReorden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReorden.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReorden.Location = new System.Drawing.Point(103, 59);
            this.txtReorden.MaxLength = 5;
            this.txtReorden.Name = "txtReorden";
            this.txtReorden.Size = new System.Drawing.Size(71, 22);
            this.txtReorden.TabIndex = 15;
            this.txtReorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReorden.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReorden_KeyDown);
            this.txtReorden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReorden_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Punto Reorden";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCveArt
            // 
            this.txtCveArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCveArt.Enabled = false;
            this.txtCveArt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCveArt.Location = new System.Drawing.Point(143, 31);
            this.txtCveArt.MaxLength = 10;
            this.txtCveArt.Name = "txtCveArt";
            this.txtCveArt.Size = new System.Drawing.Size(55, 22);
            this.txtCveArt.TabIndex = 1;
            this.txtCveArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCveArt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCveArt_KeyDown);
            this.txtCveArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCveArt_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Clave Artículo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Nivel";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Anaquel";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "Area";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbLocalizacion
            // 
            this.gbLocalizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gbLocalizacion, 3);
            this.gbLocalizacion.Controls.Add(this.tableLayoutPanel3);
            this.gbLocalizacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocalizacion.Location = new System.Drawing.Point(359, 255);
            this.gbLocalizacion.Name = "gbLocalizacion";
            this.gbLocalizacion.Size = new System.Drawing.Size(378, 113);
            this.gbLocalizacion.TabIndex = 16;
            this.gbLocalizacion.TabStop = false;
            this.gbLocalizacion.Text = "Localización";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.txtNivel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtAnaquel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtArea, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 92);
            this.tableLayoutPanel3.TabIndex = 53;
            // 
            // txtNivel
            // 
            this.txtNivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNivel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivel.Location = new System.Drawing.Point(64, 59);
            this.txtNivel.MaxLength = 20;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(305, 22);
            this.txtNivel.TabIndex = 18;
            this.txtNivel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNivel_KeyDown);
            // 
            // txtAnaquel
            // 
            this.txtAnaquel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnaquel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnaquel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnaquel.Location = new System.Drawing.Point(64, 31);
            this.txtAnaquel.MaxLength = 20;
            this.txtAnaquel.Name = "txtAnaquel";
            this.txtAnaquel.Size = new System.Drawing.Size(305, 22);
            this.txtAnaquel.TabIndex = 17;
            this.txtAnaquel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnaquel_KeyDown);
            // 
            // txtArea
            // 
            this.txtArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArea.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(64, 3);
            this.txtArea.MaxLength = 20;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(305, 22);
            this.txtArea.TabIndex = 16;
            this.txtArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArea_KeyDown);
            // 
            // gbControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbControl, 2);
            this.gbControl.Controls.Add(this.tableLayoutPanel2);
            this.gbControl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControl.Location = new System.Drawing.Point(143, 255);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(183, 113);
            this.gbControl.TabIndex = 13;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control Stock";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.txtReorden, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMaximo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMinimo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(177, 92);
            this.tableLayoutPanel2.TabIndex = 53;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblDesPartida, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPresentacionUnidad, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPartida, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCveArt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCuadroBasico, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCuadroBasico, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rtbDesArticulo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCantidad, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblAdmistracion, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbAdministracion, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.gbControl, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.gbLocalizacion, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoMed, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblGrupo, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblDosis, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblGramaje, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtGrupo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtDosis, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtGramaje, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cmbUnidad, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 5, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblTipoMed, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbPresentacion, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 445);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // lblDesPartida
            // 
            this.lblDesPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lblDesPartida, 5);
            this.lblDesPartida.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesPartida.Location = new System.Drawing.Point(204, 6);
            this.lblDesPartida.Name = "lblDesPartida";
            this.lblDesPartida.Size = new System.Drawing.Size(533, 16);
            this.lblDesPartida.TabIndex = 44;
            this.lblDesPartida.Text = "lblDesPartida";
            this.lblDesPartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPresentacionUnidad
            // 
            this.cmbPresentacionUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPresentacionUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresentacionUnidad.FormattingEnabled = true;
            this.cmbPresentacionUnidad.Location = new System.Drawing.Point(431, 116);
            this.cmbPresentacionUnidad.Name = "cmbPresentacionUnidad";
            this.cmbPresentacionUnidad.Size = new System.Drawing.Size(218, 21);
            this.cmbPresentacionUnidad.TabIndex = 7;
            // 
            // lblAdmistracion
            // 
            this.lblAdmistracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmistracion.AutoSize = true;
            this.lblAdmistracion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmistracion.Location = new System.Drawing.Point(3, 146);
            this.lblAdmistracion.Name = "lblAdmistracion";
            this.lblAdmistracion.Size = new System.Drawing.Size(134, 16);
            this.lblAdmistracion.TabIndex = 54;
            this.lblAdmistracion.Text = "Via de Administración";
            this.lblAdmistracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAdmistracion.Visible = false;
            // 
            // cmbAdministracion
            // 
            this.cmbAdministracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbAdministracion, 2);
            this.cmbAdministracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdministracion.FormattingEnabled = true;
            this.cmbAdministracion.Location = new System.Drawing.Point(143, 144);
            this.cmbAdministracion.Name = "cmbAdministracion";
            this.cmbAdministracion.Size = new System.Drawing.Size(183, 21);
            this.cmbAdministracion.TabIndex = 8;
            this.cmbAdministracion.Visible = false;
            // 
            // cmbTipoMed
            // 
            this.cmbTipoMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMed.FormattingEnabled = true;
            this.cmbTipoMed.Location = new System.Drawing.Point(431, 144);
            this.cmbTipoMed.Name = "cmbTipoMed";
            this.cmbTipoMed.Size = new System.Drawing.Size(218, 21);
            this.cmbTipoMed.TabIndex = 9;
            this.cmbTipoMed.Visible = false;
            // 
            // lblGrupo
            // 
            this.lblGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(3, 174);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(134, 16);
            this.lblGrupo.TabIndex = 58;
            this.lblGrupo.Text = "Grupo";
            this.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGrupo.Visible = false;
            // 
            // lblDosis
            // 
            this.lblDosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDosis.AutoSize = true;
            this.lblDosis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDosis.Location = new System.Drawing.Point(3, 202);
            this.lblDosis.Name = "lblDosis";
            this.lblDosis.Size = new System.Drawing.Size(134, 16);
            this.lblDosis.TabIndex = 59;
            this.lblDosis.Text = "Dosis";
            this.lblDosis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDosis.Visible = false;
            // 
            // lblGramaje
            // 
            this.lblGramaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGramaje.AutoSize = true;
            this.lblGramaje.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramaje.Location = new System.Drawing.Point(3, 230);
            this.lblGramaje.Name = "lblGramaje";
            this.lblGramaje.Size = new System.Drawing.Size(134, 16);
            this.lblGramaje.TabIndex = 60;
            this.lblGramaje.Text = "Gramaje";
            this.lblGramaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGramaje.Visible = false;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txtGrupo, 5);
            this.txtGrupo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.Location = new System.Drawing.Point(143, 171);
            this.txtGrupo.MaxLength = 200;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(506, 22);
            this.txtGrupo.TabIndex = 10;
            this.txtGrupo.Visible = false;
            this.txtGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGrupo_KeyDown);
            // 
            // txtDosis
            // 
            this.txtDosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDosis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDosis, 5);
            this.txtDosis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosis.Location = new System.Drawing.Point(143, 199);
            this.txtDosis.MaxLength = 200;
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(506, 22);
            this.txtDosis.TabIndex = 11;
            this.txtDosis.Visible = false;
            this.txtDosis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDosis_KeyDown);
            // 
            // txtGramaje
            // 
            this.txtGramaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGramaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txtGramaje, 5);
            this.txtGramaje.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGramaje.Location = new System.Drawing.Point(143, 227);
            this.txtGramaje.MaxLength = 200;
            this.txtGramaje.Name = "txtGramaje";
            this.txtGramaje.Size = new System.Drawing.Size(506, 22);
            this.txtGramaje.TabIndex = 12;
            this.txtGramaje.Visible = false;
            this.txtGramaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGramaje_KeyDown);
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbUnidad, 2);
            this.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Location = new System.Drawing.Point(143, 88);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(183, 21);
            this.cmbUnidad.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.btnCancelar, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnGuardar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnModificar, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAgregar, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(431, 374);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(306, 71);
            this.tableLayoutPanel4.TabIndex = 65;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Almacen.View.Properties.Resources.delete_32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(225, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 58);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Almacen.View.Properties.Resources.save_ico;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(68, 58);
            this.btnGuardar.TabIndex = 55;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::Almacen.View.Properties.Resources.pencil_32;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(151, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(68, 58);
            this.btnModificar.TabIndex = 54;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::Almacen.View.Properties.Resources.plus_ico;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(77, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 58);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTipoMed
            // 
            this.lblTipoMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoMed.AutoSize = true;
            this.lblTipoMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMed.Location = new System.Drawing.Point(359, 146);
            this.lblTipoMed.Name = "lblTipoMed";
            this.lblTipoMed.Size = new System.Drawing.Size(66, 16);
            this.lblTipoMed.TabIndex = 57;
            this.lblTipoMed.Text = "Tipo Med.";
            this.lblTipoMed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTipoMed.Visible = false;
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.cmbPresentacion, 2);
            this.cmbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Location = new System.Drawing.Point(143, 116);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(183, 21);
            this.cmbPresentacion.TabIndex = 5;
            // 
            // bisArticulo
            // 
            this.bisArticulo.DataSource = typeof(Almacen.Data.Entities.Articulo);
            // 
            // bisArticuloFarmacia
            // 
            this.bisArticuloFarmacia.DataSource = typeof(Almacen.Data.Entities.ArticuloFarmacia);
            // 
            // FrmCatalogoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 469);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(969, 633);
            this.MinimizeBox = false;
            this.Name = "FrmCatalogoArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Artículos";
            this.gbLocalizacion.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bisArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bisArticuloFarmacia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPartida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDesArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuadroBasico;
        private System.Windows.Forms.Label lblCuadroBasico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReorden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCveArt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbLocalizacion;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDesPartida;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtAnaquel;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbPresentacion;
        private System.Windows.Forms.ComboBox cmbPresentacionUnidad;
        private System.Windows.Forms.Label lblAdmistracion;
        private System.Windows.Forms.ComboBox cmbAdministracion;
        private System.Windows.Forms.ComboBox cmbTipoMed;
        private System.Windows.Forms.Label lblTipoMed;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblDosis;
        private System.Windows.Forms.Label lblGramaje;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.TextBox txtGramaje;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.BindingSource bisArticulo;
        private System.Windows.Forms.BindingSource bisArticuloFarmacia;
    }
}