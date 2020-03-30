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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aplicativoDataSet);

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aplicativoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.aplicativoDataSet.Usuarios);
            txtFecha.Text = DateTime.Now.ToShortDateString();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            if (txtNumDoc.Text =="" || txtNombre.Text == "" || txtApellido.Text == "" || txtUsuario.Text == "" || txtPassword.Text == "" ) { 

                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                this.usuariosTableAdapter.Agregar(txtNombre.Text, txtApellido.Text, txtNumDoc.Text, txtUsuario.Text, txtPassword.Text, cboAcceso.Text, cboEstado.Text,txtTelefono.Text,txtCorreo.Text,txtFecha.Text);
                MessageBox.Show("Registro exitoso del usuario " + txtUsuario.Text);
                this.usuariosTableAdapter.Fill(this.aplicativoDataSet.Usuarios);

                txtApellido.Clear();
                txtId.Clear();
                txtNombre.Clear();
                txtNumDoc.Clear();
                txtPassword.Clear();
                txtUsuario.Clear();
                cboAcceso.SelectedIndex = 0;
                cboEstado.SelectedIndex = 0;
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtFecha.Text = DateTime.Now.ToShortDateString();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNumDoc.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtUsuario.Text == "" || txtPassword.Text == "")
            {

                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                this.usuariosTableAdapter.Editar(txtNombre.Text, txtApellido.Text, txtNumDoc.Text, txtUsuario.Text, txtPassword.Text, cboAcceso.Text, cboEstado.Text,txtTelefono.Text,txtCorreo.Text,txtFecha.Text, txtNumDoc.Text);
                MessageBox.Show("Se edito exitosamente la informacion del Usuario identicado con Nº Doc. " + txtNumDoc.Text);
                this.usuariosTableAdapter.Fill(this.aplicativoDataSet.Usuarios);

                txtApellido.Clear();
                txtId.Clear();
                txtNombre.Clear();
                txtNumDoc.Clear();
                txtPassword.Clear();
                txtUsuario.Clear();
                cboAcceso.SelectedIndex = 0;
                cboEstado.SelectedIndex = 0;
                txtTelefono.Clear();
                txtCorreo.Clear();
                txtFecha.Text = DateTime.Now.ToShortDateString();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtId.Clear();
            txtNombre.Clear();
            txtNumDoc.Clear();
            txtPassword.Clear();
            txtUsuario.Clear();
            cboAcceso.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.aplicativoDataSet.Usuarios);
        }

        private void cboAcceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = "";
            x = cboAcceso.Text;

            if (x ==  "1")
            {
                txtDescripcion.Text = "Acceso total para usuario administrador de la aplicación";

            }else if (x == "2")
              {
                txtDescripcion.Text = "Acceso con restricciones definidas";

            }else{

                txtDescripcion.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumBuscar.Text=="")
            {
                MessageBox.Show("Ingrese el N° de docuemnto del usuario que desea buscar");
            }
            else
            {
                this.usuariosTableAdapter.FillBy1(this.aplicativoDataSet.Usuarios, txtNumBuscar.Text);
            }
            if (txtNumDoc.Text==txtNumBuscar.Text)
            {
                MessageBox.Show("Usuario Encontrado");
                txtNumBuscar.Clear();
            }
            else
            {
                MessageBox.Show("No existe ningun Usuario con ese N° de documento, por favor verifique");
                txtNumBuscar.Clear();
                this.usuariosTableAdapter.Fill(this.aplicativoDataSet.Usuarios);
            }
        }
    }
}
