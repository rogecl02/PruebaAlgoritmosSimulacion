using PruebaAlgoritmosSimulacion.Algoritmos;
using PruebaAlgoritmosSimulacion.Clases;
using System.Reflection.Metadata.Ecma335;


namespace PruebaAlgoritmosSimulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (int X_1, int a, int b, int c, int m) = validaciones(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            //Paso2: llamar a Algoritmo
            GeneradorAleatorios generador = new GeneradorAleatorios();

            List<int> listaleatoria = new List<int>();
            if ((X_1, a, b, c, m) != (0, 0, 0, 0, 0))
            {
                (List<List<float>> matrizResultados, float media) resultado = generador.MonteCarloSimulation(a, b, m, c);
                MessageBox.Show("Media: "+resultado.media.ToString());
                llenarGrid(resultado.matrizResultados, X_1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenarGrid(List<List<float>> lista, int X_1)
        {
            // Column names
            
            string[] columnNames = { "1", "2", "3", "4", "5", "6" };

            // Clear existing columns and add new ones
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(columnNames[0], "Iteración");
            dataGridView1.Columns.Add(columnNames[1], "Panel 1");
            dataGridView1.Columns.Add(columnNames[2], "Panel 2");
            dataGridView1.Columns.Add(columnNames[3], "Panel 3");
            dataGridView1.Columns.Add(columnNames[4], "Panel 4");
            dataGridView1.Columns.Add(columnNames[5], "Panel 5");

            // Populate rows
            for (int i = 0; i < lista.Count; i++)
            {
                // Add a new row and get the index of the added row
                int rowIndex = dataGridView1.Rows.Add();

                // Set cell values for the added row
                dataGridView1.Rows[rowIndex].Cells[0].Value = (i + 1).ToString(); // Iteration number

                for (int j = 0; j < lista[i].Count && j <= 5; j++)
                {
                    dataGridView1.Rows[rowIndex].Cells[j + 1].Value = lista[i][j].ToString(); // Panels 1 to 5
                }
            }
        }





        public void DescargaExcel(DataGridView data)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }
            int indiceFilas = 0;

            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //hola
        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        public (int X_1, int a, int b, int c, int d) validaciones(string a, string b, string c, string d, string e)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || string.IsNullOrEmpty(c) || string.IsNullOrEmpty(d) || string.IsNullOrEmpty(e))
            {
                MessageBox.Show("Los números tienen que ser Mayor que cero, NO VACÍOS");
                return (0, 0, 0, 0, 0);
            }
            int X_1 = Convert.ToInt32(a);
            int a_1 = Convert.ToInt32(b);
            int b_1 = Convert.ToInt32(c);
            int c_1 = Convert.ToInt32(d);
            int d_1 = Convert.ToInt32(e);
            if (
                X_1 <= 0 || a_1 <= 0 || b_1 <= 0 || c_1 <= 0 || d_1 <= 0)

            {
                MessageBox.Show("Los números tienen que ser Mayor que cero, NO VACÍOS");
                return (0, 0, 0, 0, 0);
            }


            return (X_1, a_1, b_1, c_1, d_1);
        }
        public bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
