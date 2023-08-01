using System;
using System.Collections.Generic;
using webbanhang_plus.Models;

namespace webbanhang_plus.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
