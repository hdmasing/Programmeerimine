﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proge1
{
    public class Food
    {
            public string Name { get; set; }
            public double Price { get; set; }

            public Food(string name, double price)
            {
                this.Name = name;
                this.Price = price;

            }
        }
    }

