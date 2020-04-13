using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            float imcCalc;
            imcCalc = float.Parse(txtPeso.Text) / (float.Parse(txtAltura.Text) * float.Parse(txtAltura.Text));
            MessageBox.Show("Seu IMC é " + imcCalc, "IMC");
        }
    }
}
