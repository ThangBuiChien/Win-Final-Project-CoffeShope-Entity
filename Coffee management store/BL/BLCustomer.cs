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
    internal class BLCustomer
    {
        //done 


        Database db = null;
        public BLCustomer()
        {
            db = new Database();
        }
        /*public DataSet GetCustomer()
        {
            return db.ExecuteQueryDataSet("select * from Customer", CommandType.Text);
        }
*/
        public DataTable GetCustomer()
        {
            QLCoffeEntities qlbhEntity = new QLCoffeEntities();
            var tps =
            from p in qlbhEntity.Customers
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Cus-ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Point");
            dt.Columns.Add("Rank");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.cID, p.cName, p.point, p.cRank);
            }
            return dt;
        }

        /*public bool AddCustomer(string customerId,string customername,  out string errorMessage)
        {
            return this.db.AddCustomer(customerId,customername, out errorMessage);
        }*/
        public bool AddCustomer(string customerId, string customername, ref string err)
        {
            QLCoffeEntities qlbhEntity = new QLCoffeEntities();

           Customer cs = new Customer();
            cs.cID = customerId;
            cs.cName = customername;
            qlbhEntity.Customers.Add(cs);
            qlbhEntity.SaveChanges();

            return true;

        }

        /*internal bool AddCustomer(string cID, string cName, object point, out string errorMessage)
        {
            throw new NotImplementedException();
        }*/
    }
}
