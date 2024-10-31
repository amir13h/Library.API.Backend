using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.API.DB
{
    public class LibraryDB2 : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<UsernameAndPassword> UsernamesAndPasswords { get; set; }
        public LibraryDB2(DbContextOptions options)
            :base(options)
        {
            
        }
    }
}