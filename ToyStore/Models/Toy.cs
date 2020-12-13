using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToyStore.Models
{
    public class Toy
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Firm { get; set; }
        public int Price { get; set; }
    }
}