using Coffee_management_store.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_management_store.DB;

namespace Coffee_management_store.BL
{
    internal class BLMenu
    {
        Database db = null;
        public BLMenu()
        {
            db = new Database();
        }
        public DataSet Loadmenu()
        {
            return db.ExecuteQueryDataSet("Select * from Menu", CommandType.Text);
        }
        public bool addmenu(string ID, string Name, string Des, string Img, int Price, ref string err)
        {
            string sql = $"EXEC dbo.add_menu @dID = N'{ID}',@name = N'{Name}',@description = N'{Des}',@img = N'{Img}', @prices = {Price}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool deletemenu(string ID, ref string err)
        {
            string sql = $"EXEC dbo.delete_menu @dID = N'{ID}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool updatemenu(string ID, string Name, string Des, string Img, int Price, ref string err)
        {
            string sql = $"EXEC dbo.update_menu @dID = N'{ID}',@name = N'{Name}',@description = N'{Des}',@img = N'{Img}', @prices = {Price}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}
