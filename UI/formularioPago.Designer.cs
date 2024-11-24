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
            BtnCrearPago = new Button();
            dataGridViewPagos = new DataGridView();
            BtnEliminarPago = new Button();
            txtSaldoHorasCliente = new TextBox();
            txtSaldoHoras = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).BeginInit();
            SuspendLayout();
            // 
            // comboCliente
            // 
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(234, 28);
            comboCliente.Margin = new Padding(2);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(129, 23);
            comboCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor de la hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 122);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 3;
            label3.Text = "Cantidad de horas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 186);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 4;
            label4.Text = "Total a facturar";
            // 
            // textValorHora
            // 
            textValorHora.Location = new Point(15, 85);
            textValorHora.Margin = new Padding(2);
            textValorHora.Name = "textValorHora";
            textValorHora.Size = new Size(106, 23);
            textValorHora.TabIndex = 5;
            // 
            // textCantidadHora
            // 
            textCantidadHora.Location = new Point(12, 139);
            textCantidadHora.Margin = new Padding(2);
            textCantidadHora.Name = "textCantidadHora";
            textCantidadHora.Size = new Size(106, 23);
            textCantidadHora.TabIndex = 6;
            // 
            // textTotal
            // 
            textTotal.Location = new Point(15, 203);
            textTotal.Margin = new Padding(2);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(106, 23);
            textTotal.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 11);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Factura";
            // 
            // textFactura
            // 
            textFactura.Location = new Point(15, 28);
            textFactura.Margin = new Padding(2);
            textFactura.Name = "textFactura";
            textFactura.Size = new Size(106, 23);
            textFactura.TabIndex = 9;
            // 
            // BtnCrearPago
            // 
            BtnCrearPago.Location = new Point(154, 235);
            BtnCrearPago.Name = "BtnCrearPago";
            BtnCrearPago.Size = new Size(106, 23);
            BtnCrearPago.TabIndex = 10;
            BtnCrearPago.Text = "Crear Pago";
            BtnCrearPago.UseVisualStyleBackColor = true;
            BtnCrearPago.Click += BtnCrearPago_Click;
            // 
            // dataGridViewPagos
            // 
            dataGridViewPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPagos.Location = new Point(408, 30);
            dataGridViewPagos.Name = "dataGridViewPagos";
            dataGridViewPagos.Size = new Size(537, 150);
            dataGridViewPagos.TabIndex = 11;
            // 
            // BtnEliminarPago
            // 
            BtnEliminarPago.Location = new Point(839, 186);
            BtnEliminarPago.Name = "BtnEliminarPago";
            BtnEliminarPago.Size = new Size(106, 23);
            BtnEliminarPago.TabIndex = 12;
            BtnEliminarPago.Text = "Eliminar Pago";
            BtnEliminarPago.UseVisualStyleBackColor = true;
            BtnEliminarPago.Click += BtnEliminarPago_Click;
            // 
            // txtSaldoHorasCliente
            // 
            txtSaldoHorasCliente.Location = new Point(244, 139);
            txtSaldoHorasCliente.Name = "txtSaldoHorasCliente";
            txtSaldoHorasCliente.Size = new Size(100, 23);
            txtSaldoHorasCliente.TabIndex = 13;
            // 
            // txtSaldoHoras
            // 
            txtSaldoHoras.AutoSize = true;
            txtSaldoHoras.Location = new Point(244, 112);
            txtSaldoHoras.Name = "txtSaldoHoras";
            txtSaldoHoras.Size = new Size(70, 15);
            txtSaldoHoras.TabIndex = 14;
            txtSaldoHoras.Text = "Saldo Horas";
            // 
            // formularioPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 266);
            Controls.Add(txtSaldoHoras);
            Controls.Add(txtSaldoHorasCliente);
            Controls.Add(BtnEliminarPago);
            Controls.Add(dataGridViewPagos);
            Controls.Add(BtnCrearPago);
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
            Margin = new Padding(2);
            Name = "formularioPago";
            Text = "formularioPago";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).EndInit();
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
        private Button BtnCrearPago;
        private DataGridView dataGridViewPagos;
        private Button BtnEliminarPago;
        private TextBox txtSaldoHorasCliente;
        private Label txtSaldoHoras;
    }
}