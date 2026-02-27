namespace Ejercicio_1
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
            treeView1 = new TreeView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(595, 113);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(292, 372);
            treeView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(595, 50);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 1;
            label1.Text = "Árbol creado";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(46, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 372);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 213);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 9;
            label3.Text = "Nodo Seleccionado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 128);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 8;
            label2.Text = "Nodo Seleccionado";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // button6
            // 
            button6.Location = new Point(197, 228);
            button6.Name = "button6";
            button6.Size = new Size(102, 47);
            button6.TabIndex = 5;
            button6.Text = "Agregar por Izquierda";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(197, 150);
            button5.Name = "button5";
            button5.Size = new Size(102, 47);
            button5.TabIndex = 4;
            button5.Text = "Agregar por Derecha";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(29, 303);
            button4.Name = "button4";
            button4.Size = new Size(102, 47);
            button4.TabIndex = 3;
            button4.Text = "Recorrido Posorden";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(29, 228);
            button3.Name = "button3";
            button3.Size = new Size(102, 47);
            button3.TabIndex = 2;
            button3.Text = "Recorrido Inorden";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(29, 150);
            button2.Name = "button2";
            button2.Size = new Size(102, 47);
            button2.TabIndex = 1;
            button2.Text = "Recorrido Preorden";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(29, 77);
            button1.Name = "button1";
            button1.Size = new Size(102, 47);
            button1.TabIndex = 0;
            button1.Text = "Agregar Nodo Raíz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 573);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
