namespace Listas_ABM_Alumnos_2
{
    public partial class Form1 : Form
    {
        ListaAlumnos _lista = new ListaAlumnos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            dataGridView1.Rows.Clear();

            Alumnos actual = _lista.inicio;

            while (actual != null)
            {
                dataGridView1.Rows.Add(actual.Dni, actual.Nombre, actual.Apellido, actual.FechaNac, actual.Direccion, actual.Tel);
                actual = actual.Siguiente;
            }

            if(_lista.inicio == null)
            {
                MessageBox.Show("La lista esta vacía!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBox1.Text);
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            DateTime fecha = dateTimePicker1.Value;
            string direccion = textBox4.Text;
            int tel = Convert.ToInt32(textBox5.Text);

            _lista.AgregarInicio(new Alumnos(dni, nombre, apellido, fecha, direccion, tel));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBox6.Text);
            Alumnos alumno = _lista.BuscarPorDni(dni);

            if(alumno != null)
            {
                alumno.Nombre = textBox2.Text;
                alumno.Apellido = textBox3.Text;
                alumno.FechaNac = dateTimePicker1.Value;
                alumno.Direccion = textBox4.Text;
                alumno.Tel = Convert.ToInt32(textBox5.Text);
            }
            else
            {
                MessageBox.Show($"No existe el alumno con DNI: {dni}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBox6.Text);
            Alumnos alumno = _lista.EliminarPorDni(dni);

            if(alumno != null)
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show($"No existe el alumno con DNI: {dni}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBox6.Text);

            int dniNuevo = Convert.ToInt32(textBox1.Text);
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            DateTime fecha = dateTimePicker1.Value;
            string direccion = textBox4.Text;
            int tel = Convert.ToInt32(textBox5.Text);

            Alumnos alumno = new Alumnos(dniNuevo, nombre, apellido, fecha, direccion, tel);

            _lista.AgregarDespues(alumno, dni);
            Mostrar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
