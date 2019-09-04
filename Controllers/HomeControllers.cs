using System;
using Microsoft.AspNetCore.Mvc;
using PrograLabPC1.Models;

namespace Practica.Controllers
{

    public class HomeController:Controller{

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();
        }
        
        [HttpPost]
        public IActionResult calculo(Factura cli){
            Console.WriteLine("Calculo");  
            Random rnd = new Random(); 
            int cantidad= cli.Cantidad;        
            int sTotal=0;
            double total=0;

            //calculo total
            if(cli.Producto.Equals("p1")){
                sTotal=100 * cantidad;
                total = sTotal * 1.18;
            }else if(cli.Producto.Equals("p2")){
                sTotal=50 * cantidad;
                total = sTotal * 1.18;
            }else if(cli.Producto.Equals("p3")){
                sTotal=80 * cantidad;
                total = sTotal * 1.18;
            }   

            //aleatorio
            cli.id = rnd.Next(100000, 999999);
            
            cli.Subtotal= sTotal;
            cli.Total = total;

            _context.Add(cli);
            _context.SaveChanges();
            return View(cli);
        }
    }

}