using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MasterClass
    {

        public static string cnn = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.DB20192001399ConnectionString"].ConnectionString;
        public static SqlConnection conec;
        public static bool activar = false;

    }
}
