namespace TBDD
{
    partial class FmAsistente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.Tb_BaseDeDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_NombreDeTabla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_CrearTablas = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodedato = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nulos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.autoincremental = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CrearTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            this.Btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Crear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Btn_Crear.Location = new System.Drawing.Point(1061, 407);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(154, 31);
            this.Btn_Crear.TabIndex = 1;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = false;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // Tb_BaseDeDatos
            // 
            this.Tb_BaseDeDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.Tb_BaseDeDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Tb_BaseDeDatos.Location = new System.Drawing.Point(630, 414);
            this.Tb_BaseDeDatos.Name = "Tb_BaseDeDatos";
            this.Tb_BaseDeDatos.ReadOnly = true;
            this.Tb_BaseDeDatos.Size = new System.Drawing.Size(151, 22);
            this.Tb_BaseDeDatos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(529, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base de datos";
            // 
            // Tb_NombreDeTabla
            // 
            this.Tb_NombreDeTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.Tb_NombreDeTabla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Tb_NombreDeTabla.Location = new System.Drawing.Point(915, 414);
            this.Tb_NombreDeTabla.Name = "Tb_NombreDeTabla";
            this.Tb_NombreDeTabla.Size = new System.Drawing.Size(128, 22);
            this.Tb_NombreDeTabla.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(787, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de la tabla";
            // 
            // Dgv_CrearTablas
            // 
            this.Dgv_CrearTablas.AllowUserToResizeColumns = false;
            this.Dgv_CrearTablas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(92)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Dgv_CrearTablas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_CrearTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_CrearTablas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(95)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_CrearTablas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_CrearTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CrearTablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.tipodedato,
            this.nulos,
            this.pk,
            this.autoincremental});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_CrearTablas.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_CrearTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_CrearTablas.EnableHeadersVisualStyles = false;
            this.Dgv_CrearTablas.Location = new System.Drawing.Point(0, 0);
            this.Dgv_CrearTablas.Name = "Dgv_CrearTablas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_CrearTablas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_CrearTablas.RowHeadersVisible = false;
            this.Dgv_CrearTablas.RowHeadersWidth = 51;
            this.Dgv_CrearTablas.RowTemplate.Height = 24;
            this.Dgv_CrearTablas.Size = new System.Drawing.Size(1227, 450);
            this.Dgv_CrearTablas.TabIndex = 0;
            this.Dgv_CrearTablas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Dgv_CrearTablas_CellValidating);
            this.Dgv_CrearTablas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_CrearTablas_EditingControlShowing);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            // 
            // tipodedato
            // 
            this.tipodedato.AutoComplete = false;
            this.tipodedato.HeaderText = "TipoDeDato";
            this.tipodedato.Items.AddRange(new object[] {
            "bigint",
            "binary(50)",
            "bit",
            "char(10)",
            "date",
            "datetime",
            "datetime2(7)",
            "datetimeoffset(7)",
            "decimal(18,0)",
            "float",
            "geography",
            "geometry",
            "hierachyid",
            "image",
            "int",
            "money",
            "nchar(10)",
            "ntext",
            "numeric(18,0)",
            "nvarchar(50)",
            "nvarchar(MAX)",
            "real",
            "smalldatetime",
            "smallint",
            "smallmoney",
            "sql_variant",
            "text",
            "time(7)",
            "timestamp",
            "tinyint",
            "uniqueidentifiquer",
            "varbinary(50)",
            "varbinary(MAX)",
            "varchar(50)",
            "varchar(MAX)",
            "xml"});
            this.tipodedato.MinimumWidth = 6;
            this.tipodedato.Name = "tipodedato";
            this.tipodedato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nulos
            // 
            this.nulos.FalseValue = "not null";
            this.nulos.HeaderText = "Nulos";
            this.nulos.MinimumWidth = 6;
            this.nulos.Name = "nulos";
            this.nulos.TrueValue = "null";
            // 
            // pk
            // 
            this.pk.FalseValue = "false";
            this.pk.HeaderText = "PK";
            this.pk.MinimumWidth = 6;
            this.pk.Name = "pk";
            this.pk.TrueValue = "true";
            // 
            // autoincremental
            // 
            this.autoincremental.FalseValue = "false";
            this.autoincremental.HeaderText = "AutoIncremental";
            this.autoincremental.MinimumWidth = 6;
            this.autoincremental.Name = "autoincremental";
            this.autoincremental.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.autoincremental.TrueValue = "si";
            // 
            // FmAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_NombreDeTabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_BaseDeDatos);
            this.Controls.Add(this.Btn_Crear);
            this.Controls.Add(this.Dgv_CrearTablas);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FmAsistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmAsistente";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CrearTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.TextBox Tb_BaseDeDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_NombreDeTabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_CrearTablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipodedato;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nulos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pk;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoincremental;
    }
}