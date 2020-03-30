namespace Sistema_de_Ventas
{
    partial class Producto
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
            System.Windows.Forms.Label categoriaLabel1;
            System.Windows.Forms.Label fechaLabel1;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label productoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label tallaLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRefeBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.txtIdFactura2 = new System.Windows.Forms.TextBox();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aplicativoDataSet = new Sistema_de_Ventas.AplicativoDataSet();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDescuento = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaTableAdapter = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.FacturaTableAdapter();
            this.tableAdapterManager = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.TableAdapterManager();
            this.productoTableAdapter = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.ProductoTableAdapter();
            this.txtVUnitario = new System.Windows.Forms.TextBox();
            categoriaLabel1 = new System.Windows.Forms.Label();
            fechaLabel1 = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            productoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            tallaLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaLabel1
            // 
            categoriaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            categoriaLabel1.AutoSize = true;
            categoriaLabel1.Location = new System.Drawing.Point(72, 204);
            categoriaLabel1.Name = "categoriaLabel1";
            categoriaLabel1.Size = new System.Drawing.Size(79, 17);
            categoriaLabel1.TabIndex = 84;
            categoriaLabel1.Text = "Categoria:";
            // 
            // fechaLabel1
            // 
            fechaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            fechaLabel1.AutoSize = true;
            fechaLabel1.Location = new System.Drawing.Point(100, 349);
            fechaLabel1.Name = "fechaLabel1";
            fechaLabel1.Size = new System.Drawing.Size(51, 17);
            fechaLabel1.TabIndex = 81;
            fechaLabel1.Text = "Fecha:";
            // 
            // valorLabel
            // 
            valorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(105, 291);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(46, 17);
            valorLabel.TabIndex = 73;
            valorLabel.Text = "Valor:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(70, 320);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(81, 17);
            descuentoLabel.TabIndex = 75;
            descuentoLabel.Text = "Descuento:";
            // 
            // estadoLabel
            // 
            estadoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(95, 262);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(56, 17);
            estadoLabel.TabIndex = 78;
            estadoLabel.Text = "Estado:";
            // 
            // codigoLabel
            // 
            codigoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(89, 233);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(62, 17);
            codigoLabel.TabIndex = 80;
            codigoLabel.Text = "Codigo:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(71, 30);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(80, 17);
            referenciaLabel.TabIndex = 62;
            referenciaLabel.Text = "Referencia:";
            // 
            // productoLabel
            // 
            productoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            productoLabel.AutoSize = true;
            productoLabel.Location = new System.Drawing.Point(79, 59);
            productoLabel.Name = "productoLabel";
            productoLabel.Size = new System.Drawing.Size(72, 17);
            productoLabel.TabIndex = 64;
            productoLabel.Text = "Producto:";
            // 
            // marcaLabel
            // 
            marcaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(98, 88);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(53, 17);
            marcaLabel.TabIndex = 66;
            marcaLabel.Text = "Marca:";
            // 
            // tallaLabel
            // 
            tallaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tallaLabel.AutoSize = true;
            tallaLabel.Location = new System.Drawing.Point(110, 117);
            tallaLabel.Name = "tallaLabel";
            tallaLabel.Size = new System.Drawing.Size(41, 17);
            tallaLabel.TabIndex = 68;
            tallaLabel.Text = "Talla:";
            // 
            // colorLabel
            // 
            colorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(103, 146);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(48, 17);
            colorLabel.TabIndex = 70;
            colorLabel.Text = "Color:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(76, 175);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(75, 17);
            cantidadLabel.TabIndex = 72;
            cantidadLabel.Text = "Cantidad:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1030, 50);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "INVENTARIO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Referencia:";
            // 
            // txtRefeBuscar
            // 
            this.txtRefeBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRefeBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtRefeBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefeBuscar.ForeColor = System.Drawing.Color.White;
            this.txtRefeBuscar.Location = new System.Drawing.Point(188, 136);
            this.txtRefeBuscar.Name = "txtRefeBuscar";
            this.txtRefeBuscar.Size = new System.Drawing.Size(231, 23);
            this.txtRefeBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(425, 128);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 35);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdFactura2
            // 
            this.txtIdFactura2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdFactura2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdFactura2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdFactura2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "id_factura", true));
            this.txtIdFactura2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdFactura2.Location = new System.Drawing.Point(424, 61);
            this.txtIdFactura2.Name = "txtIdFactura2";
            this.txtIdFactura2.Size = new System.Drawing.Size(40, 16);
            this.txtIdFactura2.TabIndex = 19;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.aplicativoDataSet;
            // 
            // aplicativoDataSet
            // 
            this.aplicativoDataSet.DataSetName = "AplicativoDataSet";
            this.aplicativoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCantidad2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "cantidad", true));
            this.txtCantidad2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCantidad2.Location = new System.Drawing.Point(354, 62);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(35, 16);
            this.txtCantidad2.TabIndex = 35;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "id_producto", true));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtId.Location = new System.Drawing.Point(173, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 16);
            this.txtId.TabIndex = 42;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.aplicativoDataSet;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdFactura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "id_factura", true));
            this.txtIdFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdFactura.Location = new System.Drawing.Point(238, 61);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(43, 16);
            this.txtIdFactura.TabIndex = 44;
            this.txtIdFactura.TextChanged += new System.EventHandler(this.txtIdFactura_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cboDescuento);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(categoriaLabel1);
            this.groupBox2.Controls.Add(this.cboCategoria);
            this.groupBox2.Controls.Add(fechaLabel1);
            this.groupBox2.Controls.Add(this.txtFecha);
            this.groupBox2.Controls.Add(valorLabel);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(descuentoLabel);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(estadoLabel);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(codigoLabel);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(referenciaLabel);
            this.groupBox2.Controls.Add(this.txtReferencia);
            this.groupBox2.Controls.Add(productoLabel);
            this.groupBox2.Controls.Add(this.txtProducto);
            this.groupBox2.Controls.Add(marcaLabel);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(tallaLabel);
            this.groupBox2.Controls.Add(this.txtTalla);
            this.groupBox2.Controls.Add(colorLabel);
            this.groupBox2.Controls.Add(this.txtColor);
            this.groupBox2.Controls.Add(cantidadLabel);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(41, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 462);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del Producto";
            // 
            // cboDescuento
            // 
            this.cboDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cboDescuento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "descuento", true));
            this.cboDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDescuento.ForeColor = System.Drawing.Color.White;
            this.cboDescuento.FormattingEnabled = true;
            this.cboDescuento.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.cboDescuento.Location = new System.Drawing.Point(157, 320);
            this.cboDescuento.Name = "cboDescuento";
            this.cboDescuento.Size = new System.Drawing.Size(231, 25);
            this.cboDescuento.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(0, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 85);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(378, 32);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 29);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(285, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 29);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(192, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 29);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(99, 32);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 29);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(6, 32);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 29);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cboCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "categoria", true));
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.ForeColor = System.Drawing.Color.White;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Blusas",
            "Faldas",
            "Vestidos",
            "Busos Femeninos",
            "Busos Masculinos",
            "Camisas Femeninas",
            "Camisas Masculinas",
            "Chaquetas Femeninas",
            "Chaquetas Masculinas",
            "Jeans Femeninos",
            "Jeans Masculinos",
            "Pantalones Femeninos",
            "Pantalones Masculinos",
            "Ropa Interior Femenina",
            "Ropa Interior Masculina",
            "Ropa Deportiva Femenina",
            "Ropa Deportiva Masculina",
            "Short Femeninos",
            "Short Masculinos"});
            this.cboCategoria.Location = new System.Drawing.Point(157, 204);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(231, 25);
            this.cboCategoria.TabIndex = 1;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFecha.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productoBindingSource, "fecha", true));
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(157, 349);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(111, 23);
            this.txtFecha.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "valor", true));
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(157, 291);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(231, 23);
            this.txtValor.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "cantidad", true));
            this.txtCantidad.Enabled = false;
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(157, 175);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(231, 23);
            this.txtCantidad.TabIndex = 77;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "estado", true));
            this.txtEstado.ForeColor = System.Drawing.Color.White;
            this.txtEstado.Location = new System.Drawing.Point(157, 262);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(231, 23);
            this.txtEstado.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "codigo", true));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(157, 233);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(231, 23);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "referencia", true));
            this.txtReferencia.Enabled = false;
            this.txtReferencia.ForeColor = System.Drawing.Color.White;
            this.txtReferencia.Location = new System.Drawing.Point(157, 30);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(231, 23);
            this.txtReferencia.TabIndex = 63;
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "producto", true));
            this.txtProducto.Enabled = false;
            this.txtProducto.ForeColor = System.Drawing.Color.White;
            this.txtProducto.Location = new System.Drawing.Point(157, 59);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(231, 23);
            this.txtProducto.TabIndex = 65;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "marca", true));
            this.txtMarca.Enabled = false;
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(157, 88);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(231, 23);
            this.txtMarca.TabIndex = 67;
            // 
            // txtTalla
            // 
            this.txtTalla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTalla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "talla", true));
            this.txtTalla.Enabled = false;
            this.txtTalla.ForeColor = System.Drawing.Color.White;
            this.txtTalla.Location = new System.Drawing.Point(157, 117);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(231, 23);
            this.txtTalla.TabIndex = 69;
            // 
            // txtColor
            // 
            this.txtColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "color", true));
            this.txtColor.Enabled = false;
            this.txtColor.ForeColor = System.Drawing.Color.White;
            this.txtColor.Location = new System.Drawing.Point(157, 146);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(231, 23);
            this.txtColor.TabIndex = 71;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Articulo,
            this.Cantidad,
            this.Valor,
            this.Descuento});
            this.dataGridView1.Location = new System.Drawing.Point(539, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(523, 218);
            this.dataGridView1.TabIndex = 12;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Producto";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.productoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(539, 436);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.Size = new System.Drawing.Size(523, 208);
            this.productoDataGridView.TabIndex = 13;
            this.productoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_factura";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_factura";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "categoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descuento";
            this.dataGridViewTextBoxColumn5.HeaderText = "descuento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn6.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn7.HeaderText = "cantidad";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn8.HeaderText = "estado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn9.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = this.facturaTableAdapter;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_de_Ventas.AplicativoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // txtVUnitario
            // 
            this.txtVUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtVUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVUnitario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "valor_unitario", true));
            this.txtVUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtVUnitario.Location = new System.Drawing.Point(238, 90);
            this.txtVUnitario.Name = "txtVUnitario";
            this.txtVUnitario.Size = new System.Drawing.Size(100, 16);
            this.txtVUnitario.TabIndex = 64;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1082, 662);
            this.Controls.Add(this.txtVUnitario);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.txtIdFactura2);
            this.Controls.Add(this.txtCantidad2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtRefeBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRefeBuscar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private AplicativoDataSet aplicativoDataSet;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private AplicativoDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private AplicativoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AplicativoDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.TextBox txtIdFactura2;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox cboDescuento;
        private System.Windows.Forms.TextBox txtVUnitario;
    }
}