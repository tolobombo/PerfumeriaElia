namespace WindowsFormsApp10
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContra2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(9, 5);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(698, 349);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnAgregar.Location = new System.Drawing.Point(900, 360);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 27);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnEliminar.Location = new System.Drawing.Point(529, 360);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 27);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnModificar.Location = new System.Drawing.Point(621, 360);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 27);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(37, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "EMPLEADOS";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.btnMinimizar);
            this.topPanel.Controls.Add(this.btnSalir);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(989, 24);
            this.topPanel.TabIndex = 15;
            this.topPanel.Click += new System.EventHandler(this.topPanel_Click);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp10.Properties.Resources._1lotuslogo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnMinimizar.Location = new System.Drawing.Point(910, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(38, 24);
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.Text = "__";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnSalir.Location = new System.Drawing.Point(949, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 24);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btnLimpiar);
            this.MainPanel.Controls.Add(this.label10);
            this.MainPanel.Controls.Add(this.txtContra2);
            this.MainPanel.Controls.Add(this.label9);
            this.MainPanel.Controls.Add(this.txtContra);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.txtUsuario);
            this.MainPanel.Controls.Add(this.cmbTipo);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.txtCorreo);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.txtApellido2);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.txtApellido1);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.txtNombre);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.txtID);
            this.MainPanel.Controls.Add(this.btnRegresar);
            this.MainPanel.Controls.Add(this.dgvEmpleados);
            this.MainPanel.Controls.Add(this.btnAgregar);
            this.MainPanel.Controls.Add(this.btnModificar);
            this.MainPanel.Controls.Add(this.btnEliminar);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(989, 394);
            this.MainPanel.TabIndex = 16;
            this.MainPanel.Click += new System.EventHandler(this.MainPanel_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnLimpiar.Location = new System.Drawing.Point(808, 360);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 27);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label10.Location = new System.Drawing.Point(713, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 14);
            this.label10.TabIndex = 24;
            this.label10.Text = "Confirmar Contraseña:";
            // 
            // txtContra2
            // 
            this.txtContra2.Location = new System.Drawing.Point(716, 281);
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.PasswordChar = '*';
            this.txtContra2.Size = new System.Drawing.Size(189, 20);
            this.txtContra2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label9.Location = new System.Drawing.Point(713, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 14);
            this.label9.TabIndex = 22;
            this.label9.Text = "Contraseña:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(716, 232);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(189, 20);
            this.txtContra.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label8.Location = new System.Drawing.Point(713, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(716, 183);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 20);
            this.txtUsuario.TabIndex = 17;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.cmbTipo.Location = new System.Drawing.Point(716, 327);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label7.Location = new System.Drawing.Point(713, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo de Usuario:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(716, 132);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(261, 20);
            this.txtCorreo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label6.Location = new System.Drawing.Point(847, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Segundo Apellido:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(850, 76);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(127, 20);
            this.txtApellido2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(713, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Correo Electronico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(713, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Primer Apellido:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(716, 76);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(128, 20);
            this.txtApellido1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(771, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre(s):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(774, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(713, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(716, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(49, 20);
            this.txtID.TabIndex = 6;
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnRegresar.Location = new System.Drawing.Point(12, 360);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(80, 27);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(989, 418);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Empleados";
            this.Shown += new System.EventHandler(this.Empleados_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContra2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnLimpiar;
    }
}