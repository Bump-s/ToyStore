using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ToyStore.Models
{
    public class ToyDbInitializer:DropCreateDatabaseAlways<ToyContext>
    {
        protected override void Seed(ToyContext db)
        {
            db.Toys.Add(new Toy { Title = "Покемон", Firm = "7toys", Price = 200 });
            db.Toys.Add(new Toy { Title = "Пистолет", Firm = "GameTrue", Price = 500 });
            db.Toys.Add(new Toy { Title = "Лизун", Firm = "7toys", Price = 145 });

            base.Seed(db);
        }
    }
}