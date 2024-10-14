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
            (int X_1,int a,int b,int c, int m)=validaciones(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            //Paso2: llamar a Algoritmo
            GeneradorAleatorios generador = new GeneradorAleatorios();
            
            List<int> listaleatoria = new List<int>();
            if ((X_1, a, b, c, m) != (0, 0, 0, 0, 0))
            {
                (List<List<float>> matrizResultados, float media) resultado = generador.MonteCarloSimulation(a, b, m, c);
                MessageBox.Show(resultado.media.ToString());
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
        public void llenarGrid(List<List<float>> lista,int X_1)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";
            string numeroColumna5 = "5";
            string numeroColumna6 = "6";



            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "iteración");
            dataGridView1.Columns.Add(numeroColumna2, "Panel 1 ");
            dataGridView1.Columns.Add(numeroColumna3, "Panel 2 ");
            dataGridView1.Columns.Add(numeroColumna4, "Panel 3 ");
            dataGridView1.Columns.Add(numeroColumna5, "Panel 4 ");
            dataGridView1.Columns.Add(numeroColumna6, "Panel 5 ");

            
            for (int i = 1; i < lista.Count+1; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = (lista[i - 1][1]).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = (lista[i - 1][2]).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = (lista[i - 1][3]).ToString();
                //dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna5) - 1].Value = (lista[i - 1][4]).ToString();
                //dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna6) - 1].Value = (lista[i - 1][5]).ToString();


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
        public (int X_1, int a, int b,int c, int d) validaciones(string a, string b, string c,string d, string e)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || string.IsNullOrEmpty(c) || string.IsNullOrEmpty(d) || string.IsNullOrEmpty(e))
            {
                MessageBox.Show("Los números tienen que ser Mayor que cero, NO VACÍOS");
                return (0,0,0,0,0);
            }
            int X_1 = Convert.ToInt32(a);
            int a_1 = Convert.ToInt32(b);
            int b_1 = Convert.ToInt32(c);
            int c_1 = Convert.ToInt32(d);
            int d_1 = Convert.ToInt32(e);
            if (
                X_1 <=0||a_1<=0|| b_1 <= 0 || c_1 <= 0|| d_1 <= 0 )
     
            {
                MessageBox.Show("Los números tienen que ser Mayor que cero, NO VACÍOS");
                return (0,0,0,0,0);
            }
            
           
            return (X_1, a_1, b_1,c_1,d_1);
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
    }
}
