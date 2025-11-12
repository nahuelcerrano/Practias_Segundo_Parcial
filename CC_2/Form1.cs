namespace CC_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ventas = @"../../../Archivos/Ventas.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                if (c.Index > 0)
                {
                    c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            bool agregar = false;
            bool agregar2 = false;

            decimal subtotalQProducto = 0;
            decimal subtotalProducto = 0;
            decimal subtotalVendedor = 0;
            decimal totalGeneral = 0;

            if(File.Exists(ventas))
            {
                using (StreamReader sr = new StreamReader(ventas))
                {
                    string _S = sr.ReadLine();
                    string[] _D = _S.Split(',');

                    while(_S != null)
                    {
                        string _Vendedor = _D[0];

                        dataGridView1.Rows.Add(new string[] { _D[0] });

                        while (_Vendedor == _D[0] && _S != null)
                        {
                            string _Producto = _D[1];

                            if (agregar2)
                            {
                                dataGridView1.Rows.Add(new string[] { "", _D[1] });
                            }
                            else
                            {
                                dataGridView1.Rows[dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[1].Value = _D[1];
                                agregar2 = true;
                            }

                            while (_Producto == _D[1] && _Vendedor == _D[0] && _S != null)
                            {
                                subtotalQProducto += decimal.Parse(_D[2]);
                                subtotalProducto += decimal.Parse(_D[3]);
                                subtotalVendedor += decimal.Parse(_D[3]);
                                totalGeneral += decimal.Parse(_D[3]);

                                if (agregar)
                                {
                                    dataGridView1.Rows.Add(new string[] { "", "", _D[2], _D[3] });
                                }
                                else
                                {
                                    var ultimaFila = dataGridView1.Rows[dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None)];
                                    ultimaFila.Cells[2].Value = _D[2];
                                    ultimaFila.Cells[3].Value = _D[3];
                                    agregar = true;
                                }

                                _S = sr.ReadLine();
                                if (_S != null)
                                {
                                    _D = _S.Split(new char[] { ',' });
                                }
                            }
                            dataGridView1.Rows.Add(new string[] { "", "", "", "Subtot Prod ->", subtotalQProducto.ToString(), subtotalProducto.ToString() });
                            dataGridView1.Rows.Add();
                            subtotalQProducto = 0;
                            subtotalProducto = 0;
                            agregar2 = false;
                            agregar = false;
                        }
                        dataGridView1.Rows.Add(new string[] { "", "", "", "", "", "Subtot ->", subtotalVendedor.ToString() });
                        subtotalVendedor = 0;
                        agregar = false;
                    }
                    dataGridView1.Rows.Add(new string[] { "", "", "", "", "", "", "Total Gral ->", totalGeneral.ToString() });
                    totalGeneral = 0;
                }
            }
        }
    }
}
