using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayor_que
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trcnumero1_Scroll(object sender, EventArgs e)
        {
            MayorQue();
        }

        private void trcnumero2_Scroll(object sender, EventArgs e)
        {
            MayorQue();
        }

        public void MayorQue()
        {
            Graphics papel = pictureBox1.CreateGraphics();
            SolidBrush brocha1 = new SolidBrush(Color.Red);
            SolidBrush brocha2 = new SolidBrush(Color.Blue);
            int valor1, valor2;

            //track 1 lado izquierdo

            trcnumero1.Maximum = pictureBox1.Height;

            //track 1 lado izquierdo
            trcnumero2.Maximum = pictureBox1.Height;
            valor1 = trcnumero1.Value;
            valor2 = trcnumero2.Value;
            papel.Clear(Color.White);

            papel.FillEllipse(brocha1, 10, 10, valor1, valor1);

            papel.FillEllipse(brocha2, 400,10, valor2, valor2);




            if (valor2 > valor1)
            {
                lblmostrar.Text = "El circulo AZUL es mas Grande ";
                
            }
            else
            {
                lblmostrar.Text = "El circulo ROJO es mas Grande;";

            }
        }


    }
}
