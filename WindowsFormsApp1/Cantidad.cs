using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cantidad : MaterialForm
    {
        public int cantidad;
        public bool aceptar = false;
        public Cantidad()
        {
            InitializeComponent();
        }

        private void Cantidad_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cantidad= Convert.ToInt32(textBox1.Text);
        }

        private void acetparbtn_Click(object sender, EventArgs e)
        {
            this.aceptar = true;
            this.Visible = false;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.aceptar = false;
        }
    }
}
