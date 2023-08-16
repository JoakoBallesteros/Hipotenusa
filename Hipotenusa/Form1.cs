using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hipotenusa
{
    public partial class FrmHipotenusa : Form
    {
        public FrmHipotenusa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnCalcular_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(TxtCateto1.Text, out double cateto1) &&
                double.TryParse(TxtCateto2.Text, out double cateto2))
            {
                double hipotenusa = Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);
                LblResultado.Text = "Hipotenusa: " + hipotenusa.ToString("F2");
            }
            else
            {
                LblResultado.Text = "Ingrese valores numéricos válidos.";
            }

        }
    }
}
    
