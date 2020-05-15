using quanly.data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace quanly.data.Entities
{
    public class Product
    {
        public int idProduct { get; set; }
        public string NameProduct { get; set; }
        public Status Status { get; set; }
    }
}
