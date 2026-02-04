using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccApplication
{
    public class BankAccount
    {
        public string owner { get; set; }
        public Guid accountNumber { get; set; } //globally unique identifier, unique id zum benutzen der AccountNr
        public decimal Balance  { get; set; }

        public BankAccount(string owner) //Konstruktor
        {
            this.owner = owner; // Owner zugewiesen in Klasse form
            accountNumber = Guid.NewGuid(); // für jedes neue Object der Klasse Bankaccout wird neue ID erstellt
            Balance = 0; // Bei Kontoerstellung --> Kontoguthaben = 0
        }
    }
}
