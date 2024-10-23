namespace trabajoRey
{
    public partial class Form1 : Form
    {
        Empresa miEmpresa = new Empresa();
        Clientes miCliente = new Clientes();
        Producto miProducto = new Producto();
        public Form1()
        {
            InitializeComponent();
            dtgTablaClientes.ReadOnly = true;
            dtgTablaObjetios.ReadOnly = true;
            dtgTablaClientes.Columns.Add("Nombre", "Nombre");
            dtgTablaObjetios.Columns.Add("Cosa", "Cosa");
            dtgTablaObjetios.AllowUserToAddRows = false;
            dtgTablaClientes.AllowUserToAddRows = false;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturarEmpledos_Click(object sender, EventArgs e)
        {
            miEmpresa.Empleados = int.Parse(txtEmpleados.Text);
            MessageBox.Show("Datos capturados correctamente");
        }

        private void btnCapturarClientes_Click(object sender, EventArgs e)
        {
            miCliente.Numero = int.Parse(txtClientes.Text):
              MessageBox.Show("Datos capturados correctamente");
        }

        private void btnCapturarObjeto_Click(object sender, EventArgs e)
        {
            miProducto.Nombre = txtObjeto.Text;
            MessageBox.Show("Datos capturados correctamente");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        { 
            
            miEmpresa.InsertarCliente(miCliente);
            miEmpresa.IngresarProductos(miProducto);

            
        }
    }
}
