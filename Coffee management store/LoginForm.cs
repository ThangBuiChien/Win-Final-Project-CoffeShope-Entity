using Coffee_management_store.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_management_store
{
    public partial class LoginForm : Form
    {
        BLAccount dbAccount = new BLAccount();
        public LoginForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }
        public static bool bIslogin = false;
        public static string connsever = null;

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            lbUS.Visible = false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lbPW.Visible = false;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
           

            if (verif() == false)
            {
                MessageBox.Show("Please enter your account and password!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (radioManagerButton.Checked == false && radioEmployeeButton.Checked == false)
            {
                MessageBox.Show("Please select the permission to login!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string user = tbUsername.Text;
                    string pass = tbPassword.Text;
                    string role;
                    if (radioEmployeeButton.Checked == true)
                    {
                        role = "employee";
                    }
                    else
                    {
                        role = "manager";
                    }
                    SqlConnection con = new SqlConnection(@"Data Source=Cao;Initial Catalog=CoffeeShop;User ID= ManagerCao ;Password= passM1");

                    //Set DataSource
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand("select * from V_CheckAccount(@user,@pass,@role) ", con);//Username and Password
                    command.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
                    command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
                    command.Parameters.Add("@role", SqlDbType.NVarChar).Value = role;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    LoginForm.bIslogin = true;
                    if (table.Rows.Count == 0)
                    {
                       
                            MessageBox.Show("Please select the correct type of user for which your account is registered!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                            DialogResult = DialogResult.OK;
                    }
                    if (table.Rows.Count > 0)
                    {
                        if (radioEmployeeButton.Checked == true)
                        {
                            connsever = @"Data Source=CAO;Initial Catalog=CoffeeShop;User ID= EmployeeCao ;Password= passE1";
                        }
                        else
                        {
                            connsever = @"Data Source=Cao;Initial Catalog=CoffeeShop;User ID= ManagerCao ;Password= passM1";
                        }
                        con.Close();
                        con = null;
                        dbAccount.db.Connsever = connsever;
                        MainForm mainForm = new MainForm();
                        //MessageBox.Show(dbAccount.db.Connsever);
                        LoginForm.bIslogin = true;
                       
                        mainForm.ShowDialog();
                        Close();
                    }
                   
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }

         bool verif()
        {
            if(tbUsername.Text.Trim()==""||tbPassword.Text.Trim()=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
             
    }
}
