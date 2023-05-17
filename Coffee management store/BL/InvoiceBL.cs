using Coffee_management_store.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_management_store.BL
{
    class InvoiceBL
    {
        //done 




        Database db = null;

        public InvoiceBL()
        {
            db = new Database();
        }
        /*public DataSet Loadinvoice()
        {
            string sql = "Select * from invoice";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }*/
        public DataTable Loadinvoice()
        {
            QLCoffeEntities qlbhEntity = new QLCoffeEntities();
            var tps =
            from p in qlbhEntity.Invoices
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("I_ID");
            dt.Columns.Add("IDate");
            dt.Columns.Add("customer_ID");
            dt.Columns.Add("shop_ID");
            dt.Columns.Add("coupon");
            dt.Columns.Add("initial_total");
            dt.Columns.Add("discount");
            dt.Columns.Add("delivery");
            dt.Columns.Add("employee_ID");
            dt.Columns.Add("final_total");


            foreach (var p in tps)
            {
                dt.Rows.Add(p.I_ID, p.IDate, p.customer_ID, p.shop_ID, p.coupon, p.initial_total, p.discount, p.delivery, p.employee_ID,p.final_total);
            }
            return dt;
        }

        public bool DeleteInvoice(string Iid, ref string err)
        {
            /*string sql = $"EXEC dbo.delete_invoice @id = N'{Iid}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);*/

            try
            {
                using (var qlCoffeEntities = new QLCoffeEntities())
                {
                    qlCoffeEntities.delete_invoice(Iid);
                    qlCoffeEntities.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}
