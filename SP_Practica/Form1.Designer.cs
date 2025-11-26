namespace SP_Practica
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            importe = new DataGridViewTextBoxColumn();
            subVenta = new DataGridViewTextBoxColumn();
            totGeneral = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(339, 634);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(415, 133);
            button1.Name = "button1";
            button1.Size = new Size(121, 53);
            button1.TabIndex = 1;
            button1.Text = "Encolar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(415, 267);
            button2.Name = "button2";
            button2.Size = new Size(121, 53);
            button2.TabIndex = 2;
            button2.Text = "Desencolar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(415, 410);
            button3.Name = "button3";
            button3.Size = new Size(121, 53);
            button3.TabIndex = 3;
            button3.Text = "Corte de Control";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, importe, subVenta, totGeneral });
            dataGridView1.Location = new Point(592, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 634);
            dataGridView1.TabIndex = 4;
            // 
            // codigo
            // 
            codigo.HeaderText = "Codigo Vendedor";
            codigo.Name = "codigo";
            // 
            // importe
            // 
            importe.HeaderText = "Importe Venta";
            importe.Name = "importe";
            // 
            // subVenta
            // 
            subVenta.HeaderText = "Subtotal Venta";
            subVenta.Name = "subVenta";
            // 
            // totGeneral
            // 
            totGeneral.HeaderText = "Total General";
            totGeneral.Name = "totGeneral";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 669);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn importe;
        private DataGridViewTextBoxColumn subVenta;
        private DataGridViewTextBoxColumn totGeneral;
    }
}
