namespace UI
{
    partial class AltaCliente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textDNI = new TextBox();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textTelefono = new TextBox();
            textEmail = new TextBox();
            textTelEmergencia = new TextBox();
            label10 = new Label();
            BtnAlta = new Button();
            label7 = new Label();
            textBrevet = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 61);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 92);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 123);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 29);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // textDNI
            // 
            textDNI.Location = new Point(88, 25);
            textDNI.Margin = new Padding(2);
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(106, 23);
            textDNI.TabIndex = 10;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(88, 58);
            textNombre.Margin = new Padding(2);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(106, 23);
            textNombre.TabIndex = 11;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(88, 89);
            textApellido.Margin = new Padding(2);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(106, 23);
            textApellido.TabIndex = 12;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(88, 119);
            textTelefono.Margin = new Padding(2);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(106, 23);
            textTelefono.TabIndex = 13;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(377, 27);
            textEmail.Margin = new Padding(2);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(106, 23);
            textEmail.TabIndex = 14;
            // 
            // textTelEmergencia
            // 
            textTelEmergencia.Location = new Point(377, 92);
            textTelEmergencia.Margin = new Padding(2);
            textTelEmergencia.Name = "textTelEmergencia";
            textTelEmergencia.Size = new Size(106, 23);
            textTelEmergencia.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(226, 92);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(133, 15);
            label10.TabIndex = 19;
            label10.Text = "Telefono de emergencia";
            // 
            // BtnAlta
            // 
            BtnAlta.Location = new Point(194, 159);
            BtnAlta.Margin = new Padding(2);
            BtnAlta.Name = "BtnAlta";
            BtnAlta.Size = new Size(112, 28);
            BtnAlta.TabIndex = 20;
            BtnAlta.Text = "Alta";
            BtnAlta.UseVisualStyleBackColor = true;
            BtnAlta.Click += BtnAlta_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(226, 61);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 27;
            label7.Text = "Brevet";
            // 
            // textBrevet
            // 
            textBrevet.Location = new Point(377, 61);
            textBrevet.Margin = new Padding(2);
            textBrevet.Name = "textBrevet";
            textBrevet.Size = new Size(106, 23);
            textBrevet.TabIndex = 28;
            // 
            // AltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 203);
            Controls.Add(textBrevet);
            Controls.Add(label7);
            Controls.Add(BtnAlta);
            Controls.Add(label10);
            Controls.Add(textTelEmergencia);
            Controls.Add(textEmail);
            Controls.Add(textTelefono);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(textDNI);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "AltaCliente";
            Text = "Alta de cliente ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textDNI;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textTelefono;
        private TextBox textEmail;
        private TextBox textTelEmergencia;
        private Label label10;
        private Button BtnAlta;
        private Label label7;
        private TextBox textBrevet;
    }
}