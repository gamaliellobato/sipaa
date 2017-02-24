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
        public int iContador;
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

          
            
            if (panel3.Width < panel2.Width)
            {
                int isuma = (panel1.Width / 100) * 5;

                panel3.Width = panel3.Width + isuma;
                iContador = iContador + (isuma / 4);
                lbCarga.Text = iContador.ToString()+"%";

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
