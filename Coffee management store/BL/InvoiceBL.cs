using Coffee_management_store.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_management_store.BL
{
    class InvoiceBL
    {
        Database db = null;

        public InvoiceBL()
        {
            db = new Database();
        }
        public DataSet Loadinvoice()
        {
            string sql = "Select * from invoice";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public bool DeleteInvoice(string Iid, ref string err)
        {
            string sql = $"EXEC dbo.delete_invoice @id = N'{Iid}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}
