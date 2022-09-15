using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class CONVERSOR : Form
    {
        int bandera = 0;

        public CONVERSOR()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                //Si escribio en centigrados
                if (bandera == 1)
                {
                    //Centigrados
                    grados = Convert.ToDouble(txtCentigrados.Text) * 9.0 / 5.0 + 32.0;
                    //Mostrar el resultado
                    txtFar.Text = String.Format("{0:F2}", grados);
                }
                if(bandera == 2)
                {
                    //fahr
                    grados = (Convert.ToDouble(txtFar.Text)-32.0) * 5.0 / 9.0;
                    //Mostrar el resultado
                    txtCentigrados.Text = String.Format("{0:F2}", grados);
                }
            }catch(FormatException)
            {
                txtCentigrados.Text = "0.0";
                txtFar.Text = "32.00";
            }
        }

        private void txtCentigrados_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCentigrados_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 1;
            if (e.KeyChar == 13)
            {
                btnAceptar_Click(sender, e);
            }
        }

        private void txtFar_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 2;
            if(e.KeyChar==13)
            {
                btnAceptar_Click(sender, e);
            }
        }

        private void txtFar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
