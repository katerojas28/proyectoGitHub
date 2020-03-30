namespace Sistema_de_Ventas
{
    partial class Venta2
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
            System.Windows.Forms.Label id_productoLabel;
            System.Windows.Forms.Label id_facturaLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aplicativoDataSet = new Sistema_de_Ventas.AplicativoDataSet();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.TableAdapterManager();
            this.facturaTableAdapter = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.FacturaTableAdapter();
            id_productoLabel = new System.Windows.Forms.Label();
            id_facturaLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_productoLabel
            // 
            id_productoLabel.AutoSize = true;
            id_productoLabel.Location = new System.Drawing.Point(171, 271);
            id_productoLabel.Name = "id_productoLabel";
            id_productoLabel.Size = new System.Drawing.Size(63, 13);
            id_productoLabel.TabIndex = 37;
            id_productoLabel.Text = "id producto:";
            // 
            // id_facturaLabel
            // 
            id_facturaLabel.AutoSize = true;
            id_facturaLabel.Location = new System.Drawing.Point(180, 297);
            id_facturaLabel.Name = "id_facturaLabel";
            id_facturaLabel.Size = new System.Drawing.Size(54, 13);
            id_facturaLabel.TabIndex = 38;
            id_facturaLabel.Text = "id factura:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(201, 323);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(33, 13);
            valorLabel.TabIndex = 39;
            valorLabel.Text = "valor:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(174, 349);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(60, 13);
            descuentoLabel.TabIndex = 40;
            descuentoLabel.Text = "descuento:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(192, 375);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(42, 13);
            codigoLabel.TabIndex = 41;
            codigoLabel.Text = "codigo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtCodigoB);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(151, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(434, 103);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR PRODUCTO";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Codigo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(278, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 35);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCodigoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoB.ForeColor = System.Drawing.Color.White;
            this.txtCodigoB.Location = new System.Drawing.Point(119, 51);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(153, 20);
            this.txtCodigoB.TabIndex = 39;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(694, 18);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 37;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "id_producto", true));
            this.txtIdProducto.Location = new System.Drawing.Point(240, 268);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 38;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.aplicativoDataSet;
            // 
            // aplicativoDataSet
            // 
            this.aplicativoDataSet.DataSetName = "AplicativoDataSet";
            this.aplicativoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "id_factura", true));
            this.txtIdFactura.Location = new System.Drawing.Point(240, 294);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(100, 20);
            this.txtIdFactura.TabIndex = 39;
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "valor", true));
            this.txtValor.Location = new System.Drawing.Point(240, 320);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 40;
            // 
            // txtDescuento
            // 
            this.txtDescuento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "descuento", true));
            this.txtDescuento.Location = new System.Drawing.Point(240, 346);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 41;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "codigo", true));
            this.txtCodigo.Location = new System.Drawing.Point(240, 372);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 42;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.aplicativoDataSet;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_de_Ventas.AplicativoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // Venta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(745, 504);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(id_facturaLabel);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(id_productoLabel);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta2";
            this.Load += new System.EventHandler(this.Venta2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.PictureBox btnCerrar;
        private AplicativoDataSet aplicativoDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private AplicativoDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private AplicativoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private AplicativoDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
    }
}