using MaterialSkin.Controls;
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

namespace WindowsFormsApp1
{
    public partial class ServicioCliente : MaterialForm
    {
        private SqlDataAdapter clienteDataAdapter;

        private SqlDataAdapter facturaDataAdapter;

        private String clienteID;

        private SqlDataAdapter interaccionDataAdapter;

        public ServicioCliente()
        {
            InitializeComponent();
        }

        private void ServicioCliente_Load(object sender, EventArgs e)
        {

            MasterClass.conec = new SqlConnection(MasterClass.cnn);
            MasterClass.conec.ConnectionString = MasterClass.cnn;

            clienteDataAdapter = new SqlDataAdapter("Select * from Cliente", MasterClass.conec);
            clienteDataAdapter.FillSchema(masterDataSet, SchemaType.Source, "Cliente");
            clienteDataAdapter.Fill(masterDataSet, "Cliente");

            this.clienteCombo.DataSource = masterDataSet;
            this.clienteCombo.DisplayMember = "Cliente.Contacto";
            this.clienteCombo.ValueMember = "Cliente.ClienteID";

        }

        private void cambioSeleccionCliente(object sender, EventArgs e)
        {

            Type selectedValueType = this.clienteCombo.SelectedValue.GetType();

            if (selectedValueType == typeof(System.Int32))
            {
                this.clienteID = this.clienteCombo.SelectedValue.ToString();
                loadFacturasAsociadas(sender, e);

            }


        }

        private void loadFacturasAsociadas(object sender, EventArgs e)
        {
            if (this.clienteID != null)
            {
                facturaDataAdapter = new SqlDataAdapter("Select * from Factura where ClienteID = " + this.clienteID, MasterClass.conec);
                facturaDataAdapter.FillSchema(masterDataSet, SchemaType.Source, "Factura");
                facturaDataAdapter.Fill(masterDataSet, "Factura");

                this.facturaDataGrid.DataSource = masterDataSet;
                this.facturaDataGrid.DataMember = "Factura";
            }
        }

        private void CrearInteraccionBtn_Click(object sender, EventArgs e)
        {

            if( this.clienteID == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            MasterClass.conec = new SqlConnection(MasterClass.cnn);
            MasterClass.conec.ConnectionString = MasterClass.cnn;


            DateTime fecha = DateTime.Now;
            string tipo = "default";
            string estado = "default";

            string query = "INSERT INTO Factura (ClienteID, Fecha, Tipo, Estado) VALUES (@clienteID, @fecha, @tipo, @estado)";
            SqlCommand cmd = new SqlCommand(query, MasterClass.conec);
            cmd.Parameters.AddWithValue("@clienteID", clienteID);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@estado", estado);


            try
            {
                MasterClass.conec.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Factura creada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear factura: " + ex.Message);
            }
            finally
            {
                MasterClass.conec.Close();

                Task.Delay(2000);
                loadFacturasAsociadas(sender, e);
            }



        }

        private void DetalleFacturaBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
