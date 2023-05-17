using Coffee_management_store.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_management_store.DB;
using System.Net;
using System.Security.Cryptography;

namespace Coffee_management_store.BL
{
    internal class BLMenu
    {

        //done
           

        Database db = null;
        public BLMenu()
        {
            db = new Database();
        }
       /* public DataSet Loadmenu()
        {
            return db.ExecuteQueryDataSet("Select * from Menu", CommandType.Text);
        }
        
        public bool addmenu(string ID, string Name, string Des, string Img, int Price, ref string err)
        {
            string sql = $"EXEC dbo.add_menu @dID = N'{ID}',@name = N'{Name}',@description = N'{Des}',@img = N'{Img}', @prices = {Price}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool deletemenu(string ID, ref string err)
        {
            string sql = $"EXEC dbo.delete_menu @dID = N'{ID}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        public bool updatemenu(string ID, string Name, string Des, string Img, int Price, ref string err)
        {
            string sql = $"EXEC dbo.update_menu @dID = N'{ID}',@name = N'{Name}',@description = N'{Des}',@img = N'{Img}', @prices = {Price}";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }*/
        public DataTable Loadmenu()
        {
            QLCoffeEntities qlCoffeEntities = new QLCoffeEntities();
            var tps =
            from p in qlCoffeEntities.Menus
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("description");
            dt.Columns.Add("Images");
            dt.Columns.Add("Prices");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.dID, p.mName, p.mDescription, p.img_path, p.prices);
            }
            return dt;
        }

        public bool addmenu(string ID, string Name, string Des, string Img, int Price, ref string err)
        {
            /* QLCoffeEntities qlCoffeEntities = new QLCoffeEntities();

             Menu mn = new Menu();
             mn.dID = ID;
             mn.mName = Name;
             mn.mDescription = Des;
             mn.img_path = Img;
             mn.prices = Price;
             qlCoffeEntities.Menus.Add(mn);
             qlCoffeEntities.SaveChanges();

             return true;*/
            try
            {
                using (var qlCoffeEntities = new QLCoffeEntities())
                {
                    qlCoffeEntities.add_menu(ID, Name, Des, Img, Price);
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
        public bool deletemenu(string ID, ref string err)
        {
            QLCoffeEntities qlCoffeEntities = new QLCoffeEntities();
            Menu mn = new Menu();
            mn.dID = ID;
            qlCoffeEntities.Menus.Attach(mn);
            qlCoffeEntities.Menus.Remove(mn);
            qlCoffeEntities.SaveChanges();
            return true;
        }

        public bool updatemenu(string ID, string Name, string Des, string Img, int Price, ref string err)
        {
            QLCoffeEntities qlCoffeEntities = new QLCoffeEntities();
            var mnQuery = (from mn in qlCoffeEntities.Menus
                           where mn.dID == ID
                           select mn).SingleOrDefault();
            if (mnQuery != null)
            {
                mnQuery.mName = Name;
                mnQuery.mDescription = Des;
                mnQuery.img_path = Img;
                mnQuery.prices = Price;
                qlCoffeEntities.SaveChanges();
            }
            return true;
        }
    }
}
