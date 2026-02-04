using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccApplication
{
    public class BankAccount
    {
        public string owner { get; set; }
        public Guid accountNumber { get; set; } //globally unique identifier, unique id zum benutzen der AccountNr
        public decimal Balance { get; protected set; } //Balance kann ohne weiters gelesen werden, aber Änderung nur möglich innerhalb Klasse, oder in child Klassen

        public BankAccount(string owner) //Konstruktor
        {
            this.owner = owner; // Owner zugewiesen in Klasse form
            accountNumber = Guid.NewGuid(); // für jedes neue Object der Klasse Bankaccout wird neue ID erstellt
            Balance = 0; // Bei Kontoerstellung --> Kontoguthaben = 0
        }

        public virtual string Deposit(decimal amount) //virtual, child kann seine Version dieser funktion nutzen
        {
            if (amount <= 0) return "Der Betrag kann nicht eingezahlt werden. Ungültige Eingabe";

            if (amount > 20000) return "Zu hoher Einzahlungs-Betrag für Automaten! Bitte an das Personal wenden";

            Balance += amount;
            return "Einzahlung erfolgreich.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0) return "Der Betrag kann nicht ausgezhalt werden. Ungültige Eingabe";

            if (amount > Balance) return "Auszahlung nicht möglich. Zu wenig Kontoguthaben";

            Balance -= amount;
            return "Auszahlung erfolgreich.";

        }
    }
}
