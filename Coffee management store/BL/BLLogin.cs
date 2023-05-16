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
using System.Security.Cryptography;

namespace Coffee_management_store.BL
{
    class BLLogin
    {
        Database db = null;
        public BLLogin()
        {
            db = new Database();
        }

        public bool  checkAccount(string user,string pass, ref string err)
        {
            string mysql = $"SELECT * FROM Customer_Employee_IDs";
            return db.MyExecuteNonQuery(mysql, CommandType.Text, ref err);
        }
    }
}
