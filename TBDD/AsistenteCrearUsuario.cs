using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexiones;

namespace TBDD
{
    public partial class AsistenteCrearUsuario : Form
    {
        private string servidor { get; set; }
        private string usuario { get; set; }
        private string contra { get; set; }
        dbSqlServer instancia = null;
        string error = string.Empty;
        public AsistenteCrearUsuario(string servidor, string usuario,string contra)
        {
            this.servidor = servidor;
            this.usuario = usuario;
            this.contra = contra;
            instancia = new dbSqlServer(servidor,usuario,contra);
            InitializeComponent();
        }
       
        public DataTable basesDeDatosDefault = new DataTable();
        private void tb_Usuario_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_Usuario.Text == "USUARIO")
            {
                tb_Usuario.Text = "";
            }
        }
        private void tb_Usuario_Leave(object sender, EventArgs e)
        {
            if (tb_Usuario.Text == "")
            {
                tb_Usuario.Text = "USUARIO";
            }
        }

        private void tb_Contra_Enter(object sender, EventArgs e)
        {
            if (tb_Contra.Text == "CONTRASEÑA")
            {
                tb_Contra.Text = "";
                tb_Contra.UseSystemPasswordChar = true;
            }
        }
        private void tb_Contra_Leave(object sender, EventArgs e)
        {
            if (tb_Contra.Text == "")
            {
                tb_Contra.UseSystemPasswordChar = false;
                tb_Contra.Text = "CONTRASEÑA";
            }
        }

        private void tb_ConfirmarContra_Enter(object sender, EventArgs e)
        {
            if (tb_ConfirmarContra.Text == "CONFIRMAR CONTRASEÑA")
            {
                tb_ConfirmarContra.Text = "";
                tb_ConfirmarContra.UseSystemPasswordChar = true;
            }
        }

        private void tb_ConfirmarContra_Leave(object sender, EventArgs e)
        {
            if (tb_ConfirmarContra.Text == "")
            {
                tb_ConfirmarContra.UseSystemPasswordChar = false;
                tb_ConfirmarContra.Text = "CONFIRMAR CONTRASEÑA";
            }
            else
            {
                if(!tb_Contra.Text.Equals(tb_ConfirmarContra.Text))
                {
                    MessageBox.Show("Su contraseña no concuerda");
                }
            }
        }

        private void pbMostrarContra_MouseDown(object sender, MouseEventArgs e)
        {
            if(tb_Contra.Text!="CONTRASEÑA")
            {
                if (MouseButtons == MouseButtons.Left)
                    tb_Contra.UseSystemPasswordChar = false;
            }

        }

        private void pbMostrarContra_MouseUp(object sender, MouseEventArgs e)
        {
            if(tb_Contra.Text!="CONTRASEÑA")
            {
                if (e.Button == MouseButtons.Left)
                {
                    tb_Contra.UseSystemPasswordChar = true;
                }
            }
        }

        private void AsistenteCrearUsuario_Load(object sender, EventArgs e)
        {
            cmb_BdD.DataSource = basesDeDatosDefault;
            cmb_BdD.DisplayMember = "name";
            cmb_BdD.ValueMember= "name";
            foreach(DataRow fila in basesDeDatosDefault.Rows)
            {
                TreeNode NodoP = new TreeNode();
                NodoP.Text = fila[0].ToString();
                NodoP.Text = fila[0].ToString();
                tv_BasesDeDatos.Nodes.Add(NodoP);
            }
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {

            

            if(tb_Usuario.Text=="USUARIO" && tb_Contra.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Favor introducir valores coherentes");
                return;
            }

            string caractEspecial = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~()";
            char[] caracterEspecial = caractEspecial.ToCharArray();
            char[] contraArray = tb_Contra.Text.ToCharArray();

            string abecedarioMinus = "abcdefghijklmnñopqrstuvwxyz";
            string abecedarioMayus = abecedarioMinus.ToUpper();
            char[] abeceMayus = abecedarioMayus.ToCharArray();
            char[] abeceMinus = abecedarioMinus.ToCharArray();


            var caracteresEspeciales = contraArray.Intersect(caractEspecial).ToList().Count;
            var abecedario = contraArray.Intersect(abeceMinus).ToList().Count;
            var abecedario2 = contraArray.Intersect(abeceMayus).ToList().Count;



            if(caracteresEspeciales < 0 || tb_Contra.Text.Length <8 || abecedario < 1 || abecedario2 < 1)
            {
                MessageBox.Show($"Contraseña inválida verifique que contenga algún caracter especial, {caractEspecial}\n almenos  una mayuscula y su longitud sea minimo de 8 caracteres");
                return;
            }


            string spolicy = string.Empty;

            if (policy.Checked)
            {
                spolicy = "on";
            }
            else
            {
                spolicy = "off";
            }

            string queryCrearLogin = "use master " +
                $" create login [{tb_Usuario.Text}] with password = '{tb_Contra.Text}'," +
                $"default_database=[{cmb_BdD.Text}], check_expiration=off, check_policy={spolicy}";

            
            if (instancia.AbrirConexion())
            {
                if (!instancia.EjecutarComando(queryCrearLogin))
                {
                    MessageBox.Show(instancia.sLastError);
                }

                // CICLO PARA RECORRER LAS BASES DE DATOS SELECCIONADAS
                for (int i = 0; i < tv_BasesDeDatos.Nodes.Count; i++)
                {
                    if (tv_BasesDeDatos.Nodes[i].Checked)
                    {   
                        string queryCrearUsuario = $"use [{tv_BasesDeDatos.Nodes[i].Text}]" +
                            $"create user [{tb_Usuario.Text}] for login [{tb_Usuario.Text}]";

                        if(!instancia.EjecutarComando(queryCrearUsuario))
                        {
                            MessageBox.Show(instancia.sLastError);
                        }
                            

                            //CICLO PARA RECORRER LOS ROLES QUE SE SELECCIONARON
                        for (int j = 0; j < tv_RolesBdd.Nodes.Count; j++)
                        {
                            if (tv_RolesBdd.Nodes[j].Checked)
                            {
                                string queryAsignarRol = $" use [{tv_BasesDeDatos.Nodes[i].Text}]" +
                                $"alter role [{tv_RolesBdd.Nodes[j].Text}] add member [{tb_Usuario.Text}]";

                                if(!instancia.EjecutarComando(queryAsignarRol))
                                {
                                    MessageBox.Show(instancia.sLastError);
                                }
                             }
                        }
                    }
                }

                MessageBox.Show("Usuario creado con exito");

            }       
            this.Close();
        }
    }
}
