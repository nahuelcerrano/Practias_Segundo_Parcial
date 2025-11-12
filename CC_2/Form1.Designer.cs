namespace CC_2
{
    partial class Form1
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
            button1 = new Button();
            vendedor = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            importe = new DataGridViewTextBoxColumn();
            subtotalProducto = new DataGridViewTextBoxColumn();
            subtotalPrecioProducto = new DataGridViewTextBoxColumn();
            subtotalVendedor = new DataGridViewTextBoxColumn();
            totalGeneral = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vendedor, producto, cantidad, importe, subtotalProducto, subtotalPrecioProducto, subtotalVendedor, totalGeneral });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1379, 541);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1397, 28);
            button1.Name = "button1";
            button1.Size = new Size(96, 45);
            button1.TabIndex = 1;
            button1.Text = "Corte de Control";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // vendedor
            // 
            vendedor.HeaderText = "Vendedor";
            vendedor.Name = "vendedor";
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.Name = "producto";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // importe
            // 
            importe.HeaderText = "Importe";
            importe.Name = "importe";
            // 
            // subtotalProducto
            // 
            subtotalProducto.HeaderText = "Subtotal Producto";
            subtotalProducto.Name = "subtotalProducto";
            // 
            // subtotalPrecioProducto
            // 
            subtotalPrecioProducto.HeaderText = "Subtotal Precio Producto";
            subtotalPrecioProducto.Name = "subtotalPrecioProducto";
            // 
            // subtotalVendedor
            // 
            subtotalVendedor.HeaderText = "Subtotal Vendedor";
            subtotalVendedor.Name = "subtotalVendedor";
            // 
            // totalGeneral
            // 
            totalGeneral.HeaderText = "Total General";
            totalGeneral.Name = "totalGeneral";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 580);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn vendedor;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn importe;
        private DataGridViewTextBoxColumn subtotalProducto;
        private DataGridViewTextBoxColumn subtotalPrecioProducto;
        private DataGridViewTextBoxColumn subtotalVendedor;
        private DataGridViewTextBoxColumn totalGeneral;
    }
}
