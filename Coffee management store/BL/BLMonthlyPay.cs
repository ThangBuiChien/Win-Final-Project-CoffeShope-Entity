using Coffee_management_store.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_management_store.BL
{
    class BLMonthlyPay
    {
        Database db = null;
        public BLMonthlyPay()
        {
            db = new Database();
        }
        public DataSet GetMonthlyPay()
        {
            return db.ExecuteQueryDataSet("select * from Monthly_pay", CommandType.Text);
        }



        public bool addMonthlyPay(string employeeId, DateTime date, int dayAbsent, int penalty,
            int toltalsalary, ref string errorMessage)
        {
            string sqlString = "addMonthlyPay";

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@E_ID", employeeId);
            parameters[1] = new SqlParameter("@Month", date);
            parameters[2] = new SqlParameter("@days_absent", dayAbsent);
            parameters[3] = new SqlParameter("@Penalty", penalty);
            parameters[4] = new SqlParameter("@TotalSalary", toltalsalary);

            return db.MyExecuteNonQueryParameter(sqlString, CommandType.Text, ref errorMessage, parameters);
        }

        public bool DeleteMonthlyPay(ref string err, string EID, DateTime date)
        {
            string sqlString = "deleteMonthlyPay";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@E_ID", EID);
            parameters[1] = new SqlParameter("@Month", date);
            return db.MyExecuteNonQueryParameter(sqlString, CommandType.Text, ref err, parameters);
        }

        public bool updateMonlyPay(string employeeId, DateTime date, int dayAbsent, int penalty
            , int toltalsalary, ref string err)
        {
            string sqlString = "changeMonthlyPay";

            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@E_ID", employeeId);
            parameters[1] = new SqlParameter("@Month", date);
            parameters[2] = new SqlParameter("@days_absent", dayAbsent);
            parameters[3] = new SqlParameter("@Penalty", penalty);
            parameters[4] = new SqlParameter("@TotalSalary", toltalsalary);

            return db.MyExecuteNonQueryParameter(sqlString, CommandType.Text, ref err, parameters);
        }
    }
}
