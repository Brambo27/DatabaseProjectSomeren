﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Gebruiker
    {
        public int Gebruiker_ID { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}