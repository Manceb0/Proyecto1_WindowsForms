using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if (string.IsNullOrEmpty(txtSB.Text))
            {
                MessageBox.Show($"Ingresar el sueldo bruto ");
                return;
            }

            double SB, SN, AFP, ISR, SFS;
            SB = double.Parse(txtSB.Text);

            AFP = SB * 0.07;
            ISR = SB * 0.09;
            SFS = SB * 0.10;

            // SUELDO NETO


            SN = SB - (AFP + ISR + SFS);

            lblSN.Text = SN.ToString();
            //LABEL SUELDO NETO

            txtAPFTotal.Text = AFP.ToString();
            //AFP

            txtISRTotal.Text = ISR.ToString();
            //ISR

            txtSFSTotal.Text = SFS.ToString();
            //SFS
        }

        private void txtSB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
