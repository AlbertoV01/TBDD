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


namespace TBDD
{
    public partial class Interfaz : Form
    {

        DataTable DtServidor = new DataTable();
        DataTable BasesDeDatos = new DataTable();
        DataTable Tablas = new DataTable();
        DataTable Campos = new DataTable();
        DataTable Constraint = new DataTable();
        DataTable Vistas = new DataTable();
        DataTable SystemViews = new DataTable();

        TreeNode NodoServidor = new TreeNode();
        TreeNode NodoBasesDeDatos = new TreeNode();
        TreeNode NodoTablas = new TreeNode();
        TreeNode NodoCampos = new TreeNode();
        TreeNode NodoConstraint = new TreeNode();
        string CampoPk=string.Empty;

        string servidor = string.Empty;
        string usuario = string.Empty;
        string contra = string.Empty;
        dbSqlServer sql;
        public Interfaz(string servidor, string usuario, string contra, dbSqlServer sql)
        {
            this.servidor = servidor;
            this.usuario = usuario;
            this.contra = contra;
            this.sql = sql;

            InitializeComponent();
            sql = new dbSqlServer(servidor,usuario,contra);
        }


        private void Btn_Conectar_Click(object sender, EventArgs e)
        
        {

            if (!sql.ConexionAbierta())
            {
                if (sql.AbrirConexion())
                {
                    MessageBox.Show("Conexión exitosa");
                   

                }
                else
                {
                    MessageBox.Show($"Hay un error {sql.sLastError}");
                }
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void Tv_BDD_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {            
            // PRUEBA DE CODIGO

            //if (e.Button == MouseButtons.Right)
            //{
            //    CmsPopOut.Show(Cursor.Position);
            //}
        }

        private void Tv_BDD_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //PRUEBA DE CODIGO

            //if (Tv_Campos.Nodes.Count != 0) Tv_Campos.Nodes.Clear();

            //dbSqlServer sql = new dbSqlServer(Tb_Servidor.Text, Tb_Usuario.Text, Tb_Contra.Text);
            //if (sql.AbrirConexion()) ;
            //OpTreeView op = new OpTreeView();
            //op.CargarCampos(sql.conexion, Tv_BDD.SelectedNode.Text, Tv_Campos, Tv_BDD.SelectedNode.Parent.Text);
        }

        private void nuevaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // PRUEBA DE CODIGO 
            //FmAsistente asist = new FmAsistente();
            //asist.Show();
        }

        // BOTON PARA ABRIR EL ASISTENTE DONDE SE CREAN LAS TABLAS
        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            if (Tv_BDD.SelectedNode == null)
            {
                return;
            }
            if (Tv_BDD.SelectedNode.Text == servidor)
                return;
            if (Tv_BDD.SelectedNode.Parent.Text == servidor)
            {
                FmAsistente fmAsistente = new FmAsistente(servidor, usuario,contra, Tv_BDD.SelectedNode.Text);
                fmAsistente.ShowDialog();
            }
        }
        // BOTON PARA CONETARSE AL MOTOR DE LA BASE DE DATOS SQL
        private void Btn_Ejecutar_Click(object sender, EventArgs e)
        {
            if (Tv_BDD.SelectedNode==null)
            {
                return;
            }
            if (!sql.ConexionAbierta())
            {
                if (sql.AbrirConexion())
                {
                    if (!sql.EjecutarComando(Tb_Consultas.Text,Tv_BDD.SelectedNode.Text))
                    {
                        MessageBox.Show("Ha ocurrido un error " + sql.sLastError);
                    }
                    else
                    {
                        MessageBox.Show("Comando ejecutado correctamente");
                    }
                }
            }
            else
            {      
                if(Tb_Consultas.Text.ToLower().Contains("select"))
                {
                    Dgv_Resultados.DataSource = sql.EjecutarConsulta(Tb_Consultas.Text,Tv_BDD.SelectedNode.Text);
                }
                else
                {
                    if (!sql.EjecutarComando(Tb_Consultas.Text,Tv_BDD.SelectedNode.Text))
                    {
                        MessageBox.Show("Ha ocurrido un error " + sql.sLastError);
                    }
                    else
                    {
                        MessageBox.Show("Comando ejecutado correctamente");
                    }
                } 
            }
        }

