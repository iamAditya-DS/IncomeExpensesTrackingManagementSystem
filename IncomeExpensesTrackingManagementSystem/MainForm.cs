using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpensesTrackingManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            displayUsername();
        }

        public void displayUsername()
        {
            string getUsername = Form1.username;

            greetUser.Text = "Welcome, " + getUsername.Substring(0, 1).ToUpper() + getUsername.Substring(1);
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;

            DashboardForm dForm = dashboardForm1 as DashboardForm;

            if(dForm != null)
            {
                dForm.refreshData();
            }
        }

        private void addCategory_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = true;
            incomeForm1.Visible = false;
            expensesForm1.Visible = false;

            CategoryForm cForm = categoryForm1 as CategoryForm;

            if (cForm != null)
            {
                cForm.refreshData();
            }
        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = true;
            expensesForm1.Visible = false;

            IncomeForm iForm = incomeForm1 as IncomeForm;

            if (iForm != null)
            {
                iForm.refreshData();
            }
        }

        private void expenses_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expensesForm1.Visible = true;

            ExpensesForm eForm = expensesForm1 as ExpensesForm;

            if (eForm != null)
            {
                eForm.refreshData();
            }
        }
    }
}


// THATS IT FOR THIS VIDEO, THANKS FOR WATCHING!! 

// JOIN TO OUR MEMBERSHIP TO GET THIS PROJECT !!
// THANK YOU! : ) 