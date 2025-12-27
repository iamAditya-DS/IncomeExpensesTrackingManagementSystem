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
    public partial class ExpensesForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aditya\OneDrive\Documents\expense1.mdf;Integrated Security=True;Connect Timeout=30";

        public ExpensesForm()
        {
            InitializeComponent();

            displayCategyList();
            displayExpenseData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategyList();
            displayExpenseData();
        }

        public void displayExpenseData()
        {
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.expensesListData();

            dataGridView1.DataSource = listData;
        }

        public void displayCategyList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Expenses");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    expense_category.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        expense_category.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
            }
        }

        private void income_addBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == ""
                || expense_cost.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO expenses (category, item, cost, description, date_expense, date_insert) " +
                        "VALUES(@cat, @item, @cost, @desc, @date_ex, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", expense_item.Text);
                        cmd.Parameters.AddWithValue("@cost", expense_cost.Text);
                        cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                        cmd.Parameters.AddWithValue("@date_ex", expense_date.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connect.Close();
                }
            }
            displayExpenseData();
        }

        public void clearFields()
        {
            expense_item.Text = "";
            expense_category.SelectedIndex = -1;
            expense_cost.Text = "";
            expense_description.Text = "";
        }

        private void expense_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void expense_updateBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == ""
                || expense_cost.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE expenses SET category = @cat, item = @item" +
                            ", cost = @cost, description = @desc, date_expense = @date_ex WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", expense_item.Text);
                            cmd.Parameters.AddWithValue("@cost", expense_cost.Text);
                            cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                            cmd.Parameters.AddWithValue("@date_ex", expense_date.Value);
                            cmd.Parameters.AddWithValue("@id", getID);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        connect.Close();
                    }
                }
            }
            displayExpenseData();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                expense_category.SelectedItem = row.Cells[1].Value.ToString();
                expense_item.Text = row.Cells[2].Value.ToString();
                expense_cost.Text = row.Cells[3].Value.ToString();
                expense_description.Text = row.Cells[4].Value.ToString();
                DateTime parsedDate;
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out parsedDate))
                {
                    expense_date.Value = parsedDate;
                }
            }
        }

        private void expense_deleteBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == ""
                || expense_cost.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM expenses WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        connect.Close();
                    }
                }
            }
            displayExpenseData();
        }
    }
}
