namespace UI
{
    partial class FormCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label8 = new Label();
            Altabtn = new Button();
            Bajabtn = new Button();
            Modificarbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 39);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(672, 135);
            dataGridView1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(291, 5);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 8;
            label8.Text = "Lista de cliente";
            // 
            // Altabtn
            // 
            Altabtn.Location = new Point(57, 221);
            Altabtn.Margin = new Padding(2, 2, 2, 2);
            Altabtn.Name = "Altabtn";
            Altabtn.Size = new Size(83, 41);
            Altabtn.TabIndex = 15;
            Altabtn.Text = "Alta de cliente";
            Altabtn.UseVisualStyleBackColor = true;
            Altabtn.Click += button1_Click;
            // 
            // Bajabtn
            // 
            Bajabtn.Location = new Point(644, 221);
            Bajabtn.Margin = new Padding(2, 2, 2, 2);
            Bajabtn.Name = "Bajabtn";
            Bajabtn.Size = new Size(85, 41);
            Bajabtn.TabIndex = 16;
            Bajabtn.Text = "Baja de cliente ";
            Bajabtn.UseVisualStyleBackColor = true;
            Bajabtn.Click += Bajabtn_Click;
            // 
            // Modificarbtn
            // 
            Modificarbtn.Location = new Point(166, 221);
            Modificarbtn.Margin = new Padding(2, 2, 2, 2);
            Modificarbtn.Name = "Modificarbtn";
            Modificarbtn.Size = new Size(78, 41);
            Modificarbtn.TabIndex = 17;
            Modificarbtn.Text = "Modificar cliente ";
            Modificarbtn.UseVisualStyleBackColor = true;
            Modificarbtn.Click += button3_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 320);
            Controls.Add(Modificarbtn);
            Controls.Add(Bajabtn);
            Controls.Add(Altabtn);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Name = "FormCliente";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button Altabtn;
        private Label label9;
        private Button Bajabtn;
        private Button Modificarbtn;
    }
}
