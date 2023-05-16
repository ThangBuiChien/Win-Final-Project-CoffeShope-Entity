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
    class BLAccount
    {

        public Database db = null;
        public BLAccount()
        {
            db = new Database();
        }
        public DataSet GetAccount()
        {
            return db.ExecuteQueryDataSet("select * from Account", CommandType.Text);
        }

        public bool AddAccount(string AccountID,string User,string Pass,string Statification,int Active, ref string err)
        {
            string sql = $"EXEC dbo.Add_Account @E_ID = N'{AccountID}',@Username= N'{User}' ,@Password = N'{Pass}',@Active = {Active} ,@Stratification= N'{Statification}' ";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool UpdateAccount(string AccountID, string User, string Pass, string Statification, int Active, ref string err)
        {
            string sql = $"EXEC dbo.Update_Account @E_ID = N'{AccountID}',@Username= N'{User}' ,@Password = N'{Pass}',@Active = {Active} ,@Stratification= N'{Statification}' ";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public void getStr(string namerole)
        {

        }

    }
}
