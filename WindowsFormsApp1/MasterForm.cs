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
        private SqlDataAdapter MasterDataAdapter;
        private SqlDataAdapter MasterDataAdapterchild;
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
            MasterDataAdapter = new SqlDataAdapter("Select * from Articulo", MasterClass.conec);
            MasterDataAdapter.FillSchema(masterDataSet, SchemaType.Source, "articulo");
            MasterDataAdapter.Fill(masterDataSet, "articulo");

            dg.DataSource = masterDataSet;
            dg.DataMember = "articulo";
            option = 1;
            this.save.Visible = false;
            this.delete.Visible = false;
        }

        private void articulo_save()
        {
            MasterDataAdapter.InsertCommand = new SqlCommand("Insert Into Articulo Values(@a,@b,@c,@d,@e)", MasterClass.conec);
            MasterDataAdapter.InsertCommand.Parameters.Add("@a", SqlDbType.Int, 4, "ArticuloID");
            MasterDataAdapter.InsertCommand.Parameters.Add("@b", SqlDbType.VarChar, 50, "Nombre");
            MasterDataAdapter.InsertCommand.Parameters.Add("@c", SqlDbType.Float, 4, "Existencia");
            MasterDataAdapter.InsertCommand.Parameters.Add("@d", SqlDbType.Float, 4, "Precio");
            MasterDataAdapter.InsertCommand.Parameters.Add("@e", SqlDbType.Float, 4, "ISV");

            MasterDataAdapter.UpdateCommand = new SqlCommand("Update Articulo set Nombre = @b, Existencia = @c,Precio = @d, ISV = @e where ArticuloID = @a", MasterClass.conec);
            MasterDataAdapter.UpdateCommand.Parameters.Add("@a", SqlDbType.Int, 4, "ArticuloID");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@b", SqlDbType.VarChar, 50, "Nombre");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@c", SqlDbType.Float, 4, "Existencia");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@d", SqlDbType.Float, 4, "Precio");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@e", SqlDbType.Float, 4, "ISV");

            MasterDataAdapter.Update(masterDataSet.Articulo);
        }

        private void Empleado_load()
        {
            MasterDataAdapter = new SqlDataAdapter("Select * from Empleado", MasterClass.conec);
            MasterDataAdapter.FillSchema(masterDataSet, SchemaType.Source, "Empleado");
            MasterDataAdapter.Fill(masterDataSet, "Empleado");

            dg.DataSource = masterDataSet;
            dg.DataMember = "Empleado";
            option = 2;
            this.save.Visible = true;
            this.delete.Visible = true;
        }

        private void empleado_save()
        {
            MasterDataAdapter.InsertCommand = new SqlCommand("Insert Into Empleado Values(@a,@b,@c,@d,@e)", MasterClass.conec);
            MasterDataAdapter.InsertCommand.Parameters.Add("@a", SqlDbType.Int, 4, "EmpleadoID");
            MasterDataAdapter.InsertCommand.Parameters.Add("@b", SqlDbType.VarChar, 50, "Nombre");
            MasterDataAdapter.InsertCommand.Parameters.Add("@c", SqlDbType.VarChar, 100, "Direccion");
            MasterDataAdapter.InsertCommand.Parameters.Add("@d", SqlDbType.VarChar, 50, "Email");
            MasterDataAdapter.InsertCommand.Parameters.Add("@e", SqlDbType.Bit, 1, "Tecnico");

            MasterDataAdapter.UpdateCommand = new SqlCommand("Update Empleado set Nombre = @b, Direccion = @c,Email = @d, Tecnico = @e where EmpleadoID = @a", MasterClass.conec);
            MasterDataAdapter.UpdateCommand.Parameters.Add("@a", SqlDbType.Int, 4, "EmpleadoID");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@b", SqlDbType.VarChar, 50, "Nombre");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@c", SqlDbType.VarChar, 100, "Direccion");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@d", SqlDbType.VarChar, 50, "Email");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@e", SqlDbType.Bit, 1, "Tecnico");

            MasterDataAdapter.Update(masterDataSet.Empleado);
        }

        private void empleado_Delete()
        {
            MasterDataAdapter.UpdateCommand = new SqlCommand("Update Empleado set Activo = @e where EmpleadoID = @a", MasterClass.conec);
            MasterDataAdapter.UpdateCommand.Parameters.Add("@a", SqlDbType.Int, 4, "EmpleadoID");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@e", SqlDbType.Bit, 1, "Activo");

            MasterDataAdapter.Update(masterDataSet.Empleado);
        }
        private void Proveedor_load()
        {
            MasterDataAdapter = new SqlDataAdapter("Select * from Proveedor", MasterClass.conec);
            MasterDataAdapter.FillSchema(masterDataSet, SchemaType.Source, "Proveedor");
            MasterDataAdapter.Fill(masterDataSet, "Proveedor");

            dg.DataSource = masterDataSet;
            dg.DataMember = "Proveedor";
            option = 3;
            this.save.Visible = true;
            this.delete.Visible = true;
        }

        private void Proveedor_save()
        {
            MasterDataAdapter.InsertCommand = new SqlCommand("Insert Into Proveedor Values(@a,@b,@c,@d,@e,@f)", MasterClass.conec);
            MasterDataAdapter.InsertCommand.Parameters.Add("@a", SqlDbType.Int, 4, "EmpleadoID");
            MasterDataAdapter.InsertCommand.Parameters.Add("@b", SqlDbType.VarChar, 50, "Nombre");
            MasterDataAdapter.InsertCommand.Parameters.Add("@c", SqlDbType.VarChar, 100, "Direccion");
            MasterDataAdapter.InsertCommand.Parameters.Add("@d", SqlDbType.VarChar, 20, "RTN");
            MasterDataAdapter.InsertCommand.Parameters.Add("@e", SqlDbType.VarChar, 1, "Tipo");
            MasterDataAdapter.InsertCommand.Parameters.Add("@f", SqlDbType.VarChar, 20, "Telefono");

            MasterDataAdapter.UpdateCommand = new SqlCommand("Update Proveedor set Nombre = @b, Direccion = @c,RTN = @d, Tipo = @e, Telefono = @f where EmpleadoID = @a", MasterClass.conec);
            MasterDataAdapter.UpdateCommand.Parameters.Add("@a", SqlDbType.Int, 4, "EmpleadoID");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@b", SqlDbType.VarChar, 50, "Nombre");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@c", SqlDbType.VarChar, 100, "Direccion");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@d", SqlDbType.VarChar, 20, "RTN");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@e", SqlDbType.VarChar, 1, "Tipo");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@f", SqlDbType.VarChar, 20, "Telefono");

            MasterDataAdapter.Update(masterDataSet.Empleado);
        }

        private void Proveedor_Delete()
        {

            MasterDataAdapter.UpdateCommand = new SqlCommand("Update Proveedor set Activo = @e where EmpleadoID = @a", MasterClass.conec);
            MasterDataAdapter.UpdateCommand.Parameters.Add("@a", SqlDbType.Int, 4, "EmpleadoID");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@e", SqlDbType.VarChar, 1, "Activo");

            MasterDataAdapter.Update(masterDataSet.Empleado);
        }

        private void Cliente_load()
        {
            MasterDataAdapter = new SqlDataAdapter("Select * from Proveedor", MasterClass.conec);
            MasterDataAdapter.FillSchema(masterDataSet, SchemaType.Source, "Proveedor");
            MasterDataAdapter.Fill(masterDataSet, "Proveedor");

            dg.DataSource = masterDataSet;
            dg.DataMember = "Proveedor";
            option = 4;
            this.save.Visible = true;
            this.delete.Visible = false;
        }

        private void Cliente_save()
        {
            MasterDataAdapter.InsertCommand = new SqlCommand("Insert Into Cliente Values(@a,@b,@c,@d,@e,@f, @g, @h)", MasterClass.conec);
            MasterDataAdapter.InsertCommand.Parameters.Add("@a", SqlDbType.Int, 4, "CLienteID");
            MasterDataAdapter.InsertCommand.Parameters.Add("@b", SqlDbType.VarChar, 10, "Direccion");
            MasterDataAdapter.InsertCommand.Parameters.Add("@c", SqlDbType.VarChar, 1, "Tipo");
            MasterDataAdapter.InsertCommand.Parameters.Add("@d", SqlDbType.VarChar, 1, "Sexo");
            MasterDataAdapter.InsertCommand.Parameters.Add("@e", SqlDbType.VarChar, 1, "Civil");
            MasterDataAdapter.InsertCommand.Parameters.Add("@f", SqlDbType.VarChar, 50, "Razon");
            MasterDataAdapter.InsertCommand.Parameters.Add("@g", SqlDbType.VarChar, 50, "Contacto");
            MasterDataAdapter.InsertCommand.Parameters.Add("@h", SqlDbType.Bit, 1, "Activo");

            MasterDataAdapter.UpdateCommand = new SqlCommand("Update Cliente set Direccion = @b, Tipo = @c,Sexo = @d, Civil = @e, Razon = @f, Activo = @h, Contacto = @g where ClienteId = @a", MasterClass.conec);
            MasterDataAdapter.UpdateCommand.Parameters.Add("@a", SqlDbType.Int, 4, "EmpleadoID");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@b", SqlDbType.VarChar, 10, "Direccion");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@c", SqlDbType.VarChar, 1, "Tipo");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@d", SqlDbType.VarChar, 1, "Sexo");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@e", SqlDbType.VarChar, 1, "Civil");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@f", SqlDbType.VarChar, 50, "Razon");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@g", SqlDbType.VarChar, 50, "Contacto");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@h", SqlDbType.Bit, 1, "Activo");

            MasterDataAdapter.Update(masterDataSet.Empleado);
        }
        private void Cliente_delete()
        {
            MasterDataAdapter.UpdateCommand = new SqlCommand("Update Cliente set Activo = @c where ClienteId = @a", MasterClass.conec);
            MasterDataAdapter.UpdateCommand.Parameters.Add("@a", SqlDbType.Int, 4, "EmpleadoID");
            MasterDataAdapter.UpdateCommand.Parameters.Add("@c", SqlDbType.Bit, 1, "Activo");

            MasterDataAdapter.Update(masterDataSet.Empleado);
        }

        private void Servicio_load()
        {
            MasterDataAdapter = new SqlDataAdapter("Select * from Servicio", MasterClass.conec);
            MasterDataAdapter.FillSchema(masterDataSet, SchemaType.Source, "Servicio");
            MasterDataAdapter.Fill(masterDataSet, "Servicio");

            dg.DataSource = masterDataSet;
            dg.DataMember = "Servicio";
            option = 1;
            this.save.Visible = false;
            this.delete.Visible = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            switch (option) 
            {
                case 1:
                    try
                    {
                        //articulo_save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                break;

                case 2:
                    try
                    {
                        empleado_save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                break;

                case 3:
                    try
                    {
                        Proveedor_save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                break;
                case 4:
                    try
                    {
                        Cliente_save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                break;

            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case 1:
                    try
                    {
                       // articulo_save();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 2:
                    try
                    {
                        empleado_Delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 3:
                    try
                    {
                        Proveedor_Delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 4:
                    try
                    {
                        Cliente_delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

        }
    }
}
