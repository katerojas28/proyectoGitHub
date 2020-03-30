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
    public partial class Cliente1 : Form
    {
        public Cliente1()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aplicativoDataSet);

        }

        private void Cliente1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aplicativoDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.aplicativoDataSet.Cliente);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboTipDoc.Text == "" || txtNumDoc.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "")
            {

                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                this.clienteTableAdapter.Agregar(txtNumDoc.Text,cboTipDoc.Text,txtNombre.Text,txtTelefono.Text,txtCorreo.Text,txtDireccion.Text);
                MessageBox.Show("Registro exitoso del Cliente " + txtNombre.Text);
                this.clienteTableAdapter.Fill(this.aplicativoDataSet.Cliente);

                cboTipDoc.SelectedIndex = -1;
                txtNumDoc.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtDireccion.Clear();

            }
        }
    }
}
