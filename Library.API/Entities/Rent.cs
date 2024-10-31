using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Entities.Base;

namespace Library.API.Entities
{
    public class Rent : Thing
    {
        public DateTime RentTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public Book? Book { get; set; }
        public Member? Member { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
    }
}