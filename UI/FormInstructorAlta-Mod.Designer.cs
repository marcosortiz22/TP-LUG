namespace UI
{
    partial class FormInstructorAlta_Mod
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
            BtnAlta = new Button();
            txt_Brevet = new TextBox();
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            txt_Dni = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            txt_IdInstructor = new TextBox();
            label_Id = new Label();
            SuspendLayout();
            // 
            // BtnAlta
            // 
            BtnAlta.Location = new Point(129, 208);
            BtnAlta.Margin = new Padding(2);
            BtnAlta.Name = "BtnAlta";
            BtnAlta.Size = new Size(112, 28);
            BtnAlta.TabIndex = 33;
            BtnAlta.Text = "Alta";
            BtnAlta.UseVisualStyleBackColor = true;
            BtnAlta.Click += BtnAlta_Click;
            // 
            // txt_Brevet
            // 
            txt_Brevet.Location = new Point(135, 145);
            txt_Brevet.Margin = new Padding(2);
            txt_Brevet.Name = "txt_Brevet";
            txt_Brevet.Size = new Size(106, 23);
            txt_Brevet.TabIndex = 29;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(135, 87);
            txt_Apellido.Margin = new Padding(2);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(106, 23);
            txt_Apellido.TabIndex = 28;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(135, 114);
            txt_Nombre.Margin = new Padding(2);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(106, 23);
            txt_Nombre.TabIndex = 27;
            // 
            // txt_Dni
            // 
            txt_Dni.Location = new Point(135, 52);
            txt_Dni.Margin = new Padding(2);
            txt_Dni.Name = "txt_Dni";
            txt_Dni.Size = new Size(106, 23);
            txt_Dni.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 149);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 24;
            label5.Text = "Brevet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 90);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 23;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 117);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 22;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 21;
            label2.Text = "DNI";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(135, 173);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "Activo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_IdInstructor
            // 
            txt_IdInstructor.Location = new Point(134, 21);
            txt_IdInstructor.Name = "txt_IdInstructor";
            txt_IdInstructor.Size = new Size(25, 23);
            txt_IdInstructor.TabIndex = 35;
            // 
            // label_Id
            // 
            label_Id.AutoSize = true;
            label_Id.Location = new Point(64, 25);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(18, 15);
            label_Id.TabIndex = 36;
            label_Id.Text = "ID";
            // 
            // FormInstructorAlta_Mod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 295);
            Controls.Add(label_Id);
            Controls.Add(txt_IdInstructor);
            Controls.Add(checkBox1);
            Controls.Add(BtnAlta);
            Controls.Add(txt_Brevet);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Dni);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormInstructorAlta_Mod";
            Text = "FormInstructorAlta_Mod";
            Load += FormInstructorAlta_Mod_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAlta;
        private TextBox txt_Brevet;
        private TextBox txt_Apellido;
        private TextBox txt_Nombre;
        private TextBox txt_Dni;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox txt_IdInstructor;
        private Label label_Id;
    }
}