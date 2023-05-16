using Coffee_management_store.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_management_store.BL
{
    class SupplyBL
    {
        Database db = null;

        public SupplyBL()
        {
            db = new Database();
        }
        public DataSet LoadSupply()
        {
            return db.ExecuteQueryDataSet("Select * from Supplier_Detail", CommandType.Text);
        }

        public bool addSupply(string Sid, string Sname, string address, ref string err)
        {
            string sql = $"EXEC dbo.add_supplier_detail @S_ID = N'{Sid}', @S_Name = N'{Sname}',@S_Address = N'{address}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool delSupply(string Sid, ref string err)
        {
            string sql = $"EXEC dbo.Delete_supplier_detail @supplier_id = N'{Sid}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool upSupply(string Sid, string Sname, string address, ref string err)
        {
            string sql = $"EXEC dbo.update_supplierdetail @supplier_id = N'{Sid}', @supply_name = N'{Sname}',@supply_address = N'{address}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

    }
}
