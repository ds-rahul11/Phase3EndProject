using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Phase3Project.Model
{
    public partial class Seller
    {
        public int Id { get; set; }
        public string Sname { get; set; }
        public string Password { get; set; }
    }
}
