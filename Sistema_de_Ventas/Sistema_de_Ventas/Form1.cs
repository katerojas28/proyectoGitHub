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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void fn_prbar_()
        {
            progressBar1.Increment(1);
            label1.Text ="Cargando el Sistema al "+ progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Login frm = new Login();
                frm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_prbar_();
        }
    }
}
