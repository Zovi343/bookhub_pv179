﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs.PurchaseHistory
{
    public class PurchaseHistoryCreateUpdateDTO
    {
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
