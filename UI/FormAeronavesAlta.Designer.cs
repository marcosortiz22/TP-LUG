namespace UI
{
    partial class FormAeronavesAlta
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
            dateTimePickerRevisionAnual = new DateTimePicker();
            txt_Matricula = new TextBox();
            txt_Marca = new TextBox();
            label2 = new Label();
            txt_Modelo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dgv_ListaBorrador = new DataGridView();
            txt_Revision100Hs = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btn_ConfirmarBorrador = new Button();
            btn_Alta = new Button();
            btn_AltaBorrador = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ListaBorrador).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 75);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Matricula";
            // 
            // dateTimePickerRevisionAnual
            // 
            dateTimePickerRevisionAnual.Format = DateTimePickerFormat.Short;
            dateTimePickerRevisionAnual.Location = new Point(112, 244);
            dateTimePickerRevisionAnual.Name = "dateTimePickerRevisionAnual";
            dateTimePickerRevisionAnual.Size = new Size(118, 23);
            dateTimePickerRevisionAnual.TabIndex = 1;
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(112, 75);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(118, 23);
            txt_Matricula.TabIndex = 2;
            // 
            // txt_Marca
            // 
            txt_Marca.Location = new Point(112, 115);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(118, 23);
            txt_Marca.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 118);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Marca";
            // 
            // txt_Modelo
            // 
            txt_Modelo.Location = new Point(112, 157);
            txt_Modelo.Name = "txt_Modelo";
            txt_Modelo.Size = new Size(118, 23);
            txt_Modelo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 160);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 244);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 7;
            label4.Text = "Revision Anual";
            // 
            // dgv_ListaBorrador
            // 
            dgv_ListaBorrador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListaBorrador.Location = new Point(325, 75);
            dgv_ListaBorrador.Name = "dgv_ListaBorrador";
            dgv_ListaBorrador.Size = new Size(636, 166);
            dgv_ListaBorrador.TabIndex = 8;
            // 
            // txt_Revision100Hs
            // 
            txt_Revision100Hs.Location = new Point(112, 197);
            txt_Revision100Hs.Name = "txt_Revision100Hs";
            txt_Revision100Hs.Size = new Size(118, 23);
            txt_Revision100Hs.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 200);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 9;
            label5.Text = "Revision de 100Hs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 47);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 11;
            label6.Text = "Lista Borrador para Altas";
            // 
            // btn_ConfirmarBorrador
            // 
            btn_ConfirmarBorrador.Location = new Point(808, 289);
            btn_ConfirmarBorrador.Name = "btn_ConfirmarBorrador";
            btn_ConfirmarBorrador.Size = new Size(153, 33);
            btn_ConfirmarBorrador.TabIndex = 12;
            btn_ConfirmarBorrador.Text = "Confirmar Lista Borrador";
            btn_ConfirmarBorrador.UseVisualStyleBackColor = true;
            btn_ConfirmarBorrador.Click += btn_ConfirmarBorrador_Click;
            // 
            // btn_Alta
            // 
            btn_Alta.Location = new Point(12, 289);
            btn_Alta.Name = "btn_Alta";
            btn_Alta.Size = new Size(125, 33);
            btn_Alta.TabIndex = 13;
            btn_Alta.Text = "Dar Alta";
            btn_Alta.UseVisualStyleBackColor = true;
            btn_Alta.Click += btn_Alta_Click;
            // 
            // btn_AltaBorrador
            // 
            btn_AltaBorrador.Location = new Point(157, 289);
            btn_AltaBorrador.Name = "btn_AltaBorrador";
            btn_AltaBorrador.Size = new Size(125, 33);
            btn_AltaBorrador.TabIndex = 14;
            btn_AltaBorrador.Text = "Alta Lista Borrador";
            btn_AltaBorrador.UseVisualStyleBackColor = true;
            btn_AltaBorrador.Click += btn_AltaBorrador_Click;
            // 
            // FormAeronaveAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 410);
            Controls.Add(btn_AltaBorrador);
            Controls.Add(btn_Alta);
            Controls.Add(btn_ConfirmarBorrador);
            Controls.Add(label6);
            Controls.Add(txt_Revision100Hs);
            Controls.Add(label5);
            Controls.Add(dgv_ListaBorrador);
            Controls.Add(label4);
            Controls.Add(txt_Modelo);
            Controls.Add(label3);
            Controls.Add(txt_Marca);
            Controls.Add(label2);
            Controls.Add(txt_Matricula);
            Controls.Add(dateTimePickerRevisionAnual);
            Controls.Add(label1);
            Name = "FormAeronaveAlta";
            Text = "FormAeronaveAlta";
            Load += FormAeronaveAlta_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ListaBorrador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePickerRevisionAnual;
        private TextBox txt_Matricula;
        private TextBox txt_Marca;
        private Label label2;
        private TextBox txt_Modelo;
        private Label label3;
        private Label label4;
        private DataGridView dgv_ListaBorrador;
        private TextBox txt_Revision100Hs;
        private Label label5;
        private Label label6;
        private Button btn_ConfirmarBorrador;
        private Button btn_Alta;
        private Button btn_AltaBorrador;
    }
}