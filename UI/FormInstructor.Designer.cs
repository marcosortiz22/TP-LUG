namespace UI
{
    partial class FormInstructor
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
            dgv_Instructor = new DataGridView();
            btn_AltaInstructor = new Button();
            btn_ModficarInstructor = new Button();
            btn_EliminarInstructor = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Instructor).BeginInit();
            SuspendLayout();
            // 
            // dgv_Instructor
            // 
            dgv_Instructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Instructor.Location = new Point(27, 22);
            dgv_Instructor.MultiSelect = false;
            dgv_Instructor.Name = "dgv_Instructor";
            dgv_Instructor.ReadOnly = true;
            dgv_Instructor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Instructor.Size = new Size(716, 222);
            dgv_Instructor.TabIndex = 0;
            // 
            // btn_AltaInstructor
            // 
            btn_AltaInstructor.Location = new Point(34, 266);
            btn_AltaInstructor.Name = "btn_AltaInstructor";
            btn_AltaInstructor.Size = new Size(94, 28);
            btn_AltaInstructor.TabIndex = 1;
            btn_AltaInstructor.Text = "Alta Instructor";
            btn_AltaInstructor.UseVisualStyleBackColor = true;
            btn_AltaInstructor.Click += btn_AltaInstructor_Click;
            // 
            // btn_ModficarInstructor
            // 
            btn_ModficarInstructor.Location = new Point(158, 265);
            btn_ModficarInstructor.Name = "btn_ModficarInstructor";
            btn_ModficarInstructor.Size = new Size(130, 28);
            btn_ModficarInstructor.TabIndex = 2;
            btn_ModficarInstructor.Text = "Modificar Instructor";
            btn_ModficarInstructor.UseVisualStyleBackColor = true;
            btn_ModficarInstructor.Click += btn_ModficarInstructor_Click;
            // 
            // btn_EliminarInstructor
            // 
            btn_EliminarInstructor.Location = new Point(609, 265);
            btn_EliminarInstructor.Name = "btn_EliminarInstructor";
            btn_EliminarInstructor.Size = new Size(134, 28);
            btn_EliminarInstructor.TabIndex = 3;
            btn_EliminarInstructor.Text = "Eliminar Instructor";
            btn_EliminarInstructor.UseVisualStyleBackColor = true;
            btn_EliminarInstructor.Click += btn_EliminarInstructor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 4);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Instructores";
            // 
            // FormInstructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 337);
            Controls.Add(label1);
            Controls.Add(btn_EliminarInstructor);
            Controls.Add(btn_ModficarInstructor);
            Controls.Add(btn_AltaInstructor);
            Controls.Add(dgv_Instructor);
            Name = "FormInstructor";
            Text = "FormInstructor";
            Load += FormInstructor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Instructor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Instructor;
        private Button btn_AltaInstructor;
        private Button btn_ModficarInstructor;
        private Button btn_EliminarInstructor;
        private Label label1;
    }
}