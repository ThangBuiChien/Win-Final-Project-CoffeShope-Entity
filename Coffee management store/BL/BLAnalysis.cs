using Coffee_management_store.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Coffee_management_store.BL
{
    class BLAnalysis
    {
        Database db = null;
        public BLAnalysis()
        {
            db = new Database();
        }
        
        public DataTable EmpMostSales(ref string err)
        {
            string mysql = "SELECT * FROM get_employee_with_most_sales()";
            return db.myExecuteFunction(mysql, out err);
        }

        public DataTable TopSalesIteam(/*string  dateStart,string dateEnd,*/ref string err)
        {
            string mysql = " SELECT*FROM sales_trends('2022-01-01', '2023-12-31')";
            return db.myExecuteFunction(mysql, out err);
        }

        public DataTable SearchNameDirnk(string Name, ref string err)
        {
            string mysql = $"SELECT * FROM Find_Drink('{Name}')";
            return db.myExecuteFunction(mysql, out err);
        }
        public DataTable EMPCalculatePR(ref string err)
        {
            string mysql = $"SELECT * from calculate_employee_productivity()";
            return db.myExecuteFunction(mysql, out err);
        }
        public DataTable ShopPR( ref string err)
        {
            string mysql = $"SELECT * FROM dbo.calculate_shop_profitability()";
            return db.myExecuteFunction(mysql, out err);
        }
    

    }
}
