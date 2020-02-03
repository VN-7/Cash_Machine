using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6
{
    public partial class FrmCashMachine : Form
    {
        String enteredNumbers;
        Boolean inputPermitted, withdrawing, receipt, returnAccount;//it will allow the vallues to be entered
        Account acc1, acc2, acc3, acc4, selectedAccount; 

        public FrmCashMachine()
        {
            InitializeComponent();
        }

        private void FrmCashMachine_Load(object sender, EventArgs e)
        {
            lbloutput.Text = "";/*it will clear out the values on the label*/
            inputPermitted = true;
            acc1 = new Account("1234", 8500);
            acc2 = new Account("4321", 12000);
            acc3 = new Account("5678", 25000);
            acc4 = new Account("8765", 50000);
        }
        private Account getAccount(String pin)//creating method
        {
            if (acc1.checkPin(pin)) 
            {
                return acc1;
            }
            if (acc2.checkPin(pin)) 
            {
                return acc2;
            }
            if (acc3.checkPin(pin)) 
            {
                return acc3;
            }
            if (acc4.checkPin(pin)) 
            {
                return acc4;
            }
            return null;
        }

        public void updateDisplay()/*this function will be called when different values are typed on the screen*/
        {
            lbloutput.Text = enteredNumbers;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = enteredNumbers + "9";
            updateDisplay();
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = enteredNumbers + "8";
            updateDisplay();
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = enteredNumbers + "7";
            updateDisplay();
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = enteredNumbers + "6";
            updateDisplay();
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = enteredNumbers + "5";
            updateDisplay();
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = enteredNumbers + "4";
            updateDisplay();
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = enteredNumbers + "3";
            updateDisplay();
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = enteredNumbers + "2";
            updateDisplay();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = enteredNumbers + "1";
            updateDisplay();
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = enteredNumbers + "0";
            updateDisplay();
        }

        private void cmdC_Click(object sender, EventArgs e)
        {
            if (inputPermitted == false)
            {
                return;
            }
            enteredNumbers = "";
            updateDisplay();
        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            if (selectedAccount == null)
            {
                selectedAccount = getAccount(enteredNumbers);
            }
            if (selectedAccount != null)
            {
                if (withdrawing == true)
                {
                    returnAccount = selectedAccount.withDraw(Int32.Parse(enteredNumbers));

                    if (returnAccount == true)
                    {
                        lbloutput.Text = "Transaction successful ";

                        if (receipt == true)
                        {
                            lbloutput.Text = lbloutput.Text + "\nLast transaction: " + selectedAccount.getLastTranscation();
                        }
                    }
                    else 
                    {
                        lbloutput.Text = "Insufficient funds";
                        withdrawing = false;
                        enteredNumbers = "";
                    }
                }
                else 
                {
                    lbloutput.Text = "Logged in - choose transcation";
                    enteredNumbers = "";
                }
            }
            else 
            {
                lbloutput.Text = "Invalid PIN ";
                enteredNumbers = "";
                inputPermitted = true;
            }
        }

        private void cmdBalance_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                lbloutput.Text = "Your balance is: " + selectedAccount.getBalance();
            }
            else
            {
                lbloutput.Text = "Enter PIN";
            }
        }

        private void cmdWithdraw_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                lbloutput.Text = "Enter amount";
                withdrawing = true;
                receipt = false;
                inputPermitted = true;
                enteredNumbers = "";
            }
            else 
            {
                lbloutput.Text = "Enter PIN";
            }
        }

        private void cmdReceipt_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                lbloutput.Text = "Enter amount";
                withdrawing = true;
                receipt = true;
                inputPermitted = true;
                enteredNumbers = "";
            }
            else 
            {
                lbloutput.Text = "Enter PIN";
            }
        }

        private void cmdDeny_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                lbloutput.Text = "Choose transaction";
                enteredNumbers = "";
                withdrawing = false;
            }
            else 
            {
                lbloutput.Text = "Enter PIN";
            }
        }
    }
}
