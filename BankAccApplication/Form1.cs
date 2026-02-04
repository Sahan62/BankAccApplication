namespace BankAccApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //
                         
            BankAccount account = new BankAccount("Sahan Dogan"); //creatinng new Object
 
            BankAccount account2 = new BankAccount("Cristiano Ronaldo"); //creatinng new Object
          
            BankAccount account3 = new BankAccount("Lionel Messi"); //creatinng new Object
           

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
