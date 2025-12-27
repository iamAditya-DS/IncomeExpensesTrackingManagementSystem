using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeExpensesTrackingManagementSystem
{
    class IncomeData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aditya\OneDrive\Documents\expense1.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string Category { set; get; }
        public string Item { set; get; }
        public string Cost { set; get; }
        public string Description { set; get; }
        public string DateIncome { set; get; }

        public List<IncomeData> incomeListData()
        {
            List<IncomeData> listData = new List<IncomeData>();

            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM income";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();
                        iData.ID = (int)reader["id"];
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Cost = reader["income"].ToString();
                        iData.Description = reader["description"].ToString();
                        iData.DateIncome = ((DateTime)reader["date_income"]).ToString("MM-dd-yyyy");

                        listData.Add(iData);

                    }
                }
            }
            return listData;
        }
    }
}
