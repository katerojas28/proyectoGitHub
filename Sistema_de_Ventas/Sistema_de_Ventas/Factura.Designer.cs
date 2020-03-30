namespace Sistema_de_Ventas
{
    partial class Factura
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
            System.Windows.Forms.Label cod_facturaLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label productoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label tallaLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label valor_unitarioLabel;
            System.Windows.Forms.Label valor_totalLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label nitLabel;
            System.Windows.Forms.Label empresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aplicativoDataSet = new Sistema_de_Ventas.AplicativoDataSet();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtIdProveedor2 = new System.Windows.Forms.TextBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNit = new System.Windows.Forms.TextBox();
            this.facturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.facturaTableAdapter = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.FacturaTableAdapter();
            this.tableAdapterManager = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.TableAdapterManager();
            this.proveedorTableAdapter = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.ProveedorTableAdapter();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            cod_facturaLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            productoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            tallaLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            valor_unitarioLabel = new System.Windows.Forms.Label();
            valor_totalLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            nitLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_facturaLabel
            // 
            cod_facturaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cod_facturaLabel.AutoSize = true;
            cod_facturaLabel.ForeColor = System.Drawing.Color.White;
            cod_facturaLabel.Location = new System.Drawing.Point(706, 168);
            cod_facturaLabel.Name = "cod_facturaLabel";
            cod_facturaLabel.Size = new System.Drawing.Size(115, 17);
            cod_facturaLabel.TabIndex = 19;
            cod_facturaLabel.Text = "Codigo Factura:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            referenciaLabel.AutoSize = true;
            referenciaLabel.ForeColor = System.Drawing.Color.White;
            referenciaLabel.Location = new System.Drawing.Point(145, 228);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(80, 17);
            referenciaLabel.TabIndex = 21;
            referenciaLabel.Text = "Referencia:";
            // 
            // productoLabel
            // 
            productoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            productoLabel.AutoSize = true;
            productoLabel.ForeColor = System.Drawing.Color.White;
            productoLabel.Location = new System.Drawing.Point(248, 228);
            productoLabel.Name = "productoLabel";
            productoLabel.Size = new System.Drawing.Size(72, 17);
            productoLabel.TabIndex = 23;
            productoLabel.Text = "Producto:";
            // 
            // marcaLabel
            // 
            marcaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            marcaLabel.AutoSize = true;
            marcaLabel.ForeColor = System.Drawing.Color.White;
            marcaLabel.Location = new System.Drawing.Point(348, 228);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(53, 17);
            marcaLabel.TabIndex = 25;
            marcaLabel.Text = "Marca:";
            // 
            // tallaLabel
            // 
            tallaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tallaLabel.AutoSize = true;
            tallaLabel.ForeColor = System.Drawing.Color.White;
            tallaLabel.Location = new System.Drawing.Point(450, 228);
            tallaLabel.Name = "tallaLabel";
            tallaLabel.Size = new System.Drawing.Size(41, 17);
            tallaLabel.TabIndex = 27;
            tallaLabel.Text = "Talla:";
            // 
            // colorLabel
            // 
            colorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            colorLabel.AutoSize = true;
            colorLabel.ForeColor = System.Drawing.Color.White;
            colorLabel.Location = new System.Drawing.Point(550, 228);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(48, 17);
            colorLabel.TabIndex = 29;
            colorLabel.Text = "Color:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            cantidadLabel.AutoSize = true;
            cantidadLabel.ForeColor = System.Drawing.Color.White;
            cantidadLabel.Location = new System.Drawing.Point(651, 228);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(75, 17);
            cantidadLabel.TabIndex = 31;
            cantidadLabel.Text = "Cantidad:";
            // 
            // valor_unitarioLabel
            // 
            valor_unitarioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            valor_unitarioLabel.AutoSize = true;
            valor_unitarioLabel.ForeColor = System.Drawing.Color.White;
            valor_unitarioLabel.Location = new System.Drawing.Point(752, 228);
            valor_unitarioLabel.Name = "valor_unitarioLabel";
            valor_unitarioLabel.Size = new System.Drawing.Size(99, 17);
            valor_unitarioLabel.TabIndex = 33;
            valor_unitarioLabel.Text = "Valor Unitario:";
            // 
            // valor_totalLabel
            // 
            valor_totalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            valor_totalLabel.AutoSize = true;
            valor_totalLabel.ForeColor = System.Drawing.Color.White;
            valor_totalLabel.Location = new System.Drawing.Point(855, 228);
            valor_totalLabel.Name = "valor_totalLabel";
            valor_totalLabel.Size = new System.Drawing.Size(81, 17);
            valor_totalLabel.TabIndex = 35;
            valor_totalLabel.Text = "Valor Total:";
            // 
            // fechaLabel
            // 
            fechaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            fechaLabel.AutoSize = true;
            fechaLabel.ForeColor = System.Drawing.Color.White;
            fechaLabel.Location = new System.Drawing.Point(956, 228);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(51, 17);
            fechaLabel.TabIndex = 37;
            fechaLabel.Text = "Fecha:";
            // 
            // nitLabel
            // 
            nitLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nitLabel.AutoSize = true;
            nitLabel.ForeColor = System.Drawing.Color.White;
            nitLabel.Location = new System.Drawing.Point(182, 167);
            nitLabel.Name = "nitLabel";
            nitLabel.Size = new System.Drawing.Size(30, 17);
            nitLabel.TabIndex = 42;
            nitLabel.Text = "NIT:";
            // 
            // empresaLabel
            // 
            empresaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            empresaLabel.AutoSize = true;
            empresaLabel.ForeColor = System.Drawing.Color.White;
            empresaLabel.Location = new System.Drawing.Point(428, 167);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(67, 17);
            empresaLabel.TabIndex = 47;
            empresaLabel.Text = "Empresa:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(490, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "FACTURAS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1138, 50);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "id_factura", true));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtId.Location = new System.Drawing.Point(55, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(10, 16);
            this.txtId.TabIndex = 16;
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
            // txtIdProveedor
            // 
            this.txtIdProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "id_proveedor", true));
            this.txtIdProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdProveedor.Location = new System.Drawing.Point(101, 61);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(10, 16);
            this.txtIdProveedor.TabIndex = 18;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "cod_factura", true));
            this.txtCodigo.ForeColor = System.Drawing.Color.LightGray;
            this.txtCodigo.Location = new System.Drawing.Point(825, 165);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(188, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "referencia", true));
            this.txtReferencia.ForeColor = System.Drawing.Color.LightGray;
            this.txtReferencia.Location = new System.Drawing.Point(145, 248);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(96, 23);
            this.txtReferencia.TabIndex = 2;
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "producto", true));
            this.txtProducto.ForeColor = System.Drawing.Color.LightGray;
            this.txtProducto.Location = new System.Drawing.Point(246, 248);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(96, 23);
            this.txtProducto.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "marca", true));
            this.txtMarca.ForeColor = System.Drawing.Color.LightGray;
            this.txtMarca.Location = new System.Drawing.Point(346, 248);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(96, 23);
            this.txtMarca.TabIndex = 4;
            // 
            // txtTalla
            // 
            this.txtTalla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTalla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "talla", true));
            this.txtTalla.ForeColor = System.Drawing.Color.LightGray;
            this.txtTalla.Location = new System.Drawing.Point(447, 248);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(96, 23);
            this.txtTalla.TabIndex = 5;
            // 
            // txtColor
            // 
            this.txtColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "color", true));
            this.txtColor.ForeColor = System.Drawing.Color.LightGray;
            this.txtColor.Location = new System.Drawing.Point(548, 248);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(96, 23);
            this.txtColor.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "cantidad", true));
            this.txtCantidad.ForeColor = System.Drawing.Color.LightGray;
            this.txtCantidad.Location = new System.Drawing.Point(649, 248);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(96, 23);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorUnitario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "valor_unitario", true));
            this.txtValorUnitario.ForeColor = System.Drawing.Color.LightGray;
            this.txtValorUnitario.Location = new System.Drawing.Point(750, 248);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(96, 23);
            this.txtValorUnitario.TabIndex = 8;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturaBindingSource, "valor_total", true));
            this.txtValorTotal.ForeColor = System.Drawing.Color.LightGray;
            this.txtValorTotal.Location = new System.Drawing.Point(852, 248);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(96, 23);
            this.txtValorTotal.TabIndex = 9;
            // 
            // txtIdProveedor2
            // 
            this.txtIdProveedor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdProveedor2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProveedor2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "id_proveedor", true));
            this.txtIdProveedor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdProveedor2.Location = new System.Drawing.Point(684, 61);
            this.txtIdProveedor2.Name = "txtIdProveedor2";
            this.txtIdProveedor2.Size = new System.Drawing.Size(10, 16);
            this.txtIdProveedor2.TabIndex = 39;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.aplicativoDataSet;
            // 
            // txtNit
            // 
            this.txtNit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "nit", true));
            this.txtNit.ForeColor = System.Drawing.Color.LightGray;
            this.txtNit.Location = new System.Drawing.Point(212, 163);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(188, 23);
            this.txtNit.TabIndex = 0;
            this.txtNit.Leave += new System.EventHandler(this.txtNit_Leave);
            // 
            // facturaDataGridView
            // 
            this.facturaDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.facturaDataGridView.AutoGenerateColumns = false;
            this.facturaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.facturaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.facturaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.facturaDataGridView.DataSource = this.facturaBindingSource;
            this.facturaDataGridView.Location = new System.Drawing.Point(60, 397);
            this.facturaDataGridView.Name = "facturaDataGridView";
            this.facturaDataGridView.Size = new System.Drawing.Size(1063, 206);
            this.facturaDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_proveedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id-Proveedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cod_factura";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "referencia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Referencia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "producto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "marca";
            this.dataGridViewTextBoxColumn6.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "talla";
            this.dataGridViewTextBoxColumn7.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn8.HeaderText = "Color";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "valor_unitario";
            this.dataGridViewTextBoxColumn10.HeaderText = "V/U";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "valor_total";
            this.dataGridViewTextBoxColumn11.HeaderText = "V. Total";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn12.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(328, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 85);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(439, 32);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 29);
            this.btnActualizar.TabIndex = 15;
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
            this.btnCancelar.Location = new System.Drawing.Point(334, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 29);
            this.btnCancelar.TabIndex = 14;
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
            this.btnEliminar.Location = new System.Drawing.Point(225, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 29);
            this.btnEliminar.TabIndex = 13;
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
            this.btnEditar.Location = new System.Drawing.Point(121, 32);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 29);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(19, 32);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 29);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empresaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.empresaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "empresa", true));
            this.empresaTextBox.Enabled = false;
            this.empresaTextBox.Location = new System.Drawing.Point(497, 163);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(188, 23);
            this.empresaTextBox.TabIndex = 50;
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
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sistema_de_Ventas.AplicativoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFecha.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facturaBindingSource, "fecha", true));
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(953, 248);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(107, 23);
            this.txtFecha.TabIndex = 10;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1195, 623);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.facturaDataGridView);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.txtIdProveedor2);
            this.Controls.Add(nitLabel);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(cod_facturaLabel);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(referenciaLabel);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(productoLabel);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(tallaLabel);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(valor_unitarioLabel);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(valor_totalLabel);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private AplicativoDataSet aplicativoDataSet;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private AplicativoDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private AplicativoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AplicativoDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.TextBox txtIdProveedor2;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.DataGridView facturaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.DateTimePicker txtFecha;
    }
}