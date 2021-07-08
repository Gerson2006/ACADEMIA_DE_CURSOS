using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CAPA_DATOS
{
    public class SQLMethods
    {
        public SQLMethods(SqlConnection connection)
        {
            SQLMCon = connection;
        }
        SqlConnection SQLMCon;
        public bool ExcuteSqlQuery(string strQuery)
        {
            try
            {
                SQLMCon.Open();
                SqlCommand com = new SqlCommand(strQuery, SQLMCon);
                com.ExecuteNonQuery();
                SQLMCon.Close();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool ExcuteSqlQuery(SqlCommand ComQuery)
        {
            try
            {
                SQLMCon.Open();
                ComQuery.Connection = SQLMCon;
                ComQuery.ExecuteNonQuery();
                SQLMCon.Close();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable TraerDatosSQL(string queryString)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, SQLMCon);
            DataSet ObjDS = new DataSet();
            adapter.Fill(ObjDS, "Table");
            return ObjDS.Tables["Table"];
        }

    }
}
