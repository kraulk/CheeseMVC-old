﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int CheeseId
        {
            get;
            set;
        }
        private static int nextId = 1;


        public Cheese(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Cheese()
        {
            CheeseId = nextId;
            nextId++;
        }
    }
}
