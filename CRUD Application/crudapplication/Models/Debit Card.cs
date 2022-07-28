using System;

namespace crudapplication.Models
{
    public class Debit_Card
    {
       
        public long CardNo { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}