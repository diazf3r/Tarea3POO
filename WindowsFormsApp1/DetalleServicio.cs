using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DetalleServicio : MaterialForm
    {
        private SqlDataAdapter Detailadapter;
        private SqlDataAdapter articuloadapter;
        private SqlDataAdapter servicioadapter;
        public DetalleServicio()
        {
            InitializeComponent();
        }

        private void DetalleServicio_Load(object sender, EventArgs e)
        {
            MasterClass.conec = new SqlConnection();
            MasterClass.conec.ConnectionString = MasterClass.cnn;

            articuloadapter = new SqlDataAdapter("Select * from Articulo Order By Nombre", MasterClass.conec);
            articuloadapter.FillSchema(masterDataSet1, SchemaType.Source, "Articulo");
            articuloadapter.Fill(masterDataSet1, "Articulo");
            CBArticulo.DataSource = masterDataSet1;
            CBArticulo.DisplayMember = "Articulo.nombre";
            CBArticulo.ValueMember = "Articulo.ArticuloId";

            servicioadapter = new SqlDataAdapter("Select * from Servicio Order By Nombre", MasterClass.conec);
            servicioadapter.FillSchema(masterDataSet1, SchemaType.Source, "Servicio");
            servicioadapter.Fill(masterDataSet1, "Servicio");
            CBServicio.DataSource = masterDataSet1;
            CBServicio.DisplayMember = "Servicio.Nombre";
            CBServicio.ValueMember = "Servicio.ServicioId";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Save_Click(object sender, EventArgs e)
        {
           var servicio =  Convert.ToInt32(CBServicio.SelectedValue);
           var articulo =  Convert.ToInt32(CBArticulo.SelectedValue);
           var cantidad =  Convert.ToInt32(this.cantidad.Text);
            try
            {
                Detailadapter = new SqlDataAdapter("Select * from ServicioDet", MasterClass.conec);
                Detailadapter.FillSchema(masterDataSet1, SchemaType.Source, "ServicioDet");
                Detailadapter.Fill(masterDataSet1, "ServicioDet");

                Detailadapter.InsertCommand = new SqlCommand("Insert Into ServicioDet (ServicioId,ArticuloId,Cantidad) Values(@a,@b,@c)", MasterClass.conec);
                Detailadapter.InsertCommand.Parameters.AddWithValue("@a", servicio);
                Detailadapter.InsertCommand.Parameters.AddWithValue("@b", articulo);
                Detailadapter.InsertCommand.Parameters.AddWithValue("@b", cantidad);

                Detailadapter.Update(masterDataSet1.ServicioDet);
                this.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
