using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace memo.SQLite
{
    internal class MemoOnceDAL
    {
        SQLiteConnection conn = new SQLiteConnection();
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder();
        string connString = "Data Source=myDB.sqlite;Version=3;";
        public void Connect()
        {
            conn.ConnectionString = connString;
            cmd.Connection = conn;
            commandBuilder.DataAdapter = adapter;
            conn.Open();

        }

        public void Close()
        {
            conn.Close();
        }
        public void createTable()
        {
            string sql = "create table if not exists worklistonce(ID1 integer primary key autoincrement, WorkName1 varchar(50), WorkTime1 datetime)";
            Connect();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();            

        }
        public void createTable2()
        {
            string sql = "create table if not exists worklistdaily(ID2 integer primary key autoincrement, WorkName2 varchar(50), WorkTime2 time)";
            Connect();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }
        public DataTable loadData()
        {
            DataTable dt = new DataTable();
            Connect();
            string sql = "select * from worklistonce";
            cmd.CommandText = sql;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            Close();
            return dt;
        }

        public DataTable loadData2()
        {
            DataTable dt = new DataTable();
            Connect();
            string sql = "select * from worklistdaily";
            cmd.CommandText = sql;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            Close();
            return dt;
        }

        public void updateTable(DataTable ChangedTable)
        {
            Connect();
            adapter.Update(ChangedTable);
            Close();
        }

        public void updateTable2(DataTable ChangedTable2)
        {
            Connect();
            adapter.Update(ChangedTable2);
            Close();
        }
    }

    
    
}
