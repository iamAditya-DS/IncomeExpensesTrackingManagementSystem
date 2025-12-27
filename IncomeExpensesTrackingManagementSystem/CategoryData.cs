using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeExpensesTrackingManagementSystem
{
    class CategoryData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aditya\OneDrive\Documents\expense1.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; } // 0
        public string Category { set; get; } // 1
        public string Type { set; get; } // 2
        public string Status { set; get; } // 3
        public string Date { set; get; } // 4

        public List<CategoryData> categoryListData()
        {
            List<CategoryData> listData = new List<CategoryData>();

            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoryData cData = new CategoryData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }
    }
}
