using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionsManager.Services
{
    public class TransactionsSearchCriteria
    {
        public bool? IsFraud { get; set; }
        public string SearchNameDest { get; set; }
    }
}
