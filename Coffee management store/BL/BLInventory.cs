using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Coffee_management_store.DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Coffee_management_store.BL
{
    class BLInventory
    {
        Database db = null;
        public BLInventory()
        {
            db = new Database();
        }
        public DataSet GetInventory()
        {
            return db.ExecuteQueryDataSet("select * from Inventory", CommandType.Text);
        }

        public bool DeleteInventory(string inventoryId, ref string err)
        {
            string sql = $"EXEC dbo.Delete_Inventory @dID = N'{inventoryId}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
           
        }
        public bool UpdateInventory(string inventoryId, int newAmount, int newBuyingPrice, ref string err)
        {
            string sql = $"EXEC dbo.Update_Inventory @amount = {newAmount},@buying_price ={newBuyingPrice},@dID = N'{inventoryId}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool AddInventory(string inventoryId,string supplierID, int newAmount, int newBuyingPrice, ref string err)
        {
            string sql = $"EXEC dbo.AddInventoryProduct @amount = {newAmount},@buyingPrice ={newBuyingPrice},@dID = N'{inventoryId}',@supplier_ID = N'{supplierID}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }



    }
}
