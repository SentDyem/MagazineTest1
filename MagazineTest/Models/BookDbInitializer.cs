using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagazineTest.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Учим C# с примерами", Author = "Б. Гейтс", Price = 2590 });
            db.Books.Add(new Book { Name = "Apple. История развития", Author = "С. Джобс", Price = 990 });
            db.Books.Add(new Book { Name = "Всемирная паутина - Google", Author = "Л. Пейдж", Price = 3990 });

            base.Seed(db);
        }
    }
}