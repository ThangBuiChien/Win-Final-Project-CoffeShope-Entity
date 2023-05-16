using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Coffee_management_store.BL;
using static System.Net.WebRequestMethods;

namespace Coffee_management_store
{
    public partial class EmployeeForm : Form
    {   
        DataTable tbEmployee = null;
        bool Add;
        string err;
        BLEmployee dbEmployee = new BLEmployee();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                tbEmployee = new DataTable();
                tbEmployee.Clear();
                DataSet dataSet = dbEmployee.GetEmployee();
                tbEmployee = dataSet.Tables[0];
                // push on data GRV
                dataGridViewEmployee.DataSource = tbEmployee;
                // chang size table
                dataGridViewEmployee.AutoResizeColumns();
                //
                dataGridViewEmployee_CellContentClick(null, null);
                Add = true;
            }
            catch
            {
                MessageBox.Show("Dose not take Data. Eror!!!");
            }
        }
        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridViewEmployee.CurrentCell.RowIndex;
            tbID.Text = dataGridViewEmployee.Rows[r].Cells[0].Value.ToString();
            tbDateSt.Text = dataGridViewEmployee.Rows[r].Cells[1].Value.ToString();
            tbName.Text = dataGridViewEmployee.Rows[r].Cells[2].Value.ToString();
            tbPosition.Text = dataGridViewEmployee.Rows[r].Cells[3].Value.ToString();
            tbSalary.Text = dataGridViewEmployee.Rows[r].Cells[4].Value.ToString();
            tbGmail.Text = dataGridViewEmployee.Rows[r].Cells[5].Value.ToString();
            tbPhone.Text = dataGridViewEmployee.Rows[r].Cells[6].Value.ToString();
            tbStatus.Text = dataGridViewEmployee.Rows[r].Cells[7].Value.ToString();
           
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show("are you sure?", "Trả lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
                Close();
        }
        private void ptbSearchEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string strEmpName = tbSearchEmployee.Text; ;
                dataGridViewEmployee.DataSource = this.dbEmployee.FindEmployee(strEmpName, ref err);
                string totalday = dbEmployee.totalday(strEmpName,ref err) + " day " + dbEmployee.totalmonth(strEmpName,ref err) +" month" ;
                tbTotalDayworking.Text = totalday;
            }
            catch
            {
                MessageBox.Show($"Error Find: {err}");
            }
            finally
            {
            }
        }
        private void ptbAdd_Click(object sender, EventArgs e)
        {   
            if (Add)
            {
                try
                {
                    // Thực hiện lệnh 
                    BLEmployee blemp = new BLEmployee();
                    if(tbSalary.Text == "")
                    {
                        tbSalary.Text = "0";
                    }
                    blemp.ADDEmployee(tbID.Text, DateTime.Parse(this.tbDateSt.Text), tbName.Text, tbPosition.Text, Int32.Parse(tbSalary.Text), tbGmail.Text, Int32.Parse(tbPhone.Text), tbStatus.Text, ref err);           // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLEmployee blemp = new BLEmployee();
                blemp.ADDEmployee(tbID.Text, DateTime.Parse(this.tbDateSt.Text), tbName.Text, tbPosition.Text, Int32.Parse(tbSalary.Text), tbGmail.Text, Int32.Parse(tbPhone.Text), tbStatus.Text, ref err);           // Load lại dữ liệu trên DataGridView 

            }
            // Load lại dữ liệu trên DataGridView 
            LoadData();
            // Thông báo 
            MessageBox.Show("Đã sửa xong!");
        }
        private void ptbFix_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    // Thực hiện lệnh 
                    BLEmployee blemp = new BLEmployee();
                    if (tbSalary.Text == "")
                    {
                        tbSalary.Text = "0";
                    }
                    bool isSuccess = blemp.UpdateEMP(tbID.Text, DateTime.Parse(this.tbDateSt.Text), tbName.Text, tbPosition.Text, Int32.Parse(tbSalary.Text), tbGmail.Text, Int32.Parse(tbPhone.Text), tbStatus.Text, ref err);           // Load lại dữ liệu trên DataGridView 
                    
                    if (isSuccess)
                    {
                        MessageBox.Show("Employee deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error deleting employee: {err}");
                    }
                    LoadData();
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Error data!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLEmployee blemp = new BLEmployee();
                blemp.UpdateEMP(tbID.Text, DateTime.Parse(this.tbDateSt.Text), tbName.Text, tbPosition.Text, Int32.Parse(tbSalary.Text), tbGmail.Text, Int32.Parse(tbPhone.Text), tbStatus.Text, ref err);           // Load lại dữ liệu trên DataGridView 

            }
            // Load lại dữ liệu trên DataGridView 
            LoadData();
            // Thông báo 
            MessageBox.Show("Update Successfully!");
        }
        private void ptbDelete_Click(object sender, EventArgs e)
        {
            DialogResult answear;
            answear = MessageBox.Show(" Are you sure delete ?", "answear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answear == DialogResult.OK)
            {
                try
                {
                    int r = dataGridViewEmployee.CurrentCell.RowIndex;
                    string strEmpID = dataGridViewEmployee.Rows[r].Cells[0].Value.ToString();
                    
                    bool isSuccess = this.dbEmployee.DeleteEmployee(strEmpID, ref err);
                    if (isSuccess)
                    {
                        MessageBox.Show("Employee deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Error deleting employee: {err}");
                    }
                    LoadData();

                }
                catch
                {
                    MessageBox.Show(" error delete ");
                }
                finally
                {

                }
            }
        }
        private void ptbReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
