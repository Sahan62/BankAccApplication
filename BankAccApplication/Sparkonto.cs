using System;
using System.Collections.Generic;
using System.Text;
// Sparkonto hat die selben Objekte und Methoden wie normales Bankkonto --> Vererbung
namespace BankAccApplication
{
    public class Sparkonto:BankAccount
    {
        public decimal Zinssatz {  get; set; }

        public Sparkonto(string owner, decimal Zinssatz):base(owner + " (" + Zinssatz + "%)")
        {
            this.Zinssatz = Zinssatz;

        }
    }
}
