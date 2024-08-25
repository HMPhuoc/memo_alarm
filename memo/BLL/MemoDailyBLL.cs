using memo.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memo.SQLite;

namespace memo.DAL
{
    class MemoDailyBLL
    {
        MemoDailyDAL db = new MemoDailyDAL();
        public MemoDailyBLL() { }

        public void createTable()
        {
            db.createTable();
        }
        public DataTable getDataDAL()
        {
            return db.loadData2();
        }
        public void updateTable(DataTable ChangedTable)
        {
            db.updateTable(ChangedTable);
        }
    }
}
