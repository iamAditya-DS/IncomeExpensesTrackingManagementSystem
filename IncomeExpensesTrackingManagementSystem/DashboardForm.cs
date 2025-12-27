using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IncomeExpensesTrackingManagementSystem
{
    public partial class DashboardForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aditya\OneDrive\Documents\expense1.mdf;Integrated Security=True;Connect Timeout=30";

        public DashboardForm()
        {
            InitializeComponent();

            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            incometotalIncome();

            expensesTodayIncome();
            expensesYesterdayIncome();
            expensesThisMonth();
            expensesThisYear();
            expensestotalExpenses();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            incometotalIncome();

            expensesTodayIncome();
            expensesYesterdayIncome();
            expensesThisMonth();
            expensesThisYear();
            expensestotalExpenses();
        }

        // INCOME 

        public void incomeTodayIncome()
        {
            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE date_income = @date_in";

                using(SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);

                    object result = cmd.ExecuteScalar();

                    if(result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        income_totalIncome.Text = todayCost.ToString("C");
                    }
                    else
                    {
                        income_totalIncome.Text = "₹0.00";
                    }
                }
            }
        }

        public void incomeYesterdayIncome()
        {
            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";

                using(SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if(result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        income_yesterdayIncome.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        income_yesterdayIncome.Text = "₹0.00";
                    }
                }
            }
        }

        public void incomeThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <= @endMonth";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);

                        income_thisMonthIncome.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        income_thisMonthIncome.Text = "₹0.00";
                    }
                }
            }
        }

        public void incomeThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);

                        income_thisYearIncome.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        income_thisYearIncome.Text = "₹0.00";
                    }
                }
            }
        }

        public void incometotalIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);

                        totalIncome.Text = totalCost.ToString("C");
                    }
                    else
                    {
                        expense_today.Text = "₹0.00";
                    }
                }
            }
        }

        // EXPENSES

        public void expensesTodayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense = @date_ex";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_ex", today);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        expense_today.Text = todayCost.ToString("C");
                    }
                    else
                    {
                        expense_today.Text = "₹0.00";
                    }
                }
            }
        }

        public void expensesYesterdayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE CONVERT(DATE, date_expense) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        expense_yesterday.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        expense_yesterday.Text = "₹0.00";
                    }
                }
            }
        }

        public void expensesThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startMonth AND date_expense <= @endMonth";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);

                        expense_thisMonth.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        expense_thisMonth.Text = "₹0.00";
                    }
                }
            }
        }

        public void expensesThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startYear AND date_expense <= @endYear";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);

                        expense_thisYear.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        expense_thisYear.Text = "₹0.00";
                    }
                }
            }
        }

        public void expensestotalExpenses()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);

                        totalExpenses.Text = totalCost.ToString("C");
                    }
                    else
                    {
                        expense_today.Text = "₹0.00";
                    }
                }
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void income_thisMonthIncome_Click(object sender, EventArgs e)
        {

        }
    }
}
