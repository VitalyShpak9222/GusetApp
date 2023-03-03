using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace GuestApp.DataBase
{
    internal class DataBaseUsersLink
    {
        private static SqlConnection SqlConnection_connection = null;

        public static void Connect() 
        {
            SqlConnection_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Key_BD_Users"].ConnectionString);
            SqlConnection_connection.Open();
        }

        public static void AddUsersInfo(string insert) 
        {
            SqlCommand command = new SqlCommand(insert, SqlConnection_connection);
            command.ExecuteNonQuery();
        }

        public static DataSet SELECT_Definite_DataBase(string select_info)
        {
            string select = $"SELECT * FROM Users WHERE Status LIKE N'%{select_info}%' ORDER BY Id";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select, SqlConnection_connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }


        public static DataSet SELECT_All_DataBase(string select_info) 
        {
            string select = $"SELECT * FROM Users WHERE * LIKE N'%{select_info}%' ORDER BY Id";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select, SqlConnection_connection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }

        public static int SELECT_CountUsers() 
        {
            string select = "SELECT COUNT(1) FROM Users";
            SqlCommand command = new SqlCommand(select, SqlConnection_connection);
            int CountColumn = (int)command.ExecuteScalar();
            return CountColumn;
        }

        //Дописать методы для получения индекса и списка индексов строк подошедших по критериям
        //(на входе столбец и значения для поиска в нем )
        //метод 1: вернуть индекс
        //метод 2: вернуть массив индексов
        //По соответствию вставить в методы обновления индекса

        public static void UpdateStatus() 
        {
            DateTime now = DateTime.Now;
            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            string update = $"UPDATE Users SET [Status] = N'Выписывается' WHERE [DateExit] = '{month}/{day}/{year}'";
            string update1 = $"UPDATE Users SET [Status] = N'Свободен' WHERE [DateExit] < '{month}/{day}/{year}'"; 
            string update2 = $"UPDATE Users SET [Status] = N'Занял' WHERE [DateExit] > '{month}/{day}/{year}' AND [DateStar] < '{month}/{day}/{year}'"; 
            string update3 = $"UPDATE Users SET [Status] = N'Зарезервировал' WHERE [DateStar] > '{month}/{day}/{year}'";
            string[] comands = { update, update1, update2, update3 };
            SqlCommand command;
            for (int i = 0; i < comands.Count(); i++)
            {
                command = new SqlCommand(comands[i], SqlConnection_connection);
                command.ExecuteNonQuery();
            }
        }

        // методы обновленя индеса/ов
        //----------------------------------------------

        public static void UpdateID(int id)
        {
            string update = $"UPDATE Users SET [Id] = 'Id - 1' WHERE [Id] > '{id}'";
            SqlCommand command = new SqlCommand(update, SqlConnection_connection);
            command.ExecuteNonQuery();
        }

        public static void UpdateID(int[] IDs)
        {
            foreach (int id in IDs)
            {
                string update = $"UPDATE Users SET [Id] = 'Id - 1' WHERE [Id] > '{id}'";
                SqlCommand command = new SqlCommand(update, SqlConnection_connection);
                command.ExecuteNonQuery();
            }
        }

        //----------------------------------------------

        public static void Delete(string category, string text) 
        {
            string delete = $"DELETE FROM Users WHERE {category} = N'{text}'";
            SqlCommand command = new SqlCommand(delete, SqlConnection_connection);
            command.ExecuteNonQuery();
        }

    }
}
