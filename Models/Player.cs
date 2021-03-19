using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication27.Models
{
    public partial class Player
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Pteam { get; set; }
        public string Pcountry { get; set; }
    }
}
