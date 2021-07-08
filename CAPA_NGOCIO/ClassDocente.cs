using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class ClassDocente
    {
        public int IdDocente { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento  { get; set; }
        public string Genero { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public  string NumeroTelefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Activo { get; set; }

        public bool Save(ClassDocente Docente)
        {
            try
            {
                if (Docente.IdDocente != -1)
                { 

                    SqlADOConexion.IniciarConexion("sa", "1234");
                    string strQuery = "UPDATE  DOCENTE  " +
                        "set [Codigo] = '" + Docente.Codigo +
                        "', [NOmbres] = '" + Docente.Nombres +
                        "', [Apellidos] = '" + Docente.Apellidos +
                        "', [DNI] = '" + Docente.DNI +
                        "', [FechaNacimiento] = '" + Docente.FechaNacimiento +
                        "', [Genero] = '" + Docente.Genero +
                        "', [Ciudad] = '" + Docente.Ciudad +
                        "', [Direccion] = '" + Docente.Direccion +
                        "', [NumeroTelefono] = '" + Docente.NumeroTelefono +
                        "', [FechaRegistro] = '" + Docente.FechaRegistro +
                        "', [Activo] = '" + Docente.Activo + "' WHERE idDocente =" + Docente.IdDocente;
                    SqlADOConexion.SQLM.ExcuteSqlQuery(strQuery);
                }
                else
                {
                    SqlADOConexion.IniciarConexion("sa", "1234");
                    string strQuery = "INSERT INTO DOCENTE" +
                        "([Codigo], [Nombres],[Apellidos],[DNI],[FechaNacimiento],[Genero],[Ciudad],[Direccion]," +
                        "[NumeroTelefono],[FechaRegistro],[Activo])" +
                        "VALUES('" + Docente.Codigo +
                        "','" + Docente.Nombres +
                        "','" + Docente.Apellidos +
                        "','" + Docente.DNI +
                        "','" + Docente.FechaNacimiento +
                        "','" + Docente.Genero +
                        "','" + Docente.Ciudad +
                        "','" + Docente.Direccion +
                        "','" + Docente.NumeroTelefono +
                        "','" + Docente.FechaNacimiento +
                        "','" + Docente.Activo + "')";
                    SqlADOConexion.SQLM.ExcuteSqlQuery(strQuery);

                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public object Filter()
        {
            SqlADOConexion.IniciarConexion("sa", "1234");
            DataTable Data = SqlADOConexion.SQLM.TraerDatosSQL("select * from DOCENTE");
            List<ClassDocente> List = new List<ClassDocente>();
            for (int i = 0; i < Data.Rows.Count; i++)
            {
                ClassDocente DC = new ClassDocente();
                DC.IdDocente = Convert.ToInt32(Data.Rows[i]["IdDocente"]);
                DC.Codigo = Data.Rows[i]["Codigo"].ToString();
                DC.Nombres = Data.Rows[i]["Nombres"].ToString();
                DC.Apellidos = Data.Rows[i]["Apellidos"].ToString();
                DC.DNI = Data.Rows[i]["DNI"].ToString();
                DC.FechaNacimiento = Convert.ToDateTime(Data.Rows[i]["FechaNacimiento"]);
                DC.Genero = Data.Rows[i]["Genero"].ToString();
                DC.Ciudad = Data.Rows[i]["Ciudad"].ToString();
                DC.NumeroTelefono = Data.Rows[i]["NumeroTelefono"].ToString();
                DC.FechaRegistro = Convert.ToDateTime(Data.Rows[i]["FechaRegistro"]);
                DC.Activo = Data.Rows[i]["Activo"].ToString();
                List.Add(DC);
            }
            return List;
        }
    }
}
