using EjercicioEnClase2.Models;
using EjercicioEnClase2.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioEnClase2.Controllers
{
    public class ProductoController : Controller
    {
        // GET: ProductoController
        public IActionResult Index()
        {
            return View(Util.Utils.ListaProducto);
        }

        // GET: ProductoController/Details/5
        public IActionResult Details(int id)
        {
            Producto producto = Utils.ListaProducto.Find(x => x.Id == id);
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Producto producto)
        {
            int id=Utils.ListaProducto.Count()+1;
            producto.Id = id;
            Utils.ListaProducto.Add(producto);
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Edit/5
        public IActionResult Edit(int Id)
        {
            Producto producto = Utils.ListaProducto.Find(x => x.Id == Id);
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index");
            
        }
        [HttpPost]
        public IActionResult Edit(Producto updatedProducto)
        {
            // Find the original producto with the same Id in your list.
            Producto originalProducto = Utils.ListaProducto.Find(x => x.Id == updatedProducto.Id);

            // Check if the original producto exists.
            if (originalProducto != null)
            {
                // Update the properties of the original product with the properties of the updated product.
                originalProducto.Nombre = updatedProducto.Nombre; // Replace with actual property names
                originalProducto.Descripcion = updatedProducto.Descripcion; // Replace with actual property names
                originalProducto.Cantidad = updatedProducto.Cantidad; // Replace with actual property names
                // Redirect to the Index action after successfully updating the product.
                return RedirectToAction("Index");
            }

            // If the original producto with the given Id does not exist, redirect to the Index action.
            return RedirectToAction("Index");

        }


        // GET: ProductoController/Delete/5
        public IActionResult Delete(int Id)
        {
            Producto producto = Utils.ListaProducto.Find(x => x.Id == Id);
            if(producto != null)
            {
                Utils.ListaProducto.Remove(producto);
            }
            return RedirectToAction("Index");
        }


    }
}
