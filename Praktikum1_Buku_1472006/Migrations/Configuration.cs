namespace Praktikum1_Buku_1472006.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Praktikum1_Buku_1472006.Models.AppDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Praktikum1_Buku_1472006.Models.AppDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.DaftarBuku.AddOrUpdate(i => i.Title,
                new Models.Book { Title = "Bodrex", ISBN = "123456", Year = 2016, Author = "aaa", Publisher = "lalala" },
                new Models.Book { Title = "Bodrex2", ISBN = "1234567", Year = 2026, Author = "aaa2", Publisher = "2lalala" }
                );
            //
        }
    }
}
