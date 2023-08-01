using System;
using System.Collections.Generic;

#nullable disable

namespace webbanhang_plus.Models
{
    public partial class RegisterViewModel
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
