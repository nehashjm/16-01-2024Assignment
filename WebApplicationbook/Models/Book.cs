using System;
using System.Collections.Generic;

namespace WebApplicationbook.Models
{
    public partial class Book
    {
        public int Bookid { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? Category { get; set; }
        public int? Price { get; set; }
    }
}
