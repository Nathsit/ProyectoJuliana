namespace ProyectoJuliana
{
    partial class frmBusqueda
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
            pictureBox2 = new PictureBox();
            TextNombreLibro = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            TextNombreAutor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TextAño = new TextBox();
            checkBoxAutor = new CheckBox();
            checkBoxNombre = new CheckBox();
            txtBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            NombreLibro = new DataGridViewTextBoxColumn();
            NombreAutor = new DataGridViewTextBoxColumn();
            Año = new DataGridViewTextBoxColumn();
            Ubicacion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            TextCantidad = new TextBox();
            label6 = new Label();
            TextUbicacion = new TextBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cerrar_sesion;
            pictureBox2.Location = new Point(930, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(131, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // TextNombreLibro
            // 
            TextNombreLibro.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNombreLibro.Location = new Point(11, 160);
            TextNombreLibro.Name = "TextNombreLibro";
            TextNombreLibro.Size = new Size(272, 38);
            TextNombreLibro.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(214, 61, 92);
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 125);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 2;
            label1.Text = "Nombre del Libro";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 65, 69);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(301, 715);
            panel4.Name = "panel4";
            panel4.Size = new Size(1128, 125);
            panel4.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(628, 22);
            label5.Name = "label5";
            label5.Size = new Size(496, 55);
            label5.TabIndex = 20;
            label5.Text = "BUSQUEDA DE LIBROS";
            // 
            // TextNombreAutor
            // 
            TextNombreAutor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNombreAutor.Location = new Point(11, 295);
            TextNombreAutor.Name = "TextNombreAutor";
            TextNombreAutor.Size = new Size(272, 38);
            TextNombreAutor.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(214, 61, 92);
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 260);
            label3.Name = "label3";
            label3.Size = new Size(217, 32);
            label3.TabIndex = 6;
            label3.Text = "Nombre del Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(214, 61, 92);
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 388);
            label2.Name = "label2";
            label2.Size = new Size(182, 32);
            label2.TabIndex = 22;
            label2.Text = "Año Publicacion";
            // 
            // TextAño
            // 
            TextAño.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextAño.Location = new Point(11, 423);
            TextAño.Name = "TextAño";
            TextAño.Size = new Size(272, 38);
            TextAño.TabIndex = 23;
            // 
            // checkBoxAutor
            // 
            checkBoxAutor.AutoSize = true;
            checkBoxAutor.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAutor.Location = new Point(703, 125);
            checkBoxAutor.Name = "checkBoxAutor";
            checkBoxAutor.Size = new Size(161, 35);
            checkBoxAutor.TabIndex = 24;
            checkBoxAutor.Text = "Autor Libro";
            checkBoxAutor.UseVisualStyleBackColor = true;
            // 
            // checkBoxNombre
            // 
            checkBoxNombre.AutoSize = true;
            checkBoxNombre.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxNombre.Location = new Point(870, 125);
            checkBoxNombre.Name = "checkBoxNombre";
            checkBoxNombre.Size = new Size(185, 35);
            checkBoxNombre.TabIndex = 25;
            checkBoxNombre.Text = "Nombre Libro";
            checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(628, 161);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(486, 40);
            txtBuscar.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreLibro, NombreAutor, Año, Ubicacion, Cantidad });
            dataGridView1.Location = new Point(403, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(937, 438);
            dataGridView1.TabIndex = 27;
            // 
            // NombreLibro
            // 
            NombreLibro.HeaderText = "Nombre del Libro";
            NombreLibro.MinimumWidth = 6;
            NombreLibro.Name = "NombreLibro";
            NombreLibro.ReadOnly = true;
            NombreLibro.Width = 125;
            // 
            // NombreAutor
            // 
            NombreAutor.HeaderText = "Nombre Del Autor";
            NombreAutor.MinimumWidth = 6;
            NombreAutor.Name = "NombreAutor";
            NombreAutor.ReadOnly = true;
            NombreAutor.Width = 125;
            // 
            // Año
            // 
            Año.HeaderText = "Año de Publicacion";
            Año.MinimumWidth = 6;
            Año.Name = "Año";
            Año.ReadOnly = true;
            Año.Width = 125;
            // 
            // Ubicacion
            // 
            Ubicacion.HeaderText = "Ubicacion";
            Ubicacion.MinimumWidth = 6;
            Ubicacion.Name = "Ubicacion";
            Ubicacion.ReadOnly = true;
            Ubicacion.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(214, 61, 92);
            panel1.Controls.Add(TextCantidad);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TextUbicacion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextNombreLibro);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TextNombreAutor);
            panel1.Controls.Add(TextAño);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 840);
            panel1.TabIndex = 18;
            // 
            // TextCantidad
            // 
            TextCantidad.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextCantidad.Location = new Point(11, 677);
            TextCantidad.Name = "TextCantidad";
            TextCantidad.Size = new Size(272, 38);
            TextCantidad.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(214, 61, 92);
            label6.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(92, 642);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 26;
            label6.Text = "Cantidad";
            // 
            // TextUbicacion
            // 
            TextUbicacion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextUbicacion.Location = new Point(11, 552);
            TextUbicacion.Name = "TextUbicacion";
            TextUbicacion.Size = new Size(272, 38);
            TextUbicacion.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(214, 61, 92);
            label4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(92, 517);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 24;
            label4.Text = "Ubicacion";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1137, 161);
            button1.Name = "button1";
            button1.Size = new Size(111, 38);
            button1.TabIndex = 28;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmBusqueda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1429, 840);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(checkBoxNombre);
            Controls.Add(checkBoxAutor);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBusqueda";
            Text = "frmBusqueda";
            Load += frmBusqueda_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TextNombreLibro;
        private Label label1;
        private Panel panel4;
        private Label label5;
        private TextBox TextNombreAutor;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private TextBox TextAño;
        private CheckBox checkBoxAutor;
        private CheckBox checkBoxNombre;
        private TextBox txtBuscar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NombreLibro;
        private DataGridViewTextBoxColumn NombreAutor;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewTextBoxColumn Ubicacion;
        private DataGridViewTextBoxColumn Cantidad;
        private Panel panel1;
        private TextBox TextCantidad;
        private Label label6;
        private TextBox TextUbicacion;
        private Label label4;
        private Button button1;
    }
}