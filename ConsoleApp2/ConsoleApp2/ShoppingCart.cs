﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnitoo3.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public double Sum { get; set; }
        public DateTime DateCreated { get; set; }


        public virtual ICollection<Food> Items { get; set; }

        public ShoppingCart()
        {
                
        }

        public ShoppingCart(double sum)
        {
            Id= Guid.NewGuid();
            Items = new List<Food>();
            Sum = sum;
            DateCreated= DateTime.Now;
           
        }
    }
}
