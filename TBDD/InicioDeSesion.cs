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
    public partial class fmInicioDeSesion : Form
    {
        dbSqlServer sql;
        public fmInicioDeSesion()
        {
            InitializeComponent();
            sql = new dbSqlServer(Tb_Servidor.Text,Tb_Usuario.Text,Tb_Contra.Text);
        }
        private void Btn_Conectar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!sql.ConexionAbierta())
                {
                    if (Tb_Contra.Text == "" || Tb_Servidor.Text == "" || Tb_Usuario.Text == "")
                    {
                        MessageBox.Show("Favor de ingresar los datos completos");
                        return;
                    }
                    sql.conexion.Open();
                    Interfaz oInterfaz = new Interfaz(Tb_Servidor.Text, Tb_Usuario.Text, Tb_Contra.Text, sql);
                    oInterfaz.FormClosed += OInterfaz_FormClosed;
                    oInterfaz.Show();
                    this.Visible = false;
                    
                }
                else
                {
                    MessageBox.Show("Conexion cerrada");
                }
            }catch(Exception er)
            {
               string error=  er.Message;
            }
        }

        private void OInterfaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