        private void Tv_BDD_DoubleClick(object sender, EventArgs e)
        {
            // CONDICION PARA VERIFICAR QUE EL NODO SELECCIONADO SEA DEVUELVA NULLO, DE SER ASI NO ENTRA A LAS DEMAS INSTRUCCIONES
            if (Tv_BDD.SelectedNode == null) return;
            if (Tv_BDD.SelectedNode.Parent == null)
            {
                return;
            }
            // CONDICION PARA LIMPIAR LOS NODOS DEL TREE VIEW INFERIOR SIEMPRE QUE HAYA MAS UN NODO O MAS
            if (Tv_Campos.Nodes.Count != 0)
            {
                Tv_Campos.Nodes.Clear();
            }

            // DATA TABLE DONDE SE CARGAN LAS TABLAS y LAS VISTAS
            Tablas = sql.Tablas(sql.conexion, Tv_BDD.SelectedNode.Text);
            Vistas = sql.Vistas(sql.conexion, Tv_BDD.SelectedNode.Text);
            SystemViews = sql.SystemViews(sql.conexion);
            // VISTAS DEL SISTEMA
            TreeNode nodoVistaSistema = new TreeNode();
            nodoVistaSistema.Text = "System Views";
            nodoVistaSistema.Name = "System Views";
            Tv_Campos.Nodes.Add(nodoVistaSistema);
            TreeNode nodoSystemViews = new TreeNode();

            foreach(DataRow fila in SystemViews.Rows)
            {
                nodoSystemViews = new TreeNode();
                nodoSystemViews.Text = fila[0].ToString();
                nodoSystemViews.Name = fila[0].ToString();
                Tv_Campos.Nodes[nodoVistaSistema.Name].Nodes.Add(nodoSystemViews);
            }


            //VISTAS DE las BASES DE DATOS
            TreeNode nodoPrimario = new TreeNode();
            nodoPrimario.Text = "Views";
            nodoPrimario.Name = "Views";
            Tv_Campos.Nodes.Add(nodoPrimario);
            TreeNode nodoVistas = new TreeNode();

            for (int i = 0; i < Vistas.Rows.Count; i++)
            {
                nodoVistas = new TreeNode();
                nodoVistas.Text = Vistas.Rows[i][0].ToString();
                nodoVistas.Name = Vistas.Rows[i][0].ToString();
                Tv_Campos.Nodes[nodoPrimario.Name].Nodes.Add(nodoVistas);
            }
           
           

            // CICLO ANIDADO PARA CARGAR EL TREE VIEW EN EL CUAL SE CARGAN LAS TABLAS, LOS CAMPOS Y SUS TIPOS DE DATO
            for (int b=0; b<Tablas.Rows.Count; b++)
            {

                NodoTablas = new TreeNode();
                NodoTablas.Text = Tablas.Rows[b][0].ToString();
                NodoTablas.Name = Tablas.Rows[b][0].ToString();
                Tv_Campos.Nodes.Add(NodoTablas);
                Campos = sql.Campos(sql.conexion, Tablas.Rows[b][0].ToString(), Tv_BDD.SelectedNode.Text);


                for (int c = 0; c < Campos.Rows.Count; c++)
                {
                    NodoCampos = new TreeNode();

                    string TipoDeDatoLongitud = Campos.Rows[c][2].ToString();
                    Constraint = sql.Constraint(sql.conexion, Tv_BDD.SelectedNode.Text, Tablas.Rows[b][0].ToString());
                    if (Constraint.Rows.Count != 0)
                    {
                        if (Constraint.Rows.Count > 1)
                        {
                            CampoPk = Constraint.Rows[1][1].ToString();
                        }
                        else
                        {
                            CampoPk = Constraint.Rows[0][1].ToString();
                        }

                    }


                    // CONDICION PARA REMOVER LOS PARENTESIS A AQUELLOS CAMPOS QUE SU TIPO DE DATO NO LO REQUIERA
                    if (TipoDeDatoLongitud == "")
                    {
                        if (Campos.Rows[c][0].ToString().Contains(CampoPk))
                        {
                            if (CampoPk == "")
                            {
                                NodoCampos.Text = Campos.Rows[c][0].ToString() + "  " + Campos.Rows[c][1].ToString();
                            }
                            else
                            {
                                NodoCampos.Text = Campos.Rows[c][0].ToString() + "  PK   " + Campos.Rows[c][1].ToString() + " not null";
                            }
                        }
                        else
                        {
                            NodoCampos.Text = Campos.Rows[c][0].ToString() + "  " + Campos.Rows[c][1].ToString();
                        } 
                    }
                    else
                    {
                        if (Campos.Rows[c][0].ToString().Contains(CampoPk))
                        {
                            NodoCampos.Text = Campos.Rows[c][0].ToString() + "  PK   " + Campos.Rows[c][1].ToString() + $" ({Campos.Rows[c][2]}) " + " not null";
                                
                        }
                        else
                        {
                            NodoCampos.Text = Campos.Rows[c][0] + " " + Campos.Rows[c][1].ToString() + $" ({Campos.Rows[c][2]})";
                        }
                    }
                    NodoCampos.Name = Campos.Rows[c][0].ToString();
                    Tv_Campos.Nodes[NodoTablas.Name].Nodes.Add(NodoCampos);
                }
            }
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

            DtServidor = sql.ServidorLocal(sql.conexion);
            NodoServidor = new TreeNode();
            NodoServidor.Text = DtServidor.Rows[0][0].ToString();
            NodoServidor.Name = DtServidor.Rows[0][0].ToString();
            Tv_BDD.Nodes.Add(NodoServidor);
            BasesDeDatos = sql.BasesDeDatos(sql.conexion);

            // CICLO QUE CARGA TODAS LAS BASES DE DATOS EN EL PRIMER TREE VIEW (EXCEPTO LAS DEL SISTEMA)
            for (int a = 0; a < BasesDeDatos.Rows.Count; a++)
            {
                NodoBasesDeDatos = new TreeNode();
                NodoBasesDeDatos.Text = BasesDeDatos.Rows[a][0].ToString();
                NodoBasesDeDatos.Name = BasesDeDatos.Rows[a][0].ToString();
                Tv_BDD.Nodes[NodoServidor.Name].Nodes.Add(NodoBasesDeDatos);
            }
        }

        private void PnlIzq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            AsistenteCrearUsuario fmAsistenteCrearUsuario = new AsistenteCrearUsuario(servidor,usuario,contra);
            fmAsistenteCrearUsuario.basesDeDatosDefault = (sql.BasesDeDatosIS(sql.conexion));
            fmAsistenteCrearUsuario.ShowDialog();

     
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
