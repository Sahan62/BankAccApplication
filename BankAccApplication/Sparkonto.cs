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
        public override string Deposit(decimal amount)
        {
            if (amount <= 0) return "Der Betrag kann nicht eingezahlt werden. Ungültige Eingabe";

            if (amount > 20000) return "Zu hoher Einzahlungs-Betrag für Automaten! Bitte an das Personal wenden";

            decimal Zinsen = (Zinssatz / 100) * amount;
            Balance += amount + Zinsen;
            return "Einzahlung erfolgreich.";
        }
    }
}
