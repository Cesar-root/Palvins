namespace trabajoRey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa miEmpresa = new Empresa();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            miEmpresa.Clientes = int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miEmpresa.Clientes.ToString());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            miEmpresa.Nombre = textBox2.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miEmpresa.Nombre);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            miEmpresa.Venta = int.Parse(textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miEmpresa.Venta.ToString());

        }
    }
}
