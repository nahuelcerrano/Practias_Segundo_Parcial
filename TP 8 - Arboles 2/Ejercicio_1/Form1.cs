namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public class Nodo
        {
            public Nodo(string pId = "", Nodo pIzq = null, Nodo pDer = null)
            {
                Id = pId;
                Izquierdo = pIzq;
                Derecho = pDer;
            }
            public string Id { get; set; }
            public Nodo Izquierdo { get; set; }
            public Nodo Derecho { get; set; }
        }

        private Nodo raiz;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (raiz != null)
                {
                    MessageBox.Show("Ya existe un nodo raíz!!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Ingrese un valor para el nodo raíz");
                    return;
                }

                string valor = textBox1.Text.Trim();
                raiz = new Nodo(valor);

                treeView1.Nodes.Clear();
                TreeNode nodoVisual = new TreeNode(valor);
                nodoVisual.Tag = raiz;
                treeView1.Nodes.Add(nodoVisual);

                treeView1.ExpandAll();
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (raiz == null)
                {
                    MessageBox.Show("Primero debe crear un nodo raíz!!");
                    return;
                }

                if (treeView1.SelectedNode == null)
                {
                    MessageBox.Show("Debe seleccionar un nodo en el árbol!!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Ingrese un valor para el nuevo nodo!!");
                    return;
                }

                TreeNode nodoSeleccionado = treeView1.SelectedNode;
                Nodo nodoLogicoSeleccionado = (Nodo)nodoSeleccionado.Tag;

                if (nodoLogicoSeleccionado.Derecho != null)
                {
                    MessageBox.Show("Este nodo ya tiene un sucesor derecho");
                    return;
                }

                string valor = textBox1.Text.Trim();
                Nodo nuevoNodoLogico = new Nodo(valor);
                nodoLogicoSeleccionado.Derecho = nuevoNodoLogico;

                TreeNode nuevoNodo = new TreeNode(valor);
                nuevoNodo.Tag = nuevoNodoLogico;

                if (nodoLogicoSeleccionado.Izquierdo != null)
                {
                    nodoSeleccionado.Nodes.Add(nuevoNodo);
                }
                else
                {
                    nodoSeleccionado.Nodes.Insert(0, nuevoNodo);
                }

                treeView1.ExpandAll();
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (raiz == null)
                {
                    MessageBox.Show("Primero debe crear un nodo raíz!!");
                    return;
                }

                if (treeView1.SelectedNode == null)
                {
                    MessageBox.Show("Debe seleccionar un nodo en el árbol!!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Ingrese un valor para el nuevo nodo!!");
                    return;
                }

                TreeNode nodoSeleccionado = treeView1.SelectedNode;
                Nodo nodoLogicoSeleccionado = (Nodo)nodoSeleccionado.Tag;

                if (nodoLogicoSeleccionado.Izquierdo != null)
                {
                    MessageBox.Show("Este nodo ya tiene un sucesor izquierdo");
                    return;
                }

                string valor = textBox2.Text.Trim();
                Nodo nuevoNodo = new Nodo(valor);
                nodoLogicoSeleccionado.Izquierdo = nuevoNodo;

                TreeNode nuevoNodoVisual = new TreeNode(valor);
                nuevoNodoVisual.Tag = nuevoNodo;

                nodoSeleccionado.Nodes.Insert(0, nuevoNodoVisual);

                treeView1.ExpandAll();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Recorrido Preorden
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (raiz == null)
                {
                    MessageBox.Show("El árbol está vacío.", "Información");
                    return;
                }

                string resultado = "";
                PreOrdenRecursiva(raiz, ref resultado);
                MessageBox.Show($"Recorrido Preorden:\n{resultado.Trim()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PreOrdenRecursiva(Nodo nodo, ref string resultado)
        {
            if (nodo != null)
            {
                resultado += $"{nodo.Id} ";
                PreOrdenRecursiva(nodo.Izquierdo, ref resultado);
                PreOrdenRecursiva(nodo.Derecho, ref resultado);
            }
        }

        // Recorrido Inorden
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (raiz == null)
                {
                    MessageBox.Show("El árbol está vacío.", "Información");
                    return;
                }

                string resultado = "";
                InOrdenRecursiva(raiz, ref resultado);
                MessageBox.Show($"Recorrido Inorden:\n{resultado.Trim()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void InOrdenRecursiva(Nodo nodo, ref string resultado)
        {
            if (nodo != null)
            {
                InOrdenRecursiva(nodo.Izquierdo, ref resultado);
                resultado += $"{nodo.Id} ";
                InOrdenRecursiva(nodo.Derecho, ref resultado);
            }
        }

        // Recorrido Posorden
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (raiz == null)
                {
                    MessageBox.Show("El árbol está vacío.", "Información");
                    return;
                }

                string resultado = "";
                PosOrdenRecursiva(raiz, ref resultado);
                MessageBox.Show($"Recorrido Posorden:\n{resultado.Trim()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PosOrdenRecursiva(Nodo nodo, ref string resultado)
        {
            if (nodo != null)
            {
                PosOrdenRecursiva(nodo.Izquierdo, ref resultado);
                PosOrdenRecursiva(nodo.Derecho, ref resultado);
                resultado += $"{nodo.Id} ";
            }
        }
    }
}
