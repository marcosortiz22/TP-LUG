namespace UI
{
    partial class FormAeronaves
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
            dgv_Aeronaves = new DataGridView();
            btn_ModificarAeronave = new Button();
            btn_EliminarAeronave = new Button();
            cmBox_AeronavesDisp = new ComboBox();
            dgv_AeronavesTaller = new DataGridView();
            btn_AltaAeronave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_RealizarService = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Aeronaves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_AeronavesTaller).BeginInit();
            SuspendLayout();
            // 
            // dgv_Aeronaves
            // 
            dgv_Aeronaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Aeronaves.Location = new Point(45, 31);
            dgv_Aeronaves.MultiSelect = false;
            dgv_Aeronaves.Name = "dgv_Aeronaves";
            dgv_Aeronaves.ReadOnly = true;
            dgv_Aeronaves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Aeronaves.Size = new Size(963, 190);
            dgv_Aeronaves.TabIndex = 0;
            // 
            // btn_ModificarAeronave
            // 
            btn_ModificarAeronave.Location = new Point(180, 230);
            btn_ModificarAeronave.Name = "btn_ModificarAeronave";
            btn_ModificarAeronave.Size = new Size(115, 29);
            btn_ModificarAeronave.TabIndex = 1;
            btn_ModificarAeronave.Text = "Modificar";
            btn_ModificarAeronave.UseVisualStyleBackColor = true;
            btn_ModificarAeronave.Click += btn_ModificarAeronave_Click;
            // 
            // btn_EliminarAeronave
            // 
            btn_EliminarAeronave.Location = new Point(880, 230);
            btn_EliminarAeronave.Name = "btn_EliminarAeronave";
            btn_EliminarAeronave.Size = new Size(128, 29);
            btn_EliminarAeronave.TabIndex = 2;
            btn_EliminarAeronave.Text = "Eliminar";
            btn_EliminarAeronave.UseVisualStyleBackColor = true;
            btn_EliminarAeronave.Click += btn_EliminarAeronave_Click;
            // 
            // cmBox_AeronavesDisp
            // 
            cmBox_AeronavesDisp.FormattingEnabled = true;
            cmBox_AeronavesDisp.Location = new Point(822, 380);
            cmBox_AeronavesDisp.Name = "cmBox_AeronavesDisp";
            cmBox_AeronavesDisp.Size = new Size(186, 23);
            cmBox_AeronavesDisp.TabIndex = 3;
            // 
            // dgv_AeronavesTaller
            // 
            dgv_AeronavesTaller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AeronavesTaller.Location = new Point(45, 326);
            dgv_AeronavesTaller.Name = "dgv_AeronavesTaller";
            dgv_AeronavesTaller.Size = new Size(464, 183);
            dgv_AeronavesTaller.TabIndex = 4;
            // 
            // btn_AltaAeronave
            // 
            btn_AltaAeronave.Location = new Point(45, 230);
            btn_AltaAeronave.Name = "btn_AltaAeronave";
            btn_AltaAeronave.Size = new Size(115, 29);
            btn_AltaAeronave.TabIndex = 5;
            btn_AltaAeronave.Text = "Alta ";
            btn_AltaAeronave.UseVisualStyleBackColor = true;
            btn_AltaAeronave.Click += btn_AltaAeronave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 13);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 6;
            label1.Text = "Aeronaves Disponibles  y no disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 308);
            label2.Name = "label2";
            label2.Size = new Size(178, 15);
            label2.TabIndex = 7;
            label2.Text = "Aeronaves que requieren Service";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(822, 351);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 8;
            label3.Text = "Modelo de combo box para vuelo";
            // 
            // btn_RealizarService
            // 
            btn_RealizarService.Location = new Point(55, 518);
            btn_RealizarService.Name = "btn_RealizarService";
            btn_RealizarService.Size = new Size(114, 23);
            btn_RealizarService.TabIndex = 9;
            btn_RealizarService.Text = "Realizar Service";
            btn_RealizarService.UseVisualStyleBackColor = true;
            btn_RealizarService.Click += btn_RealizarService_Click;
            // 
            // FormAeronaves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 553);
            Controls.Add(btn_RealizarService);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_AltaAeronave);
            Controls.Add(dgv_AeronavesTaller);
            Controls.Add(cmBox_AeronavesDisp);
            Controls.Add(btn_EliminarAeronave);
            Controls.Add(btn_ModificarAeronave);
            Controls.Add(dgv_Aeronaves);
            Name = "FormAeronaves";
            Text = "FormAeronaves";
            Load += FormAeronaves_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Aeronaves).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_AeronavesTaller).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Aeronaves;
        private Button btn_ModificarAeronave;
        private Button btn_EliminarAeronave;
        private ComboBox cmBox_AeronavesDisp;
        private DataGridView dgv_AeronavesTaller;
        private Button btn_AltaAeronave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_RealizarService;
    }
}