namespace UI
{
    partial class FormModificarAeronave
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
            btn_Modificar = new Button();
            txt_Revision100Hs = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_Modelo = new TextBox();
            label3 = new Label();
            txt_Marca = new TextBox();
            label2 = new Label();
            txt_Matricula = new TextBox();
            dateTimePickerRevisionAnual = new DateTimePicker();
            label1 = new Label();
            checkBoxActivo = new CheckBox();
            SuspendLayout();
            // 
            // btn_Modificar
            // 
            btn_Modificar.Location = new Point(191, 295);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(125, 33);
            btn_Modificar.TabIndex = 24;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // txt_Revision100Hs
            // 
            txt_Revision100Hs.Location = new Point(191, 174);
            txt_Revision100Hs.Name = "txt_Revision100Hs";
            txt_Revision100Hs.Size = new Size(118, 23);
            txt_Revision100Hs.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 177);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 22;
            label5.Text = "Revision de 100Hs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 221);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 21;
            label4.Text = "Revision Anual";
            // 
            // txt_Modelo
            // 
            txt_Modelo.Location = new Point(191, 134);
            txt_Modelo.Name = "txt_Modelo";
            txt_Modelo.Size = new Size(118, 23);
            txt_Modelo.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 137);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 19;
            label3.Text = "Modelo";
            // 
            // txt_Marca
            // 
            txt_Marca.Location = new Point(191, 92);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(118, 23);
            txt_Marca.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 95);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 17;
            label2.Text = "Marca";
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(191, 52);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(118, 23);
            txt_Matricula.TabIndex = 16;
            // 
            // dateTimePickerRevisionAnual
            // 
            dateTimePickerRevisionAnual.Format = DateTimePickerFormat.Short;
            dateTimePickerRevisionAnual.Location = new Point(191, 221);
            dateTimePickerRevisionAnual.Name = "dateTimePickerRevisionAnual";
            dateTimePickerRevisionAnual.Size = new Size(118, 23);
            dateTimePickerRevisionAnual.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 52);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 14;
            label1.Text = "Matricula";
            // 
            // checkBoxActivo
            // 
            checkBoxActivo.AutoSize = true;
            checkBoxActivo.Location = new Point(191, 261);
            checkBoxActivo.Name = "checkBoxActivo";
            checkBoxActivo.Size = new Size(60, 19);
            checkBoxActivo.TabIndex = 25;
            checkBoxActivo.Text = "Activo";
            checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // FormModificarAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 360);
            Controls.Add(checkBoxActivo);
            Controls.Add(btn_Modificar);
            Controls.Add(txt_Revision100Hs);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_Modelo);
            Controls.Add(label3);
            Controls.Add(txt_Marca);
            Controls.Add(label2);
            Controls.Add(txt_Matricula);
            Controls.Add(dateTimePickerRevisionAnual);
            Controls.Add(label1);
            Name = "FormModificarAeronave";
            Text = "FormModificarAeronave";
            Load += FormModificarAeronave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Modificar;
        private TextBox txt_Revision100Hs;
        private Label label5;
        private Label label4;
        private TextBox txt_Modelo;
        private Label label3;
        private TextBox txt_Marca;
        private Label label2;
        private TextBox txt_Matricula;
        private DateTimePicker dateTimePickerRevisionAnual;
        private Label label1;
        private CheckBox checkBoxActivo;
    }
}