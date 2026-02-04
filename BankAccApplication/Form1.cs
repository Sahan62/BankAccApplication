using System.Drawing.Imaging.Effects;

namespace BankAccApplication
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>(); //globale Variable, schreibe lieber groß
        public Form1()
        {
            InitializeComponent(); //

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            string input = OwnerTxt.Text;

            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;
            //MessageBox.Show("Testen von Events");
            if (!input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Der Name darf nur Buchstaben und Leerzeichen enthalten!");
                OwnerTxt.Clear();
                return;
            }

            BankAccount bankaccount = new BankAccount(OwnerTxt.Text);
            BankAccounts.Add(bankaccount);
            RefreshGrid();
            OwnerTxt.Clear();

        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null; //clear grid
            BankAccountsGrid.DataSource = BankAccounts; //set new data source for grid
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0) // nur dann einzahlung möglich
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);


            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0) // nur dann Auszahlung möglich
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Withdraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);

            }
        }
    }
}
