using Microsoft.VisualBasic;

namespace SP_Practica
{
    public partial class Form1 : Form
    {
        ColaVenta cola = new ColaVenta();

        string rVenta = "../../../Ventas.txt";
        string rVentasAux = "../../../VentasAux.txt";

        public Form1()
        {
            InitializeComponent();
            LeerDesdeArchivo(rVenta);
            Mostrar();
        }

        private void GrabarEnArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    NodoVenta actual = cola.Ver();

                    while (actual != null)
                    {
                        sw.WriteLine($"{actual.CodVendedor}, {actual.ImporteVenta}");
                        actual = actual.Siguiente;
                    }
                }
            }
        }

        private void LeerDesdeArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string linea;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        string codigo = datos[0];
                        decimal importe = Convert.ToDecimal(datos[1]);

                        NodoVenta venta = new NodoVenta(codigo, importe);
                        cola.Encolar(venta);
                    }
                }
            }
        }

        private void OrdenarVentas(string ruta)
        {
            List<NodoVenta> listaVentas = new List<NodoVenta>();
            NodoVenta actual = cola.Ver();

            while(actual != null)
            {
                listaVentas.Add(new NodoVenta(actual.CodVendedor, actual.ImporteVenta));
                actual = actual.Siguiente;
            }

            listaVentas = listaVentas.OrderBy(a => a.CodVendedor).ToList();

            using(StreamWriter sw = new StreamWriter(ruta))
            { 
                foreach(var ventas in listaVentas)
                {
                    sw.WriteLine($"{ventas.CodVendedor}, {ventas.ImporteVenta}");
                }
            }
        }

        private void CorteControl(string ruta)
        {
            if (File.Exists(ruta))
            {
                using(StreamReader sr = new StreamReader(ruta))
                {
                    string _S = sr.ReadLine();
                    string[] _D = _S.Split(',');

                    bool agregar1 = false;

                    decimal _SubtotalVentas = 0;
                    decimal _TotalGeneral = 0;

                    while(_S != null)
                    {
                        string _Vendedor = _D[0];

                        dataGridView1.Rows.Add(new string[] { _D[0] });
                        
                        while(_S != null && _Vendedor == _D[0])
                        {
                            decimal importe = Convert.ToDecimal(_D[1]);
                            _SubtotalVentas += importe;
                            _TotalGeneral += importe;

                            dataGridView1.Rows.Add(new string[] { "", _D[1] });
                            agregar1 = true;

                            _S = sr.ReadLine();
                            if(_S != null)
                            {
                                _D = _S.Split(',');
                            }
                        }
                        dataGridView1.Rows.Add(new string[] { "", "Subtotal =>", _SubtotalVentas.ToString() });
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None));
                        
                        _SubtotalVentas = 0;
                        agregar1 = false;
                    }
                    dataGridView1.Rows.Add(new string[] { "", "", "Total =>", _TotalGeneral.ToString() });
                }
            }
        }

        private void Mostrar()
        {
            listBox1.Items.Clear();

            NodoVenta actual = cola.Ver();

            while (actual != null)
            {
                listBox1.Items.Add($"Codigo: {actual.CodVendedor} - Importe: {actual.ImporteVenta}");
                actual = actual.Siguiente;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = Interaction.InputBox("Ingrese el codigo del vendedor");
            decimal importe = Convert.ToDecimal(Interaction.InputBox("Ingrese el importe de la venta"));

            NodoVenta venta = new NodoVenta(codigo, importe);
            cola.Encolar(venta);
            GrabarEnArchivo(rVenta);
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cola.Desencolar();
            GrabarEnArchivo(rVenta);
            Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrdenarVentas(rVentasAux);
            CorteControl(rVentasAux);
        }
    }
}
