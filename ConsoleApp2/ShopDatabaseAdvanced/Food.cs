﻿using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabaseAdvanced.Models
{
    public class Food
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

      
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
         public Food()
        {

        }
      

        public Food(string name, double price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
           
        }

        public double CalculateSum(Food food, double a)
        {
            double sum = 0;
            sum = food.Price * a;
            return sum;
        }




    }
}
