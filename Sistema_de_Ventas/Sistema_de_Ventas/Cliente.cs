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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aplicativoDataSet);

        }

        private void Cliente_Load(object sender, EventArgs e)
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
            Cliente1 frm = new Cliente1();
            frm.Show();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.aplicativoDataSet.Cliente);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                txtDocB.Enabled = false;
                txtNombreB.Enabled = true;
                txtDocB.BackColor = Color.DarkGray;
                txtNombreB.BackColor = Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
                txtDocB.Clear();
            }
            else
            {
                txtDocB.Enabled = true;
                txtNombreB.Enabled = false;
                txtNombreB.BackColor = Color.DarkGray;
                txtDocB.BackColor = Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
                txtNombreB.Clear();

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDocB.Enabled == true)
            {
                if (txtDocB.Text == "")
                {
                    MessageBox.Show("Ingresa el numero para realizar la busqueda");
                }
                else
                {
                    this.clienteTableAdapter.FillBy(this.aplicativoDataSet.Cliente,txtDocB.Text);
                   
                }
            }
            else
            {
                if(txtNombreB.Text == "")
                {
                    MessageBox.Show("Ingresa el nombre para realizar la busqueda");
                }
                else
                {
                    this.clienteTableAdapter.FillBy1(this.aplicativoDataSet.Cliente,txtNombreB.Text);
                    MessageBox.Show("Ingresaaaaa");
                }

            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas frm = new Ventas();
            frm.txtNombre.Text = txtNombre.Text;
            frm.txtTipoDoc.Text = txtTipoDoc.Text;
            frm.txtNumDoc.Text = txtNumDoc.Text;
            frm.txtDireccion.Text = txtDireccion.Text;
            frm.Show();
        }
    }
}
