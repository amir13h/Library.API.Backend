using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Entities.Base;

namespace Library.API.Entities
{
    public class Member : Thing
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Phone { get; set; }
    }
}