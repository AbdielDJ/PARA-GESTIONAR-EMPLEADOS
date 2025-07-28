namespace PROYECTO_FINAL
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportarCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEmpleadoID = new System.Windows.Forms.TextBox();
            this.txtEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.txtEmpleadoDepartamento = new System.Windows.Forms.TextBox();
            this.txtEmpleadoCargo = new System.Windows.Forms.TextBox();
            this.txtEmpleadoSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_DE_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEMPO_EN_LA_EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.Dtpempleados = new System.Windows.Forms.DateTimePicker();
            this.CboxEmpleadosEstado = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menustrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarEmpleadosToolStripMenuItem,
            this.btnAgregarEmpleado,
            this.btnActualizarEmpleado,
            this.btnEliminarEmpleado,
            this.btnExportarCSV,
            this.btnSalir});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mostrarEmpleadosToolStripMenuItem
            // 
            this.mostrarEmpleadosToolStripMenuItem.Name = "mostrarEmpleadosToolStripMenuItem";
            this.mostrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mostrarEmpleadosToolStripMenuItem.Text = "Mostrar empleados";
            this.mostrarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarEmpleadosToolStripMenuItem_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(182, 22);
            this.btnAgregarEmpleado.Text = "Agregar empleado";
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(182, 22);
            this.btnActualizarEmpleado.Text = "Actualizar empleado";
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(182, 22);
            this.btnEliminarEmpleado.Text = "Eliminar empleado";
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(182, 22);
            this.btnExportarCSV.Text = "Exportar a CSV";
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(182, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtEmpleadoID
            // 
            this.txtEmpleadoID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmpleadoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoID.Location = new System.Drawing.Point(94, 97);
            this.txtEmpleadoID.Multiline = true;
            this.txtEmpleadoID.Name = "txtEmpleadoID";
            this.txtEmpleadoID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtEmpleadoID.Size = new System.Drawing.Size(124, 39);
            this.txtEmpleadoID.TabIndex = 1;
            this.txtEmpleadoID.TextChanged += new System.EventHandler(this.txtEmpleadoID_TextChanged);
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmpleadoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(94, 158);
            this.txtEmpleadoNombre.Multiline = true;
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(124, 36);
            this.txtEmpleadoNombre.TabIndex = 2;
            this.txtEmpleadoNombre.TextChanged += new System.EventHandler(this.txtEmpleadoNombre_TextChanged);
            // 
            // txtEmpleadoDepartamento
            // 
            this.txtEmpleadoDepartamento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmpleadoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoDepartamento.Location = new System.Drawing.Point(94, 219);
            this.txtEmpleadoDepartamento.Multiline = true;
            this.txtEmpleadoDepartamento.Name = "txtEmpleadoDepartamento";
            this.txtEmpleadoDepartamento.Size = new System.Drawing.Size(124, 35);
            this.txtEmpleadoDepartamento.TabIndex = 3;
            // 
            // txtEmpleadoCargo
            // 
            this.txtEmpleadoCargo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmpleadoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoCargo.Location = new System.Drawing.Point(94, 269);
            this.txtEmpleadoCargo.Multiline = true;
            this.txtEmpleadoCargo.Name = "txtEmpleadoCargo";
            this.txtEmpleadoCargo.Size = new System.Drawing.Size(124, 36);
            this.txtEmpleadoCargo.TabIndex = 4;
            // 
            // txtEmpleadoSalario
            // 
            this.txtEmpleadoSalario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmpleadoSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoSalario.Location = new System.Drawing.Point(498, 97);
            this.txtEmpleadoSalario.Multiline = true;
            this.txtEmpleadoSalario.Name = "txtEmpleadoSalario";
            this.txtEmpleadoSalario.Size = new System.Drawing.Size(121, 39);
            this.txtEmpleadoSalario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Depto.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(423, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(423, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Salario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(423, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado";
            // 
            // dgvEmpleados
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.DEPARTAMENTO,
            this.CARGO,
            this.FECHA_DE_INICIO,
            this.SALARIO,
            this.ESTADO,
            this.TIEMPO_EN_LA_EMPRESA});
            this.dgvEmpleados.Location = new System.Drawing.Point(62, 335);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(1049, 440);
            this.dgvEmpleados.TabIndex = 15;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.DEPARTAMENTO.Name = "DEPARTAMENTO";
            // 
            // CARGO
            // 
            this.CARGO.HeaderText = "CARGO";
            this.CARGO.Name = "CARGO";
            // 
            // FECHA_DE_INICIO
            // 
            this.FECHA_DE_INICIO.HeaderText = "FECHA DE INICIO";
            this.FECHA_DE_INICIO.Name = "FECHA_DE_INICIO";
            // 
            // SALARIO
            // 
            this.SALARIO.HeaderText = "SALARIO";
            this.SALARIO.Name = "SALARIO";
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // TIEMPO_EN_LA_EMPRESA
            // 
            this.TIEMPO_EN_LA_EMPRESA.HeaderText = "TIEMPO EN LA EMPRESA";
            this.TIEMPO_EN_LA_EMPRESA.Name = "TIEMPO_EN_LA_EMPRESA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(77, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(395, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "GESTION DE EMPLEADOS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Dtpempleados
            // 
            this.Dtpempleados.Location = new System.Drawing.Point(498, 148);
            this.Dtpempleados.Name = "Dtpempleados";
            this.Dtpempleados.Size = new System.Drawing.Size(187, 20);
            this.Dtpempleados.TabIndex = 17;
            // 
            // CboxEmpleadosEstado
            // 
            this.CboxEmpleadosEstado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CboxEmpleadosEstado.FormattingEnabled = true;
            this.CboxEmpleadosEstado.Items.AddRange(new object[] {
            "Vigente",
            "No Vigente"});
            this.CboxEmpleadosEstado.Location = new System.Drawing.Point(498, 202);
            this.CboxEmpleadosEstado.Name = "CboxEmpleadosEstado";
            this.CboxEmpleadosEstado.Size = new System.Drawing.Size(121, 21);
            this.CboxEmpleadosEstado.TabIndex = 18;
            this.CboxEmpleadosEstado.SelectedIndexChanged += new System.EventHandler(this.CboxEmpleadosEstado_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 819);
            this.Controls.Add(this.CboxEmpleadosEstado);
            this.Controls.Add(this.Dtpempleados);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpleadoSalario);
            this.Controls.Add(this.txtEmpleadoCargo);
            this.Controls.Add(this.txtEmpleadoDepartamento);
            this.Controls.Add(this.txtEmpleadoNombre);
            this.Controls.Add(this.txtEmpleadoID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnActualizarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem btnExportarCSV;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.TextBox txtEmpleadoID;
        private System.Windows.Forms.TextBox txtEmpleadoNombre;
        private System.Windows.Forms.TextBox txtEmpleadoDepartamento;
        private System.Windows.Forms.TextBox txtEmpleadoCargo;
        private System.Windows.Forms.TextBox txtEmpleadoSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_DE_INICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEMPO_EN_LA_EMPRESA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Dtpempleados;
        private System.Windows.Forms.ComboBox CboxEmpleadosEstado;
    }
}