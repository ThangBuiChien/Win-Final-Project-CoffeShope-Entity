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
using System.Security.Principal;
using static System.Windows.Forms.AxHost;
using System.Net;
using System.Security.Cryptography;

namespace Coffee_management_store.BL
{
    class BLAccount
    {
        //done


        public Database db = null;
        public BLAccount()
        {
            db = new Database();
        }
        /*public DataSet GetAccount()
        {
            return db.ExecuteQueryDataSet("select * from Account", CommandType.Text);
        }*/
        public DataTable GetAccount()
        {
           QLCoffeEntities qlbhEntity = new QLCoffeEntities();
            var tps =
            from p in qlbhEntity.Accounts
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("AccountID");
            dt.Columns.Add("User");
            dt.Columns.Add("Pass");
            dt.Columns.Add("Statification");
            dt.Columns.Add("Active");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.E_ID, p.username, p.password, p.statification, p.active);
            }
            return dt;
        }
        public bool AddAccount(string AccountID, string User, string Pass, string Statification, int Active, ref string err)
        {
            string sql = $"EXEC dbo.Add_Account @E_ID = N'{AccountID}',@Username= N'{User}' ,@Password = N'{Pass}',@Active = {Active} ,@Stratification= N'{Statification}' ";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        /* public bool UpdateAccount(string AccountID, string User, string Pass, string Statification, int Active, ref string err)
         {
             string sql = $"EXEC dbo.Update_Account @E_ID = N'{AccountID}',@Username= N'{User}' ,@Password = N'{Pass}',@Active = {Active} ,@Stratification= N'{Statification}' ";
             return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
         }*/

        public bool UpdateAccount(string AccountID, string User, string Pass, string Statification, bool Active, ref string err)
        {
            /*QLCoffeEntities qlbhEntity = new QLCoffeEntities();
            var tpQuery = (from tp in qlbhEntity.Accounts
                           where tp.E_ID == AccountID
                           select tp).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.username = User;
                tpQuery.password = Pass;
                tpQuery.statification = Statification;
                tpQuery.active = Active;

                qlbhEntity.SaveChanges();
            }
            return true;*/

            try
            {
                using (var qlCoffeEntities = new QLCoffeEntities())
                {
                    qlCoffeEntities.updateAccount(AccountID, User, Pass, Statification, Active);
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
        


        public void getStr(string namerole)
        {

        }

    }
}
