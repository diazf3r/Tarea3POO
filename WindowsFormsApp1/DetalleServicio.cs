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
        private SqlCommandBuilder cb;
        private SqlDataAdapter articuloadapter;
        private SqlDataAdapter servicioadapter;
        DataRow reg;
        //public DetalleServicio()
        //{
        //    InitializeComponent();
        //}

        public DetalleServicio(SqlConnection connec, int row)
        {
            InitializeComponent();
            this.ServicioID.Text = row.ToString();
        }

        private void DetalleServicio_Load(object sender, EventArgs e)
        {
            //MasterClass.conec = new SqlConnection();
            //MasterClass.conec.ConnectionString = MasterClass.cnn;

            articuloadapter = new SqlDataAdapter("Select * from Articulo Order By Nombre", MasterClass.conec);
            articuloadapter.FillSchema(masterDataSet1, SchemaType.Source, "Articulo");
            articuloadapter.Fill(masterDataSet1, "Articulo");
            CBArticulo.DataSource = masterDataSet1;
            CBArticulo.DisplayMember = "Articulo.nombre";
            CBArticulo.ValueMember = "Articulo.ArticuloId";


            Detailadapter = new SqlDataAdapter("Select * from ServicioDet", MasterClass.conec);
            Detailadapter.FillSchema(masterDataSet1, SchemaType.Source, "ServicioDet");
            Detailadapter.Fill(masterDataSet1, "ServicioDet");
            cb = new SqlCommandBuilder(Detailadapter);

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
            reg = masterDataSet1.ServicioDet.NewRow();
           var servicio =  Convert.ToInt32(this.ServicioID.ToString());
           var articulo =  Convert.ToInt32(CBArticulo.SelectedValue.ToString());
           var cantidad =  Convert.ToInt32(this.cantidad.Text);
            try
            {
                reg["ServicioID"] = servicio;
                reg["ArticuloID"] = articulo;
                reg["Cantidad"] = cantidad;
                masterDataSet1.ServicioDet.Rows.Add(reg);
                Detailadapter.Update(masterDataSet1.ServicioDet);
                this.cantidad.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
