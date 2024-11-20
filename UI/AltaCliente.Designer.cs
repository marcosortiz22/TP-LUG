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
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 48);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 102);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 154);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 3;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 205);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(323, 48);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // textDNI
            // 
            textDNI.Location = new Point(125, 42);
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(150, 31);
            textDNI.TabIndex = 10;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(125, 96);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(150, 31);
            textNombre.TabIndex = 11;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(125, 148);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(150, 31);
            textApellido.TabIndex = 12;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(125, 199);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(150, 31);
            textTelefono.TabIndex = 13;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(538, 45);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(150, 31);
            textEmail.TabIndex = 14;
            // 
            // textTelEmergencia
            // 
            textTelEmergencia.Location = new Point(538, 95);
            textTelEmergencia.Name = "textTelEmergencia";
            textTelEmergencia.Size = new Size(150, 31);
            textTelEmergencia.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(323, 102);
            label10.Name = "label10";
            label10.Size = new Size(200, 25);
            label10.TabIndex = 19;
            label10.Text = "Telefono de emergencia";
            // 
            // BtnAlta
            // 
            BtnAlta.Location = new Point(277, 265);
            BtnAlta.Name = "BtnAlta";
            BtnAlta.Size = new Size(160, 46);
            BtnAlta.TabIndex = 20;
            BtnAlta.Text = "Alta";
            BtnAlta.UseVisualStyleBackColor = true;
            // 
            // AltaCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 338);
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
    }
}