namespace TBDD
{
    partial class Interfaz
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tb_Consultas = new System.Windows.Forms.TextBox();
            this.Tv_Campos = new System.Windows.Forms.TreeView();
            this.Tv_BDD = new System.Windows.Forms.TreeView();
            this.CmsPopOut = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Ejecutar = new System.Windows.Forms.Button();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.PnlIzq = new System.Windows.Forms.Panel();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.Dgv_Resultados = new System.Windows.Forms.DataGridView();
            this.CmsPopOut.SuspendLayout();
            this.PnlIzq.SuspendLayout();
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Consultas
            // 
            this.Tb_Consultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.Tb_Consultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tb_Consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Consultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Tb_Consultas.Location = new System.Drawing.Point(270, 34);
            this.Tb_Consultas.Multiline = true;
            this.Tb_Consultas.Name = "Tb_Consultas";
            this.Tb_Consultas.Size = new System.Drawing.Size(1158, 322);
            this.Tb_Consultas.TabIndex = 4;
            // 
            // Tv_Campos
            // 
            this.Tv_Campos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.Tv_Campos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tv_Campos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tv_Campos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tv_Campos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Tv_Campos.Location = new System.Drawing.Point(0, 356);
            this.Tv_Campos.Name = "Tv_Campos";
            this.Tv_Campos.Size = new System.Drawing.Size(264, 326);
            this.Tv_Campos.TabIndex = 6;
            // 
            // Tv_BDD
            // 
            this.Tv_BDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.Tv_BDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tv_BDD.ContextMenuStrip = this.CmsPopOut;
            this.Tv_BDD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tv_BDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tv_BDD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Tv_BDD.Location = new System.Drawing.Point(0, 3);
            this.Tv_BDD.Name = "Tv_BDD";
            this.Tv_BDD.Size = new System.Drawing.Size(264, 353);
            this.Tv_BDD.TabIndex = 7;
            this.Tv_BDD.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tv_BDD_AfterSelect);
            this.Tv_BDD.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tv_BDD_NodeMouseClick);
            this.Tv_BDD.DoubleClick += new System.EventHandler(this.Tv_BDD_DoubleClick);
            // 
            // CmsPopOut
            // 
            this.CmsPopOut.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsPopOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.nuevaTablaToolStripMenuItem});
            this.CmsPopOut.Name = "contextMenuStrip1";
            this.CmsPopOut.Size = new System.Drawing.Size(255, 68);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.nuevaToolStripMenuItem.Text = "Nueva Base De Datos";
            // 
            // nuevaTablaToolStripMenuItem
            // 
            this.nuevaTablaToolStripMenuItem.Name = "nuevaTablaToolStripMenuItem";
            this.nuevaTablaToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.nuevaTablaToolStripMenuItem.Text = "Nueva Tabla";
            this.nuevaTablaToolStripMenuItem.Click += new System.EventHandler(this.nuevaTablaToolStripMenuItem_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.Btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.Btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Btn_Guardar.Location = new System.Drawing.Point(652, -3);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(218, 28);
            this.Btn_Guardar.TabIndex = 8;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Ejecutar
            // 
            this.Btn_Ejecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.Btn_Ejecutar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Ejecutar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.Btn_Ejecutar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.Btn_Ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ejecutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Btn_Ejecutar.Location = new System.Drawing.Point(0, 0);
            this.Btn_Ejecutar.Name = "Btn_Ejecutar";
            this.Btn_Ejecutar.Size = new System.Drawing.Size(198, 28);
            this.Btn_Ejecutar.TabIndex = 9;
            this.Btn_Ejecutar.Text = "Ejecutar";
            this.Btn_Ejecutar.UseVisualStyleBackColor = false;
            this.Btn_Ejecutar.Click += new System.EventHandler(this.Btn_Ejecutar_Click);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.Btn_Crear.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn_Crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.Btn_Crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.Btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Crear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Btn_Crear.Location = new System.Drawing.Point(198, 0);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(158, 28);
            this.Btn_Crear.TabIndex = 10;
            this.Btn_Crear.Text = "Crear Tabla";
            this.Btn_Crear.UseVisualStyleBackColor = false;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // PnlIzq
            // 
            this.PnlIzq.Controls.Add(this.Tv_BDD);
            this.PnlIzq.Controls.Add(this.Tv_Campos);
            this.PnlIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzq.Location = new System.Drawing.Point(0, 0);
            this.PnlIzq.Name = "PnlIzq";
            this.PnlIzq.Size = new System.Drawing.Size(264, 682);
            this.PnlIzq.TabIndex = 11;
            this.PnlIzq.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlIzq_Paint);
            // 
            // pnlArriba
            // 
            this.pnlArriba.Controls.Add(this.btn_CrearUsuario);
            this.pnlArriba.Controls.Add(this.Btn_Crear);
            this.pnlArriba.Controls.Add(this.Btn_Ejecutar);
            this.pnlArriba.Controls.Add(this.Btn_Guardar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(264, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(1176, 28);
            this.pnlArriba.TabIndex = 12;
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.btn_CrearUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            this.btn_CrearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            this.btn_CrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_CrearUsuario.Location = new System.Drawing.Point(362, 0);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(218, 28);
            this.btn_CrearUsuario.TabIndex = 13;
            this.btn_CrearUsuario.Text = "CREAR USUARIO";
            this.btn_CrearUsuario.UseVisualStyleBackColor = false;
            this.btn_CrearUsuario.Click += new System.EventHandler(this.btn_CrearUsuario_Click);
            // 
            // Dgv_Resultados
            // 
            this.Dgv_Resultados.AllowUserToResizeColumns = false;
            this.Dgv_Resultados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Dgv_Resultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Resultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Resultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Resultados.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Resultados.EnableHeadersVisualStyles = false;
            this.Dgv_Resultados.Location = new System.Drawing.Point(270, 356);
            this.Dgv_Resultados.Name = "Dgv_Resultados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Resultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Resultados.RowHeadersVisible = false;
            this.Dgv_Resultados.RowHeadersWidth = 51;
            this.Dgv_Resultados.RowTemplate.Height = 24;
            this.Dgv_Resultados.Size = new System.Drawing.Size(1158, 314);
            this.Dgv_Resultados.TabIndex = 13;
            // 
            // Interfaz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1440, 682);
            this.Controls.Add(this.Dgv_Resultados);
            this.Controls.Add(this.pnlArriba);
            this.Controls.Add(this.PnlIzq);
            this.Controls.Add(this.Tb_Consultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.CmsPopOut.ResumeLayout(false);
            this.PnlIzq.ResumeLayout(false);
            this.pnlArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tb_Consultas;
        private System.Windows.Forms.TreeView Tv_Campos;
        private System.Windows.Forms.TreeView Tv_BDD;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.ContextMenuStrip CmsPopOut;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaTablaToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Ejecutar;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.Panel PnlIzq;
        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.DataGridView Dgv_Resultados;
        private System.Windows.Forms.Button btn_CrearUsuario;
    }
}

