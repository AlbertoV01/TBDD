using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Conexiones
{
    public class dbSqlServer
    {
        public string sLastError = "";
        public SqlConnection conexion;

        // CONSTRUCTOR DE LA CLASE
        public dbSqlServer(string sServer, string sUsuario, string sPassword)
        {
            conexion = new SqlConnection($"Server={sServer};Database=master;User Id={sUsuario};Password={sPassword};");
        }

        // METODO PARA ABRIR LA CONEXION DE SQL
        public Boolean AbrirConexion()
        {
            Boolean bALLOK = true;
            try
            {
                conexion.Open();
            }
            catch (Exception EX)
            {
                sLastError = EX.Message;
                bALLOK = false;
            }
            return bALLOK;
        }

        // METODO PARA COMPROBAR SI LA CONEXION A SQL ESTA EN OPEN O CLOSE
        public Boolean ConexionAbierta()
        {
            Boolean bALLOk = true;

            try
            {
                bALLOk = conexion.State == System.Data.ConnectionState.Open ? true : false;
            }
            catch (Exception ex)
            {
                sLastError = ex.Message;
                bALLOk = false;
            }
            return bALLOk;
        }

        // METODOS PARA EJECUTAR LOS QUERY
        public Boolean EjecutarComando(string sCmd)
        {
         
            Boolean bALLOk = true;
            try
            {
                using (SqlCommand cmd = new SqlCommand(sCmd, conexion))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                bALLOk = false;
                sLastError = ex.Message;
            }

            return bALLOk;
        }
        public Boolean EjecutarComando(string sCmd, string BaseDeDatos)
        {
            if (sCmd.Contains(""))
            {
                return false;
            }

            string Extra = $"use {BaseDeDatos}" + sCmd;
            Boolean bALLOk = true;
            try
            {
                using (SqlCommand cmd = new SqlCommand(Extra, conexion))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                bALLOk = false;
                sLastError = ex.Message;
            }

            return bALLOk;
        }
        // METODO QUE DEVUELVE LAS TABLAS DE LAS CONSULTAS
        public DataTable EjecutarConsulta(string sCmd, string BaseDeDatos)
        {
            string Extra = $"use {BaseDeDatos} " + sCmd;

            DataTable DtConsulta = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(Extra, conexion))
                {
                    DtConsulta.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                sLastError = ex.Message;
            }

            return DtConsulta;
        }

        // METODO PARA CREAR LA TABLA MEDIANTE EL "ASISTENTE"
        public Boolean CrearTabla(DataGridView Dgv_CrearTablas, string BaseDeDatos, string NombreDeTabla)
        {
            Boolean bALLOk = true;
            StringBuilder stringBuilder = new StringBuilder($"use {BaseDeDatos} create table {NombreDeTabla}");

            try
            {
                int columnas = Dgv_CrearTablas.Columns.Count;
                int filas = Dgv_CrearTablas.Rows.Count - 1;

                for (int j = 0; j < filas; j++)
                {
                    for (int i = 0; i < columnas; i++)
                    {
                        var campo = Dgv_CrearTablas.Rows[j].Cells[i].Value;
                        if (i == 0 && j == 0) stringBuilder.Append("(");
                        stringBuilder.Append(" " + campo);
                    }
                    //CONDICION PARA DECIDIR SI EL CAMPO ES PRIMARY KEY
                    if (Convert.ToBoolean(Dgv_CrearTablas.Rows[j].Cells[3].Value))
                        stringBuilder = stringBuilder.Replace("true", "primary key");
                    else
                        stringBuilder = stringBuilder.Replace("false", " ");
                    // CONDICION PARA SABER SI EL CAMPO ES IDENTITY
                    string sVariable = stringBuilder.ToString();
                    if (sVariable.Contains("si"))
                        stringBuilder = stringBuilder.Replace("si", "identity(1,1)");
                    if (sVariable.Contains("false"))
                        stringBuilder = stringBuilder.Replace("false", " ");
                    stringBuilder.Append(",");
                    if (j == filas - 1) stringBuilder.Append(")");
                }
                string Query = stringBuilder.ToString();
                SqlCommand cmd = new SqlCommand(Query, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                bALLOk = false;
                sLastError = ex.Message;
            }
            return bALLOk;
        } 
        // FUNCION PARA CERRAR LA CONEXION DE SQL
        public void CerrarConexion()
        {
            conexion.Close();
        }
        // FUNCION QUE DUEVUELVE EL SERVIDOR LOCAL
        public DataTable ServidorLocal(SqlConnection sConexion)
        {
            DataTable ServidorLocal = new DataTable();
            string Query = "select @@servername as 'Server Name'";
            SqlCommand Cmd = new SqlCommand(Query, sConexion);
            ServidorLocal.Load(Cmd.ExecuteReader());
            return ServidorLocal;
        }
        // FUNCION QUE DEVUELVE LAS BASE DE DATOS
        public DataTable BasesDeDatos(SqlConnection sConexion)
        {
            DataTable BasesDeDatos = new DataTable();
            string Query = "select name from sys.databases where database_id not in ('1','2','3','4')";
            SqlCommand Cmd = new SqlCommand(Query, sConexion);
            BasesDeDatos.Load(Cmd.ExecuteReader());
            return BasesDeDatos;
        }
        public DataTable BasesDeDatosIS(SqlConnection sConexion)
        {
            DataTable BasesDeDatos = new DataTable();
            string Query = "select name from sys.databases";
            SqlCommand Cmd = new SqlCommand(Query, sConexion);
            BasesDeDatos.Load(Cmd.ExecuteReader());
            return BasesDeDatos;
        }

        // FUNCION QUE DEVUELVE LAS TABLAS DE LAS BASES DE DATOS
        public DataTable Tablas(SqlConnection sConexion, String sBaseDeDatos)
        {
            DataTable Tablas = new DataTable();
            string Query = $" use {sBaseDeDatos} select name  from sys.tables where name not in ('sysdiagrams')";
            SqlCommand Cmd = new SqlCommand(Query, sConexion);
            Tablas.Load(Cmd.ExecuteReader());
            return Tablas;
        }
        // FUNCION QUE DEVUELVE LOS CMAPOS Y LOS TIPOS DE DATOS 
        public DataTable Campos(SqlConnection sConexion,String NombreTabla, String BaseDeDatos)
        {
            DataTable Campos = new DataTable();
            string Query = $"use {BaseDeDatos} select column_name, data_type, character_maximum_length from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='{NombreTabla}'";
            SqlCommand Cmd = new SqlCommand(Query,sConexion);
            Campos.Load(Cmd.ExecuteReader());
            return Campos;
        }
        // FUNCION QUE DEVUELVE EL NOMBRE DE LA TABLA Y CUAL CAMPO QUE CONTIENE ES CONSTRAINT
        public DataTable Constraint(SqlConnection sConexion, String BaseDeDatos, String Tabla)
        {
            DataTable Constraint = new DataTable();
            string Query = $"use {BaseDeDatos} select TABLE_NAME,COLUMN_NAME from INFORMATION_SCHEMA.KEY_COLUMN_USAGE where table_name = '{Tabla}'";
            SqlCommand Cmd = new SqlCommand(Query,sConexion);
            Constraint.Load(Cmd.ExecuteReader());
            return Constraint;
        }
        // FUNCION QUE DEVUELVE LAS VISTAS DE LA BASE DE DATOS
        public DataTable Vistas(SqlConnection sConexion, String BaseDeDatos)
        {
            DataTable vistas = new DataTable();
            string query = $"use {BaseDeDatos} select TABLE_NAME from INFORMATION_SCHEMA.VIEWS";
            SqlCommand Cmd = new SqlCommand(query,sConexion);
            vistas.Load(Cmd.ExecuteReader());
            return vistas;
        }
        // FUNCION QUE DEVUELVE LAS VISTAS DEL SISTEMA
        public DataTable SystemViews(SqlConnection sConexion)
        {
            DataTable SystemViews = new DataTable();
            string query = $"select Esquemas.name + Vistas.name as SystemViews\r\nfrom sys.system_views as Vistas\r\ninner join sys.schemas as Esquemas on Vistas.schema_id = Esquemas.schema_id\r\nORDER BY Esquemas.name ASC, Vistas.name ASC;";
            SqlCommand Cmd = new SqlCommand(query, sConexion);
            SystemViews.Load(Cmd.ExecuteReader());
            return SystemViews;
        }
        
    }
}