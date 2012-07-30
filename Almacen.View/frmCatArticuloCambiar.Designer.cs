namespace Almacen.View
{
    partial class FrmCatArticuloCambiar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatArticuloCambiar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCuadroBasico = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuadroBasico = new System.Windows.Forms.TextBox();
            this.lblPartida = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCveArt = new System.Windows.Forms.TextBox();
            this.rtbDesArticulo = new System.Windows.Forms.RichTextBox();
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.lblDesPartida = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCuadroBasico, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCuadroBasico, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPartida, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCveArt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbDesArticulo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPartida, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDesPartida, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 192);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.Controls.Add(this.btnGuardar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnModificar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCancelar, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(280, 116);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(499, 66);
            this.tableLayoutPanel4.TabIndex = 66;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Almacen.View.Properties.Resources.save_ico;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(277, 4);
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
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::Almacen.View.Properties.Resources.pencil_32;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(353, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(68, 58);
            this.btnModificar.TabIndex = 54;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Almacen.View.Properties.Resources.delete_32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(428, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 58);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCuadroBasico
            // 
            this.lblCuadroBasico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCuadroBasico.AutoSize = true;
            this.lblCuadroBasico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuadroBasico.Location = new System.Drawing.Point(3, 63);
            this.lblCuadroBasico.Name = "lblCuadroBasico";
            this.lblCuadroBasico.Size = new System.Drawing.Size(93, 16);
            this.lblCuadroBasico.TabIndex = 24;
            this.lblCuadroBasico.Text = "Cuadro Básico";
            this.lblCuadroBasico.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Descripción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCuadroBasico
            // 
            this.txtCuadroBasico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuadroBasico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.txtCuadroBasico, 2);
            this.txtCuadroBasico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuadroBasico.Location = new System.Drawing.Point(102, 60);
            this.txtCuadroBasico.MaxLength = 9;
            this.txtCuadroBasico.Name = "txtCuadroBasico";
            this.txtCuadroBasico.Size = new System.Drawing.Size(172, 22);
            this.txtCuadroBasico.TabIndex = 2;
            this.txtCuadroBasico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuadroBasico.Visible = false;
            this.txtCuadroBasico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuadroBasico_KeyDown);
            this.txtCuadroBasico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuadroBasico_KeyPress);
            // 
            // lblPartida
            // 
            this.lblPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPartida.AutoSize = true;
            this.lblPartida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartida.Location = new System.Drawing.Point(3, 91);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(93, 16);
            this.lblPartida.TabIndex = 48;
            this.lblPartida.Text = "Partida";
            this.lblPartida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPartida.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 50;
            this.label11.Text = "Clave Artículo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCveArt
            // 
            this.txtCveArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCveArt.Enabled = false;
            this.txtCveArt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCveArt.Location = new System.Drawing.Point(102, 3);
            this.txtCveArt.MaxLength = 10;
            this.txtCveArt.Name = "txtCveArt";
            this.txtCveArt.Size = new System.Drawing.Size(90, 22);
            this.txtCveArt.TabIndex = 0;
            this.txtCveArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCveArt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCveArt_KeyDown);
            this.txtCveArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCveArt_KeyPress);
            // 
            // rtbDesArticulo
            // 
            this.rtbDesArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDesArticulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesArticulo.Location = new System.Drawing.Point(280, 3);
            this.rtbDesArticulo.Name = "rtbDesArticulo";
            this.tableLayoutPanel1.SetRowSpan(this.rtbDesArticulo, 2);
            this.rtbDesArticulo.Size = new System.Drawing.Size(499, 51);
            this.rtbDesArticulo.TabIndex = 1;
            this.rtbDesArticulo.Text = "";
            // 
            // txtPartida
            // 
            this.txtPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartida.Location = new System.Drawing.Point(102, 88);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(90, 22);
            this.txtPartida.TabIndex = 3;
            this.txtPartida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPartida.Visible = false;
            this.txtPartida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartida_KeyDown);
            this.txtPartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartida_KeyPress);
            // 
            // lblDesPartida
            // 
            this.lblDesPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lblDesPartida, 2);
            this.lblDesPartida.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesPartida.Location = new System.Drawing.Point(198, 91);
            this.lblDesPartida.Name = "lblDesPartida";
            this.lblDesPartida.Size = new System.Drawing.Size(581, 16);
            this.lblDesPartida.TabIndex = 51;
            this.lblDesPartida.Text = "lblDesPartida";
            this.lblDesPartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDesPartida.Visible = false;
            // 
            // FrmCatArticuloCambiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 215);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCatArticuloCambiar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de Articulos - Cambiar de . . .";
            this.Load += new System.EventHandler(this.FrmCatArticuloCambiar_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCveArt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtbDesArticulo;
        private System.Windows.Forms.Label lblCuadroBasico;
        private System.Windows.Forms.TextBox txtCuadroBasico;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.TextBox txtPartida;
        private System.Windows.Forms.Label lblDesPartida;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
    }
}