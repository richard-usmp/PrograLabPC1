using System;
using System.ComponentModel.DataAnnotations;

namespace PrograLabPC1.Models
{

    public class Factura{
        [Key]
        public int id {get; set;}
        public String Name {get; set;}
        public String Producto {get; set;}
        /*
        [DataType(DataType.Date)]
        public DateTime Date {get; set;}
        */
        public int Cantidad {get; set;}
        public int Subtotal{get; set;}
        public double Total{get; set;}
    }

}