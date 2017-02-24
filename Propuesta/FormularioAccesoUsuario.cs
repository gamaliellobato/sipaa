using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propuesta
{
    public partial class FormularioAccesoUsuario : Form
    {
        Conexion c = new Conexion();
        public FormularioAccesoUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c, d, dd,f, g, h, i, j, k;
            //int e;
            DateTime g;
            a = txtCvUsuario.Text;
            b = txtIdTrab.Text;
            c = txtNombre.Text;
            d = txtPassw.Text;
            dd = cbStUsuario.SelectedItem.ToString();
            f = txtUsuMod.Text;
            g = dtpFhuMod;

        }
    }
}
