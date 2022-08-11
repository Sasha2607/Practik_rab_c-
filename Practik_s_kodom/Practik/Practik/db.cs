using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practik
{
    class db
    {
        public SQLiteConnection DBConnection = new SQLiteConnection(@"Data Source=""" + Environment.CurrentDirectory + @"\database.db"";Version=3;");

        public string DBError;







        public string DateFormat(string date, bool reverse = false)
        {
            // dd.mm.yyyy -> yyyy-mm-dd
            char s;
            if (reverse) s = '-';
            else s = '.';

            date = date.Split(' ')[0];

            if (date.IndexOf(s) >= 0) return date.Split(s)[2] + "-" + date.Split(s)[1] + "-" + date.Split(s)[0];
            return date;
        }


        public DataTable Select(string SqlQuery)
        {
            DataTable dt = new DataTable();

            try
            {
                DBConnection.Open();
                SQLiteDataAdapter SDA = new SQLiteDataAdapter(SqlQuery, DBConnection);
                SQLiteCommandBuilder SCB = new SQLiteCommandBuilder(SDA);
                SDA.Fill(dt);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
            }

            DBConnection.Close();
            return dt;
        }

        public bool InsertInto(string table, List<string> cols, List<string> values)
        {
            DBConnection.Open();

            string val = "";
            string col = "";
            int i;

            for (i = 0; i < values.Count(); i++)
            {
                val += "@" + cols[i];
                if (i < (values.Count() - 1)) val += ",";

                col += cols[i];
                if (i < (values.Count() - 1)) col += ",";
            }

            string sql = "INSERT INTO " + table + " (" + col + ") VALUES (" + val + ")";

            SQLiteCommand command;

            try
            {
                command = new SQLiteCommand(sql);
                command.Connection = DBConnection;
                for (i = 0; i < values.Count(); i++)
                {
                    command.Parameters.AddWithValue("@" + cols[i], values[i]);
                }
                command.ExecuteNonQuery();
                DBConnection.Close();
                return true;
            }
            catch
            {
                DBConnection.Close();
                return false;
            }
        }
        public bool Update(string table, string set, string where)
        {
            DBConnection.Open();

            string sql = "UPDATE " + table + " SET " + set + " WHERE " + where + "";

            SQLiteCommand command;

            try
            {
                command = new SQLiteCommand(sql, DBConnection);
                command.ExecuteNonQuery();
                DBConnection.Close();
                return true;
            }
            catch
            {
                DBConnection.Close();
                return false;
            }
        }

        public bool Delete(string table, string where)
        {
            DBConnection.Open();

            string sql = "DELETE FROM " + table + " WHERE " + where + "";

            SQLiteCommand command;

            try
            {



                command = new SQLiteCommand(DBConnection);
                command.CommandText = "PRAGMA foreign_keys=ON";
                command.ExecuteNonQuery();
                command.CommandText = sql;
                command.ExecuteReader();
                DBConnection.Close();
                return true;
            }
            catch
            {
                DBConnection.Close();
                return false;
            }
        }


        public void SaveExcel(string sql)
        {


            string file_name;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы Excel (.xlsx, .xls)|*.xlsx;*.xls, ";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_name = saveFileDialog.FileName;
            }
            else
            {
                return;
            }

            XLWorkbook wb = new XLWorkbook();
            DataTable dt =  Select(sql);
            wb.Worksheets.Add(dt, "Таблица");
            wb.SaveAs(file_name);

            MessageBox.Show("Таблица конвертирована в файл Excel");

        
        }

    }
}
