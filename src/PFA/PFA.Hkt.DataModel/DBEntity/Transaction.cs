﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
   public class Transaction :BaseEntity
    {
       public DateTime Date { get; set; }
       public Guid ReferenceId { get; set; }
       public Guid CategoryId { get; set; }
       public string Description { get; set; }
       public Guid AccountId { get; set; }
       public string Type { get; set; }
       public double Amount { get; set; }
       public string Payee { get; set; }
       public string Note { get; set; }
       public Guid ParentId { get; set; }
       public bool IsSplitTransaction { get; set; }
       public string TxSource { get; set; }
    }
}
