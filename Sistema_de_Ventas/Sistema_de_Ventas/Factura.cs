using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aplicativoDataSet);

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aplicativoDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.aplicativoDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'aplicativoDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.aplicativoDataSet.Factura);

            txtFecha.Text = DateTime.Now.ToShortDateString();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            txtId.Clear();
            txtReferencia.Clear();
            txtProducto.Clear();
            txtMarca.Clear();
            txtTalla.Clear();
            txtColor.Clear();
            txtCantidad.Clear();
            txtValorUnitario.Clear();
            txtValorTotal.Clear();
            

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.facturaTableAdapter.Fill(this.aplicativoDataSet.Factura);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIdProveedor.Text == "" || txtCodigo.Text == "" || txtReferencia.Text == "" || txtProducto.Text == "" || txtMarca.Text == "" || txtTalla.Text == "" || txtColor.Text == "" || txtCantidad.Text == ""  || txtValorUnitario.Text == "" || txtValorTotal.Text == "" || txtFecha.Text == "")
            {

                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                this.facturaTableAdapter.Agregar(txtIdProveedor.Text,txtCodigo.Text,txtReferencia.Text,
                    txtProducto.Text,txtMarca.Text,txtTalla.Text,txtColor.Text,txtCantidad.Text,
                    txtValorUnitario.Text,txtValorTotal.Text,txtFecha.Text);
                MessageBox.Show("Se agrego el producto exitosamente");
                this.facturaTableAdapter.Fill(this.aplicativoDataSet.Factura);

                txtFecha.Text = DateTime.Now.ToShortDateString();
                txtId.Clear();
                //   txtIdProveedor.Clear();
                //  txtIdProveedor2.Clear();
                //   cboEmpresa.SelectedIndex = -1;
                //   txtNit.Clear();
                //   txtCodigo.Clear();
                txtReferencia.Clear();
                txtProducto.Clear();
                txtMarca.Clear();
                txtTalla.Clear();
                txtColor.Clear();
                txtCantidad.Clear();
                txtValorUnitario.Clear();
                txtValorTotal.Clear();
            }
        }

        private void txtNit_Leave(object sender, EventArgs e)
        {
            this.proveedorTableAdapter.FillBy(this.aplicativoDataSet.Proveedor, txtNit.Text);

            txtIdProveedor.Text = txtIdProveedor2.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdProveedor.Text == "" || txtCodigo.Text == "" || txtReferencia.Text == "" || txtProducto.Text == ""
                || txtMarca.Text == "" || txtTalla.Text == "" || txtColor.Text == "" || txtCantidad.Text == ""
                || txtValorUnitario.Text == "" || txtValorTotal.Text == "" || txtFecha.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningun Producto");
            }
            else
            {
                if (MessageBox.Show("Desea eliminar el producto" + txtProducto.Text, "Eliminar producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.facturaTableAdapter.Eliminar( txtReferencia.Text);
                    MessageBox.Show("Se elimino exitosamente el producto " + txtProducto.Text);
                    this.facturaTableAdapter.Fill(this.aplicativoDataSet.Factura);

                    txtFecha.Text = DateTime.Now.ToShortDateString();
                    txtId.Clear();
                    txtReferencia.Clear();
                    txtProducto.Clear();
                    txtMarca.Clear();
                    txtTalla.Clear();
                    txtColor.Clear();
                    txtCantidad.Clear();
                    txtValorUnitario.Clear();
                    txtValorTotal.Clear();
                }
                else
                {
                    MessageBox.Show("Se ha cancelado la eliminacion");
                    //|DataDirectory|
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          if (txtIdProveedor.Text == "" || txtCodigo.Text == "" || txtReferencia.Text == "" || txtProducto.Text == ""
             || txtMarca.Text == "" || txtTalla.Text == "" || txtColor.Text == "" || txtCantidad.Text == ""
               || txtValorUnitario.Text == "" || txtValorTotal.Text == "" || txtFecha.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningun Producto");
            }
            else
            {
                this.facturaTableAdapter.Editar(txtIdProveedor.Text, txtCodigo.Text, txtReferencia.Text,
                    txtProducto.Text, txtMarca.Text, txtTalla.Text, txtColor.Text, txtCantidad.Text,
                    txtValorUnitario.Text, txtValorTotal.Text, txtFecha.Text,txtReferencia.Text);

                MessageBox.Show("Se edito exitosamente el producto de referencia" + txtReferencia.Text);
                this.facturaTableAdapter.Fill(this.aplicativoDataSet.Factura);

                txtFecha.Text = DateTime.Now.ToShortDateString();
                txtId.Clear();
                txtReferencia.Clear();
                txtProducto.Clear();
                txtMarca.Clear();
                txtTalla.Clear();
                txtColor.Clear();
                txtCantidad.Clear();
                txtValorUnitario.Clear();
                txtValorTotal.Clear();

            }
        }

     
    }
}
