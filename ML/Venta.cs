using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Venta
    {
        public string NombreProducto { set; get; }
        public int Cantidad { set; get; }

        public decimal Total { set; get; }

        public DateTime VentaHora { set; get; }

        public Producto Producto { set; get; }

        public List<object> Ventas { set; get; }
    }
}
