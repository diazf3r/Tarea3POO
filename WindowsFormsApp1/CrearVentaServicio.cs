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
    public partial class CrearVentaServicio : MaterialForm

    {
        private String tipo;
        private int idFactura;
        private int clienteID;

        private SqlDataAdapter ArticuloServicioAdapter;


        private DataTable DetalleFactura = new DataTable();

        public CrearVentaServicio()
        {
            InitializeComponent();
        }


        public CrearVentaServicio(String Tipo, int IdFactura, int ClienteID)
        {
            InitializeComponent();

            this.tipo = Tipo;
            this.idFactura = IdFactura;
            this.clienteID = ClienteID;

            if (this.tipo == "Venta")
            {
                materialLabel1.Text = "Venta";

                DetalleFactura.Columns.Add("ArticuloID", typeof(int));
                DetalleFactura.Columns.Add("Nombre", typeof(string));
                DetalleFactura.Columns.Add("Cantidad", typeof(int));
                DetalleFactura.Columns.Add("Precio", typeof(decimal));

            }

            if (this.tipo == "Servicio")
            {
                DetalleFactura.Columns.Add("ServicioID", typeof(int));
                DetalleFactura.Columns.Add("Nombre", typeof(string));
                DetalleFactura.Columns.Add("Precio", typeof(decimal));

            }

        }

        private void CrearVentaServicio_Load(object sender, EventArgs e)
        {

            MasterClass.conec = new SqlConnection(MasterClass.cnn);
            MasterClass.conec.ConnectionString = MasterClass.cnn;

            if (tipo == "Venta")
            {

                ArticuloServicioAdapter = new SqlDataAdapter("Select * from Articulo", MasterClass.conec);
                ArticuloServicioAdapter.FillSchema(masterDataSet, SchemaType.Source, "Articulo");
                ArticuloServicioAdapter.Fill(masterDataSet, "Articulo");

                this.listaArticuloServicioDataView.DataSource = masterDataSet;
                this.listaArticuloServicioDataView.DataMember = "Articulo";

                this.listaArticuloServicioDataView.Columns["ArticuloID"].Visible = false;
                this.listaArticuloServicioDataView.Columns["ISV"].Visible = false;


            }
            else if (tipo == "Servicio")
            {
                ArticuloServicioAdapter = new SqlDataAdapter("Select * from Servicio", MasterClass.conec);
                ArticuloServicioAdapter.FillSchema(masterDataSet, SchemaType.Source, "Servicio");
                ArticuloServicioAdapter.Fill(masterDataSet, "Servicio");

                this.listaArticuloServicioDataView.DataSource = masterDataSet;
                this.listaArticuloServicioDataView.DataMember = "Servicio";
                this.listaArticuloServicioDataView.Columns["ServicioID"].Visible = false;


            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = listaArticuloServicioDataView.SelectedRows[0];

            if (this.tipo == "Venta")
            {
                Cantidad pregunta = new Cantidad();
                pregunta.ShowDialog();

                if (pregunta.aceptar == false)
                {
                    MessageBox.Show("No se ingreso una cantidad");
                    return;
                }

                int articuloID = (int)selectedRow.Cells["ArticuloID"].Value;

                String updateQuery = "UPDATE Articulo SET Existencia = Existencia - @cantidad WHERE ArticuloID = @articuloID";

                SqlConnection connection = new SqlConnection(MasterClass.cnn);
                SqlCommand command = new SqlCommand(updateQuery, connection);

                command.Parameters.AddWithValue("@cantidad", pregunta.cantidad);
                command.Parameters.AddWithValue("@articuloID", articuloID);

                connection.Open();
                command.ExecuteNonQuery();


                DetalleFactura.Rows.Add(selectedRow.Cells["ArticuloID"].Value, selectedRow.Cells["Nombre"].Value, pregunta.cantidad, selectedRow.Cells["Precio"].Value
                    );

                detalleGridView.DataSource = DetalleFactura;

                CrearVentaServicio_Load(sender, e);

            }
            else if (this.tipo == "Servicio")
            {
                Console.WriteLine("ID: " + selectedRow.Cells["ServicioID"].Value);
                Console.WriteLine("Nombre: " + selectedRow.Cells["Nombre"].Value);
                Console.WriteLine("Precio: " + selectedRow.Cells["Precio"].Value);

                DetalleFactura.Rows.Add(selectedRow.Cells["ServicioID"].Value, selectedRow.Cells["Nombre"].Value, selectedRow.Cells["Precio"].Value);
                detalleGridView.DataSource = DetalleFactura;
            }


        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (detalleGridView.SelectedRows[0] == null)
            {
                MessageBox.Show("No selecciono un detalle de la factura");
            }
            else
            {
                DataGridViewRow selectedrow = detalleGridView.SelectedRows[0];

                if (this.tipo == "Venta")
                {
                    int articuloID = (int)selectedrow.Cells["ArticuloID"].Value;

                    String updateQuery = "UPDATE Articulo SET Existencia = Existencia + @cantidad WHERE ArticuloID = @articuloID";

                    SqlConnection connection = new SqlConnection(MasterClass.cnn);
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    command.Parameters.AddWithValue("@cantidad", selectedrow.Cells["Cantidad"].Value);
                    command.Parameters.AddWithValue("@articuloID", articuloID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    CrearVentaServicio_Load(sender, e);


                }
                detalleGridView.Rows.Remove(selectedrow);
            }




        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void crearDetalleBtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(MasterClass.cnn);
            connection.Open();

            foreach (DataGridViewRow row in detalleGridView.Rows)
            {

                if (row.Cells["ArticuloID"].Value == null)
                {


                    return;
                }

                if (this.tipo == "Venta")
                {

                    int articuloId = (int)row.Cells["ArticuloID"].Value;
                    int cantidad = (int)row.Cells["Cantidad"].Value;
                    decimal precio = (decimal)row.Cells["Precio"].Value;
                    Double isv = 0.15;

                    String insertQuery = "INSERT INTO FacturaDet (FacturaID, ArticuloID, Cantidad, Precio, ISV) VALUES (@facturaID, @articuloID, @cantidad, @precio, @isv)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);


                    command.Parameters.AddWithValue("@FacturaID", this.idFactura);
                    command.Parameters.AddWithValue("@ArticuloID", articuloId);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@ISV", isv);

                    command.ExecuteNonQuery();

                }
            }


        }
    }
}
