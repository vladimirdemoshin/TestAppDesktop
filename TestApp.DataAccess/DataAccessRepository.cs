using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.IO;
using System.Data;
using TestApp.Contract;
using System.Xml.Linq;

namespace TestApp.DataAccess
{
    public class DataAccessRepository
    {
        public static string DBFileName = @"..\..\..\TestAppDB.sqlite";
        public SQLiteConnection DBConnection = new SQLiteConnection("Data Source=" + DBFileName);
        public SQLiteCommand SQLCommand = new SQLiteCommand();

        public List<Item_dc> GetItems()
        {
            List<Item_dc> result = new List<Item_dc>();
            try
            {
                DBConnection.Open();
                SQLCommand.Connection = DBConnection;
                string sqlQuery = "SELECT * FROM Item";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, DBConnection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    var currentRow = dataTable.Rows[i];
                    result.Add(new Item_dc(currentRow["ItemID"].ToString(), currentRow["Description"].ToString(), Int32.Parse(currentRow["Price"].ToString())));
                }
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                DBConnection.Close();
            }
        }

        public bool AddItem(String itemID, String description, int price)
        {
            try
            {
                DBConnection.Open();
                SQLCommand.Connection = DBConnection;
                string sqlQuery = String.Format("INSERT INTO Item VALUES('{0}','{1}',{2})", itemID, description, price);
                SQLCommand.CommandText = sqlQuery;
                SQLCommand.ExecuteScalar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                DBConnection.Close();
            }
        }

        public bool DeleteItem(string ItemID)
        {
            try
            {
                DBConnection.Open();
                SQLCommand.Connection = DBConnection;
                string sqlQuery = String.Format("DELETE FROM Item WHERE ItemID = '{0}'", ItemID);
                SQLCommand.CommandText = sqlQuery;
                SQLCommand.ExecuteScalar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                DBConnection.Close();
            }
        }

        public bool CreateTransaction(List<Item_dc> basket)
        {
            string dateTime = DateTime.Now.ToString();

            var xmlItems = new List<XElement>();
            foreach(var item in basket)
            {
                xmlItems.Add(new XElement("Item", new XAttribute("ItemID", item.ItemID),
                   new XAttribute("Description", item.Description), new XAttribute("Price", item.Price)));
            }
            XElement xmlTransaction = new XElement("Transaction", xmlItems);
            string description = xmlTransaction.ToString();

            int total = 0;
            foreach (var item in basket)
                total += item.Price;

            try
            {
                DBConnection.Open();
                SQLCommand.Connection = DBConnection;
                string sqlQuery = String.Format("INSERT INTO TransactionRepository (DateTime, Description, Total) VALUES ('{0}','{1}',{2})", dateTime, description, total);
                SQLCommand.CommandText = sqlQuery;
                SQLCommand.ExecuteScalar();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                DBConnection.Close();
            }
        }

    }
}
