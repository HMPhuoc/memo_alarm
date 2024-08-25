using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using memo.SQLite;

namespace memo.DAL
{
    internal class MemoOnceBLL
    {
        MemoOnceDAL db = new MemoOnceDAL();
        public MemoOnceBLL() { }

        public void createTable()
        {
            db.createTable();
        }
        public DataTable getDataDAL()
        {
            return db.loadData();
        }
        public void updateTable(DataTable ChangedTable)
        {
            db.updateTable(ChangedTable);
        }
    }
}
