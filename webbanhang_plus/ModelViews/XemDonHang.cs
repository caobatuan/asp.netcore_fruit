using System;
using System.Collections.Generic;
using webbanhang_plus.Models;

namespace webbanhang_plus.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
