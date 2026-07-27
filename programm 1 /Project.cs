using System;
using System.Collections.Generic;

namespace programm_1;
{
    public class Project
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Pname { get; set; }
        public string Plocation {get; set;}
        public int Dnum   { get; set; }//////
    }
}
