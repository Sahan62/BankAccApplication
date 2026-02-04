using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccApplication
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid accountNumber { get; set; } //globally unique identifier, unique id zum benutzen der AccountNr
        public decimal Balance  { get; set; }
    }
}
