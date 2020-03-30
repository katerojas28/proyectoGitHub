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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void Inicio_Load(Object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormHija (Object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0) 
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Proveedor());
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Usuario());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Factura());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnSlider_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 220)
            {

                MenuVertical.Width = 56;
            }
            else
            {
                MenuVertical.Width = 220;
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Producto());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Cliente());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

            AbrirFormHija(new Ventas());
            
           
        }

        private void btnInfU_Click(object sender, EventArgs e)
        {
            Inf frm = new Inf();
            frm.Show();
            frm.lblNombre.Text = lblNombre.Text;
            frm.lblApellido.Text = lblApellido.Text;
            frm.lblNumDoc.Text = lblNumDoc.Text;
            
            frm.lblUsuario.Text = lblUsuario.Text;
            frm.lblNivelAcceso.Text = lblNivelAcceso.Text;
            frm.lblEstado.Text = lblEstado.Text;
            frm.lblTelefono.Text = lblTelefono.Text;
            frm.lblCorreo.Text = lblCorreo.Text;
            frm.lblFecha.Text = lblFechaa.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Empresa frm = new Empresa();
            frm.Show();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
