using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Venta
    {

        public static ML.Result Add(ML.Venta venta)
       {
           ML.Result result = new ML.Result();
           try
           {
               using(DL.VentasAntojitosEntities1 context = new DL.VentasAntojitosEntities1())
               {
                   var query = context.VentaAdd(venta.NombreProducto, venta.Cantidad,venta.Total);
                   if(query > 0)
                   {
                       result.Correct = true;
                   }else{
                        result.Correct = false;
                   }


               }

           }catch(Exception ex)
           {
               result.Correct = false;
               result.ErrorMessage = ex.Message;
           }



           return result;

       }


        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.VentasAntojitosEntities1 context = new DL.VentasAntojitosEntities1())
                {
                    var query = context.VentaGetAll().ToList();
                    if (query != null)
                    {
                        result.Correct = true;

                        result.Objects = new List<object>();


                        foreach(var ob in query)
                        {
                            ML.Venta venta = new ML.Venta();

                            venta.NombreProducto = ob.NombreProducto;
                            venta.Cantidad = ob.Cantidad.Value;
                            venta.Total = ob.Total.Value;
                            venta.VentaHora = ob.VentaHora.Value;

                            result.Objects.Add(venta);
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
