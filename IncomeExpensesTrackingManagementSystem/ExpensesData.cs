using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeExpensesTrackingManagementSystem
{
    class ExpensesData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aditya\OneDrive\Documents\expense1.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string Category { set; get; }
        public string Item { set; get; }
        public string Cost { set; get; }
        public string Description { set; get; }
        public string DateIncome { set; get; }

        public List<ExpensesData> expensesListData()
        {
            List<ExpensesData> listData = new List<ExpensesData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM expenses";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ExpensesData eData = new ExpensesData();
                        eData.ID = (int)reader["id"];
                        eData.Category = reader["category"].ToString();
                        eData.Item = reader["item"].ToString();
                        eData.Cost = reader["cost"].ToString();
                        eData.Description = reader["description"].ToString();
                        eData.DateIncome = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy");

                        listData.Add(eData);
                    }
                }
            }
            return listData;
        }
    }
}
