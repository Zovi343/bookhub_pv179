﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs.Author
{
    public class AuthorWithoutBooksDTO : BaseDTO
    {
        public string Name { get; set; }
    }
}