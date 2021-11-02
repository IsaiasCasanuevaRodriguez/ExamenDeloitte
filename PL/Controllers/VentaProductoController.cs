using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class VentaProductoController : Controller
    {
        
         [HttpGet]
        public ActionResult GetAll()
        {
            ML.Result result = BL.Venta.GetAll();


            if(result.Correct)
            {

                ML.Venta venta = new ML.Venta();

                venta.Ventas = result.Objects;

                return View(venta);
            }
            else
            {
                ML.Venta venta = new ML.Venta();

                return View(venta);
            }
            

        }

           [HttpGet]
        public ActionResult Formulario()
        {
    

            return View();

        }
         [HttpPost]
        public ActionResult Formulario(ML.Venta venta)
        {

            ML.Result result = BL.Venta.Add(venta);

             if(result.Correct)
             {

                 return View();

             }
             else
             {
                 ViewBag.Message = "Error al guardar el producto ";
                 return PartialView();
             }
            return View();

        }


        //
        // GET: /VentaProducto/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /VentaProducto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /VentaProducto/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /VentaProducto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /VentaProducto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /VentaProducto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /VentaProducto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /VentaProducto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
