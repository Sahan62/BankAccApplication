namespace BankAccApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccBtn = new Button();
            label3 = new Label();
            ZinssatzNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ZinssatzNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 62);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 452);
            label2.Name = "label2";
            label2.Size = new Size(122, 38);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Font = new Font("Segoe UI", 12F);
            OwnerTxt.Location = new Point(195, 66);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(216, 34);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Font = new Font("Segoe UI", 12F);
            AmountNum.Location = new Point(195, 455);
            AmountNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(216, 34);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(464, 62);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(452, 380);
            BankAccountsGrid.TabIndex = 4;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(464, 455);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(216, 63);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(700, 455);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(216, 63);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateAccBtn
            // 
            CreateAccBtn.Location = new Point(195, 208);
            CreateAccBtn.Name = "CreateAccBtn";
            CreateAccBtn.Size = new Size(216, 63);
            CreateAccBtn.TabIndex = 7;
            CreateAccBtn.Text = "Create account";
            CreateAccBtn.UseVisualStyleBackColor = true;
            CreateAccBtn.Click += CreateAccBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(85, 130);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 8;
            label3.Text = "Zinssatz (%):";
            label3.Click += label3_Click;
            // 
            // ZinssatzNum
            // 
            ZinssatzNum.Font = new Font("Segoe UI", 10F);
            ZinssatzNum.Location = new Point(276, 130);
            ZinssatzNum.Name = "ZinssatzNum";
            ZinssatzNum.Size = new Size(135, 30);
            ZinssatzNum.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 530);
            Controls.Add(ZinssatzNum);
            Controls.Add(label3);
            Controls.Add(CreateAccBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ZinssatzNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccBtn;
        private Label label3;
        private NumericUpDown ZinssatzNum;
    }
}
