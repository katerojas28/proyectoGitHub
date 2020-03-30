using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sistema_de_Ventas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aplicativoDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.aplicativoDataSet.Usuarios);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aplicativoDataSet);

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            txtPassword.Visible = true;
            txtUsuario.Visible = true;
            this.usuariosTableAdapter.FillBy(this.aplicativoDataSet.Usuarios, txtUsuario1.Text);

            if (txtUsuario1.Text == "USUARIO")
            {

                MessageBox.Show("Ingrese un usuario");
            }
           else  if (txtPassword2.Text == "PASSWORD")
            {

                MessageBox.Show("Ingrese una contraseña");
            }
            else
            {
                if (txtUsuario1.Text == txtUsuario.Text)
                {
                    if (txtPassword2.Text == txtPassword.Text)
                    {
                        if (txtAcceso.Text == "1")
                        {
                            if (txtEstado.Text == "Activo")
                            {

                                this.Hide();

                                MessageBox.Show("Bienvenido " + txtNombre.Text + " " + txtApellido.Text);
                                Inicio frm = new Inicio();
                                frm.Show();

                                frm.lblNombre.Text = txtNombre.Text;
                                frm.lblApellido.Text = txtApellido.Text;
                                frm.lblNumDoc.Text = txtNumDoc.Text;
                                frm.lblIdU.Text = txtId.Text;
                                frm.lblUsuario.Text = txtUsuario1.Text;
                                frm.lblNivelAcceso.Text = txtAcceso.Text;
                                frm.lblEstado.Text = txtEstado.Text;
                                frm.lblTelefono.Text = txtTelefono.Text;
                                frm.lblCorreo.Text = txtCorreo.Text;
                                frm.lblFechaa.Text = txtFecha.Text;

                                txtPassword.Visible = false;
                                txtUsuario.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Usuario " + txtNombre.Text + " " + txtApellido.Text + " Inactivo");
                                txtUsuario1.Text = "USUARIO";
                                txtPassword2.Text = "PASSWORD";
                                txtUsuario1.ForeColor = Color.DimGray;
                                txtPassword2.ForeColor = Color.DimGray;
                                txtPassword2.UseSystemPasswordChar = false;
                            }

                        }
                        else if (txtAcceso.Text == "2")
                        {
                            if (txtEstado.Text == "Activo")
                            {
                                this.Hide();
                                MessageBox.Show("Bienvenido " + txtNombre.Text + " " + txtApellido.Text);
                                Inicio frm = new Inicio();
                                frm.Show();

                                frm.lblNombre.Text = txtNombre.Text;
                                frm.lblApellido.Text = txtApellido.Text;
                                frm.lblNumDoc.Text = txtNumDoc.Text;
                                frm.lblIdU.Text = txtId.Text;                               
                                frm.lblUsuario.Text = txtUsuario1.Text;
                                frm.lblNivelAcceso.Text = txtAcceso.Text;
                                frm.lblEstado.Text = txtEstado.Text;
                                frm.lblTelefono.Text = txtTelefono.Text;
                                frm.lblCorreo.Text = txtCorreo.Text;
                                frm.lblFechaa.Text = txtFecha.Text;

                                txtPassword.Visible = false;
                                txtUsuario.Visible = false;
                                frm.btnProveedor.Visible = false;
                                frm.btnFactura.Visible = false;
                                frm.btnProductos.Visible = false;
                                frm.btnUsuario.Visible = false;

                                frm.btnVentas.Location = new System.Drawing.Point(2,176);
                                frm.btnClientes.Location = new System.Drawing.Point(2,268);
                                frm.btnHistorial.Location = new System.Drawing.Point(2,360);
                                frm.btnVentas.Size = new System.Drawing.Size(217, 60);
                                frm.btnClientes.Size = new System.Drawing.Size(217, 60);
                                frm.btnHistorial.Size = new System.Drawing.Size(217, 60);


                            }
                            else
                            {
                                MessageBox.Show("Usuario " + txtNombre.Text + " " + txtApellido.Text + " Inactivo");
                                txtUsuario1.Text = "USUARIO";
                                txtPassword2.Text = "PASSWORD";
                                txtUsuario1.ForeColor = Color.DimGray;
                                txtPassword2.ForeColor = Color.DimGray;
                                txtPassword2.UseSystemPasswordChar = false;
                            }

                        }

                    }
                    else
                    {
                        txtPassword.Visible = false;
                        txtUsuario.Visible = false;
                        MessageBox.Show("Password Incorrecto");
                        txtPassword2.Text = "PASSWORD";
                        txtPassword2.ForeColor = Color.DimGray;
                        txtPassword2.UseSystemPasswordChar = false;
                    }


                }
                else
                {
                    txtPassword.Visible = false;
                    txtUsuario.Visible = false;
                    MessageBox.Show("Usuario Incorrecto");
                    txtUsuario1.Text = "USUARIO";
                    txtUsuario1.ForeColor = Color.DimGray;
                    txtPassword2.Text = "PASSWORD";
                    txtPassword2.ForeColor = Color.DimGray;
                    txtPassword2.UseSystemPasswordChar = false;
                }
            }
        }

        private void txtUsuario1_Enter(object sender, EventArgs e)
        {
            if (txtUsuario1.Text == "USUARIO")
            {
                txtUsuario1.Text = "";
                txtUsuario1.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario1_Leave(object sender, EventArgs e)
        {
            if (txtUsuario1.Text == "")
            {
                txtUsuario1.Text = "USUARIO";
                txtUsuario1.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            if (txtPassword2.Text == "PASSWORD")
            {
                txtPassword2.Text = "";
                txtPassword2.ForeColor = Color.LightGray;
                txtPassword2.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            if (txtPassword2.Text == "")
            {
                txtPassword2.Text = "PASSWORD";
                txtPassword2.ForeColor = Color.DimGray;
                txtPassword2.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     
    }
}
