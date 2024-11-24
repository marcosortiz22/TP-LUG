namespace UI
{
    partial class FormVuelos
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
            label1 = new Label();
            dgvVuelos = new DataGridView();
            btnNuevoVuelo = new Button();
            btnModificar = new Button();
            btn_FormClientes = new Button();
            btn_FormInstructores = new Button();
            btn_FormAeronaves = new Button();
            btn_FormPagos = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVuelos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Lista de vuelos:";
            // 
            // dgvVuelos
            // 
            dgvVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVuelos.Location = new Point(11, 40);
            dgvVuelos.Name = "dgvVuelos";
            dgvVuelos.RowHeadersWidth = 51;
            dgvVuelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVuelos.Size = new Size(1448, 340);
            dgvVuelos.TabIndex = 1;
            // 
            // btnNuevoVuelo
            // 
            btnNuevoVuelo.Location = new Point(11, 409);
            btnNuevoVuelo.Name = "btnNuevoVuelo";
            btnNuevoVuelo.Size = new Size(169, 29);
            btnNuevoVuelo.TabIndex = 2;
            btnNuevoVuelo.Text = "Nuevo Vuelo";
            btnNuevoVuelo.UseVisualStyleBackColor = true;
            btnNuevoVuelo.Click += btnNuevoVuelo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(250, 409);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(169, 29);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar Vuelo";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btn_FormClientes
            // 
            btn_FormClientes.Location = new Point(14, 501);
            btn_FormClientes.Margin = new Padding(3, 4, 3, 4);
            btn_FormClientes.Name = "btn_FormClientes";
            btn_FormClientes.Size = new Size(133, 47);
            btn_FormClientes.TabIndex = 4;
            btn_FormClientes.Text = "Gestion Clientes";
            btn_FormClientes.UseVisualStyleBackColor = true;
            btn_FormClientes.Click += btn_FormClientes_Click;
            // 
            // btn_FormInstructores
            // 
            btn_FormInstructores.Location = new Point(217, 500);
            btn_FormInstructores.Margin = new Padding(3, 4, 3, 4);
            btn_FormInstructores.Name = "btn_FormInstructores";
            btn_FormInstructores.Size = new Size(139, 48);
            btn_FormInstructores.TabIndex = 5;
            btn_FormInstructores.Text = "Gestion Instructores";
            btn_FormInstructores.UseVisualStyleBackColor = true;
            btn_FormInstructores.Click += btn_FormInstructores_Click;
            // 
            // btn_FormAeronaves
            // 
            btn_FormAeronaves.Location = new Point(426, 501);
            btn_FormAeronaves.Margin = new Padding(3, 4, 3, 4);
            btn_FormAeronaves.Name = "btn_FormAeronaves";
            btn_FormAeronaves.Size = new Size(141, 47);
            btn_FormAeronaves.TabIndex = 6;
            btn_FormAeronaves.Text = "Gestion Aeronaves";
            btn_FormAeronaves.UseVisualStyleBackColor = true;
            btn_FormAeronaves.Click += btn_FormAeronaves_Click;
            // 
            // btn_FormPagos
            // 
            btn_FormPagos.Location = new Point(645, 501);
            btn_FormPagos.Margin = new Padding(3, 4, 3, 4);
            btn_FormPagos.Name = "btn_FormPagos";
            btn_FormPagos.Size = new Size(154, 47);
            btn_FormPagos.TabIndex = 7;
            btn_FormPagos.Text = "Gestion Pagos";
            btn_FormPagos.UseVisualStyleBackColor = true;
            btn_FormPagos.Click += btn_FormPagos_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(491, 409);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 29);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar Vuelo";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormVuelos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 581);
            Controls.Add(btnEliminar);
            Controls.Add(btn_FormPagos);
            Controls.Add(btn_FormAeronaves);
            Controls.Add(btn_FormInstructores);
            Controls.Add(btn_FormClientes);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevoVuelo);
            Controls.Add(dgvVuelos);
            Controls.Add(label1);
            Name = "FormVuelos";
            Text = "Formulario de vuelos";
            Load += FormVuelos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVuelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvVuelos;
        private Button btnNuevoVuelo;
        private Button btnModificar;
        private Button btn_FormClientes;
        private Button btn_FormInstructores;
        private Button btn_FormAeronaves;
        private Button btn_FormPagos;
        private Button btnEliminar;
    }
}