using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BankAccount b = new BankAccount();
            b.Deposit(100.3);
            MessageBox.Show(b.ToString());



            MessageBox.Show(b.showBalance());
            b.Deposit(-10.0);
            MessageBox.Show(b.showBalance());
            b.Deposit((Decimal)100.3);
            MessageBox.Show(b.showBalance());
            MessageBox.Show(b.ToString());
        }
    }
}
