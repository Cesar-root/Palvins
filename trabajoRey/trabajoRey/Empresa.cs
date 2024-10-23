using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoRey
{
    internal class Empresa
    {
        private int _intEmpleados;
        public int Empleados 
        {
            get { return _intEmpleados; }
            set { _intEmpleados = value; }
        }
        
       private List<Producto> _listaDeProductos = new List<Producto>();
       private List<Clientes> _listaDeClientes = new List<Clientes>();

        public void IngresarProductos(Producto nuevoProducto) 
        {
             _listaDeProductos.Add(nuevoProducto);
        }
        public void InsertarCliente(Clientes nuevoCliente) 
        {
            _listaDeClientes.Add(nuevoCliente);
        }
        IEnumerable<Producto> IteradorProductos() 
        {
            foreach(Producto unProducto in _listaDeProductos) 
            {
                _listaDeProductos.GetEnumerator();
            }
            return _listaDeProductos;
        }
        IEnumerable<Clientes> IteradorClientes()
        {
            foreach (Clientes unCliente in _listaDeClientes)
            {
                _listaDeClientes.GetEnumerator();
            }
            return _listaDeClientes;
        }
        ~Empresa() 
        {
            _listaDeClientes.Clear();
            _listaDeProductos.Clear();
        }

    }
}
