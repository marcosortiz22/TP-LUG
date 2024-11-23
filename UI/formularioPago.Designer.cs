namespace UI
{
    partial class formularioPago
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
            comboCliente = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textValorHora = new TextBox();
            textCantidadHora = new TextBox();
            textTotal = new TextBox();
            label5 = new Label();
            textFactura = new TextBox();
            SuspendLayout();
            // 
            // comboCliente
            // 
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(458, 67);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(182, 33);
            comboCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 149);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 2;
            label2.Text = "Valor de la hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 249);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 3;
            label3.Text = "Cantidad de horas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 386);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 4;
            label4.Text = "Total a facturar";
            // 
            // textValorHora
            // 
            textValorHora.Location = new Point(26, 189);
            textValorHora.Name = "textValorHora";
            textValorHora.Size = new Size(150, 31);
            textValorHora.TabIndex = 5;
            // 
            // textCantidadHora
            // 
            textCantidadHora.Location = new Point(26, 289);
            textCantidadHora.Name = "textCantidadHora";
            textCantidadHora.Size = new Size(150, 31);
            textCantidadHora.TabIndex = 6;
            // 
            // textTotal
            // 
            textTotal.Location = new Point(198, 383);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(150, 31);
            textTotal.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 171);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 8;
            label5.Text = "Factura";
            // 
            // textFactura
            // 
            textFactura.Location = new Point(458, 220);
            textFactura.Name = "textFactura";
            textFactura.Size = new Size(150, 31);
            textFactura.TabIndex = 9;
            // 
            // formularioPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(textFactura);
            Controls.Add(label5);
            Controls.Add(textTotal);
            Controls.Add(textCantidadHora);
            Controls.Add(textValorHora);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboCliente);
            Name = "formularioPago";
            Text = "formularioPago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textValorHora;
        private TextBox textCantidadHora;
        private TextBox textTotal;
        private Label label5;
        private TextBox textFactura;
    }
}