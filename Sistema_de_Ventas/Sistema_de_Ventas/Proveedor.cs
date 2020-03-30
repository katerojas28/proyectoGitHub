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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //723; 47

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aplicativoDataSet);

        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aplicativoDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.aplicativoDataSet.Proveedor);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text == "" || txtNit.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {

                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                this.proveedorTableAdapter.Agregar(txtEmpresa.Text, txtNit.Text, txtDireccion.Text, txtTelefono.Text);
                MessageBox.Show("Registro exitoso de la empresa " + txtEmpresa.Text);
                this.proveedorTableAdapter.Fill(this.aplicativoDataSet.Proveedor);

                txtEmpresa.Clear();
                txtNit.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtId.Clear();
                txtNit2.Clear();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text == "" || txtNit.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {

                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                this.proveedorTableAdapter.Editar(txtEmpresa.Text, txtNit.Text, txtDireccion.Text, txtTelefono.Text, txtNit.Text);
                MessageBox.Show("Se edito exitosamente la informacion de la empresa " + txtEmpresa.Text);
                this.proveedorTableAdapter.Fill(this.aplicativoDataSet.Proveedor);

                txtEmpresa.Clear();
                txtNit.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtId.Clear();
                txtNit2.Clear();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtEmpresa.Text == "" || txtNit.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningun registro");
            }
            else
            {
                if (MessageBox.Show("Desea eliminar el registro de la empresa" + txtEmpresa.Text, "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.proveedorTableAdapter.Eliminar(txtNit.Text);
                    MessageBox.Show("Se elimino exitosamente la informacion de la empresa " + txtEmpresa.Text);
                    this.proveedorTableAdapter.Fill(this.aplicativoDataSet.Proveedor);

                    txtEmpresa.Clear();
                    txtNit.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtId.Clear();
                    txtNit2.Clear();
                }
                else
                {
                    MessageBox.Show("Se ha cancelado la eliminacion del registro");
                    //|DataDirectory|
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEmpresa.Clear();
            txtNit.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtId.Clear();
            txtNit2.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.proveedorTableAdapter.Fill(this.aplicativoDataSet.Proveedor);
        }
        
    }
}
