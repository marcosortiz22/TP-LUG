namespace UI
{
    partial class FormVuelosABM
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
            cmbAeronavesDisp = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbFinalidad = new ComboBox();
            label3 = new Label();
            dtpFechaVuelo = new DateTimePicker();
            label4 = new Label();
            cmbInstructor = new ComboBox();
            cmbCliente = new ComboBox();
            label5 = new Label();
            dtpHoraPM = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dtpHoraCorte = new DateTimePicker();
            nddHubInicial = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            nddHubFinal = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nddHubInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nddHubFinal).BeginInit();
            SuspendLayout();
            // 
            // cmbAeronavesDisp
            // 
            cmbAeronavesDisp.FormattingEnabled = true;
            cmbAeronavesDisp.Location = new Point(132, 153);
            cmbAeronavesDisp.Margin = new Padding(3, 4, 3, 4);
            cmbAeronavesDisp.Name = "cmbAeronavesDisp";
            cmbAeronavesDisp.Size = new Size(212, 28);
            cmbAeronavesDisp.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 153);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Aeronave:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 193);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 6;
            label2.Text = "Finalidad:";
            // 
            // cmbFinalidad
            // 
            cmbFinalidad.FormattingEnabled = true;
            cmbFinalidad.Location = new Point(132, 189);
            cmbFinalidad.Margin = new Padding(3, 4, 3, 4);
            cmbFinalidad.Name = "cmbFinalidad";
            cmbFinalidad.Size = new Size(210, 28);
            cmbFinalidad.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 50);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 12;
            label3.Text = "Fecha de vuelo:";
            // 
            // dtpFechaVuelo
            // 
            dtpFechaVuelo.Location = new Point(132, 50);
            dtpFechaVuelo.Name = "dtpFechaVuelo";
            dtpFechaVuelo.Size = new Size(250, 27);
            dtpFechaVuelo.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 84);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 14;
            label4.Text = "Instructor:";
            // 
            // cmbInstructor
            // 
            cmbInstructor.FormattingEnabled = true;
            cmbInstructor.Location = new Point(132, 81);
            cmbInstructor.Margin = new Padding(3, 4, 3, 4);
            cmbInstructor.Name = "cmbInstructor";
            cmbInstructor.Size = new Size(212, 28);
            cmbInstructor.TabIndex = 15;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(132, 117);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(212, 28);
            cmbCliente.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 120);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 16;
            label5.Text = "Cliente:";
            // 
            // dtpHoraPM
            // 
            dtpHoraPM.CustomFormat = "HH:mm";
            dtpHoraPM.Format = DateTimePickerFormat.Custom;
            dtpHoraPM.Location = new Point(505, 43);
            dtpHoraPM.Name = "dtpHoraPM";
            dtpHoraPM.Size = new Size(105, 27);
            dtpHoraPM.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 50);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 19;
            label6.Text = "Hora PM:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 83);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 21;
            label7.Text = "Hora Corte:";
            // 
            // dtpHoraCorte
            // 
            dtpHoraCorte.CustomFormat = "HH:mm";
            dtpHoraCorte.Format = DateTimePickerFormat.Custom;
            dtpHoraCorte.Location = new Point(505, 76);
            dtpHoraCorte.Name = "dtpHoraCorte";
            dtpHoraCorte.Size = new Size(105, 27);
            dtpHoraCorte.TabIndex = 20;
            // 
            // nddHubInicial
            // 
            nddHubInicial.DecimalPlaces = 2;
            nddHubInicial.Location = new Point(505, 109);
            nddHubInicial.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            nddHubInicial.Name = "nddHubInicial";
            nddHubInicial.Size = new Size(150, 27);
            nddHubInicial.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(413, 116);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 23;
            label8.Text = "Hub inicial:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(413, 149);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 25;
            label9.Text = "Hub final:";
            // 
            // nddHubFinal
            // 
            nddHubFinal.DecimalPlaces = 2;
            nddHubFinal.Location = new Point(505, 142);
            nddHubFinal.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            nddHubFinal.Name = "nddHubFinal";
            nddHubFinal.Size = new Size(150, 27);
            nddHubFinal.TabIndex = 24;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(15, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(558, 244);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormVueloABM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 291);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label9);
            Controls.Add(nddHubFinal);
            Controls.Add(label8);
            Controls.Add(nddHubInicial);
            Controls.Add(label7);
            Controls.Add(dtpHoraCorte);
            Controls.Add(label6);
            Controls.Add(dtpHoraPM);
            Controls.Add(cmbCliente);
            Controls.Add(label5);
            Controls.Add(cmbInstructor);
            Controls.Add(label4);
            Controls.Add(dtpFechaVuelo);
            Controls.Add(label3);
            Controls.Add(cmbFinalidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbAeronavesDisp);
            Name = "FormVueloABM";
            Text = "FormVueloABM";
            ((System.ComponentModel.ISupportInitialize)nddHubInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)nddHubFinal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAeronavesDisp;
        private Label label1;
        private Label label2;
        private ComboBox cmbFinalidad;
        private Label label3;
        private DateTimePicker dtpFechaVuelo;
        private Label label4;
        private ComboBox cmbInstructor;
        private ComboBox cmbCliente;
        private Label label5;
        private DateTimePicker dtpHoraPM;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpHoraCorte;
        private NumericUpDown nddHubInicial;
        private Label label8;
        private Label label9;
        private NumericUpDown nddHubFinal;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}