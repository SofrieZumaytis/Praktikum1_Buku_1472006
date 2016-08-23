using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Praktikum1_Buku_1472006.Models
{
    public class AppDataContext : DbContext
    {
        public DbSet<Book> DaftarBuku { get; set; }
    }
}