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
    public partial class IncomeForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aditya\OneDrive\Documents\expense1.mdf;Integrated Security=True;Connect Timeout=30";

        public IncomeForm()
        {
            InitializeComponent();

            displayCategyList();
            displayIncomeData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategyList();
            displayIncomeData();
        }

        public void displayIncomeData()
        {
            IncomeData iData = new IncomeData();
            List<IncomeData> listData = iData.incomeListData();

            dataGridView1.DataSource = listData;
        }

        public void displayCategyList()
        {
            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    income_category.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        income_category.Items.Add(reader["category"].ToString());
                    }
                }

                connect.Close();
            }
        }

        private void income_addBtn_Click(object sender, EventArgs e)
        {
            if(income_category.SelectedIndex == -1 || income_item.Text == "" 
                || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO income (category, item, income, description, date_income, date_insert) " +
                        "VALUES(@cat, @item, @income, @desc, @date_in, @date)";

                    using(SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", income_item.Text);
                        cmd.Parameters.AddWithValue("@income", income_income.Text);
                        cmd.Parameters.AddWithValue("@desc", income_description.Text);
                        cmd.Parameters.AddWithValue("@date_in", income_date.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connect.Close();
                }
            }
            displayIncomeData();
        }

        public void clearFields()
        {
            income_item.Text = "";
            income_category.SelectedIndex = -1;
            income_income.Text = "";
            income_description.Text = "";
        }
        private void income_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void income_updateBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == ""
                || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to Update ID: " + getID + "?"
                    , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE income SET category = @cat, item = @item, " +
                            "income = @income, description = @desc, date_income = @date_in WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", income_item.Text);
                            cmd.Parameters.AddWithValue("@income", income_income.Text);
                            cmd.Parameters.AddWithValue("@desc", income_description.Text);
                            cmd.Parameters.AddWithValue("@date_in", income_date.Text);
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }
                
            }
            displayIncomeData();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                income_category.SelectedItem = row.Cells[1].Value.ToString();
                income_item.Text = row.Cells[2].Value.ToString();
                income_income.Text = row.Cells[3].Value.ToString();
                income_description.Text = row.Cells[4].Value.ToString();
                DateTime parsedDate;
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out parsedDate))
                {
                    income_date.Value = parsedDate;
                }
            }
        }

        private void income_deleteBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == ""
                || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?"
                    , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string insertData = "DELETE FROM income WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
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
            displayIncomeData();
        }
    }
}
