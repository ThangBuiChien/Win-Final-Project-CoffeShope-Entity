using Coffee_management_store.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Coffee_management_store.BL
{
    class BLAnalysis
    {
        //not done
        Database db = null;
        public BLAnalysis()
        {
            db = new Database();
            
        }
        
        public DataTable EmpMostSales(ref string err)
        {
            /*string mysql = "SELECT * FROM get_employee_with_most_sales()";
            return db.myExecuteFunction(mysql, out err);*/

            QLCoffeEntities qlbhEntity = new QLCoffeEntities();
            var tps =
            from p in qlbhEntity.get_employee_with_most_sales()
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("EID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Total Sale");
            

            foreach (var p in tps)
            {
                dt.Rows.Add(p.E_ID, p.Name, p.TotalSales);
            }
            return dt;
        }

        public DataTable TopSalesIteam(/*string  dateStart,string dateEnd,*/ref string err)
        {
            /*string mysql = " SELECT*FROM sales_trends('2022-01-01', '2023-12-31')";
            return db.myExecuteFunction(mysql, out err);*/


            QLCoffeEntities qlbhEntity = new QLCoffeEntities();
            var tps =
            from p in qlbhEntity.sales_trends(new DateTime(2020, 1, 01), new DateTime(2023, 12, 31))
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("product_name");
            dt.Columns.Add("total sales");
            dt.Columns.Add("peak sales times");
            dt.Columns.Add("peak sales days");
            dt.Columns.Add("top customer name");
            dt.Columns.Add("top customer total");




            foreach (var p in tps)
            {
                dt.Rows.Add(p.product_name, p.total_sales, p.peak_sales_time, p.peak_sales_day, p.top_customer_name, p.top_customer_total);
            }
            return dt;

            
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
