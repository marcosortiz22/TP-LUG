namespace UI
{
    partial class ActualizarCliente
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
            btnModificar = new Button();
            label10 = new Label();
            textTelEmergencia = new TextBox();
            textHoras = new TextBox();
            textBrevet = new TextBox();
            textEmail = new TextBox();
            textTelefono = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            textDNI = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(280, 297);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 39;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(331, 203);
            label10.Name = "label10";
            label10.Size = new Size(200, 25);
            label10.TabIndex = 38;
            label10.Text = "Telefono de emergencia";
            // 
            // textTelEmergencia
            // 
            textTelEmergencia.Location = new Point(557, 194);
            textTelEmergencia.Name = "textTelEmergencia";
            textTelEmergencia.Size = new Size(150, 31);
            textTelEmergencia.TabIndex = 37;
            // 
            // textHoras
            // 
            textHoras.Location = new Point(557, 146);
            textHoras.Name = "textHoras";
            textHoras.Size = new Size(150, 31);
            textHoras.TabIndex = 35;
            // 
            // textBrevet
            // 
            textBrevet.Location = new Point(557, 91);
            textBrevet.Name = "textBrevet";
            textBrevet.Size = new Size(150, 31);
            textBrevet.TabIndex = 34;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(557, 40);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(150, 31);
            textEmail.TabIndex = 33;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(133, 197);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(150, 31);
            textTelefono.TabIndex = 32;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(133, 146);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(150, 31);
            textApellido.TabIndex = 31;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(133, 94);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(150, 31);
            textNombre.TabIndex = 30;
            // 
            // textDNI
            // 
            textDNI.Location = new Point(133, 40);
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(150, 31);
            textDNI.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(331, 152);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 27;
            label8.Text = "Saldo/Horas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 97);
            label7.Name = "label7";
            label7.Size = new Size(61, 25);
            label7.TabIndex = 26;
            label7.Text = "Brevet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 46);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 25;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 200);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 24;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 152);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 23;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 100);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 22;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 46);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 21;
            label2.Text = "DNI";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(133, 244);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 29);
            checkBox1.TabIndex = 40;
            checkBox1.Text = "Activo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ActualizarCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 346);
            Controls.Add(checkBox1);
            Controls.Add(btnModificar);
            Controls.Add(label10);
            Controls.Add(textTelEmergencia);
            Controls.Add(textHoras);
            Controls.Add(textBrevet);
            Controls.Add(textEmail);
            Controls.Add(textTelefono);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(textDNI);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ActualizarCliente";
            Text = "Actualizar cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private Label label10;
        private TextBox textTelEmergencia;
        private TextBox textHoras;
        private TextBox textBrevet;
        private TextBox textEmail;
        private TextBox textTelefono;
        private TextBox textApellido;
        private TextBox textNombre;
        private TextBox textDNI;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox checkBox1;
    }
}