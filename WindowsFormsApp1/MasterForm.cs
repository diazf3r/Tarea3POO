using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class MasterForm : MaterialForm
    {
        private SqlCommandBuilder cb;
        private SqlDataAdapter Da_articulos;
        private SqlDataAdapter da_cliente;
        private SqlDataAdapter da_proveedor;
        private SqlDataAdapter da_servicio;
        private SqlDataAdapter da_dservicio;
        private SqlConnection cnx;
        public MasterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MasterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
