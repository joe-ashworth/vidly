﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    // POCO = Plain Old CLR Object
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // /movies/random
}