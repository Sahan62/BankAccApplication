namespace BankAccApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //
                         
            BankAccount account = new BankAccount(); //creatinng new Object
            account.Owner = "Sahan Dogan";
            account.accountNumber = Guid.NewGuid();
            account.Balance = 500;

            BankAccount account2 = new BankAccount(); //creatinng new Object
            account2.Owner = "Cristiano Ronaldo";
            account2.accountNumber = Guid.NewGuid();
            account2.Balance = 999;

            BankAccount account3 = new BankAccount(); //creatinng new Object
            account3.Owner = "Lionel Messi";
            account3.accountNumber = Guid.NewGuid();
            account3.Balance = 1000;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(account);
            bankAccounts.Add(account2);
            bankAccounts.Add(account3);

            BankAccountsGrid.DataSource = bankAccounts;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
