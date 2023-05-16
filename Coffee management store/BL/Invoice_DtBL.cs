using Coffee_management_store.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_management_store.BL
{
    class Invoice_DtBL
    {
        Database db = null;

        public Invoice_DtBL()
        {
            db = new Database();
        }

        public DataSet Loadinvoice()
        {
            string sql = "Select * from invoice";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet Loadinvoicedetail(string Iid)
        {
            string sql = $"Select Products From PrintInvoice where I_ID = N'{Iid}'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public bool ViewInDt(string Iid, ref string err)
        {
            string sql = $"Select Products From PrintInvoice where I_ID = N'{Iid}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool AddInDt(string Iid, string Did, int quantity, ref string err)
        {
            string sql = $"EXEC dbo.Add_Invoice_detail @I_ID = N'{Iid}', @D_ID = N'{Did}', @quality = {quantity}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool DelInDt(string Did, ref string err)
        {
            string sql = $"EXEC dbo.delete_InvoiceDetail @D_ID = N'{Did}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool UpEmp(string Iid, string idemp, ref string err)
        {
            string sql = $"UPDATE dbo.Invoice SET employee_ID = N'{idemp}' WHERE I_ID = N'{Iid}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool UpCus(string Iid, string idCus, ref string err)
        {
            string sql = $"UPDATE dbo.Invoice SET customer_ID = N'{idCus}' WHERE I_ID = N'{Iid}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool FiInv(string Iid, ref string err)
        {
            string sql = $"UPDATE dbo.Invoice SET  final_total = initial_total - (initial_total * coupon) WHERE I_ID = N'{Iid}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool UpCP(string Iid, float coupon, ref string err)
        {
            string sql = $"UPDATE dbo.Invoice SET coupon = {coupon} WHERE I_ID = N'{Iid}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool UpDeli(string Iid, string delivery, ref string err)
        {
            string sql = $"UPDATE dbo.Invoice SET delivery = N'{delivery}' WHERE I_ID = N'{Iid}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool AddIn(string Iid, ref string err)
        {
            string sql = $"EXEC dbo.add_invoice @id = N'{Iid}',@idemp = Null,@idcus = Null,@delivery = Null,@cp = Null";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool DelIn(string Iid, ref string err)
        {
            string sql = $"EXEC dbo.delete_invoice @id = N'{Iid}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }

 }
