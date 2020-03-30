namespace Sistema_de_Ventas
{
    partial class Cliente1
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
            System.Windows.Forms.Label id_num_clienteLabel;
            System.Windows.Forms.Label tipo_docLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente1));
            this.aplicativoDataSet = new Sistema_de_Ventas.AplicativoDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new Sistema_de_Ventas.AplicativoDataSetTableAdapters.TableAdapterManager();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.cboTipDoc = new System.Windows.Forms.ComboBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            id_num_clienteLabel = new System.Windows.Forms.Label();
            tipo_docLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // id_num_clienteLabel
            // 
            id_num_clienteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            id_num_clienteLabel.AutoSize = true;
            id_num_clienteLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            id_num_clienteLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            id_num_clienteLabel.ForeColor = System.Drawing.Color.White;
            id_num_clienteLabel.Location = new System.Drawing.Point(29, 78);
            id_num_clienteLabel.Name = "id_num_clienteLabel";
            id_num_clienteLabel.Size = new System.Drawing.Size(109, 17);
            id_num_clienteLabel.TabIndex = 14;
            id_num_clienteLabel.Text = "N° Documento:";
            // 
            // tipo_docLabel
            // 
            tipo_docLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tipo_docLabel.AutoSize = true;
            tipo_docLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            tipo_docLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            tipo_docLabel.ForeColor = System.Drawing.Color.White;
            tipo_docLabel.Location = new System.Drawing.Point(18, 51);
            tipo_docLabel.Name = "tipo_docLabel";
            tipo_docLabel.Size = new System.Drawing.Size(120, 17);
            tipo_docLabel.TabIndex = 16;
            tipo_docLabel.Text = "Tipo Documento:";
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(73, 105);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(65, 17);
            nombreLabel.TabIndex = 17;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            telefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            telefonoLabel.ForeColor = System.Drawing.Color.White;
            telefonoLabel.Location = new System.Drawing.Point(72, 131);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(66, 17);
            telefonoLabel.TabIndex = 19;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoLabel
            // 
            correoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            correoLabel.AutoSize = true;
            correoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            correoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            correoLabel.ForeColor = System.Drawing.Color.White;
            correoLabel.Location = new System.Drawing.Point(81, 157);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(57, 17);
            correoLabel.TabIndex = 21;
            correoLabel.Text = "Correo:";
            // 
            // direccionLabel
            // 
            direccionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            direccionLabel.AutoSize = true;
            direccionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            direccionLabel.ForeColor = System.Drawing.Color.White;
            direccionLabel.Location = new System.Drawing.Point(65, 183);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(73, 17);
            direccionLabel.TabIndex = 23;
            direccionLabel.Text = "Direccion:";
            // 
            // aplicativoDataSet
            // 
            this.aplicativoDataSet.DataSetName = "AplicativoDataSet";
            this.aplicativoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.aplicativoDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_de_Ventas.AplicativoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(306, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 51);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.cboTipDoc);
            this.groupBox1.Controls.Add(id_num_clienteLabel);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtNumDoc);
            this.groupBox1.Controls.Add(tipo_docLabel);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(correoLabel);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 278);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Cliente";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(381, 13);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cboTipDoc
            // 
            this.cboTipDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cboTipDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "tipo_doc", true));
            this.cboTipDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipDoc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cboTipDoc.ForeColor = System.Drawing.Color.White;
            this.cboTipDoc.FormattingEnabled = true;
            this.cboTipDoc.Items.AddRange(new object[] {
            "Cedula Ciudadania",
            "Tarjeta de Identidad",
            "NIT/Razon Social"});
            this.cboTipDoc.Location = new System.Drawing.Point(144, 51);
            this.cboTipDoc.Name = "cboTipDoc";
            this.cboTipDoc.Size = new System.Drawing.Size(231, 25);
            this.cboTipDoc.TabIndex = 0;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNumDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "id_num_cliente", true));
            this.txtNumDoc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumDoc.ForeColor = System.Drawing.Color.White;
            this.txtNumDoc.Location = new System.Drawing.Point(144, 78);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(231, 23);
            this.txtNumDoc.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nombre", true));
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(144, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "telefono", true));
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(144, 131);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(231, 23);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "correo", true));
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(144, 157);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(231, 23);
            this.txtCorreo.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "direccion", true));
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(144, 183);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(231, 23);
            this.txtDireccion.TabIndex = 5;
            // 
            // Cliente1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(445, 289);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(234, 179);
            this.Name = "Cliente1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente1";
            this.Load += new System.EventHandler(this.Cliente1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AplicativoDataSet aplicativoDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private AplicativoDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private AplicativoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ComboBox cboTipDoc;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}