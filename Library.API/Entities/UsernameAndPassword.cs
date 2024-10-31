using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Entities.Base;

namespace Library.API.Entities
{
    public class UsernameAndPassword :Thing
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}