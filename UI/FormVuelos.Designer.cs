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
            ((System.ComponentModel.ISupportInitialize)dgvVuelos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Lista de vuelos:";
            // 
            // dgvVuelos
            // 
            dgvVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVuelos.Location = new Point(12, 40);
            dgvVuelos.Name = "dgvVuelos";
            dgvVuelos.RowHeadersWidth = 51;
            dgvVuelos.Size = new Size(1448, 340);
            dgvVuelos.TabIndex = 1;
            // 
            // btnNuevoVuelo
            // 
            btnNuevoVuelo.Location = new Point(12, 409);
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
            // FormVuelos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 450);
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
    }
}