using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace CAPA_DATOS
{
    public class SqlADOConexion
    {
        static string UserSQLConexion = "Data Source=.;Initial Catalog=BDAcademiaCursos;User ID=sa;Password=1234";
        static SqlConnection SqlCon;
        static public SQLMethods SQLM;

        static public bool IniciarConexion(string user, string password)
        {
            try
            {
                UserSQLConexion = "Data Source=.;" +
                             "Initial Catalog=BDAcademiaCursos;" +
                             "User ID="+user+";Password="+password;
                SqlCon = new SqlConnection(UserSQLConexion);
                SQLM = new SQLMethods(SqlCon);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
