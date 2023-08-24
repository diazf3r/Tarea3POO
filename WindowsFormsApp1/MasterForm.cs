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
        private int option = 0;
        public MasterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            MasterClass.conec = new SqlConnection();
            MasterClass.conec.ConnectionString = MasterClass.cnn;

        }

        private void SelectTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = this.SelectTabla.SelectedItem.ToString();

            switch (combo)
            {
                case "Articulos":
                    Articulo_load();
                    break;
                case "Empleado":
                    Empleado_load();
                    break;
                case "Cliente":
                    Cliente_load();
                    break;
                case "Proveedor":
                    Proveedor_load();
                    break;
                case "servicio":
                    break;
                case "detalle servicio":
                    break;
                default:
                    MessageBox.Show("Debe seleccionar una opcion", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void Articulo_load()
        {
            Da_articulos = new SqlDataAdapter("Select * from Articulo", MasterClass.conec);
            Da_articulos.FillSchema(masterDataSet, SchemaType.Source, "articulo");
            Da_articulos.Fill(masterDataSet, "articulo");

            dg.DataSource = masterDataSet;
            dg.DataMember = "articulo";
            option = 1;
        }

        private void Empleado_load()
        {
            Da_articulos = new SqlDataAdapter("Select * from Empleado", MasterClass.conec);
            Da_articulos.FillSchema(masterDataSet, SchemaType.Source, "Empleado");
            Da_articulos.Fill(masterDataSet, "Empleado");

            dg.DataSource = masterDataSet;
            dg.DataMember = "Empleado";
            option = 2;
        }

        private void Proveedor_load()
        {
            Da_articulos = new SqlDataAdapter("Select * from Proveedor", MasterClass.conec);
            Da_articulos.FillSchema(masterDataSet, SchemaType.Source, "Proveedor");
            Da_articulos.Fill(masterDataSet, "Proveedor");

            dg.DataSource = masterDataSet;
            dg.DataMember = "Proveedor";
            option = 3;
        }

        private void Cliente_load()
        {
            Da_articulos = new SqlDataAdapter("Select * from Proveedor", MasterClass.conec);
            Da_articulos.FillSchema(masterDataSet, SchemaType.Source, "Proveedor");
            Da_articulos.Fill(masterDataSet, "Proveedor");

            dg.DataSource = masterDataSet;
            dg.DataMember = "Proveedor";
            option = 4;
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}
