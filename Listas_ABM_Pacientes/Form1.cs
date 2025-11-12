namespace Listas_ABM_Pacientes
{
    public partial class Form1 : Form
    {
        ListaPaciente _lista = new ListaPaciente();

        public Form1()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            listBox1.Items.Clear();

            Paciente actual = _lista.inicio;

            while (actual != null)
            {
                listBox1.Items.Add($"Codigo: {actual.Codigo} - Nombre: {actual.Nombre} - Apellido: {actual.Apellido} - Dirección: {actual.Direccion} - Teléfono: {actual.Tel}");
                actual = actual.Siguiente;
            }

            if (_lista.inicio == null)
            {
                MessageBox.Show("La lista está vacía!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            string direccion = textBox4.Text;
            int tel = Convert.ToInt32(textBox5.Text);

            _lista.AgregarPrincipio(new Paciente(codigo, nombre, apellido, direccion, tel));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox6.Text);
            Paciente paciente = _lista.BuscarPorCodigo(codigo);
            
            if(paciente != null)
            {
                paciente.Nombre = textBox2.Text;
                paciente.Apellido = textBox3.Text;
                paciente.Direccion = textBox4.Text;
                paciente.Tel = Convert.ToInt32(textBox5.Text);

                Mostrar();

                MessageBox.Show("Paciente editado");
            }
            else
            {
                MessageBox.Show("El paciente no existe!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox6.Text);
            Paciente paciente = _lista.EliminadoPorCodigo(codigo);

            if(paciente != null)
            {
                Mostrar();
                listBox1.Refresh();
                MessageBox.Show("Paciente eliminado");
            }
            else
            {
                MessageBox.Show("El paciente no existe!");
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox6.Text);

            int codigoNuevo = Convert.ToInt32(textBox1.Text);
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            string direccion = textBox4.Text;
            int tel = Convert.ToInt32(textBox5.Text);

            Paciente nuevo = new Paciente(codigoNuevo, nombre, apellido, direccion, tel);

            _lista.AgregarDespues(nuevo, codigo);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
