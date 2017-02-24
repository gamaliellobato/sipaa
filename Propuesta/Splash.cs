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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int res=0;
            
            if (panel3.Width < 400)
            {
                panel3.Width = panel3.Width + 40;
                res = (100 * panel3.Width) / 400;
                lbCarga.Text = "Cargando SIPAA al " + res + "%";
            }
            else
            {
                timer1.Enabled = false;
                //MessageBox.Show("Finalizo");
                
                Acceso acc = new Acceso();
                acc.Show();
                //this.Hide();
            }

            
        }
    }
}
