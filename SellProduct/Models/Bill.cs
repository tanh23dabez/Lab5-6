﻿using System.Collections.Generic;
using System;

namespace SellProduct.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid UserId { get; set; }
        public int Status { get; set; }
        public virtual ICollection<BillDetails> BillDetails { get; set; }
    }
}
