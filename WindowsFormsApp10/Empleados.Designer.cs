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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Correo,
            this.TipoUsuario});
            this.dataGridView1.Location = new System.Drawing.Point(9, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(462, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnAgregar.Location = new System.Drawing.Point(652, 182);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 27);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.button2.Location = new System.Drawing.Point(201, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Baja";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.button3.Location = new System.Drawing.Point(293, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Consulta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.button4.Location = new System.Drawing.Point(385, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
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
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(750, 24);
            this.topPanel.TabIndex = 15;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp10.Properties.Resources._1lotuslogo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnMinimizar.Location = new System.Drawing.Point(673, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnSalir.Location = new System.Drawing.Point(712, 2);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 24);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 293);
            this.panel1.TabIndex = 16;
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnRegresar.Location = new System.Drawing.Point(12, 254);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(80, 27);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(480, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(49, 20);
            this.txtID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(477, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(538, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(535, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre(s):";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(480, 75);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(128, 20);
            this.txtApellido1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(477, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Primer Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(477, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Correo Electronico:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(614, 75);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(127, 20);
            this.txtApellido2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label6.Location = new System.Drawing.Point(611, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Segundo Apellido:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(480, 131);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(261, 20);
            this.txtCorreo.TabIndex = 16;
            // 
            // ID
            // 
            this.ID.FillWeight = 30F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.FillWeight = 60F;
            this.TipoUsuario.HeaderText = "TipoUsuario";
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label7.Location = new System.Drawing.Point(477, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo de Usuario:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "SELECCIONAR",
            "Usuario",
            "Administrador"});
            this.cmbTipo.Location = new System.Drawing.Point(480, 188);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 18;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(750, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Empleados";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label7;
    }
}