using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Entities.Base;

namespace Library.API.Entities
{
    public class Book : Thing
    {
        public string? Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
}