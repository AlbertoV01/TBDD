using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexiones;
using System.Data.Sql;
using System.Data.SqlClient;


namespace TBDD
{
    public partial class FmAsistente : Form
    {
        SqlConnection conexion;
        dbSqlServer sql;
        //todo: borrame
        public FmAsistente()
        {

        }
        public FmAsistente(string sServer, string sUsuario, string sPassword, string sBaseDeDatos)
        {
            InitializeComponent();
            conexion = new SqlConnection($"Server={sServer};Database=master;User Id={sUsuario};Password={sPassword};");
            sql = new dbSqlServer(sServer, sUsuario, sPassword);
            Tb_BaseDeDatos.Text = sBaseDeDatos;
        }
        // BOTON QUE ABRE UN NUEVO FORMULARIO DONDE SE ABRE UN "ASISTENTE" PARA CREAR TABLAS CON SUS RESPECTIVOS CAMPOS
        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            DataRow data;
            if (!sql.ConexionAbierta())
            {
                if (sql.AbrirConexion())
                {
                    if (sql.CrearTabla(Dgv_CrearTablas, Tb_BaseDeDatos.Text, Tb_NombreDeTabla.Text))
                    {
                        MessageBox.Show("Tabla creada correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error " + sql.sLastError);
                    }
                }
            }
        }

        // EVENTO DEL COMBOBOX NECESARIO PARA PODER ESCRIBIR EN EL COMBOBOX
        private void Dgv_CrearTablas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //  es para poder escribir en el combobox que esta dentro del datagrid
            ComboBox combo = e.Control as ComboBox;

            if (combo != null)
            {
                combo.DropDownStyle = ComboBoxStyle.DropDown;
            }
        }

        //EVENTO NECESARIO PARA PODER ESCRIBIR EN EL COMBOBOX
        private void Dgv_CrearTablas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // es para conocer que celda sera validada y en que columna. Para verificar si se encuentra con un objeto dentro de el y si es asi se lo agrega
            // para despues agregarle el valor a la celda que este activa en ese momento
            if (e.ColumnIndex == tipodedato.DisplayIndex)
            {
                if (!tipodedato.Items.Contains(e.FormattedValue))
                {
                    tipodedato.Items.Add(e.FormattedValue);
                }
                Dgv_CrearTablas.CurrentCell.Value = e.FormattedValue;
            }
            
        }



    }
}
