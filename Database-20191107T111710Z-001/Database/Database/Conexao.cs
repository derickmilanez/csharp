using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Conexao
    {
       public static SqlConnection GetConnection()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_OQUECEISQUISEREM;Integrated Security=True;Pooling=False");
            return cnn;
        }
    }
}
