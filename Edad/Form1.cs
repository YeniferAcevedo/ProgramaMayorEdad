using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edad
{
    public partial class Form1 : Form
    {
        Edad edad = new Edad();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMayorEdad_Click(object sender, EventArgs e)
        {
            edad.setEdad(double.Parse(txtEdad.Text));

            if (edad.calcularEdad() == true)
            {
                lblRespuesta.Text = "SI";
                lblRespuesta.Visible = true;
            }
            else
            {
                lblRespuesta.Text = "NO";
                lblRespuesta.Visible = true;
            }
        }
    }
}
