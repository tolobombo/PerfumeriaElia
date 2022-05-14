namespace WindowsFormsApp10
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboProductos = new System.Windows.Forms.ComboBox();
            this.comboOtro = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.picChanel = new System.Windows.Forms.PictureBox();
            this.picPaco = new System.Windows.Forms.PictureBox();
            this.picCk = new System.Windows.Forms.PictureBox();
            this.picBoss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProductos.Location = new System.Drawing.Point(13, 206);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(517, 271);
            this.dgvProductos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripción";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Importe";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // comboProductos
            // 
            this.comboProductos.FormattingEnabled = true;
            this.comboProductos.Location = new System.Drawing.Point(14, 175);
            this.comboProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboProductos.Name = "comboProductos";
            this.comboProductos.Size = new System.Drawing.Size(300, 23);
            this.comboProductos.TabIndex = 5;
            this.comboProductos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboOtro
            // 
            this.comboOtro.FormattingEnabled = true;
            this.comboOtro.Location = new System.Drawing.Point(730, 69);
            this.comboOtro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboOtro.Name = "comboOtro";
            this.comboOtro.Size = new System.Drawing.Size(140, 23);
            this.comboOtro.TabIndex = 6;
            this.comboOtro.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(746, 178);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(116, 20);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(746, 242);
            this.txtPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(116, 20);
            this.txtPago.TabIndex = 8;
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(746, 369);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(116, 20);
            this.txtCambio.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(286, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marcas TOP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(780, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Otros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(116, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(780, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(777, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Su pago";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnPagar.Location = new System.Drawing.Point(758, 292);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(88, 27);
            this.btnPagar.TabIndex = 15;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label6.Location = new System.Drawing.Point(774, 341);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Su Cambio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(371, 175);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(135, 20);
            this.txtCantidad.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label7.Location = new System.Drawing.Point(407, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnAgregar.Location = new System.Drawing.Point(538, 163);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 45);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar Cantidad y Producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnEliminar.Location = new System.Drawing.Point(557, 239);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 27);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar Cantidad";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button4_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topPanel.Controls.Add(this.pictureBox5);
            this.topPanel.Controls.Add(this.label8);
            this.topPanel.Controls.Add(this.btnMinimizar);
            this.topPanel.Controls.Add(this.btnSalir);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(903, 30);
            this.topPanel.TabIndex = 23;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp10.Properties.Resources._1lotuslogo;
            this.pictureBox5.Location = new System.Drawing.Point(12, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.label8.Location = new System.Drawing.Point(49, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "VENTAS";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnMinimizar.Location = new System.Drawing.Point(794, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 30);
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
            this.btnSalir.Location = new System.Drawing.Point(847, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 30);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.btnRegresar);
            this.mainPanel.Controls.Add(this.picChanel);
            this.mainPanel.Controls.Add(this.picPaco);
            this.mainPanel.Controls.Add(this.picCk);
            this.mainPanel.Controls.Add(this.dgvProductos);
            this.mainPanel.Controls.Add(this.btnEliminar);
            this.mainPanel.Controls.Add(this.picBoss);
            this.mainPanel.Controls.Add(this.btnAgregar);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.txtCantidad);
            this.mainPanel.Controls.Add(this.comboOtro);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.comboProductos);
            this.mainPanel.Controls.Add(this.btnPagar);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.txtTotal);
            this.mainPanel.Controls.Add(this.txtPago);
            this.mainPanel.Controls.Add(this.txtCambio);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 30);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(903, 489);
            this.mainPanel.TabIndex = 24;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnRegresar.Location = new System.Drawing.Point(806, 440);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(85, 37);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // picChanel
            // 
            this.picChanel.Image = global::WindowsFormsApp10.Properties.Resources.LogoChanel;
            this.picChanel.Location = new System.Drawing.Point(41, 41);
            this.picChanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picChanel.Name = "picChanel";
            this.picChanel.Size = new System.Drawing.Size(107, 103);
            this.picChanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChanel.TabIndex = 1;
            this.picChanel.TabStop = false;
            this.picChanel.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picPaco
            // 
            this.picPaco.Image = global::WindowsFormsApp10.Properties.Resources.LogoPaco;
            this.picPaco.Location = new System.Drawing.Point(190, 41);
            this.picPaco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picPaco.Name = "picPaco";
            this.picPaco.Size = new System.Drawing.Size(107, 103);
            this.picPaco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaco.TabIndex = 2;
            this.picPaco.TabStop = false;
            this.picPaco.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picCk
            // 
            this.picCk.Image = global::WindowsFormsApp10.Properties.Resources.LogoCk;
            this.picCk.Location = new System.Drawing.Point(349, 41);
            this.picCk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picCk.Name = "picCk";
            this.picCk.Size = new System.Drawing.Size(107, 103);
            this.picCk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCk.TabIndex = 3;
            this.picCk.TabStop = false;
            this.picCk.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picBoss
            // 
            this.picBoss.Image = global::WindowsFormsApp10.Properties.Resources.LogoBoss;
            this.picBoss.Location = new System.Drawing.Point(498, 41);
            this.picBoss.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picBoss.Name = "picBoss";
            this.picBoss.Size = new System.Drawing.Size(107, 103);
            this.picBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoss.TabIndex = 4;
            this.picBoss.TabStop = false;
            this.picBoss.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(903, 519);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(167)))), ((int)(((byte)(91)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Venta";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox picChanel;
        private System.Windows.Forms.PictureBox picPaco;
        private System.Windows.Forms.PictureBox picCk;
        private System.Windows.Forms.PictureBox picBoss;
        private System.Windows.Forms.ComboBox comboProductos;
        private System.Windows.Forms.ComboBox comboOtro;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnRegresar;
    }
}