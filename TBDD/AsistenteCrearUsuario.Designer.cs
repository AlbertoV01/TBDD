namespace TBDD
{
    partial class AsistenteCrearUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("db_owner");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("db_securityadmin");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("db_accessadmin");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("db_backupoperator");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("db_backupoperator");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("db_datawriter");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("db_datareader");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("db_denydatawriter");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("db_denydatareader");
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.tb_Contra = new System.Windows.Forms.TextBox();
            this.tb_ConfirmarContra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMostrarContra = new System.Windows.Forms.PictureBox();
            this.tv_RolesBdd = new System.Windows.Forms.TreeView();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.tv_BasesDeDatos = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.policy = new System.Windows.Forms.CheckBox();
            this.cmb_BdD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarContra)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.tb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tb_Usuario.Location = new System.Drawing.Point(0, 54);
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(915, 27);
            this.tb_Usuario.TabIndex = 1;
            this.tb_Usuario.Text = "USUARIO";
            this.tb_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Usuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Usuario_MouseClick);
            this.tb_Usuario.Leave += new System.EventHandler(this.tb_Usuario_Leave);
            // 
            // tb_Contra
            // 
            this.tb_Contra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Contra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.tb_Contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tb_Contra.Location = new System.Drawing.Point(0, 96);
            this.tb_Contra.Name = "tb_Contra";
            this.tb_Contra.Size = new System.Drawing.Size(915, 27);
            this.tb_Contra.TabIndex = 2;
            this.tb_Contra.Text = "CONTRASEÑA";
            this.tb_Contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Contra.Enter += new System.EventHandler(this.tb_Contra_Enter);
            this.tb_Contra.Leave += new System.EventHandler(this.tb_Contra_Leave);
            // 
            // tb_ConfirmarContra
            // 
            this.tb_ConfirmarContra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ConfirmarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.tb_ConfirmarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ConfirmarContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tb_ConfirmarContra.Location = new System.Drawing.Point(0, 138);
            this.tb_ConfirmarContra.Name = "tb_ConfirmarContra";
            this.tb_ConfirmarContra.Size = new System.Drawing.Size(915, 27);
            this.tb_ConfirmarContra.TabIndex = 5;
            this.tb_ConfirmarContra.Text = "CONFIRMAR CONTRASEÑA";
            this.tb_ConfirmarContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ConfirmarContra.Enter += new System.EventHandler(this.tb_ConfirmarContra_Enter);
            this.tb_ConfirmarContra.Leave += new System.EventHandler(this.tb_ConfirmarContra_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "CREAR USUARIO";
            // 
            // pbMostrarContra
            // 
            this.pbMostrarContra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMostrarContra.BackColor = System.Drawing.Color.Transparent;
            this.pbMostrarContra.BackgroundImage = global::TBDD.Properties.Resources.kisspng_computer_icons_red_eye_symbol_5af35ab1b0e551_4248892915258979057246;
            this.pbMostrarContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMostrarContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMostrarContra.Image = global::TBDD.Properties.Resources.kisspng_computer_icons_red_eye_symbol_5af35ab1b0e551_4248892915258979057246;
            this.pbMostrarContra.Location = new System.Drawing.Point(876, 96);
            this.pbMostrarContra.Name = "pbMostrarContra";
            this.pbMostrarContra.Size = new System.Drawing.Size(39, 27);
            this.pbMostrarContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrarContra.TabIndex = 10;
            this.pbMostrarContra.TabStop = false;
            this.pbMostrarContra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMostrarContra_MouseDown);
            this.pbMostrarContra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMostrarContra_MouseUp);
            // 
            // tv_RolesBdd
            // 
            this.tv_RolesBdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_RolesBdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tv_RolesBdd.CheckBoxes = true;
            this.tv_RolesBdd.Location = new System.Drawing.Point(12, 416);
            this.tv_RolesBdd.Name = "tv_RolesBdd";
            treeNode10.Name = "db_owner";
            treeNode10.Text = "db_owner";
            treeNode11.Name = "db_securityadmin";
            treeNode11.Text = "db_securityadmin";
            treeNode12.Name = "db_accessadmin";
            treeNode12.Text = "db_accessadmin";
            treeNode13.Name = "db_backupoperator";
            treeNode13.Text = "db_backupoperator";
            treeNode14.Name = "db_backupoperator";
            treeNode14.Text = "db_backupoperator";
            treeNode15.Name = "db_datawriter";
            treeNode15.Text = "db_datawriter";
            treeNode16.Name = "db_datareader";
            treeNode16.Text = "db_datareader";
            treeNode17.Name = "db_denydatawriter";
            treeNode17.Text = "db_denydatawriter";
            treeNode18.Name = "db_denydatareader";
            treeNode18.Text = "db_denydatareader";
            this.tv_RolesBdd.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            this.tv_RolesBdd.Size = new System.Drawing.Size(891, 169);
            this.tv_RolesBdd.TabIndex = 11;
            // 
            // btn_Crear
            // 
            this.btn_Crear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.btn_Crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.btn_Crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_Crear.Location = new System.Drawing.Point(12, 606);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(891, 28);
            this.btn_Crear.TabIndex = 14;
            this.btn_Crear.Text = "CREAR";
            this.btn_Crear.UseVisualStyleBackColor = false;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // tv_BasesDeDatos
            // 
            this.tv_BasesDeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_BasesDeDatos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tv_BasesDeDatos.CheckBoxes = true;
            this.tv_BasesDeDatos.Location = new System.Drawing.Point(12, 213);
            this.tv_BasesDeDatos.Name = "tv_BasesDeDatos";
            this.tv_BasesDeDatos.Size = new System.Drawing.Size(891, 169);
            this.tv_BasesDeDatos.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(765, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "BASES DE DATOS";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(667, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "DATABASE ROLE MEMBERSHIP";
            // 
            // policy
            // 
            this.policy.AutoSize = true;
            this.policy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.policy.Location = new System.Drawing.Point(12, 171);
            this.policy.Name = "policy";
            this.policy.Size = new System.Drawing.Size(128, 20);
            this.policy.TabIndex = 18;
            this.policy.Text = "CHECK_POLICY";
            this.policy.UseVisualStyleBackColor = true;
            // 
            // cmb_BdD
            // 
            this.cmb_BdD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_BdD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(66)))));
            this.cmb_BdD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_BdD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmb_BdD.FormattingEnabled = true;
            this.cmb_BdD.Location = new System.Drawing.Point(666, 171);
            this.cmb_BdD.Name = "cmb_BdD";
            this.cmb_BdD.Size = new System.Drawing.Size(237, 24);
            this.cmb_BdD.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(379, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "BASE DE DATOS POR DEFECTO:";
            // 
            // AsistenteCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(8)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(915, 646);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_BdD);
            this.Controls.Add(this.policy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tv_BasesDeDatos);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.tv_RolesBdd);
            this.Controls.Add(this.pbMostrarContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ConfirmarContra);
            this.Controls.Add(this.tb_Contra);
            this.Controls.Add(this.tb_Usuario);
            this.Name = "AsistenteCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsistenteCrearUsuario";
            this.Load += new System.EventHandler(this.AsistenteCrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarContra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.TextBox tb_Contra;
        private System.Windows.Forms.TextBox tb_ConfirmarContra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMostrarContra;
        private System.Windows.Forms.TreeView tv_RolesBdd;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.TreeView tv_BasesDeDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox policy;
        private System.Windows.Forms.ComboBox cmb_BdD;
        private System.Windows.Forms.Label label4;
    }
}