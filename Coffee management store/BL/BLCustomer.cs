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
        Database db = null;
        public BLCustomer()
        {
            db = new Database();
        }
        public DataSet GetCustomer()
        {
            return db.ExecuteQueryDataSet("select * from Customer", CommandType.Text);
        }

        public bool AddCustomer(string customerId,string customername,  out string errorMessage)
        {
            return this.db.AddCustomer(customerId,customername, out errorMessage);
        }

        internal bool AddCustomer(string cID, string cName, object point, out string errorMessage)
        {
            throw new NotImplementedException();
        }
    }
}
