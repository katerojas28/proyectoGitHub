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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void facturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aplicativoDataSet);

        }

        private void Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aplicativoDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.aplicativoDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'aplicativoDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.aplicativoDataSet.Factura);
           

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.facturaTableAdapter.Fill(this.aplicativoDataSet.Factura);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtIdFactura.Clear();
            txtIdFactura2.Clear();
            txtCantidad2.Clear();
            txtReferencia.Clear();
            txtProducto.Clear();
            txtMarca.Clear();
            txtTalla.Clear();
            txtColor.Clear();
            txtCantidad.Clear();
            cboCategoria.SelectedIndex = 0;
            txtCodigo.Clear();
            txtEstado.Clear();
            txtValor.Clear();
            cboDescuento.SelectedIndex = 0;
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtRefeBuscar.Text == "")
            {
                MessageBox.Show("Ingrese el N° de referencia del producto");
            }
            else
            {
                this.facturaTableAdapter.FillBy(this.aplicativoDataSet.Factura, txtRefeBuscar.Text);
            }
            if (txtReferencia.Text == txtRefeBuscar.Text)
            {
                MessageBox.Show("Producto encontrado");
              //  txtIdFactura.Text = txtIdFactura2.Text;
                txtCantidad.Text = txtCantidad2.Text;
                txtCodigo.Text = txtReferencia.Text + " - ";
                txtRefeBuscar.Clear();                              
            }
            else
            {
                MessageBox.Show("No existe ningun producto con ese N° de refrencia, por favor verifique");
                txtRefeBuscar.Clear();
                this.facturaTableAdapter.Fill(this.aplicativoDataSet.Factura);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == txtReferencia.Text + " - " || txtCodigo.Text == "" || txtReferencia.Text == "" || txtEstado.Text == "" || txtValor.Text == "")
            {

                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                this.productoTableAdapter.Agregar(txtIdFactura2.Text,cboCategoria.Text,txtValor.Text,cboDescuento.Text,txtFecha.Text,txtCantidad.Text,txtEstado.Text,txtCodigo.Text);
                MessageBox.Show("Registro exitoso del producto " + txtProducto.Text+" Cod. "+ txtCodigo.Text);
                this.productoTableAdapter.Fill(this.aplicativoDataSet.Producto);

                txtId.Clear();
                txtIdFactura.Clear();
                txtIdFactura2.Clear();
                txtCantidad2.Clear();
                txtReferencia.Clear();
                txtProducto.Clear();
                txtMarca.Clear();
                txtTalla.Clear();
                txtColor.Clear();
                txtCantidad.Clear();
                cboCategoria.SelectedIndex = 0;
                txtCodigo.Clear();
                txtEstado.Clear();
                txtValor.Clear();
                cboDescuento.SelectedIndex = 0;
                txtFecha.Text = DateTime.Now.ToShortDateString();

            }
        }        
        private void txtIdFactura_TextChanged(object sender, EventArgs e)
        {
            if (txtIdFactura.Text != "")
            {
                this.facturaTableAdapter.FillBy1(this.aplicativoDataSet.Factura, int.Parse (txtIdFactura.Text));
            }
        }
        
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text == txtReferencia.Text + " - " || txtCodigo.Text == "" || txtReferencia.Text == "" || txtEstado.Text == "" || txtValor.Text == "")
            {

                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                this.productoTableAdapter.Editar(txtIdFactura2.Text, cboCategoria.Text, txtValor.Text, cboDescuento.Text, txtFecha.Text, txtCantidad.Text, txtEstado.Text, txtCodigo.Text,txtCodigo.Text);
                MessageBox.Show("Se edito exitosamente la informacion del producto " + txtCodigo.Text);
                this.productoTableAdapter.Fill(this.aplicativoDataSet.Producto);

                txtId.Clear();
                txtIdFactura.Clear();
                txtIdFactura2.Clear();
                txtCantidad2.Clear();
                txtReferencia.Clear();
                txtProducto.Clear();
                txtMarca.Clear();
                txtTalla.Clear();
                txtColor.Clear();
                txtCantidad.Clear();
                cboCategoria.SelectedIndex = 0;
                txtCodigo.Clear();
                txtEstado.Clear();
                txtValor.Clear();
                cboDescuento.SelectedIndex = 0;
                txtFecha.Text = DateTime.Now.ToShortDateString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == txtReferencia.Text + " - " || txtCodigo.Text == "" || txtReferencia.Text == "" || txtEstado.Text == "" || txtValor.Text == "")
            {

                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                if (MessageBox.Show("Desea eliminar el registro del producto" + txtCodigo.Text, "Eliminar producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.productoTableAdapter.Eliminar(txtCodigo.Text);
                    MessageBox.Show("Se elimino exitosamente la informacion del producto " + txtProducto.Text + " Cod. " + txtCodigo);
                    this.productoTableAdapter.Fill(this.aplicativoDataSet.Producto);

                    txtId.Clear();
                    txtIdFactura.Clear();
                    txtIdFactura2.Clear();
                    txtCantidad2.Clear();
                    txtReferencia.Clear();
                    txtProducto.Clear();
                    txtMarca.Clear();
                    txtTalla.Clear();
                    txtColor.Clear();
                    txtCantidad.Clear();
                    cboCategoria.SelectedIndex = 0;
                    txtCodigo.Clear();
                    txtEstado.Clear();
                    txtValor.Clear();
                    cboDescuento.SelectedIndex = 0;
                    txtFecha.Text = DateTime.Now.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("Se ha cancelado la eliminacion del registro");
                    //|DataDirectory|
                }
            }
        }

        private void productoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

