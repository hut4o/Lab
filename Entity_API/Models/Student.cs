﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_API.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Msv { get; set; }
        public int NamSinh { get; set; }
        public string NganhHoc { get; set; }
    }
}
