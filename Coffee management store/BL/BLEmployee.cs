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
    class BLEmployee
    {
        //not done


        Database db = null;
        public BLEmployee()
        {
            db = new Database();
        }

        public DataTable GetID_C_E()
        {
           /* string mysql = $"SELECT * FROM Customer_Employee_IDs";
            return db.ExecuteQueryDataSet(mysql, CommandType.Text);*/

            QLCoffeEntities qlbhEntity = new QLCoffeEntities();
            var tps =
            from p in qlbhEntity.Customer_Employee_IDs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Table Name");
            

            foreach (var p in tps)
            {
                dt.Rows.Add(p.ID,p.Table_Name);
            }
            return dt;
        }
        public DataSet GetEmployee()
        {
            return db.ExecuteQueryDataSet("select * from Employee", CommandType.Text);
        }

        public bool DeleteEmployee(string employeeId, ref string err)
        {
            string sql = $"EXEC dbo.Delete_Employee @E_ID = N'{employeeId}'";
             return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
       

        public DataTable FindEmployee (string employeeName, ref string err)
        {
            string mysql = $"SELECT * FROM Find_Employee('{employeeName}')";
            return db.myExecuteFunction(mysql, out err);
        }

        public int totalday(string employeeName, ref string err)
        {
            string mysql = $"SELECT dbo.check_day('{employeeName}')";
            return db.myExcuteFunctionINT(mysql, ref err);
        }
        public int totalmonth(string employeeName, ref string err)
        {
            string mysql = $"SELECT dbo.check_month('{employeeName}')";
            return db.myExcuteFunctionINT(mysql, ref err);
        }
        public bool ADDEmployee(string ID, DateTime date, string Name, string position, int salary, string email, int phone, string status, ref string err)
        {
            if (salary == 0)
            {
                salary = 0;
            }
            string sql = $"EXEC dbo.AddEmployee @E_ID = N'{ID}',@start =N'{date}',@Name = N'{Name}',@position = N'{position}',@fixed_salary = {salary},@email = N'{email}', @phone_number = {phone},@status = N'{status}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public bool UpdateEMP(string ID, DateTime date, string Name, string position, int salary, string email, int phone, string status, ref string err)
        {   if(salary == 0)
            {
                salary = 0;
            }
            string sql = $"Use  CoffeeShop EXEC dbo.Update_Employee @E_ID = N'{ID}',@Start_Date =N'{date}',@Name = N'{Name}',@Position = N'{position}',@Fixed_Salary = {salary},@Email = N'{email}', @Phone_Number = {phone},@Status = N'{status}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}
