using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Producto
    {

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.VentasAntojitosEntities1 context = new DL.VentasAntojitosEntities1())
                {
                    var query = context.ProductoGetAll().ToList();
                    if (query != null)
                    {
                        result.Correct = true;

                        result.Objects = new List<object>();


                        foreach (var ob in query)
                        {
                            ML.Producto producto = new ML.Producto();

                            producto.IdProducto = ob.IdProducto;
                            producto.Nombre = ob.Nombre;
                            producto.precio = ob.Precio.Value;

                            result.Objects.Add(producto);
                        }
                    }
                    else
                    {
                        result.Correct = false;
                    }


                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }



            return result;

        }
    }
}
